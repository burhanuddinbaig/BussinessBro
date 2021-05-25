using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace prjGrow.Classes
{
    public class Delivery : Journal
    {
        public long prod_id { get; set; }
        public long order_id { get; set; }
        public long cost { get; set; }
        public long sold { get; set; }
        public long adv { get; set; }
        public long dist { get; set; }

        public bool saveDelivery(SqlTransaction tran, DataTable tblOrders)
        {
            result = true;
            foreach (DataRow row in tblOrders.Rows)
            {
                prod_id = Convert.ToInt64(row[col_prod_id]);
                order_id = Convert.ToInt64(row[col_order_no]);
                cost = string.IsNullOrEmpty(row[col_cost].ToString()) ? 0 : Convert.ToInt64(row[col_cost]);
                sold = Convert.ToInt64(row[col_price]);
                
                cr = Convert.ToInt64(row[Orders.col_qty]);

                db.query = "insert into Stock(prod_id, cost, sold, cr, tran_id, term_id, uid, order_id)" + sqlLine;
                db.query += "values("+prod_id+","+cost+","+sold+","+cr+","+tran_id+", "+Constants.term_order_queue+","+User.curUid+", " + order_id + ")" + sqlLine;
                result = db.runQuery(tran);

                if (result)
                {
                    db.query = "update order_item set progress = " + Orders.order_deliver + sqlLine;
                    db.query += "where order_id = " + order_id + " and " + " prod_id = " + prod_id + sqlLine;
                    result = db.runQuery(tran);
                }

                if (!result)
                    break;
            }
            return result;
        }
    }
}
