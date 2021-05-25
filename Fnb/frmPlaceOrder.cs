using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using prjGrow.StockInfo;
using prjGrow.Classes;
using prjGrow.General;
using prjGrow.Manufacture;

namespace prjGrow.Fnb
{
    public partial class frmPlaceOrder : Form
    {
        public frmPlaceOrder()
        {
            InitializeComponent();
        }

        DataTable tblTbl;
        DataTable tblProd;
        DataTable tblCus;
        
        clsTable tbl = new clsTable();
        Product prod = new Product();
        Foodnb fnb = new Foodnb();
        Customer cus = new Customer();
        
        bool loading = false;
        Common com = new Common();
        int count = 0;
        bool tableFlip = false;
        int qtyDash = 0;

        public string tname = "";

        void loadTables()
        {
            tblTbl = tbl.getTables();

            Button btnTbl;
            foreach (DataRow row in tblTbl.Rows)
            {
                btnTbl = new Button();
                btnTbl.FlatStyle = FlatStyle.Flat;
                btnTbl.Width = 250;
                btnTbl.Height = 40;
                btnTbl.TabIndex = Convert.ToInt32(row[clsTable.col_id].ToString());
                btnTbl.Name = row[clsTable.col_tbl_name].ToString();
                btnTbl.Text = btnTbl.Name;

                btnTbl.Click += new EventHandler(btnTbl_Click);
                fpnlTbl.Controls.Add(btnTbl);
            }
            /*
            btnTbl = new Button();
            btnTbl.FlatStyle = FlatStyle.Flat;
            btnTbl.Width = 250;
            btnTbl.Height = 40;
            btnTbl.Name = "btnAddTable";
            btnTbl.Text = "+ Add More";
            btnTbl.Click += new EventHandler(btnAddTbl_Click);
            fpnlTbl.Controls.Add(btnTbl);
            */
            fnb.tbl_id = Convert.ToInt64(tblTbl.Rows[0][Foodnb.col_id]);
        }

        void loadDishes()
        {
            prod.cateGadget = prod.cateStk = prod.multiCate = true;
            prod.onlyAvailable = true;
            tblProd = prod.getProducts(true);
            int i = 0;

            for (int j = fpnlDish.Controls.Count-1; j >= 0; j--)
            {
                fpnlDish.Controls.RemoveAt(j);
            }
            
            Button btnDish;
            foreach (DataRow row in tblProd.Rows)
            {
                btnDish = new Button();
                btnDish.Font = new Font(FontFamily.GenericSansSerif, 16, FontStyle.Regular);
                btnDish.BackColor = i % 2 > 0 ? Color.MediumAquamarine : Color.CadetBlue;
                btnDish.FlatStyle = FlatStyle.Flat;
                btnDish.FlatAppearance.BorderSize = 2;
                btnDish.Width = 220;
                btnDish.Height = 55;
                fnb.prod_id = Convert.ToInt32(row[Product.col_prod_id].ToString());
                fnb.dish_name = row[Product.col_prod_name].ToString();
                fnb.dish_qty = Convert.ToInt32(row[Product.col_stock].ToString());
                btnDish.TabIndex = (int)fnb.prod_id;
                btnDish.Name = fnb.dish_name;
                btnDish.Text = fnb.dish_name + " (" + row[Product.col_stock].ToString() + ")";
                btnDish.Click += new EventHandler(btnDish_Click);
                fpnlDish.Controls.Add(btnDish);
                i++;
            }

            btnDish = new Button();
            btnDish.Font = new Font(FontFamily.GenericSansSerif, 16, FontStyle.Regular);
            btnDish.BackColor = i % 2 > 0 ? Color.MediumAquamarine : Color.CadetBlue;
            btnDish.FlatStyle = FlatStyle.Flat;
            btnDish.FlatAppearance.BorderSize = 2;
            btnDish.Width = 220;
            btnDish.Height = 55;
            btnDish.Name = "btnAddDish";
            btnDish.Text = "+ Add More";
            btnDish.Click += new EventHandler(btnAddDish_Click);
            fpnlDish.Controls.Add(btnDish);
            i++;
        }

