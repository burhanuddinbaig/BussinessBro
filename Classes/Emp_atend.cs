using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace prjGrow.Classes
{
    public class Emp_atend : Gen
    {
        public long id { get; set; }
        public string name { get; set; }
        public DateTime date { get; set; }
        public long emp_id { get; set; }
        public char present { get; set; }

        public DataTable getAtend()
        {
            db.query = "select a.id as [" + col_id + "], a.date as [" + col_date + "], e.name as [" + col_emp_name + "], a.emp_id as [" + col_emp_id + "], a.present as [" + col_status + "]" + sqlLine;
            db.query += "from Emp_atend a inner join Employee e" + sqlLine;
            db.query += "on a.emp_id = e.id" + sqlLine;
            db.query += "where [date] = '" + date.ToShortDateString() + "'" + sqlLine;
            db.query +=  " and a.status = " + Constants.status_active + " and e.status = " + Constants.status_active + sqlLine;

            return db.getDataTable();
        }
        
        public void saveAtend()
        {
            db.query = "insert into Emp_atend(date, emp_id, present, uid)" + sqlLine;
            db.query += "values('"+date.ToShortDateString()+"',"+emp_id+",'"+present+"',"+User.curUid+")" + sqlLine;

            result = db.runQuery();
            setMessage( "Attendance", "Saved");
        }

        public void updAtend()
        {
            db.query = "update Emp_atend set" + sqlLine;
            db.query = "present = '"+present+"'" + sqlLine;
            db.query = "where id = " + id + " and status = " + Constants.status_active + sqlLine;

            result = db.runQuery();
            setMessage("Attendance", "Updated");
        }

        public void delAtend()
        {
            db.query = "update Emp_atend set" + sqlLine;
            db.query += "status = " + Constants.status_deleted + "" + sqlLine;
            db.query += "where id = " + id + sqlLine;

            result = db.runQuery();
            setMessage("Attandance", "Deleted");
        }
    }
}