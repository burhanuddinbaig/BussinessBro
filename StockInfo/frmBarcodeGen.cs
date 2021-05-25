using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using prjGrow.Reporting;
using prjGrow.Classes;

namespace prjGrow.StockInfo
{
    public partial class frmBarcodeGen : frmBaseReportSimple
    {
        public frmBarcodeGen()
        {
            InitializeComponent();
        }

        Barcode code = new Barcode();
        Product prod = new Product();

        public bool validItem()
        {
            bool res = true;
            res = com.chkValid(new Control[] { txtCode, cmbProd, numQty }, new string[] { "Product", "Product", "Quantity" }, lblMsg, tmrMsg);

            if (com.DataExists(cmbProd.Text, Product.col_prod_name, code.tblCodes))
            {
                com.setMessage("Product Already Exists",Constants.message_info);
                res = false;
            }
            if (rbExist.Checked)
            {
                int x = com.searchTableIndex(code.tblProd, Product.col_code, txtCode.Text);
                res = x >= 0;
                if (!res)
                    com.setMessage("Not a valid Product Code", Constants.message_warning);
            }
            if (!res)
                com.showMessage(lblMsg,tmrMsg);
            return res;
        }

        public void loadProd()
        {
            prod.forLabels = true;
            prod.cateBakery = prod.cateStk = prod.cateBakery = prod.allCate = prod.multiCate = true;
            code.tblProd = prod.getProducts();
            com.loadCombo(cmbProd, code.tblProd, Product.col_prod_name, Product.col_id);
        }

        public void flip()
        {
            clear();
            txtCode.Enabled = rbExist.Checked;
            if (rbExist.Checked)
            {
                com.filterData("1%", Product.col_code, code.tblProd);
                txtCode.Focus();
            }
            if (rbNew.Checked)
            {
                com.filterData("", Product.col_code, code.tblProd, false);
                cmbProd.Focus();
                txtCode.Text = code.curCode;
            }
        }

        public void showTable()
        {
            code.tblCodes.Clear();
            dgvData.DataSource = code.tblCodes;
            com.hideColumns(dgvData, new string[] { Product.col_prod_id });
        }

        public bool upcaCode(string str)
        {
            if (str.Contains("027639"))
                return true;
            else
            {
                com.showMessage("Not a valid UPCA code", lblMsg, Constants.message_info, tmrMsg);
                return false;
            }
        }

        public void addToTable()
        {
            code.prod_id = Convert.ToInt64(cmbProd.SelectedValue);
            if (code.prod_id <= 0)
                return;
            code.prod_code = txtCode.Text;
            if (rbNew.Checked)
            {
                code.prod_name = cmbProd.Text;
                int x = com.searchTableIndex(code.tblProd, Product.col_prod_name, code.prod_name);
                code.price = Convert.ToInt64(code.tblProd.Rows[x][Product.col_retail].ToString());
            }
            else
            {
                int x = com.searchTableIndex(code.tblProd, Product.col_code, txtCode.Text);
                code.prod_name = code.tblProd.Rows[x][Product.col_prod_name].ToString();
                code.price = Convert.ToInt64(code.tblProd.Rows[x][Product.col_retail].ToString());
            }
            code.qty = Convert.ToInt64(numQty.Value);

            code.tblCodes.Rows.Add(code.prod_id, code.prod_code, code.prod_name, code.qty, code.price);
            dgvData.DataSource = code.tblCodes;
        }

        public void clear()
        {
            Control[] C = new Control[] { txtCode, cmbProd, numQty };
            com.clearControls(C);
        }

        void clearGrid()
        {
            code.tblCodes.Clear();
            dgvData.DataSource = code.tblCodes;
            setCode();
        }

        void setCode()
        {
            code.getLastCode();
            code.nextCode();
            if (rbNew.Checked)
                txtCode.Text = code.curCode;
        }

        private void frmBarcodeGen_Load(object sender, EventArgs e)
        {
            loading = true;
            com.loadFormInfo(this,"Barcode Generator",lblTitle);
            code.createTable();
            loadProd();
            showTable();
            flip();
            setCode();
            loading = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!validItem())
                return;
            addToTable();
            clear();
            if (rbNew.Checked)
            {
                code.nextCode();
                txtCode.Text = code.curCode;
            }
        }

        private void rbNew_CheckedChanged(object sender, EventArgs e)
        {
            flip();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            code.addToTmp();
            code.print();
            code.updateCodes();
            loadProd();
            flip();
            com.showMessage(code.msg, lblMsg, code.msg_type, tmrMsg);
        }

        private void txtCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string tmpCode = txtCode.Text;
                if (tmpCode == "" || !com.DataExists(tmpCode, Product.col_code, code.tblProd))
                {
                    cmbProd.SelectedIndex = -1;
                    return;
                }

                int id = Convert.ToInt32(com.searchTableRow(code.tblProd, Product.col_code, tmpCode)[Product.col_id].ToString());
                cmbProd.SelectedValue = id;
                if (id >= 0)
                    numQty.Focus();
            }
        }

        private void cmbProd_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbProd.SelectedIndex < 0 || loading)
                return;

            if (rbExist.Checked)
            {
                string tmpCode = com.searchTableRow(code.tblProd, Product.col_id, cmbProd.SelectedValue.ToString())[Product.col_code].ToString();
                
                txtCode.Text = tmpCode;
                numQty.Focus();
            }
        }

        private void numQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd_Click(sender, e);
            }
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
                return;

            if (dgvData.Columns[e.RowIndex].Name == "Remove")
            {
            //    dgvData.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            clear();
            clearGrid();
        }
    }
}
