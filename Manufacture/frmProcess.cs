using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using prjGrow.Classes;

namespace prjGrow.Manufacture
{
    public partial class frmProcess : frmBaseComplex
    {
        public frmProcess()
        {
            InitializeComponent();
        }

        Processing pros = new Processing();
        Orders ord = new Orders();
        Product prod = new Product();
        frmLabour lab = new frmLabour();


        bool validItem()
        {
            bool b = true;
            b = com.chkValid(new Control[] { cmbProd, numMaterQty }, new string[] { "Product Name", "Quantity" });
            if(b)
            {
                b = dgvData.DataSource == pros.tblProcessRaw;
                if(!b)
                    com.setMessage( "Please select an Order", Constants.message_info);
            }
            if (b && rbProd.Checked)
            {
                b = com.chkValid(new Control[] { cmbProdName, numOrderQty, numItemPrice }, new string[] { "Product Name", "Quantity", "Price per Item" });
        
                if(Custom.mod_fnb)
                    if(Convert.ToInt16(pros.tblProds.Rows[cmbProdName.SelectedIndex][Product.col_cate]) == Constants.cate_partial)
                        b = com.chkValid(new Control[] { cmbProdName, numOrderQty}, new string[] { "Product Name", "Quantity"});
            }
            if (b && pros.tblProcessRaw != null)
            {
                b = !com.DataExists(cmbProd.Text, Processing.col_prod_name, pros.tblProcessRaw);
                if (!b)
                    com.setMessage("Item Already Exists", Constants.message_info);
            }
            if (!b)
                com.showMessage(lblMsg, tmrMsg);
            return b;
        }

        void clear()
        {
            Control[] C = new Control[] { cmbProdName, cmbProd, txtMaterUnit, numOrderQty, txtCus, dtpOrderDate, gbMatiral, numLabourCost, numMaterCost, numTotal, numPriceTotal, numItemCost, numItemPrice, numItemProfit, numGrossProfit };
            com.clearControls(C);
            clrCus();
            pros.tblLabour = new DataTable();
            lab.tblLabour.Clear();
            pros.order_id = 0;
            btnLabour.Text = "&Labour";

            if (rbOrder.Checked)
                loadOrders();
            else
                pros.tblProcessRaw.Clear();
        }

        void clrCus()
        {
            com.clearControls(new Control[] {txtCus, cmbProdName, numOrderQty});
        }

        void clrRaw()
        {
            com.clearContainer(gbMatiral);
        }

        void loadOrders()
        {
            if (Custom.client_id_active == 7)
                return;
            pros.tblOrder = ord.getOrderProd(false);
            dgvData.DataSource = pros.tblOrder;
            com.hideColumns(dgvData, new string[] { Orders.col_order_no, Orders.col_prod_id, Orders.col_cus_id, Orders.col_advance, Orders.col_progress, "Remove" });

            if(pros.tblProcessRaw != null)
                pros.tblProcessRaw.Clear();
            btnLabour.Enabled = false;
        }

        void loadProd()
        {
            prod.category = Constants.cate_raw;
            prod.onlyAvailable = true;
            pros.tblProdRaw = prod.getProducts(true);
            prod.onlyAvailable = false;
            com.loadCombo(cmbProd, pros.tblProdRaw, Product.col_prod_name, Product.col_prod_id);
        }

        void loadGadgets()
        {
            prod.category = Constants.cate_gadget;
            pros.tblProds = prod.getProducts(true);
            com.loadCombo(cmbProdName, pros.tblProds, Product.col_prod_name, Product.col_prod_id);
        }

        void loadValues()
        {
            if (Custom.mod_fnb)
                if (Convert.ToInt16(pros.tblProds.Rows[cmbProdName.SelectedIndex][Product.col_cate]) == Constants.cate_partial)
                    numItemPrice.Value = pros.cost_item;

            numMaterCost.Value = pros.cost_mater;
            numLabourCost.Value = pros.cost_labour;
            numTotal.Value = pros.cost_tot;
            numGrossProfit.Value = pros.profit_gross;
            numItemCost.Value = pros.cost_item;
            numItemProfit.Value = pros.profit_item;
        }

