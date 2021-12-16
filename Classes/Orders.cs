using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using prjGrow.Classes;
using System.Drawing.Printing;
using CrystalDecisions.CrystalReports.Engine;

namespace prjGrow.Classes
{
    public class Orders : Journal
    {
        public long id { get; set; }
        public DateTime date { get; set; }
        public DateTime target { get; set; }
        public DateTime targetTime { get; set; }
        public long cus_id { get; set; }
        public long paid { get; set; }
        public long amount { get; set; }
        public long discount { get; set; }
        public long remain { get; set; }
        public long total { get; set; }

        public string prod_code { get; set; }
        public string prod_name { get; set; }
        public long prod_id { get; set; }
        public long price { get; set; }
        public long prod_amount { get; set; }
        public int qty { get; set; }
        public long adv_prod { get; set; }
        public float dist_prod { get; set; }
        public long adv { get; set; }
        public short prog { get; set; }
        public string descrip { get; set; }

        clsReports reps = new clsReports();

        public static string col_qty = Custom.client_id_active == 2 ? "Pounds" : "Qty";

        public static string pendingOrders = "";
        public static string readyOrders = "";
        public static string overdueOrders = "";
        
        public Bank_ledger bnk = new Bank_ledger();
        public Cus_ledger cus = new Cus_ledger();
        public Stock stk = new Stock();

        public DataTable tblCart = new DataTable();
        public const int order_new = 1, order_factory = 2, order_late = 0, order_ready = 3, order_deliver = 9;

