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
    public partial class frmPriceList : frmBaseReportSimple
    {
        public frmPriceList()
        {
            InitializeComponent();
        }

        Stock_reports reps = new Stock_reports();
        frmDisplayRep display = new frmDisplayRep("Price List");

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            reps.stockReport();

            display.rep = reps.getReport("repPriceList.rpt");
            display.ShowDialog();
        }

        private void frmPriceList_Load(object sender, EventArgs e)
        {
            com.loadFormInfo(this, "Price List", lblTitle);
        }
    }
}
