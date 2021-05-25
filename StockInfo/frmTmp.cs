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
using prjGrow.Manufacture;

namespace prjGrow.StockInfo
{
    public partial class frmTmp : frmBaseSalePur
    {
        public frmTmp()
        {
            InitializeComponent();
        }

        Common com = new Common();
        Sale sale = new Sale();
        Product prod = new Product();
        Bank bnk = new Bank();
        Customer cus = new Customer();
        Vehicle veh = new Vehicle();

        DataTable tblCus = null;
        DataTable tblLabour = new DataTable();
        DataTable tblVeh = new DataTable();
        Orders odr = new Orders();
        frmOrders frmOdr = new frmOrders();
        clsDb db = new clsDb();
        Employee emp = new Employee();

        public frmLabour frmLab = new frmLabour();
        public frmDelivery frmDeliver = new frmDelivery();
        frmIMEI obji = new frmIMEI();
        bool loading = false;
        bool is_service = false;
        bool is_bakery = false;     //to less stock bakers if purchased entry not pushed yet

        #region functions
        public void createCart()
        {
            sale.tblCart = new DataTable();
            sale.tblCart.Columns.Add(Product.col_prod_id, typeof(long));
            sale.tblCart.Columns.Add(Product.col_code, typeof(string));
            sale.tblCart.Columns.Add(Product.col_prod_name, typeof(string));
            sale.tblCart.Columns.Add(Product.col_cost, typeof(double));
            sale.tblCart.Columns.Add(Product.col_price, typeof(double));
            if(Custom.client_id_active == 5)
                sale.tblCart.Columns.Add(Product.col_real_price, typeof(double));
            sale.tblCart.Columns.Add(Product.col_qty, typeof(float));
            sale.tblCart.Columns.Add(Product.col_amount, typeof(float));
            sale.tblCart.Columns.Add(Product.col_stock, typeof(float));
            sale.tblCart.Columns.Add(Product.col_cate, typeof(short));
            if (Sale.mod_manufact || Sale.mod_bakers)
            {
                sale.tblCart.Columns.Add(Sale.col_order_no, typeof(long));
                sale.tblCart.Columns.Add(Product.col_unit, typeof(string));
            }
        }

        void loadProducts()
        {
            prod.onlyAvailable = true;
            if (Custom.mod_manufact && rbRetail.Checked && !(Custom.client_id_active == 7))
            {
                prod.cateStk = prod.cateGadget = prod.cateServ = prod.multiCate = true;
                prod.cateRaw = false;
            }
            else if (Custom.mod_manufact && rbWhole.Checked && !(Custom.client_id_active == 7))
            {
                prod.cateStk = prod.cateRaw = prod.multiCate = true;
                prod.cateGadget = prod.cateServ = false;
            }
            else if (Custom.client_id_active == 6 || Custom.client_id_active == 1)
                prod.cateServ = prod.allCate = true;
            else if (Custom.client_id_active == 7)
                prod.cateGadget = prod.allCate = true;
            else if (Custom.client_id_active == 2)
                prod.cateBakery = prod.cateStk = prod.cateServ = prod.allCate = true;

            sale.tblProducts = prod.getProducts(true);
            dgvData.DataSource = sale.tblProducts;

            if (rbRetail.Checked)
            {
                com.hideColumns(dgvData, new string[] { Product.col_prod_id, Product.col_cost, Product.col_whole, Product.col_cate, "Remove" });
                com.showColumns(dgvData, new string[] { Product.col_retail, Product.col_stock });
            }
            else if (rbWhole.Checked)
            {
                com.hideColumns(dgvData, new string[] { Product.col_prod_id, Product.col_cost, Product.col_retail, Product.col_cate, "Remove" });
                com.showColumns(dgvData, new string[] { Product.col_whole, Product.col_stock });
            }

            if (Custom.client_id_active == 5 || Custom.client_id_active == 3)
                com.hideColumns(dgvData, new string[] {Product.col_unit});
            if (Custom.client_id_active == 2)
                com.enableColumns(dgvData, new string[] { Product.col_unit }, User.curAuth == 2);
        }

        void loadBanks()
        {
            com.loadCombo(cmbBank, bnk.getBanks(), Bank.col_bank, Bank.col_id);
        }

