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
    public partial class frmBalSheet : frmBaseReportSimple
    {
        public frmBalSheet()
        {
            InitializeComponent();
        }

        Account_cycle acc_cycle = new Account_cycle();
        frmDisplayRep display = new frmDisplayRep("Balance Sheet");

        void getData()
        {
            acc_cycle.edate = dtpTodate.Value;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            getData();
            acc_cycle.balSheet();

            display.rep = acc_cycle.getReport("balSheet.rpt");
            display.ShowDialog();
        }

        private void frmBalSheet_Load(object sender, EventArgs e)
        {
            com.loadFormInfo(this, "Balance Sheet",lblTitle);
        }
    }
}
