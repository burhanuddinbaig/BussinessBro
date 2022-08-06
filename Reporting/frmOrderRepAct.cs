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
    public partial class frmOrderRepAct : frmBaseReportSimple
    {
        public frmOrderRepAct()
        {
            InitializeComponent();
        }

        Manufact_reports reps = new Manufact_reports();
        frmDisplayRep display = new frmDisplayRep("Active Orders Report");

        public void customize()
        {
            if (Custom.client_id_active == 2)
            {
                rbFactory.Visible = true;
                rbReady.Text = "Display";
                rbNew.Text = "New";
            }
        }

        public void getData()
        {
            if (rbAll.Checked)
                reps.prog = 0;
            else if (rbNew.Checked)
                reps.prog = 1;
            else if (rbFactory.Checked)
                reps.prog = 2;
            else if (rbReady.Checked)
                reps.prog = 3;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            getData();
            reps.ordersActive();

            display.rep = reps.getReport("repActiveOrders.rpt");
            display.ShowDialog();
        }

        private void frmOrderRepAct_Load(object sender, EventArgs e)
        {
            com.loadFormInfo("Active Orders", lblTitle);
            customize();
        }
    }
}
