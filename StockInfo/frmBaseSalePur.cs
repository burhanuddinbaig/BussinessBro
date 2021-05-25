using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prjGrow.StockInfo
{
    public partial class frmBaseSalePur : Form
    {
        public frmBaseSalePur()
        {
            InitializeComponent();

            tmrMsg.Interval = Constants.interval_message;
        }

        public Common com = new Common();
        public clsDb db = new clsDb();
        private int count = 0;
        public bool loading = false;

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

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void lblPaid_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void numCredit_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numPaid_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numDiscount_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numBillTotal_ValueChanged(object sender, EventArgs e)
        {

        }

        private void frmBaseSalePur_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
