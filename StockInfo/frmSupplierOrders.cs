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
    public partial class frmSupplierOrders : frmBaseGeneral
    {
        public frmSupplierOrders()
        {
            InitializeComponent();
        }

        Product prod = new Product();
        Supplier sup = new Supplier();
        Sup_Orders odr = new Sup_Orders();

        frmDisplayRep display = new frmDisplayRep("Supplier Orders");

        DataTable tblProd = new DataTable();
        DataTable tblSup = new DataTable();
        DataTable tblData = new DataTable();

        void loadProducts()
        {
            prod.cateStk = prod.cateRaw = prod.multiCate = true;
            tblProd = prod.getProducts();
            com.loadCombo(cmbProd, tblProd, Product.col_prod_name, Product.col_id);
        }

        void loadSuplier()
        {
            tblSup = sup.getSupliers();
            com.loadCombo(cmbSupName, tblSup, Supplier.col_sup_name, Supplier.col_id);
        }

        void loadFields(DataGridViewRow row)
        {
            Control[] C = new Control[]{ cmbProd, cmbSupName, numQty };
            string[] S = new string[]{ Sup_Orders.col_prod_id, Sup_Orders.col_sup_id, Sup_Orders.col_qty };

            com.loadFields(row, C, S, cmbProd, btnSaveUpd );
        }

        void loadData()
        {
            odr.sup_id = Convert.ToInt64(cmbSupName.SelectedValue);
            tblData = odr.getSupOrders();
            dgvData.DataSource = tblData;
            com.hideColumns(dgvData, new string[] {Sup_Orders.col_id, Sup_Orders.col_prod_id, Sup_Orders.col_sup_id});
        }

        void clear()
        {
            Control[] C = new Control[] { cmbProd, numQty };
            com.clearControls(C, cmbProd, btnSaveUpd);
        }

        bool validation()
        {
            Control[] C = new Control[] { cmbProd, cmbSupName, numQty };
            string[] S = new string[] { "Product Name", "Supplier Name", "Quantity" };

            return com.chkValid(C, S);
        }

        void getData()
        {
            odr.prod_id = Convert.ToInt64(cmbProd.SelectedValue);
            odr.sup_id = Convert.ToInt64(cmbSupName.SelectedValue);
            odr.qty = Convert.ToInt64(numQty.Value);
        }

        private void frmSupplierOrders_Load(object sender, EventArgs e)
        {
            loading = true;
            com.loadFormInfo(this, dgvData, "Supplier Orders", lblClient, lblTitle);
            loadProducts();
            loadSuplier();
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
                odr.saveSupOrder();
            }
            else if (isUpd())
            {
                odr.updSupOrder();
            }
            if (odr.result)
            {
                loadData();
                clear();
            }
            com.showMessage(odr.msg, lblMsg, odr.msg_type, tmrMsg);
        }

        private void btnOrderRep_Click(object sender, EventArgs e)
        {
            frmSupOrder supOdr = new frmSupOrder();
            supOdr.ShowDialog();
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            DataGridViewRow row = dgvData.Rows[e.RowIndex];
            odr.id = Convert.ToInt64(row.Cells[Customer.col_id].Value.ToString());
            
            operation = dgvData.Columns[e.ColumnIndex].Name;

            if (isEdit())
            {
                loadFields(row);
            }
            else if (isDel())
            {
                if (com.delOption("Supplier Order"))
                {
                    odr.delSupOrder();

                    com.showMessage(odr.msg, lblMsg, odr.msg_type, tmrMsg);
                    if (odr.result)
                    {
                        clear();
                        loadData();
                    }
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void cmbSupName_SelectedValueChanged(object sender, EventArgs e)
        {
            if (loading)
                return;
            loadData();
        }
    }
}