        void loadCustomers()
        {
            tblCus = cus.getCustomers();
            com.loadCombo(cmbClient, tblCus, Customer.col_name, Customer.col_id);   
        }

        void loadBillno()
        {
            numInvoiceno.Value = db.getNextId("Sale");
        }

        void showCart()
        {
            dgvData.DataSource = sale.tblCart;
            com.hideColumns(dgvData, new string[] { "id", Product.col_cost, Product.col_real_price, Product.col_stock, Sale.col_order_no });
            com.showColumns(dgvData, new string[] { "Remove" });

            dgvData.ReadOnly = false;
            dgvData.Columns[Product.col_code].ReadOnly = true;
            dgvData.Columns[Product.col_prod_name].ReadOnly = true;
            dgvData.Columns[Product.col_amount].ReadOnly = true;
        }

        void clearValues()
        {
            sale.total = 0;
            sale.discount = 0;
            sale.paid = 0;

            numBillTotal.Value = 0;
            numDiscount.Value = 0;
            numPaid.Value = 0;
            numCredit.Value = 0;
            numChange.Value = 0;
        }

        void clearLabour()
        {
            frmLab = new frmLabour();
            btnServ.Enabled = false;
        }

        void clearDeliver()
        {
            btnDeliver.Text = "Deliver(0)";
            btnDeliver.Enabled = false;
        }

        void clearAll()
        {
            if(sale.tblCart != null)sale.tblCart.Clear();
            if (sale.tblOrders != null) sale.tblOrders.Clear();
            if (sale.tblIMEI != null) sale.tblIMEI.Clear();
            com.clearControls(new Control[]{cmbBank, cmbClient, txtAccno, txtProdCode, txtProdName, txtReference});
            clearValues();
            loadProducts();
            loadCustomers();
            loadBillno();
            cusDisplay();
            if(Custom.client_id_active == 6)
                clearLabour();
            if (btnDeliver.Enabled)
                clearDeliver();
        }

        void getData()
        {
            sale.date = dtpDate.Value;
            sale.reference = txtReference.Text;

            if (com.chkCombo(cmbClient))
                sale.cus_id = Convert.ToInt64(cmbClient.SelectedValue);
            else
                sale.cus_id = 0;

            if (com.chkCombo(cmbBank))
                sale.bank_id = Convert.ToInt64(cmbBank.SelectedValue);
            else
                sale.bank_id = 0;

            if (sale.tblOrders.Rows.Count > 0)
            {
                sale.discount += Convert.ToInt32(sale.tblOrders.Compute("Sum(" + Sale.col_discount + ")", "").ToString());
                
                if (sale.tblCart != null && sale.tblCart.Rows.Count > 0)
                    sale.total = Convert.ToInt64(sale.tblCart.Compute("Sum(" + Product.col_amount + ")", ""));
                else
                    sale.total = 0;
                if (sale.tblOrders != null && sale.tblOrders.Rows.Count > 0)
                {
                    sale.total += Convert.ToInt64(sale.tblOrders.Compute("Sum(" + Sale.col_amount + ")", ""));
                }
            }

            if (Custom.client_id_active == 5 || Custom.client_id_active == 2)
            {
                sale.createRaw();
                if (com.chkCombo(cmbEmp))
                    sale.emp_id = Convert.ToInt64(cmbEmp.SelectedValue);
                else
                    sale.emp_id = 0;
            }
            else if (Custom.client_id_active == 6)
                sale.empLed.tblLabour = tblLabour;
            else if (Custom.client_id_active == 7)
            {
                if (cmbVeh.Text == "")
                {
                    sale.stock.term_id = Constants.term_store;
                }
                else if (com.chkCombo(cmbVeh))
                {
                    sale.stock.term_id = Convert.ToInt64(tblVeh.Rows[cmbVeh.SelectedIndex][Distribute.col_trem_id]);
                }
            }
        }

