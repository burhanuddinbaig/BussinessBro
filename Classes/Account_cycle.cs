using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjGrow.Classes
{
    public class Account_cycle: clsReports
    {
        public long cus_id { get; set; }
        public long sup_id { get; set; }
        public long bnk_id { get; set; }
        public long exp_type { get; set; }
        public long emp_id { get; set; }

        public void journal(int year, short month, DateTime date)
        {
            setBounds(year, month, date);

            db.query = "exec createJournal @sdate = '" + sdate + "', @edate = '" + edate + "'";
            db.runQuery();
        }

        public void cashBook(int year, short month, DateTime date)
        {
            setBounds(year, month, date);

            db.query = "exec cashbook @sdate = '"+sdate+"', @edate = '"+edate+"', @cashConfig = " + Constants.config_cash + "";
            db.runQuery();
        }

        public void cashflow(int year, short month, DateTime date)
        {
            setBounds(year, month, date);

            db.query = "exec cashflow @sdate = '" + sdate + "', @edate = '" + edate + "', @configCash = " + Constants.config_cash + "";
            db.runQuery();
        }

        public void cusLedger(int year, short month, bool all)
        {
            setBounds(year, month, all);

            db.query = "exec cusLedger @sdate = '"+sdate+"', @edate = '"+edate+"', @cusId = "+cus_id+"";
            db.runQuery();
        }

        public void cusLedAll()
        {
            db.query = "exec cus_led_all";
            db.runQuery();
        }

        public void supLedger()
        {
            setBounds(year, month, all);

            db.query = "exec supLedger @sdate = '" + sdate + "', @edate = '" + edate + "', @supId = " + sup_id + "";
            db.runQuery();
        }
        public void empLedger()
        {
            setBounds(year, month, all);
            db.query = "exec empLedger @sdate = '" + sdate + "', @edate = '" + edate + "', @empId = " + emp_id + "";
            db.runQuery();
        }
        public void bnkLedger()
        {
            setBounds(year, month, all);

            db.query = "exec bnkLedger @sdate = '" + sdate + "', @edate = '" + edate + "', @bankId = " + bnk_id + "";
            db.runQuery();
        }

        public void expLedger()
        {
            setBounds(year, month, date);

            db.query = "exec expLedger @sdate = '" + sdate + "', @edate = '" + edate + "', @expConfig = " + Constants.config_expense + "";
            db.runQuery();
        }

        public void trial_bal(bool all, int year, short month, DateTime date)
        {
            setBounds(year, month, date, all);

            db.query = "exec trialBal @sdate = '" + sdate + "', @edate = '" + edate + "'";
            db.runQuery();
        }

        public void profitLoss(bool all, int year, short month, DateTime date)
        {
            setBounds(year, month, date, all);

            db.query = "exec profitLoss @sdate = '" + sdate + "', @edate = '" + edate + "'";
            db.runQuery();
        }

        public void dayBook()
        {
            setBounds(year, month, date );

            db.query = "exec dayBook @sdate = '" + sdate + "', @edate = '" + edate + "', @configCash = " + Constants.config_cash + sqlLine;
            db.runQuery();
        }

        public void balSheet()
        {
            db.query = "exec balSheet @todate = '" + edate + "'" + sqlLine;
            db.runQuery();
        }
    }
}