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
    public partial class frmPurchase : frmBaseSalePur
    {
        public frmPurchase()
        {
            InitializeComponent();
            pur.createCart();
        }

        DataTable tblProd = null, tblSuplier = null, tblBank = null, tblTermin = null;
        Purchase pur = new Purchase();
        Bank bnk = new Bank();
        Supplier sup = new Supplier();
        Product prod = new Product();
        Imei im = new Imei();
        Termin termin = new Termin();
        bool loading = false;
        bool expiryitem = false;
        frmIMEI obji = new frmIMEI();

        int sno = 0;

        #region functions

        void calAmount()
        {
            numAmount.Value = numCost.Value * numQty.Value;
        }

        bool validPurchase()
        {
            bool res = true;
            if (pur.tblCart.Rows.Count <= 0)
            {
                com.msg = "Sorry, Cart is Empty";
                res = false;
            }
            else if ((numBillTotal.Value - numDiscount.Value - numPaid.Value) > 0 && cmbClient.SelectedIndex < 0)
            {
                com.msg = "Please Select any Supplier";
                res = false;
            }
            
            com.showMessage(lblMsg, tmrMsg);

            return res;
        }

        void customize()
        {
            btnAddIMEI.Visible = Purchase.mod_mobile;
            chkExpiry.Visible = Custom.mod_bakers;
            pnlWhole.Visible = pnlRetail.Visible = !Custom.mod_fnb;
            pnlPurchase.Visible = Custom.client_id_active == 2;

            if (Custom.client_id_active == 2)
                cmbTermin.SelectedValue = Constants.term_store;

            if (Custom.mod_fnb)
                numQty.DecimalPlaces = 2;
            if (Custom.mod_manufact)
                numCost.DecimalPlaces = numWhole.DecimalPlaces = 2;

            pnlFrieght.Visible = Custom.fet_freight;
            focusProd();
        }

        void focusProd()
        {
            if (Custom.fet_bcode)
            {
                txtProdCode.Focus();
            }
            else
            {
                txtProdName.Focus();
                txtProdCode.TabStop = false;
            }
        }

        void calTotals()
        {
            if (pur.tblCart.Rows.Count > 0)
            {
                pur.total = Convert.ToInt64(pur.tblCart.Compute("Sum(" + Product.col_amount + ")", ""));
                pur.discount = Convert.ToInt32(numDiscount.Value);
                if (cmbClient.SelectedIndex < 0)
                    pur.paid = Convert.ToInt64(numBillTotal.Value - numDiscount.Value);
                else
                {
                    pur.paid = Convert.ToInt64(numPaid.Value);
                }
                
                pur.remain = pur.total - pur.discount - pur.paid;
                
                if (pur.remain < 0)
                    pur.remain = 0;
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

        void addtoCart()
        {
            DataRow row = pur.tblCart.NewRow();
            row[Product.col_prod_id] = prod.id;
            row[Product.col_code] = txtProdCode.Text;
            row[Product.col_prod_name] = txtProdName.Text;
            row[Product.col_cost] = numCost.Value;
            row[Product.col_whole] = numWhole.Value;
            row[Product.col_retail] = numRetail.Value;
            row[Product.col_qty] = numQty.Value;
            row[Product.col_amount] = numCost.Value * numQty.Value;
            if (expiryitem) row[Stock.col_expiry] = dtpExpiry.Value;

            pur.tblCart.Rows.Add(row);

            showCart();
        }

        void showCart()
        {
            dgvData.DataSource = pur.tblCart;
            com.hideColumns(dgvData, new string[] { Product.col_prod_id, Purchase.col_sno});
            com.showColumns(dgvData, new string[] { "Remove" });
            com.enableColumns(dgvData, new string[] { Purchase.col_frieght }, Custom.fet_freight);
            dgvData.Sort(dgvData.Columns[Purchase.col_sno], ListSortDirection.Descending);
        }

        bool validItem()
        {
            bool res = true;
            if(Custom.mod_fnb)
                res = com.chkValid(new Control[] { txtProdName, numCost, numQty }, new string[] { "Product Name", "Cost Price", "Quantity" }, lblMsg, tmrMsg);
            else
                res = com.chkValid(new Control[] { txtProdName, numCost, numRetail, numQty }, new string[] { "Product Name", "Cost Price", "Retail Price", "Quantity" }, lblMsg, tmrMsg);
            if (prod.id == 0)
            {
                com.msg = "Please add the new Product";
                com.msg_type = Constants.message_info;
                res = false;
            }
            return res;
        }

        void loadFields(DataGridViewRow row)
        {
            if (prod.id == Convert.ToInt64(row.Cells[Product.col_prod_id].Value))        //return if same product is loaded
                return;

            prod.id = Convert.ToInt64(row.Cells[Product.col_prod_id].Value);
            obji.prod_id = prod.id;
            
            loading = true;

            Control[] C = { txtProdCode, txtProdName, numCost, numWhole, numRetail };
            string[] S = { Product.col_code, Product.col_prod_name, Product.col_cost, Product.col_whole, Product.col_retail};
            com.loadFields(row, C, S);
            
            numQty.Value = 0;
            prod.category = Convert.ToInt16(row.Cells[Product.col_cate].Value);
            if (Purchase.mod_mobile)
            {
                btnAddIMEI.Enabled = prod.category == Constants.cate_mobile;
                numQty.Enabled = !(prod.category == Constants.cate_mobile);
                if (btnAddIMEI.Enabled)
                    showImei();
            }
            if (Purchase.mod_fnb)
                pnlRetail.Visible = prod.category == Constants.cate_stock;
            numQty.Focus();
            loading = false;
        }

        void clearItem()
        {
            Control[] C = new Control[] { txtProdCode, txtProdName, numCost, numWhole, numRetail, numQty, numAmount };

            com.clearControls(C);
            prod.id = 0;
            focusProd();
            chkExpiry.Checked = false;
        }

        void clearValues()
        {
            pur.total = 0;
            pur.discount = 0;
            pur.paid = 0;
            pur.remain = 0;
            Control[] C = new Control[] { numBillTotal, numDiscount, numPaid, numCredit, txtCheq_no };
            com.clearControls(C);
        }

        void clear()
        {
            if (pur.tblIMEI != null) pur.tblIMEI.Clear();
            Control[] C = new Control[] { numClientBal, txtAccno, cmbBank, cmbClient, txtCheq_no, numFrieght };
            com.clearControls(C);
            prod.id = 0;
            sno = 0;
        }

        void getData()
        {
            pur.date = dtpDate.Value;
            pur.bank_id = Convert.ToInt64(cmbBank.SelectedValue);
            pur.sup_id = Convert.ToInt64(cmbClient.SelectedValue);
            pur.sup_led.sup_id = pur.sup_id;
            pur.sup_led.invoice = Convert.ToInt64(numInvoiceno.Value);
            pur.sup_led.date = pur.date;
            pur.cheq.cheq_no = txtCheq_no.Text;
            pur.narration = "To Purchase: " + cmbClient.Text;
            pur.freight = Convert.ToInt64(numFrieght.Value);

            if (!string.IsNullOrEmpty(txtCheq_no.Text))
            {
                pur.cheq.bnk_id = pur.bank_id;
                pur.cheq.cheq_type = Constants.cheq_pymnt;
                pur.cheq.amt = Convert.ToInt64(numPaid.Value);
                pur.cheq.issue_date = dtpCheqDate.Value;
            }
            
            if (Custom.client_id_active == 1 || Custom.client_id_active == 5 || Custom.client_id_active == 7)
                pur.stock.term_id = Constants.term_store;
            else if (Custom.client_id_active == 2)
                pur.stock.term_id = Convert.ToInt64(cmbTermin.SelectedValue);
            else
                pur.stock.term_id = Constants.term_shop;
        }

        void showImei()
        {
            obji.ShowDialog();
            pur.tblIMEI = obji.objImei.tblTempTable;
            if (pur.tblIMEI.Rows.Count > 0)
                numQty.Value = Convert.ToInt16(pur.tblIMEI.Compute("count([" + Imei.col_imei + "])", "[" + Imei.col_prod_id + "] = " + prod.id));
            else
                numQty.Value = 0;
        }

        void loadProd()
        {
            string tmpCode = txtProdCode.Text;
            if (tmpCode.Equals(""))
                return;

            showProducts();
            com.filterData(tmpCode, Product.col_code, dgvData, tblProd);
            
            if (dgvData.RowCount == 1)
            {
                loadFields(dgvData.Rows[0]);
            }
        }

        void loadTerminals()
        {
            tblTermin = termin.getTermin();
            com.loadCombo(cmbTermin, tblTermin, Termin.col_name, Termin.col_id);
        }

        void setLblPaid()
        {
            if (cmbBank.Text == "" && txtCheq_no.Text == "")
                lblPaid.Text = "Paid as Cash";
            else if (cmbBank.SelectedIndex >= 0 && txtCheq_no.Text == "")
                lblPaid.Text = "Paid as Bank Transfer";
            else if (cmbBank.SelectedIndex >= 0 && txtCheq_no.Text != "")
                lblPaid.Text = "Paid as Bank Cheque";
        }

        #endregion

        #region loadFunctions
        
        void showProducts()
        {
            if (Custom.mod_fnb)
                prod.cateRaw = prod.cateStk = prod.multiCate = true;
            else if (Custom.mod_manufact)
                prod.cateStk = prod.cateRaw = prod.multiCate = true;
            else if (Custom.mod_bakers)
                prod.cateStk = prod.cateBakery = prod.multiCate = true;
            else if (Custom.mod_mobile)
                prod.cateStk = prod.cateMobile = prod.multiCate = true;
            tblProd = prod.getProducts(true);
            dgvData.DataSource = tblProd;
            com.hideColumns(dgvData, new string[] { Product.col_prod_id, "Remove", "Review", Product.col_cate });
            com.enableColumns(dgvData, new string[] { Product.col_retail, Product.col_whole}, !Custom.mod_fnb);
            if (Custom.client_id_active == 5)
                com.hideColumns(dgvData, new string[] { Product.col_unit });
            com.enableColumns(dgvData, new string[] { Purchase.col_frieght }, Custom.fet_freight);
        }

        void loadSupliers()
        {
            tblSuplier = sup.getSupliers();
            com.loadCombo(cmbClient, tblSuplier, Supplier.col_sup_name, Supplier.col_id);
        }

        void setInvoiceNo()
        {
            numInvoiceno.Value = db.getNextId("Purchase");
        }

        void setMinDate()
        {
            dtpExpiry.MinDate = DateTime.Now;
        }

        void loadBanks()
        {
            tblBank = bnk.getBanks();
            com.loadCombo(cmbBank, tblBank, Bank.col_bank, Bank.col_id);
        }

        void divideFrieght()
        {
            if (!Custom.fet_freight)
                return;

            if (pur.tblCart.Rows.Count <= 0)//numFrieght.Value <= 0 ||
                return;
            float tmpCost = 0, freightRatio = 0, tmpFreight = 0;
            
            pur.freight = Convert.ToInt64(numFrieght.Value);
            freightRatio = (float)pur.freight / pur.total;

            foreach (DataRow row in pur.tblCart.Rows)
            {
                tmpCost = Convert.ToInt64(row[Purchase.col_cost]);
                tmpFreight = (float)Math.Round(tmpCost * freightRatio, 2);
                row[Purchase.col_frieght] = tmpFreight;
            }
        }

        void resize()
        {
            Size siz = SystemInformation.VirtualScreen.Size;
            if (siz.Height == 768 && siz.Width == 1024)
            {
                Font = new Font("Arial Narrow", 13);
            }
        }
        #endregion

        #region Events

        private void cmbClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loading)
                return;

            sup.id = Convert.ToInt64(cmbClient.SelectedValue);
            sup.balance = sup.getSuplierBal(sup.id);
            numClientBal.Value = sup.balance;
        }

        private void cmbClient_TextChanged(object sender, EventArgs e)
        {
            if (cmbClient.Text == "")
            {
                cmbClient.SelectedIndex = -1;
            }
        }

        private void cmbBank_TextChanged(object sender, EventArgs e)
        {
            setLblPaid();
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

        private void numWhole_Leave(object sender, EventArgs e)
        {
            if (numWhole.Value <= numCost.Value)
                numWhole.Value = 0;
        }

        private void numRetail_Leave(object sender, EventArgs e)
        {
            if (numRetail.Value <= numWhole.Value)
                numRetail.Value = 0;
        }

        private void numCost_ValueChanged(object sender, EventArgs e)
        {
            calAmount();
        }

        private void numQty_ValueChanged(object sender, EventArgs e)
        {
            calAmount();
        }

        private void frmPurchase_Load(object sender, EventArgs e)
        {
            loading = true;
            com.loadFormInfo(this, "Goods Purchase", lblClient, lblTitle);
            resize();
            customize();
            showProducts();
            loadBanks();
            loadSupliers();
            setInvoiceNo();
            loadTerminals();
            loading = false;
        }

        private void txtProdName_TextChanged(object sender, EventArgs e)
        {
            if (loading)
                return;
            if(dgvData.DataSource != tblProd)
                showProducts();
            com.filterData(txtProdName.Text, Product.col_prod_name, dgvData, tblProd);
        }
        
        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            loading = true;
            if (dgvData.Columns["Remove"].Visible == false)
            {
                loadFields(dgvData.Rows[e.RowIndex]);
                calTotals();
            }
            else if (dgvData.DataSource == pur.tblCart && dgvData.Columns[e.ColumnIndex].Name == "Remove")
            {
                pur.tblCart.Rows.RemoveAt(e.RowIndex);
                dgvData.DataSource = pur.tblCart;
                com.delRows(obji.objImei.tblTempTable, Product.col_prod_id, obji.prod_id);       
                calTotals();
                divideFrieght();
            }
            else if (dgvData.DataSource == pur.tblCart && dgvData.Columns[e.ColumnIndex].Name == "Review")
            {
                pur.tblCart.Rows.RemoveAt(e.RowIndex);
            }
            loading = false;
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            pur.tblCart.Rows.Clear();
            showProducts();
            clearValues();
            clearItem();
            sno = 0;
            obji = new frmIMEI();
            btnAddIMEI.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loading = true;
            if (!validItem())
            {
                com.showMessage(lblMsg, tmrMsg);
                return;
            }
            if (expiryitem)
            {
                string[] S = { Product.col_code, Product.col_prod_name, Classes.Stock.col_cost, Classes.Stock.col_whole, Classes.Stock.col_retail, Classes.Stock.col_qty, Classes.Stock.col_amount, Stock.col_expiry };
                Control[] C = { txtProdCode, txtProdName, numCost, numWhole, numRetail, numQty, numAmount, dtpExpiry };
                dgvData.DataSource = pur.tblCart;
                com.addtoGrid(dgvData, pur.tblCart, S, C);
            }
            else
            {
                string[] S = { Product.col_code, Product.col_prod_name, Classes.Stock.col_cost, Classes.Stock.col_whole, Classes.Stock.col_retail, Classes.Stock.col_qty, Classes.Stock.col_amount};
                Control[] C = { txtProdCode, txtProdName, numCost, numWhole, numRetail, numQty, numAmount };
                dgvData.DataSource = pur.tblCart;
                com.addtoGrid(dgvData, pur.tblCart, S, C);
            }
            
            pur.tblCart.Rows[pur.tblCart.Rows.Count - 1][Product.col_prod_id] = prod.id;
            pur.tblCart.Rows[pur.tblCart.Rows.Count - 1][Purchase.col_sno] = pur.tblCart.Rows.Count;
            showCart();
            calTotals();
            clearItem();
            divideFrieght();
            loading = false;
        }
        
        private void numDiscount_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnBank_Click(object sender, EventArgs e)
        {
            General.frmBank bnk = new General.frmBank();
            bnk.ShowDialog();
            loadBanks();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!validPurchase())
                return;

            calTotals();
            getData();
            
            bool res = pur.SavePurchase();
            if (res)
            {
                loading = true;
                clear();
                tblProd = prod.getProducts(true);
                setInvoiceNo();
                loadSupliers();
                btnCart_Click(sender, e);
                com.showMessage("Stock Purchased Successfully", lblMsg, Constants.message_success, tmrMsg);
                loading = false;
            }
            else
            {
                com.showMessage("Stock Purchase Transaction Stoped", lblMsg, Constants.message_error, tmrMsg);                
            }
        }

        private void numPaid_ValueChanged(object sender, EventArgs e)
        {
            if (numPaid.Value > numBillTotal.Value)
                numPaid.Value = numBillTotal.Value;
            
            calTotals();
        }

        private void numBillTotal_ValueChanged(object sender, EventArgs e)
        {
            if (numDiscount.Value > numBillTotal.Value)
                numDiscount.Value = 0;
            if (cmbClient.SelectedIndex >= 0)
                numPaid.Value = numBillTotal.Value - numDiscount.Value;
            else
                numPaid.Value = 0;
        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            frmPurchaseReview review = new frmPurchaseReview();
            review.ShowDialog();
            showProducts();
        }

        #endregion

        private void btnClient_Click(object sender, EventArgs e)
        {
            frmSuplier sup = new frmSuplier();
            sup.ShowDialog();
            loadSupliers();
        }

        private void chkExpiry_CheckedChanged(object sender, EventArgs e)
        {
            expiryitem = chkExpiry.Checked;
            prod.stock.expiryitem = expiryitem;
            dtpExpiry.Visible = expiryitem;
            lblExpire.Visible = expiryitem;
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            frmProducts frmProd = new frmProducts();
            frmProd.called = true;
            frmProd.txtProdCode.Text = txtProdCode.Text;
            frmProd.ShowDialog();
            
            showProducts();
            txtProdCode.Text = frmProd.prod.code;
            loadProd();    //loads currently added Product
        }

        private void txtProdCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (loading)
                    return;

                showProducts();
                loadProd();
            }
        }

        private void btnAddIMEI_Click(object sender, EventArgs e)
        {
            showImei();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCheq_no_Leave(object sender, EventArgs e)
        {
            if(txtCheq_no.Text.Length > 0)
                lblPaid.Text = "Paid as Cheque";
        }

        private void txtCheq_no_TextChanged(object sender, EventArgs e)
        {
            setLblPaid();
        }

        private void numFrieght_ValueChanged(object sender, EventArgs e)
        {
            divideFrieght();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}