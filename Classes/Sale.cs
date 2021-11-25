using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Printing;
using prjGrow.Reporting;
using CrystalDecisions.CrystalReports.Engine;

namespace prjGrow.Classes
{
    public class Sale : Journal
    {
        public long id { get; set; }
        public DateTime date { get; set; }
        public int discount { get; set; }
        public long paid { get; set; }
        public string reference { get; set; }
        public long tot_cost { get; set; }
        public long total { get; set; }
        public long amount { get; set; }
        public long cus_id { get; set; }
        public long bank_id { get; set; }
        public long emp_id { get; set; }
        public long  adv { get; set; }
        public long prod_id { get; set; }
        public int year { get; set; }
        public short month { get; set; }
        public long paid_cash { get; set; }

        public static bool toSwitch = false;
        public long init_amt = 0;

        private long sale_ref_id = 0;
    //    private long acc_id_sale = 0, acc_id_discount = 0, acc_id_cash = 0, acc_id_cus = 0, acc_id_bank = 0;

        public const string col_bill_no = "Bill_No", col_date = "Date", col_total_amount = "Amount", col_paid = "Paid", col_credit = "Credit";
        public const string col_cus_id = "Cus_id", col_cus_name = "Customer Name", col_bank_id = "Bank_id", col_discount = "Discount";

        public Emp_ledger empLed = new Emp_ledger();
        public long cate = 0;

        public DataTable tblProducts = null, tblCart = new DataTable(), tblOrders = new DataTable();
        public DataTable tblIMEI = new DataTable();
        public DataTable tblEmp = new DataTable();

        Imei imi = new Imei();
        Delivery deliver = new Delivery();
        public Stock stock = new Stock();
        Cus_ledger cusLed = new Cus_ledger();
        Bank_ledger bankLed = new Bank_ledger();
        frmDisplayRep display = new frmDisplayRep("Invoice");
        clsReports reps = new clsReports();
        Product prod = new Product();
        Link_prod lnk = new Link_prod();

        public DataTable tblRaw = null;

        public void getAccIds()
        {
            sale_ref_id = db.getNextId("Sale");

            acc_id_sale = coa.getAccId(Constants.config_sale);

            if ( cus_id > 0 )
            {
                acc_id_cus = coa.getAccId("Customer", cus_id);
            }
            if (bank_id > 0)
            {
                acc_id_bank = coa.getAccId("Bank", bank_id);
            }
            else if (paid > 0)
                acc_id_cash = coa.getAccId(Constants.config_cash);

            if (discount > 0)
                acc_id_discount = coa.getAccId(Constants.config_discount);
            if (emp_id > 0)
            {
                acc_id_sal = coa.getAccId(Constants.config_employee);
                acc_id_emp = coa.getAccId("Employee", emp_id);
            }
            if (tblOrders.Rows.Count > 0)
            {
                acc_id_adv_order = coa.getAccId(Constants.config_adv_order);
            }
        }

        public void printBill()
        {
            string repName = "repSaleRecipt.rpt";
            if (Custom.client_id_active == 5)
                repName = "repSaleRecieptMed.rpt";
            else if (Custom.fet_item_dist)
                repName = "repSaleReciptD.rpt";

            db.query = "exec createSaleInvoice @tranId = " + tran_id + ", @accid = " + acc_id_cus;
            db.runQuery();
            if (mod_mobile)
            {
                db.query = "exec createImeiSale @tranId=" + tran_id;
                db.runQuery();
            }
            if (tblOrders.Rows.Count > 0)
            {
                long tmpAdv = Convert.ToInt64(tblOrders.Compute("Sum("+col_advance+")","").ToString());
                db.query = "insert into tmp_sale_invoice(prod_name, price, tran_id, cus_bal, adv_odr) values('',0,"+tran_id+", 0,"+tmpAdv+")";

                db.runQuery();
            }

            //reps.cryRpt.DataDefinition.FormulaFields[Client.col_quote].Text = client_qoute;
            ReportDocument rep = reps.getReport(repName);
            
            if(repName == "repSaleReciptD.rpt")
                rep.DataDefinition.FormulaFields[Client.col_quote].Text = "'" + client_qoute + "'";
            rep.PrintToPrinter(new PrinterSettings(), new PageSettings(), false);
        }

