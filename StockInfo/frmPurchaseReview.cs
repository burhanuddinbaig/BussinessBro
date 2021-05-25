using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using prjGrow.Classes;

namespace prjGrow.StockInfo
{
    public partial class frmPurchaseReview : frmBaseSalePur
    {
        public frmPurchaseReview()
        {
            InitializeComponent();
        }

        Product prod = new Product();
        Bank bnk = new Bank();
        Supplier sup = new Supplier();

        Purchase pur = new Purchase();
        Classes.Stock stock = new Classes.Stock();
        frmIMEI obji = new frmIMEI();

        DataTable tblProd = null;
        bool loading = false;

        void clearItem()
        {
            loading = true;
            Control[] C = new Control[] { cmbProd, numCost, numRetail, numWhole, numQty, numStock, numAmount };
            com.clearControls(C);
            loading = false;
        }

        void clearBill()
        {
            dgvData.DataSource = pur.tblCart;
            pur.tblCart.Clear();
            Control[] C = new Control[] { cmbClient, cmbBank, numInvoiceno, numBillTotal, numDiscount, numPaid, numCredit }; 
            com.clearControls(C);
        }

        void getData()
        {
            pur.date = dtpDate.Value;
            if (cmbClient.SelectedIndex > 0)
                pur.sup_id = Convert.ToInt64(cmbClient.SelectedValue);
            else
                pur.sup_id = 0;

            if (cmbBank.SelectedIndex > 0)
                pur.bank_id = Convert.ToInt64(cmbBank.SelectedValue);
            else
                pur.bank_id = 0;

            pur.tblIMEI = obji.objImei.tblTempTable;
            calValues();

            pur.cheq.cheq_no = txtCheq_no.Text;

            if (!string.IsNullOrEmpty(txtCheq_no.Text))
            {
                pur.cheq.bnk_id = pur.bank_id;
                pur.cheq.cheq_type = Constants.cheq_pymnt;
                pur.cheq.amt = Convert.ToInt64(numPaid.Value);
            }
        }

        void showImei()
        {
            obji.ShowDialog();
            pur.tblIMEI = obji.objImei.tblTempTable;
            if (pur.tblIMEI.Rows.Count > 0)
                numQty.Value = Convert.ToInt16(pur.tblIMEI.Compute("count([" + Imei.col_imei + "])", "[" + Imei.col_prod_id + "] = " + obji.prod_id));
            else
                numQty.Value = 0;
        }

        void returnImei(int rowIndex)
        {
            obji.toReturn = true;
            obji.fromSale = false;
            obji.prod_id = Convert.ToInt64(dgvData.Rows[rowIndex].Cells[Purchase.col_prod_id].Value);
            obji.Text = "Return Gadget";
            obji.ShowDialog();
            btnAddIMEI.Enabled = true;
            dgvData.Rows[rowIndex].Cells[Purchase.col_qty].Value = obji.counter;
            dgvData.Rows[rowIndex].Cells[Purchase.col_amount].Value = Convert.ToInt64(dgvData.Rows[rowIndex].Cells[Purchase.col_qty].Value) * Convert.ToInt64(dgvData.Rows[rowIndex].Cells[Purchase.col_cost].Value);
            if (obji.counter <= 0)
                pur.tblCart.Rows.RemoveAt(rowIndex);
        }

        void customize()
        {
            btnAddIMEI.Visible = Purchase.mod_mobile;
            if (Custom.client_id_active == 6)
                pnlTots.SendToBack();
        }

        bool validItem()
        {
            bool res = com.chkValid(new Control[] { cmbProd, numCost, numRetail, numQty }, new string[] { "Product Name", "Cost Price", "Retail Price", "Quantity" }, lblMsg, tmrMsg);
            return res;
        }

        public bool validation()
        {
            if (pur.id <= 0)
            {
                com.showMessage("Please select an invoice", lblMsg, Constants.message_info, tmrMsg);
                numInvoiceno.Focus();
                return false;
            }
            else if (pur.tblCart.Rows.Count <= 0)
            {
                com.showMessage("Cart is Empty", lblMsg, Constants.message_info, tmrMsg);
                cmbProd.Focus();
                return false;
            }
            else
                return true;
        }

