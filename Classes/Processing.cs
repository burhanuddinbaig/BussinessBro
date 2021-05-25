using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Printing;
using prjGrow.Classes;
using CrystalDecisions.CrystalReports.Engine;

namespace prjGrow.Classes
{
    public class Processing: Journal
    {
        public long id { get; set; }
        public long order_id { get; set; }
        public long prod_id { get; set; }
        public long qty { get; set; }
        public Int16 term_id { get; set; }

        public clsReports reps = new clsReports();

        public long cost_mater = 0, cost_labour = 0, cost_item = 0, cost_tot = 0, price_tot = 0, price_item = 0, profit_gross = 0, profit_item = 0;
        public long stkTermin = 2;
        public long factTermin = 1;

        public bool isOrder = true;
        public bool isProduction = false;
        public long prod_id_raw = 0;
        public double qty_raw = 0, cost_raw = 0;
        public long emp_id = 0, wage = 0;

        public DataTable tblProcessRaw = new DataTable();
        public DataTable tblOrder = null;
        public DataTable tblProdRaw = new DataTable();
        public DataTable tblProds = new DataTable();
        public DataTable tblLabour = new DataTable();

        public Orders order = new Orders();

        public void createProcess()
        {
            tblProcessRaw = new DataTable();
            DataColumn[] Cols = new DataColumn[]
            {
                new DataColumn(col_prod_id),
                new DataColumn(col_prod_name),
                new DataColumn(col_Item_price),
                new DataColumn(col_Item_qty),
                new DataColumn(col_Item_amount, typeof(double)),
                new DataColumn(col_unit)
            };
            tblProcessRaw.Columns.AddRange(Cols);
        }

        public DataTable getProduction(long prodId, DateTime date)
        {
            db.query = "select ps.id as " + col_id + ", ps.prod_id as " + col_prod_id + ", ps.order_id as " + col_order_no + ", ps.tran_id as " + col_tran_id + ", ps.date as " + col_date + "," + sqlLine;
            db.query += "pd.prod_name as " + col_prod_name + ", st.dr as " + col_qty + "" + sqlLine;
          //  db.query += "(select max(stc.retail) from Stock stc where stc.id = (select max(stk.id) from Stock stk where stk.prod_id = pd.id and stk.retail > 0)) as [" + col_retail + "]" + sqlLine;
            db.query += "from Process ps inner join Product pd on ps.prod_id = pd.id" + sqlLine;
            db.query += "inner join Stock st on st.tran_id = ps.tran_id" + sqlLine;
            db.query += "where ps.status = " + Constants.status_active + " and pd.status = " + Constants.status_active + " and st.status = " + Constants.status_active + sqlLine;// (o.status = " + Constants.status_active + " or o.status is null) and
          //  db.query += "and (o.progress not in( " + order_delivered + "," + order_new + ") or o.status is null)" + sqlLine;
            //db.query += "and st.dr > 0" + sqlLine; the quick brown f
            db.query += " and CONVERT(VARCHAR(10), [date], 101) = '" + date.ToShortDateString() + "'" + sqlLine;//prodId > 0 ? " and ps.prod_id = " + prodId + " and datepart(year, ps.date) = datepart(year, '" + date + "')" + sqlLine :
            db.query += "order by ps.date desc" + sqlLine;

            return db.getDataTable();
        }

        public DataTable getProcess(long prodId, DateTime date)
        {
            db.query = "select ps.id as "+col_id+", ps.prod_id as "+col_prod_id+", ps.order_id as "+col_order_no+", ps.tran_id as "+col_tran_id+", ps.date as "+col_date+"," + sqlLine;
            db.query += "pd.prod_name as "+col_prod_name+", st.dr as "+col_qty+", st.retail as "+col_price+", o.descrip as "+col_descrip+"" + sqlLine;
            db.query += "from Process ps left outer join order_item o on ps.order_id = o.order_id" + sqlLine;
            db.query += "inner join Product pd on ps.prod_id = pd.id" + sqlLine;
            db.query += "inner join Stock st on st.tran_id = ps.tran_id" + sqlLine;
            db.query += "where ps.status = " + Constants.status_active+" and (o.status = " + Constants.status_active + " or o.status is null) and pd.status = " + Constants.status_active + " and st.status = " + Constants.status_active + sqlLine;
            db.query += "and (o.progress not in( " + Constants.order_delivered + "," + Constants.order_new + ") or o.status is null)" + sqlLine;
            db.query += "and st.dr > 0" + sqlLine;
            db.query += prodId > 0 ? "and ps.prod_id = " + prodId + " and datepart(year, ps.date) = datepart(year, '" + date + "')" + sqlLine : "and ps.date = '" + date.ToShortDateString() + "'" + sqlLine;
            db.query += "order by ps.date desc" + sqlLine;

            return db.getDataTable();
        }

