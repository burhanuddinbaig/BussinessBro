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
    public partial class frmBaseGeneral : Form
    {
        public frmBaseGeneral()
        {
            InitializeComponent();
            tmrMsg.Interval = Constants.interval_message;
        }

        void close()
        {
            this.Close();
        }

        public string frmTitle = Constants.client_name;

        public bool called = false;     //indicated from is shown from another form

        public Constants constant = new Constants();
        public Common com = new Common();
        public bool loading = false;
        public string operation = "";
        public bool close_on_save = false;

        private short count = 0;

        public void btnClose_Click(object sender, EventArgs e)
        {
            close();
        }

        private void frmBaseGeneral_Load(object sender, EventArgs e)
        {
            //lblTitle.Text = frmTitle;
        }

        public bool isSave()
        {
            return operation == "&Save";
        }

        public bool isUpd()
        {
            return operation == "&Update";
        }

        public bool isEdit()
        {
            return operation == "Edit";
        }

        public bool isDel()
        {
            return operation == "Delete";
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
            if (called)
                this.close();
        }
    }
}