        public void loadCart()
        {
            pur.tran_id = pur.getTranid(pur.id, "Purchase");
            pur.tblCart = stock.getPurchaseStock(pur.tran_id);
            dgvData.DataSource = pur.tblCart;
            com.hideColumns(dgvData, new string[] { Classes.Stock.col_id, Classes.Stock.col_prod_id, Classes.Stock.col_tran_id, Classes.Product.col_cate });
            com.freezeColumns(dgvData, new string[] { Classes.Stock.col_cost, Classes.Stock.col_qty });
            if (Custom.client_id_active == 5)
                com.hideColumns(dgvData, new string [] {Classes.Stock.col_unit});
        }

        public void loadProducts()
        {
            loading = true;
            if (Custom.mod_manufact)
                prod.cateRaw = prod.cateStk = prod.multiCate = true;
            else if (Custom.mod_bakers)
                prod.cateBakery = prod.cateStk = prod.multiCate = true;
            else if (Custom.mod_mobile)
                prod.cateStk = prod.cateMobile = prod.multiCate = true;
            tblProd = prod.getProducts(true);
            com.loadCombo(cmbProd, tblProd, Product.col_prod_name, Product.col_prod_id);
            loading = false;
        }

        public void loadSupliers()
        {
            com.loadCombo(cmbClient, sup.getSupliers(), Supplier.col_sup_name, Supplier.col_id);
        }

        public void loadBanks()
        {
            com.loadCombo(cmbBank, bnk.getBanks(), Bank.col_bank, Bank.col_id);
        }

        void clearValues()
        {
            Control[] C = new Control[] { numAmount, numCredit, numBillTotal, numDiscount };
            com.clearControls(C);
        }

        public void calTotal()
        {
            if (pur.tblCart.Rows.Count <= 0)
            {
                numBillTotal.Value = pur.total = 0;
                return;
            }

            for (int i = 0; i < pur.tblCart.Rows.Count; i++)
            {
                int tmpQty = Convert.ToInt32(pur.tblCart.Rows[i][Classes.Stock.col_qty]);
                int tmpCost = Convert.ToInt32(pur.tblCart.Rows[i][Classes.Stock.col_cost]);
                pur.tblCart.Rows[i][Classes.Stock.col_amount] = tmpCost * tmpQty;
            }

            pur.total = Convert.ToInt64(pur.tblCart.Compute("Sum(" + Classes.Stock.col_amount + ")",""));
            numBillTotal.Value = pur.total;
        }

        public void calValues()
        {
            calTotal();
            if (pur.tblCart.Rows.Count > 0)
            {
                pur.discount = Convert.ToInt32(numDiscount.Value);
                if (cmbClient.SelectedIndex < 0)
                    pur.paid = Convert.ToInt64(numBillTotal.Value - numDiscount.Value);
                else
                    pur.paid = Convert.ToInt64(numPaid.Value);
                pur.remain = pur.total - pur.discount - pur.paid;
            }
            else
            {
                pur.total = 0;
                pur.discount = 0;
                pur.remain = 0;
                pur.paid = 0;
            }

            numBillTotal.Value = pur.total;
            numDiscount.Value = pur.discount;
            numPaid.Value = pur.paid;
            numCredit.Value = pur.remain;
        }

        public void loadBill()
        {
            DataRow row = pur.getPurchase();
            if (row == null)
            {
                pur.id = 0;
                clearItem();
                clearBill();
                return;
            }

            pur.id = Convert.ToInt64(numInvoiceno.Value);
            pur.bank_id = Convert.ToInt64(row[Purchase.col_bank_id]);
            pur.sup_id = Convert.ToInt64(row[Purchase.col_sup_id]);

            Control[] C = new Control[] { dtpDate, cmbClient, cmbBank, numPaid, numDiscount };////, numPaid, numDiscount 
            string[] S = new string[] { Purchase.col_date, Supplier.col_sup_name, Bank.col_bank, Purchase.col_paid, Purchase.col_discount };
            com.loadFields(row, C, S);

            obji.objImei.tran_id = pur.getTranid(pur.id,"Purchase");
            obji.objImei.tblTempTable = obji.objImei.getIMEIs();
        }

        void resize()
        {
            Size siz = SystemInformation.VirtualScreen.Size;
            if (siz.Height == 768 && siz.Width == 1024)
            {
                Font = new Font("Arial Narrow", 13);
            }
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            pur.tblCart.Clear();
            dgvData.DataSource = pur.tblCart;
            clearItem();
            calTotal();
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void frmPurchaseReview_Load(object sender, EventArgs e)
        {
            loading = true;
            com.loadFormInfo(this, "Purchase Review",lblClient, lblTitle);
            resize();
            loadSupliers();
            customize();
            loadBanks();
            loadProducts();
            numInvoiceno.Value = db.getLastId("Purchase");
            loading = false;
            btnSrh_Click(sender, e);
        }

        private void btnSrh_Click(object sender, EventArgs e)
        {
            pur.id = Convert.ToInt64(numInvoiceno.Value);

            loadCart();
            loadBill();
            calTotal();
        }

        private void dgvData_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            calTotal();
        }

