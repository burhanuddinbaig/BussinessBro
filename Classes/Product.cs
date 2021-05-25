using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace prjGrow.Classes
{
    public class Product: Gen
    {
        public Int64 id { get; set; }
        public string code { get; set; }
        public string prod_name { get; set; }
        public Int64 type { get; set; }
        public Int64 opening_stock { get; set; }
        public Int64 min_stock { get; set; }
        public string unit { get; set; }
        public Stock stock { get; set; }

        public int term_id = 0;

        public DataTable tblData = null;
        public DataTable tblProd = null;
        public DataTable tblUnit = new DataTable();

        public short category = Constants.cate_stock;
        public bool multiCate = false;
        public bool cateStk = false;
        public bool cateGadget = false;
        public bool cateMobile = false;
        public bool cateBakery = false;
        public bool cateServ = false;
        public bool catePartial = false;
        public bool cateRaw = false;
        public bool ordered = false;
        public bool disabled = false;

        public bool forLabels = false;
        public bool onlyAvailable = false;
        public bool allCate = false;
        
        public Product()
        {
            stock = new Stock();
        }

        public DataTable getProducts()
        {
            db.query = "select p.id as [" + col_id + "], p.prod_code as [" + col_code + "], p.prod_name as [" + col_prod_name + "]" + sqlLine;
            db.query += ", p.type as [" + col_prod_type_id + "], t.name as [" + col_prod_type + "], " + sqlLine;
            db.query += "(select max(st.cost) from Stock st where st.id = (select max(stk.id) from Stock stk where stk.prod_id = p.id and stk.retail > 0)) as [" + col_cost + "]," + sqlLine;
            db.query += "(select max(st.whole) from Stock st where st.id = (select max(stk.id) from Stock stk where stk.prod_id = p.id and stk.retail > 0)) as [" + col_whole + "]," + sqlLine;
            db.query += "(select max(st.retail) from Stock st where st.id = (select max(stk.id) from Stock stk where stk.prod_id = p.id and stk.retail > 0)) as [" + col_retail + "]," + sqlLine;
            if(term_id > 0)
                db.query += "(select max(st.dr) from stock st where st.tran_id = 0 and st.prod_id = p.id and st.status = " + Constants.status_active + " and term_id = " + term_id + ") as [" + col_opening_stock + "]" + sqlLine;
            else
                db.query += "(select max(st.dr) from stock st where st.tran_id = 0 and st.prod_id = p.id and st.status = " + Constants.status_active + ") as [" + col_opening_stock + "]" + sqlLine;
            db.query += ", p.unit as [" + col_unit + "] " + sqlLine;
            db.query += Custom.mod_bakers ? ", (select max(st.expiry) from Stock st where st.tran_id = 0 and st.prod_id = p.id and st.status = " + Constants.status_active + ") as ["+Stock.col_expiry+"]" + sqlLine : "" + sqlLine;
            db.query += ", CASE WHEN p.status = 1 then 'Enabled' else 'Disabled' END as " + col_status + sqlLine;
            db.query += "from Stock s right outer join Product p on p.id = s.prod_id " + sqlLine;
            db.query += "left outer join Prod_type t on p.type = t.id" + sqlLine;
            db.query += disabled ? "where p.status in(" + Constants.status_active + "," + Constants.status_disabled + ")" : "where p.status = " + Constants.status_active + "" + sqlLine + sqlLine;
            db.query += "and (s.status = " + Constants.status_active + " or s.status is null)" + sqlLine;
            if (multiCate)
            {
                db.query += "and p.category in(" + sqlLine;
                db.query += cateStk ? Constants.cate_stock + "," : "";
                db.query += cateGadget ? Constants.cate_gadget + "," : "";
                db.query += cateMobile ? Constants.cate_mobile + "," : "";
                db.query += cateBakery ? Constants.cate_cake + "," : "";
                db.query += cateServ ? Constants.cate_service + "," : "";
                db.query += catePartial ? Constants.cate_partial + "," : "";
                db.query += cateRaw ? Constants.cate_raw + "," : "";
                db.query += "0)" + sqlLine;
            }
            else
                db.query += "and p.category = " + category + "" + sqlLine;
            if (forLabels) db.query += "and (p.prod_code = '' or len(prod_code) = 6)" + sqlLine;
        //    db.query += "and s.id = (select max(stk.id) from Stock stk where stk.prod_id = p.id)" + sqlLine;
            db.query += "group by p.id, p.prod_code, p.prod_name, p.prod_name, p.type, t.name, p.unit, p.status" + sqlLine;
            db.query += Custom.client_id_active == 5 ? "order by p.prod_code, p.prod_name" : "order by p.prod_name" + sqlLine;

            return db.getDataTable();
        }

        public DataTable getUnits()
        {
            db.query = "select title as "+col_unit+" from Units" + sqlLine;
            db.query += Custom.client_id_active == 2 ? "where module = 2" : "" + sqlLine;
            db.query += mod_manufact && !(Custom.client_id_active == 7) ? "where module = 1" : "" + sqlLine;
            db.query += mod_fnb || Custom.client_id_active == 7 ? "where module = 5" : "" + sqlLine;

            return db.getDataTable();
        }

        public void disableProduct(bool disable)
        {
            db.query = "Update Product" + sqlLine;
            db.query += disable ? "set status = " + Constants.status_disabled : "set status = " + Constants.status_active + sqlLine;
            db.query += "where id = " + id + sqlLine;

            result = db.runQuery();
            
            string tmpStr = disable ? "Disabled": "Enabled";
            setMessage( "Product", tmpStr);
        }

        public DataTable getProducts(bool withStock)
        {
            db.query = "select p.id as [" + Product.col_prod_id + "], p.prod_code as [" + col_code + "], p.prod_name as [" + col_prod_name + "]," + sqlLine;
            if (Custom.mod_fnb)
                db.query += "isnull((select max(st.cost) from Stock st where st.id = (select max(stk.id) from Stock stk where stk.prod_id = p.id and stk.cost > 0)), 0) as [" + col_cost + "]," + sqlLine;
            else
                db.query += "isnull((select max(st.cost) from Stock st where st.id = (select max(stk.id) from Stock stk where stk.prod_id = p.id and stk.retail > 0)), 0) as [" + col_cost + "]," + sqlLine;
            db.query += "isnull((select max(st.whole) from Stock st where st.id = (select max(stk.id) from Stock stk where stk.prod_id = p.id and stk.retail > 0)), 0) as [" + col_whole + "]," + sqlLine;
            db.query += "isnull((select max(st.retail) from Stock st where st.id = (select max(stk.id) from Stock stk where stk.prod_id = p.id and stk.retail > 0)), 0) as [" + col_retail + "]," + sqlLine;
            db.query += "Round(isnull((select max(st.frieght) from Stock st where st.id = (select max(stk.id) from Stock stk where stk.prod_id = p.id and stk.frieght > 0)), 0), 2) as [" + col_frieght + "]" + sqlLine;
            db.query += ", case when Round(isnull(sum(s.dr) - sum(s.cr), 0), 2) < 0 then 0 when Round(isnull(sum(s.dr) - sum(s.cr), 0), 2) >= 0 then Round(isnull(sum(s.dr) - sum(s.cr), 0), 2) end as [" + col_stock + "]" + sqlLine;
            db.query += ", p.category as [" + Product.col_cate + "]" + sqlLine;
            db.query += ", p.min_stock as [" + Product.col_min_stock + "]" + sqlLine;
            db.query += Custom.mod_manufact || Custom.mod_fnb || Custom.mod_bakers ? ", p.unit as [" + Product.col_unit + "]" : "";
            db.query += " from Product p left outer join Stock s on p.id = s.prod_id " + sqlLine;
            db.query += " where p.status = " + Constants.status_active + " and (s.status = " + Constants.status_active + " or s.status is null)" + sqlLine;

            if (!ordered)
                db.query += " and s.term_id != " + Constants.term_order_queue + sqlLine;
            db.query += term_id > 0 ? " and s.term_id = " + term_id + sqlLine : "";
            if (allCate) { }
            else if (multiCate)
            {
                db.query += "and p.category in(" + sqlLine;
                db.query += cateStk ? Constants.cate_stock + "," : "";
                db.query += cateGadget ? Constants.cate_gadget + "," : "";
                db.query += cateMobile ? Constants.cate_mobile + "," : "";
                db.query += cateBakery ? Constants.cate_cake + "," : "";
                db.query += cateServ ? Constants.cate_service + "," : "";
                db.query += catePartial ? Constants.cate_partial + "," : "";
                db.query += cateRaw ? Constants.cate_raw + "," : "";
                db.query += "0)" + sqlLine;
            }
            else
                db.query += "and p.category = " + category + "" + sqlLine; 
            db.query += "group by p.id, p.prod_code, p.prod_name, p.category, p.unit, p.min_stock" + sqlLine;
            db.query += onlyAvailable ? "having isnull(sum(s.dr) - sum(s.cr), 0) > 0" : "" + sqlLine;
            db.query += onlyAvailable && cateServ ? " or p.category in (" + Constants.cate_service + ")" + sqlLine : "";
            db.query += onlyAvailable && cateBakery ? " or p.category in (" + Constants.cate_cake + ")" + sqlLine : "";
            db.query += "order by p.prod_name";

            return db.getDataTable();
        }

        public void saveProduct(bool costs = false, bool opening = false)
        {
            stock.prod_id = db.getNextId("Product");
            db.Connect();
            SqlTransaction tran = db.con.BeginTransaction();
            try
            {
                db.query = "insert into Product(prod_code, prod_name, type, category, unit, min_stock" + sqlLine;
                db.query += ", uid)" + sqlLine;
                db.query += " values('" + code + "','" + prod_name + "'," + type + ", " + category + ",'" + unit + "', 0," + User.curUid + ")" + sqlLine;

                result = db.runQuery(tran);
                
                if (result && ( costs || opening))
                {
                    result = stock.saveCosts(tran);
                }
            }
            catch (Exception ex)
            {
                result = false;
            }
            finally
            {
                if (result)
                    tran.Commit();
                else
                    tran.Rollback();
                db.closeCon();
                setMessage("Product", "Saved");
            }
        }

        public void updProduct(bool costs = false, bool opening = false)
        {
            db.Connect();
            SqlTransaction tran = db.con.BeginTransaction();

            try
            {
                db.query = "update product set " + sqlLine;
                db.query += "prod_code = '" + code + "', " + sqlLine;
                db.query += "prod_name = '" + prod_name + "', " + sqlLine;
                db.query += "type = " + type + "," + sqlLine;
                db.query += "category = " + category + "" + sqlLine;
                db.query += "where id = " + this.id + sqlLine;

                result = db.runQuery(tran);

                stock.prod_id = this.id;
                if (result && (costs || opening))
                    result = stock.updateCosts(tran);
            }
            catch (Exception ex)
            {
                result = false;
            }
            finally
            {
                if (result)
                    tran.Commit();
                else
                    tran.Rollback();

                db.closeCon();

                setMessage("Product","Updated");
            }
        }

        public void delProduct()
        {
            long tmp = this.id;
            if (stock.haveEntries(tmp))
            {
                setMessage("Product have entries", Constants.message_warning);
                result = false;
                return;
            }

            db.Connect();
            SqlTransaction tran = db.con.BeginTransaction();

            try
            {
                db.query = "update product set status = " + Constants.status_deleted + sqlLine;
                db.query += "where id = " + this.id + sqlLine;
                result = db.runQuery(tran);

                if (result)
                    result = stock.delStock(tran, 0, this.id);
            }
            catch (Exception ex)
            {
                tran.Rollback();
                result = false;
            }
            finally
            {
                if (result)
                    tran.Commit();
                else
                    tran.Rollback();
                db.closeCon();

                setMessage("Product", "Deleted");
            }   
        }

        public void getShortStock()
        {
            db.query = "select id as ["+col_prod_id+"], prod_name as ["+col_prod_name+"], min_stock as ["+col_min_stock+"]" + sqlLine;
            db.query += "from Product where min_stock > 0" + sqlLine;
            db.query += "order by prod_name" + sqlLine;

            tblData = db.getDataTable();
        }

        public void updShortStock()
        {
            db.query = "update Product set min_stock = " + min_stock + sqlLine;
            db.query += "where id = " + id + sqlLine;

            result = db.runQuery();
            setMessage("Short Stock","Saved");
        }

        public void delShortStock()
        {
            if (!com.delOption("Short Stock"))
                return;
            db.query = "update Product set min_stock = 0 " + sqlLine;
            db.query += "where id = " + id + sqlLine;

            result = db.runQuery();
            setMessage("Short Stock", "Deleted");
        }
    }
}