        public void calCost()
        {
            if (order.qty <= 0 && qty <= 0)
                return;
            if (tblProcessRaw.Rows.Count > 0)
                cost_mater = Convert.ToInt64(tblProcessRaw.Compute("Sum(" + col_Item_amount + ")", ""));
            else
                cost_mater = 0;
            if (tblLabour.Rows.Count > 0)
                cost_labour = Convert.ToInt64(tblLabour.Compute("Sum(" + col_amount + ")", ""));
            else
                cost_labour = 0;
            if (isOrder)
            {
                price_tot = price_item * qty;
                cost_tot = cost_mater + cost_labour;
                profit_gross = price_tot - cost_tot;
                cost_item = cost_tot / qty;
                profit_item = price_item - cost_item;
            }
            else
            {
                price_tot = price_item * qty;
                cost_tot = cost_mater + cost_labour;
                cost_item = cost_tot / qty;
                profit_item = price_item - cost_item;
                profit_gross = price_tot - cost_tot;
            }
        }

        public void saveProduction()
        {
            tran_id = getTranidNext();

            db.Connect();
            SqlTransaction tran = db.con.BeginTransaction();
            try
            {
                db.query = "insert into Process(prod_id, tran_id, date, uid)" + sqlLine;
                db.query += "values(" + prod_id + "," + tran_id + ",'" + date + "'," + User.curUid + ")" + sqlLine;
                result = db.runQuery();

                if (result)
                    result = createTran(tran, date);

                if (result)
                    addGadget(tran);
            }
            catch (Exception ex)
            {
                result = false;
            }
            finally
            {
                db.closeCon();
                if (result)
                    tran.Commit();
                else
                    tran.Rollback();
                setMessage("Production", "Saved");
            }
        }

        public void updProduction()
        {
            db.Connect();
            SqlTransaction tran = db.con.BeginTransaction();
            try
            {
                db.query = "update Process set date = '" + date + "', uid = " + User.curUid + "" + sqlLine;
                db.query += "where tran_id = " + tran_id + sqlLine;
                result = db.runQuery();

                if (result)
                    deleteTransaction(tran, "Stock", "Emp_ledger");
                if (result)
                    addGadget(tran);
            }
            catch (Exception ex)
            {
                result = false;
            }
            finally
            {
                db.closeCon();
                if (result)
                    tran.Commit();
                else
                    tran.Rollback();
                setMessage("Production", "Updated");
            }
        }

        public void delProduction()
        {
            deleteTransaction("Process", "Stock");
            setMessage("Production", "Deleted");
        }

        public void saveProcess()
        {
            acc_id_sal = coa.getAccId(Constants.config_employee);
            tran_id = getTranidNext();

            db.Connect();
            SqlTransaction tran = db.con.BeginTransaction();
            try
            {
                db.query = "insert into Process(order_id, prod_id, tran_id, date, uid)" + sqlLine;
                db.query += "values("+order_id+","+prod_id+","+tran_id+",'"+date+"',"+User.curUid+")" + sqlLine;
                result = db.runQuery();

                if (result)
                    result = createTran(tran, date);

                if (result && tblProcessRaw.Rows.Count > 0)
                    saveProcessStock(tran);

                if (result && tblLabour.Rows.Count > 0)
                    saveWages(tran);
                
                if (result)
                    addGadget(tran);
            }
            catch (Exception ex)
            {
                result = false;
            }
            finally
            {
                db.closeCon();
                if (result)
                    tran.Commit();
                else
                    tran.Rollback();
                setMessage("Process","Saved");
            }
        }

        public void updProcess()
        {
            acc_id_sal = coa.getAccId(Constants.config_employee);

            db.Connect();
            SqlTransaction tran = db.con.BeginTransaction();
            try
            {
                db.query = "update Process set date = '" + date + "', uid = " + User.curUid + "" + sqlLine;
                db.query += "where tran_id = " + tran_id + sqlLine;
                result = db.runQuery();

                if (result)
                    deleteTransaction(tran, "Stock", "Emp_ledger");
                if (result && tblProcessRaw.Rows.Count > 0)
                    saveProcessStock(tran);
                if (result && tblLabour.Rows.Count > 0)
                    saveWages(tran);
                if (result)
                    addGadget(tran);
            }
            catch (Exception ex)
            {
                result = false;
            }
            finally
            {
                db.closeCon();
                if (result)
                    tran.Commit();
                else
                    tran.Rollback();
                setMessage("Process", "Updated");
            }
        }

