using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using prjGrow.Classes;

namespace prjGrow.Accounts
{
    public partial class frmDrawInvest : frmBaseAccounts
    {
        public frmDrawInvest()
        {
            InitializeComponent();
        }

        Drawing draw = new Drawing();
        DataTable tblData = new DataTable();

        void loadData()
        {
            tblData = draw.getDrawInvest();
            dgvData.DataSource = tblData;

            com.hideColumns(dgvData, new string [] { Drawing.col_id, Drawing.col_tran_id, Drawing.col_bnk_id, Drawing.col_acc_id, Drawing.col_bank });
        }

        bool validData()
        {
            if (!(com.chkNum(numAmt) || com.chkNum(numInvest)))
            {
                com.showMessage("Please enter drawing amount or investment amount", lblMsg, Constants.message_info, tmrMsg);
                return false;
            }
            else
                return true;
        }

        void getData()
        {
            draw.date = dtpDate.Value;
            draw.remarks = txtRemarks.Text;
            draw.invest = Convert.ToInt64(numInvest.Value);
            draw.draw = Convert.ToInt64(numAmt.Value);

            draw.bnk_id = Convert.ToInt64(cmbBank.SelectedValue);
            draw.bnk.bank_id = draw.bnk_id;
            draw.bnk.date = draw.date;
            draw.bnk.dr = Convert.ToInt64(numInvest.Value);
            draw.bnk.cr = Convert.ToInt64(numAmt.Value);
        }

        void clear()
        {
            Control[] C = new Control[] { txtRemarks, numAmt, numInvest, cmbBank };
            com.clearControls(C, null, btnSaveUpd);
        }

        void loadFields(DataGridViewRow row)
        {
            Control[] C =  new Control[]{ dtpDate, txtRemarks, numAmt, numInvest, cmbBank };
            string[] S = new string[]{ Bank_ledger.col_date, Bank_ledger.col_remarks, Drawing.col_dr, Drawing.col_cr, Drawing.col_bnk_id };
            com.loadFields(row, C, S, null, btnSaveUpd);
        }
        private void numAmt_ValueChanged(object sender, EventArgs e)
        {
            if (numAmt.Value > 0)
                numInvest.Value = 0;
        }

        private void numInvest_ValueChanged(object sender, EventArgs e)
        {
            if (numInvest.Value > 0)
                numAmt.Value = 0;
        }

        private void frmDrawInvest_Load(object sender, EventArgs e)
        {
            com.loadFormInfo(this, "Drawing and Investment", lblHead, lblTitle);
            loadData();
            loadBanks();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnSaveUpd_Click(object sender, EventArgs e)
        {
            if (!validData())
                return;
            getData();
            if (btnSaveUpd.Text == "&Save")
            {
                draw.saveDrawInvest();
            }
            else if (btnSaveUpd.Text == "&Update")
            {
                draw.updDrawInvest();
            }
            if (draw.result)
            {
                clear();
                loadData();
                loadBanks();
            }
            com.showMessage(draw.msg, lblMsg, draw.msg_type, tmrMsg);
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            DataGridViewRow row = dgvData.Rows[e.RowIndex];
            draw.id = Convert.ToInt64(row.Cells[Cus_ledger.col_id].Value.ToString());
            draw.tran_id = Convert.ToInt64(row.Cells[Cus_ledger.col_tran_id].Value.ToString());
            operation = dgvData.Columns[e.ColumnIndex].Name;

            if (operation == "Edit")
            {
                loadFields(row);
            }
            else if (operation == "Delete")
            {
                if (com.delOption("Record"))
                {
                    draw.deleteTransaction("Drawing", "Bank_ledger");
                    com.showMessage(draw.msg, lblMsg, draw.msg_type, tmrMsg);

                    if (draw.result)
                    {
                        loadData();
                        loadBanks();
                        clear();
                    }
                }
            }
        }

        private void cmbBank_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbBank.Text))
                cmbBank.SelectedIndex = -1;
        }
    }
}