using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using prjGrow.StockInfo;
using prjGrow.Reporting;
using prjGrow.Classes;
using System.Data.SqlClient;

namespace prjGrow.Reporting
{
    public partial class frmBnkLed : frmBaseReport
    {
        public frmBnkLed()
        {
            InitializeComponent();
        }

        frmDisplayRep display = new frmDisplayRep("Bank Ledger");
        DataTable tblBanks = null;
        Bank bnk = new Bank();
        Account_cycle acc = new Account_cycle();

        bool validData()
        {
            return !com.chkCombo(cmbBank, "Bank Name");
        }

        void getData()
        {
            acc.bnk_id = Convert.ToInt64(cmbBank.SelectedValue);

            acc.year = 0;
            acc.month = 0;

            acc.all = rbAll.Checked;
            if (rbAll.Checked)
            {
                acc.all = true;
            }
           else if (rbMonth.Checked)
            {
                acc.month = Convert.ToInt16(cmbMonth.SelectedIndex + 1);
                acc.year = Convert.ToInt16(numYear.Value);
            }
            else if (rbYear.Checked)
            {
                acc.year = Convert.ToInt16(numYear.Value);
                acc.month = 0;
            }
        }

        void loadBanks()
        {
            tblBanks = bnk.getBanks();
            com.loadCombo(cmbBank, tblBanks, Bank_ledger.col_bank, Bank_ledger.col_id);
        }

        private void frmBnkLed_Load(object sender, EventArgs e)
        {
            com.loadFormInfo(this, "Bank Ledger", lblTitle);
            loadBanks();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if(validData())
                return;
            getData();
            acc.bnkLedger();

            display.rep = acc.getReport("repBnk.rpt");
            display.ShowDialog();
        }
    }
}