using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace prjGrow.Classes
{
    public class Termin : Coa
    {
        public long id { get; set; }
        public string title { get; set; }

        public DataTable getTermin()
        {
            db.query = "select id as [" + col_id + "], title as ["+col_name+"] from Termin" + sqlLine;
            db.query += "where id in (" + Constants.term_shop + ", " + Constants.term_store + ")" + sqlLine;

            return db.getDataTable();
        }

        public bool createTermin(SqlTransaction tran)
        {
            db.query = "insert into Termin(title) values('"+title+"')" + sqlLine;

            return db.runQuery();
        }

        public bool updTermin(SqlTransaction tran)
        {
            db.query = "update Termin set title = '" + title + "'" + sqlLine;
            db.query += "where id = " + id + sqlLine;

            return db.runQuery();
        }
    }
}
