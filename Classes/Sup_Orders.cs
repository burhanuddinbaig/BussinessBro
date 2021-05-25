using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace prjGrow.Classes
{
    public class Sup_Orders : Journal
    {
        public long prod_id { get; set; }
        public long sup_id { get; set; }
        public float qty { get; set; }

        public void saveSupOrder()
        {
            db.query = "insert into Sup_Order(prod_id, sup_id, qty, uid )" + sqlLine;
            db.query += "values("+prod_id+","+sup_id+","+qty+", "+User.curUid+")" + sqlLine;
            
            result = db.runQuery();
        }

        public void updSupOrder()
        {
            db.query = "update Sup_Order set" + sqlLine;
            db.query += "prod_id = "+prod_id+", sup_id = "+sup_id+", qty = "+qty+", uid = "+User.curUid+"" + sqlLine;
            db.query += "where id = " + id + sqlLine;

            result = db.runQuery();
        }

        public void delSupOrder()
        { 
            db.query = "update Sup_Order set status = " + Constants.status_deleted + sqlLine;
            db.query += "where status = " + Constants.status_active + " and id = " + id + sqlLine;
            
            result = db.runQuery();
        }

        public DataTable getSupOrders()
        {
            db.query = "select o.id as " + col_id + ", o.prod_id as " + col_prod_id + ", pd.prod_name as [" + col_prod_name + "], " + sqlLine;
            db.query += "sp.id as " + col_sup_id + ", o.qty as [" + col_qty + "]" + sqlLine;//sp.name as [" + col_sup_name + "],
            db.query += "from Sup_Order o inner join Product pd on o.prod_id = pd.id" + sqlLine;
            db.query += "inner join Supplier sp on o.sup_id = sp.id" + sqlLine;
            db.query += "where o.status = " + Constants.status_active + " and pd.status = " + Constants.status_active + " and sp.status = " + Constants.status_active + sqlLine;
            db.query += "and o.sup_id = " + sup_id + " and progress in (" + Constants.order_new + ")" + sqlLine;

            return db.getDataTable();
        }

        public void reciveOrder(DataTable tblCart, long sup_id)
        {
            if(sup_id <= 0 || !Custom.fet_sup_order)
                return;

            long tmp_prod, tmp_id;
            foreach (DataRow row in tblCart.Rows)
            {
                tmp_prod = tmp_id = 0;
                tmp_prod = Convert.ToInt64(row[Sale.col_prod_id]);
                
                db.query = "select min(id) from Sup_order" + sqlLine;
                db.query += "where sup_id = " + sup_id + " and prod_id = " + tmp_prod + " and progress = " + Constants.order_new + " and status = " + Constants.status_active + sqlLine;

                tmp_id = db.readLong();
                if (tmp_id <= 0)
                    continue;

                db.query = "update Sup_order" + sqlLine;
                db.query += "set progress = " + Constants.order_recieved + sqlLine;
                db.query += "where id = " + tmp_id + sqlLine;
                
                db.runQuery();
            }
        }
    }
}