using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using prjGrow.Classes;

namespace prjGrow.General
{
    public partial class frmProducts : frmBaseGeneral
    {
        public frmProducts()
        {
            InitializeComponent();
        }

        DataTable tblProd = null;
        DataTable tblTypes = null;

        public Product prod = new Product();
        Prod_type type = new Prod_type();

        public int defaultSelected = 0;

        bool haveCosts = false;
        bool haveStock = false;

        void loadProducts()
        {
            if (Custom.client_id_active == 2)
                prod.term_id = rbShop.Checked ? Constants.term_shop : Constants.term_store;

            prod.disabled = true;
            tblProd = prod.getProducts();
            dgvData.DataSource = tblProd;

            com.hideColumns(dgvData, new string[] { Product.col_id, Product.col_prod_type_id });
            com.enableColumns(dgvData, new string[] { Product.col_opening_stock }, chkStock.Checked);
            com.enableColumns(dgvData, new string[] { Product.col_cost, Product.col_whole, Product.col_retail }, chkCost.Checked);
            com.enableColumns(dgvData, new string[] { Product.col_unit }, rbCake.Checked);
            pnlUnit.Visible = rbCake.Checked || rbPartial.Checked || rbRaw.Checked;

            if (rbServ.Checked)
                com.hideColumns(dgvData, new string[] { Product.col_opening_stock, Product.col_cost });
            if (rbGadget.Checked)
            {
                com.hideColumns(dgvData, new string[] { Product.col_opening_stock, Product.col_cost, Product.col_whole });
                if (Custom.client_id_active == 7)
                    com.showColumns(dgvData, new string[] { Product.col_opening_stock, Product.col_whole });
            }
            if (rbRaw.Checked || rbStock.Checked)
                com.enableColumns(dgvData, new string[]{ Product.col_cost, Product.col_whole, Product.col_retail}, chkCost.Checked);
        }

        void customize()
        {
            pnlCategory.Visible = Custom.mod_manufact || Custom.mod_bakers || Custom.mod_mobile || Custom.mod_fnb || Custom.client_id_active == 6;
            bool tmp = (Custom.mod_bakers || Custom.mod_mobile || Custom.mod_fnb || Custom.client_id_active == 5 || Custom.client_id_active == 6 || Custom.client_id_active == 1);
            rbStock.Visible = tmp;
            rbCake.Visible = Custom.mod_bakers;
            rbRaw.Visible = Custom.mod_manufact || Custom.mod_fnb;
            rbRaw.Checked = Custom.mod_manufact;
            rbGadget.Visible = Custom.mod_manufact || Custom.mod_fnb;
            rbMobile.Visible = Custom.mod_mobile;
            rbPartial.Visible = Custom.mod_fnb || Custom.client_id_active == 7;
            rbServ.Visible = Custom.client_id_active == 5 || Custom.client_id_active == 6 || Custom.client_id_active == 1 || Custom.client_id_active == 2;
            chkExpiry.Visible = Custom.client_id_active == 2 && chkStock.Checked;
            
            if (!rbStock.Visible && pnlCategory.Visible)
                rbRaw.Checked = true;

            if (Custom.mod_fnb)
            {
                rbGadget.Text = "Dishes";
                pnlWhole.Visible = false;
                pnlRetail.Visible = false;
            }

            if (Custom.mod_manufact)
            {
                rbGadget.Text = "Finished Products";
                rbGadget.Size = new Size(170,26);
                pnlUnit.Visible = rbRaw.Checked;
                numCost.DecimalPlaces = 2;
            }

            if (Custom.client_id_active == 2)
                rbServ.Text = "Packs";

            if (defaultSelected > 0)
            { 
                disableAll();
                if (defaultSelected == Constants.cate_stock)
                {
                    rbStock.Visible = true;
                    rbStock.Checked = true;
                }
                else if (defaultSelected == Constants.cate_cake)
                {
                    rbCake.Visible = true;
                    rbCake.Checked = true;
                }
                else if (defaultSelected == Constants.cate_gadget)
                {
                    rbGadget.Visible = true;
                    rbGadget.Checked = true;
                }
                else if (defaultSelected == Constants.cate_raw)
                {
                    rbRaw.Visible = true;
                    rbRaw.Checked = true;
                }
            }

            chkCost.Checked = rbStock.Checked || rbRaw.Checked;     ///
        }

