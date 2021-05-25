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

namespace prjGrow.Manufacture
{
    public partial class frmOrderReview : frmBaseComplex
    {
        public frmOrderReview()
        {
            InitializeComponent();
        }

        DataTable tblProd = new DataTable();
        DataTable tblOdr = new DataTable();
        Product prod = new Product();
        Orders odr = new Orders();

        public void loadProducts()
        {
            if (Custom.mod_manufact)
                prod.category = Constants.cate_gadget;
            else if (Custom.mod_bakers)
                prod.category = Constants.cate_cake;
            tblProd = prod.getProducts();
            com.loadCombo(cmbProdName, tblProd, Product.col_prod_name, Product.col_id);
        }

        public void loadOrders()
        {
            tblOdr = odr.getCusOrder(0,0);
            dgvData.DataSource = tblOdr;
            com.hideColumns(dgvData, new string[]{ Orders.col_cus_id, Orders.col_tran_id, "Remove" });
        }

        void calTotal()
        {
            if (loading)
                return;
            if (odr.tblCart.Rows.Count > 0)
            {
                numTotal.Value = Convert.ToInt64(odr.tblCart.Compute("sum(" + Orders.col_amount + ")", ""));
            }
            else
                numTotal.Value = 0;
        }

        void calValues()
        {
            if (loading)
                return;
            numDiscount.Value = Convert.ToInt64(odr.tblCart.Compute("sum("+Orders.col_discount+")","").ToString());
            numAdvance.Value = Convert.ToInt64(odr.tblCart.Compute("Sum("+Orders.col_advance+")", "").ToString());
            numAmount.Value = numTotal.Value - numDiscount.Value;
            numRemain.Value = numAmount.Value - numAdvance.Value;
        }

        void showOrder()
        {
            odr.id = Convert.ToInt64(numOrder.Value);
            DataTable tblTmp = odr.getCusOrder(0, odr.id);
            if (tblTmp.Rows.Count <= 0)
            {
                com.showMessage("Order not found",lblMsg,Constants.message_info,tmrMsg);
                numOrder.Value = 0;
                return;
            }
            DataRow row = tblTmp.Rows[0];
            txtCusName.Text = row[Orders.col_cus_name].ToString();
            dtpDate.Value = Convert.ToDateTime(row[Orders.col_date].ToString());
            dtpTarget.Value = Convert.ToDateTime(row[Orders.col_target].ToString());
            dtpTime.Value= Convert.ToDateTime(row[Orders.col_target_time].ToString());

            odr.tblCart = odr.getOrderItems();
            dgvData.DataSource = odr.tblCart;
            com.hideColumns(dgvData, new string[]{Orders.col_progress, Orders.col_prod_id});
            com.showColumns(dgvData, new string[] { "Remove" });
            calTotal();
            numDiscount.Value = Convert.ToInt64(row[Orders.col_discount].ToString());
            numAdvance.Value = Convert.ToInt64(row[Orders.col_advance].ToString());
            calValues();
        }

        public void clearAll()
        { 
            Control[] C = new Control[] {numOrder, txtCusName, numTotal, numDiscount, numAdvance, numAmount, numRemain};
            com.clearControls(C);
            clearProd();
            loadOrders();
        }
        public void clearProd()
        {
            Control[] C = new Control[] {cmbProdName, txtDescrip, numPrice, numQty, numAmtProd};
            com.clearControls(C);
        }
        bool validProd()
        {
            Control[] C = new Control[] {cmbProdName, numPrice, numQty};
            string[] S = new string[] {"Product Name", "Price", "Quantity"};
            return com.chkValid( C, S, lblMsg, tmrMsg );
        }
        bool validData()
        {
            Control[] C = new Control[] { numAdvance };
            string[] S = new string[] { "Advance" };
            bool isvalid = true;
            isvalid = com.chkTbl(odr.tblCart, "Cart");
            if (isvalid)
                isvalid = com.chkValid(C, S);
            if (!isvalid)
                com.showMessage(lblMsg, tmrMsg);
            return isvalid;
        }
        public void getProdData()
        {
            odr.prod_id = Convert.ToInt64(cmbProdName.SelectedValue);
            odr.prod_name = cmbProdName.Text;
            odr.qty = Convert.ToInt32(numQty.Value);
            odr.price = Convert.ToInt64(numPrice.Value);
            odr.descrip = txtDescrip.Text;
            odr.amount = odr.qty * odr.price;
            odr.adv_prod = Convert.ToInt64(numAdv.Value);
            odr.dist_prod = Convert.ToInt64(numDist.Value);
        }

