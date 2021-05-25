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
    public partial class frmSupplierTran : frmBaseGeneral
    {
        public frmSupplierTran()
        {
            InitializeComponent();
        }

        Sup_ledger sl = new Sup_ledger();
        Supplier sup = new Supplier();
        DataTable tblBank = null;
        DataTable tblSup = null;
        DataTable tblData = null;

        Bank bnk = new Bank();

        void loadBanks()
        {
            tblBank = bnk.getBanks();
            com.loadCombo(cmbBank, tblBank, Bank.col_bank, Bank.col_id);
        }

        void loadSuplier()
        {
            tblSup = sup.getSupliers();
            com.loadCombo(cmbSup, tblSup, Supplier.col_sup_name, Supplier.col_id);
        }

        void getData()
        {
            sl.amount = Convert.ToInt64(numAmount.Value);
            sl.discount = Convert.ToInt64(numDist.Value);
            sl.dr = sl.amount + sl.discount;
            sl.cr = 0;
            sl.date = dtpDate.Value;
            sl.by_cheq = ! com.chkNull(txtCheq_no);
            sl.narration = sl.amount > 0 ? "Paid to " + cmbSup.Text : "Discount by Supplier (" + cmbSup.Text + ")" ;
            sl.reference = txtReference.Text;

            if (com.chkCombo(cmbBank))
            {
                sl.bnk_id = Convert.ToInt64(cmbBank.SelectedValue);
                sl.bnk.bank_id = sl.bnk_id;
                sl.bnk.cr = sl.dr;
                sl.bnk.date = sl.date;

                if (sl.by_cheq)
                {
                    sl.cheq.cheq_no = txtCheq_no.Text;
                    sl.cheq.bnk_id = Convert.ToInt64(cmbBank.SelectedValue.ToString());
                    sl.cheq.cheq_type = Constants.cheq_pymnt;
                    sl.cheq.amt = sl.amount;
                    sl.cheq.issue_date = dtpIssue.Value;
                }
            }
            else
                sl.bnk_id = 0;
        }

        void clear()
        {
            Control[] C = new Control[] { dtpDate, cmbBank, numAmount, numDist, txtCheq_no, dtpIssue };
            com.clearControls(C, numAmount, btnSaveUpd);
        //    loadSuplier();
        }
        
        void loadFields(DataGridViewRow row)
        {
            Control[] C = new Control[] { dtpDate, cmbBank, numAmount };
            string[] S = new string[] { Sup_ledger.col_date, Bank.col_bnk_id, Sup_ledger.col_debit };
            com.loadFields(row, C, S, numAmount, btnSaveUpd);

            sl.tran_id = Convert.ToInt64(row.Cells[Sup_ledger.col_tran_id].Value);
        }

        bool validData()
        {
            bool tmp = com.chkValid(new Control[] { dtpDate, cmbSup }, new string[] { "Date", "Supplier" });
            if (tmp)
                tmp = com.chkNum(numAmount) || com.chkNum(numDist);
            return tmp;
        }

        void loadData()
        {
            if (loading || cmbSup.SelectedIndex < 0)
                return;
            sl.sup_id = Convert.ToInt64(cmbSup.SelectedValue);
            tblData = sl.getSupled();
            dgvData.DataSource = tblData;
            com.hideColumns(dgvData, new string[] { Sup_ledger.col_id, Sup_ledger.col_sup_id, Sup_ledger.col_tran_id, Bank.col_bnk_id });
            numBalance.Value = Convert.ToInt64(tblSup.Rows[cmbSup.SelectedIndex][Supplier.col_balance]);
        }

        private void frmSupplierLog_Load(object sender, EventArgs e)
        {
            loading = true;
            com.loadFormInfo(this, "Supplier Transactions", lblClient, lblTitle);
            loadBanks();
            loadSuplier();
            loading = false;
        }

        private void cmbSup_SelectedValueChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnSaveUpd_Click(object sender, EventArgs e)
        {
            if (!validData())
                return;

            getData();
            if (btnSaveUpd.Text == "&Save")
            {
                sl.saveLedger();
            }
            else if (btnSaveUpd.Text == "&Update")
            {
                sl.updLedger();
            }
            if (sl.result)
            {
                clear();
                loadData();
            }
            com.showMessage(sl.msg, lblMsg, sl.msg_type, tmrMsg);
        }

        private void cmbBank_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbBank.Text))
                cmbBank.SelectedIndex = -1;
        }

        private void txtSrh_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                clear();
                return;
            }

            if (Convert.ToInt64(dgvData.Rows[e.RowIndex].Cells[Sup_ledger.col_credit].Value) > 0)
                return;

            loading = true;
            DataGridViewRow row = dgvData.Rows[e.RowIndex];
            sl.id = Convert.ToInt64(row.Cells[Sup_ledger.col_id].Value.ToString());
            sl.tran_id = Convert.ToInt64(row.Cells[Sup_ledger.col_tran_id].Value.ToString());
            
            if (dgvData.Columns[e.ColumnIndex].Name == "Edit")
            {
                loadFields(row);
            }
            else if (dgvData.Columns[e.ColumnIndex].Name == "Delete")
            {
                if (com.delOption("Suplier Transaction"))
                {
                    sl.delLedger();
                    com.showMessage(sl.msg, lblMsg, sl.msg_type, tmrMsg);
                    if (sl.result)
                    {
                        loading = false;
                        loadData();
                    }
                }
            }
            loading = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void numDist_ValueChanged(object sender, EventArgs e)
        {
            if (numDist.Value > 0)
                numAmount.Value = 0;
        }

        private void numAmount_ValueChanged(object sender, EventArgs e)
        {
            if (numAmount.Value > 0)
                numDist.Value = 0;
        }
    }
}