        void loadFields(DataGridViewRow row)
        {
            string[] Col = new string[] { Product.col_prod_name, Product.col_prod_type_id, Product.col_cost, Product.col_whole, Product.col_retail, Product.col_opening_stock };
            Control[] Cnt = new Control[]{txtProdName, cmbType, numCost, numWhole, numRetail, numStock};
            com.loadFields(row, Cnt, Col);
        }

        void disableAll()
        {
            rbCake.Visible = false;
            rbRaw.Visible = false;
            rbGadget.Visible = false;
            rbMobile.Visible = false;
        }

        void loadTypes()
        {
            tblTypes = type.getTypes();

            com.loadCombo(cmbType, tblTypes, Prod_type.col_prod_type, Prod_type.col_prod_type_id);
        }

        void refreshProd()
        {
            if (rbStock.Checked)
            {
                prod.category = Constants.cate_stock;
                loadProducts();
            }
            else if (rbRaw.Checked)
            {
                prod.category = Constants.cate_raw;
                loadProducts();
            }
            else if (rbGadget.Checked)
            {
                prod.category = Constants.cate_gadget;
                loadProducts();
            }
            else if (rbCake.Checked)
            {
                prod.category = Constants.cate_cake;
                loadProducts();
            }
            else if (rbPartial.Checked)
            {
                prod.category = Constants.cate_partial;
                loadProducts();
            }
            else if (rbServ.Checked)
            {
                prod.category = Constants.cate_service;
                loadProducts();
            }
        }

        bool validation()
        {
            if (!com.chkValid(new Control[] { txtProdName }, new string[] { "Product Name" })) return false;
            else if (haveCosts && pnlCost.Visible && !com.chkValid(new Control[] { numCost}, new string[] { "Cost Price" })) return false;
            else if (haveCosts && pnlRetail.Visible && !com.chkValid(new Control[] { numRetail }, new string[] { "Retail Price" })) return false;
            else if (haveStock && !com.chkValid(new Control[] { numStock }, new string[] { "Stock" })) return false;
            else if (com.DataExists(txtProdCode.Text, Product.col_code, tblProd) && txtProdCode.Text.Length > 0 && btnSaveUpd.Text != "&Update")
            { prod.setMessage("Product Already Exists", Constants.message_warning); return false; }
            else if (com.DataExists(txtProdName.Text, Product.col_prod_name, tblProd) && btnSaveUpd.Text != "&Update")
            { prod.setMessage("Product Already Exists", Constants.message_warning); return false; }
            return true;
        }

        void loadUnits()
        {
            prod.tblUnit = prod.getUnits();
            com.loadCombo(cmbUnit, prod.tblUnit, Product.col_unit, Product.col_unit);
        }