        bool calValues()
        {
            if (loading)
                return true;
            //return false if cart is empty
            if (sale.tblCart == null && sale.tblOrders == null)
            {
                clearValues();
                return false;
            }

            if (sale.tblCart != null)
            {
                float tmpQty = 0, tmpPrice = 0, tmpCost = 0;

                for (int i = 0; i < sale.tblCart.Rows.Count; i++)
                {
                    tmpPrice = tmpQty = tmpCost = 0;
                    if (!string.IsNullOrWhiteSpace(sale.tblCart.Rows[i][Product.col_qty].ToString()))
                        tmpQty = (float)Convert.ToDouble(sale.tblCart.Rows[i][Product.col_qty].ToString());

                    if(!string.IsNullOrWhiteSpace(sale.tblCart.Rows[i][Product.col_price].ToString()))
                        tmpPrice = (float)Convert.ToDouble(sale.tblCart.Rows[i][Product.col_price].ToString());
                    if (!string.IsNullOrWhiteSpace(sale.tblCart.Rows[i][Product.col_cost].ToString()))
                    {
                        tmpCost = (float)Convert.ToDouble(sale.tblCart.Rows[i][Product.col_cost].ToString());
                        if (tmpPrice <= tmpCost && Custom.client_id_active != 7)
                        {
                            tmpPrice = tmpCost; //* (float)1.2;
                            sale.tblCart.Rows[i][Product.col_price] = tmpPrice;
                        }
                    }
                    sale.tblCart.Rows[i][Product.col_amount] = tmpQty * tmpPrice;
                    float tmpStock = (float)Convert.ToDouble(sale.tblCart.Rows[i][Product.col_stock].ToString());

                    if (Custom.client_id_active == 5 || Custom.client_id_active == 6 || Custom.client_id_active == 2)
                    {
                        is_service = Convert.ToInt16(sale.tblCart.Rows[i][Product.col_cate].ToString()) == Constants.cate_service;
                        is_bakery = Convert.ToInt16(sale.tblCart.Rows[i][Product.col_cate].ToString()) == Constants.cate_cake;
                    }
                    if (tmpQty > tmpStock && !is_service && !(Custom.client_id_active == 2 && is_bakery))          //check whether item quantity exeeds stock
                    {
                        clearValues();
                        if (dgvData.Columns["Remove"].Visible)
                        {
                            sale.tblCart.Rows[i][Product.col_qty] = 1;
                            sale.tblCart.Rows[i][Product.col_amount] = tmpPrice;
                        }
                        sale.setMessage("You have only " + tmpStock + " items available", Constants.message_info);
                        com.showMessage(sale.msg, lblMsg, sale.msg_type, tmrMsg);
                    }
                }
            }

            if (sale.tblCart != null && sale.tblCart.Rows.Count > 0)
            {
                sale.total = Convert.ToInt64(sale.tblCart.Compute("Sum(" + Product.col_amount + ")", ""));
                sale.tot_cost = Convert.ToInt64(sale.tblCart.Compute("Sum(" + Product.col_cost + ")", ""));
            }
            else
                sale.total = 0;
            if (sale.tblOrders != null && sale.tblOrders.Rows.Count > 0)
            {
                sale.total += Convert.ToInt64(sale.tblOrders.Compute("Sum(" + Sale.col_remain + ")", "")); 
            }
            sale.discount = Convert.ToInt32(numDiscount.Value) < Convert.ToInt64(numBillTotal.Value) ? Convert.ToInt32(numDiscount.Value) : 0;
            sale.paid = sale.total - sale.discount - Convert.ToInt32(numPaid.Value) <= 0 ? sale.total - sale.discount : Convert.ToInt32(numPaid.Value);
            
            loading = true;
            numBillTotal.Value = sale.total;
            loading = false;

            if (cmbClient.SelectedIndex >= 0)
            {
                numCredit.Value = (sale.total - sale.discount - sale.paid) > 0 ? (sale.total - sale.discount - sale.paid) : 0;
            }
            else
            {
                numCredit.Value = 0;
                loading = true;
                numPaid.Value = sale.paid < (sale.total - sale.discount) ? sale.total - sale.discount : numPaid.Value;
                loading = false;
            }

            if (numCredit.Value <= 0)
            {
                long change = Convert.ToInt32(numPaid.Value) - (sale.total - sale.discount);
                numChange.Value = change > 0 && change != sale.discount ? change : 0;
                if (change == sale.discount && change > 0)
                    numPaid.Value = sale.paid;
            }
            else
                numChange.Value = 0;

            return true;
        }

