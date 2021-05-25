using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace prjGrow.Classes
{
    public class Cheque : Journal
    {
        public long bnk_id { get; set; }
        public string bnk_name { get; set; }
        public string cheq_no { get; set; }
        public short progress { get; set; }
        public short cheq_type { get; set; }
        public long amt { get; set; }
        public DateTime issue_date { get; set; }
        public DataTable tblToProcess = new DataTable();
        public bool toProcess = false;

        Bank_ledger bnk = new Bank_ledger();

        public bool saveCheque(SqlTransaction tran, long tran_id)
        {
            db.query = "insert into cheque(bnk_id, cheq_no, bnk_name, amt, type, tran_id, issue_date, uid)" + sqlLine;
            db.query += "values(" + bnk_id + ",'" + cheq_no + "','" + bnk_name + "'," + amt + "," + cheq_type + ", "+tran_id+", '"+issue_date+"'," + User.curUid + ")" + sqlLine;

            return db.runQuery();
        }

        public DataTable getPayCheques()
        {
            db.query = "select cq.id as [" + col_id + "], cq.cheq_no as [" + col_cheq_no + "], cq.bnk_id as [" + col_bnk_id + "], bnk.name as [" + col_bank + "], cq.amt as [" + col_amount + "], cq.type as [" + col_type_id + "]" + sqlLine;
            db.query += ", cq.issue_date as [" + col_issue_date + "], cq.[progress] as ["+col_progress+"] " + sqlLine;
            db.query += "from cheque cq inner join bank bnk on cq.bnk_id = bnk.id" + sqlLine;
            db.query += "where cq.[status] = " + Constants.status_active + " and bnk.[status] = " + Constants.status_active + sqlLine;
            db.query += "and cq.type = " + Constants.cheq_pymnt + " and cq.progress = " + progress + sqlLine;
            db.query += toProcess ? "cq.issue_date < '"+DateTime.Today+"'" : "" + sqlLine;

            return db.getDataTable();
        }

        public void getAccIds(long bnk_id)
        {
            acc_id_bank = coa.getAccId("Bank", bnk_id);
            bnk.acc_id_bank = acc_id_bank;
            acc_id_cheq = coa.getAccId(Constants.config_cheq_payment);
        }

        public void processCheque()
        {
            progress = Constants.cheq_status_pending;
            tblToProcess = getPayCheques();

            if (tblToProcess.Rows.Count <= 0)
                return;
            
            db.query = "Update Cheque set progress = " + Constants.cheq_status_processed + sqlLine;
            db.query += "where progress = " + Constants.cheq_status_pending + " and status = " + Constants.status_active + sqlLine;
       //     db.query += "and issue_date < '" + DateTime.Today + "'" + sqlLine;
            
            result = db.runQuery();
            if (!result)
                return;

            foreach(DataRow row in tblToProcess.Rows)
            {
                tran_id = getTranidNext();
                amt = Convert.ToInt64(row[col_amount].ToString());
                date = DateTime.Today;

                getAccIds(Convert.ToInt64(row[col_bnk_id].ToString()));
                db.Connect();
                SqlTransaction tran = db.con.BeginTransaction();

                try
                {
                    result = bnk.addBankLedger(tran);
                    if (result)
                        result = credit(tran, date, "Bank Cheque Processed", acc_id_bank, amt);  //Bank account debit if deposit > 0 and credit if withdraw > 0
                    if (result)
                        result = debit(tran, date, "Bank Cheque Processed", acc_id_cheq, amt);  //Cash account debit if withdraw > 0 and credit if deposit > 0
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
            }
        }
    }
}