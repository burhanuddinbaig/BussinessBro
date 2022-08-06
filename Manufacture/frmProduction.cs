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
    public partial class frmProduction : frmBaseGeneral
    {
        public frmProduction()
        {
            InitializeComponent();
        }

        Product prod = new Product();
        Processing proc = new Processing();
        long curStock = 0;

        DataTable tblProd = new DataTable();
        DataTable tblData = new DataTable();

        void getData()
        {
            proc.isOrder = false;
            proc.date = dtpDate.Value;
            proc.prod_id = Convert.ToInt64(cmbProd.SelectedValue);
            proc.qty = Convert.ToInt64(numQty.Value);
            proc.cost_item = Convert.ToInt64(tblProd.Rows[cmbProd.SelectedIndex][Product.col_cost]);
        }

        void clear()
        {
            Control[] C = new Control[] { cmbProd, numQty, dtpDate };
            com.clearControls(C, cmbProd, btnSaveUpd);
        }

        void loadFields(DataGridViewRow row)
        {
            Control[] C = new Control[] { cmbProd, numQty, dtpDate };
            string[] S = new string[] { Product.col_id, Product.col_qty, Product.col_date };
            com.loadFields(row, C, S, cmbProd, btnSaveUpd);
        }

        bool validation()
        {
            Control[] C = new Control[] { cmbProd, numQty, dtpDate };
            string[] S = new string[] { "Product Name", "Quantity", "Date" };
            return com.chkValid(C, S, lblMsg, tmrMsg);
        }

        void loadProducts()
        {
            prod.cateGadget = prod.catePartial = prod.multiCate = true;
            tblProd = prod.getProducts(true);
            com.loadCombo(cmbProd, tblProd, Product.col_prod_name, Product.col_prod_id);
        }

        void loadData()
        {
            tblData = proc.getProduction(Convert.ToInt64(cmbProd.SelectedValue), dtpDate.Value);
            dgvData.DataSource = tblData;
            com.hideColumns(dgvData, new string[] { Processing.col_id, Processing.col_prod_id, Processing.col_tran_id, Processing.col_order_no });
        }

        private void frmProduction_Load(object sender, EventArgs e)
        {
            loading = true;
            com.loadFormInfo(this, dgvData, "Production", lblClient, lblTitle);
            loadProducts();
            proc.date = dtpDate.Value;
            loadData();
            loading = false;
        }

        private void btnSaveUpd_Click(object sender, EventArgs e)
        {
            if (!validation())
                return;
            getData();

            if (btnSaveUpd.Text == "&Save")
            {
                proc.saveProduction();
            }
            else if (btnSaveUpd.Text == "&Update")
            {
                proc.updProduction();
            }

            if (proc.result)
            {
                loading = true;
                clear();
                loadData();
                loadProducts();
                loading = false;
            }

            com.showMessage(proc.msg, lblMsg, proc.msg_type, tmrMsg);
        }

        private void cmbProd_SelectedValueChanged(object sender, EventArgs e)
        {
            if (loading)
                return;

            numCurStock.Value = Convert.ToDecimal(tblProd.Rows[cmbProd.SelectedIndex][Product.col_stock].ToString());
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            loading = true;
            DataGridViewRow row = dgvData.Rows[e.RowIndex];
            numCurStock.Value = 0;
            proc.tran_id = Convert.ToInt64(row.Cells[Journal.col_tran_id].Value);
            
            string operation = dgvData.Columns[e.ColumnIndex].Name;
            if (operation == "Edit")
            {
                loadFields(row);
            }
            else if (operation == "Delete")
            {
                if (com.delOption("Production"))
                {
                    proc.delProduction();
                    if (proc.result)
                    {
                        loading = true;
                        loadData();
                        loadProducts();
                        loading = false;
                    }
                    com.showMessage(proc.msg, lblMsg, proc.msg_type, tmrMsg);
                }
            }
            loading = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnProd_Click(object sender, EventArgs e)
        {
            frmProducts prod = new frmProducts();
            prod.close_on_save = true;
            prod.defaultSelected = Constants.cate_gadget;
            prod.ShowDialog();
            loadProducts();
        }
    }
}