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
    public partial class frmAddCheque : frmBaseMicro
    {
        public frmAddCheque()
        {
            InitializeComponent();
        }

        public Cheque cheq = new Cheque();
        Bank bnk = new Bank();

        DataTable tblBanks = new DataTable();

        void loadBanks()
        {
            tblBanks = bnk.getBanks();
            com.loadCombo(cmbBankName, tblBanks, Bank_ledger.col_bank, Bank_ledger.col_id);
        }

        private void frmAddCheque_Load(object sender, EventArgs e)
        {
            com.loadFormInfo(this, "Bank Cheque", lblTitle);
            loadBanks();
            cmbBankName.SelectedValue = cheq.bnk_id;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
