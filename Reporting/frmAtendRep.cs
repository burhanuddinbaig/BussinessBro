using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using prjGrow.Classes;
using prjGrow.Reporting;
namespace prjGrow.Reporting
{
    public partial class frmAtendRep : frmBaseReport
    {
        public frmAtendRep()
        {
            InitializeComponent();
        }

        Gen_reports reps = new Gen_reports();
        frmDisplayRep display = new frmDisplayRep("Attendance Report");

        void getData()
        {
            reps.year = 0;
            reps.month = 0;

            if (rbMonth.Checked)
            {
                reps.year = Convert.ToInt32(numYear.Value);
                reps.month = Convert.ToInt16(cmbMonth.SelectedIndex + 1);
            }
            else if (rbYear.Checked)
                reps.year = Convert.ToInt16(numYear.Value);
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            getData();
            reps.attendReport();

            display.rep = reps.getReport("repAtend.rpt");
            display.ShowDialog();
        }

        private void frmAtendRep_Load(object sender, EventArgs e)
        {
            com.loadFormInfo(this, "Attendance Report", lblTitle);
        }
    }
}
