using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace prjGrow.Classes
{
    public class Distribute : Journal
    {
        public Stock stock = new Stock();

        public long id { get; set; }
        public long prod_id { get; set; }
        public long veh_id { get; set; }
        public int veh_term { get; set; }
        public long qty { get; set; }
        public long whole { get; set; }
        public long retail { get; set; }

        public void stockIn()
        {
            tran_id = getTranidNext();
            narration = "Stock In";
            db.Connect();
            SqlTransaction tran = db.con.BeginTransaction();
            try
            {
                db.query = "insert into Stock_distrib(tran_id, ddate, prod_id, veh_id)" + sqlLine;
                db.query += "values(" + tran_id + ",'" + date.ToShortDateString() + "', " + prod_id + ", " + veh_id + ")" + sqlLine;
                result = db.runQuery(tran);
                if (result)
                    result = createTran(tran, date);
                if (result)
                {
                    stock.termA = veh_term;
                    stock.termB = Constants.term_store;
                    stock.saveInboundStock(tran, tran_id, prod_id, 0, whole, retail, qty);
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
                setMessage("Stock", "Out");
            }
        }

        public void stockOut()
        {
            tran_id = getTranidNext();
            narration = "Stock Out";
            db.Connect();
            SqlTransaction tran = db.con.BeginTransaction();
            try
            {
                db.query = "insert into Stock_distrib(tran_id, ddate, prod_id, veh_id)" + sqlLine;
                db.query += "values(" + tran_id + ",'" + date.ToShortDateString() + "', "+prod_id+", "+veh_id+")" + sqlLine;

                result = db.runQuery(tran);
                if (result)
                    result = createTran(tran, date);
                if (result)
                {
                    stock.termA = Constants.term_store;
                    stock.termB = veh_term;
                    stock.saveInboundStock(tran, tran_id, prod_id, 0, whole, retail, qty);
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
                setMessage("Stock", "Out");
            }
        }

        public DataTable getData(bool stockOut)
        {
            db.query = "select d.veh_id as "+col_veh_id+", st.prod_id as "+col_prod_id+", p.prod_name as "+col_prod_name+", d.tran_id as "+col_tran_id+", d.ddate as "+col_date+"" + sqlLine;
            db.query += stockOut ? ", st.dr as " + col_qty + sqlLine + "" : ", st.cr as " + col_qty + "" + sqlLine;
            db.query += "from Stock_distrib d inner join Stock st on d.tran_id = st.tran_id" + sqlLine;
            db.query += "inner join product p on st.prod_id = p.id" + sqlLine;
            db.query += "where d.[status] = " + Constants.status_active + " and st.[status] = " + Constants.status_active + "" + sqlLine;
            db.query += stockOut ? " and st.dr > 0" + sqlLine : " and st.cr > 0" + sqlLine;
            db.query += "and st.term_id = " + veh_term + sqlLine;
            db.query += "and d.veh_id = " + veh_id + "" + sqlLine;
            db.query += "and d.ddate between '" + new DateTime(date.Year, date.Month, date.Day, 0, 0, 0) + "'" + sqlLine;
            db.query += "and '" + new DateTime(date.Year, date.Month, date.Day, 23, 59, 59) + "'" + sqlLine;
            
            return db.getDataTable();
        }
    }
}