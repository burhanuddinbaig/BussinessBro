using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjGrow.Classes
{
    public class Manufact_reports: clsReports
    {
        public short prog { get; set; }

        public void ordersActive()
        {
            db.query = "EXEC ordersActive @prog = " + prog + sqlLine;
            db.runQuery();
        }

        public void productionReport()
        {
            setBounds(year, month, date);

            db.query = "EXEC repProduction @sdate = '"+sdate+"', @edate = '"+edate+"'" + sqlLine;
            db.runQuery();
        }

        public void repConsume()
        {
            setBounds(year, month, date);

            string procName = Custom.client_id_active == 7 ? "repConsumeSimple" : "repConsume";

            db.query = "Exec " + procName + " @sdate = '" + sdate + "', @edate = '" + edate + "'" + sqlLine;
            db.runQuery();
        }
    }
}