        void loadCustomers()
        {
            tblCus = cus.getCustomers();
            com.loadCombo(cmbClient, tblCus, Customer.col_name, Customer.col_id);
        }

        void setValues()
        {
            numBillAmt.Value = fnb.bill_amt;
            numDist.Value = fnb.discount;
            numPaid.Value = fnb.paid;
            numBillTot.Value = fnb.bill_tot;
            numCredit.Value = fnb.remain;

            int x = com.searchTableIndex(tblTbl, Foodnb.col_id, fnb.tbl_id.ToString());
            string tmpName = tblTbl.Rows[x]["Table_"].ToString();
            if (fnb.bill_tot > 0)
                fpnlTbl.Controls[x + 1].Text = tmpName + "  PKR." + fnb.bill_tot;
            else
                fpnlTbl.Controls[x + 1].Text = tmpName;
        }
        
        void clearValues()
        {
            fnb.bill_amt = 0;
            fnb.discount = 0;
            fnb.bill_tot = 0;
            fnb.paid = 0;
            fnb.remain = 0;

            setValues();
        }

        void calValues()
        {
            if (fnb.tblCart.Rows.Count <= 0)
            {
                clearValues();
                return;
            }

            fnb.bill_tot = Convert.ToInt32(fnb.tblCart.Compute("Sum(" + Foodnb.col_amount + ")",""));
            fnb.discount = numDist.Value <= fnb.bill_tot ? Convert.ToInt32(numDist.Value) : 0;
            fnb.bill_amt = fnb.bill_tot - fnb.discount;
            fnb.paid = !com.chkCombo(cmbClient) && numPaid.Value <= fnb.bill_amt ? fnb.bill_amt : (long)numPaid.Value;

            if (com.chkCombo(cmbClient))
                fnb.remain = fnb.paid <= fnb.bill_amt ? fnb.bill_amt - fnb.paid : 0;
            else
                fnb.remain = 0;
            
            setValues();
        }

        void loadDetails()
        {
            fnb.filterCart();
            dgvOrders.DataSource = fnb.tblCart;
            com.hideColumns(dgvOrders, new string[] { Foodnb.col_prod_id, Foodnb.col_tbl_id, Foodnb.col_cost });
            com.lockColumns(dgvOrders, true, Foodnb.col_prod_name, Foodnb.col_qty, Foodnb.col_amount);
            dgvOrders.Columns[3].FillWeight = 200;
            calValues();
        }

        void updProdQty(Button btn)
        {
            fnb.prod_id = btn.TabIndex;
            DataRow row = com.searchTableRow(tblProd, Product.col_prod_id, fnb.prod_id.ToString());
            fnb.dish_name = row[Product.col_prod_name].ToString();
            object objTmp = fnb.tblCartAll.Compute("Sum(" + Stock.col_qty + ")", Foodnb.col_prod_id + " = " + fnb.prod_id + " and " + Foodnb.col_tbl_id + " <> " + fnb.tbl_id);
            objTmp = objTmp.GetType() == typeof(DBNull) ? (object)0 : objTmp;
            qtyDash = Convert.ToInt32(row[Product.col_stock]) - Convert.ToInt32(objTmp) - (int)fnb.dish_qty;
            btn.Text = fnb.dish_name + "(" + qtyDash + ")";
        }
        
        void addToBill(Button btn)
        {
            fnb.prod_id = btn.TabIndex;
            int x = com.searchTableIndex(fnb.tblCart, Product.col_prod_id, fnb.prod_id.ToString());
            DataRow row = null;
            if (x >= 0)
            {
                row = com.searchTableRow(tblProd, Foodnb.col_prod_id, fnb.prod_id.ToString());
                fnb.dish_qty = Convert.ToInt32(dgvOrders.Rows[x].Cells[Product.col_qty].Value) + 1;
                dgvOrders.Rows[x].Cells[Product.col_qty].Value = fnb.dish_qty;
                dgvOrders.Rows[x].Cells[Product.col_amount].Value = Convert.ToInt32(fnb.tblCart.Rows[x][Product.col_price]) * fnb.dish_qty;
            }
            else
            {
                row = com.searchTableRow(tblProd, Foodnb.col_prod_id, fnb.prod_id.ToString());
                fnb.prod_id = Convert.ToInt64(row[Product.col_prod_id]);
                fnb.dish_qty = 1;
                
                fnb.dish_name = row[Product.col_prod_name].ToString();
                fnb.dish_price = Convert.ToInt64(row[Product.col_retail].ToString());
                fnb.dish_cost = Convert.ToInt64(row[Product.col_cost].ToString());

                fnb.tblCart.Rows.Add(fnb.tbl_id, fnb.prod_id, fnb.dish_name, fnb.dish_qty, fnb.dish_price, fnb.dish_price * fnb.dish_qty, fnb.dish_cost);
                dgvOrders.DataSource = fnb.tblCart;
            }
            addPending();
            updProdQty(btn);
            calValues();
        }