        public void createCart()
        {
            tblCart = new DataTable();
            tblCart.Columns.Add(col_prod_id, typeof(string));
            tblCart.Columns.Add(col_prod_name, typeof(string));
            tblCart.Columns.Add(col_price, typeof(string));
            tblCart.Columns.Add(col_qty, typeof(string));
            tblCart.Columns.Add(col_amount, typeof(long));
            tblCart.Columns.Add(col_descrip, typeof(string));
            tblCart.Columns.Add(col_discount, typeof(float));
            tblCart.Columns.Add(col_advance, typeof(long));
            tblCart.Columns.Add(col_progress, typeof(long));
        }
        public void saveOrder()
        {
            getAccIds();
            tran_id = getTranidNext();
            id = db.getNextId("Orders");

            db.Connect();
            SqlTransaction tran = db.con.BeginTransaction();
            try
            {
                db.query = "insert into [orders](date, cus_id, target, targetTime, tran_id, uid)" + sqlLine;
                db.query += "values('" + date + "'," + cus_id + ",'" + target.ToShortDateString() + "', '" + targetTime.ToShortTimeString() + "'," + tran_id + "," + User.curUid + ")" + sqlLine;
                result = db.runQuery(tran);
                if(result)
                    saveOrderTran(tran);
                if (result)
                    saveOrderCart(tran);
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

                setMessage("Customer Order", "Saved");
            }
        }
        public void updOrder()
        {
            getAccIds();
            tran_id = getTranid(this.id, "Orders");

            db.Connect();
            SqlTransaction tran = db.con.BeginTransaction();
            try
            {
                db.query = "update orders set" + sqlLine;
                db.query += "date = '" + date + "', target = '" + target.ToShortDateString() + "', targetTime = '" + targetTime.ToShortTimeString() + "'," + sqlLine;
                db.query += "uid = " + User.curUid + "" + sqlLine;
                db.query += "where id = " + this.id + sqlLine;
                result = db.runQuery(tran);

                if(result)
                    result = deleteTransaction(tran);
                if (result)
                    result = saveOrderTran(tran);
                if (result)
                    delOrdersCart(tran);
                if (result)
                    saveOrderCart(tran);
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

                setMessage("Customer Order", "Updated");
            }
        }
        public void progressOrder(short progress)
        {
            string tmpStr = progress == order_factory ? "sent to factory" : "put in display";

            db.Connect();
            SqlTransaction tran = db.con.BeginTransaction();
            try
            {
                db.query = "update order_item set progress = " + progress + sqlLine;
                db.query += "where order_id = " + id + " and prod_id = " + prod_id;
                result = db.runQuery(tran);

                if(result && progress == order_ready)
                    result = stk.reciveOrder(tran);
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
                setMessage("Order", tmpStr);
            }
        }
        public void printReciept()
        {
            string repName = Custom.client_id_active == 5 ? "repOrderRecieptMed.rpt" : "repOrderReciept.rpt";
            db.query = "exec orderReciept @orderId = " + this.id + ", @cusId = " + cus_id + sqlLine;
            db.runQuery();

            ReportDocument reciept = reps.getReport(repName);
            reciept.PrintToPrinter(new PrinterSettings(), new PageSettings(), false);
        }
        public void getAccIds()
        {
            if (adv > 0)
            {
                acc_id_order = coa.getAccId(Constants.config_order);
                acc_id_adv_order = coa.getAccId(Constants.config_adv_order);                
            }
            if (paid > 0 && bnk_id > 0)
                acc_id_bank = coa.getAccId("Bank", bnk_id);
            else if (adv > 0)
                acc_id_cash = coa.getAccId(Constants.config_cash);
            if (remain > 0)
                acc_id_cus = coa.getAccId("Customer", cus.cus_id);
            if (discount > 0)
                acc_id_discount = coa.getAccId(Constants.config_discount);
        }
        public bool saveOrderTran(SqlTransaction tran)
        {
            if (bnk_id > 0)
            {
                bnk.tran_id = tran_id;
                bnk.dr = adv;
                result = bnk.addBankLedger(tran);
                if (result)
                    result = debit(tran, date, "To bank on advance on order", acc_id_bank, adv);
            }
            else
            {
                result = debit(tran, date, "To cash on advance on order", acc_id_cash, adv);
            }

            if (result && cus.cus_id > 0)
            {
                if (result)
                    credit(tran, date, "Paid advance on order", acc_id_adv_order, adv);

                /*                cus.tran_id = tran_id;
                                cus.acc_id_cus = acc_id_cus;
                                cus.date = date;
                                cus.dr = total - discount - adv;
                                cus.cr = adv;
                                result = cus.addCusLedger(tran);*/
            }

/*            if (result)
                result = credit(tran, date, "Customer Order", acc_id_order, total);
            if(result && discount > 0)
                result = debit(tran, date, "Discount on Customer Order", acc_id_discount, discount);*/
            return result;
        }
        public void delOrder()
        {
            tran_id = getTranid(id, "[orders]");
            deleteTransaction(new string[]{"Orders","cus_ledger","bank_ledger"});
            setMessage("Customer Order", "Deleted");
        }
        public void delOrdersCart(SqlTransaction tran)
        {
            db.query = "update order_item set status = " + Constants.status_deleted + sqlLine;
            db.query += "where order_id = " + this.id + sqlLine;

            result = db.runQuery();
        }
        public void saveOrderCart(SqlTransaction tran)
        {
            foreach(DataRow row in tblCart.Rows)
            {
                prod_id = Convert.ToInt64(row[col_prod_id].ToString());
                qty = Convert.ToInt32(row[col_qty].ToString());
                price  = Convert.ToInt64(row[col_price].ToString());
                descrip  = row[col_descrip].ToString();
                adv_prod = Convert.ToInt64(row[col_advance].ToString());
                dist_prod = Convert.ToInt64(row[col_discount].ToString());

                db.query = "insert into order_item(prod_id, order_id, qty, price, adv, dist, descrip, progress, uid)" + sqlLine;
                db.query += "values("+prod_id+","+id+","+qty+","+price+", "+adv_prod+","+dist_prod+",'"+descrip+"', 1,"+User.curUid+")" + sqlLine;
                result = db.runQuery(tran);
                if(!result)
                    break;
            }
        }

