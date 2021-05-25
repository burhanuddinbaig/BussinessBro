using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace prjGrow.Classes
{
    public class clsTable : Gen
    {
        public long id { get; set; }
        public string tbl_name { get; set; }

        public DataTable getTables()
        {
            db.query = "select id as ["+col_id+"], name as ["+col_tbl_name+"] from Tbl" + sqlLine;
            db.query += "where [status] = " + Constants.status_active + sqlLine;

            return db.getDataTable();
        }

        public void saveTable()
        {
            db.query = "insert into Tbl(name, uid)" + sqlLine;
            db.query += "values('"+tbl_name+"', "+User.curUid+")" + sqlLine;

            result = db.runQuery();
            setMessage("Table","Saved");
        }

        public void updTable()
        {
            db.query = "update Tbl" + sqlLine;
            db.query += "set name = '" + tbl_name + "', uid = " + User.curUid + "" + sqlLine;
            db.query += "where id = " + id + sqlLine;

            result = db.runQuery();
            setMessage("Table", "Updated");
        }

        public void delTable()
        {
            db.query = "update Tbl set status = " + Constants.status_deleted + sqlLine;
            db.query += "where id = " + id + sqlLine;

            result = db.runQuery();
            setMessage("Table", "Deleted");
        }
    }
}