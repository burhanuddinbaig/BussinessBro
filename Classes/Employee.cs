using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace prjGrow.Classes
{
    public class Employee : Coa
    {
        public long id { get; set; }
        public string name { get; set; }
        public string cnic { get; set; }
        public string contact { get; set; }
        public string adrs { get; set; }
        public long sal { get; set; }
        public DateTime jdate { get; set; }
        public DateTime ldate { get; set; }
        public bool leaved = true;

        public DataTable getEmps()
        {
            db.query = "select id as ["+col_id+"], name as ["+col_name+"], cnic as ["+col_cnic+"], contact as ["+col_contact+"], sal as ["+col_sal+"], adrs as ["+col_adrs+"], acc_id as ["+col_acc_id+"], jdate as "+col_jdate+", ldate as "+col_ldate+"" + sqlLine;
            db.query += "from Employee where status = " + Constants.status_active + sqlLine;

            return db.getDataTable();
        }

        public void saveEmp()
        {
            acc_id = getNextAccId();
            db.Connect();
            SqlTransaction tran = db.con.BeginTransaction();
            try
            {
                db.query = "insert into Employee(name, cnic, contact, sal, adrs, jdate," + sqlLine;
                db.query += leaved ? "ldate, " + sqlLine : "";
                db.query += "acc_id)" + sqlLine;
                db.query += "values('" + name + "','" + cnic + "','" + contact + "'," + sal + ",'" + adrs + "','"+jdate+"', " + sqlLine;
                db.query += leaved ? "'" + ldate + "'," + sqlLine : "";
                db.query += "" + acc_id + ")" +  sqlLine;

                result = db.runQuery();

                if (result)
                    result = saveCoa(tran, Constants.acc_libality, Constants.config_employee);
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
                setMessage("Employee", "Saved");
            }
        }

        public void updEmp()
        { 
            acc_id = getAccId("Employee", id);
            db.Connect();
            SqlTransaction tran = db.con.BeginTransaction();
            try
            {
                db.query = "Update Employee set" + sqlLine;
                db.query += "name = '"+name+"', contact  = '"+contact+"', sal = "+sal+", cnic  = '"+cnic+"', adrs = '"+adrs+"'" + sqlLine;
                db.query += ", ldate = '"+ldate+"'" + sqlLine;
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

                setMessage("Employee", "Updated");
            }
        }
    }
}