        public bool haveOrders(long cusId)
        {
            db.query = "select count(*)" + sqlLine;
            db.query += "from Orders o inner join Order_item i on o.id = i.order_id" + sqlLine;
        //    db.query += Custom.mod_manufact ? "inner join process p on o.id = p.order_id" + sqlLine : "";
            db.query += "inner join stock s on i.prod_id = s.prod_id" + sqlLine;
            db.query += "where cus_id = " + cusId + "" + sqlLine;
            db.query += "and o.status = " + Constants.status_active + " and s.status = " + Constants.status_active;
            db.query += "and i.progress not in (" + order_new + "," + order_factory + "," + order_deliver + ")";
            db.query += "having sum(s.dr) - sum(s.cr) > 0" + sqlLine;
            return db.readInt() > 0;
        }

        public DataTable getCusOrder(long cusId, long orderId)
        {
            db.query = "select o.id as ["+col_order_no+"], o.cus_id as ["+col_cus_id+"], c.name as ["+col_cus_name+"], o.date as ["+col_date+"], o.target as ["+col_target+"]," + sqlLine;
            db.query += "o.targetTime as ["+col_target_time+"], sum(i.adv) as ["+col_advance+"], o.tran_id as ["+col_tran_id+"], sum(i.dist) as ["+col_discount+"]" + sqlLine;
            db.query += ",sum(i.price * i.qty) - sum(i.dist) as " + col_amount + sqlLine;
            db.query += "from Orders o inner join Customer c on o.cus_id = c.id" + sqlLine;
            db.query += "inner join order_item i on o.id = i.order_id" + sqlLine;
            db.query += "where o.status = " + Constants.status_active + " and c.status = " + Constants.status_active + " and i.status = " + Constants.status_active + sqlLine;
            db.query += cusId > 0 ? "and o.cus_id = " + cusId + sqlLine : "";
            db.query += orderId > 0 ? "and o.id = " + orderId + sqlLine : ""; 
            db.query += "group by o.id, o.cus_id, c.name, o.date, o.target, o.targetTime, o.tran_id" + sqlLine;
            db.query += "having max(i.progress) <> " + order_deliver;

            return db.getDataTable();
        }
        public DataTable getOrderProd(bool toDeliver)
        {
            db.query = "select o.id as [" + col_order_no + "], i.prod_id as [" + col_prod_id + "], c.name as [" + col_cus_name + "], p.prod_name  as [" + col_prod_name + "], i.price as [" + col_price + "]," + sqlLine;
            db.query += "i.qty as [" + col_qty + "], i.price * i.qty as [" + col_amount + "], i.dist as ["+col_discount+"], i.adv as [" + col_advance + "], (i.price * i.qty) - i.dist - i.adv as [" + col_remain + "], i.descrip as [" + col_descrip + "], i.progress as [" + col_progress + "]" + sqlLine;
            db.query += ",o.date as [" + col_date + "], o.target as ["+col_target+"]" + sqlLine;
            db.query += toDeliver && Custom.mod_manufact ? ",(select st.cost from stock st inner join process ps on st.tran_id = ps.tran_id where ps.order_id = o.id and ps.prod_id = i.prod_id and st.dr > 0 and st.status = 1 and ps.status = 1) as " + col_cost + sqlLine : "";
            db.query += toDeliver && !Custom.mod_manufact ? ",i.price * 0.65 as ["+col_cost+"]" : "";
            db.query += "from Order_item i inner join Product p on i.prod_id = p.id" + sqlLine;
            db.query += "inner join Orders o on i.order_id = o.id" + sqlLine;
            db.query += "inner join Customer c on o.cus_id = c.id" + sqlLine;
            db.query += "where i.status = " + Constants.status_active + " and p.status = " + Constants.status_active + " and o.status = " + Constants.status_active + " and c.status = " + Constants.status_active + sqlLine;
            db.query += toDeliver ? "and i.progress in (" + order_ready + ")" + sqlLine : "and i.progress not in ("+order_deliver+"," + order_ready + ")" + sqlLine;
            db.query += toDeliver ? "and o.cus_id = " + cus_id + sqlLine : "";
            return db.getDataTable();
        }
        public DataTable getOrderProgress()
        {
            db.query = "select o.id as [" + col_order_no + "], o.date as [" + col_date + "], i.prod_id as [" + col_prod_id + "], cs.name as [" + col_cus_name + "],  p.prod_name  as [" + col_prod_name + "]," + sqlLine;
            db.query += "i.qty as [" + col_qty + "], i.price as [" + col_price + "], i.descrip as [" + col_descrip + "], i.progress as [" + col_prog_id + "]," + sqlLine;
            db.query += "pg.name as [" + col_progress + "]" + sqlLine;
            db.query += "from Order_item i inner join Product p on i.prod_id = p.id" + sqlLine;
            db.query += "inner join Orders o on i.order_id = o.id" + sqlLine;
            db.query += "inner join Progress pg on i.progress = pg.id" + sqlLine;
            db.query += "inner join Customer cs on o.cus_id = cs.id" + sqlLine;
            db.query += "where i.status = " + Constants.status_active + " and p.status = " + Constants.status_active + " and o.status = " + Constants.status_active + " and cs.status = " + Constants.status_active + sqlLine;
            db.query += "and i.progress not in (" + order_deliver + ")" + sqlLine;
            
            return db.getDataTable();
        }
        public DataTable getOrderItems()
        {
            db.query = "select i.prod_id as [" + col_prod_id + "], p.prod_name  as [" + col_prod_name + "], i.price as [" + col_price + "]," + sqlLine;
            db.query += "i.qty as [" + col_qty + "], i.price * i.qty as ["+col_amount+"], i.dist as ["+col_discount+"], i.adv as ["+col_advance+"], i.descrip as [" + col_descrip + "], i.progress as [" + col_progress + "]" + sqlLine;
            db.query += "from Order_item i inner join Product p" + sqlLine;
            db.query += "on i.prod_id = p.id" + sqlLine;
            db.query += "where i.status = " + Constants.status_active + " and p.status = " + Constants.status_active + sqlLine;
            db.query += "and i.order_id = " + this.id + sqlLine;

            return db.getDataTable();
        }
        
