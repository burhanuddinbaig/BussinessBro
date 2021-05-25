using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace prjGrow.Classes
{
    public  class Inbound : Journal
    {
        public long id { get; set; }
        public DateTime indate { get; set; }
        public long qty { get; set; }
        public long pro_id { get; set; }
        public long cost { get; set; }
        public long whole { get; set; }
        public long retail { get; set; }

        Stock stock = new Stock();

        public DataTable getStoreData(DateTime idate)
        {
            db.query = "select i.id as [" + col_id + "], i.indate as [" + col_inbnd_date + "], i.tran_id as [" + col_tran_id + "],  p.prod_code  as [" + col_prod_code + "], p.prod_name as [" + col_prod_name + "]," + sqlLine;
            db.query += "sum(s.dr) - sum(s.cr) as [" + col_stock + "]" + sqlLine;
            db.query += "from Inbound i inner join stock s on i.tran_id = s.tran_id" + sqlLine;
            db.query += "inner join Product p on s.prod_id = p.id" + sqlLine;
            db.query += "where p.status = " + Constants.status_active + " and s.status = " + Constants.status_active + " and i.status = " + Constants.status_active + sqlLine;
            db.query += " and i.indate = '" + idate.ToShortDateString() + "' " + sqlLine;
            db.query += "group by i.id, i.indate, i.tran_id, p.prod_code, p.prod_name" + sqlLine;

            return db.getDataTable();
        }

        public DataTable getProdTerm(int termA, int termB)
        {
            db.query = "select p.id as [" + col_prod_id + "], p.prod_code  as [" + col_prod_code + "], p.prod_name as [" + col_prod_name + "]," + sqlLine;
            db.query += "(select max(st.cost) from Stock st where st.id = (select max(stk.id) from Stock stk where stk.prod_id = p.id and stk.retail > 0)) as [" + col_cost + "]," + sqlLine;
            db.query += "(select max(st.whole) from Stock st where st.id = (select max(stk.id) from Stock stk where stk.prod_id = p.id and stk.retail > 0)) as [" + col_whole + "]," + sqlLine;
            db.query += "(select max(st.retail) from Stock st where st.id = (select max(stk.id) from Stock stk where stk.prod_id = p.id and stk.retail > 0)) as [" + col_retail + "]," + sqlLine;
            db.query += "isnull( sum(s.dr) - sum(s.cr),0) as [" + col_stock + "]," + sqlLine;
            db.query += "isnull ((select sum(st.dr) - sum(st.cr) from stock st where term_id = " + termA + " and st.prod_id=p.id and status = " + Constants.status_active + "),0) as [" + col_stk_a + "]," + sqlLine;
            db.query += "isnull ( (select sum(st.dr) - sum(st.cr) from stock st where term_id = " + termB + " and st.prod_id=p.id and status = " + Constants.status_active + "),0) as [" + col_stk_b + "]" + sqlLine;
            db.query += "from stock s inner join Product p on s.prod_id = p.id" + sqlLine;
            db.query += "where p.status = " + Constants.status_active + " and s.status = " + Constants.status_active + sqlLine;
            db.query += "group by p.id, p.prod_code, p.prod_name" + sqlLine;

            return db.getDataTable();
        }

        public DataTable getProdInbound()
        {
            db.query = "select p.id as [" + col_prod_id + "], p.prod_code  as [" + col_prod_code + "], p.prod_name as [" + col_prod_name + "]," + sqlLine;
            db.query += "(select max(st.cost) from Stock st where st.id = (select max(stk.id) from Stock stk where stk.prod_id = p.id and stk.retail > 0)) as [" + col_cost + "]," + sqlLine;
            db.query += "(select max(st.whole) from Stock st where st.id = (select max(stk.id) from Stock stk where stk.prod_id = p.id and stk.retail > 0)) as [" + col_whole + "]," + sqlLine;
            db.query += "(select max(st.retail) from Stock st where st.id = (select max(stk.id) from Stock stk where stk.prod_id = p.id and stk.retail > 0)) as [" + col_retail + "]," + sqlLine;
            db.query += " isnull( sum(s.dr) - sum(s.cr),0) as [" + col_stock + "]," + sqlLine;
            db.query += " isnull ((select sum(st.dr) - sum(st.cr) from stock st where term_id = 2 and st.prod_id=p.id and status = " + Constants.status_active + "),0) as [" + col_store + "]," + sqlLine;
            db.query += "isnull ( (select sum(st.dr) - sum(st.cr) from stock st where term_id = 1 and st.prod_id=p.id and status = " + Constants.status_active + "),0) as [" + col_shop + "]" + sqlLine;
            db.query += "from stock s inner join Product p on s.prod_id = p.id" + sqlLine;
            db.query += "where p.status = " + Constants.status_active + " and s.status = " + Constants.status_active + sqlLine;
            db.query += "group by p.id, p.prod_code, p.prod_name" + sqlLine;

            return db.getDataTable();
        }

        public void saveInbound()
        {
            tran_id = getTranidNext();
            narration = "Inbound stock Transaction";
            db.Connect();
            SqlTransaction tran = db.con.BeginTransaction();

            try
            {
                db.query = "insert into Inbound(tran_id, indate)" + sqlLine;
                db.query += "values(" + tran_id + ",'" + indate.ToShortDateString() + "')" + sqlLine;

                result = db.runQuery(tran);
                if (result)
                    result = createTran(tran, indate);
                if (result)
                {
                    stock.termA = 1;
                    stock.termB = 2;
                    stock.saveInboundStock(tran, tran_id, pro_id, cost, whole, retail, qty);
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

                setMessage("Stock", "Transferred");
            }
        }

       
        public void delInbound()
        {
            tran_id = getTranid(id, "Inbound");
            db.Connect();
            SqlTransaction tran = db.con.BeginTransaction();
            try
            {
              result=  deleteTransaction(tran, "Inbound");
              if (result)
                  deleteTransaction(tran, "Stock");
              if (result)
                  deleteTransaction(tran, "Journal");
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

                setMessage("Inbound Record", "Deleted");
            }
        }
    }
}