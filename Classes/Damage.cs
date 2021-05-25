using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace prjGrow.Classes
{
    public class Damage: Journal
    {
        public long id { get; set; }
        public long prod_id { get; set; }
        public string remarks { get; set; }
        public long qty { get; set; }
        public long cost { get; set; }

        Stock stock = new Stock();

        public DataTable getDamage()
        {
            db.query = "select d.id as [" + col_id + "], d.prod_id as [" + col_prod_id + "], p.prod_code  as ["+ col_prod_code +"], p.prod_name as ["+ col_prod_name +"]," + sqlLine;
            db.query += "d.remarks  as [" + col_remarks + "], d.qty  as [" + col_qty + "], d.date as [" + col_date + "], d.tran_id as [" + col_tran_id + "]" + sqlLine;
            db.query += ", sum(s.dr) - sum(s.cr) as [" + col_stock + "]" + sqlLine;
            db.query += "from damage d inner join Product p on d.prod_id = p.id" + sqlLine;
            db.query += "inner join Stock s on d.prod_id = s.prod_id" + sqlLine;
            db.query += "where s.status = " + Constants.status_active + " and d.status = " + Constants.status_active + sqlLine;
            db.query += "group by d.id, d.prod_id, p.prod_code, p.prod_name, d.remarks, d.qty, d.date, d.tran_id" + sqlLine;
            
            return db.getDataTable();
        }

        void getAccIds()
        {
            acc_id_damage = coa.getAccId(Constants.config_goods_damage);
            acc_id_pur = coa.getAccId(Constants.config_purchase);
        }

        public void saveDamage()
        {
            tran_id = getTranidNext();

            getAccIds();

            db.Connect();
            SqlTransaction tran = db.con.BeginTransaction();

            try
            {
                db.query = "insert into Damage(tran_id, prod_id, date, remarks, qty)" + sqlLine;
                db.query += "values(" + tran_id + "," + prod_id + ",'" + date.ToShortDateString() + "','" + remarks + "'," + qty + ")" + sqlLine;

                result = db.runQuery(tran);
                
                if(result)
                    result = createTran(tran, date);
                
                if (result)
                    result = stock.saveDamageStock(tran, tran_id, prod_id, qty, cost);

                if (result)
                    result = debit(tran, date, "Goods Damage", acc_id_damage, qty * cost);

                if (result)
                    result = credit(tran, date, "Goods Damage", acc_id_pur, qty * cost);
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

        public void updDamage()
        {
            getAccIds();
            db.Connect();
            SqlTransaction tran = db.con.BeginTransaction();

            try
            {
                db.query = "update Damage" + sqlLine;
                db.query += "set prod_id = " + prod_id + ", date = '" + date.ToShortDateString() + "', qty = " + qty + ", remarks = '" + remarks + "'" + sqlLine;
                db.query += "where tran_id = " + tran_id + sqlLine;

                result = db.runQuery(tran);
                
                if(result)
                    result = deleteTransaction(tran, "Stock");
                
                if(result)
                result = stock.saveDamageStock(tran, tran_id, prod_id, qty, cost);

                if (result)
                    result = debit(tran, date, "Goods Damage", acc_id_damage, qty * cost);

                if (result)
                    result = credit(tran, date, "Goods Damage", acc_id_pur, qty * cost);
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

        public void delDamage()
        {
            db.Connect();
            SqlTransaction tran = db.con.BeginTransaction();

            try
            {
                result = db.deleteTran(tran, "Damage", tran_id);
                if (!result) { tran.Rollback(); return; }

                result = deleteTransaction(tran);
                if (!result) { tran.Rollback(); return; }

                result = stock.delStock(tran, tran_id);
                if (!result) { tran.Rollback(); return; }

                tran.Commit();
            }
            catch (Exception ex)
            {
                result = false;
                tran.Rollback();
            }
            finally
            {
                db.closeCon();
            }
        }
    }
}