        public void getDashboardOrders()
        {
            DataTable dt = new DataTable();
            db.query = @"select p.name, oi.progress as prog, count(oi.id) AS count
                        FROM Progress p inner join Order_item oi on p.id = oi.progress 
                        inner join Orders o on oi.order_id = o.id
                        where (o.[target] >= CONVERT(DATETIME, '" + DateTime.Today + @"', 102) or oi.progress > 1) 
                        and o.[status] = 1 and oi.[status] = 1 and oi.progress < 9 
                        group by p.name, oi.progress";

            dt = db.getDataTable();
            pendingOrders = dt.Compute("Sum([count])", "prog = 1").ToString();
            pendingOrders = string.IsNullOrEmpty(pendingOrders) ? "000" : pendingOrders;
            readyOrders = dt.Compute("Sum([count])", "prog = 3").ToString();
            readyOrders = string.IsNullOrEmpty(readyOrders) ? "000" : readyOrders;
            getOverDueOrders();
        }

        public int getCurOrders()
        {
            db.query = @"select count(oi.id) AS count
                        FROM Progress p inner join Order_item oi on p.id = oi.progress 
                        inner join Orders o on oi.order_id = o.id
                        where oi.progress in (1,2,3) 
                        and o.[status] = 1 and oi.[status] = 1";

            return db.readInt();
        }

        public void getOverDueOrders()
        {
            DataTable dt = new DataTable();
            db.query = @"select p.name, oi.progress as prog, count(oi.id) AS count
                        FROM Progress p inner join Order_item oi on p.id = oi.progress 
                        inner join Orders o on oi.order_id = o.id
                        where (o.[target] < CONVERT(DATETIME, '" + DateTime.Today + @"', 102) and oi.progress = 1) 
                        and o.[status] = 1 and oi.[status] = 1 
                        group by p.name, oi.progress";


            dt = db.getDataTable();
            if (dt.Rows.Count > 0)
            {
                overdueOrders = dt.Rows[0]["count"].ToString();
                overdueOrders = string.IsNullOrEmpty(overdueOrders) ? "000" : overdueOrders;
            }
            else
                overdueOrders = "000";
        }
    }
}