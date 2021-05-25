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
    public partial class frmOrders : frmBaseComplex
    {
        public frmOrders()
        {
            InitializeComponent();
        }

        public Orders odr = new Orders();
        frmCustomer frmCus = new frmCustomer();
        DataTable tblCus = new DataTable();
        DataTable tblProd = new DataTable();
        Customer cus = new Customer();
        Product prod = new Product();
        clsDb db = new clsDb();

        double adv_ratio = 0;

        void clearProd()
        {
            loading = true;
            Control[] C = new Control[] { cmbProdName, numPrice, numQty, numAmtProd, txtDescrip, numAdvProd, numDistProd };
            com.clearControls(C);
            loading = false;
        }

        void setTargetDate()
        {
            if (Custom.client_id_active == 5)
                dtpTarget.Value = DateTime.Today.AddDays(6);
        }

        void calProdValues()
        {
            bool default_adv = numAmtProd.Value / 2 == numAdvProd.Value;                          //Checks wheather default advance changed or not
            numAmtProd.Value = Convert.ToInt64(numPrice.Value) * Convert.ToInt64(numQty.Value);
            if (adv_ratio > 0 && (numAdvProd.Value == 0 || default_adv))                         //Setting advance if have ratio and default value not changed 
                numAdvProd.Value = numAmtProd.Value * (decimal)adv_ratio;
        }

        void setOrderNo()
        {
            numOrder.Value = db.getNextId("Orders");
        }

        void calValues()
        {
            if (loading)
                return;
            if (odr.tblCart.Rows.Count > 0)
            {
                numTotal.Value = Convert.ToInt64(odr.tblCart.Compute("sum([" + Orders.col_amount + "])", ""));
                numAdvance.Value = Convert.ToInt64(odr.tblCart.Compute("sum([" + Orders.col_advance + "])", ""));
                numDiscount.Value = Convert.ToInt64(odr.tblCart.Compute("sum([" + Orders.col_discount + "])", ""));
            }
            else
            {
                numTotal.Value = 0;
                numAdvance.Value = 0;
                numDiscount.Value = 0;
            }
            numAmount.Value = numTotal.Value - numDiscount.Value;
            numRemain.Value = numAmount.Value - numAdvance.Value;
        }

        void customize()
        {
            if (Orders.mod_bakers)
            {
                pnlTime.Visible = true;
                lblTitle.Text = "Cake Orders";
                lblQty.Text = "Pounds";
            }

            adv_ratio = Custom.client_id_active == 2 ? 0.5 : 0;

            setTargetDate();
        }

        void loadCus()
        {
            tblCus = cus.getCustomers();
            com.loadCombo(cmbCus, tblCus, Customer.col_name, Customer.col_id);
        }

        bool validData()
        {
            Control[] C = new Control[] { cmbCus };
            string[] S = new string[] { "Customer Name" };
            bool isvalid = true;
            isvalid = com.chkTbl(odr.tblCart, "Cart");
            if (isvalid)
                isvalid = com.chkValid(C, S, lblMsg, tmrMsg);
            return isvalid;
        }

        bool validProd()
        {
            bool res = true;
            res = com.chkCombo(cmbCus, "Customer Name");
            if (res)
            {
                if (odr.tblCart != null)
                    res = !com.DataExists(cmbProdName.Text, Orders.col_prod_name, odr.tblCart);

                if (!res)
                    com.setMessage("Please Select a customer", Constants.message_info);
            }
            if (!res)
                com.showMessage(lblMsg, tmrMsg);
            return res;
        }

        void getData()
        {
            odr.cus_id = Convert.ToInt64(cmbCus.SelectedValue.ToString());
            odr.total = Convert.ToInt64(numTotal.Value);
            odr.discount = Convert.ToInt64(numDiscount.Value);
            odr.adv = Convert.ToInt64(numAdvance.Value);
            odr.remain = odr.total - odr.adv - odr.discount;
            odr.date = dtpDate.Value;
            odr.target = dtpTarget.Value;
            odr.targetTime = dtpTime.Value;
            odr.discount = Convert.ToInt64(numDiscount.Value);
            odr.cus.cus_id = odr.cus_id;
        }

        void getProdData()
        {
            odr.prod_id = Convert.ToInt64(cmbProdName.SelectedValue.ToString());
            odr.prod_name = cmbProdName.Text;
            odr.qty = Convert.ToInt32(numQty.Value);
            odr.price = Convert.ToInt64(numPrice.Value);
            odr.descrip = txtDescrip.Text;
            odr.adv_prod = Convert.ToInt64(numAdvProd.Value);
            odr.dist_prod = Convert.ToInt64(numDistProd.Value);
        }

        void loadProd()
        {
            if (Orders.mod_manufact)
                prod.category = Constants.cate_gadget;
            else if (Orders.mod_bakers)
                prod.category = Constants.cate_cake;

            tblProd = prod.getProducts();
            com.loadCombo(cmbProdName, tblProd, Product.col_prod_name, Product.col_id);
        }

        public void addToCart()
        {
            odr.prod_amount = odr.price * odr.qty;
            odr.tblCart.Rows.Add(odr.prod_id, odr.prod_name, odr.price, odr.qty, odr.prod_amount, odr.descrip, odr.dist_prod, odr.adv_prod, Orders.order_new);
            dgvData.DataSource = odr.tblCart;
        }

        void clearAll()
        {
            odr.tblCart.Clear();
            Control[] C = new Control[] { cmbCus, numPrevious, dtpDate, dtpTime, numAmount, numDiscount, numTotal, numAdvance, numRemain };
            com.clearControls(C);
            clearProd();
            setTargetDate();
        }

        void clearCart()
        {
            odr.tblCart.Clear();
            dgvData.DataSource = odr.tblCart;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!validProd())
                return;
            if (odr.tblCart.Rows.Count <= 0)
                odr.createCart();
            cmbProdName.Focus();
            getProdData();
            addToCart();
            dgvData.DataSource = odr.tblCart;
            com.hideColumns(dgvData, new string[] { Orders.col_prod_id, Orders.col_progress });
            calValues();
            clearProd();
        }

        private void frmOrders_Load(object sender, EventArgs e)
        {
            loading = true;
            com.loadFormInfo(this, "Customer Orders", lblClient, lblTitle);
            loadCus();
            loadProd();
            customize();
            setOrderNo();
            loading = false;
        }

        private void numPrice_ValueChanged(object sender, EventArgs e)
        {
            calProdValues();
        }

        private void numQty_ValueChanged(object sender, EventArgs e)
        {
            calProdValues();
        }

        private void cmbCus_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbCus.SelectedIndex < 0 || loading)
                return;
            numPrevious.Value = Convert.ToInt64(tblCus.Rows[cmbCus.SelectedIndex][Customer.col_balance]);
        }

        private void btnAddCus_Click(object sender, EventArgs e)
        {
            frmCus.ShowDialog();
            loadCus();
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
                return;
            operation = dgvData.Columns[e.ColumnIndex].HeaderText;
            if (operation == "Remove")
            {
                odr.tblCart.Rows.RemoveAt(e.RowIndex);
                dgvData.DataSource = odr.tblCart;
                calValues();
            }
        }

        private void btnProd_Click(object sender, EventArgs e)
        {
            frmProducts frmProd = new frmProducts();
            frmProd.ShowDialog();
            loadProd();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            loading = true;
            clearCart();
            clearProd();
            clearAll();
            cmbCus.Focus();
            loading = false;
        }

        private void btnSaveUpd_Click(object sender, EventArgs e)
        {
            if (!validData())
                return;
            getData();
            odr.saveOrder();
            if (odr.result)
            {
                clearAll();
                setOrderNo();
                if (chkPrint.Checked)
                    odr.printReciept();
            }
            com.showMessage(odr.msg, lblMsg, odr.msg_type, tmrMsg);
        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            frmOrderReview rev = new frmOrderReview();
            rev.ShowDialog();
            loadCus();
        }

        private void numAdvProd_ValueChanged(object sender, EventArgs e)
        {
            if (loading)
                return;
            if (numAdvProd.Value > (numAmtProd.Value - numDistProd.Value))
                numAdvProd.Value = numAmtProd.Value - numDistProd.Value;
        }

        private void cmbProdName_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!com.chkCombo(cmbProdName) || loading)
                return;
            numPrice.Value = Convert.ToInt64(tblProd.Rows[cmbProdName.SelectedIndex][Product.col_retail].ToString());
        }

        private void numDistProd_ValueChanged(object sender, EventArgs e)
        {
            if (numDistProd.Value > numAmtProd.Value)
                numDistProd.Value = 0;
        }
    }
}