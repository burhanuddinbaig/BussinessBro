using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using prjGrow.Classes;
using prjGrow.General;

namespace prjGrow.StockInfo
{
    public partial class frmDamage : frmBaseGeneral
    {
        public frmDamage()
        {
            InitializeComponent();
        }

        Damage damage = new Damage();
        Product prod = new Product();
        
        DataTable tblProd = new DataTable();
        DataTable tblDamage = new DataTable();

        private void loadProducts()
        {
            prod.cateBakery = prod.cateGadget = prod.cateMobile = prod.catePartial = prod.cateRaw = prod.cateStk = prod.multiCate = true;
            tblProd = prod.getProducts(true);
            com.loadCombo(cmbProduct, tblProd, Product.col_prod_name,  Product.col_prod_id);
        }

        private void loadDamage()
        {
            tblDamage = damage.getDamage();
            dgvData.DataSource = tblDamage;
            com.hideColumns( dgvData, new string[] { Journal.col_id, Journal.col_prod_id, Journal.col_tran_id, Journal.col_stock} );
        }

        public bool validation()
        {
            bool tmp = com.chkValid(new Control[] {cmbProduct, numDamage},new string[] { "Product", "Quantity" }, lblMsg, tmrMsg);
            if(!tmp)
                com.showMessage(lblMsg, tmrMsg);
            return tmp;
        }

        public void getData()
        {
            damage.prod_id = Convert.ToInt64(cmbProduct.SelectedValue);
            damage.date = dtpDate.Value;
            damage.qty = Convert.ToInt64(numDamage.Value);
            damage.cost = Convert.ToInt64(tblProd.Rows[cmbProduct.SelectedIndex][Product.col_cost]);
            damage.remarks = txtRemarks.Text;
        }

        public void enableControls(bool enable)
        {
            txtProdCode.Enabled = enable;
            cmbProduct.Enabled = enable;
        }

        private void frmDamage_Load(object sender, EventArgs e)
        {
            loading = true;
            loadDamage();
            com.loadFormInfo(this, "Stock Damage", lblClient, lblTitle);
            loadProducts();
            loading = false;
        }

        private void cmbProduct_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!com.chkCombo(cmbProduct) || loading)
                return;

            DataRow row = tblProd.Rows[cmbProduct.SelectedIndex];
            Control[] C = new Control[] { txtProdCode, numStock };
            String[] S = new string[] { Product.col_code, Product.col_stock };
            damage.cost = Convert.ToInt64(tblProd.Rows[cmbProduct.SelectedIndex][Product.col_cost]);

            com.loadFields(row, C, S);
            numDamage.Focus();
        }

        private void txtProdCode_Click(object sender, EventArgs e)
        {
            string tmpCode = txtProdCode.Text;
            if (tmpCode == "")
                return;

            int x = com.searchTableIndex(tblProd, Product.col_code, tmpCode);
            cmbProduct.SelectedIndex = x;

            if (x >= 0)
                numDamage.Focus();
        }

        private void numDamage_ValueChanged(object sender, EventArgs e)
        {
            if (loading)
                return;

            if (numDamage.Value > numStock.Value)
            {
                com.showMessage("Please Enter Valid Quantity", lblMsg, Constants.message_info, tmrMsg);
                numDamage.Focus();
            }
        }

        private void btnSaveUpd_Click(object sender, EventArgs e)
        {
            if (!validation())
                return;
            getData();

            if (btnSaveUpd.Text == "&Save")
            {
                damage.saveDamage();
            }
            else if (btnSaveUpd.Text == "&Update")
            {
                damage.updDamage();
            }
            
            if (damage.result)
            {
                com.showMessage("Stock Damage Saved Successfully", lblMsg, Constants.message_success, tmrMsg);
                btnClear_Click(sender, e);
                loadDamage();
                loadProducts();
            }
            else
            {
                com.showMessage("Stock Damage Cannot be Saved", lblMsg, Constants.message_error, tmrMsg);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            loading = true;

            com.clearForm(this, false);
            btnSaveUpd.Text = "&Save";

            loading = false;
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            loading = true;

            DataGridViewRow row = dgvData.Rows[e.RowIndex];
            numStock.Value = 0;
            damage.tran_id = Convert.ToInt64(row.Cells[Journal.col_tran_id].Value);

            string operation = dgvData.Columns[e.ColumnIndex].Name;
            if (operation == "Edit")
            {
                Control[] C = new Control[] { txtProdCode, cmbProduct, dtpDate, numDamage, txtRemarks, numStock };
                string[] S = new string[] { Journal.col_prod_code, Journal.col_prod_id, Journal.col_date, Journal.col_qty, Journal.col_remarks, Journal.col_stock };
                com.loadFields(row, C, S);

                btnSaveUpd.Text = "&Update";
            }
            else if(operation == "Delete")
            {
                if (com.delOption("Stock Damage"))
                {
                    damage.delDamage();

                    if (damage.result)
                    {
                        loading = true;

                        damage.com.showMessage("Stock Damage Deleted Successfully", lblMsg, Constants.message_success, tmrMsg);
                        loadDamage();
                        loadProducts();

                        loading = false;
                    }
                    else
                    {
                        damage.com.showMessage("Stock Damage cannot be Deleted", lblMsg, Constants.message_error, tmrMsg);
                    }
                }
            }
            loading = false;
        }

        private void txtSrh_TextChanged(object sender, EventArgs e)
        {
            com.filterData(txtSrh.Text, Journal.col_prod_name, dgvData, tblDamage);
        }
    }
}