        void getData()
        {
            prod.code = txtProdCode.Text;
            prod.prod_name = txtProdName.Text;
            prod.type = Convert.ToInt64(cmbType.SelectedValue);

            if (rbRaw.Checked || rbPartial.Checked || rbCake.Checked)
                prod.unit = cmbUnit.SelectedValue == null ? "" : cmbUnit.Text;
            else
                prod.unit = "";

            if (rbStock.Checked) prod.category = Constants.cate_stock;
            else if (rbRaw.Checked) prod.category = Constants.cate_raw;
            else if (rbGadget.Checked) prod.category = Constants.cate_gadget;
            else if (rbMobile.Checked) prod.category = Constants.cate_mobile;
            else if (rbCake.Checked) prod.category = Constants.cate_cake;
            else if (rbPartial.Checked) prod.category = Constants.cate_partial;

            prod.stock = new Stock();

            prod.cost = Convert.ToDouble(numCost.Value);
            prod.retail = Convert.ToInt64(numRetail.Value);
            prod.whole = Convert.ToDouble(numWhole.Value) > 0 ? Convert.ToDouble(numWhole.Value) : prod.stock.retail;

            prod.stock.cost = prod.cost;
            prod.stock.retail = prod.retail;
            prod.stock.whole = prod.whole;
            prod.stock.dr = Convert.ToInt64(numStock.Value);
            prod.stock.term_id = Custom.client_id_active == 1 || Custom.client_id_active == 7 ? Constants.term_store : Constants.term_shop;
            if(Custom.client_id_active == 2)
                prod.stock.term_id = rbShop.Checked ? Constants.term_shop: Constants.term_store;
            prod.stock.expiryitem = dtpExpiry.Visible;
            if (dtpExpiry.Visible)
                prod.stock.expiry = dtpExpiry.Value;
        }

        void clear()
        {
            Control[] C = new Control[] { txtProdCode, txtProdName, cmbType, cmbUnit, numCost, numWhole, numRetail, numStock };
            com.clearControls(C, txtProdCode, btnSaveUpd);
            prod.id = 0;
            chkExpiry.Checked = false;
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            com.loadFormInfo(this, "Product", lblClient, lblTitle);
            customize();
            loadProducts();
            loadTypes();
            loadUnits();
        }

        private void chkCost_CheckedChanged(object sender, EventArgs e)
        {
            haveCosts = chkCost.Checked;

            if (Custom.mod_fnb)
            {
                com.enableColumns(dgvData, new string[] { Product.col_cost }, chkCost.Checked);
                pnlCost.Visible = haveCosts;
            }
            else if (rbServ.Checked)
            {
                com.hideColumns(dgvData, new string[] { Product.col_cost, Product.col_whole, Product.col_opening_stock });
                pnlRetail.Visible = haveCosts;
            }
            else if (rbGadget.Checked && Custom.mod_manufact)
            {
                com.hideColumns(dgvData, new string[] { Product.col_cost, Product.col_whole, Product.col_opening_stock });
                pnlRetail.Visible = haveCosts;
                pnlWhole.Visible = haveCosts && Custom.client_id_active == 7;
            }
            else if ((rbStock.Checked || rbRaw.Checked) && Custom.mod_manufact)
            {
                com.enableColumns(dgvData, new string[]{ Product.col_cost, Product.col_whole, Product.col_retail }, haveCosts);
                pnlRetail.Visible = pnlCost.Visible = pnlRetail.Visible = pnlWhole.Visible = haveCosts;
            }
            else
            {
                com.enableColumns(dgvData, new string[] { Product.col_cost, Product.col_whole, Product.col_retail }, chkCost.Checked);
                pnlCost.Visible = pnlRetail.Visible = pnlWhole.Visible = haveCosts;
            }
        }

