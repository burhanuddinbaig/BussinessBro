using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace prjGrow.Classes
{
    public class Complementry : Journal
    {
        public long id { get; set; }
        public long prod_id { get; set; }
        public double qty { get; set; }
        public double stk { get; set; }
        public double cost { get; set; }
        public string remarks { get; set; }

        public DataTable tblProd = new DataTable();
        public DataTable tblData = new DataTable();
        Stock stock = new Stock();

        public DataTable getComp()
        {
            db.query = "select c.id as [" + col_id + "], c.tran_id as ["+col_tran_id+"], c.prod_id as ["+col_prod_id+"]," + sqlLine;
            db.query += "p.prod_name as ["+col_prod_name+"], c.date as ["+col_date+"], c.remarks as ["+col_remarks+"], c.qty as ["+col_qty+"]" + sqlLine;
            db.query += "from Comp c inner join Product p on c.prod_id = p.id" + sqlLine;
            db.query += "where c.[status] = " + Constants.status_active + " and p.[status] = " + Constants.status_active + "" + sqlLine;
            db.query += "and c.date = '" + date.ToShortDateString() + "'" + sqlLine;

            return db.getDataTable();
        }

        void getAccIds()
        {
            acc_id_comp = coa.getAccId(Constants.config_comp);
            acc_id_pur = coa.getAccId(Constants.config_purchase);
        }

        public void saveComp()
        {
            tran_id = getTranidNext();
            getAccIds();

            db.Connect();
            SqlTransaction tran = db.con.BeginTransaction();

            try
            {
                db.query = "insert into Comp(tran_id, prod_id, date, remarks, qty, uid)" + sqlLine;
                db.query += "values(" + tran_id + "," + prod_id + ",'" + date.ToShortDateString() + "','" + remarks + "'," + qty + ", " + User.curUid + ")" + sqlLine;

                result = db.runQuery(tran);

                if (result)
                    result = createTran(tran, date);

                if (result)
                    result = stock.saveDamageStock(tran, tran_id, prod_id, (long)qty, (long)cost);

                if (result)
                    result = debit(tran, date, "Complementry", acc_id_comp, (long)(qty * cost));

                if (result)
                    result = credit(tran, date, "Complementry", acc_id_pur, (long)(qty * cost));
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
            }
        }

        public void updComp()
        {
            getAccIds();
            db.Connect();
            SqlTransaction tran = db.con.BeginTransaction();

            try
            {
                db.query = "update Comp set prod_id = " + prod_id + ", date = '" + date.ToShortDateString() + sqlLine;
                db.query += "', remarks = '" + remarks + "', qty = " + qty + ", uid = " + User.curUid + sqlLine;
                db.query += "where tran_id = " + tran_id + sqlLine;

                result = db.runQuery(tran);

                if (result)
                    deleteTransaction(tran, "Stock");

                if (result)
                    result = createTran(tran, date);

                if (result)
                    result = stock.saveDamageStock(tran, tran_id, prod_id, (long)qty, (long)cost);

                if (result)
                    result = debit(tran, date, "Complementry", acc_id_comp, (long)(qty * cost));

                if (result)
                    result = credit(tran, date, "Complementry", acc_id_pur, (long)(qty * cost));
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
            }
        }

        public void delComp()
        {
            deleteTransaction("Stock", "Comp");
            com.setMessage("Complementry", "Deleted");
        }
    }
}
