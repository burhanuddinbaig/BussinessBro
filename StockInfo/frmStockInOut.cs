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

namespace prjGrow.StockInfo
{
    public partial class frmStockInOut : frmBaseGeneral
    {
        public frmStockInOut()
        {
            InitializeComponent();
        }

        DataTable tblProd = new DataTable();
        DataTable tblData = new DataTable();
        DataTable tblVeh = new DataTable();
        Product prod = new Product();
        Vehicle veh = new Vehicle();
        Distribute dist = new Distribute();
        Inbound inbd = new Inbound();

        void flipLabels()
        {
            lblQty.Text = rbStockOut.Checked ? "Out Qty" : "In Qty";
            lblStock.Text = rbStockOut.Checked ? "Stock Store" : "Stock Load";
        }

        void getData()
        {
            dist.veh_id = Convert.ToInt64(cmbVeh.SelectedValue);
            dist.prod_id = Convert.ToInt64(cmbProd.SelectedValue);
            dist.veh_term = Convert.ToInt32(tblVeh.Rows[cmbVeh.SelectedIndex][Vehicle.col_term_id]);
            dist.qty = Convert.ToInt64(numQty.Value);
            dist.retail = Convert.ToInt64(tblProd.Rows[cmbProd.SelectedIndex][Vehicle.col_retail]);
            dist.whole = Convert.ToInt64(tblProd.Rows[cmbProd.SelectedIndex][Vehicle.col_whole]);
            dist.date = dtpDate.Value;
        }

        void clear()
        {
            Control[] C = new Control[] { cmbProd, numQty, numStock, dtpDate};
            com.clearControls(C, cmbProd, null);
        }

        void loadProd()
        {
            prod.multiCate = prod.cateStk = prod.cateGadget = true;
            if (rbStockIn.Checked && cmbVeh.SelectedIndex < 0) cmbVeh.SelectedIndex = 0;
            prod.term_id = rbStockIn.Checked ? Convert.ToInt32(tblVeh.Rows[cmbVeh.SelectedIndex][Product.col_term_id]) :  Constants.term_store;
            tblProd = prod.getProducts(true);
            com.loadCombo(cmbProd, tblProd, Product.col_prod_name, Product.col_prod_id);
        }

        void loadVeh()
        {
            tblVeh = veh.getVehicles();
            com.loadCombo(cmbVeh, tblVeh, Vehicle.col_veh_name, Vehicle.col_veh_id);
        }
        
        void loadData()
        {
            dist.veh_id = Convert.ToInt32(cmbVeh.SelectedValue);
            dist.veh_term = com.chkCombo(cmbVeh) ? Convert.ToInt32(tblVeh.Rows[cmbVeh.SelectedIndex][Distribute.col_trem_id]) : 0;
            tblData = dist.getData(rbStockOut.Checked);
            dgvData.DataSource = tblData;
            com.hideColumns( dgvData, new string[]{ Distribute.col_tran_id, Distribute.col_veh_id, Distribute.col_prod_id, Distribute.col_trem_id, Distribute.col_date });
        }

        void loadStockIn()
        {
            
        }

        bool validation()
        {
            bool b = com.chkValid(new Control[] { cmbVeh, cmbProd, numQty }, new string[] {"Vehicle Name", "Product Name", "Quantity"});
            return b;
        }

        private void frmStockInOut_Load(object sender, EventArgs e)
        {
            loading = true;
            com.loadFormInfo(this, dgvData, "Stock In-Out", lblClient, lblTitle);
      //      loadData();
            loadProd();
            loadVeh();
            loading = false;
        }

        private void rbStockIn_CheckedChanged(object sender, EventArgs e)
        {
            dist.date = dtpDate.Value;
            cmbProd.SelectedIndex = -1;
            clear();
            flipLabels();
            loadData();
            loadProd();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void rbStockOut_CheckedChanged(object sender, EventArgs e)
        {
            clear();
            flipLabels();
            loadData();
            loadProd();
        }

        private void btnSaveUpd_Click(object sender, EventArgs e)
        {
            if (!validation())
                return;
            getData();
            if (rbStockIn.Checked)
                dist.stockIn();
            else if (rbStockOut.Checked)
                dist.stockOut();
            if (dist.result)
            {
                loadData();
                clear();
            }
            com.showMessage(dist.msg, lblMsg, dist.msg_type, tmrMsg);
        }

        private void numQty_ValueChanged(object sender, EventArgs e)
        {
            if (numQty.Value > numStock.Value)
                numQty.Value = numStock.Value;
        }

        private void cmbProd_SelectedValueChanged(object sender, EventArgs e)
        {
            if (loading)
                return;
            if(com.chkCombo(cmbProd, "Product Name"))
                numStock.Value = Convert.ToInt64(tblProd.Rows[cmbProd.SelectedIndex][Product.col_stock]);
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbVeh_SelectedValueChanged(object sender, EventArgs e)
        {
            if (loading)
                return;

            dist.date = dtpDate.Value;
            dist.veh_id = Convert.ToInt64(cmbVeh.SelectedValue);

            loadData();
            if (rbStockIn.Checked)
                loadProd();
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            if (loading)
                return;

            dist.date = dtpDate.Value;
            dist.veh_id = Convert.ToInt64(cmbVeh.SelectedValue);

            loadData();
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            DataGridViewRow row = dgvData.Rows[e.RowIndex];
            dist.tran_id = Convert.ToInt64(row.Cells[Distribute.col_tran_id].Value.ToString());
            operation = dgvData.Columns[e.ColumnIndex].Name;

            if (operation == "Delete")
            {
                if (com.delOption("Record"))
                {
                    dist.deleteTransaction("Stock_distrib", "Stock");
                    com.showMessage(dist.msg, lblMsg, dist.msg_type, tmrMsg);

                    if (dist.result)
                    {
                        loadData();
                        clear();
                    }
                }
            }
        }
    }
}