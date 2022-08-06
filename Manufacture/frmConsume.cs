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

namespace prjGrow.Manufacture
{
    public partial class frmConsume : frmBaseGeneral
    {
        public frmConsume()
        {
            InitializeComponent();
        }

        Product prod = new Product();
        DataTable tblProd = new DataTable();
        DataTable tblData = new DataTable();

        Consume consume = new Consume();

        void getData()
        {
            consume.prod_id = Convert.ToInt64(cmbProd.SelectedValue);
            consume.remarks = txtRemarks.Text;
            consume.date = dtpDate.Value;

            consume.stock.term_id = rbStore.Checked ? Constants.term_store : Constants.term_shop;
            consume.stock.prod_id = consume.prod_id;
            consume.stock.cr = Convert.ToInt64(numQty.Value);
            consume.stock.cost = Convert.ToInt64(tblProd.Rows[cmbProd.SelectedIndex][Product.col_cost]);
        }

        void customize()
        {
            rbFactory.Visible = Custom.client_id_active == 7;
            rbStore.Visible = Custom.client_id_active == 7 || Custom.client_id_active == 5;
            rbShop.Visible = Custom.client_id_active == 5;

            rbStore.Checked = Custom.client_id_active == 7;
        }

        void clear()
        {
            Control[] C = new Control[] { cmbProd, numQty, dtpDate, txtRemarks, numCurStock };
            loading = true;
            com.clearControls(C, cmbProd, btnSaveUpd);
            loading = false;
        }

        void loadFields(DataGridViewRow row)
        {
            Control[] C = new Control[] { cmbProd, numQty, dtpDate };
            string[] S = new string[] { Product.col_prod_id, Product.col_qty, Product.col_date };
            com.loadFields(row, C, S, cmbProd, btnSaveUpd);
        }

        bool validation()
        {
            Control[] C = new Control[] { cmbProd, numQty, dtpDate };
            string[] S = new string[] { "Product Name", "Quantity", "Date" };
            return com.chkValid(C, S, lblMsg, tmrMsg);
        }

        void loadProd()
        {
            prod.cateRaw = prod.catePartial = prod.multiCate = true;
            prod.term_id = rbFactory.Checked ? Constants.term_factory : Constants.term_store;
            if (Custom.client_id_active == 9)
                prod.term_id = 0;
            tblProd = prod.getProducts(true);
            com.loadCombo(cmbProd, tblProd, Product.col_prod_name, Product.col_prod_id);
        }

        void loadData()
        {
            if (loading)
                consume.date = DateTime.Today;
            else
                consume.date = dtpDate.Value;

            tblData = consume.getConsumeData();
            dgvData.DataSource = tblData;
            com.hideColumns(dgvData, new string[] { Processing.col_id, Processing.col_prod_id, Processing.col_tran_id, "Edit" });
        }

        private void frmConsume_Load(object sender, EventArgs e)
        {
            loading = true;
            com.loadFormInfo(this, "Stock Consumption", lblClient, lblTitle);
            customize();
            loadData();
            loadProd();
            loading = false;
        }

        private void btnSaveUpd_Click(object sender, EventArgs e)
        {
            if (!validation())
                return;
            getData();
            
            operation = btnSaveUpd.Text;
            if (isSave())
            {
                consume.saveConsume();
            }
            else if (isUpd())
            {
                consume.updConsume();
            }
            if (consume.result)
            {
                loadData();
                clear();
            }
            com.showMessage(consume.msg, lblMsg, consume.msg_type, tmrMsg);
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            DataGridViewRow row = dgvData.Rows[e.RowIndex];
            consume.id = Convert.ToInt64(row.Cells[Consume.col_id].Value.ToString());
            consume.tran_id = Convert.ToInt64(row.Cells[Consume.col_tran_id].Value.ToString());
            operation = dgvData.Columns[e.ColumnIndex].Name;

            if (isEdit())
            {
                loadFields(row);
            }
            else if (isDel())
            {
                if (com.delOption("Stock Consumption"))
                {
                    consume.delConsume();
                    com.showMessage(consume.msg, lblMsg, consume.msg_type, tmrMsg);
                    if (consume.result)
                    {
                        loadData();
                        clear();
                    }
                }
            }
        }

        private void btnProd_Click(object sender, EventArgs e)
        {
            frmProducts frmProd = new frmProducts();
            frmProd.defaultSelected = Constants.cate_raw;
            frmProd.ShowDialog();
            loadProd();
        }

        private void rbStore_CheckedChanged(object sender, EventArgs e)
        {
            if (rbStore.Checked)
            {
                clear();
                loadProd();
            }
        }

        private void rbShop_CheckedChanged(object sender, EventArgs e)
        {
            if (rbShop.Checked)
            {
                clear();
                loadProd();
            }
        }

        private void rbFactory_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFactory.Checked)
            {
                clear();
                loadProd();
            }
        }

        private void cmbProd_SelectedValueChanged(object sender, EventArgs e)
        {
            if (loading)
                return;
            if (tblProd.Rows.Count <= 0 || !com.chkCombo(cmbProd))
                return;
            long tmp = Convert.ToInt64(tblProd.Rows[cmbProd.SelectedIndex][Product.col_stock].ToString());
            numCurStock.Value = tmp;
        }

        private void cmbProd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
