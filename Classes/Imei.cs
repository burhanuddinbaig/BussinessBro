using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace prjGrow.Classes
{
    public class Imei : Journal
    {
        public long id { get; set; }
        public string imei { get; set; }
        public long prod_id { get; set; }
        public long dr { get; set; }
        public long cr { get; set; }

        public DataTable tblTempTable = new DataTable();

        public DataTable getIMEIs()
        {
            db.query = "select id as [" + col_id + "], imei as [" + col_imei + "], prod_id as [" + col_prod_id + "], tran_id as ["+col_tran_id+"]" + sqlLine;
            db.query += "from IMEI" + sqlLine;
            db.query += "where tran_id =  " + tran_id + " AND status = " + Constants.status_active + sqlLine;
            db.query += "order by id desc " + sqlLine;

            return db.getDataTable();
        }

        public DataTable getIMEIsForSearch(string imei)
        {
            db.query = @"SELECT     Product.prod_name AS Procuct_Name, IMEI.imei AS IMEI, CASE WHEN IMEI.dr = 1 THEN 'Yes' ELSE '' END AS Purchase, CASE WHEN IMEI.cr = 1 THEN 'Yes' ELSE 'No' END AS Sold, 
                      ISNULL(Sale.date, Purchase.date) AS Tran_Date, ISNULL(Customer.name, Supplier.name) AS Client_Name
                      FROM         IMEI INNER JOIN
                      Product ON IMEI.prod_id = Product.id LEFT OUTER JOIN
                      Supplier INNER JOIN
                      Purchase ON Supplier.id = Purchase.sup_id ON IMEI.tran_id = Purchase.tran_id LEFT OUTER JOIN
                      Customer RIGHT OUTER JOIN
                      Sale ON Customer.id = Sale.cus_id ON IMEI.tran_id = Sale.tran_id
                        WHERE     (IMEI.status = 1) AND (Product.status = 1) AND (IMEI.imei = N'" + imei + "')";
            return db.getDataTable();
        }
      
        public bool saveIMEI(DataTable tempcart, SqlTransaction tran)
        {
            bool result = false;
            foreach (DataRow row in tempcart.Rows)
            {
                prod_id = Convert.ToInt64(row[Imei.col_prod_id]);
                imei = row[Imei.col_imei].ToString();
                db.query = "insert into IMEI (tran_id, prod_id, imei, dr, cr, uid)" + Environment.NewLine;
                db.query += "values(" + tran_id + "," + prod_id + ",'" + imei + "'," + dr + "," + cr + "," + User.curUid + ")";

                result = db.runQuery(tran);

                if (!result)
                    return false;
            }
            return result;
        }

        public bool delIMEI(DataTable tmpcart, SqlTransaction tran)
        {
            bool result = false;
            foreach (DataRow row in tmpcart.Rows)
            {
                prod_id = Convert.ToInt64(row[Imei.col_prod_id]);
                imei = row[Imei.col_imei].ToString();
                db.query = "update  IMEI  " + sqlLine;
                db.query += "set status = " + Constants.status_deleted + "" + sqlLine;
                db.query += "where tran_id = " + tran_id + sqlLine;
                result = db.runQuery(tran);

                if (!result)
                    return false;
            }
            return result;
        }
    }
}
