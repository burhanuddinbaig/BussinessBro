using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace prjGrow.Classes
{
    public class Gen_reports : clsReports
    {
        public void attendReport()
        {
            setBounds(year, month);
            db.query = "exec atendRep @sdate = '"+sdate+"', @edate = '"+edate+"'" + sqlLine;
            db.runQuery();
        }

        public void cusVisit()
        {
            setBounds(year, month);
            db.query = "exec cus_visit_sum @sdate = '" + sdate + "', @edate = '" + edate + "'" + sqlLine;
            db.runQuery();
        }
    }
}