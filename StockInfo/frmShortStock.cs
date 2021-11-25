using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using prjGrow.General;
using prjGrow.Classes;
using prjGrow.Reporting;

namespace prjGrow.StockInfo
{
    public partial class frmShortStock : frmBaseGeneral
    {
        public frmShortStock()
        {
            InitializeComponent();
        }

        Product prod = new Product();

        bool validData()
        {
            return com.chkValid(new Control[]{cmbProd, numQty}, new string[]{"Product Name","Quantity"}, lblMsg, tmrMsg);
        }

        void getData()
        {
            prod.id = Convert.ToInt64(cmbProd.SelectedValue);
            prod.min_stock = Convert.ToInt64(numQty.Value);
        }

        void loadData()
        {
            prod.getShortStock();
            dgvData.DataSource = prod.tblData;
            com.hideColumns(dgvData, new string[]{Product.col_prod_id});
        }

        void loadProd()
        {
            prod.tblProd = prod.getProducts(true);
            com.loadCombo(cmbProd, prod.tblProd, Product.col_prod_name, Product.col_prod_id);
        }

        void loadStock()
        {
            if (loading || cmbProd.SelectedIndex < 0)
                return;
            numStock.Value = Convert.ToInt64(prod.tblProd.Rows[cmbProd.SelectedIndex][Product.col_stock].ToString());
        }

        void loadFields(DataGridViewRow row)
        {
            com.loadFields(row, new Control[]{cmbProd, numQty}, new string[]{Product.col_prod_id, Product.col_min_stock}, numQty, btnSaveUpd);
            cmbProd.Enabled = false;
        }

        void clear()
        {
            Control[] C = new Control[] { cmbProd, numQty, numStock };
            com.clearControls(C, cmbProd, btnSaveUpd);
            cmbProd.Enabled = true;
        }

        private void frmShortStock_Load(object sender, EventArgs e)
        {
            loading = true;
            com.loadFormInfo(this, dgvData, "Short Stock", lblClient, lblTitle);
            loadData();
            loadProd();
            loading = false;
        }

        private void btnSaveUpd_Click(object sender, EventArgs e)
        {
            if (!validData())
                return;
            getData();

            operation = btnSaveUpd.Text;
            if (operation == "&Save" || operation == "&Update")
            {
                prod.updShortStock();
            }

            if (prod.result)
            {
                com.showMessage(prod.msg, lblMsg, prod.msg_type, tmrMsg);
                loadData();
                loadProd();
                btnClear_Click(sender, e);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            loading = true;

            DataGridViewRow row = dgvData.Rows[e.RowIndex];
            prod.id = Convert.ToInt64(row.Cells[Product.col_prod_id].Value);

            string operation = dgvData.Columns[e.ColumnIndex].Name;
            if (operation == "Edit")
            {
                loadFields(row);
            }
            else if (operation == "Delete")
            {
                prod.delShortStock();
                
                if (prod.result)
                {
                    loading = true;

                    loadData();
                    
                    loading = false;
                }
                com.showMessage(prod.msg, lblMsg, prod.msg_type, tmrMsg);
            }

            loading = false;
        }

        private void cmbProd_SelectedValueChanged(object sender, EventArgs e)
        {
            loadStock();
        }

        private void txtSrh_TextChanged(object sender, EventArgs e)
        {
            com.filterData(txtSrh.Text, Product.col_prod_name, prod.tblData);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            frmShortStockRep rpt = new frmShortStockRep();
            rpt.ShowDialog();
        }
    }
}