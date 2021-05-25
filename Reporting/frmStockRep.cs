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
    public partial class frmStockRep : frmBaseReportSimple
    {
        public frmStockRep()
        {
            InitializeComponent();
        }

        DataTable tblTypes = null;
        DataTable tblCate = null;
        Prod_type type = new Prod_type();
        Stock_reports rep = new Stock_reports();
        frmDisplayRep display = new frmDisplayRep("Stock Report");

        void getData()
        {
            rep.prodTypeId = 0;
            rep.prod_name = "";

            if (cmbProdType.SelectedIndex >= 0)
                rep.prodTypeId = Convert.ToInt64(cmbProdType.SelectedValue);
            else if (!com.chkNull(txtProdName))
                rep.prod_name = txtProdName.Text;
        }

        void loadTypes()
        {
            tblTypes = type.getTypes();
            com.loadCombo(cmbProdType, tblTypes, Prod_type.col_prod_type, Prod_type.col_prod_type_id);
        }
        void loadCate()
        {
            tblCate = new DataTable();
            tblCate.Columns.AddRange(new DataColumn[]{ new DataColumn(Product.col_id,typeof(long)), new DataColumn(Product.col_cate, typeof(string))});

            tblCate.Rows.Add(1, "Stock Items");
            if (Custom.mod_manufact)
            {
                tblCate.Rows.Add(2, "Raw Matirials");
                tblCate.Rows.Add(3, "Gadgets");
            }
            if (Custom.mod_mobile)
            {
                tblCate.Rows.Add(4, "Mobiles");
            }
            if (Custom.mod_bakers)
            {
                tblCate.Rows.Add(5, "Bakery");
            }
        }

        private void frmStockRep_Load(object sender, EventArgs e)
        {
            loadCate();
            loadTypes();
            com.loadFormInfo(this,"Stock Report",lblTitle);
        }

        private void cmbProdType_TextChanged(object sender, EventArgs e)
        {
            if (cmbProdType.Text == "")
                cmbProdType.SelectedIndex = -1;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            getData();
            rep.stockReport();

            display.rep = rep.getReport("repStock.rpt");
            display.ShowDialog();
        }

        private void cmbCate_TextChanged(object sender, EventArgs e)
        {
//            cmbCate.SelectedIndex = -1;
        }

        private void txtProdName_TextChanged(object sender, EventArgs e)
        {
            if (loading)
                return;

            loading = true;
            if (!com.chkNull(txtProdName))
                cmbProdType.SelectedIndex = -1;
            loading = false;
        }

        private void cmbProdType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loading)
                return;

            loading = true;
            if (com.chkCombo(cmbProdType))
                txtProdName.Text = "";
            loading = false;
        }
    }
}