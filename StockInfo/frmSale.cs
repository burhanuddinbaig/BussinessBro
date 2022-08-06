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
using prjGrow.Users;

namespace prjGrow.StockInfo
{
    public partial class frmSale : frmBaseSalePur
    {
        public frmSale()
        {
            InitializeComponent();
        }

        Common com = new Common();
        Sale sale = new Sale();
        Product prod = new Product();
        Bank bnk = new Bank();
        Customer cus = new Customer();
        Vehicle veh = new Vehicle();
        Orders odr = new Orders();

        DataTable tblCus = null;
        DataTable tblLabour = new DataTable();
        DataTable tblVeh = new DataTable();
        DataTable tblBill = new DataTable();
        frmOrders frmOdr = new frmOrders();
        clsDb db = new clsDb();
        Employee emp = new Employee();

        int tmrCount = 0;

        public frmLabour frmLab = new frmLabour();
        public frmDelivery frmDeliver = new frmDelivery();
        frmIMEI obji = new frmIMEI();
        bool loading = false;
        bool is_service = false;
        bool is_bakery = false;     //to less stock bakers if purchased entry not pushed yet

        bool removed = false;
        bool isOrder = false;

        #region functions
        public void createCart()
        {
            sale.tblCart = new DataTable();
            sale.tblCart.Columns.Add(Sale.col_sno, typeof(short));
            sale.tblCart.Columns.Add(Product.col_prod_id, typeof(long));
            sale.tblCart.Columns.Add(Product.col_code, typeof(string));
            sale.tblCart.Columns.Add(Product.col_prod_name, typeof(string));
            sale.tblCart.Columns.Add(Product.col_cost, typeof(double));
            sale.tblCart.Columns.Add(Product.col_price, typeof(double));
            sale.tblCart.Columns.Add(Product.col_flip_price, typeof(double));
            if(Custom.client_id_active == 5)
                sale.tblCart.Columns.Add(Product.col_real_price, typeof(double));
            sale.tblCart.Columns.Add(Product.col_qty, typeof(float));
            sale.tblCart.Columns.Add(Sale.col_item_dist, typeof(float));
            sale.tblCart.Columns.Add(Product.col_amount, typeof(float));
            sale.tblCart.Columns.Add(Product.col_stock, typeof(float));
            sale.tblCart.Columns.Add(Product.col_cate, typeof(short));
            sale.tblCart.Columns.Add(Product.col_frieght, typeof(float));
            if (Sale.mod_manufact || Sale.mod_bakers)
            {
                sale.tblCart.Columns.Add(Sale.col_order_no, typeof(long));
                sale.tblCart.Columns.Add(Product.col_unit, typeof(string));
            }
        }

        void focusProd()
        {
            if (Custom.fet_bcode)
                txtProdCode.Focus();
            else
                txtProdName.Focus();
        }

        void formatfrm()
        {
            numDiscount.BackColor = Color.White;
            numBillTotal.BackColor = Color.White;
            numAmt.BackColor = Color.White;
            numBal.BackColor = Color.White;
            numCredit.BackColor = Color.White;
            numChange.BackColor = Color.White;
        }

