using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using prjGrow.StockInfo;
using prjGrow.Classes;

namespace prjGrow.Reporting
{
    public partial class frmSaleRep : frmBaseReport
    {
        public frmSaleRep()
        {
            InitializeComponent();
        }

        Stock_reports reps = new Stock_reports();
        frmDisplayRep display = new frmDisplayRep("Sale Report");

        void getData()
        {
            if (rbMonth.Checked)
            {
                year = Convert.ToInt32(numYear.Value);
                month = Convert.ToInt16(cmbMonth.SelectedIndex + 1);
                date = new DateTime();
            }
            else if (rbDaily.Checked)
            {
                year = 0;
                month = 0;
                date = dtpDate.Value;
            }
        }

        void customize()
        {
            rbMonth.Visible = !(Custom.client_id_active == 5);
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string repName = Custom.client_id_active == 5 ? "repSaleDetail.rpt" : "repSale.rpt";
            getData();
            reps.saleReport(year, month, date);

            display.rep = reps.getReport(repName);
            display.ShowDialog();
        }

        private void frmSaleRep_Load(object sender, EventArgs e)
        {
            com.loadFormInfo(this,  "Sale Report", lblClient, lblTitle );
            customize();
        }
    }
}