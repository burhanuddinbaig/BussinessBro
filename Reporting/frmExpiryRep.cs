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
    public partial class frmExpiryRep : frmBaseReportSimple
    {
        public frmExpiryRep()
        {
            InitializeComponent();
        }

        Stock_reports stock = new Stock_reports();
        frmDisplayRep display = new frmDisplayRep("Expiry Report");

        void getData()
        {
            if (rbFour.Checked)
                stock.delay = 4;
            else if (rbTwo.Checked)
                stock.delay = 2;
            else if (rbExpired.Checked)
                stock.delay = 0;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            getData();
            stock.expiryRep();

            display.rep = stock.getReport("repExpiry.rpt");
            display.ShowDialog();
        }

        private void frmExpiryRep_Load(object sender, EventArgs e)
        {
            com.loadFormInfo(this, "Expiry Report", lblTitle);
        }
    }
}