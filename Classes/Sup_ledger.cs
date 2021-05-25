using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace prjGrow.Classes
{
    public class Sup_ledger : Journal
    {
        public long id { get; set; }
        public long sup_id { get; set; }
        public long invoice { get; set; }
        public long bnk_id { get; set; }
        public long amount { get; set; }
        public long discount { get; set; }
        public string reference { get; set; }

        public Bank_ledger bnk = new Bank_ledger();
        public Cheque cheq = new Cheque();

        public void getAccIds()
        {
            acc_id_cash = coa.getAccId(Constants.config_cash);
            acc_id_bank = coa.getAccId("Bank",bnk_id);
            acc_id_sup = coa.getAccId("Supplier", sup_id);
            acc_id_cheq = coa.getAccId(Constants.config_cheq_recive);
            acc_id_discount = coa.getAccId(Constants.config_pur_discount);
        }

        public bool addSupLedger(SqlTransaction tran)
        {
            db.query = "insert into Sup_ledger(sup_id, tran_id, date, invoice, dr, cr, reference, uid)" + sqlLine;
            db.query += "values(" + sup_id + "," + tran_id + ",'" + date + "'," + invoice + "," + dr + "," + cr + ", '" + reference + "'," + User.curUid + ")" + sqlLine;

            return db.runQuery(tran);
        }

        public bool removeLedger(long tranId, SqlTransaction tran)
        {
            db.query = "update sup_ledger" + sqlLine;
            db.query += "set status = " + Constants.status_deleted + sqlLine;
            db.query += "where tran_id = " + tranId + sqlLine;

            return db.runQuery(tran);
        }
        
        public DataTable getSupled()
        {
            db.query = "select sl.id as " + col_id + ", sl.invoice as " + col_invoice + ", sl.date as " + col_date + "," + sqlLine;
            db.query += "sl.tran_id as " + col_tran_id + ", sl.cr as " + col_credit + ", sl.dr as " + col_debit + "," + sqlLine;
            db.query += "b.id as " + Bank.col_bnk_id + ", b.name as " + Bank.col_bank + "," + sqlLine;
            db.query += "cq.cheq_no as " + Cheque.col_cheq_no + ", sl.reference as " + col_reference + "" + sqlLine;
            db.query += "from sup_ledger sl inner join supplier s on s.id = sl.sup_id" + sqlLine;
            db.query += "left outer join bank_ledger bl on bl.tran_id = sl.tran_id and bl.status = " + Constants.status_active + sqlLine;
            db.query += "left outer join bank b on b.id = bl.bank_id" + sqlLine;
            db.query += "left outer join Cheque cq on cq.tran_id = sl.tran_id" + sqlLine;
            db.query += "where sl.status = " + Constants.status_active + " and s.status = " + Constants.status_active + sqlLine;
            db.query += "and sl.sup_id = " + sup_id + sqlLine;
            db.query += "order by sl.id desc" + sqlLine;

            return db.getDataTable();
        }

        public void saveLedger()
        {
            getAccIds();
            tran_id = getTranidNext();

            db.Connect();
            SqlTransaction tran = db.con.BeginTransaction();
            try
            {
                result = addSupLedger(tran);

                if (amount > 0)
                {
                    if (result)
                        result = debit(tran, date, "Paid to Supplier", acc_id_sup, amount);

                    if (by_cheq)
                    {
                        cheq.tran_id = tran_id;
                        result = cheq.saveCheque(tran, tran_id);

                        if (result)
                            result = credit(tran, date, "Paid to Supplier by Cheque", acc_id_cheq, amount);
                    }
                    if (result && bnk_id > 0)
                    {
                        bnk.tran_id = tran_id;
                        result = bnk.addBankLedger(tran);
                        if (result)
                            result = credit(tran, date, "Paid to Supplier from Bank", acc_id_bank, amount);
                    }
                    else if (result)
                        result = credit(tran, date, "Cash Paid to Supplier", acc_id_cash, amount);
                }
                else if (discount > 0)
                {
                    if (result)
                        result = debit(tran, date, narration, acc_id_sup, amount);

                    if (result)
                        result = credit(tran, date, narration, acc_id_discount, amount);
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
                setMessage("Supplier Transaction","Saved");
            }
        }

        public void updLedger()
        {
            getAccIds();

            db.Connect();
            SqlTransaction tran = db.con.BeginTransaction();
            try
            {
                db.query = "update sup_ledger set" + sqlLine;
                db.query += "dr = " + dr + sqlLine;
                db.query += ", date = '" + date + "'" + sqlLine;
                db.query += ", reference = '"+reference+"'" + sqlLine;
                db.query += ", uid = " + User.curUid + sqlLine;
                db.query += "where id = " + this.id + sqlLine;
                
                result = db.runQuery(tran);

                if (result)
                    result = deleteTransaction(tran, "Bank_ledger");

                if (amount > 0)
                {
                    if (result)
                        result = debit(tran, date, "Paid to Supplier", acc_id_sup, dr);

                    if (result && bnk_id > 0)
                    {
                        bnk.tran_id = tran_id;
                        result = bnk.addBankLedger(tran);
                        if(result)
                        result = credit(tran, date, "Paid to Supplier from Bank", acc_id_bank, dr);
                    }
                    else if (result)
                        result = credit(tran, date, "Cash Paid to Supplier", acc_id_cash, dr);
                }
                else if (discount > 0)
                {
                    if (result)
                        result = debit(tran, date, narration, acc_id_sup, amount);

                    if (result)
                        result = credit(tran, date, narration, acc_id_discount, amount);
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
                setMessage("Supplier Transaction", "Updated");
            }            
        }

        public void delLedger()
        {
            tran_id = getTranid(this.id, "Sup_ledger");
            getAccIds();
            db.Connect();
            SqlTransaction tran = db.con.BeginTransaction();
            try
            {
                result = removeLedger(tran_id, tran);

                if (result)
                    result = deleteTransaction(tran, "Bank_ledger", "Cheque");
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
                setMessage("Supplier Ledger", "Deleted");
            }
        }
    }
}