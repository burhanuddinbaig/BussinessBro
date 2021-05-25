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
    public partial class frmProfitLoss : frmBaseReport 
    {
        public frmProfitLoss()
        {
            InitializeComponent();
        }

        frmDisplayRep display = new frmDisplayRep("Profit and Loss");
        Account_cycle acc = new Account_cycle();

        void getData()
        {
            if (rbAll.Checked)
            {
                all = true;
                year = 0;
                month = 0;
                date = new DateTime();
            }
            if (rbYear.Checked)
            {
                all = false;
                year = Convert.ToInt32(numYear.Value);
                month = 0;
                date = new DateTime();
            }
            if (rbMonth.Checked)
            {
                all = false;
                year = Convert.ToInt32(numYear.Value);
                month = Convert.ToInt16(cmbMonth.SelectedIndex + 1);
                date = new DateTime();
            }
            else if (rbDaily.Checked)
            {
                all = false;
                year = 0;
                month = 0;
                date = dtpDate.Value;
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            getData();
            acc.profitLoss(all, year, month, date);
            
            display.rep = acc.getReport("repProfitLoss.rpt");
            display.ShowDialog();
        }

        private void frmProfitLoss_Load(object sender, EventArgs e)
        {
            com.loadFormInfo(this, "Profit and Loss Statement", lblTitle);
            rbDaily.Checked = true;
        }
    }
}