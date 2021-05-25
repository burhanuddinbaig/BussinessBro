using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using prjGrow.Classes;

namespace prjGrow.Reporting
{
    public partial class frmCashflow : frmBaseReport
    {
        public frmCashflow()
        {
            InitializeComponent();
        }

        frmDisplayRep display = new frmDisplayRep("Cash Flow Statement");
        Account_cycle acc = new Account_cycle();

        void getData()
        {
            if (rbYear.Checked)
            {
                year = Convert.ToInt32(numYear.Value);
                month = 0;
                date = new DateTime();
            }
            else if (rbMonth.Checked)
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

            display.rep = acc.getReport("repCashflow.rpt");
            display.ShowDialog();
        }

        private void frmCashflow_Load(object sender, EventArgs e)
        {
            com.loadFormInfo(this, "Cash Flow Statement", lblTitle);
            rbDaily.Checked = true;
        }
    }
}