        void showOrder(DataGridViewRow row)
        {
            Control[] C = new Control[]{cmbProdName, txtCus, dtpOrderDate, dtpTarget, numOrderQty, numItemPrice, numPriceTotal};;
            string[] S =  new string[]{Orders.col_prod_id, Orders.col_cus_name, Orders.col_date, Orders.col_target, Orders.col_qty, Orders.col_price, Orders.col_amount };
            com.loadFields(row, C, S, gbMatiral, null);

            pros.prod_id = Convert.ToInt64(row.Cells[Orders.col_prod_id].Value);
            pros.order_id = Convert.ToInt64(row.Cells[Orders.col_order_no].Value);
            pros.price_item = Convert.ToInt64(numPriceTotal.Value);
            pros.qty = Convert.ToInt32(numOrderQty.Value);

            pros.createProcess();
            dgvData.DataSource = pros.tblProcessRaw;
            cmbProd.Focus();
        }

        bool validData()
        {
            bool res = com.chkValid(new Control[]{cmbProdName, dtpDate}, new string[]{ "Product Name", "Date" } , lblMsg, tmrMsg);
            if (res && rbOrder.Checked)
            {
                res = pros.order_id > 0;
                if (!res)
                    com.setMessage("Please Select an Order to Process", Constants.message_info);
            }
            else if (res && rbProd.Checked && !com.chkNum(numOrderQty, "Quantity"))
                res = false;

            com.showMessage(lblMsg,tmrMsg);
            return res;
        }

        void getData()
        {
            pros.date = dtpDate.Value;
            pros.isOrder = rbOrder.Checked;
            pros.prod_id = Convert.ToInt64(cmbProdName.SelectedValue);
            pros.price_item = Convert.ToInt64(numItemPrice.Value);
            pros.calCost();
        }

        void flipOrder()
        {
            loading = true;
            clear();
            pros.isOrder = rbOrder.Checked;
            btnLabour.Enabled = rbProd.Checked;
            numOrderQty.Enabled = rbProd.Checked;
            cmbProdName.Enabled = rbProd.Checked;
            pnlTarget.Visible = rbOrder.Checked;

            if (rbOrder.Checked)
                loadOrders();
            else if (rbProd.Checked)
            {
                pros.createProcess();
                dgvData.DataSource = pros.tblProcessRaw;
                com.showColumns(dgvData, new string[]{"Remove"});
            }
            loading = false;
        }
        private void customize()
        {
            if (Custom.mod_fnb || Custom.client_id_active == 7)
            {
                rbProd.Checked = true;
                flipOrder();
                rbOrder.Visible = false;
                lblCustomerName.Visible = false;
                txtCus.Visible = false;
                lblOrderDate.Visible = false;
                dtpOrderDate.Visible = false;
                btnLabour.Visible = false;
                pnl1.Visible = pnl3.Visible = false;
            }
            if (Custom.mod_fnb)
            {
                lblTitle.Text = "Food Costing";
                lblProductName.Text = "Dish Name";
                lblItemName.Text = "Ingredient";
            }
        }
        private void frmProcess_Load(object sender, EventArgs e)
        {
            loading = true;
            com.loadFormInfo(this, "Order Processing", lblClient, lblTitle);
            prod.cateGadget = prod.cateRaw = true;
            loadOrders();
            loadProd();
            loadGadgets();
            customize();
            loading = false;
        }

