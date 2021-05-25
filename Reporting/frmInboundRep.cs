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
    public partial class frmInboundRep : frmBaseReport
    {
        public frmInboundRep()
        {
            InitializeComponent();
        }

        Stock_reports stk = new Stock_reports();
        frmDisplayRep display = new frmDisplayRep("Inbound Report");

        void getData()
        {
            stk.year = 0;
            stk.month = 0;
            
            if (rbMonth.Checked)
            {
                stk.month = Convert.ToInt16(cmbMonth.SelectedIndex + 1);
                stk.year = Convert.ToInt32(numYear.Value);
            }
            else if (rbDaily.Checked)
            {
                stk.date = dtpDate.Value;
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            getData();
            stk.inboundReport();

            display.rep = stk.getReport("repInbd.rpt");
            display.ShowDialog();
        }

        private void frmInboundRep_Load(object sender, EventArgs e)
        {
            com.loadFormInfo(this, "Inbound Report", lblTitle);
        }
    }
}