        void addToCart(DataGridViewRow rowProd)
        {
            if (sale.tblCart.Rows.Count <= 0)
                createCart();

            DataRow row = sale.tblCart.NewRow();
            prod.id = Convert.ToInt64(rowProd.Cells[Product.col_prod_id].Value);
            obji.prod_id = prod.id;

            row[Product.col_prod_id] = Convert.ToInt64(rowProd.Cells[Product.col_prod_id].Value);
            row[Product.col_code] = rowProd.Cells[Product.col_code].Value.ToString();
            row[Product.col_prod_name] = rowProd.Cells[Product.col_prod_name].Value.ToString();
            row[Product.col_cost] = Convert.ToDouble(rowProd.Cells[Product.col_cost].Value.ToString());
            if (rbRetail.Checked) row[Product.col_price] = Convert.ToInt64(rowProd.Cells[Product.col_retail].Value);
            else if (rbWhole.Checked) row[Product.col_price] = Convert.ToDouble(rowProd.Cells[Product.col_whole].Value);
            if (rbRetail.Checked && Custom.client_id_active == 5) row[Product.col_real_price] = Convert.ToInt64(rowProd.Cells[Product.col_retail].Value);
            else if (rbWhole.Checked && Custom.client_id_active == 5) row[Product.col_real_price] = Convert.ToDouble(rowProd.Cells[Product.col_whole].Value);
            row[Product.col_qty] = 1;
            row[Product.col_amount] = Convert.ToDouble(row[Product.col_qty].ToString()) * Convert.ToDouble(row[Product.col_price].ToString());
            float tmpStock = (float)Convert.ToDouble(rowProd.Cells[Product.col_stock].Value.ToString());
            row[Product.col_stock] = tmpStock;
            if (Custom.mod_mobile || Custom.mod_bakers)
                row[Product.col_unit] = rowProd.Cells[Product.col_unit].Value.ToString();
            if (Custom.mod_mobile || Custom.client_id_active == 5 || Custom.client_id_active == 6 || Custom.client_id_active == 1 || Custom.client_id_active == 2)
            {
                row[Product.col_cate] = Convert.ToInt64(rowProd.Cells[Product.col_cate].Value);
                is_service = Convert.ToInt16(row[Product.col_cate]) == Constants.cate_service;
                is_bakery = Convert.ToInt16(row[Product.col_cate]) == Constants.cate_cake;
            }
            if (tmpStock <= 0 && !is_service && !(is_bakery && Custom.client_id_active == 2))
            {
                com.showMessage("Stock is Empty for this Product",lblMsg, Constants.message_info, tmrMsg);
                return;
            }
            sale.tblCart.Rows.Add(row);
            bool ismobile = Custom.mod_mobile ? Convert.ToInt16(rowProd.Cells[Product.col_cate].Value) == Constants.cate_mobile : false;
            if (Sale.mod_mobile && ismobile)
            {
                btnAddIMEI.Enabled = ismobile;
            }
            else btnAddIMEI.Enabled = ismobile;
            showCart();
            if (Sale.mod_mobile && ismobile)
            {
                showImei();
            }
            if (is_service && (Custom.client_id_active == 6 || Custom.client_id_active == 1))
            {
                btnServ.Enabled = true;
                showServ();
            }
        }

        void customize()
        {
            btnAddIMEI.Visible = Sale.mod_mobile;
            btnDeliver.Visible = (Custom.mod_manufact && !(Custom.client_id_active == 7)) || Sale.mod_bakers;
        //    btnPurchase.Visible = Custom.client_id_active == 2;
            if (Custom.mod_manufact) this.Text = lblTitle.Text = "Sale and Delivery";
            btnOrder.Visible = Custom.client_id_active == 2 || (Custom.mod_manufact && !(Custom.client_id_active == 7));
            rbWhole.Checked = Custom.client_id_active == 7;
            btnServ.Visible = Custom.client_id_active == 6 || Custom.client_id_active == 1;
            if (Custom.client_id_active == 6)
                pnlTots.SendToBack();
            pnlEmp.Visible = Custom.client_id_active == 5;
            pnlVeh.Visible = Custom.client_id_active == 7;
            loading = true;
        }

