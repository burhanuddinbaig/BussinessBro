using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prjGrow.Reporting
{
    public partial class frmBaseReport : Form
    {
        public frmBaseReport()
        {
            InitializeComponent();

            tmrMsg.Interval = Constants.interval_message;
        }

        private short count = 0;
        public Common com = new Common();

        public bool all = false;
        public int year = 0;
        public short month = 0;
        public DateTime date = new DateTime();

        void UpdateCurrent()
        {
            DateTime dt = DateTime.Now;
            numYear.Value = dt.Year;
            cmbMonth.SelectedIndex = (dt.Month - 1);
            dtpDate.Value = dt;
        }

        private void rbYear_CheckedChanged(object sender, EventArgs e)
        {
            numYear.Enabled = true;
            cmbMonth.Enabled = false;
            dtpDate.Enabled = false;

            numYear.Focus();
            UpdateCurrent();
        }

        private void rbMonth_CheckedChanged(object sender, EventArgs e)
        {
            numYear.Enabled = true;
            cmbMonth.Enabled = true;
            dtpDate.Enabled = false;

            cmbMonth.Focus();
            UpdateCurrent();
        }

        private void rbDaily_CheckedChanged(object sender, EventArgs e)
        {
            numYear.Enabled = false;
            cmbMonth.Enabled = false;
            dtpDate.Enabled = true;

            dtpDate.Focus();
            UpdateCurrent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tmrMsg_Tick(object sender, EventArgs e)
        {
            if (count > 0)
            {
                lblMsg.Visible = false;
                count = 0;
                tmrMsg.Stop();
            }
            count++;
        }

        private void frmBaseReport_Load(object sender, EventArgs e)
        {
            UpdateCurrent();
        }

        private void rbAll_CheckedChanged(object sender, EventArgs e)
        {
            pnlDates.Enabled = !rbAll.Checked;
        }
    }
}