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
    public partial class frmShortStockRep : frmBaseReportSimple
    {
        public frmShortStockRep()
        {
            InitializeComponent();
        }

        frmDisplayRep dispay = new frmDisplayRep("Short Stock");
        Stock_reports reps = new Stock_reports();

        void getData()
        {
            if (rbBelow.Checked)
                reps.min_stk = Convert.ToInt64(numBelowQty.Value);
            else
                reps.min_stk = 0;
        }

        private void frmShortStockRep_Load(object sender, EventArgs e)
        {
            com.loadFormInfo(this, "Short Stock", lblTitle);
        }
        
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            getData();
            reps.shortStock();

            dispay.rep = reps.getReport("shortStock.rpt");
            dispay.ShowDialog();
        }

        private void rbShort_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbBelow_CheckedChanged(object sender, EventArgs e)
        {
            pnlBelow.Enabled = rbBelow.Checked;
        }
    }
}