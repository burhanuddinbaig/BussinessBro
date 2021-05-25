using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using System.Drawing.Printing;

namespace prjGrow.Classes
{
    public class Foodnb : Journal
    {
        public Foodnb()
        {
            createCart();
            createCartAll();
            createPending();
        }

        public long id { get; set; }
        public long prod_id { get; set; }
        public long tbl_id { get; set; }
        public string tbl_name { get; set; }
        public string dish_name { get; set; }
        public long dish_cost { get; set; }
        public long dish_qty { get; set; }
        public long dish_price { get; set; }
        public long cus_id { get; set; }

        public long bill_tot { get; set; }
        public long discount { get; set; }
        public long bill_amt { get; set; }
        public long paid { get; set; }
        public long remain { get; set; }

        public Sale sale = new Sale();
        public Stock stk = new Stock();
        public Cus_ledger cusLed = new Cus_ledger();
        public Stock_reports reps = new Stock_reports();

        public DataTable tblCart = new DataTable();
        public DataTable tblCartAll = new DataTable();
        public DataTable tblPending = new DataTable();

        public void createCart()
        {
            DataColumn[] Cols = new DataColumn[] {
                new DataColumn(col_tbl_id, typeof(long)),
                new DataColumn(col_prod_id, typeof(long)),
                new DataColumn(col_prod_name, typeof(string)),
                new DataColumn(col_qty, typeof(int)),
                new DataColumn(col_price, typeof(long)),
                new DataColumn(col_amount, typeof(long)),
                new DataColumn(col_cost, typeof(long))
            };
            tblCart.Columns.AddRange(Cols);
        }

        public void createCartAll()
        {
            DataColumn[] Cols = new DataColumn[] {
                new DataColumn(col_tbl_id, typeof(long)),
                new DataColumn(col_prod_id, typeof(long)),
                new DataColumn(col_prod_name, typeof(string)),
                new DataColumn(col_qty, typeof(int)),
                new DataColumn(col_price, typeof(long)),
                new DataColumn(col_amount, typeof(long)),
                new DataColumn(col_cost, typeof(long))
            };
            tblCartAll.Columns.AddRange(Cols);
        }

        public void createPending()
        {
            DataColumn[] Cols = new DataColumn[] {
                new DataColumn(col_tbl_id, typeof(long)),
                new DataColumn(col_prod_id, typeof(long)),
                new DataColumn(col_tbl_name, typeof(string)),
                new DataColumn(col_prod_name, typeof(string)),
                new DataColumn(col_qty, typeof(int))
            };
            tblPending.Columns.AddRange(Cols);
        }

        public void clearCarts()
        {
            com.delRows(tblPending, col_tbl_id, tbl_id);
            com.delRows(tblCartAll, col_tbl_id, tbl_id);
            com.delRows(tblCart, col_tbl_id, tbl_id);
        }

        public void filterCart()
        {
            DataTable tblTmp = com.filterValueToTable(tblCartAll, col_tbl_id, tbl_id.ToString());

            if ( tblTmp != null )
                tblCart = tblTmp;
        }

        public void addToCartAll()
        {
            for (int i = tblCartAll.Rows.Count-1; i >= 0; i-- )
            {
                if(Convert.ToInt32(tblCartAll.Rows[i][col_tbl_id]) == tbl_id)
                    tblCartAll.Rows.RemoveAt(i);
            }

            foreach (DataRow row in tblCart.Rows)
            {
                tblCartAll.Rows.Add(tbl_id, row[col_prod_id], row[col_prod_name], row[col_qty], row[col_price], Convert.ToInt32(row[col_qty]) * Convert.ToInt32(row[col_price]), Convert.ToInt32(row[col_cost]));
            }
        }

        public void getAccIds()
        {
            acc_id_cash = coa.getAccId(Constants.config_cash);
            acc_id_cus = coa.getAccId("Customer", cus_id);
            acc_id_discount = coa.getAccId(Constants.config_discount);
            acc_id_sale = coa.getAccId(Constants.config_sale);
            tran_id = getTranidNext();
            stk.tran_id = tran_id;
            sale.tran_id = tran_id;
        }

        public void saveOrder()
        {
            getAccIds();
            db.Connect();
            SqlTransaction tran = db.con.BeginTransaction();
            try
            {
                result = sale.addSale(tran);
                if (result)
                    result = stk.saveSaleStock(tblCart, tran_id, tran);
                if (result && paid > 0)
                    result = debit(tran, date, "Paid on Sale", acc_id_cash, paid);
                if (result && cus_id > 0)
                {
                    cusLed.tran_id = tran_id;
                    cusLed.cus_id = cus_id;                                     ///Save Customer Ledger
                    cusLed.dr = bill_amt - paid;
                    cusLed.date = date;

                    if (result)
                        result = cusLed.addCusLedger(tran);
                    result = debit(tran, date, "Remaining to Customer", acc_id_cus, bill_amt - paid);
                }
                if (result && discount > 0)
                    result = debit(tran, date, "Discount on Sale", acc_id_discount, discount);
                if (result)
                    result = credit(tran, date, "Sale", acc_id_sale, bill_tot);
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
                setMessage("Order", "Saved");
            }
        }

        public void printBill()
        {
            db.query = "exec createSaleInvoice @tranId = " + tran_id + ", @accid = " + acc_id_cus;
            db.runQuery();
            
            ReportDocument rep = reps.getReport("repSaleRecipt.rpt");
            rep.PrintToPrinter(new PrinterSettings(), new PageSettings(), false);
        }

    /*    public void updOrder()
        {
            
        }

        public void delOrder()
        { 
            
        }*/
    }
}