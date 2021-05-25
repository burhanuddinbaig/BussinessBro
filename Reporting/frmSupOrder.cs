using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using prjGrow.Classes;

namespace prjGrow.Reporting
{
    public partial class frmSupOrder : frmBaseReportSimple
    {
        public frmSupOrder()
        {
            InitializeComponent();
        }

        Supplier sup = new Supplier();
        DataTable tblSup = null;
        Stock_reports reps = new Stock_reports();
        frmDisplayRep display = new frmDisplayRep("Supplier Orders");

        bool validation()
        {
            bool res = com.chkCombo(cmbSuplier, "Supplier Name");
            if (!res)
                com.showMessage(lblMsg, tmrMsg);
            return res;
        }

        void loadSuplier()
        {
            tblSup = sup.getSupliers();
            com.loadCombo(cmbSuplier, tblSup, Supplier.col_sup_name, Supplier.col_id);
        }

        void getData()
        {
            reps.sup_id = Convert.ToInt64(cmbSuplier.SelectedValue);
        }

        private void frmRepSupOrder_Load(object sender, EventArgs e)
        {
            com.loadFormInfo(this, "Supplier Order Report", lblTitle);
            loadSuplier();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (!validation())
                return;

            getData();
            reps.supOrder();

            display.rep = reps.getReport("repSupOrder.rpt");
            display.ShowDialog();
        }
    }
}
