using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace prjGrow.Classes
{
    public class Cus_ledger : Journal
    {
        public long id { get; set; }
        public long cus_id { get; set; }
        public long amount_recive { get; set; }
        
    //    clsDb db = new clsDb();
    //    Coa coa = new Coa();
        public Customer cus = new Customer();
        public Cheque cheq = new Cheque();

        void getAccIds()
        {
            acc_id_cash = coa.getAccId(Constants.config_cash);
            acc_id_cus = coa.getAccId("Customer",cus_id);
            acc_id_cheq = coa.getAccId(Constants.config_cheq_recive);
        }

        public DataTable getCusLedger()
        {
            getAccIds();

            db.query = "select 0 as " + col_id + ", 0 as " + col_tran_id + ", '01/01/2020' as " + col_date + ", dr as " + col_debit + "," + sqlLine;
            db.query += "cr as " + col_credit + ", 'Opening Balance' as " + col_remarks + "" + sqlLine;
            db.query += "from Coa" + sqlLine;
            db.query += "where id = " + acc_id_cus + sqlLine;

            db.query += "Union All" + sqlLine;

            db.query = "select cl.id as " + col_id + ", cl.tran_id as " + col_tran_id + ", cl.date as " + col_date + ", cl.dr as " + col_debit + ", cl.cr as " + col_credit + ", cl.remarks as "+ col_remarks +"" + sqlLine;
            db.query += "from Cus_ledger cl inner join Customer cus on cl.cus_id = cus.id" + sqlLine;
            db.query += "where cl.status = " + Constants.status_active + " and cus.status = " + Constants.status_active + sqlLine;
            db.query += "and cl.cus_id = " + cus_id + sqlLine;
            return db.getDataTable();
        }

        public void saveCusLedger()
        {
            getAccIds();
            tran_id = getTranidNext();
            db.Connect();
            SqlTransaction tran = db.con.BeginTransaction();
            try
            {
                db.query = "insert into Cus_ledger(cus_id, tran_id, date, remarks, cr)" + sqlLine;
                db.query += "values("+cus_id+","+tran_id+",'"+date+"','"+remarks+"',"+amount_recive+")" + sqlLine;
                result = db.runQuery();

                if (result && by_cheq)
                    result = debit(tran, date, narration, acc_id_cheq, amount_recive);          //debit recieving cheques
                else if (result)
                    result = debit(tran, date, narration, acc_id_cash, amount_recive);          //debit cash
                if (result)
                    result = credit(tran, date, "Customer recievable recieved", acc_id_cus, amount_recive);         //credit to Customer

                if (result && by_cheq)
                    result = cheq.saveCheque(tran, tran_id);
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

                setMessage("Customer Transaction", "Saved");
            }
        }

        public void updateCusLedger()
        {
            getAccIds();
            tran_id = getTranid(id, "Cus_ledger");
            db.Connect();
            SqlTransaction tran = db.con.BeginTransaction();
            try
            {
                db.query = "update Cus_ledger set" + sqlLine;
                db.query += "cus_id = " + cus_id + ", tran_id = " + tran_id + ", date = '" + date + "', remarks = '" + remarks + "'" + sqlLine;
                db.query += ", cr = " + amount_recive + "" + sqlLine;
                db.query += "where id = " + id + sqlLine;

                result = db.runQuery();

                if (result)
                    result = deleteTransaction(tran);

                if (result)
                    result = debit(tran, date, narration, acc_id_cash, amount_recive);          //credit to cash acc

                if (result)
                    result = credit(tran, date, narration, acc_id_cus, amount_recive);              //debit to expense
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

                setMessage("Customer Transaction", "updated");
            }
        }

        public bool addCusLedger(SqlTransaction tran)
        {
            db.query = "insert into Cus_ledger(tran_id, cus_id, date, dr, cr, uid) values(" + tran_id + "," + cus_id + ",'" + date + "'," + dr + "," + cr + ", " + User.curUid + ")";
            return db.runQuery(tran);
        }

        public bool deleteCusLedger(long tranId, SqlTransaction tran)
        {
            db.query = "update Cus_ledger set status = " + Constants.status_deleted + sqlLine;
            db.query += "where tran_id = " + tranId + sqlLine;

            return db.runQuery(tran);
        }
    }
}