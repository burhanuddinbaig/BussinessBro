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
    public partial class frmDayBook : frmBaseReport
    {
        public frmDayBook()
        {
            InitializeComponent();
        }

        Account_cycle acc = new Account_cycle();
        frmDisplayRep display = new frmDisplayRep("Day Book");

        void secure()
        { 
            bool isAdmin = User.curAuth == 1 || User.curAuth == 2;

            if (!isAdmin)
            {
                dtpDate.MinDate = DateTime.Today;
                rbMonth.Visible = false;
                cmbMonth.Visible = false;
            }
        }

        void getData()
        {
            acc.year = 0;
            acc.month = 0;

            if (rbDaily.Checked)
            {
                acc.date = dtpDate.Value;
            }
            else if (rbMonth.Checked)
            {
                acc.month = Convert.ToInt16(cmbMonth.SelectedIndex + 1);
                acc.year = DateTime.Now.Year;
            }
        }

        private void frmDayBook_Load(object sender, EventArgs e)
        {
            com.loadFormInfo(this, "Day Book", lblTitle);
            secure();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            getData();
            acc.dayBook();
            display.rep = acc.getReport("repDayBook.rpt");
            display.ShowDialog();
        }
    }
}