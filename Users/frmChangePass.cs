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
    public partial class frmChangePass : frmBaseUsers
    {
        public frmChangePass()
        {
            InitializeComponent();
        }

        User user = new User();

        bool validation()
        {
            bool res = true;
            Control[] C = new Control[] { passOld, passNew, passConfirm };
            string[] S = new string[] { "Old Password", "New Password", "New Password Again" };
            res = com.chkValid(C, S);
            if (!res)
            {
                com.showMessage(lblMsg, tmrMsg);
                return res;
            }
            res = com.chkPass(passNew);
            if (!res) return res;

            res = com.chkPassword(passOld,lblMsg,tmrMsg);
            if (!res) return res;

            res = (passConfirm.Text == passNew.Text);
            if (!res)
            {
                com.showMessage("Passwords Doesnt Match", lblMsg, Constants.message_info, tmrMsg);
                passConfirm.Focus();
            }

            return res;
        }

        void getData()
        {
            user.pass = passNew.Text;
        }

        private void frmChangePass_Load(object sender, EventArgs e)
        {
            txtUname.Text = User.curUserName;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (!validation())
                return;
            getData();

            user.changePassword();

            if (user.result)
            {
                com.showMessage("Password Changed Successfuly", lblMsg, Constants.message_success, tmrMsg);
                com.clearForm(this);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}