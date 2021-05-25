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
    public partial class frmCusVisitSummary : frmBaseReport
    {
        public frmCusVisitSummary()
        {
            InitializeComponent();
        }

        frmDisplayRep display = new frmDisplayRep("Customer Visit Summary");
        Gen_reports reps = new Gen_reports();

        void getData()
        { 
            if(rbYear.Checked)
            {
                reps.year = Convert.ToInt32(numYear.Value);
                reps.month = 0;
            }
            else if (rbMonth.Checked)
            {
                reps.year = Convert.ToInt32(numYear.Value);
                reps.month = Convert.ToInt16(cmbMonth.SelectedIndex + 1);
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            getData();
            reps.cusVisit();

            display.rep = reps.getReport("repCusVisit.rpt");
            display.ShowDialog();
        }

        private void frmCusVisitSummary_Load(object sender, EventArgs e)
        {
            com.loadFormInfo(this, "Customer Visit Summary", lblTitle);
            rbMonth.Checked = true;
        }
    }
}
