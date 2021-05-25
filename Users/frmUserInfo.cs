using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using prjGrow.Classes;
using prjGrow.General;

namespace prjGrow.Users
{
    public partial class frmUserInfo : frmBaseSimple
    {
        public frmUserInfo()
        {
            InitializeComponent();
        }

        User user = new User();
        DataTable tblAuth = null;
        DataTable tblUsers = null;

        bool validation()
        {
            Control[] C = new Control[] { txtUserName, txtFullName, cmbAuthority };
            string[] S = new string[] { "User Name","Full Name","Authority" };

            return com.chkValid(C, S);
        }

        void getData()
        {
            user.user_name = txtUserName.Text;
            user.full_name = txtFullName.Text;
            user.pass = passDefault.Text;
            user.auth_id = Convert.ToInt16(cmbAuthority.SelectedValue);
        }

        public void loadAuth()
        {
            tblAuth = user.getAuthorities();
            com.loadCombo(cmbAuthority, tblAuth, Gen.col_auth_name, Gen.col_auth_id);
        }

        public void loadData()
        {
            tblUsers = user.getUsers();
            dgvData.DataSource = tblUsers;
            com.hideColumns(dgvData, new string[] { Gen.col_id, Gen.col_user_id, Gen.col_auth_id } );
        }

        public void clear()
        {
            Control[] C = new Control[] { txtFullName, txtUserName, cmbAuthority };
            com.clearControls(C, txtUserName, null);
        }

        private void frmUserInfo_Load(object sender, EventArgs e)
        {
            loadData();
            loadAuth();
            com.loadFormInfo(this, "Add Users",lblClient, lblTitle);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
            loadData();
        }

        private void btnSaveUpd_Click(object sender, EventArgs e)
        {
            if (!validation())
                return;
            getData();

            user.saveUser();

            if (user.result)
            {
                clear();
                loadData();
            }
            com.showMessage(user.msg, lblMsg, user.msg_type, tmrMsg );
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0)
                return;

            DataGridViewRow row = dgvData.Rows[e.RowIndex]; 

            if (dgvData.Columns[e.ColumnIndex].Name == "Disable")
            {
                string tmpName = row.Cells[Gen.col_full_name].Value.ToString();
                
                if (!com.sureOption("Do you want to Disable " + tmpName))
                    return;

                user.id = Convert.ToInt64(row.Cells[Gen.col_user_id].Value);
                user.delUser();

                if (user.result)
                {
                    clear();
                    loadData();
                }
                com.showMessage(user.msg,lblMsg, user.msg_type, tmrMsg);
            }
        }
    }
}