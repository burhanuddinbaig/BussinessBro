using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace prjGrow.Classes
{
    public class Bank_ledger : Journal
    {
        public long id { get; set; }
        public long bank_id { get; set; }
        public string remarks { get; set; }
        public long deposit_amount { get; set; }
        public long withdraw_amount { get; set; }
        public long native = 0;

        public Bank bnk = new Bank();

        public void getAccIds()
        {
            acc_id_cash = coa.getAccId(Constants.config_cash);
            acc_id_bank = coa.getAccId("Bank", bank_id);
        }

        public DataTable getBankLedger()
        {
            db.query = "select bl.id as ["+col_id+"], bl.tran_id as [" + col_tran_id + "], bl.date as [" + col_date + "], " + sqlLine;
            db.query += "bl.dr as [" + col_deposit + "], bl.cr as [" + col_withdraw + "], bl.remarks as [" + col_remarks + "], bl.native as [" + col_native + "]" + sqlLine;                                  
            db.query += "from Bank_ledger bl inner join Bank b on bl.bank_id = b.id" + sqlLine;
            db.query += "where bl.bank_id = " + bank_id + sqlLine;
            db.query += "and bl.status = " + Constants.status_active + " and b.status = " + Constants.status_active + sqlLine;
            db.query += "order by bl.id desc" + sqlLine;
            
            return db.getDataTable();
        }

        public bool addBankLedger(SqlTransaction tran)
        {
            db.query = "insert into Bank_ledger(tran_id, bank_id, dr, cr, remarks, native, uid)" + sqlLine;
            db.query += "values(" + tran_id + "," + bank_id + "," + dr + "," + cr + ",'"+remarks+"', "+native+", " + User.curUid + ")" + sqlLine;
            return db.runQuery(tran);
        }

        public bool deleteBankLedger(long tranId, SqlTransaction tran)
        {
            db.query = "update Bank_ledger set status = " + Constants.status_deleted + sqlLine;
            db.query += "where tran_id = " + tranId  + sqlLine;
            return db.runQuery(tran);
        }

        public void saveBankLedger()
        {
            tran_id = getTranidNext();
            getAccIds();
            db.Connect();
            SqlTransaction tran = db.con.BeginTransaction();
            try
            {
                result = addBankLedger(tran);
                
                if(result)
                    result = entry(tran, date, narration, acc_id_bank, deposit_amount, withdraw_amount);    //Bank account debit if deposit > 0 and credit if withdraw > 0

                if (result)
                    result = entry(tran, date, narration, acc_id_cash, withdraw_amount, deposit_amount);  //Cash account debit if withdraw > 0 and credit if deposit > 0
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
                setMessage("Bank Transaction", "Saved");
            }
        }

        public void updateBankLedger()
        {
            tran_id = getTranid(id, "Bank_ledger");
            getAccIds();
            db.Connect();
            SqlTransaction tran = db.con.BeginTransaction();

            try
            {
                db.query = "update Bank_ledger set" + sqlLine;
                db.query += "date = '" + date + "', dr = " + deposit_amount + ", cr = " + withdraw_amount + ", remarks = '"+remarks+"'" + sqlLine;
                db.query += "where tran_id = " + tran_id + " and native > 0" + sqlLine;

                result = db.runQuery(tran);

                if(result)
                    result = db.deleteTran(tran, "Journal", tran_id);

                if (result)
                    result = entry(tran, date, narration, acc_id_bank, deposit_amount, withdraw_amount);    //Bank account debit if deposit > 0 and credit if withdraw > 0

                if (result)
                    result = entry(tran, date, narration, acc_id_cash, withdraw_amount, deposit_amount);  //Cash account debit if withdraw > 0 and credit if deposit > 0
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
                setMessage("Bank Transaction", "Updated");
            }
        }

        public void deleteBankLedger()
        {
            tran_id = getTranid(id, "Bank_ledger");
            getAccIds();
            db.Connect();
            SqlTransaction tran = db.con.BeginTransaction();

            try
            {
                result = deleteTransaction(tran, "Bank_ledger");
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
                setMessage("Bank Transaction", "Deleted");
            }
        }
    }
}