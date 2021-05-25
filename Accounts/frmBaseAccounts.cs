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
    public partial class frmBaseAccounts : Form
    {
        public frmBaseAccounts()
        {
            InitializeComponent();
        }

        public Common com = new Common();
        public bool loading = false;
        public string operation = "";
        private int count = 0;
        public DataTable tblBank = null;
        Bank bnk = new Bank();
        Cheque cheq = new Cheque();

        public void loadBanks()
        {
            tblBank = bnk.getBankBalances();
            com.loadCombo(cmbBank, tblBank, Bank.col_bank, Bank.col_id);
            cmbBank.SelectedIndex = -1;
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
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkBank_CheckedChanged(object sender, EventArgs e)
        {
            pnlBank.Visible = chkBank.Checked;
            if (!chkBank.Checked)
                cmbBank.SelectedIndex = -1;
        }

        private void cmbBank_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbBank.SelectedIndex > 0)
            {
                DataRow row = tblBank.Rows[cmbBank.SelectedIndex];
                com.loadFields(row, new Control[] { txtBankAccno, numBankBal }, new string[] { Bank.col_acc_no, Bank.col_balance });
            }
            else
            {
                txtBankAccno.Text = "";
                numBankBal.Value = 0;
            }
        }

        private void frmBaseAccounts_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void chkCheq_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void btnSaveUpd_Click(object sender, EventArgs e)
        {
            
        }

        private void pnlBank_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