        void clearOrder()
        {
            com.delRows(fnb.tblCartAll, Foodnb.col_tbl_id, fnb.tbl_id);
            fnb.createCart();
            clearValues();
        }

        void loadPending()
        {
            dgvPending.DataSource = fnb.tblPending;
            com.hideColumns(dgvPending, new string[] { Foodnb.col_id, Foodnb.col_prod_id, Foodnb.col_tbl_id });
        }

        void addPending()
        {
            int x = com.searchTableIndex(fnb.tblPending, Product.col_prod_id, Foodnb.col_tbl_id, fnb.prod_id.ToString(), fnb.tbl_id.ToString());
            DataRow row = null;
            if (x >= 0)
            {
                row = com.searchTableRow(tblProd, Foodnb.col_prod_id, fnb.prod_id.ToString());
                fnb.dish_qty = Convert.ToInt32(dgvPending.Rows[x].Cells[Product.col_qty].Value) + 1;
                dgvPending.Rows[x].Cells[Product.col_qty].Value = fnb.dish_qty;
            }
            else
            {
                row = com.searchTableRow(tblProd, Foodnb.col_prod_id, fnb.prod_id.ToString());
                fnb.prod_id = Convert.ToInt64(row[Product.col_prod_id]);
                fnb.dish_qty = 1;
                fnb.dish_name = row[Product.col_prod_name].ToString();
                fnb.dish_price = Convert.ToInt64(row[Product.col_retail].ToString());

                fnb.tblPending.Rows.Add(fnb.tbl_id, fnb.prod_id, fnb.tbl_name, fnb.dish_name, fnb.dish_qty);
                dgvPending.DataSource = fnb.tblPending;
            //    com.hideColumns(dgvPending, new string[] { Foodnb.col_id, Foodnb.col_prod_id, Foodnb.col_tbl_id });
            }
        }

        void delPending(long prodId)
        {
            com.delRows(fnb.tblPending, Foodnb.col_tbl_id, Foodnb.col_prod_id, fnb.tbl_id, prodId);
        }

        void getData()
        {
            fnb.cus_id = Convert.ToInt64(cmbClient.SelectedValue);
            fnb.date = DateTime.Now;

            fnb.sale.cus_id = fnb.cus_id;
            fnb.sale.date = fnb.date;
            fnb.sale.total = fnb.bill_tot;
            fnb.sale.discount = (int)fnb.discount;
            fnb.sale.paid = fnb.paid;
        }

        private void frmPlaceOrder_Load(object sender, EventArgs e)
        {
            loading = true;
            loadTables();
            loadDishes();
            loadCustomers();
            loadPending();
            fnb.tbl_id = Convert.ToInt64(tblTbl.Rows[0][Foodnb.col_id]);
            fnb.tbl_name = tblTbl.Rows[0][Foodnb.col_tbl_name].ToString();
            loadDetails();
            loading = false;
        }

        private void btnTbl_Click(object sender, EventArgs e)
        {
            if (loading)
                return;
            loading = true;
            Button btn = (Button)sender;
            lblTbl.Text = btn.Text.Split(' ')[0];
            fnb.addToCartAll();
            tableFlip = fnb.tbl_id != btn.TabIndex; /// Check Whether Clicked on Same Table or another
            if (tableFlip)
            {
                cmbClient.SelectedIndex = -1;
                numPaid.Value = numBillAmt.Value;
                tableFlip = false;
            } 
            fnb.tbl_id = btn.TabIndex;
            int x = com.searchTableIndex(tblTbl, Foodnb.col_id, fnb.tbl_id.ToString());
            fnb.tbl_name = tblTbl.Rows[x][Foodnb.col_tbl_name].ToString();
            clearValues();
            loadDetails();
            loading = false;
        }

