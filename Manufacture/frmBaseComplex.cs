﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prjGrow.Manufacture
{
    public partial class frmBaseComplex : Form
    {
        public frmBaseComplex()
        {
            InitializeComponent();
            tmrMsg.Interval = Constants.interval_message;
        }

        public Common com = new Common();
        short count = 0;
        public bool loading = false;
        public string operation = "";

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
    }
}