using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prjGrow.Users
{
    public partial class frmBaseUsers : Form
    {
        public frmBaseUsers()
        {
            InitializeComponent();

            tmrMsg.Interval = Constants.interval_message;
        }

        private short count = 0;
        public Common com = new Common();

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

        private void frmBaseUsers_Load(object sender, EventArgs e)
        {
            tmrMsg.Interval = Constants.interval_message;
        }

    }
}
