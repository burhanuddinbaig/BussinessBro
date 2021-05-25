using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace prjGrow.Classes
{
    public class AutoDis : Gen
    {
        public long prod_id { get; set; }
        public float discount { get; set; }

        public DataTable getData()
        {
            db.query = "select prod_name as " + col_prod_name + ", dist as "+ col_dist +", " + sqlLine;
            db.query += "from product p inner join stock s on p.prod_id = s.prod_id" + sqlLine;
            db.query += "where dist > 0 and p.status = " + Constants.status_active + " and s.status = " + Constants.status_active + sqlLine;

            return db.getDataTable();
        }

        public void saveDiscount()
        {
            db.query = "update product set dist = " + discount + sqlLine;
            db.query += "where prod_id = " + prod_id + sqlLine;

            db.runQuery();
        }

        public void removeDiscount()
        {
            db.query = "update product set dist = 0" + sqlLine;
            db.query += "where prod_id = " + prod_id + sqlLine;

            db.runQuery();
        }
    }
}
