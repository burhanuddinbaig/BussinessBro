using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using prjGrow.Classes;
using prjGrow.StockInfo;

namespace prjGrow.Reporting
{
    public partial class frmJournal : frmBaseReport
    {
        public frmJournal()
        {
            InitializeComponent();
        }

        Account_cycle acc = new Account_cycle();
        frmDisplayRep display = new frmDisplayRep("General Journal");

        void getData()
        {
            if (rbYear.Checked)
            {
                year = Convert.ToInt32(numYear.Value);
                month = 0;
                date = new DateTime();
            }
            else if (rbMonth.Checked)
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

        private void frmJournal_Load(object sender, EventArgs e)
        {
            com.loadFormInfo(this, "General Journal", lblTitle);
            rbDaily.Checked = true;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            getData();
            acc.journal(year, month, date);

            display.rep = acc.getReport("repJournal.rpt");
            display.ShowDialog();
        }
    }
}