        void formatGrid()
        {
            dgvData.ReadOnly = false;
            if (!loading)
            {
                dgvData.Columns[Product.col_code].ReadOnly = true;
                dgvData.Columns[Product.col_prod_name].ReadOnly = true;
                dgvData.Columns[Product.col_amount].ReadOnly = true;
            }

            if (dgvData.Rows.Count > 0)
            {
                dgvData.Columns[Product.col_code].FillWeight = 100;
                dgvData.Columns[Product.col_prod_name].FillWeight = 180;
                dgvData.Columns[Product.col_qty].FillWeight = 50;
                
                if(Custom.mod_bakers || Custom.mod_manufact)
                    dgvData.Columns[Product.col_unit].FillWeight = 50;
                dgvData.Columns[Product.col_price].FillWeight = 60;
                dgvData.Columns[Sale.col_item_dist].FillWeight = 60;
                dgvData.Columns[Product.col_amount].FillWeight = 80;
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
            else if (Custom.client_id_active == Constants.CLT_ALKARIM)
            {
                if (!isOrder)
                    prod.cateBakery = prod.cateStk = prod.cateServ = prod.allCate = prod.multiCate = true;
                else
                {
                    prod.allCate = prod.multiCate = false;                 //To Load Just Bakery Items For Orders
                    prod.category = Constants.cate_cake;
                }
            }
            else if (Custom.mod_mobile)
                prod.cateStk = prod.cateMobile = prod.multiCate = true;

            sale.tblProducts = prod.getProducts(true);
            dgvData.DataSource = sale.tblProducts;

            if (rbRetail.Checked)
            {
                com.hideColumns(dgvData, new string[] { Product.col_prod_id, Product.col_cost, Sale.col_frieght, Product.col_whole, Product.col_cate, Product.col_min_stock, "Remove" });
                com.showColumns(dgvData, new string[] { Product.col_retail, Product.col_stock });
            }
            else if (rbWhole.Checked)
            {
                com.hideColumns(dgvData, new string[] { Product.col_prod_id, Product.col_cost, Sale.col_frieght, Product.col_retail, Product.col_cate, Product.col_min_stock, "Remove" });
                com.showColumns(dgvData, new string[] { Product.col_whole, Product.col_stock });
            }

            if (Custom.client_id_active == 5 || Custom.client_id_active == 3)
                com.hideColumns(dgvData, new string[] { Product.col_unit });
            if (Custom.client_id_active == 2)
                com.enableColumns(dgvData, new string[] { Product.col_stock }, User.curAuth == Constants.auth_admin);
        }

        void showProducts()
        {
            dgvData.DataSource = sale.tblProducts;

            if (rbRetail.Checked)
            {
                com.hideColumns(dgvData, new string[] { Product.col_prod_id, Product.col_cost, Sale.col_frieght, Product.col_whole, Product.col_cate, Product.col_min_stock, "Remove" });
                com.showColumns(dgvData, new string[] { Product.col_retail, Product.col_stock });
            }
            else if (rbWhole.Checked)
            {
                com.hideColumns(dgvData, new string[] { Product.col_prod_id, Product.col_cost, Sale.col_frieght, Product.col_retail, Product.col_cate, Product.col_min_stock, "Remove" });
                com.showColumns(dgvData, new string[] { Product.col_whole, Product.col_stock });
            }

            if (Custom.client_id_active == 5 || Custom.client_id_active == 3)
                com.hideColumns(dgvData, new string[] { Product.col_unit });
            if (Custom.client_id_active == 2)
                com.enableColumns(dgvData, new string[] { Product.col_stock }, User.curAuth == Constants.auth_admin);
        }

        void loadBanks()
        {
            com.loadCombo(cmbBnk, bnk.getBanks(), Bank.col_bank, Bank.col_id);
        }

        void loadCustomers()
        {
            tblCus = cus.getCustomers();
            com.loadCombo(cmbCus, tblCus, Customer.col_name, Customer.col_id);
            com.loadCombo(cmbCellNo, tblCus, Customer.col_contact, Customer.col_id); 
        }

        void loadBillno()
        {
            numInvoiceno.Value = db.getNextId("Sale");
        }

        void showCart()
        {
            dgvData.DataSource = sale.tblCart;
            com.hideColumns(dgvData, new string[] { "id", Product.col_cost, Product.col_real_price, Product.col_stock, Sale.col_order_no, Sale.col_sno, Product.col_flip_price });
            com.showColumns(dgvData, new string[] { "Remove" });
            com.enableColumns(dgvData, new string[] { Sale.col_item_dist }, Custom.fet_item_dist);
            com.enableColumns(dgvData, new string[] { Sale.col_prod_code }, Custom.fet_bcode);
            
            if(Custom.client_id_active == 2)
                com.enableColumns(dgvData, new string[] { Sale.col_prod_code }, User.curAuth == 2);

            formatGrid();
        }

        void clearValues()
        {
            sale.total = 0;
            sale.discount = 0;
            sale.paid = 0;

            numBillTotal.Value = 0;
            numDiscount.Value = 0;
            numPaid.Value = 0;
            numAmt.Value = 0;
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

        void stopTmr()
        {
            tmr.Stop();
            tmrCount = 0;
        }

        void clearAll()
        {
            if(sale.tblCart != null)sale.tblCart.Clear();
            if (sale.tblOrders != null) sale.tblOrders.Clear();
            if (sale.tblIMEI != null) sale.tblIMEI.Clear();
            com.clearControls(new Control[]{cmbBnk, cmbCus, txtAccno, txtProdCode, txtProdName, txtReference});
            clearValues();
            loadProducts();
            showCart();
            loadCustomers();
            loadBillno();
            cusDisplay();
            if(Custom.client_id_active == 6)
                clearLabour();
            if (btnDeliver.Enabled)
                clearDeliver();
            focusProd();

            btnSave.Text = Constants.btn_save;
        }

        void getData()
        {
            sale.date = dtpDate.Value;
            sale.reference = txtReference.Text;
            sale.paid_cash = Convert.ToInt64(numPaid.Value);

            if (com.chkCombo(cmbCus))
                sale.cus_id = Convert.ToInt64(cmbCus.SelectedValue);
            else
                sale.cus_id = 0;

            if (com.chkCombo(cmbBnk))
                sale.bank_id = Convert.ToInt64(cmbBnk.SelectedValue);
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
                    sale.adv += Convert.ToInt64(sale.tblOrders.Compute("Sum(" + Sale.col_advance + ")", ""));
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
            sale.narration = "Sale: " + cmbCus.Text + " " + txtReference.Text;
        }

        void getOrderData()
        {
            odr.cus_id = Convert.ToInt64(cmbCus.SelectedValue.ToString());
//            odr.cus_id = odr.cus_id > 0 ? odr.cus_id : 0;
            odr.date = dtpDate.Value;
            odr.target = dtpTimelineDate.Value;
            odr.targetTime = dtpTimelineTime.Value;
            
            odr.total = sale.total;
            odr.discount = sale.discount;
            odr.amount = odr.total - odr.discount;
            odr.adv = odr.paid > odr.amount ? odr.amount : sale.paid;
            odr.remain = odr.total - odr.adv - odr.discount;
            odr.cus.cus_id = odr.cus_id;
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
                float tmpQty = 0, tmpPrice = 0, tmpCost = 0, tmpDist = 0, tmpFrt = 0;

                for (int i = 0; i < sale.tblCart.Rows.Count; i++)
                {
                    tmpPrice = tmpQty = tmpCost = tmpDist = tmpFrt = 0;
                    if (!string.IsNullOrWhiteSpace(sale.tblCart.Rows[i][Product.col_qty].ToString()))
                        tmpQty = (float)Convert.ToDouble(sale.tblCart.Rows[i][Product.col_qty].ToString());

                    if(!string.IsNullOrWhiteSpace(sale.tblCart.Rows[i][Product.col_price].ToString()))
                        tmpPrice = (float)Convert.ToDouble(sale.tblCart.Rows[i][Product.col_price].ToString());

                    if (!string.IsNullOrWhiteSpace(sale.tblCart.Rows[i][Sale.col_item_dist].ToString()))
                        tmpDist = (float)Convert.ToDouble(sale.tblCart.Rows[i][Sale.col_item_dist].ToString());

                    if (!string.IsNullOrWhiteSpace(sale.tblCart.Rows[i][Sale.col_frieght].ToString()))
                        tmpFrt = (float)Convert.ToDouble(sale.tblCart.Rows[i][Sale.col_frieght].ToString());

                    if (!string.IsNullOrWhiteSpace(sale.tblCart.Rows[i][Product.col_cost].ToString()))
                    {
                        tmpCost = (float)Convert.ToDouble(sale.tblCart.Rows[i][Product.col_cost].ToString());
                        tmpCost += tmpFrt;
                        if (((tmpPrice * tmpQty) - tmpDist <= (tmpCost * tmpQty)) && !(Custom.client_id_active == 7))
                        {
                            tmpDist = 0;
                            sale.tblCart.Rows[i][Product.col_price] = Math.Round(tmpPrice, 2);
                            sale.tblCart.Rows[i][Sale.col_item_dist] = 0;
                        //    tmpPrice = tmpCost;
                        }
                    }
                    sale.tblCart.Rows[i][Product.col_amount] = Custom.fet_item_dist ? ((tmpQty * tmpPrice) - tmpDist) : tmpQty * tmpPrice;
                    float tmpStock = (float)Convert.ToDouble(sale.tblCart.Rows[i][Product.col_stock].ToString());

                    if (Custom.client_id_active == 5 || Custom.client_id_active == 6 || Custom.client_id_active == 2)
                    {
                        is_service = Convert.ToInt16(sale.tblCart.Rows[i][Product.col_cate].ToString()) == Constants.cate_service;
                        is_bakery = Convert.ToInt16(sale.tblCart.Rows[i][Product.col_cate].ToString()) == Constants.cate_cake;
                    }
                    if (tmpQty > tmpStock && !is_service && !(Custom.client_id_active == 2 && is_bakery))//check whether item quantity exeeds stock
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
            if (Custom.fet_item_dist && sale.tblCart.Rows.Count > 0)
            {
                sale.discount = Convert.ToInt32(sale.tblCart.Compute("Sum(" + Sale.col_item_dist + ")", ""));
                sale.total += sale.discount;                    //to add discount to total
                numDiscount.Value = sale.discount;
            }
            else
                sale.discount = Convert.ToInt32(numDiscount.Value) < Convert.ToInt64(numBillTotal.Value) ? Convert.ToInt32(numDiscount.Value) : 0;

            sale.amount = sale.total - sale.discount;
            numAmt.Value = sale.amount >= 0 ? sale.amount: 0;
            sale.paid = sale.amount - Convert.ToInt32(numPaid.Value) <= 0 ? sale.amount : Convert.ToInt32(numPaid.Value);

            loading = true; 
            numBillTotal.Value = sale.total;
            loading = false;

            if (cmbCus.SelectedIndex >= 0)
            {
                numCredit.Value = (sale.amount - sale.paid) > 0 ? (sale.amount - sale.paid) : 0;
            }
            else
            {
                numCredit.Value = 0;
                loading = true;
                numPaid.Value = sale.paid < sale.amount || removed ? sale.amount : numPaid.Value;
                removed = false;
                loading = false;
            }

            if (numCredit.Value <= 0)
            {
                long change = Convert.ToInt32(numPaid.Value) - sale.amount;
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

            float tmpMinStk = 0, tmpStock = 0;
            string tmpProdName = "";

            DataRow row = sale.tblCart.NewRow();
            prod.id = Convert.ToInt64(rowProd.Cells[Product.col_prod_id].Value);
            obji.prod_id = prod.id;

            row[Sale.col_sno] = sale.tblCart.Rows.Count + 1;
            row[Product.col_prod_id] = Convert.ToInt64(rowProd.Cells[Product.col_prod_id].Value);
            row[Product.col_code] = rowProd.Cells[Product.col_code].Value.ToString();
            tmpProdName = rowProd.Cells[Product.col_prod_name].Value.ToString();
            row[Product.col_prod_name] = tmpProdName;
            row[Product.col_cost] = Convert.ToDouble(rowProd.Cells[Product.col_cost].Value.ToString());
            if (rbRetail.Checked) row[Product.col_price] = Convert.ToInt64(rowProd.Cells[Product.col_retail].Value);
            else if (rbWhole.Checked) row[Product.col_price] = Convert.ToDouble(rowProd.Cells[Product.col_whole].Value);
            if (rbRetail.Checked && Custom.client_id_active == 5) row[Product.col_real_price] = Convert.ToInt64(rowProd.Cells[Product.col_retail].Value);
            else if (rbWhole.Checked && Custom.client_id_active == 5) row[Product.col_real_price] = Convert.ToDouble(rowProd.Cells[Product.col_whole].Value);
            if (rbRetail.Checked) row[Product.col_flip_price] = Convert.ToInt64(rowProd.Cells[Product.col_whole].Value);
            else if (rbWhole.Checked) row[Product.col_flip_price] = Convert.ToInt64(rowProd.Cells[Product.col_retail].Value);
            row[Product.col_qty] = 1;
            row[Product.col_amount] = Convert.ToDouble(row[Product.col_qty].ToString()) * Convert.ToDouble(row[Product.col_price].ToString());
            tmpStock = (float)Convert.ToDouble(rowProd.Cells[Product.col_stock].Value.ToString());
            tmpMinStk = (float)Convert.ToDouble(rowProd.Cells[Product.col_min_stock].Value.ToString());
            row[Product.col_stock] = tmpStock;
            if (Custom.mod_manufact || Custom.mod_bakers)
                row[Product.col_unit] = rowProd.Cells[Product.col_unit].Value.ToString();
            if(Custom.fet_item_dist)
                row[Sale.col_item_dist] = 0;
            if (Custom.fet_freight)
                row[Sale.col_frieght] = (float)Convert.ToDouble(rowProd.Cells[Product.col_frieght].Value);
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
            if (tmpStock < tmpMinStk)
            {
                com.showMessage(tmpProdName + " is getting Low", lblMsg, Constants.message_info, tmrMsg);
            }

            sale.tblCart.Rows.Add(row);
            
            bool ismobile = Custom.mod_mobile ? Convert.ToInt16(rowProd.Cells[Product.col_cate].Value) == Constants.cate_mobile : false;
            if (Sale.mod_mobile && ismobile)
            {
                btnAddIMEI.Enabled = ismobile;
            }
            else btnAddIMEI.Enabled = ismobile;
            showCart();

            dgvData.Sort(dgvData.Columns[Sale.col_sno], ListSortDirection.Descending);
            if(Custom.client_id_active == 6)
                dgvData.Rows[0].Selected = true;

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
            //btnPurchase.Visible = Custom.client_id_active == 2;
            if (Custom.mod_manufact) this.Text = lblTitle.Text = "Sale and Delivery";
            if (Custom.client_id_active == 2)
            {
                btnSp1.Text = "Bag sm.";
                btnSp2.Text = "Bag lg.";
                btnSp1.Visible = btnSp2.Visible = true;     ////the quick brown fox jumps over lazy dog the quick brown fox jumps
            }
            btnOrder.Visible = Custom.client_id_active == 2 || (Custom.mod_manufact && !(Custom.client_id_active == 7));
            rbWhole.Checked = Custom.client_id_active == 7;
            btnServ.Visible = Custom.client_id_active == 6 || Custom.client_id_active == 1;
            btnSupOrder.Visible = Custom.client_id_active == 6;
            if (Custom.client_id_active == 6)
                pnlTots.SendToBack();
            pnlEmp.Visible = Custom.client_id_active == 5;
            pnlVeh.Visible = Custom.client_id_active == 7;
            if (Custom.fet_item_dist)
            {
                numDiscount.Enabled = false;
                lblDiscount.Text = "Discount Total";
            }
            pnlCell.Visible = Custom.client_id_active == 6;
            loading = true;
        }

        void secure()
        {
            if(Custom.client_id_active == 3)
                btnReiew.Enabled = User.curAuth == 1 || User.curAuth == 2;
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

        void addProdtoCart(string prodCode)         //for special type of Products
        {
            com.filterData(prodCode, Product.col_code, dgvData, sale.tblProducts);
            if (itemExists(0))
                return;
            if (dgvData.Rows.Count > 0)
                addToCart(dgvData.Rows[0]);
            calValues();
        }

        void resize()
        {
            Size siz = SystemInformation.VirtualScreen.Size;
            if (siz.Height == 768 && siz.Width == 1024)
            {
                Font = new Font("Rockwell Condensed", 16);
                this.Width = 1000;
                lblProdCode.Text = "Code";
                lblProdName.Text = "Product";
                rbWhole.Text = "Whole";
                rbWhole.Location = new Point(rbWhole.Location.X + 20, rbWhole.Location.Y);
                chkBill.Text = "Bill Print";
            }
        }

        void flipPrice(int rowIndex)                               ///to flip price from whole to retail
        {
            long tmpFlipPrice = 0;
            tmpFlipPrice = Convert.ToInt64(sale.tblCart.Rows[rowIndex][Product.col_flip_price]);
            sale.tblCart.Rows[rowIndex][Product.col_flip_price] = Convert.ToInt64(sale.tblCart.Rows[rowIndex][Product.col_price]);
            sale.tblCart.Rows[rowIndex][Product.col_price] = tmpFlipPrice;

            calValues();
        }

        void flipOrder()            //to activate/deactivate orders
        {
            loading = true;
            isOrder = chkOrder.Checked;
            clearAll();
            chkBill.Checked = isOrder;
            lblPaid.Text = isOrder ? "Advance on Order:" : "Paid as Cash:";
            pnlTimeline.Visible = pnlDescrip.Visible = isOrder;
            loading = false;
        }

        void loadOrderCount()
        {
            short tmp = (short)odr.getCurOrders();
            btnOrder.Text = "Orders(" + tmp + ")";
        }

        bool saveCus()
        {
            if (cmbCus.SelectedIndex < 0 && cmbCus.Text.Length > 0)
            {
                cus.contact = (cmbCell.SelectedIndex < 0) ? cmbCell.Text : "";  //Assigns cell no to cell.contact if new cell no typed else empty
                cus.name = cmbCus.Text;
                cus.saveCustomer();
                if (cus.result)
                    sale.cus_id = odr.cus_id = db.getLastId("Customer");
                if (!cus.result)
                    com.showMessage(cus.msg, lblMsg, cus.msg_type, tmrMsg);
                return cus.result;
            }
            return true;
        }

        void saveSale()
        {
            calValues();
            getData();
            if (!saveCus())
                return;
            if (sale.saveSale())
            {
                stopTmr();
                if (chkBill.Checked)
                    sale.printBill();
                loading = true;
                clearAll();
                loading = false;
            }
            com.showMessage(sale.msg, lblMsg, sale.msg_type, tmrMsg);
        }

        void saveOrder()
        {
            calValues();
            getOrderData();
            saveCus();
            odr.saveOrder();
            if (odr.result)
            {
                stopTmr();
                if (chkBill.Checked)
                    odr.printReciept();
                loading = true;
                clearAll();
                loading = false;
            }
            com.showMessage(odr.msg, lblMsg, odr.msg_type, tmrMsg);
        }

        public void cusDisplay()
        {
            if (Custom.client_id_active != 2)
                return;
            if (!portCusDisplay.IsOpen)
                return;
            portCusDisplay.Open();
            portCusDisplay.WriteLine((char)13 + "    Bill Total    ");
            portCusDisplay.WriteLine((char)13 + "    PKR." + (numBillTotal.Value - numDiscount.Value) + ".00        ");
            portCusDisplay.Close();
        }

        public void clearDisplay()
        {

        }

        #endregion

        #region events

        private void frmSale_Load(object sender, EventArgs e)
        {
            loading = true;
            com.loadFormInfo(this, dgvData, "Sale Corner", lblClient, lblTitle);
            customize();
            secure();
            loadCustomers();
            loadProducts();
            createCart();
            showCart();
            loadBanks();
            loadBillno();
            if (Custom.client_id_active == 5)
                loadEmp();
            else if (Custom.client_id_active == 7)
                loadVeh();
            else if (Custom.client_id_active == 2)
                loadOrderCount();

            resize();
//            clearDisplay();
            formatfrm();
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
                focusProd();
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
                    calValues();

                    txtProdName.Text = "";
                    txtProdCode.Text = "";
                    focusProd();
                    if(Custom.client_id_active == 6)
                        dgvData.Rows[sale.tblCart.Rows.Count - i - 1].Selected = true;

                    cusDisplay();
                    return true;
                }
            }
            return false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            isOrder = chkOrder.Checked;
            if (btnSave.Text == Constants.btn_cnc)
            {
                tmr.Stop();
                btnSave.Text = Constants.btn_save;
            }
            else if (btnSave.Text == Constants.btn_save && Custom.client_id_active == 6)
            {
                calValues();
                btnSave.Text = Constants.btn_cnc;
                tmrCount = 0;
                tmr.Start();
            }
            else if (btnSave.Text == Constants.btn_save)
            {
                if (isOrder)
                    saveOrder();
                else
                    saveSale();
            }
        }

        private void rbWhole_CheckedChanged(object sender, EventArgs e)
        {
            loading = true;
            clearAll();
            loading = false;
        }

        private void btnBank_Click(object sender, EventArgs e)
        {
            
        }

        private void txtProdName_TextChanged(object sender, EventArgs e)
        {
            if (loading)
                return;
            string str = txtProdName.Text;
            if (str.Length == 1)
                return;
            if (str == "")// && sale.tblCart.Rows.Count > 0
                showCart();
            else if (dgvData.DataSource == sale.tblCart && str.Length > 1)
            {
                showProducts();
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
            showCart();
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
            if (dgvData.Columns[e.ColumnIndex].Name == Product.col_qty || dgvData.Columns[e.ColumnIndex].Name == Product.col_price || dgvData.Columns[e.ColumnIndex].Name == Sale.col_item_dist)
            {
                removed = true;
                calValues();
                removed = false;
                cusDisplay();
            }
        }

        private void txtProdCode_MouseUp(object sender, MouseEventArgs e)
        {
            txtProdCode.Text = "";
        }

        //private void cmbCus_Leave(object sender, EventArgs e)
        //{
        //    if (cmbCus.Text == "")
        //        cmbCus.SelectedIndex = -1;
        //}

        private void btnReview_Click(object sender, EventArgs e)
        {
            frmSaleReview review = new frmSaleReview();
            review.ShowDialog();
            loadProducts();
            showCart();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            //frmOdr.from_sale = true;
            //frmOdr.ShowDialog();
            frmProgress prog = new frmProgress();
            prog.ShowDialog();
            loadOrderCount();
            //sale.tblOrders = frmOdr.odr.tblCart;
            //if (sale.tblOrders != null)
            //{
            //    btnOrder.Text = "&Orders(" + sale.tblOrders.Rows.Count + ")";
            //}
            //else
            //    btnOrder.Text = "&Orders";
            //calValues();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            frmProducts frmProd = new frmProducts();
            frmProd.ShowDialog();
            loadProducts();
            showProducts();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            
        }

        private void txtProdCode_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                string tmpCode = txtProdCode.Text;
                if (tmpCode.Equals(""))
                {
                    if(sale.tblCart.Rows.Count > 0)
                        btnSave_Click(sender,e);
                    return;
                }
                com.filterDataParity(tmpCode, Product.col_code, dgvData, sale.tblProducts);

                bool b = itemExists(0);
                if (b)            //adds quantity if item already exists in cart
                    return;
                if (dgvData.RowCount == 1)
                    addToCart(dgvData.Rows[0]);
                calValues();

                txtProdName.Text = "";
                txtProdCode.Text = "";
                focusProd();
                cusDisplay();
            }
            else if(e.KeyCode == Keys.Q && dgvData.DataSource == sale.tblCart)
            {
                dgvData.CurrentCell = dgvData.Rows[0].Cells[Sale.col_qty];
                dgvData.BeginEdit(true);
            }
            else if (e.KeyCode == Keys.Delete && dgvData.DataSource == sale.tblCart)
            {
                dgvData.Rows.RemoveAt(0);
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

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            DataGridViewRow row = dgvData.Rows[e.RowIndex];
            string operation = dgvData.Columns[e.ColumnIndex].Name;

            if (dgvData.Columns["Remove"].Visible)
            {
                if (e.ColumnIndex == 0)
                {
                    dgvData.Rows.RemoveAt(e.RowIndex);
                    removed = true;
                    com.delRows(obji.objImei.tblTempTable, Product.col_prod_id, obji.prod_id);
                    calValues();
                    focusProd();
                }
                else if (operation == Product.col_prod_name && Custom.client_id_active == 6)
                {
                    float tmpCost = Convert.ToInt64(row.Cells[Product.col_cost].Value) + Convert.ToInt64(row.Cells[Product.col_frieght].Value);
                    lblCp.Text = "C.P: " + tmpCost.ToString();
                    lblCp.Text += " , Qty: " + sale.tblCart.Rows[e.RowIndex][Product.col_stock].ToString();
                    lblCp.Visible = true;
                    tmr.Start();
                }
            }
            else
            {
                if (itemExists(e.RowIndex))    //adds quantity if item already exists in cart
                    return;
                addToCart(row);
                calValues();
                focusProd();
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
            numPaid.Select(0, numPaid.Value.ToString().Length);
        }

        private void numDiscount_Enter(object sender, EventArgs e)
        {
            numDiscount.Select(0, numDiscount.Value.ToString().Length);
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            frmPurchase pur = new frmPurchase();
            pur.ShowDialog();
            loadProducts();
        }

        private void btnSp1_Click(object sender, EventArgs e)
        {
            addProdtoCart(Constants.code_bag_sm);
        }

        private void btnSp2_Click(object sender, EventArgs e)
        {
            addProdtoCart(Constants.code_bag_lg);
        }

        private void txtProdName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtProdName.Text.Length < 6)    //to prevent from envoking if prod code scaned in prod name mistakenly
                {
                    btnSave_Click(sender, e);
                    return;
                }
            }
        }

        private void lblCp_Click(object sender, EventArgs e)
        {
            lblCp.Hide();
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            if (btnSave.Text == "Ca&ncel" && tmrCount >= 1)
            {
                numPaid.Enabled = false;
                saveSale();
                numPaid.Enabled = true;
                tmr.Stop();
            }
            else if (tmrCount >= 3 && lblCp.Visible)
            {
                lblCp.Hide();
                tmrCount = 0;
                tmr.Stop();
            }
            tmrCount++;
        }

        private void btnSave_Leave(object sender, EventArgs e)
        {
            txtProdName.Focus();
        }

        private void btnSwitchUser_Click(object sender, EventArgs e)
        {
            if (sale.tblCart.Rows.Count > 0)
                return;
            string tmpStr = "";
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                tmpStr = Application.OpenForms[i].Name;
                if (tmpStr != "frmDashboard" &&  tmpStr != "frmSale")
                    Application.OpenForms[i].Close();
            }
            Sale.toSwitch = true;
            frmlogin log = new frmlogin();
            log.ShowDialog();
            this.Close();
        }

