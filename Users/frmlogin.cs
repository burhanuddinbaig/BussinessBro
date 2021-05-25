using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using prjGrow.Classes;

namespace prjGrow.Users
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        User user = new User();
        Common com = new Common();
        int count = 0;

        AutoCompleteStringCollection col = new AutoCompleteStringCollection();

        void strColect()
        {
            col.AddRange(user.getUserNames());
        }

        bool validPassword()
        { 
            bool res = true;

            Control[] C = new Control[] { txtUname, txtPass };
            string[] S = new string[] { "User Name", "Password" };

            res = com.chkValid(C,S,lblMsg,tmrMsg);
            if(!res) return res;

            string tmpPass = user.getPassword(txtUname.Text);
            
            res = !(string.IsNullOrEmpty(tmpPass));
            if (!res)
            {
                com.showMessage("Please, enter valid user name",lblMsg, Constants.message_info, tmrMsg);
                txtUname.Focus();
                return false;
            }

            User.curPass = user.getPassword(txtUname.Text);

            res = com.chkPassword(txtPass, lblMsg, tmrMsg);

            if (!res)
            {
                com.showMessage("Please, enter valid password", lblMsg, Constants.message_info, tmrMsg);
                txtPass.Focus();
            }

            return res;
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            if (!validPassword())
                return;

//            com.showMessage("Sign In Successfull", lblMsg, Constants.message_successfull, tmrMsg);
            User.login_success = true;
            user.user_name = txtUname.Text;
            user.setData();
            this.Close();
        }

        private void frmlogin_Load(object sender, EventArgs e)
        {
            strColect();
            txtUname.AutoCompleteCustomSource = col;
        }

        private void tmrMsg_Tick(object sender, EventArgs e)
        {
            if (count > 0)
            {
                lblMsg.Hide();
                count = 0;
                tmrMsg.Stop();
            }
            count++;
        }

        private void txtUname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtPass.Focus();
            }
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSignin_Click(sender, e);
            }
        }
    }
}