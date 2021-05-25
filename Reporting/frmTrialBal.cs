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
    public partial class frmTrialBal : frmBaseReport
    {
        public frmTrialBal()
        {
            InitializeComponent();
        }

        Account_cycle acc = new Account_cycle();
        frmDisplayRep display = new frmDisplayRep("Trial Balance");

        void getData()
        {
            if (rbAll.Checked)
            {
                all = true;
                year = 0;
                month = 0;
                date = new DateTime();
            } 
            else if (rbYear.Checked)
            {
                all = false;
                year = Convert.ToInt32(numYear.Value);
                month = 0;
                date = new DateTime();
            }
            else if (rbMonth.Checked)
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

        private void frmBalSheet_Load(object sender, EventArgs e)
        {
            com.loadFormInfo(this,"Trial Balance", lblTitle);
            rbYear.Checked = true;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            getData();
            acc.trial_bal(all, year, month, date);

            display.rep = acc.getReport("repTrialBal.rpt");
            display.ShowDialog();
        }
    }
}
