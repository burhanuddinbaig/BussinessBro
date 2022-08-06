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
    public partial class frmSaleRep : frmBaseReport
    {
        public frmSaleRep()
        {
            InitializeComponent();
        }

        Stock_reports reps = new Stock_reports();
        frmDisplayRep display = new frmDisplayRep("Sale Report");
        Product prod = new Product();
        Customer cus = new Customer();

        DataTable tblCustomers, tblProducts;

        void getData()
        {
            reps.prod_id = reps.cus_id = 0;
            
            if (rbYear.Checked)
            {
                year = Convert.ToInt32(numYear.Value);
                month = 0;
                date = new DateTime();
            }
            if (rbMonth.Checked)
            {
                year = Convert.ToInt32(numYear.Value);
                month = Convert.ToInt16(cmbMonth.SelectedIndex + 1);
                date = new DateTime();
            }
            else if (rbDaily.Checked)
            {
                year = 0;
                month = 0;
                date = dtpDate.Value;
            }

            if (rbDetailed.Checked)
            {
                reps.prod_id = (cmbProduct.SelectedIndex > 0)? Convert.ToInt32(cmbProduct.SelectedValue) : 0;
                reps.cus_id = (cmbCustomer.SelectedIndex > 0)? Convert.ToInt32(cmbCustomer.SelectedValue) : 0;
            }
        }

        void customize()
        {
            rbMonth.Visible = !(Custom.client_id_active == 5);
            numYear.Value = DateTime.Today.Year;
        }

        void flipControls()         //Activate Deactivate the Search Box
        {
            bool isDetailed = rbDetailed.Checked;
            gbSearch.Enabled = isDetailed;

            if (isDetailed)
                rbYear.Select();
            else
                rbMonth.Select();
        }

        void loadProducts()
        {
            prod.onlyAvailable = false;
            tblProducts = prod.getProducts(true);
            com.loadCombo(cmbProduct, tblProducts, Product.col_prod_name, Product.col_prod_id);
        }

        void loadCustomers()
        {
            tblCustomers = cus.getCustomers();
            com.loadCombo(cmbCustomer, tblCustomers, Customer.col_name, Customer.col_id);
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string repName = rbDetailed.Checked ? "repSaleDetail.rpt" : "repSale.rpt";
            getData();

            if(rbDetailed.Checked)
                reps.saleDetailReport(reps.cus_id, reps.prod_id, year, month, date);
            else
                reps.saleReport(year, month, date);

            display.rep = reps.getReport(repName);
            display.ShowDialog();
        }

        private void frmSaleRep_Load(object sender, EventArgs e)
        {
            com.loadFormInfo(this,  "Sale Report", lblClient, lblTitle );
            customize();
            loadCustomers();
            loadProducts();
        }

        private void rbDetailed_CheckedChanged(object sender, EventArgs e)
        {
            flipControls();
        }

        private void rbSimple_CheckedChanged(object sender, EventArgs e)
        {
            flipControls();
        }

        private void cmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbProduct.SelectedIndex >= 0 && cmbCustomer.SelectedIndex >= 0)
                cmbProduct.SelectedIndex = -1;
        }

        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProduct.SelectedIndex >= 0 && cmbCustomer.SelectedIndex >= 0)
                cmbCustomer.SelectedIndex = -1;
        }
    }
}