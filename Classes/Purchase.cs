using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace prjGrow.Classes
{
    public class Purchase: Journal
    {
        public long id { get; set; }
        public long sup_id { get; set; }
        public long bank_id { get; set; }
        public DateTime date { get; set; }
        public int discount { get; set; }
        public long paid { get; set; }
        public long term_id { get; set; }

        public string sup_name { get; set; }
        public string bank_name { get; set; }
        public long prod_id { get; set; }

        public long total = 0;
        public long remain = 0;
        public long freight = 0;

        public const string col_id = "id", col_sup_id = "Sup_id", col_bank_id = "Bank_id", col_date = "Date";
        public const string col_discount = "Discount", col_paid = "Paid";

        public long acc_id_pur = 0, acc_id_sup = 0, acc_id_bank = 0, acc_id_cash = 0, acc_id_pur_disct = 0;
        public DataTable tblIMEI = new DataTable();
        public Stock stock = new Stock();
        Imei imi = new Imei();
        public Bank_ledger bnk_led = new Bank_ledger();
        public Sup_ledger sup_led = new Sup_ledger();
        public Cheque cheq = new Cheque();
        public Sup_Orders sup_odr = new Sup_Orders();

        public DataTable tblCart = null;

        public void createCart()
        {
            tblCart = new DataTable();
            tblCart.Columns.Add(Purchase.col_sno, typeof(int));
            tblCart.Columns.Add(Product.col_prod_id, typeof(long));
            tblCart.Columns.Add(Product.col_code, typeof(string));
            tblCart.Columns.Add(Product.col_prod_name, typeof(string));
            if (Custom.mod_manufact)
            {
                tblCart.Columns.Add(Classes.Stock.col_cost, typeof(double));
                tblCart.Columns.Add(Classes.Stock.col_whole, typeof(double));
            }
            else
            {
                tblCart.Columns.Add(Classes.Stock.col_cost, typeof(long));
                tblCart.Columns.Add(Classes.Stock.col_whole, typeof(long));
            }
            tblCart.Columns.Add(Classes.Stock.col_retail, typeof(long));
            tblCart.Columns.Add(Classes.Stock.col_qty, typeof(float));
            tblCart.Columns.Add(Classes.Stock.col_amount, typeof(long));
            tblCart.Columns.Add(Stock.col_frieght, typeof(float));
            if (Custom.mod_bakers) tblCart.Columns.Add(Classes.Stock.col_expiry, typeof(DateTime));
        }

        public void getAccIds()
        {
            acc_id_pur = coa.getAccId(Constants.config_purchase);

            if (sup_id > 0)
            {
                acc_id_sup = coa.getAccId("Supplier", sup_id);
            }
            if (bank_id > 0)
            {
                acc_id_bank = coa.getAccId("Bank", bank_id);
            }
            else if (paid > 0)
                acc_id_cash = coa.getAccId(Constants.config_cash);

            if (discount > 0)
                acc_id_discount = coa.getAccId(Constants.config_pur_discount);
            
            if (!string.IsNullOrEmpty(cheq.cheq_no))
                acc_id_cheq = coa.getAccId(Constants.config_cheq_payment);

            if (freight > 0)
                acc_id_freight = coa.getAccId(Constants.config_frieght);
        }

        public bool SavePurchase()
        {
            tran_id = getTranidNext();
            getAccIds();
            db.Connect();
            SqlTransaction tran = db.con.BeginTransaction();
            try
            {
                result = addPurchase(tran, tran_id);
                stock.tran_id = tran_id;
                if (result)
                result = stock.savePurchaseStock(tran, tblCart);
                if (result)
                    result = debit(tran, date, narration, acc_id_pur, total);
                if (!string.IsNullOrEmpty(cheq.cheq_no) && bank_id > 0 && result)
                {
                    result = cheq.saveCheque(tran, tran_id);
                    if (result)
                        result = credit(tran, date, "Paid by cheque on Goods Purchase", acc_id_cheq, paid);
                }
                else if (bank_id > 0 && result)
                {
                    bnk_led.tran_id = tran_id;
                    bnk_led.bank_id = bank_id;
                    bnk_led.dr = 0;
                    bnk_led.cr = paid;
                    result = bnk_led.addBankLedger(tran);
                    if (result)
                        result = credit(tran, date, "Paid from Bank on Goods Purchase", acc_id_bank, paid);
                }
                else if (result)
                {
                    result = credit(tran, date, "Paid on " + narration, acc_id_cash, paid);
                }
                if (sup_id > 0 && result)
                {
                    sup_led.tran_id = tran_id;
                    sup_led.cr = total - discount - paid;
                    sup_led.dr = 0;
                    result = sup_led.addSupLedger(tran);
                    if (result)
                        result = credit(tran, date, "Remaining on " + narration, acc_id_sup, total - discount - paid);
                }
                if (discount > 0 && result)
                {
                    result = credit(tran, date, "Purchase Discount", acc_id_discount, discount);
                }
                if (freight > 0 && result)
                {
                    result = debit(tran, date, "Freight " + narration, acc_id_freight, freight);

                    if (bank_id > 0 && result)
                    {
                        bnk_led.dr = 0;
                        bnk_led.cr = freight;
                        result = bnk_led.addBankLedger(tran);
                        if (result)
                            result = credit(tran, date, "Paid Freight from Bank", acc_id_bank, freight);
                    }
                    else if (result)
                    {
                        result = credit(tran, date, "Paid for Freight " + narration, acc_id_cash, freight);
                    }
                }
                if (tblIMEI.Rows.Count > 0 && result)
                {
                    imi.tran_id = tran_id;
                    imi.dr = 1;
                    imi.cr = 0;
                    imi.saveIMEI(tblIMEI, tran);
                }
            }
            catch (Exception ex)
            {
                result = false;
            }
            finally
            {
                db.con.Close();
                if (result)
                {
                    tran.Commit();
                    sup_odr.reciveOrder(tblCart, sup_id);
                }
                else
                    tran.Rollback();
                setMessage("Stock Purchase", "Saved");
            }
            return result;
        }

        public bool addPurchase(SqlTransaction tran, long tranId)
        {
            db.query = "Insert into Purchase(sup_id, bank_id, date, discount, paid, tran_id, uid)" + sqlLine;
            db.query += "values(" + sup_id + "," + bank_id + ",'" + date.ToShortDateString() + "'," + discount + ", " + paid + "," + tran_id + "," + User.curUid + ")" + sqlLine;

            return db.runQuery();
        }

        public DataRow getPurchase()
        {
            db.query = "select p.id as [" + col_id + "], p.sup_id as [" + col_sup_id + "], s.name as [" + Supplier.col_sup_name + "], p.bank_id as [" + col_bank_id + "]," + sqlLine;
            db.query += "b.name as [" + Bank.col_bank + "], p.tran_id as [" + col_tran_id + "], p.date as [" + col_date + "], p.discount as [" + col_discount +"]," + sqlLine;
            db.query += "p.paid as [" + col_paid + "], p.uid " + sqlLine;
            db.query += ", cq.cheq_no as ["+col_cheq_no+"] " + sqlLine;
            db.query += "from Purchase p left outer join Bank b on p.bank_id = b.id" + sqlLine;
            db.query += "left outer join Supplier s on p.sup_id = s.id" + sqlLine;
            db.query += "left outer join Cheque cq on p.tran_id = cq.tran_id" + sqlLine;
            db.query += "where p.status = " + Constants.status_active + " and p.id = " + this.id + sqlLine;
            
            DataTable tblTemp = db.getDataTable();
            if (tblTemp.Rows.Count > 0)
            {
                return tblTemp.Rows[0];
/*                id = Convert.ToInt64(row[col_id]);
                tran_id = Convert.ToInt64(row[col_tran_id]);
                date = Convert.ToDateTime(row[col_date]);
                sup_id = Convert.ToInt64(row[col_sup_id]);
                sup_name = sup_id > 0 ? row[Supplier.col_sup_name].ToString() : "";
                bank_id = Convert.ToInt64(row[col_bank_id]);
                bank_name = bank_id > 0 ? row[Bank.col_bank].ToString() : "";
                discount = Convert.ToInt32(row[col_discount]);
                paid = Convert.ToInt64(row[col_paid]);*/
            }
            else
            {
                msg = "Sorry, No Such a Bill Found";
                msg_type = Constants.message_info;
                result = false;
                return null;
            }
        }

        public void updatePurchase()
        {
            tran_id = getTranid(this.id, "Purchase");
            getAccIds();

            db.Connect();
            SqlTransaction tran = db.con.BeginTransaction();
            narration = "Purchase Edited";

            try
            {
                result = updPurchase(tran);

                if(result)
                    result = stock.deleteStockEntries(tran_id, tran);
                if(result)
                {
                    stock.tran_id = tran_id;
                    result = stock.savePurchaseStock(tran, tblCart);
                }

                if(result)
                    result = deleteTransaction(tran, "IMEI");
                
                if(result)
                    result = debit(tran, date, narration, acc_id_pur, total - discount);

                if(!string.IsNullOrEmpty(cheq.cheq_no) && result)
                {
                    result = cheq.saveCheque(tran, tran_id);
                    if (result)
                        result = credit(tran, date, "Paid by cheque on Goods Purchase", acc_id_bank, paid);
                }
                else if(bank_id > 0 && result)
                {
                    bnk_led.tran_id = tran_id;
                    bnk_led.bank_id = bank_id;
                    bnk_led.dr = 0;
                    bnk_led.cr = paid;
                    result = bnk_led.addBankLedger(tran);
                    if (result)
                        result = credit(tran, date, "Paid from Bank on Goods Purchase", acc_id_bank, paid);
                }
                else if(result)
                {
                    result = credit(tran, date, "Paid on Goods Purchase", acc_id_cash, paid);
                }
                if(sup_id > 0 && result)
                {
                    result = credit(tran, date, narration, acc_id_sup, total - discount - paid);
                }
                if(discount > 0)
                    result = credit(tran, date, "Discount on purchase", acc_id_pur_disct, discount);
                if(tblIMEI.Rows.Count > 0)
                {
                    imi.tran_id = tran_id;
                    imi.dr = 1;
                    imi.cr = 0;
                    imi.saveIMEI(tblIMEI, tran);
                }
            }
            catch(Exception ex)
            {
                result = false;
            }
            finally
            {
                if(result)
                    tran.Commit();
                else
                    tran.Rollback();
                db.con.Close();
                setMessage("Stock Purchase", "Updated");
            }
        }

        public bool updPurchase(SqlTransaction tran)
        {
            db.query = "update Purchase set" + sqlLine;
            db.query += "date = '" + date + "', discount = " + discount + ", paid = " + paid + "" + sqlLine;
            db.query += "where tran_id = " + tran_id + sqlLine;

            return db.runQuery(tran);
        }

        public void deletePurchase()
        {
            tran_id = getTranid(this.id, "Purchase");
            getAccIds();

            db.Connect();
            SqlTransaction tran = db.con.BeginTransaction();

            try
            {
                result = delPurchase(tran);
                
                if(result)
                    result = stock.deleteStockEntries(tran_id, tran);

                if (result)
                    result = deleteTransaction(tran,"IMEI", "Cheque");

                if (bank_id > 0 && result)
                {
                    result = bnk_led.deleteBankLedger( tran_id, tran);
                }

                if (sup_id > 0 && result)
                {
                    result = sup_led.removeLedger(tran_id, tran);
                }
            }
            catch (Exception ex)
            {
                result = false;
            }
            finally
            {
                if (result)
                    tran.Commit();
                else
                    tran.Rollback();
                db.closeCon();

                setMessage("Stock Purchase","Deleted");
            }
        }

        public bool delPurchase(SqlTransaction tran)
        {
            db.query += "update Purchase set status = " + Constants.status_deleted + sqlLine;
            db.query += "where tran_id = " + tran_id + sqlLine;

            return db.runQuery(tran);
        }
    }
}