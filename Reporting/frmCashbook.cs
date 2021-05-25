using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CRVsPackageLib;
using CrystalDecisions.Data;
using prjGrow.StockInfo;
using prjGrow.Reporting;
using prjGrow.Classes;

namespace prjGrow.Reports
{
    public partial class frmCashbook : frmBaseReport
    {
        public frmCashbook()
        {
            InitializeComponent();
        }

        Account_cycle acc = new Account_cycle();
        frmDisplayRep display = new frmDisplayRep("Stock Report");

        void getData()
        {
            if (rbMonth.Checked)
            {
                year = Convert.ToInt32(numYear.Value);
                month = Convert.ToInt16(cmbMonth.SelectedIndex + 1);
                date = new DateTime();
            }
            else if (rbDaily.Checked)
            {
                year = 0;
                month = 0;
                date = dtpDate.Value;
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            getData();
            acc.cashflow(year, month, date);

            display.rep = acc.getReport("repCashBook.rpt");
            display.ShowDialog();
        }

        private void frmCashbook_Load(object sender, EventArgs e)
        {
            com.loadFormInfo(this, "Cash Book", lblTitle);
            rbDaily.Checked = true;
        }
    }
}
