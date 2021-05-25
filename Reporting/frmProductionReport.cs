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
    public partial class frmProductionReport : frmBaseReport
    {
        public frmProductionReport()
        {
            InitializeComponent();
        }

        Manufact_reports reps = new Manufact_reports();
        frmDisplayRep display = new frmDisplayRep("Production Report");

        void getData()
        {
            if (rbMonth.Checked)
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

        private void frmProductionReport_Load(object sender, EventArgs e)
        {
            com.loadFormInfo(this, "Production Report", lblTitle);
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            getData();
            reps.productionReport();

            display.rep = reps.getReport("repProduction.rpt");
            display.ShowDialog();
        }
    }
}