        public void delProcess()
        {
            deleteTransaction("Process", "Stock", "Emp_ledger");
            setMessage("Process","Deleted");
        }

        public void print()
        {
            if (tran_id <= 0)
                return;
            db.query = "exec processVoucher @tranId = " + tran_id + ", @configEmp = " + Constants.config_employee + sqlLine;
            db.runQuery();

            ReportDocument voucher = reps.getReport("repProcessVoucher.rpt");
            voucher.PrintToPrinter(new PrinterSettings(), new PageSettings(), false);
        }

        public DataTable getProcessLabour()
        {
            db.query = "select el.emp_id as "+col_emp_id+", el.acc_id as "+col_acc_id+", el.name as "+col_emp_name+", el.cr as "+col_amount+"" + sqlLine;
            db.query += "from Process ps inner join led_emp el on ps.tran_id = el.tran_id" + sqlLine;
            db.query += "where ps.status = " + Constants.status_active + sqlLine;
            db.query += "and ps.tran_id = " + tran_id + sqlLine;

            return db.getDataTable();
        }

        public DataTable getProcessItems()
        {
            db.query = "select ps.id as ["+col_id+"], ps.tran_id as ["+col_tran_id+"], st.prod_id as ["+col_prod_id+"], pd.prod_name as ["+col_prod_name+"]" + sqlLine;
            db.query += ", st.cost as [" + col_Item_price + "], st.cr as [" + col_Item_qty + "], st.cost * st.cr as ["+col_Item_amount+"], pd.unit as [" + col_unit + "]" + sqlLine;
            db.query += "from Process ps inner join Stock st on ps.tran_id = st.tran_id" + sqlLine;
            db.query += "inner join Product pd on st.prod_id = pd.id" + sqlLine;
            db.query += "where ps.status = " + Constants.status_active + " and (pd.status = " + Constants.status_active + " or pd.status = " + Constants.status_disabled + ") and st.status = " + Constants.status_active + sqlLine;
            db.query += "and ps.tran_id = " + tran_id + " and st.cr > 0" + sqlLine;
            
            return db.getDataTable();
        }

        public void saveProcessStock(SqlTransaction tran)
        {
            foreach (DataRow row in tblProcessRaw.Rows)
            {
                prod_id_raw = Convert.ToInt64(row[col_prod_id].ToString());
                cost_raw = Convert.ToDouble(row[col_Item_price].ToString());
                qty_raw = Convert.ToDouble(row[col_Item_qty].ToString());

                db.query = "insert into stock(tran_id, prod_id, cost, cr, uid)" + sqlLine;
                db.query += "values("+tran_id+","+prod_id_raw+","+cost_raw+","+qty_raw+","+User.curUid+")" + sqlLine;

                result = db.runQuery(tran);
                if (!result)
                    break;
            }
        }

        public void addGadget(SqlTransaction tran)
        {
            if (isOrder)
                term_id = Constants.term_order_queue;   
            else if (Custom.mod_fnb)
                term_id = Constants.term_shop;
            else if (Custom.client_id_active == 7)
                term_id = Constants.term_store;
            else
                term_id = Constants.term_shop;

            db.query = "insert into stock(tran_id, prod_id, cost, retail, whole, dr, term_id, uid)" + sqlLine;
            db.query += "values(" + tran_id + "," + prod_id + "," + cost_item + "," + price_item + "," + price_item + "," + qty + "," + term_id + "," + User.curUid + ")" + sqlLine;
            result = db.runQuery(tran);

            if (result && isOrder)
            {
                db.query = "update Order_item set progress = " + Constants.order_ready + sqlLine;
                db.query += "where prod_id = " + prod_id + " and order_id = " + order_id + " and status = " + Constants.status_active + sqlLine;
                result = db.runQuery(tran);
            }
        }

        public void saveWages(SqlTransaction tran)
        {
            foreach (DataRow row in tblLabour.Rows)
            {
                emp_id = Convert.ToInt64(row[col_emp_id].ToString());
                acc_id_emp = Convert.ToInt64(row[col_acc_id].ToString());
                wage = Convert.ToInt64(row[col_amount].ToString());

                db.query = "insert into Emp_ledger(emp_id, tran_id, remarks, uid)" + sqlLine;
                db.query += "values("+emp_id+","+tran_id+",'Employee Wage'," + User.curUid + ")" + sqlLine;
                result = db.runQuery(tran);
                if (!result)
                    break;

                result = debit(tran, date, "Employee wage", acc_id_sal, wage);
                if (!result)
                    break;

                result = credit(tran, date, "Employee wage", acc_id_emp, wage);
                if (!result)
                    break;
            }
        }
    }
}