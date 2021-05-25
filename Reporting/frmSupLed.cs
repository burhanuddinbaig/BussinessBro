using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using prjGrow.StockInfo;
using prjGrow.Classes;

namespace prjGrow.Reporting
{
    public partial class frmSupLed : frmBaseReport
    {
        public frmSupLed()
        {
            InitializeComponent();
        }

        Supplier sup = new Supplier();
        Account_cycle acc = new Account_cycle();
        frmDisplayRep display = new frmDisplayRep("Supplier Ledger");

        DataTable tblSup = null;

        bool validData()
        { 
            return com.chkCombo(cmbSup, "Supplier");
        }

        void getData()
        {
            acc.year = 0;
            acc.month = 0;

            acc.sup_id = Convert.ToInt64(cmbSup.SelectedValue);
            if (rbAll.Checked)
            {
                acc.all = true;
            }
            else if (rbMonth.Checked)
            {
                acc.year = Convert.ToInt32(numYear.Value);
                acc.month = Convert.ToInt16(cmbMonth.SelectedIndex + 1);
            }
            else if (rbYear.Checked)
            {
                acc.year = Convert.ToInt16(numYear.Value);
                acc.month = 0;
            }
        }

        void loadSuplier()
        {
            tblSup = sup.getSupliers();
            com.loadCombo(cmbSup, tblSup, Supplier.col_sup_name, Supplier.col_id);
        }

        private void frmSupLed_Load(object sender, EventArgs e)
        {
            com.loadFormInfo(this,"Supplier Ledger", lblTitle);
            loadSuplier();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            getData();
            acc.supLedger();

            display.rep = acc.getReport("repSupLedger.rpt");
            display.ShowDialog();
        }
    }
}
