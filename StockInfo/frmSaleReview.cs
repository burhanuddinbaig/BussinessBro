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
    public partial class frmSaleReview : frmBaseSalePur
    {
        public frmSaleReview()
        {
            InitializeComponent();
        }

        Common com = new Common();

        DataTable tblBills = null;
        DataTable tblCart = null;
        DataTable tblProd = null;
        DataTable tblCus = null;
        DataTable tblProdSrh = null;
        Product prod = new Product();
        Classes.Stock stock = new Classes.Stock();
        frmIMEI obji = new frmIMEI();
        Customer cus = new Customer();
        Sale sale = new Sale();

        bool is_service = false;

        void loadBillsByDate()
        {
            sale.prod_id = sale.cus_id = 0;
            tblBills = sale.getAllBills(dtpDateSrh.Value);
            com.showColumns(dgvData, new string[] { Sale.col_credit, Sale.col_discount, Sale.col_amount, Sale.col_paid });
            showBills();
            clearValues();
        }

        void loadBillsByCus()
        {
            sale.cus_id = Convert.ToInt64(cmbCusSrh.SelectedValue);
            sale.prod_id = 0;
            tblBills = sale.getAllBills(dtpDateSrh.Value);
            showBills();
            clearValues();
        }

        void clearValues()
        {
            loading = true;
            numBillTotal.Value = 0;
            numDiscount.Value = 0;
            numPaid.Value = 0;
            numCredit.Value = 0;
            numRefund.Value = 0;
            loading = false;
        }

        void loadBillsByProd()
        {
            sale.month = Convert.ToInt16(cmbMonth.SelectedIndex + 1);
            sale.year = Convert.ToInt32(numYear.Value);
            sale.prod_id = Convert.ToInt64(cmbProdSrh.SelectedValue);
            sale.cus_id = 0;
            com.hideColumns(dgvData, new string[] { Sale.col_credit, Sale.col_discount, Sale.col_amount, Sale.col_paid });
            tblBills = sale.getAllBills(dtpDateSrh.Value);
            showBills();
            clearValues();
        }

        void showImei()
        {
            obji.toReturn = false;
            obji.fromSale = true;
            obji.ShowDialog();
            sale.tblIMEI = obji.objImei.tblTempTable;
            if (sale.tblIMEI.Rows.Count > 0)
                numQty.Value = Convert.ToInt16(sale.tblIMEI.Compute("count([" + Imei.col_imei + "])", "[" + Imei.col_prod_id + "] = " + obji.prod_id));
            else
                numQty.Value = 0;
        }

        void showImeiReturn(int rowIndex)
        {
            obji.toReturn = true;
            obji.fromSale = false;
            obji.prod_id = Convert.ToInt64(dgvData.Rows[rowIndex].Cells[Sale.col_prod_id].Value);
            obji.Text = "Return Gadget";
            obji.ShowDialog();
            btnAddIMEI.Enabled = true;
            dgvData.Rows[rowIndex].Cells[Sale.col_qty].Value = obji.counter;
            dgvData.Rows[rowIndex].Cells[Sale.col_amount].Value = Convert.ToInt64(dgvData.Rows[rowIndex].Cells[Sale.col_qty].Value) * Convert.ToInt64(dgvData.Rows[rowIndex].Cells[Sale.col_price].Value);
            if (obji.counter <= 0)
                tblCart.Rows.RemoveAt(rowIndex);
        }
        
        void customize()
        {
            btnAddIMEI.Visible = Purchase.mod_mobile;
            if (Custom.mod_manufact) this.Text = lblTitle.Text = "Sale and Delivery Review";
            //if(Custom.client_id_active == 6)
            //    pnlTots.SendToBack();
            pnlCell.Visible = Custom.client_id_active == 6;
            if (Custom.fet_item_dist)
            {
                numDiscount.Enabled = false;
                pnlDist.Visible = true;
            }
        }

        void showBills()
        {
            dgvData.DataSource = tblBills;
            com.hideColumns(dgvData, new string[] { Sale.col_cus_id, Sale.col_bank_id, Sale.col_tran_id, Classes.Stock.col_cost, Sale.col_credit, "Return" });
            com.showColumns(dgvData, new string[] { "Review" });
        }

        void loadProducts()
        {
            tblProd = prod.getProducts(true);
            com.loadCombo(cmbProd, tblProd, Product.col_prod_name, Product.col_prod_id);
        }

        void loadProdInfo()
        {
            if (!com.chkCombo(cmbProd))
                return;
            DataRow row = tblProd.Rows[cmbProd.SelectedIndex];
            com.loadFields(row,new Control[]{ numPrice, numStock }, new string[]{ Product.col_retail, Product.col_stock });
            if (Purchase.mod_mobile)
            {
                btnAddIMEI.Enabled = Convert.ToInt16(row[Product.col_cate].ToString()) == Constants.cate_mobile;
                numQty.Enabled = !(Convert.ToInt16(row[Product.col_cate].ToString()) == Constants.cate_mobile);
                obji.prod_id = Convert.ToInt16(row[Product.col_prod_id].ToString());
                if (btnAddIMEI.Enabled)
                    showImei();
            }
            if (Custom.client_id_active == 5 || Custom.client_id_active == 1)
            {
                is_service = Convert.ToInt16(row[Product.col_cate]) == Constants.cate_service;    
            }
        }

        void loadBillInfo(DataGridViewRow row)
        {
            if (tblBills == null)
                return;
            if (dgvData.DataSource != tblBills)
                return;
            if (row.Cells[Sale.col_bank_id] != null)
                sale.bank_id = Convert.ToInt64(row.Cells[Sale.col_bank_id].Value);
            else
                sale.bank_id = 0;
            if (row.Cells[Sale.col_cus_id] != null)
            {
                sale.cus_id = Convert.ToInt64(row.Cells[Sale.col_cus_id].Value);
                sale.acc_id_cus = cus.getAccId("Customer", sale.cus_id);
            }
            else
                sale.cus_id = 0;

            sale.tran_id = Convert.ToInt64(row.Cells[Sale.col_tran_id].Value);
            com.loadFields(row, new Control[] { numInvoiceno, dtpDate, numDiscount, numPaid }, new string[]{ Sale.col_bill_no, Sale.col_date, Sale.col_discount, Sale.col_paid });
            numCredit.Value = numBillTotal.Value - numDiscount.Value - numPaid.Value > 0 ? numBillTotal.Value - numDiscount.Value - numPaid.Value : 0;
            if (sale.cus_id > 0)
            {
                loading = true;
                cmbCusSrh.SelectedValue = sale.cus_id;
                loading = false;
            }

            obji.objImei.tran_id = sale.tran_id;
            obji.objImei.tblTempTable = obji.objImei.getIMEIs();
        }

        void getInitAmt()
        {
            sale.init_amt = sale.total - sale.discount;
        }

        void calRefund()
        {
            if (numCredit.Value > 0)
                clearRefund();
            long tmp = sale.init_amt - (sale.total - sale.discount);

            if (tmp > 0)
            {
                lblRefund.Text = "Refund";
                lblRefund.ForeColor = SystemColors.ControlLightLight;
                numRefund.Value = tmp;
            }
            else
            {
                lblRefund.Text = "Reciept";
                lblRefund.ForeColor = Color.Orange;
                numRefund.Value = -tmp;
            }
        }

        void clearRefund()
        {
            numRefund.Value = 0;
            lblRefund.Text = "Refund";
            lblRefund.ForeColor = SystemColors.ControlLightLight;
        }

        void getData()
        {
            calValues();
            sale.id = Convert.ToInt64(numInvoiceno.Value);
            sale.date = dtpDate.Value;
            sale.tblCart = tblCart;
            if (Sale.mod_mobile)
                sale.tblIMEI = obji.objImei.tblTempTable;
            if (Custom.client_id_active == 5 || Custom.client_id_active == 2)
                sale.createRaw();
        }

        void loadCart(DataGridViewRow row)
        {
            tblCart = stock.getSaleStock(Convert.ToInt64(row.Cells[Sale.col_tran_id].Value));
            dgvData.DataSource = tblCart;
            com.hideColumns(dgvData, new string[] { Classes.Stock.col_id, Classes.Stock.col_prod_id, Classes.Stock.col_tran_id, Classes.Stock.col_cost, Product.col_cate, "Review" });
            com.showColumns(dgvData, new string[] { "Return" });
            if (Custom.client_id_active == 5)
                com.hideColumns(dgvData, new string[] {Classes.Stock.col_unit});
            if (!Custom.fet_item_dist)
                com.hideColumns(dgvData, new string[] {Stock.col_item_dist});
        }

        void calValues()
        {
            if (loading)
                return;
            if (tblCart != null)
            {
                if (tblCart.Rows.Count > 0)
                {
                    sale.total = Convert.ToInt64(tblCart.Compute("sum(" + Classes.Stock.col_amount + ")", ""));
                    sale.tot_cost = Convert.ToInt64(tblCart.Compute("sum(" + Classes.Stock.col_cost + ")", ""));
                    numBillTotal.Value = sale.total;
                    if(Custom.fet_item_dist)
                        numDiscount.Value = Convert.ToInt64(tblCart.Compute("sum(" + Classes.Stock.col_item_dist + ")", ""));
                }
                else
                    clearValues();
            }
            else
                clearValues();
            if (numPaid.Value > numBillTotal.Value - numDiscount.Value)
            {
                numPaid.Value = numBillTotal.Value - numDiscount.Value;
            }
            if (sale.cus_id <= 0)
            {
                numPaid.Value = numBillTotal.Value - numDiscount.Value;
            }
            else
                numCredit.Value = numBillTotal.Value - numDiscount.Value - numPaid.Value;

            sale.discount = Convert.ToInt32(numDiscount.Value);
            sale.paid = Convert.ToInt64(numPaid.Value);
        }

        void clear()
        {
            if (sale.tblIMEI != null) 
                sale.tblIMEI.Clear();
            if (sale.tblRaw != null)
                sale.tblRaw.Clear();

            com.clearForm(this, false);
            loadProducts();
        }

        void loadMonth()
        {
            numYear.Value = DateTime.Now.Year;
            cmbMonth.SelectedIndex = DateTime.Now.Month - 1;
        }

        void clearItem()
        {
            com.clearControls(new Control[]{cmbProd, numPrice, numStock, numQty, numAmount});
            cmbProd.Focus();
        }

        private bool itemExists(long prodId)
        {
            if (tblCart == null)
                return false;
            
            for (int i = 0; i < tblCart.Rows.Count; i++)
            {
                if (Convert.ToInt64(tblCart.Rows[i][Classes.Stock.col_prod_id].ToString()) == prodId)
                {
                    tblCart.Rows[i][Classes.Stock.col_sold] = numPrice.Value;
                    tblCart.Rows[i][Classes.Stock.col_qty] = numQty.Value;
                    if(numDist.Value > 0)
                        tblCart.Rows[i][Stock.col_item_dist] = numDist.Value;
                    tblCart.Rows[i][Classes.Stock.col_amount] = numPrice.Value * numQty.Value;

                    dgvData.DataSource = tblCart;
                    clearItem();
                    calValues();
                    calRefund();
                    return true;
                }
            }
            return false;
        }

        bool validation()
        {
            if (!com.chkValid(new Control[] { cmbProd, numQty }, new string[] { "Product Name", "Quantity" }))
                return false;
            if (!((dgvData.DataSource == tblCart) || com.chkNum(numQty, "Quantity") || com.chkCombo(cmbProd, "Product")))
                return false;
            if (itemExists(Convert.ToInt64(cmbProd.SelectedValue)))
                return false;
            return true;
        }

        public void loadProdSrh()
        {
            prod.multiCate = prod.cateStk = prod.cateGadget = prod.cateBakery = prod.cateMobile = true;
            tblProdSrh = prod.getProducts();
            com.loadCombo(cmbProdSrh, tblProdSrh, Product.col_prod_name, Product.col_id);
        }

        public void loadCustomer()
        {
            tblCus = cus.getCustomers();
            com.loadCombo(cmbCusSrh, tblCus, Customer.col_name, Customer.col_id);
            com.loadCombo(cmbCell, tblCus, Customer.col_contact, Customer.col_id);
        }

        private void calAmount()
        {
            numAmount.Value = numPrice.Value * numQty.Value;
        }

        void resize()
        {
            Size siz = SystemInformation.VirtualScreen.Size;
            if (siz.Height == 768 && siz.Width == 1024)
            {
                Font = new Font("Arial Narrow", 13);
            }
        }

        private void numQty_ValueChanged(object sender, EventArgs e)
        {

            if (numQty.Value > numStock.Value && !is_service)
            {
                com.showMessage("Sorry, you have only " + numStock.Value + " items in Stock ", lblMsg, Constants.message_info, tmrMsg);
                numQty.Value = 1;
                numQty.Focus();
            }
            calAmount();
        }

        private void numPrice_ValueChanged(object sender, EventArgs e)
        {
            calAmount();
        }

        private void frmSaleReview_Load(object sender, EventArgs e)
        {
            loading = true;
            com.loadFormInfo(this, "Sale Review", lblClient, lblTitle);
            customize();
            resize();
            loadProducts();
            loadProdSrh();
            loadCustomer();
            loadMonth();
            loadBillsByDate();
            numCredit.BackColor = Color.White;
            loading = false;
        }
        private void cmbProd_SelectedValueChanged(object sender, EventArgs e)
        {
            if (loading)
                return;
            loadProdInfo();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dtpDate.Value = DateTime.Today;
            loadBillsByDate();
        }

        private void btnBillnoSrh_Click(object sender, EventArgs e)
        {
            if (!com.chkNum(numBillnoSrh))
                return;

            com.filterValue(numBillnoSrh.Value.ToString(), Sale.col_bill_no, dgvData, tblBills);

        }

        private void btnAddtoBill_Click(object sender, EventArgs e)
        {
            if (!validation())
                return;

            DataRow row = tblCart.NewRow();
            DataRow rowProd = ((DataTable)cmbProd.DataSource).Rows[cmbProd.SelectedIndex];

            row[Classes.Stock.col_id] = 0;
            row[Classes.Stock.col_tran_id] = 0;
            row[Classes.Stock.col_prod_id] = cmbProd.SelectedValue;
            row[Product.col_prod_name] = cmbProd.Text;
            row[Classes.Stock.col_cost] = rowProd[Classes.Stock.col_cost];
            row[Classes.Stock.col_qty] = numQty.Value;
            row[Classes.Stock.col_sold] = numPrice.Value;
            row[Classes.Stock.col_amount] = numQty.Value * numPrice.Value;
            row[Product.col_cate] = rowProd[Product.col_cate];
            row[Classes.Stock.col_item_dist] = numDist.Value;

            tblCart.Rows.Add(row);
            dgvData.DataSource = tblCart;

            clearItem();
            calValues();
            calRefund();
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
                return;
            if (dgvData.DataSource == tblBills && dgvData.Columns[e.ColumnIndex].Name == "Review")
            {
                loading = true;
                loadBillInfo(dgvData.Rows[e.RowIndex]);
                loadCart(dgvData.Rows[e.RowIndex]);
                loading = false;
                calValues();
                getInitAmt();
            }
            if (dgvData.DataSource == tblCart && dgvData.Columns[e.ColumnIndex].Name == "Return")
            {
                if (!com.sureOption("Do you want to Return such item"))
                    return;
                loading = true;
                if (Convert.ToInt16(tblCart.Rows[e.RowIndex][Product.col_cate].ToString()) == Constants.cate_mobile)
                    showImeiReturn(e.RowIndex);
                else
                {
                    btnAddIMEI.Enabled = false;
                    tblCart.Rows.RemoveAt(e.RowIndex);
                }
                dgvData.DataSource = tblCart;

                //com.delRows(obji.objImei.tblTempTable, Product.col_prod_id, obji.prod_id);
                
                sale.tblIMEI = obji.objImei.tblTempTable;
                loading = false;
                calValues();
                calRefund();
            }
        }

        private void numPaid_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dgvData.DataSource == tblBills)
                return;
            getData();
            bool res = false;
            if (tblCart.Rows.Count > 0)
                res = sale.updateBill();
            else
                res = sale.deleteBill();
            if (res)
            {
                clear();
                clearRefund();
                calValues();
                tblBills = null;
                loadBillsByDate();
            }
            com.showMessage(sale.msg, lblMsg, sale.msg_type, tmrMsg);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!com.delOption("Bill"))
                return;
            if (dgvData.DataSource == tblBills)
                return;
            getData();
            bool res = sale.deleteBill();
            if (res)
            {
                clear();
                tblBills = null;
                loadBillsByDate();
            }

            com.showMessage(sale.msg, lblMsg, sale.msg_type, tmrMsg);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (loading) return;
            loading = true;
            sale.printBill();
            loading = false;
        }

        private void btnAddIMEI_Click(object sender, EventArgs e)
        {
            showImei();
        }

        private void dgvData_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (dgvData.DataSource != tblCart)
                return;
            dgvData.EndEdit(DataGridViewDataErrorContexts.RowDeletion);
            if (dgvData.DataSource.GetType() == typeof(DataView))
                tblCart = ((DataView)dgvData.DataSource).ToTable();
            else if (dgvData.DataSource.GetType() == typeof(DataTable))
                tblCart = (DataTable)dgvData.DataSource;
        }

        private void numDiscount_ValueChanged(object sender, EventArgs e)
        {
            calValues();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbProdSrh_SelectedValueChanged(object sender, EventArgs e)
        {
            if (loading)
                return;
            loadBillsByProd();
        }

        private void cmbCusName_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void numYear_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbProdSrh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void dtpDateSrh_ValueChanged(object sender, EventArgs e)
        {
            loadBillsByDate();
        }

        private void cmbCusSrh_SelectedValueChanged(object sender, EventArgs e)
        {
            if (loading)
                return;
            //loading = true;
            //cmbCell.SelectedValue = Convert.ToInt64(cmbClient.SelectedValue);
            //loading = false;
            loadBillsByCus();
        }

        private void cmbCell_SelectedValueChanged(object sender, EventArgs e)
        {
            if (loading)
                return;
            loading = true;
            cmbClient.SelectedValue = Convert.ToInt64(cmbCell.SelectedValue);
            loading = false;
        }

        private void numBillTotal_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numCredit_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}