        public bool saveSale()
        {
            tran_id = getTranidNext();
            getAccIds();
            
            db.Connect();
            SqlTransaction tran = db.con.BeginTransaction();
            try
            {
                result = addSale(tran);                             ///sale sale info
                
                if (result && tblCart.Rows.Count > 0)
                    result = stock.saveSaleStock(tblCart, tran_id, tran);       ///save stock details
                if (result && (Custom.client_id_active == 5 || Custom.client_id_active == 2))
                    result = stock.saveRaw(tran, tblRaw, tran_id);
                if (result)
                    result = credit(tran, date, narration, acc_id_sale, total);     ///sale CEDIT
                
                if (discount > 0 && result)
                    result = debit(tran, date, "Discount on sale", acc_id_discount, discount);   //discount DEBIT
                
                if (bank_id > 0 && paid > 0 && result)                                     ///bank transactions
                {
                    bankLed.tran_id = tran_id;
                    bankLed.bank_id = bank_id;                                  ///save bank entry
                    bankLed.dr = paid;
                    bankLed.date = date;
                    result = bankLed.addBankLedger(tran);
                    if (result)
                        result = this.debit(tran, date, "To Bank on " + narration, acc_id_bank, paid);     //bank Debit
                }
                else if (paid > 0 && result)                                              ///cash transaction
                {
                    result = this.debit(tran, date, "To Cash on " + narration, acc_id_cash, paid);    //Cash Credit
                }
                if (cus_id > 0 && result)                ///Customer Ledger Transaction  && (total - discount - paid) > 0
                {
                    cusLed.tran_id = tran_id;
                    cusLed.cus_id = cus_id;                                     //Save Customer Ledger
                    cusLed.dr = total - adv - discount - paid;
                    cusLed.date = date;

                    if (result)
                        result = cusLed.addCusLedger(tran);
                    if(result)
                        result = this.debit(tran, date, "Credit on " + narration, acc_id_cus, (total - adv - discount - paid));   ///Account Recivable Debit
                }

                if (tblOrders.Rows.Count > 0 && result)
                {
                    result = this.debit(tran, date, "Advance on Order", acc_id_adv_order, adv);   ///Account Recivable Debit
                }

                if (tblIMEI.Rows.Count > 0 && result)                          //add IMEIs
                {
                    imi.tran_id = tran_id;
                    imi.dr = 0;
                    imi.cr = 1;
                    result = imi.saveIMEI(tblIMEI, tran);
                }

                if (tblOrders.Rows.Count > 0 && result)
                {
                    deliver.tran_id = tran_id;
                    result = deliver.saveDelivery(tran, tblOrders);
                }

                if (empLed.tblLabour.Rows.Count > 0 && result)
                {
                    empLed.acc_id_cash = acc_id_cash;
                    empLed.date = date;
                    empLed.tran_id = tran_id;
                    result = empLed.saveWages(tran);
                }

                if (Custom.client_id_active == 5 && emp_id > 0)
                {
                    empLed.acc_id_emp = acc_id_emp;
                    empLed.acc_id_sal = acc_id_sal;
                    empLed.date = date;
                    empLed.tran_id = tran_id;
                    result = empLed.saveBonus(tran, tblCart, emp_id);
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
            }
            setMessage("Sale", "Saved");
            return result;
        }

        public bool addSale(SqlTransaction tran)
        {
            db.query = "insert into sale(tran_id, date, discount, paid_amount, paid_cash, reference, bank_id, cus_id, uid)" + Environment.NewLine;
            db.query += "values(" + tran_id + ",'" + date + "'," + discount + "," + paid + ", " + paid_cash + ",'" + reference + "', "+bank_id+", "+cus_id+"," + User.curUid + ")";

            return db.runQuery(tran);
        }

        public bool updateBill()
        {
            tran_id = getTranid(id, "Sale");
            getAccIds();
            
            db.Connect();
            SqlTransaction tran = db.con.BeginTransaction();
            try
            {
                result = updateSale(tran);
                
                if(result)
                    result = stock.deleteStockEntries(tran_id, tran);
                
                //---------------Journal Entries-----------------------

                if (result)
                    result = deleteTransaction(tran, "IMEI", "Cus_Ledger");

                if (result)
                    result = credit(tran, date, "Goods Sale", acc_id_sale, total);     /// sale CEDIT
                
                if (discount > 0 && result)
                {
                    result = debit(tran, date, "Discount on sale", acc_id_discount, discount);   //discount DEBIT
                }
                if (bank_id > 0 && paid > 0 && result)                                     ///bank transactions
                {
                    result = this.debit(tran, date, "Sale Receipt to Bank", acc_id_bank, paid);     //bank Debit
                }
                else if (paid > 0 && result)                                              ///cash transaction
                {
                    result = this.debit(tran, date, "To Cash Acc on Sale", acc_id_cash, paid);    //Cash Credit
                }
                if (tblOrders.Rows.Count > 0 && result)
                {
                    result = this.debit(tran, date, "Advance on Order", acc_id_adv_order, adv);   ///Account Recivable Debit
                }
                if (cus_id > 0 && (total - discount - paid) > 0 && result)                ///Customer Ledger Transaction
                {
                    cusLed.tran_id = tran_id;
                    cusLed.cus_id = cus_id;                                     //Save Customer Ledger
                    cusLed.dr = total - discount - paid;
                    cusLed.date = date;
                    if (result)
                        result = cusLed.addCusLedger(tran);

                    result = this.debit(tran, date, "Sale on Credit", acc_id_cus, (total - discount - paid));   ///Account Recivable Debit
                }
                if (tblIMEI.Rows.Count > 0 && result)                                            //add IMEIs
                {
                    imi.tran_id = tran_id;
                    imi.dr = 0;
                    imi.cr = 1;
                    imi.saveIMEI(tblIMEI, tran);
                }
                if (result)
                    result = stock.saveSaleStock(tblCart, tran_id, tran);

                if (result && tblRaw != null)
                    result = stock.saveRaw(tran, tblRaw, tran_id);
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

                setMessage("Sale Bill", "Updated");
            }
            return result;
        }

        public bool deleteBill()
        {
            tran_id = getTranid(id, "Sale");

            db.Connect();
            SqlTransaction tran = db.con.BeginTransaction();
            try
            {
                if (cus_id > 0 && result)
                {
                    result = cusLed.deleteCusLedger(tran_id, tran);
                }
                if (bank_id > 0 && result)
                {
                    result = bankLed.deleteBankLedger(tran_id, tran);
                }
                
                if(result)
                    result = stock.deleteStockEntries( tran_id, tran);

                if(result)
                    result = deleteTransaction(tran, "IMEI");               //to delete from journal

                if(result)
                    result = deleteSale(tran);
                
            }
            catch (Exception ex)
            {
                result = false;
                tran.Rollback();
            }
            finally
            {
                if (result)
                    tran.Commit();
                else
                    tran.Rollback();
                db.closeCon();
                this.setMessage("Sale Bill", "Deleted");
            }
            return result;
        }

        public bool updateSale(SqlTransaction tran)
        {
            db.query = "Update Sale set " + sqlLine;
            db.query += " date = '"+date.ToShortDateString()+"', discount = "+discount+", paid_amount = "+paid+" " + sqlLine;
            db.query += " where id = " + id + sqlLine;

            return db.runQuery(tran);
        }

        public void showBill()
        {

            string repName = "repSaleRecipt.rpt";
            if (Custom.client_id_active == 5)
                repName = "repSaleRecieptMed.rpt";
            else if (Custom.fet_item_dist)
                repName = "repSaleReciptD.rpt";

            db.query = "exec createSaleInvoice @tranId = " + tran_id + ", @accid = " + acc_id_cus;
            db.runQuery();
            if (mod_mobile)
            {
                db.query = "exec createImeiSale @tranId=" + tran_id;
                db.runQuery();
            }

            ReportDocument rpt = reps.getReport(repName);
            if(repName == "repSaleRecieptD.rpt")
                rpt.DataDefinition.FormulaFields[Client.col_quote].Text = "'" + client_qoute + "'";
            display.rep = rpt;
            display.ShowDialog();
        }

        public bool deleteSale(SqlTransaction tran)
        {
            db.query = "Update Sale set status = " + Constants.status_deleted + " where id = " + id + sqlLine;

            return db.runQuery(tran);
        }

        public DataTable getSalesReceipts(Int64 customerid)
        {
            db.query = @"SELECT Sale.id AS [" + col_bill_no + "], Sale.date as [" + col_date + "] , Sale.cus_id as [" + col_cus_id + "], Sale.tran_id as [" + col_tran_id + "], Sale.Paid_Amount, SUM( dbo.Stock.cr*sold) as Bill_Amount" + sqlLine;
            db.query += "FROM dbo.Sale INNER JOIN dbo.Stock ON dbo.Sale.tran_id = dbo.Stock.tran_id " + sqlLine;
            db.query += "where Sale.status = " + Constants.status_active + " and Stock.status = " + Constants.status_active + sqlLine;
            db.query += " Group by dbo.Sale.id, dbo.Sale.date, dbo.Sale.cus_id, dbo.Sale.tran_id, dbo.Sale.paid_amount" + sqlLine;
            db.query += " Having (dbo.Sale.cus_id = " + customerid + ") ORDER BY [" + col_bill_no + "] DESC" + sqlLine;
            return db.getDataTable();
        }

        public DataTable getAllBills(DateTime date)    //get list of sales          DateTime billDate
        {
            db.query = "select sl.id as [" + col_bill_no + "], sl.date as [" + col_date + "], sl.cus_id  as [" + col_cus_id + "], cs.name as [" + col_cus_name + "]," + sqlLine;
            db.query += "sl.discount as [" + col_discount + "], sl.paid_amount as [" + col_paid + "], max(cost) as ["+Product.col_cost+"], " + sqlLine;
            db.query += "sum(st.cr * st.sold) - sl.discount - sl.paid_amount as [" + col_credit + "],sum(st.cr * st.sold) as [" + col_total_amount + "],  sl.bank_id as [" + col_bank_id + "], sl.tran_id as [" + col_tran_id + "]" + sqlLine;
            db.query += "from Sale sl inner join Stock st on sl.tran_id = st.tran_id" + sqlLine;
            db.query += "left outer join Customer cs on sl.cus_id = cs.id" + sqlLine;
            db.query += "where sl.status = " + Constants.status_active + " and st.status = " + Constants.status_active + sqlLine;
            db.query += prod_id > 0 ? "and st.prod_id = " + prod_id + " and sl.date between '" + month +"/01/" + year + "' and '" + ((month != 12) ? month + 1 : 1) + "/01/" + year + "'" + sqlLine : "";
            db.query += cus_id > 0 ? "and sl.cus_id = " + cus_id + sqlLine : "";
            db.query += prod_id == 0 && cus_id == 0 ? "and sl.date between '" + date.ToShortDateString() + " 00:00:00' and '" + date.ToShortDateString() + " 23:59:59 " + "'" + sqlLine : "";
            db.query += "group by sl.id, sl.date, cs.id, cs.name, sl.paid_amount, sl.bank_id, sl.discount, sl.tran_id, sl.cus_id" + sqlLine;
            db.query += "order by sl.id desc" + sqlLine;
            
            return db.getDataTable();
        }

        public void createRaw()
        {
            DataTable tblTmp = new DataTable();
            tblRaw = new DataTable();

            foreach (DataRow row in tblCart.Rows)
            {
                if (Convert.ToInt16(row[Product.col_cate]) == Constants.cate_service)
                {
                    int tmpQty = Convert.ToInt32(row[Product.col_qty]);
                    tblTmp = lnk.getLinkProd(Convert.ToInt64(row[Product.col_prod_id]), tmpQty);

                    if (tblTmp.Rows.Count > 0)
                        tblRaw.Merge(tblTmp);
                }
            }
        }
    }
}