        void showImei()
        {
            obji.fromSale = true;
            obji.ShowDialog();
            sale.tblIMEI = obji.objImei.tblTempTable;
            int countCart = sale.tblCart.Rows.Count;
            if (sale.tblIMEI.Rows.Count > 0)
            {
               dgvData.Rows[countCart-1].Cells[Product.col_qty].Value = Convert.ToInt16(sale.tblIMEI.Compute("count([" + Imei.col_imei + "])", "[" + Imei.col_prod_id + "] = " + prod.id));
            }
        }

        void showDelivery()
        {
            bool b = odr.haveOrders(sale.cus_id);
            if (b)
            {
                frmDeliver.ShowDialog();
                sale.tblOrders = frmDeliver.tblOrders;
            }
            else
                sale.tblOrders = new DataTable();

            btnDeliver.Enabled = b;
            btnDeliver.Text = "&Delivery("+sale.tblOrders.Rows.Count+")";
        }

        void showServ()
        {
            if (sale.tblCart.Rows.Count <= 0)
                return;
            object tmpObj = sale.tblCart.Compute("Sum(" + Sale.col_amount + ")", "" + Product.col_cate + " = " + Constants.cate_service);
            frmLab.serv_amt = tmpObj.GetType() == typeof(DBNull) ? 0 : Convert.ToInt64(tmpObj);
            frmLab.ShowDialog();
            tblLabour = frmLab.tblLabour;
        }

        void loadEmp()
        {
            sale.tblEmp = emp.getEmps();
            com.loadCombo(cmbEmp, sale.tblEmp, Customer.col_name, Customer.col_id);
        }

        void loadVeh()
        {
            tblVeh = veh.getVehicles();
            com.loadCombo(cmbVeh, tblVeh, Vehicle.col_veh_name, Vehicle.col_veh_id);
        }
        #endregion

        #region events

        private void frmSale_Load(object sender, EventArgs e)
        {
            loading = true;
            if (Custom.client_id_active == 6)
            {
                this.Location = new Point(50,5);
            }
            com.loadFormInfo(this, dgvData, "Sale Corner", lblClient, lblTitle);
            lblClient.Text = "Al Karim Bakers";
            customize();
            loadCustomers();
            loadProducts();
            
            loadBanks();
            loadBillno();
            if (Custom.client_id_active == 5)
                loadEmp();
            else if (Custom.client_id_active == 7)
                loadVeh();
//            clearDisplay();
            loading = false;
        }

        private bool itemExists(int rowIndex)
        {
            if (dgvData.Rows.Count <= 0)
            {
                com.showMessage("Item doesnt Exists", lblMsg, Constants.message_info, tmrMsg);
                if (sale.tblCart.Rows.Count > 0)
                    showCart();
                txtProdName.Text = "";
                txtProdCode.Text = "";
                txtProdCode.Focus();
                return true;
            }

            DataGridViewRow row = dgvData.Rows[rowIndex];
            if (sale.tblCart == null)
                return false;
            long tmpId = Convert.ToInt64(row.Cells[Product.col_prod_id].Value.ToString());
            long tmpQty = 0;

            for (int i = 0; i < sale.tblCart.Rows.Count; i++)
            {
                if (Convert.ToInt64(sale.tblCart.Rows[i][Product.col_prod_id].ToString()) == tmpId)
                {
                    if (!string.IsNullOrWhiteSpace(sale.tblCart.Rows[i][Product.col_qty].ToString()))
                        tmpQty = Convert.ToInt64(sale.tblCart.Rows[i][Product.col_qty].ToString());
                    tmpQty++;
                    showCart();

                    sale.tblCart.Rows[i][Product.col_qty] = tmpQty;

                    dgvData.ReadOnly = false;
                    com.lockColumns(dgvData, true, Product.col_code, Product.col_prod_name, Product.col_amount);
                    /*dgvData.Columns[Product.col_code].ReadOnly = true;
                    dgvData.Columns[Product.col_prod_name].ReadOnly = true;
                    dgvData.Columns[Product.col_amount].ReadOnly = true;*/

                    calValues();

                    txtProdName.Text = "";
                    txtProdCode.Text = "";
                    txtProdCode.Focus();
                    cusDisplay();
                    return true;
                }
            }
            return false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            calValues();
            getData();
            if (sale.saveSale())
            {
                if (chkBill.Checked)
                    sale.printBill();
                loading = true;
                clearAll();
                loading = false;
            }
            com.showMessage(sale.msg, lblMsg, sale.msg_type, tmrMsg);
        }

