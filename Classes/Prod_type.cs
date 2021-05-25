using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace prjGrow.Classes
{
    public class Prod_type: Gen
    {
        public long id { get; set; }
        public string name { get; set; }

        Stock stk = new Stock();

        public DataTable getTypes()
        {
            db.query = "select id as [" + col_prod_type_id + "], name as [" + col_prod_type + "]" + sqlLine;
            db.query += "from Prod_type where status = " + Constants.status_active + sqlLine;

            return db.getDataTable();
        }
        public void saveProType()
        {

            db.Connect();
            SqlTransaction tran = db.con.BeginTransaction();

            try
            {
                db.query = "insert into Prod_type(name, uid)" + sqlLine;
                db.query += "values('" + name + "'," + User.curUid + ")" + sqlLine;
                result = db.runQuery(tran);
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

                setMessage("Product Type", "Saved");
            }
        }

        public void updProType()
        {  
            db.Connect();
            SqlTransaction tran = db.con.BeginTransaction();

            try
            {
                db.query = "update Prod_type set" + sqlLine;
                db.query += "name = '" + name + "', uid  = " + User.curUid + " " + sqlLine;
                db.query += "where id = " + this.id + sqlLine;

                result = db.runQuery();
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

                setMessage("Product Type", "Updated");
            }
        }

        public void delProdType()
        {
           
            db.Connect();
            SqlTransaction tran = db.con.BeginTransaction();

            if (haveProd())
            {
                setMessage("Product have entries", Constants.message_warning);
                return;
            }

            try
            {
                db.query = "update Prod_type set status = " + Constants.status_deleted + sqlLine;
                db.query += "where id = " + this.id + sqlLine;

                result = db.runQuery();
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

                setMessage("Product Type", "Deleted");
            }
        }

        public bool haveProd()
        {
            db.query = "select count(*) as a from Product" + sqlLine;
            db.query += "where type = " + this.id + " and status = " + Constants.status_active + sqlLine;
            
            return db.readInt() > 0;
        }
    }
}