        private void btnAddtoCart_Click(object sender, EventArgs e)
        {
            if ( !validItem() || pur.tblCart == null)
                return;

            string[] S = new string[] { Classes.Stock.col_prod_id, Product.col_prod_name, Stock.col_cost, Stock.col_whole, Stock.col_retail, Stock.col_qty, Stock.col_amount};
            Control[] C = new Control[] { cmbProd, numCost, numWhole, numRetail, numQty, numAmount};
            com.addtoGrid(dgvData, pur.tblCart, S, C, true);
            clearItem();
            calValues();
        }

        private void numInvoiceno_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnSrh_Click(sender, e);
            }
        }

        private void numCost_ValueChanged(object sender, EventArgs e)
        {
            numAmount.Value = numCost.Value * numQty.Value;
        }

        private void numQty_ValueChanged(object sender, EventArgs e)
        {
            numAmount.Value = numCost.Value * numQty.Value;
        }

        private void numPaid_ValueChanged(object sender, EventArgs e)
        {
            if (loading)
                return;
            if (!com.chkCombo(cmbClient))
            {
                numPaid.Value = numBillTotal.Value - numDiscount.Value;
            }
            calValues();
        }

        private void numDiscount_ValueChanged(object sender, EventArgs e)
        {
            if (loading)
                return;
            if (numDiscount.Value > numBillTotal.Value)
            {
                numDiscount.Value = 0;
            }
            calValues();
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvData.Columns[e.ColumnIndex].Name == "Return")
            {
                if (!com.sureOption("Do you want to Return such item"))
                    return;

                if (Convert.ToInt16(pur.tblCart.Rows[e.RowIndex][Product.col_cate].ToString()) == Constants.cate_mobile)
                    returnImei(e.RowIndex);
                else
                    pur.tblCart.Rows.RemoveAt(e.RowIndex);
                
                dgvData.DataSource = pur.tblCart;
                com.delRows(obji.objImei.tblTempTable, Product.col_prod_id, obji.prod_id);
                calValues();
            }
        }

        private void cmbProd_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbProd.SelectedIndex < 0 || loading)
                return;
            DataRow row = tblProd.Rows[cmbProd.SelectedIndex];
            
            Control[] C = new Control[] { cmbProd, numCost, numWhole, numRetail, numStock };
            string[] S = new string[] { Product.col_prod_name, Product.col_cost, Product.col_whole, Product.col_retail, Product.col_stock };
            com.loadFields(row, C, S);
            if (Purchase.mod_mobile)
            {
                btnAddIMEI.Enabled = Convert.ToInt16(row[Product.col_cate].ToString()) == Constants.cate_mobile;
                numQty.Enabled = !(Convert.ToInt16(row[Product.col_cate].ToString()) == Constants.cate_mobile);
                obji.prod_id = Convert.ToInt16(row[Product.col_prod_id].ToString());
                if (btnAddIMEI.Enabled)
                    showImei();
            }
            numQty.Focus();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (pur.id <= 0)
            {
                com.showMessage("Please select an invoice to delete", lblMsg, Constants.message_info, tmrMsg);
                numInvoiceno.Focus();
            }
            pur.deletePurchase();
            if (pur.result)
                clearBill();
            com.showMessage(pur.msg, lblMsg, pur.msg_type, tmrMsg);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!validation())
                return;
            getData();
            pur.updatePurchase();
            if (pur.result)
            {
                clearItem();
                clearBill();
                com.showMessage("Stock Purchase Updated Successfully", lblMsg, Constants.message_success, tmrMsg);
            }
            else
                com.showMessage("Stock cannot be Purchased", lblMsg, Constants.message_error, tmrMsg);
        }

        private void btnAddIMEI_Click(object sender, EventArgs e)
        {
            showImei();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbBank_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbBank.SelectedIndex < 0 || loading || cmbBank.SelectedValue == null)
            {
                pnlCheq.Visible = false;
                return;
            }
            txtAccno.Text = bnk.bankAccNo(Convert.ToInt64(cmbBank.SelectedValue.ToString()));
            pnlCheq.Visible = true;
        }
    }
}