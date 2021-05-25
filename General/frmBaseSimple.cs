using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prjGrow.General
{
    public partial class frmBaseSimple : Form
    {
        public frmBaseSimple()
        {
            InitializeComponent();

            tmrMsg.Interval = Constants.interval_message;
        }

        public Common com = new Common();

        public bool result = true;
        public string operation = "";
        private short count = 0;
        public bool loading = false;
        public bool close_on_save = false;

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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBaseSimple_Load(object sender, EventArgs e)
        {

        }
    }
}
