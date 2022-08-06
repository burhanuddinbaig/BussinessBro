using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using prjGrow.Classes;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Windows.Forms;

namespace prjGrow.Classes
{
    public class clsReports: Pos
    {
        public DateTime sdate { get; set; }
        public DateTime edate { get; set; }
        public int year { get; set; }
        public short month { get; set; }
        public DateTime date { get; set; }
        public bool all { get; set; }

        public ReportDocument cryRpt = new ReportDocument();
        public TableLogOnInfos crtableLogoninfos = new TableLogOnInfos();
        public TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
        public ConnectionInfo crConnectionInfo = new ConnectionInfo();
        public Tables CrTables;

        public clsDb db = new clsDb();

        public ReportDocument getReport(string repName)
        {
            cryRpt.Load(Application.StartupPath + "\\reports\\" + repName);
            crConnectionInfo.ServerName = Custom.ip_adrs;
            crConnectionInfo.DatabaseName = /*"dbHfp";//*/"dbGrow";
            crConnectionInfo.UserID = "sa";
            crConnectionInfo.Password = "123";
            crConnectionInfo.IntegratedSecurity = false;

            cryRpt.DataSourceConnections.Clear();
            cryRpt.SetDatabaseLogon(crConnectionInfo.UserID, crConnectionInfo.Password, crConnectionInfo.ServerName, crConnectionInfo.DatabaseName);
            
            CrTables = cryRpt.Database.Tables;
            foreach (CrystalDecisions.CrystalReports.Engine.Table CrTable in CrTables)
            {
                crtableLogoninfo = CrTable.LogOnInfo;
                crtableLogoninfo.ConnectionInfo = crConnectionInfo;
                CrTable.ApplyLogOnInfo(crtableLogoninfo);
            }
            cryRpt.Refresh();
            return cryRpt;
        }

        public void setBounds(int year, short month, DateTime date, bool all)
        {
            if (all)
            {
                sdate = new DateTime(2020, 1, 1);
                edate = DateTime.Now;
            }
            else if (year > 0 && month == 0)
            {
                sdate = new DateTime(year, 1, 1, 0, 0, 0);
                edate = new DateTime(year, 12, 31, 23, 59, 59);
            }
            else if (year > 0 && month > 0)
            {
                sdate = new DateTime(year, month, 1, 0, 0, 0);
                if (month == 12)
                {
                    year++;
                    month = (short)0;
                }
                edate = new DateTime(year, month + 1, 1, 0, 0, 0);
            }
            else if (date != null)
            {
                sdate = new DateTime(date.Year, date.Month, date.Day, 0, 0, 0);
                edate = new DateTime(date.Year, date.Month, date.Day, 23, 59, 59);
            }
        }

        public void setBounds(int year, short month, DateTime date)
        {
            if (year > 0 && month == 0)
            {
                sdate = new DateTime(year, 1, 1, 0, 0, 0);
                edate = new DateTime(year, 12, 31, 23, 59, 59);
            }
            else if (year > 0 && month > 0)
            {
                sdate = new DateTime(year, month, 1, 0, 0, 0);
                if(month == 12)
                {
                    year++;
                    month = (short)0;
                }
                edate = new DateTime(year, month + 1, 1, 0, 0, 0);
            }
            else if (date != null)
            {
                sdate = new DateTime(date.Year, date.Month, date.Day, 0, 0, 0);
                edate = new DateTime(date.Year, date.Month, date.Day, 23, 59, 59);
            }
        }

        public void setBounds(int year, short month, bool all = false)
        {
            if (year > 0 && month == 0)
            {
                sdate = new DateTime(year, 1, 1, 0, 0, 0);
                edate = new DateTime(year, 12, 31, 23, 59, 59);
            }
            else if (year > 0 && month > 0)
            {
                sdate = new DateTime(year, month, 1, 0, 0, 0);
                if (month == 12)
                {
                    year++;
                    month = (short)0;
                }
                edate = new DateTime(year, month + 1, 1, 0, 0, 0);
            }
            else if (all)
            {
                sdate = new DateTime(2020, 1, 1, 0, 0, 0);
                edate = DateTime.Now;
            }
        }
    }
}