        private void btnSupOrder_Click(object sender, EventArgs e)
        {
            frmSupplierOrders supOdr = new frmSupplierOrders();
            supOdr.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sale.tran_id > 0)
                sale.printBill();
        }

        private void chkBill_CheckedChanged(object sender, EventArgs e)
        {
            //if (chkBill.Checked)
            //    chkBill.BackColor = Color.Olive;
            //else
            //    chkBill.BackColor = Color.Transparent;
        }

        private void dgvData_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if (e.ColumnIndex < 0 || e.RowIndex < 0)
                return;

            if (dgvData.Columns[e.ColumnIndex].Name == Product.col_price && dgvData.Columns["Remove"].Visible && dgvData.Rows.Count > 0)
                flipPrice(sale.tblCart.Rows.Count - e.RowIndex - 1);
        }

        private void chkOrder_CheckedChanged(object sender, EventArgs e)
        {
            flipOrder();
        }

        private void cmbCellNo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCus_Click(object sender, EventArgs e)
        {
            frmCustomer frmCus = new frmCustomer();
            frmCus.close_on_save = true;
            frmCus.ShowDialog();
            loadCustomers();
        }

        private void btnBnk_Click(object sender, EventArgs e)
        {
            frmBank bank = new frmBank();
            bank.ShowDialog();
            loadBanks();
        }

        private void cmbCus_Leave(object sender, EventArgs e)
        {
            if (cmbCus.Text == "")
                cmbCus.SelectedIndex = -1;
        }

        private void cmbBnk_Leave(object sender, EventArgs e)
        {
            if (cmbBnk.Text == "")
            {
                cmbBnk.SelectedIndex = -1;
                lblPaid.Text = "Paid as Cash";
            }
            else
            {
                lblPaid.Text = "Paid to Bank";
            }
        }

        private void cmbCus_TextChanged(object sender, EventArgs e)
        {
            if (cmbCus.Text == "")
            {
                numBal.Value = 0;
                cmbCus.SelectedIndex = -1;
            }
        }

        private void cmbCus_SelectedValueChanged(object sender, EventArgs e)
        {
            if (loading || cmbCus.SelectedValue == null)
                return;
            if (Convert.ToInt64(cmbCus.SelectedValue.ToString()) < 0)
                return;
            sale.cus_id = Convert.ToInt64(cmbCus.SelectedValue.ToString());

            if (Custom.mod_manufact || Custom.mod_bakers)
            {
                frmDeliver.indexChanged = true;
                frmDeliver.cusId = sale.cus_id;
                showDelivery();
            }
            if (Custom.mod_bakers && cmbCus.SelectedIndex >= 0 && numBillTotal.Value == numPaid.Value)
            {
                numPaid.Value = 0;
            }
            numBal.Value = Convert.ToInt64(tblCus.Rows[cmbCus.SelectedIndex][Customer.col_balance]);
            calValues();
        }

        private void txtDescrip_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtProdName.Text.Length < 6)    //to prevent from envoking if prod code scaned in prod name mistakenly
                {
                    btnSave_Click(sender, e);
                    return;
                }
            }
        }

        #endregion
    }
}