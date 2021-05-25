using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace prjGrow.Classes
{
    public class Exp_type : Coa
    {
        public long id { get; set; }
        public string name { get; set; }

        public DataTable getExpTypes()
        {
            db.query = "select id as [" + col_id + "], acc_id as [" + col_acc_id + "], exp_name as [" + col_name + "]" + sqlLine;
            db.query += "from exp_type" + sqlLine;
            db.query += "where status = " + Constants.status_active + sqlLine;

            return db.getDataTable();
        }
        public void saveExpType()
        {
            acc_id = getNextAccId();

            db.Connect();
            SqlTransaction tran = db.con.BeginTransaction();

            try
            {
                db.query = "insert into Exp_type(exp_name, uid, acc_id)" + sqlLine;
                db.query += "values('" + name + "'," + User.curUid + "," + acc_id + ")" + sqlLine;
                result = db.runQuery(tran);

                if (result)
                    result = saveCoa(tran, Constants.acc_expense, Constants.config_expense);
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

                setMessage("Expense Type", "Saved");
            }
        }

        public void updExpType()
        {
            acc_id = getAccId("Exp_type", this.id);
            db.Connect();
            SqlTransaction tran = db.con.BeginTransaction();

            try
            {
                db.query = "update Exp_type set" + sqlLine;
                db.query += "exp_name = '" + name + "', uid  = " + User.curUid + ", acc_id=" + acc_id + " " + sqlLine;
                db.query += "where id = " + this.id + sqlLine;

                result = db.runQuery();

                if (result)
                    updateAccName(tran);
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

                setMessage("Supplier", "Updated");
            }
        }

        public void delExpType()
        {
            acc_id = getAccId("Exp_type", this.id);

            if (haveEntries())
            {
                setMessage("Expense Type have Entries", Constants.message_warning);
                result = false;
                return;
            }

            db.Connect();
            SqlTransaction tran = db.con.BeginTransaction();

            try
            {
                db.query = "update Exp_type set status = " + Constants.status_deleted + sqlLine;
                db.query += "where id = " + this.id + sqlLine;

                result = db.runQuery();

                if (result)
                    deleteAcc(tran);
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

                setMessage("Expense Type", "Deleted");
            }
        }
    }
}