        private void btnLabour_Click(object sender, EventArgs e)
        {
            lab.ShowDialog();
            pros.tblLabour = lab.tblLabour;
            btnLabour.Text = "Labour(" + lab.tblLabour.Rows.Count + ")";
            pros.isOrder = rbOrder.Checked;
            pros.calCost();
            loadValues();
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            if (dgvData.DataSource == pros.tblOrder)
            {
                showOrder(dgvData.Rows[e.RowIndex]);
                dgvData.Columns["Remove"].Visible = true;
            }
            else if (dgvData.Columns[e.ColumnIndex].Name == "Remove")
            {
                dgvData.Rows.RemoveAt(e.RowIndex);
                pros.isOrder = rbOrder.Checked;
                pros.calCost();
                loadValues();
            }
            bool b = dgvData.DataSource == pros.tblProcessRaw;
            btnLabour.Enabled = b;
            cmbProdName.Enabled = !b;
            numOrderQty.Enabled = !b;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!validItem())
                return;

            com.addtoGrid(dgvData, pros.tblProcessRaw, new string[]{Processing.col_prod_id, Processing.col_prod_name, Processing.col_Item_price, Processing.col_Item_qty, Processing.col_Item_amount, Processing.col_unit}, new Control[]{ cmbProd, numMaterPrice, numMaterQty, numMaterAmount, txtMaterUnit}, true);
            pros.calCost();
            clrRaw();
            loadValues();
            cmbProd.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void cmbProd_SelectedValueChanged(object sender, EventArgs e)
        {
            if (loading)
                return;
            com.loadFields(pros.tblProdRaw.Rows[cmbProd.SelectedIndex], new Control[]{cmbProd, numMaterStock, numMaterPrice, txtMaterUnit}, new string[]{Product.col_prod_name, Product.col_stock, Product.col_cost, Product.col_unit});   
        }
        private void numMaterQty_ValueChanged(object sender, EventArgs e)
        {
            if (numMaterQty.Value > numMaterStock.Value)
                numMaterQty.Value = 0;
            numMaterAmount.Value = numMaterPrice.Value * numMaterQty.Value;
        }

        private void btnSaveUpd_Click(object sender, EventArgs e)
        {
            if (!validData())
                return;
            loading = true;
            getData();
            pros.saveProcess();

            if (pros.result)
            {
                if (chkPrint.Checked)
                    pros.print();
                loadProd();
                btnClear_Click(sender, e);
            }
            com.showMessage(pros.msg, lblMsg, pros.msg_type, tmrMsg);
            loading = false;
        }

        private void numItemPrice_ValueChanged(object sender, EventArgs e)
        {
            if (loading)
                return;
            numPriceTotal.Value = numOrderQty.Value * numItemPrice.Value;
            loading = true;
            pros.isOrder = rbOrder.Checked;
            if (rbProd.Checked)
                pros.price_item = Convert.ToInt64(numItemPrice.Value);
            pros.calCost();
            loading = false;
            loadValues();
        }

        private void numOrderQty_ValueChanged(object sender, EventArgs e)
        {
            if (loading || !com.chkNum(numOrderQty))
                return;
            numPriceTotal.Value = numOrderQty.Value * numItemPrice.Value;
            loading = true;
            pros.qty = Convert.ToInt64(numOrderQty.Value);
            pros.isOrder = rbOrder.Checked;
            pros.calCost();
            loading = false;
        }

        private void cmbProd_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbProd.Text))
                com.clearContainer(gbMatiral);
        }

        private void rbOrder_CheckedChanged(object sender, EventArgs e)
        {
            flipOrder();
        }

        private void rbProd_CheckedChanged(object sender, EventArgs e)
        {
            flipOrder();
        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            frmProcessReview review = new frmProcessReview();
            review.ShowDialog();
            btnClear_Click(sender, e);
            loadOrders();
        }

        private void cmbProdName_SelectedValueChanged(object sender, EventArgs e)
        {
            if(loading || rbOrder.Checked)
                return;
            if(!com.chkCombo(cmbProdName))
                return;
            pros.price_item = Convert.ToInt64(pros.tblProds.Rows[cmbProdName.SelectedIndex][Product.col_retail]);
            numItemPrice.Value = pros.price_item;
        }
    }
}