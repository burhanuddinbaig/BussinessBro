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
    public partial class frmSaleSummary : frmBaseReport
    {
        public frmSaleSummary()
        {
            InitializeComponent();
        }

        Stock_reports reps = new Stock_reports();
        frmDisplayRep display = new frmDisplayRep("Sale Summary");
 
        void getData()
        {
            if (rbYear.Checked)
            {
                reps.year = Convert.ToInt32(numYear.Value);
                reps.month = 0;
                reps.date = new DateTime();
            }
            else if (rbMonth.Checked)
            {
                reps.year = Convert.ToInt32(numYear.Value);
                reps.month = Convert.ToInt16(cmbMonth.SelectedIndex + 1);
                reps.date = new DateTime();
            }
            else if (rbDaily.Checked)
            {
                reps.year = 0;
                reps.month = 0;
                reps.date = dtpDate.Value;
            }
        }

        private void frmSaleSummary_Load(object sender, EventArgs e)
        {
            com.loadFormInfo(this, "Sale Summary", lblTitle);
            rbDaily.Checked = true;

            if (!(User.curAuth == 1 || User.curAuth == 2))
                rbMonth.Enabled = rbYear.Enabled = false;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            getData();
            reps.saleSummary();

            display.rep = reps.getReport("repSaleSummary.rpt");
            display.ShowDialog();
        }
    }
}
