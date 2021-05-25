using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using prjGrow.Classes;

namespace prjGrow.General
{
    public partial class frmBank : frmBaseSimple
    {
        public frmBank()
        {
            InitializeComponent();
        }

        Bank bnk = new Bank();
        Common common = new Common();

        bool validation()
        {
            bool b = true;
            Control[] C = new Control[] { txtBankName };
            string[] S = new string[] { "Bank Name" };
            b = common.chkValid(C, S, lblMsg, tmrMsg);
            if (b && btnSaveUpd.Text == "&Save")
            {
                b = !com.DataExists(txtAccNo.Text, Bank.col_acc_no, (DataTable)dgvData.DataSource);
                com.setMessage("Bank Already Exists", Constants.message_info);
            }
            if (!b)
                com.showMessage(lblMsg, tmrMsg);
            return b;
        }

        void getData()
        {
            bnk.name = txtBankName.Text;
            bnk.bnk_acc_no = txtAccNo.Text;
            bnk.acc_name = bnk.name;
        }

        void loadData()
        {
            dgvData.DataSource = bnk.getBanks();
            common.hideColumns( dgvData, new string[] { Bank.col_id } );
        }

        private void clear()
        {
            common.clearForm(this, false);
            btnSaveUpd.Text = Constants.operation_save;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void loadFields(int rowIndex)
        {
            bnk.id = Convert.ToInt64(dgvData.Rows[rowIndex].Cells[Bank.col_id].Value);
            txtBankName.Text = dgvData.Rows[rowIndex].Cells[Bank.col_bank].Value.ToString();
            txtAccNo.Text = dgvData.Rows[rowIndex].Cells[Bank.col_acc_no].Value.ToString();
        }

        private void frmBank_Load(object sender, EventArgs e)
        {
            loadData();
            com.loadFormInfo(this, "Bank", lblClient, lblTitle);
        }

        private void btnSaveUpd_Click_1(object sender, EventArgs e)
        {
            if (!validation())
                return;
            getData();

            if (btnSaveUpd.Text == Constants.operation_save)
                bnk.saveBank();
            else if (btnSaveUpd.Text == Constants.operation_update)
                bnk.updateBank();

            common.showMessage(bnk.msg, lblMsg, bnk.msg_type, tmrMsg);

            if (bnk.result)
            {
                clear();
                loadData();
                if (close_on_save)
                    this.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            clear();
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            operation = dgvData.Columns[e.ColumnIndex].Name;
            if (operation == Constants.operation_edit)    //to edit
            {
                loadFields(e.RowIndex);

                btnSaveUpd.Text = Constants.operation_update;
            }
            else if (operation == Constants.operation_delete)    //to delete
            {
                if (!common.delOption("Bank"))
                    return;
                bnk.id = Convert.ToInt64(dgvData.Rows[e.RowIndex].Cells[Bank.col_id].Value);
                bnk.deleteBank();
                common.showMessage(bnk.msg, lblMsg, bnk.msg_type, tmrMsg);
                if (bnk.result)
                {
                    loadData();
                    clear();
                }
            }
        }

        private void txtSrh_TextChanged(object sender, EventArgs e)
        {
            if (txtSrh.Text.Length <= 0)
            {
                loadData();
                return;
            }
            DataTable tbl = bnk.getBanks();
            common.filterData(txtSrh.Text, Bank.col_bank, dgvData, tbl);
        }
    }
}