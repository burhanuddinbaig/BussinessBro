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

namespace prjGrow.Reporting
{
    public partial class frmPurRep : frmBaseReport
    {
        public frmPurRep()
        {
            InitializeComponent();
        }

        Stock_reports rep = new Stock_reports();
        frmDisplayRep display = new frmDisplayRep("Purchase Report");

        void getData()
        {
            if (rbYear.Checked)
            {
                year = Convert.ToInt32(numYear.Value);
                month = 0;
            }
            else if (rbMonth.Checked)
            {
                year = Convert.ToInt32(numYear.Value);
                month = Convert.ToInt16(cmbMonth.SelectedIndex + 1);
            }
            else if (rbDaily.Checked)
            {
                year = 0;
                month = 0;
                date = dtpDate.Value;
            }
        }

        private void frmPurRep_Load(object sender, EventArgs e)
        {
            com.loadFormInfo(this, "Purchase Report",lblTitle);
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            getData();

            rep.purReport(year, month, date);
            display.rep = rep.getReport("repPur.rpt");
            display.ShowDialog();
        }
    }
}