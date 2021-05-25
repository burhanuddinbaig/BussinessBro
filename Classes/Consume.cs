using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using prjGrow.Classes;

namespace prjGrow.Classes
{
    public class Consume : Journal
    {
        public long id { get; set; }
        public long prod_id { get; set; }
        public string remarks { get; set; }
        public int MyProperty { get; set; }

        public Stock stock = new Stock();

        public void saveConsume()
        {
            tran_id = getTranidNext();

            db.Connect();
            SqlTransaction tran = db.con.BeginTransaction();
            try
            {
                result =  createTran(tran, date);

                db.query = "insert into Consume(prod_id, remarks, tran_id, date, uid)" + sqlLine;
                db.query += "values('" + prod_id + "','" + remarks + "', " + tran_id + ", '" + date + "'," + User.curUid + ")" + sqlLine;
                
                if(result)
                    result = db.runQuery();

                if (result)
                {
                    stock.tran_id = tran_id;
                    result = stock.saveConsumeStk(tran);
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

                setMessage("Stock Consumption", "Saved");
            }
        }

        public void updConsume()
        {
            tran_id = getTranidNext();
            db.Connect();
            SqlTransaction tran = db.con.BeginTransaction();
            try
            {
                db.query = "update Consume" + sqlLine;
                db.query += "set prod_id = " + prod_id + ", remarks = " + remarks + ", " + User.curUid + "" + sqlLine;
                result = db.runQuery();

                if (result)
                {
                    stock.tran_id = tran_id;
                    result = stock.saveConsumeStk(tran);
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

                setMessage("Stock Consumption", "Saved");
            }
        }

        public void delConsume()
        {
            deleteTransaction("Consume" ,"Stock");
            setMessage("Stock Consumption","Deleted");
        }

        public DataTable getConsumeData()
        {
            db.query = "select cn.id as ["+col_id+"], cn.prod_id as ["+col_prod_id+"], cn.tran_id as ["+col_tran_id+"], pd.prod_name as ["+col_prod_name+"]," + sqlLine;
            db.query += "st.cr as [" + col_qty + "], cn.remarks as [" + col_remarks + "]" + sqlLine;
            db.query += "from Consume cn inner join Stock st on cn.tran_id = st.tran_id" + sqlLine;
            db.query += "inner join Product pd on cn.prod_id = pd.id" + sqlLine;
            db.query += "where cn.status = " + Constants.status_active + " and st.[status] = " + Constants.status_active + " and (pd.[status] = " + Constants.status_active + " or pd.[status] = " + Constants.status_disabled + ")" + sqlLine;
            db.query += "and CONVERT(VARCHAR(10), [date], 101) = '" + date.ToShortDateString() + "'" + sqlLine;

            return db.getDataTable();
        }
    }
}