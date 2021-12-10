using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace prjGrow.Classes
{
    public class Stock: Journal
    {
        public long id { get; set; }
        public long prod_id { get; set; }
        public double dr { get; set; }
        public double cr { get; set; }
        public double cost { get; set; }
        public double whole { get; set; }
        public double retail { get; set; }
        public double price { get; set; }
        public double dist { get; set; }
        public double sold { get; set; }
        public float freight { get; set; }
        public DateTime expiry { get; set; }
        public long cate { get; set; }
        public long term_id { get; set; }
        public int termA { get; set; }
        public int termB { get; set; }

        public bool expiryitem = false;

    //    clsDb db = new clsDb();
        public const string col_id = "Id", col_sale_id = "Sale_Id", col_prod_id = "prod_id", col_qty = "Qty", col_expiry = "Expiry";
        public const string col_cost = "Cost", col_retail = "Retail", col_whole = "Whole", col_sold = "Price", col_amount = "Amount";

        public bool saveSaleStock(DataTable cart, long tran_id, SqlTransaction tran)
        {
            if (term_id <= 10)
                term_id = Custom.client_id_active == 7 ? Constants.term_store : Constants.term_shop;
            bool result = false;
            foreach (DataRow row in cart.Rows)
            {
                prod_id = Convert.ToInt64(row[Product.col_prod_id].ToString());
                cost = Convert.ToDouble(row[Product.col_cost].ToString());
                sold = Convert.ToDouble(row[Product.col_price].ToString());
                cr = Convert.ToDouble(row[Product.col_qty].ToString());

                if (Custom.fet_item_dist)
                    dist = Convert.ToDouble(row[Stock.col_item_dist].ToString());
                else
                    dist = 0;

                if (Custom.client_id_active == 5 || Custom.client_id_active == 6 || Custom.client_id_active == 1 || Custom.client_id_active == 2)
                {
                    cate = Convert.ToInt16(row[Product.col_cate].ToString());
                    if (cate == Constants.cate_service)
                    {
                        db.query = "insert into Stock(tran_id, prod_id, dr, term_id, uid)" + Environment.NewLine;
                        db.query += "values(" + tran_id + "," + prod_id + "," + cr + ", " + term_id + ", " + User.curUid + ")";
                        result = db.runQuery(tran);

                        if(!result)
                            return false;
                    }
                }

                db.query = "insert into Stock(tran_id, prod_id, cr, cost, dist, sold, term_id, uid)" + Environment.NewLine;
                db.query += "values(" + tran_id +"," + prod_id +"," + cr +"," + cost +", "+dist+", " + sold +", " + term_id + ", " + User.curUid +")";
                result = db.runQuery(tran);

                if(!result)
                    return false;
            }
            return result;
        }

        public DataTable getSaleStock(long tranId)
        {
            db.query = "select s.id as [" + col_id + "], s.tran_id as [" + col_tran_id + "], s.prod_id as [" + col_prod_id + "], p.prod_name as [" + Product.col_prod_name + "], s.cost as [" + col_cost + "], cr as [" + col_qty + "], sold as [" + col_sold + "], cr * sold as [" + col_amount + "], p.category as [" + Product.col_cate + "], s.dist as "+col_item_dist+"" + sqlLine;
            db.query += "from Stock s inner join product p on s.prod_id = p.id" + sqlLine;
            db.query += "where s.status = " + Constants.status_active + " and (p.status = " + Constants.status_active + " or p.status = "+Constants.status_disabled+")" + sqlLine;
            db.query += "and s.cr > 0 and tran_id = " + tranId + " and s.sold > 0" + sqlLine;
            
            return db.getDataTable();
        }

        public bool deleteStockEntries(long tranId, SqlTransaction tran)
        {
            db.query = "Update Stock set " + sqlLine;
            db.query += "status = " + Constants.status_deleted + sqlLine;
            db.query += "where tran_id = " + tranId;

            return db.runQuery(tran);
        }

        public bool savePurchaseStock(SqlTransaction tran, DataTable cart)
        {
            bool result = false;
            foreach (DataRow row in cart.Rows)
            {
                expiryitem = Custom.mod_bakers && !string.IsNullOrEmpty(row[col_expiry].ToString());

                prod_id = Convert.ToInt64(row[col_prod_id].ToString());
                cost = Convert.ToDouble(row[col_cost].ToString());
                whole = Convert.ToDouble(row[col_whole].ToString());
                retail = Convert.ToInt64(row[col_retail].ToString());
                
                if (Custom.fet_freight)
                    freight = (float)Convert.ToDouble(row[col_frieght].ToString());
                else
                    freight = 0;

                dr = Custom.mod_fnb ? Convert.ToDouble(row[col_qty].ToString()) : Convert.ToInt32(row[col_qty].ToString());
                if (expiryitem) expiry = Convert.ToDateTime(row[col_expiry].ToString());

                db.query = "insert into Stock(tran_id, prod_id, dr, cost, whole, retail, frieght" + Environment.NewLine;
                if (expiryitem) db.query += ", expiry" + sqlLine;
                db.query += ", term_id, uid)" + sqlLine;
                db.query += "values(" + tran_id + "," + prod_id + "," + dr + "," + cost + "," + whole + "," + retail + "," + freight;
                if (expiryitem) db.query += ", '" + expiry + "'" + sqlLine;
                db.query += ", " + term_id + sqlLine;
                db.query += ", " + User.curUid + ")" + sqlLine;
                result = db.runQuery(tran);

                if (!result)
                    return false;
            }
            expiryitem = false;
            return result;
        }

        public DataTable getPurchaseStock(long tranId)
        {
            db.query = "select s.id as [" + col_id + "], s.tran_id as [" + col_tran_id + "], s.prod_id as [" + col_prod_id + "], p.prod_name as [" + Product.col_prod_name + "]" + sqlLine;
            db.query += ", s.cost as [" + col_cost + "], s.retail as [" + col_retail + "], s.whole as [" + col_whole + "], dr as [" + col_qty + "], dr * s.cost as [" + col_amount + "]" + sqlLine;
            db.query += ", expiry as [" + col_expiry + "], p.category as [" + Product.col_cate + "], s.[frieght] as [" + col_frieght + "]" + sqlLine;
            db.query += "from Stock s inner join product p on s.prod_id = p.id" + sqlLine;
            db.query += "where s.status = " + Constants.status_active + " and (p.status = " + Constants.status_active + " or p.[status] = " + Constants.status_disabled + ")" + sqlLine;
            db.query += "and tran_id = " + tranId + sqlLine;

            return db.getDataTable();
        }
        
        public bool saveDamageStock(SqlTransaction tran, long tranId, long prodId, long qty, long cost)
        {
            db.query = "insert into Stock(tran_id, prod_id, cr, cost, uid)" + Environment.NewLine;
            db.query += "values(" + tranId + "," + prodId + "," + qty + "," + cost + "," + User.curUid + ")";

            return db.runQuery(tran);
        }

        public bool saveInboundStock(SqlTransaction tran, long tranId, long prodId, long costPrice, long wholePrice, long retailPrice, long qty)
        {
            db.query = "insert into Stock(tran_id, prod_id, cost, whole, retail, cr, term_id, uid)" + Environment.NewLine;
            db.query += "values(" + tranId + "," + prodId + "," + costPrice + "," + wholePrice + "," + retailPrice + "," + qty + "," + termA + "," + User.curUid + ")";
            result = db.runQuery(tran);
            if (result)
            {
                db.query = "insert into Stock(tran_id, prod_id, cost, whole, retail, dr, term_id, uid)" + Environment.NewLine;
                db.query += "values(" + tranId + "," + prodId + "," + costPrice + "," + wholePrice + "," + retailPrice + "," + qty + "," + termB + "," + User.curUid + ")";
                result = db.runQuery(tran);
            }
            return result;
        }

        public bool delStock(SqlTransaction tran, long tranId, long prodId = 0)
        {
            db.query = "update Stock set status = " + Constants.status_deleted + sqlLine;
            db.query += "where tran_id = " + tranId + sqlLine;
            if (prodId > 0) db.query += "and prod_id = " + prodId + sqlLine;
            db.query += term_id > 0 && Custom.client_id_active == 2 ? "and term_id = " + term_id + sqlLine : "" + sqlLine;
        //    db.query += "and status = " + Constants.status_active + sqlLine;

            return db.runQuery(tran);
        }

        public bool saveCosts(SqlTransaction tran)
        {
            db.query = "insert into Stock(prod_id, cost, retail, whole, dr, tran_id, term_id" + sqlLine;
            db.query += expiryitem ? ", expiry" : "" + sqlLine;
            db.query += ", uid)" + sqlLine;
            db.query += "values(" + prod_id + "," + cost + "," + retail + "," + whole + "," + dr + ", 0, "+term_id+"" + sqlLine;
            db.query += expiryitem ? ", '" + expiry + "'" : "" + sqlLine;
            db.query += ", 0)" + sqlLine;

            return db.runQuery(tran);
        }
        
        public bool updateCosts(SqlTransaction tran)
        {
            delStock(tran, 0, prod_id);

            if(result)
                result = saveCosts(tran);
            
            return result;
        }

        public bool haveEntries(long prodId)
        {
            db.query = "select count(*) as A from stock" + sqlLine;
            db.query += "where prod_id = " + prodId + " and status = " + Constants.status_active + sqlLine;

            return db.readInt() > 1;
        }

        public bool reciveOrder(SqlTransaction tran)
        {
            tran_id = getTranidNext();
            result = createTran(tran, DateTime.Now);

            if (result)
            {
                db.query = "insert into stock(prod_id, cost, retail, whole, dr, cr, tran_id, term_id, uid)" + sqlLine;
                db.query += "values("+prod_id+","+(int)(price * 0.65)+"," + price + "," + price + "," + dr + ",0,"+tran_id+", "+Constants.term_order_queue+","+User.curUid+")" + sqlLine;

                result = db.runQuery(tran);
            }
            return result;
        }
        
        public bool saveRaw(SqlTransaction tran, DataTable tblRaw, long tran_id)
        {
            if (tblRaw.Rows.Count <= 0)
                return true;

            foreach (DataRow row in tblRaw.Rows)
            {
                prod_id = Convert.ToInt64(row[Product.col_raw_id]);
                cost = Convert.ToInt64(row[Product.col_cost]);
                cr = Convert.ToDouble(row[Product.col_qty]);

                db.query = "insert into Stock(tran_id, prod_id, cost, cr, term_id, uid)" + sqlLine;
                db.query += "values("+tran_id+","+prod_id+","+cost+","+cr+",1,"+User.curUid+")" + sqlLine;
                result = db.runQuery(tran);
            }
            return result;
        }

        public bool saveConsumeStk(SqlTransaction tran)
        {
            db.query = "insert into Stock(tran_id, prod_id, cost, cr, term_id, uid)" + sqlLine;
            db.query += "values(" + tran_id + "," + prod_id + "," + cost + "," + cr + "," + term_id + "," + User.curUid + ")" + sqlLine;
            result = db.runQuery(tran);

            return result;
        }
    }
}