        private void chkStock_CheckedChanged(object sender, EventArgs e)
        {
            haveStock = chkStock.Checked;
            if (Custom.client_id_active == 2)
                rbStore.Visible = rbShop.Visible = haveStock;
            pnlStock.Visible = haveStock;
            com.enableColumns(dgvData, new string[] { Product.col_opening_stock }, chkStock.Checked);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void numWhole_ValueChanged(object sender, EventArgs e)
        {
            if (loading)
                return;
            if (numWhole.Value == 0)
                return;
            if (numWhole.Value < numCost.Value && numCost.Value > 0)
            {
                loading = true;
                numWhole.Value = numCost.Value;
                loading = false;
                numWhole.Select(0, 5);
            }
            else if (numWhole.Value > numRetail.Value && numRetail.Value > 0)
            {
                loading = true;
                numWhole.Value = numRetail.Value;
                loading = false;
                numWhole.Select(0, 5);
            }
        }

        private void numRetail_ValueChanged(object sender, EventArgs e)
        {
            if (loading)
                return;
            if (numRetail.Value == 0)
                return;
            if (numRetail.Value < numWhole.Value && numWhole.Value > 0)
            {
                numRetail.Value = numWhole.Value;
                numRetail.Select(0,5);
            }
            else if (numWhole.Value < numCost.Value && numCost.Value > 0 && numWhole.Value != 0)
            {
                numRetail.Value = numCost.Value;
                numRetail.Select(0,5);
            }
        }

        private void btnSaveUpd_Click(object sender, EventArgs e)
        {
            if (!validation())
            {
                com.showMessage(prod.msg, lblMsg, prod.msg_type, tmrMsg);
                return;
            }
            getData();
            if (btnSaveUpd.Text == "&Save")
            {
                prod.saveProduct(haveCosts,haveStock);
            }
            else if (btnSaveUpd.Text == "&Update")
            {
                prod.updProduct(haveCosts, haveStock);
            }
            if (prod.result)
            {
                clear();
                loadProducts();
                if (close_on_save)
                    this.Close();
            }
            com.showMessage(prod.msg, lblMsg, prod.msg_type, tmrMsg);
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            loading = true;
            DataGridViewRow row = dgvData.Rows[e.RowIndex];
            prod.id = Convert.ToInt64(row.Cells[Product.col_id].Value.ToString());
            
            operation = dgvData.Columns[e.ColumnIndex].Name;

            if (operation == "Edit")
            {
                Control[] C = new Control[] { txtProdCode, txtProdName, cmbType, numCost, numWhole, numRetail, numStock, cmbUnit };
                string[] S = new string[] { Product.col_code, Product.col_prod_name, Product.col_prod_type_id, Product.col_cost, Product.col_whole, Product.col_retail, Product.col_opening_stock, Product.col_unit };
                com.loadFields(row, C, S, txtProdCode, btnSaveUpd);

                if(Custom.client_id_active == 2)
                {
                    if (!string.IsNullOrEmpty(row.Cells[Stock.col_expiry].Value.ToString()))
                    {
                        chkExpiry.Checked = true;
                        dtpExpiry.Value = Convert.ToDateTime(row.Cells[Stock.col_expiry].Value.ToString());
                    }
                    else
                        chkExpiry.Checked = false;
                }    
            }
            else if (operation == "Delete")
            {
                if (com.delOption("Product"))
                {
                    prod.delProduct();
                    com.showMessage(prod.msg, lblMsg, prod.msg_type, tmrMsg);
                    if (prod.result)
                        loadProducts();
                }
            }
            else if (operation == "Disable")
            {
                string tmpStr = row.Cells[Product.col_status].Value.ToString();
                bool disable = tmpStr == "Enabled";     //operation will be enabled if product is in disabled form and vice versa

                if (!com.sureOption(disable ? "Do you to disable a product" : "Do you to enable a product"))
                    return;
                prod.disableProduct(disable);
                com.showMessage(prod.msg, lblMsg, prod.msg_type, tmrMsg);
                if (prod.result)
                    loadProducts();
            }
            loading = false;
        }

        private void txtSrh_TextChanged(object sender, EventArgs e)
        {
            com.filterData(txtSrh.Text, Product.col_prod_name, dgvData, tblProd);
        }

        private void rbMatiral_CheckedChanged(object sender, EventArgs e)
        {
            clear();
            loadProducts();
            prod.category = Constants.cate_raw;
            if(Custom.mod_manufact)
                pnlUnit.Visible = rbRaw.Checked;// && Custom.client_id_active != 5;
            if (rbRaw.Checked)
            {
                chkStock.Visible = true;
                pnlCost.Visible = pnlWhole.Visible = pnlRetail.Visible = rbRaw.Checked && chkCost.Checked;
                pnlStock.Visible = rbRaw.Checked && chkStock.Checked;
            }
            prod.getProducts();
            refreshProd();
        }

        private void rbGadget_CheckedChanged(object sender, EventArgs e)
        {
            clear();
            loadProducts();
            if(Custom.client_id_active == 5)
                gbOptions.Visible = true;

            if (rbGadget.Checked && !(Custom.client_id_active == 7 || Custom.client_id_active == 9))
                chkStock.Visible = pnlStock.Visible = false;

            if (rbGadget.Checked)
                pnlCost.Visible = pnlWhole.Visible = false;
            if (Custom.mod_manufact && rbGadget.Checked )
            {
                pnlRetail.Visible = chkCost.Checked && Custom.mod_manufact;       //for Manufacturung user will enter cost for Gadgets
                pnlWhole.Visible = pnlRetail.Visible = chkCost.Checked && (Custom.client_id_active == 7 || Custom.client_id_active == 9); 
                com.showColumns(dgvData, new string[]{ Product.col_retail });
                if (Custom.client_id_active == 7 || Custom.client_id_active == 9)
                    com.hideColumns(dgvData, new string[] { Product.col_cost });
                else
                    com.hideColumns(dgvData, new string[] { Product.col_whole, Product.col_cost });
            }
            refreshProd();
        }
        
        private void rbStock_CheckedChanged(object sender, EventArgs e)
        {
            clear();

            if (rbStock.Checked)
                chkStock.Visible = true;

            rbShop.Visible = rbStore.Visible = chkStock.Checked && Custom.client_id_active == 2;

            pnlCost.Visible = pnlWhole.Visible = pnlRetail.Visible = (rbStock.Checked  || rbCake.Checked) && chkCost.Checked;
            pnlStock.Visible = (rbStock.Checked || rbCake.Checked) && chkStock.Checked;
            refreshProd();
        }

        private void btnAddType_Click(object sender, EventArgs e)
        {
            frmProductType ptype = new frmProductType();
            ptype.ShowDialog();
            loadTypes();
        }

        private void rbCake_CheckedChanged(object sender, EventArgs e)
        {
            clear();

            pnlCost.Visible = pnlWhole.Visible = pnlRetail.Visible = (rbStock.Checked || rbCake.Checked) && chkCost.Checked;
            pnlStock.Visible = (rbStock.Checked || rbCake.Checked) && chkStock.Checked;

            refreshProd();
        }

        private void rbMobile_CheckedChanged(object sender, EventArgs e)
        {
            clear();
            refreshProd();
        }

        private void rbPartial_CheckedChanged(object sender, EventArgs e)
        {
            clear();
            refreshProd();
            gbOptions.Visible = pnlRetail.Visible = pnlWhole.Visible = pnlCost.Visible = pnlStock.Visible = !rbPartial.Checked;
            pnlUnit.Visible = rbPartial.Checked;
        }

        private void rbServ_CheckedChanged(object sender, EventArgs e)
        {
            clear();
            refreshProd();

            if(rbServ.Checked)
                pnlStock.Visible = pnlWhole.Visible = pnlCost.Visible = false;
            chkStock.Visible = haveStock = !rbServ.Checked;
            pnlRetail.Visible = chkCost.Checked;
        }

        private void txtProdCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (loading)
                    return;

                string tmpCode = txtProdCode.Text;
                if (tmpCode.Equals(""))
                    return;

                com.filterData(tmpCode, Product.col_code, dgvData, tblProd);

                if (dgvData.RowCount >= 1)
                {
                    prod.id = Convert.ToInt64(dgvData.Rows[0].Cells[Product.col_id].Value.ToString());
                    loadFields(dgvData.Rows[0]);
                    btnSaveUpd.Text = "&Update";
                }
            }
        }

        private void chkExpiry_CheckedChanged(object sender, EventArgs e)
        {
            pnlExp.Visible = chkExpiry.Checked;
        }

        private void rbShop_CheckedChanged(object sender, EventArgs e)
        {
            clear();
            loadProducts();
        }

        private void rbStore_CheckedChanged(object sender, EventArgs e)
        {
            clear();
            loadProducts();
        }
    }
}