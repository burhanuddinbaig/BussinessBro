using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace prjGrow.Classes
{
    public class Expense : Journal
    {
        public long id { get; set; }
        public long type_id { get; set; }
        public string remarks { get; set; }
        public long amount { get; set; }
        public string reference { get; set; }

        void getAccIds()
        {
            acc_id_cash = coa.getAccId(Constants.config_cash);
            acc_id_exp = coa.getAccId(Constants.config_expense);
        }

        public DataTable getExpense()
        {
            db.query = "select e.id as [" + col_id + "], e.type_id as [" + col_type_id + "], t.exp_name as [" + col_exp_type + "]," + sqlLine;
            db.query += "e.date as [" + col_date + "], e.amount as [" + col_amount + "], e.remarks as [" + col_remarks + "]" + sqlLine;
            db.query += "from Expense e inner join Exp_type t on e.type_id = t.id" + sqlLine;
            db.query += "where e.status = " + Constants.status_active + " and t.status = " + Constants.status_active + sqlLine;
        //    db.query += "order by t.exp_name" + sqlLine;
            db.query += "order by e.date desc" + sqlLine;

            return db.getDataTable();
        }

        public void saveExpense()
        {
            getAccIds();
            tran_id = getTranidNext();
            db.Connect();
            SqlTransaction tran = db.con.BeginTransaction();
            try
            {
                db.query = "insert into Expense(date, amount, type_id, remarks, reference, tran_id)" + sqlLine;
                db.query += "values('"+date+"',"+amount+","+type_id+",'"+remarks+"', '"+reference+"',"+tran_id+")" + sqlLine;
                result = db.runQuery();

                if (result)
                    result = debit(tran, date, narration, acc_id_exp, amount );              //debit to expense
                
                if (result)
                    result = credit(tran, date, narration, acc_id_cash, amount);          //credit to cash acc
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

                setMessage("Expense", "Saved");
            }
        }

        public void updateExpense()
        {
            getAccIds();
            tran_id = getTranid(id, "Expense");
            db.Connect();
            SqlTransaction tran = db.con.BeginTransaction();
            
            try
            {
                db.query = "Update expense set" + sqlLine;
                db.query += "date = '" + date + "', type_id = " + type_id + ", amount = " + amount + ", remarks = '" + remarks + "'," + sqlLine;
                db.query += "uid = " + User.curUid + sqlLine;
                db.query += "where tran_id = " + tran_id + sqlLine;

                result = db.runQuery();
                
                if(result)
                    result = deleteTransaction(tran);

                if (result)
                    result = debit(tran, date, narration, acc_id_exp, amount);               //debit to expense

                if (result)
                    result = credit(tran, date, narration, acc_id_cash, amount);          //credit to cash acc
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

                setMessage("Expense", "Updated");
            }
        }

        public void deleteExpense()
        {
            getAccIds();
            tran_id = getTranid(id, "Expense");
            db.Connect();
            SqlTransaction tran = db.con.BeginTransaction();
            try
            {
                result = deleteTransaction(tran, "Expense");
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

                setMessage("Expense", "Deleted");
            }
        }
    }
}