        private void btnDish_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Text.Contains("(0)"))
                return;
            addToBill(btn);
        }

        private void btnAddDish_Click(object sender, EventArgs e)
        {
            frmProcess pros = new frmProcess();
            pros.ShowDialog();
            loadDishes();
        }

        private void btnAddTbl_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            frmCustomer frmCus = new frmCustomer();
            frmCus.ShowDialog();
            loadCustomers();
        }

        private void tmrMsg_Tick(object sender, EventArgs e)
        {
            if (count > 0)
            {
                lblMsg.Visible = false;
                count = 0;
                tmrMsg.Stop();
            }
            count++;
        }

        private void cmbClient_SelectedValueChanged(object sender, EventArgs e)
        {
            if (loading || cmbClient.SelectedValue == null)
                return;
            if (Convert.ToInt64(cmbClient.SelectedValue.ToString()) <= 0)
                return;

            fnb.cus_id = Convert.ToInt64(cmbClient.SelectedValue.ToString());
            numClientBal.Value = Convert.ToInt64(tblCus.Rows[cmbClient.SelectedIndex][Customer.col_balance]);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            calValues();
            getData();
            fnb.saveOrder();
            if (fnb.result)
            {
                loading = true;
                if (chkPrint.Checked)
                    fnb.printBill();
                fnb.clearCarts();
                clearValues();
                loadDishes();
                loading = false;
            }
            com.showMessage(fnb.msg, lblMsg, fnb.msg_type, tmrMsg);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        { 
            
        }

        private void dgvOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
                return;
            string operation = dgvOrders.Columns[e.ColumnIndex].Name;
            if (operation == "Del")
            {
                fnb.prod_id = Convert.ToInt32(fnb.tblCart.Rows[e.RowIndex][Product.col_prod_id]);
                int x = com.searchTableIndex(tblProd, Product.col_prod_id, fnb.prod_id.ToString());
                fnb.tblCart.Rows.RemoveAt(e.RowIndex);
                fnb.dish_qty = 0;
                updProdQty((Button)fpnlDish.Controls[tblProd.Rows[x][Product.col_prod_name].ToString()]);
                calValues();
                numPaid.Value = numBillAmt.Value;
                delPending(fnb.prod_id);
            }
        }

        private void dgvOrders_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvOrders.Columns[e.ColumnIndex].Name == Foodnb.col_price)
            {
                int tmpPrice = Convert.ToInt32(dgvOrders.Rows[e.RowIndex].Cells[Foodnb.col_price].Value);
                int tmpQty = Convert.ToInt32(dgvOrders.Rows[e.RowIndex].Cells[Foodnb.col_qty].Value);
                dgvOrders.Rows[e.RowIndex].Cells[Foodnb.col_amount].Value = tmpPrice * tmpQty;
            }

            calValues();
        }

        private void numPaid_ValueChanged(object sender, EventArgs e)
        {
            if (loading)
                return;
            if (!com.chkCombo(cmbClient) && numBillAmt.Value > numPaid.Value)
                numPaid.Value = numBillAmt.Value;

            numChange.Value = numPaid.Value > numBillAmt.Value ? numPaid.Value - numBillAmt.Value : 0;
            calValues();
        }

        private void numDist_ValueChanged(object sender, EventArgs e)
        {
            if (numDist.Value > numBillAmt.Value)
                numDist.Value = 0;
            calValues();
            numPaid.Value = numBillAmt.Value;
            numChange.Value = numPaid.Value > numBillAmt.Value ? numPaid.Value - numBillAmt.Value : 0;
        }

        private void cmbClient_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbClient.Text))
                numClientBal.Value = 0;
        }
        
        private void dgvPending_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            fnb.tblPending.Rows.RemoveAt(e.RowIndex);
        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            frmSaleReview review = new frmSaleReview();
            review.ShowDialog();
            loadDishes();
        }
    }
}