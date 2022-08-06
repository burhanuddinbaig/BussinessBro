using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjGrow.Classes
{
    public class Stock_reports: clsReports
    {
        public long prodTypeId { get; set; }
        public short delay { get; set; }
        public short cate { get; set; }
        public long min_stk = 0;
        public long sup_id { get; set; }
        public int cus_id { get; set; }
        public int prod_id { get; set; }
        public string prod_name = "";

        public void saleReport(int year, short month, DateTime date)
        {
            setBounds(year, month, date);

            db.query = "exec repSale @sdate = '"+sdate+"', @edate = '"+edate+"'";
            db.runQuery();
        }

        public void saleDetailReport(int cus_id, int prod_id, int year, short month, DateTime date)
        {
            setBounds(year, month, date);
            
            db.query = "exec repSaleDetail @sdate = '" + sdate + "', @edate = '" + edate + "', @prod_id = " + prod_id + ", @cus_id = " + cus_id + "";
            db.runQuery();
        }

        public void purReport(int year, short month, DateTime date)
        {
            setBounds(year, month, date);

            db.query = "exec repPurchase @sdate = '" + sdate + "', @edate = '" + edate + "'";
            db.runQuery();
        }

        public void stockReport()
        {
            db.query = "exec repStock @prod_type = " + prodTypeId + ", @prod_name = '" + prod_name + "'";
            db.runQuery();
        }

        public void expiryRep()
        {
            db.query = "exec prodExpiry @delayMonth = " + delay;
            db.runQuery();
        }

        public void shortStock()
        {
            db.query = "exec shortStock" + sqlLine;
            db.query += "@min_stk = " + min_stk + sqlLine;
            db.runQuery();
        }

        public void inboundReport()
        {
            setBounds(year, month, date);

            db.query = "exec repInbd @sdate = '" + sdate + "', @edate = '" + edate + "'";
            db.runQuery();
        }

        public void saleSummary()
        {
            setBounds(year, month, date);

            db.query = "exec saleSummary @sdate = '" + sdate + "', @edate = '" + edate + "'";
            db.runQuery();
        }

        public void supOrder()
        {
            db.query = "exec repSupOrder @sup_id = " + sup_id;
            db.runQuery();
        }
    }
}