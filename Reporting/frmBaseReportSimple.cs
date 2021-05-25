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
    public partial class frmBaseReportSimple : Form
    {
        public frmBaseReportSimple()
        {
            InitializeComponent();
        }

        private short count = 0;
        public Common com = new Common();
        public bool loading = false;

        private void frmBaseReportSimple_Load(object sender, EventArgs e)
        {

        }

        private void tmeMsg_Tick(object sender, EventArgs e)
        {
            if (count > 0)
            {
                lblMsg.Visible = false;
                count = 0;
                tmrMsg.Stop();
            }
            count++;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
