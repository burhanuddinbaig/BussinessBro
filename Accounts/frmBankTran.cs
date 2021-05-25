using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using prjGrow.General;
using prjGrow.Classes;

namespace prjGrow.Accounts
{
    public partial class frmBankTran : frmBaseGeneral
    {
        public frmBankTran()
        {
            InitializeComponent();
        }

        void clear()
        {
            Control[] C = new Control[] { txtAccno, numDeposit, numWithdraw, txtRemarks };
            com.clearControls(C);

            btnSaveUpd.Text = "&Save";
        }

        DataTable tblData = null;
        DataTable tblBanks = null;
        Bank_ledger bl = new Bank_ledger();

        void loadFields(DataGridViewRow row)
        {
            Control[] C = new Control[] { dtpDate, numDeposit, numWithdraw, txtRemarks };
            string[] S = new string[] { Bank_ledger.col_date, Bank_ledger.col_deposit, Bank_ledger.col_withdraw, Bank_ledger.col_remarks };
            com.loadFields(row, C, S);
            bl.id = Convert.ToInt64(row.Cells[Bank_ledger.col_id].Value);
            bl.tran_id = Convert.ToInt64(row.Cells[Bank_ledger.col_tran_id].Value);
            
            btnSaveUpd.Text = "&Update";
        }

        bool validData()
        {
            bool valid = true;

            Control[] C = new Control[] { dtpDate, cmbBankName };
            string[] S = new string[] { "Date", "Bank Name" };

            valid = com.chkValid( C, S);

            if (valid)
            {
                valid = com.chkNum(numDeposit) || com.chkNum(numWithdraw);
                if (!valid)
                    com.setMessage("Please Enter Deposit or Withdraw amount", Constants.message_info);
            }
            if (!valid)
                com.showMessage(com.msg, lblMsg, Constants.message_info, tmrMsg);

            return valid;
        }

        void getData()
        {
            bl.date = dtpDate.Value;
            bl.dr = Convert.ToInt64(numDeposit.Value);
            bl.cr = Convert.ToInt64(numWithdraw.Value);
            bl.deposit_amount = bl.dr;
            bl.withdraw_amount = bl.cr;
            bl.remarks = txtRemarks.Text;
            bl.native = 1;

            if (bl.deposit_amount > 0)
                bl.narration = "Deposit to Bank " + cmbBankName.Text + " " + bl.remarks;
            else if (bl.withdraw_amount > 0)
                bl.narration = "Withdraw from Bank " + cmbBankName.Text + " " + bl.remarks;
        }

        void loadData()
        {
            if (cmbBankName.SelectedIndex >= 0)
            {
                bl.bank_id = Convert.ToInt64(cmbBankName.SelectedValue);
                tblData = bl.getBankLedger();
                dgvData.DataSource = tblData;
                com.hideColumns(dgvData, new string[] { Bank_ledger.col_id, Bank_ledger.col_bnk_id, Bank_ledger.col_tran_id, Bank_ledger.col_native });

                txtAccno.Text = tblBanks.Rows[cmbBankName.SelectedIndex][Bank.col_acc_no].ToString();

                numBalance.Value = com.chkCombo(cmbBankName) ? Convert.ToInt64(tblBanks.Rows[cmbBankName.SelectedIndex][Bank.col_balance]) : 0;
            }
            else
            {
                tblData.Clear();
                clear();
            }
        }

        void loadBanks()
        {
            tblBanks = bl.bnk.getBankBalances();
            com.loadCombo(cmbBankName, tblBanks, Bank_ledger.col_bank, Bank_ledger.col_id);
        }

        private void btnSaveUpd_Click(object sender, EventArgs e)
        {
            if (!validData())
                return;

            getData();

            if (btnSaveUpd.Text == "&Save")
            {
                bl.saveBankLedger();
            }
            else if (btnSaveUpd.Text == "&Update")
            {
                bl.updateBankLedger();
            }

            if (bl.result)
            {
                clear();
                loadData();
            }

            com.showMessage(bl.msg, lblMsg, bl.msg_type, tmrMsg);
        }

        private void frmBankLog_Load(object sender, EventArgs e)
        {
            loading = true;

            com.loadFormInfo(this,"Bank Transactions",lblClient,lblTitle);
            loadBanks();
            
            loading = false;
        }

        private void txtSrh_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void numDeposit_ValueChanged(object sender, EventArgs e)
        {
            if (numWithdraw.Value > 0 && numDeposit.Value > 0)
                numWithdraw.Value = 0;
        }

        private void numWithdraw_ValueChanged(object sender, EventArgs e)
        {
            if (numWithdraw.Value > 0 && numDeposit.Value > 0)
                numDeposit.Value = 0;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                clear();
                return;
            }

            string colName = dgvData.Columns[e.ColumnIndex].Name;

            if (Convert.ToInt16(dgvData.Rows[e.RowIndex].Cells[Bank_ledger.col_native].Value) <= 0 && (colName == "Edit" || colName == "Delete"))
            {
                com.showMessage("Transaction cannot be Edited or deleted from here", lblMsg, Constants.message_warning, tmrMsg);
                return;
            }

            loading = true;
            DataGridViewRow row = dgvData.Rows[e.RowIndex];
            bl.id = Convert.ToInt64(row.Cells[Product.col_id].Value.ToString());

            if (colName == "Edit")
            {
                loadFields(row);
            }
            else if (colName == "Delete")
            {
                if (com.delOption("Bank Transaction"))
                {
                    bl.deleteBankLedger();

                    if(bl.result)
                    {
                        clear();
                        loadData();
                    }
                    com.showMessage(bl.msg, lblMsg, bl.msg_type, tmrMsg);
                }
            }

            loading = false;
        }

        private void btnAddBank_Click(object sender, EventArgs e)
        {
            frmBank frmbank = new frmBank();
            frmbank.ShowDialog();
            loadBanks();
        }

        private void cmbBankName_SelectedValueChanged(object sender, EventArgs e)
        {
            if (loading || cmbBankName.SelectedIndex < 0)
                return;

            loadData();
        }
    }
}