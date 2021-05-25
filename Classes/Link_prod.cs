using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace prjGrow.Classes
{
    public class Link_prod : Gen
    {
        public long id { get; set; }
        public long serv_id { get; set; }
        public long raw_id { get; set; }
        public float qty { get; set; }

        public DataTable getLinkProd()
        {
            db.query = "select lk.id as [" + col_id + "], lk.prod_id as [" + col_prod_id + "], pd.prod_name as [" + col_prod_name + "]" + sqlLine;
            db.query += ", lk.raw_id as [" + col_raw_id + "], pr.prod_name as [" + col_raw + "], lk.qty as [" + col_qty + "]" + sqlLine;
            db.query += "from Link_prod lk inner join Product pd on lk.prod_id = pd.id" + sqlLine;
            db.query += "inner join Product pr on lk.raw_id = pr.id" + sqlLine;
            db.query += "where lk.[status] = " + Constants.status_active + " and pr.[status] = " + Constants.status_active + " and pd.[status] = " + Constants.status_active + sqlLine;

            return db.getDataTable();
        }

        public DataTable getLinkProd(long prod_id, long _qty)
        {
            db.query = "select lk.id as [" + col_id + "], lk.prod_id as [" + col_prod_id + "], lk.raw_id as [" + col_raw_id + "], lk.qty * " + _qty + " as [" + col_qty + "]" + sqlLine;
            db.query += ",isnull((select max(st.cost) from Stock st where st.id = (select max(id) from Stock stk where stk.prod_id = lk.raw_id and stk.cost > 0)), 0) as [" + col_cost + "]" + sqlLine;
            db.query += "from Link_prod lk" + sqlLine;
            db.query += "where lk.[status] = " + Constants.status_active + " and lk.prod_id = " + prod_id + sqlLine;

            return db.getDataTable();
        }

        public void save()
        {
            db.query = "insert into Link_prod(prod_id, raw_id, qty, uid)" + sqlLine;
            db.query += "values("+serv_id+", "+raw_id+", "+qty+", "+User.curUid+")" + sqlLine;

            result = db.runQuery();
            setMessage("Record","Saved");
        }

        public void update()
        {
            db.query = "update Link_prod set" + sqlLine;
            db.query += "prod_id = "+serv_id+", raw_id = "+raw_id+", qty = "+qty+", uid = " + User.curUid + sqlLine;
            db.query += "where id = " + id + sqlLine;

            result = db.runQuery();
            setMessage("Record","Deleted");
        }

        public void delete()
        {
            db.query = "update Link_prod" + sqlLine;
            db.query += "set status = " + Constants.status_deleted + sqlLine;
            db.query += "where id = " + id + sqlLine;

            result = db.runQuery();
        }
    }
}