        private void cmbBank_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBank.SelectedIndex < 0 || loading || cmbBank.SelectedValue == null)
                return;
            txtAccno.Text = bnk.bankAccNo(Convert.ToInt64(cmbBank.SelectedValue.ToString()));
        }

        private void cmbBank_TextChanged(object sender, EventArgs e)
        {
            if (cmbBank.Text == "") txtAccno.Text = "";
        }

        private void rbWhole_CheckedChanged(object sender, EventArgs e)
        {
            loading = true;
            clearAll();
            loading = false;
        }

        private void btnBank_Click(object sender, EventArgs e)
        {
            frmBank bank = new frmBank();
            bank.ShowDialog();
            loadBanks();
        }

        private void txtProdName_TextChanged(object sender, EventArgs e)
        {
            if (loading)
                return;
            if (txtProdName.Text == "" && sale.tblCart.Rows.Count > 0)
                showCart();
            else if (dgvData.DataSource == sale.tblCart)
            {
                loadProducts();
            }
            else
                com.filterData(txtProdName.Text, Product.col_prod_name, dgvData, sale.tblProducts);
        }
        
        private void numDiscount_ValueChanged(object sender, EventArgs e)
        {
            calValues();
            if (numDiscount.Value >= sale.total || numDiscount.Value > sale.total - sale.tot_cost)
            {
                numDiscount.Value = 0;
                sale.discount = 0;
                calValues();
            }
            cusDisplay();
        }

        private void numPaid_ValueChanged(object sender, EventArgs e)
        {
             calValues();
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            if(sale.tblCart != null || sale.tblOrders != null)
                if (com.sureOption("Do you want to clear the Cart"))
                {
                    clearValues();
                    if (sale.tblCart != null)
                        sale.tblCart.Clear();
                    if (sale.tblOrders != null)
                    {
                        sale.tblOrders.Clear();
                        btnOrder.Text = "&Orders";
                    }
                    if (sale.tblRaw != null)
                        sale.tblRaw.Clear();
                }
            loadProducts();
            calValues();
            clearValues();
            cusDisplay();
            if (Custom.client_id_active == 6)
                clearLabour();
            if (btnDeliver.Enabled)
                clearDeliver();
        }
        
        private void dgvData_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (!dgvData.Columns["Remove"].Visible)
                return;
            if (dgvData.Columns[e.ColumnIndex].Name == Product.col_qty || dgvData.Columns[e.ColumnIndex].Name == Product.col_price)
            {
                calValues();
                cusDisplay();
            }
        }
        
        private void txtProdCode_MouseUp(object sender, MouseEventArgs e)
        {
            txtProdCode.Text = "";
        }

        private void cmbClient_Leave(object sender, EventArgs e)
        {
            if (cmbClient.Text == "")
                cmbClient.SelectedIndex = -1;
        }

        private void cmbBank_Leave(object sender, EventArgs e)
        {
            if (cmbBank.Text == "")
            {
                cmbBank.SelectedIndex = -1;
                lblPaid.Text = "Paid as Cash";
            }
            else
            {
                lblPaid.Text = "Paid to Bank";
            }
        }

        private void cmbClient_TextChanged(object sender, EventArgs e)
        {
            if (cmbClient.Text == "")
                cmbClient.SelectedIndex = -1;
        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            frmSaleReview review = new frmSaleReview();
            review.ShowDialog();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
//            frmOdr.from_sale = true;
            frmOdr.ShowDialog();
            sale.tblOrders = frmOdr.odr.tblCart;
            if (sale.tblOrders != null)
            {
                btnOrder.Text = "&Orders(" + sale.tblOrders.Rows.Count + ")";
            }
            else
                btnOrder.Text = "&Orders";
            calValues();
        }

        private void cmbClient_SelectedValueChanged(object sender, EventArgs e)
        {
            if (loading || cmbClient.SelectedValue == null)
                return;
            if (Convert.ToInt64(cmbClient.SelectedValue.ToString()) < 0)
                return;
            sale.cus_id = Convert.ToInt64(cmbClient.SelectedValue.ToString());

            if (Custom.mod_manufact || Custom.mod_bakers)
            {
                frmDeliver.indexChanged = true;
                frmDeliver.cusId = sale.cus_id;
                showDelivery();
            }
            numClientBal.Value = Convert.ToInt64(tblCus.Rows[cmbClient.SelectedIndex][Customer.col_balance]);
            calValues();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            frmProducts frmProd = new frmProducts();
            frmProd.ShowDialog();
            loadProducts();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            frmCustomer frmCus = new frmCustomer();
            frmCus.ShowDialog();
            loadCustomers();
        }

        private void txtProdCode_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                string tmpCode = txtProdCode.Text;
                if (tmpCode.Equals(""))
                    return;
                com.filterDataParity(tmpCode, Product.col_code, dgvData, sale.tblProducts);

                bool b = itemExists(0);
                if (b)            //adds quantity if item already exists in cart
                    return;
                if (dgvData.RowCount == 1)
                    addToCart(dgvData.Rows[0]);
                calValues();

                txtProdName.Text = "";
                txtProdCode.Text = "";
                txtProdCode.Focus();
                cusDisplay();
            }
            else if(e.KeyCode == Keys.Q && dgvData.DataSource == sale.tblCart)
            {
                dgvData.CurrentCell = dgvData.Rows[0].Cells[Sale.col_qty];
                dgvData.BeginEdit(true);
            }
        }

        private void btnAddIMEI_Click(object sender, EventArgs e)
        {
            showImei();
        }

        private void btnDeliver_Click(object sender, EventArgs e)
        {
            showDelivery();
            calValues();
        }

        public void cusDisplay()
        {
            if (Custom.client_id_active != 2)
                return;
            if (!portCusDisplay.IsOpen)
                return;
        portCusDisplay.Open();
            portCusDisplay.WriteLine((char)13 + "    Bill Total    ");
            ////portCusDisplay.WriteLine((char)13 + "    PKR." +(numBillTotal.Value - numDiscount.Value) + ".00        ");
            portCusDisplay.Close();
        }

        public void clearDisplay()
        {
      /*      portCusDisplay.Open();
            portCusDisplay.WriteLine((char)12 + "");
            portCusDisplay.Close();*/
        }

        #endregion

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            DataGridViewRow row = dgvData.Rows[e.RowIndex];
            if (dgvData.Columns["Remove"].Visible)
            {
                if (e.ColumnIndex == 0)
                {
                    dgvData.Rows.RemoveAt(e.RowIndex);
                    com.delRows(obji.objImei.tblTempTable, Product.col_prod_id, obji.prod_id);
                    calValues();
                }
            }
            else
            {
                if (itemExists(e.RowIndex))    //adds quantity if item already exists in cart
                    return;
                addToCart(row);
                calValues();
            }
            cusDisplay();
        }

        private void dgvData_KeyPress(object sender, KeyPressEventArgs e)
        {
            Common.isNumeric(e);
        }

        private void btnServ_Click(object sender, EventArgs e)
        {
            showServ();
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbVeh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbEmp_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbVeh_SelectedValueChanged(object sender, EventArgs e)
        {
            loading = true;
            if (Custom.client_id_active == 7)
            {
                if (com.chkCombo(cmbVeh))
                    prod.term_id = Convert.ToInt32(tblVeh.Rows[cmbVeh.SelectedIndex][Distribute.col_trem_id]);
                else
                    prod.term_id = Constants.term_store;
            }
            clearAll();
            loading = false;
        }

        private void cmbVeh_TextChanged(object sender, EventArgs e)
        {
            if (cmbVeh.Text == "" && Custom.client_id_active == 7)
            {
                prod.term_id = Constants.term_store;
                clearAll();
            }
        }

        private void numPaid_Enter(object sender, EventArgs e)
        {
            numPaid.Select();
        }

        private void numDiscount_Enter(object sender, EventArgs e)
        {
            numDiscount.Select();
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            frmPurchase pur = new frmPurchase();
            pur.ShowDialog();
            loadProducts();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txtAccno_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}