        public void getData()
        {
            odr.total = Convert.ToInt64(numTotal.Value);
            odr.discount = Convert.ToInt64(numDiscount.Value);
            odr.adv = Convert.ToInt64(numAdvance.Value);
            odr.remain = odr.total - odr.discount - odr.adv;
            odr.date = dtpDate.Value;
            odr.target = dtpTarget.Value;
            odr.targetTime = dtpTime.Value;
        }

        void addToCart()
        {
            if (!validProd())
                return;
            getProdData();
            odr.tblCart.Rows.Add(odr.prod_id, odr.prod_name, odr.price, odr.qty, odr.amount, odr.dist_prod, odr.adv_prod, odr.descrip);
            dgvData.DataSource = odr.tblCart;
            calTotal();
            calValues();
            clearProd();
        }

        void customize()
        {
            pnlTime.Visible = Orders.mod_bakers;
            if (Custom.mod_bakers)
            {
                lblQty.Text = "Pounds";
            }
        }

        private void frmOrderReview_Load(object sender, EventArgs e)
        {
            com.loadFormInfo(this, "Order Review",lblClient, lblTitle);
            loadOrders();
            customize();
            loadProducts();
        }

        private void btnProd_Click(object sender, EventArgs e)
        {
            frmProducts frmProd = new frmProducts();
            frmProd.ShowDialog();
            loadProducts();
        }

        private void btnSaveUpd_Click(object sender, EventArgs e)
        {
            if (!validData())
                return;
            getData();

            odr.updOrder();

            if (odr.result)
                clearAll();
            com.showMessage(odr.msg, lblMsg, odr.msg_type, tmrMsg);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            loadOrders();
        }

        private void numOrder_ValueChanged(object sender, EventArgs e)
        {
            if (numOrder.Value <= 0)
                return;
            showOrder();
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
                return;
            if (dgvData.DataSource == tblOdr)
            {
                odr.cus.cus_id = Convert.ToInt64(dgvData.Rows[e.RowIndex].Cells[Orders.col_cus_id].Value);
                numOrder.Value = Convert.ToInt64(dgvData.Rows[e.RowIndex].Cells[Orders.col_order_no].Value);
            }
            else if (dgvData.DataSource == odr.tblCart && dgvData.Columns[e.ColumnIndex].Name == "Remove" && dgvData.Rows.Count > 1)
            {
                odr.tblCart.Rows.RemoveAt(e.RowIndex);
                dgvData.DataSource = odr.tblCart;
                calTotal();
                calValues();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addToCart();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            if (!com.chkNull(numOrder, "Order no to delete"))
                return;
            odr.delOrder();

            if (odr.result)
            {
                clearAll();
                loadOrders();
            }

            com.showMessage(odr.msg, lblMsg, odr.msg_type, tmrMsg);
        }

        private void numPrice_ValueChanged(object sender, EventArgs e)
        {
            numAmtProd.Value = numPrice.Value * numQty.Value;
        }

        private void txtSrh_TextChanged(object sender, EventArgs e)
        {
            if (dgvData.DataSource == tblOdr)
                com.filterData(txtSrh.Text, Orders.col_cus_name, dgvData, tblOdr);
            if (string.IsNullOrEmpty(txtSrh.Text))
                loadOrders();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            odr.id = Convert.ToInt64(numOrder.Value);
            if (odr.id > 0)
            {
                odr.printReciept();
            }
        }

        private void numDist_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numAmtProd_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}