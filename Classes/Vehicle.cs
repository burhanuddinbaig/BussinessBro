using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace prjGrow.Classes
{
    public class Vehicle: Gen
    {
        public long id { get; set; }
        public string veh_name { get; set; }
        public string plate_no { get; set; }
        public long term_id { get; set; }
        public Termin termin = new Termin();

        public DataTable getVehicles()
        {
            db.query = "select id as ["+col_veh_id+"], veh_name  as ["+col_veh_name+"], plate_no as ["+col_plate_no+"], term_id as ["+col_term_id+"]" + sqlLine;
            db.query += "from Vehicle" + sqlLine;
            db.query += "where status = " + Constants.status_active + sqlLine;

            return db.getDataTable();
        }

        public void saveVeh()
        {
            term_id = db.getLastId("Termin") + 1;

            db.Connect();
            SqlTransaction tran = db.con.BeginTransaction();
            try
            {
                db.query = "insert into Vehicle(veh_name, plate_no, term_id, uid)" + sqlLine;
                db.query += "values('"+veh_name+"','"+plate_no+"',"+term_id+","+User.curUid+")" + sqlLine;

                result = db.runQuery();

                if(result)
                    result = termin.createTermin(tran);
            }
            catch (Exception ex)
            {
                result = false;
            }
            finally
            {
                db.con.Close();
                if (result)
                    tran.Commit();
                else
                    tran.Rollback();
                setMessage("Vehicle", "Saved");
            }
        }

        public void updVeh()
        {
            db.Connect();
            SqlTransaction tran = db.con.BeginTransaction();
            try
            {
                db.query = "update Vehicle" + sqlLine;
                db.query += "set veh_name = '" + veh_name + "', plate_no = '" + plate_no + "'" + sqlLine;
                db.query += "where id = " + id + sqlLine;

                result = db.runQuery();

                if (result)
                    result = termin.updTermin(tran);
            }
            catch (Exception ex)
            {
                result = false;
            }
            finally
            {
                db.con.Close();
                if (result)
                    tran.Commit();
                else
                    tran.Rollback();
                setMessage("Vehicle", "Updated");
            }
        }

        public void delVeh()
        {
            db.Connect();
            SqlTransaction tran = db.con.BeginTransaction();
            try
            {
                db.query = "update Vehicle" + sqlLine;
                db.query += "set status = " + Constants.status_deleted + "" + sqlLine;
                db.query += "where id = " + id + sqlLine;

                result = db.runQuery();

                if (result)
                {
                    db.query = "update Termin" + sqlLine;
                    db.query += "set status = " + Constants.status_deleted + "" + sqlLine;
                    db.query += "where id = " + term_id + sqlLine;

                    result = db.runQuery();
                }
            }
            catch (Exception ex)
            {
                result = false;
            }
            finally
            {
                db.con.Close();
                if (result)
                    tran.Commit();
                else
                    tran.Rollback();
                setMessage("Vehicle", "Deleted");
            }
        }
    }
}
