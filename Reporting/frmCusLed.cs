using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using prjGrow.Reporting;
using prjGrow.Classes;
using prjGrow.StockInfo;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace prjGrow.Reporting
{
    public partial class frmCusLed : frmBaseReport
    {
        public frmCusLed()
        {
            InitializeComponent();
        }

        DataTable tblCus = null;
        Cus_ledger cl = new Cus_ledger();
        Account_cycle acc = new Account_cycle();
        frmDisplayRep display = new frmDisplayRep("Customer Ledger");

        void getData()
        {
            acc.cus_id = Convert.ToInt64(cmbCus.SelectedValue);
            year = 0;
            month = 0;

            if (rbAll.Checked)
            {
                all = rbAll.Checked;
            }
            else if (rbMonth.Checked)
            {
                month = Convert.ToInt16(cmbMonth.SelectedIndex + 1);
                year = Convert.ToInt32(numYear.Value);
            }
            else if (rbYear.Checked)
                year = Convert.ToInt32(numYear.Value);   
        }

        void loadCus()
        {
            tblCus = cl.cus.getCustomers();
            com.loadCombo(cmbCus, tblCus, Customer.col_name, Customer.col_id);
        }

        void cusLedgerAll()
        {
            acc.cusLedAll();

            display.rep = acc.getReport("repCusLedAll.rpt");
            display.ShowDialog();
        }

        void cusLedger()
        {
            getData();
            acc.cusLedger(year, month, all);

            display.rep = acc.getReport("repCusLedger.rpt");
            display.ShowDialog();
        }

        private void frmCusLed_Load(object sender, EventArgs e)
        {
            com.loadFormInfo( this, "Customer Ledger", lblTitle );
            loadCus();
            rbYear.Checked = true;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (!com.chkCombo(cmbCus, "Customer"))
                cusLedgerAll();
            else
                cusLedger();
            
        }
    }
}