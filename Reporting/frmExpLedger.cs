using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using prjGrow.StockInfo;
using prjGrow.Classes;
using prjGrow.Reporting;

namespace prjGrow.Reporting
{
    public partial class frmExpLedger : frmBaseReport
    {
        public frmExpLedger()
        {
            InitializeComponent();
        }

        frmDisplayRep display = new frmDisplayRep("Employee Ledger");
        Account_cycle acc = new Account_cycle();

        void getData()
        {
            acc.year = 0;
            acc.month = 0;

            if (rbDaily.Checked)
                acc.date = dtpDate.Value;
            else if (rbMonth.Checked)
            {
                acc.month = Convert.ToInt16(cmbMonth.SelectedIndex + 1);
                acc.year = Convert.ToInt16(numYear.Value);
            }
            else if (rbYear.Checked)
                acc.year = Convert.ToInt16(numYear.Value);
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            getData();
            acc.expLedger();
            display.rep = acc.getReport("repExp.rpt");
            display.ShowDialog();
        }

        private void frmExpLedger_Load(object sender, EventArgs e)
        {
            com.loadFormInfo(this, "Expense Ledger", lblTitle);
        }
    }
}
