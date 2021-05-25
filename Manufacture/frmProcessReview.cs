using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using prjGrow.Classes;

namespace prjGrow.Manufacture
{
    public partial class frmProcessReview : frmBaseComplex
    {
        public frmProcessReview()
        {
            InitializeComponent();
        }

        frmLabour lab = new frmLabour();
        DataTable tblProd = new DataTable();
        DataTable tblGagdet = new DataTable();
        DataTable tblProdRaw = new DataTable();
        DataTable tblData = new DataTable();
        Product prod = new Product();
        Processing pros = new Processing();

        void clearItem()
        {
            com.clearContainer(gbMatiral);
        }

        void loadGadget()
        {
            prod.category = Constants.cate_gadget;
            tblGagdet = prod.getProducts(true);
            com.loadCombo(cmbProdName, tblGagdet, Product.col_prod_name, Product.col_prod_id);
            tblProd = prod.getProducts(true);
            com.loadCombo(cmbProdSrh, tblProd, Product.col_prod_name, Product.col_prod_id);
        }

        void getValues()
        {
            pros.price_item = Convert.ToInt64(numItemPrice.Value);
            pros.qty = Convert.ToInt64(numOrderQty.Value);
        }

        void getData()
        {
            pros.date = dtpDate.Value;
        }

        void loadRaw()
        {
            prod.category = Constants.cate_raw;
            tblProdRaw = prod.getProducts(true);
            com.loadCombo(cmbProd, tblProdRaw, Product.col_prod_name, Product.col_prod_id);
        }

        void loadItem(DataRow row)
        {
            com.loadFields(row, new Control[]{numMaterPrice, numMaterStock, txtMaterUnit }, new string[]{Product.col_cost, Product.col_stock, Product.col_unit});
        }

        void addItem()
        {
            if (!validItem())
                return;
            string[] S = new string[]{Processing.col_prod_id, Processing.col_prod_name, Processing.col_Item_price, Processing.col_Item_qty, Processing.col_Item_amount};
            Control[] C = new Control[]{cmbProd, numMaterPrice, numMaterQty, numMaterAmount};
            com.addtoGrid(dgvData, pros.tblProcessRaw, S, C, true);
        }

        void removeItem(int i)
        {
            pros.tblProcessRaw.Rows.RemoveAt(i);
            dgvData.DataSource = pros.tblProcessRaw;
            loadValues();
        }

        void loadValues()
        {
            pros.calCost();

            numMaterCost.Value = pros.cost_mater;
            numLabourCost.Value = pros.cost_labour;
            numTotal.Value = pros.cost_tot;
            numPriceTotal.Value = pros.price_tot;
            numGrossProfit.Value = pros.profit_gross;
            numItemPrice.Value = pros.price_item;
            numItemCost.Value = pros.cost_item;
            numItemProfit.Value = pros.profit_item;
        }

        bool validItem()
        {
            bool res = true;
            res = com.chkValid(new Control[]{cmbProd, numMaterPrice}, new string[]{"an Item", "Item Price"});
            if (res && pros.tblProcessRaw != null)
            {
                res = !com.DataExists(cmbProd.Text, Processing.col_prod_name, pros.tblProcessRaw);
                if(!res)
                    com.setMessage("Item Already Exists", Constants.message_info);
            }
            if (!res)
                com.showMessage(lblMsg, tmrMsg);
            return res;
        }

        bool validData()
        {
            bool res = false;
            res = dgvData.DataSource == pros.tblProcessRaw;
            return res;
        }

        void loadData()
        {
            long tmpId = cmbProdSrh.SelectedIndex >= 0 ? Convert.ToInt64(cmbProdSrh.SelectedValue) : 0;
            tblData = pros.getProcess( tmpId, dtpDate.Value );
            dgvData.DataSource = tblData;
            com.hideColumns(dgvData, new string[]{Processing.col_id, Processing.col_prod_id, Processing.col_tran_id, "Remove"});
            if (Custom.mod_fnb)
                com.hideColumns(dgvData, new String[] { Processing.col_order_no, Processing.col_descrip });
            com.showColumns(dgvData, new string[]{"Review"});
        }

        void customize()
        {
            pnlOdr.Visible = !Custom.mod_fnb || (Custom.client_id_active == 7);
            pnl2.Visible = !Custom.mod_fnb || !(Custom.client_id_active == 7);
            if (Custom.mod_fnb || Custom.client_id_active == 7)
                gbCustomer.Text = "Production";
        }

        void review(DataGridViewRow row)
        {
            Control[] C = new Control[]{cmbProdName, dtpDate, numOrderQty, numItemPrice};
            string[] S = new string[]{Processing.col_prod_id, Processing.col_date, Processing.col_qty, Processing.col_price};
            com.loadFields(row, C, S);

            pros.isOrder = Convert.ToInt64(row.Cells[Processing.col_order_no].Value) > 0;
            pros.isProduction = !pros.isOrder;
            pros.tran_id = Convert.ToInt64(row.Cells[Processing.col_tran_id].Value);
            pros.prod_id = Convert.ToInt64(row.Cells[Processing.col_prod_id].Value);
            pros.order_id = Convert.ToInt64(row.Cells[Processing.col_order_no].Value);

            pros.tblLabour = pros.getProcessLabour();
            lab.tblLabour = pros.tblLabour;
            btnLabour.Text = "Labour(" + pros.tblLabour.Rows.Count + ")";
            btnLabour.Enabled = true;

            pros.tblProcessRaw = pros.getProcessItems();
            dgvData.DataSource = pros.tblProcessRaw;
            com.hideColumns(dgvData, new string[]{ Processing.col_tran_id, Processing.col_prod_id, "Review" });
            com.showColumns(dgvData, new string[]{"Remove"});

            getValues();
            loadValues();
        }

        void clearValues()
        {
            Control[] C = new Control[] { numMaterCost, numGrossProfit, numItemCost, numItemPrice, numItemProfit, numLabourCost, numPriceTotal, numTotal };
            com.clearControls(C);
        }

        void clearAll()
        {
            com.clearContainer(gbCustomer);
            clearValues();
            clearItem();
            btnLabour.Text = "&Labour";
            btnLabour.Enabled = false;
        }

        private void frmProcessReview_Load(object sender, EventArgs e)
        {
            loading = true;
            com.loadFormInfo(this, dgvData, "Process Review", lblClient, lblTitle);
            loadData();
            loadGadget();
            loadRaw();
            customize();
            dtpDate.MinDate = DateTime.Today.AddMonths(-1);
            loading = false;
        }

        private void dtpDateSrh_ValueChanged(object sender, EventArgs e)
        {
            if (loading)
                return;
            cmbProdSrh.SelectedIndex = -1;
            loadData();
        }

        private void btnSaveUpd_Click(object sender, EventArgs e)
        {
            if (!validData())
                return;
            getData();
            loadValues();
            pros.updProcess();
            if (pros.result)
                btnClear_Click(sender, e);
            com.showMessage(pros.msg, lblMsg, pros.msg_type, tmrMsg);
        }

        private void cmbProd_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbProd.SelectedIndex < 0 || loading || dgvData.DataSource != pros.tblProcessRaw)
                return;
            loading = true;
            loadItem(tblProdRaw.Rows[cmbProd.SelectedIndex]);
            loading = false;
        }

        private void cmbProdSrh_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbProdSrh.SelectedIndex < 0 || loading)
                return;
            clearAll();
            loadData();
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            operation = dgvData.Columns[e.ColumnIndex].Name;
            if (operation == "Remove")
            {
                removeItem(e.RowIndex);
            }
            else if (operation == "Review")
            {
                review(dgvData.Rows[e.RowIndex]);
            }
        }

        private void btnLabour_Click(object sender, EventArgs e)
        {
            lab.fromReview = true;
            lab.ShowDialog();
            pros.tblLabour = lab.tblLabour;
            btnLabour.Text = "Labour(" + pros.tblLabour.Rows.Count + ")";
            loadValues();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
            loadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!validItem())
                return;
            addItem();
            clearItem();
            loadValues();
        }

        private void numMaterQty_ValueChanged(object sender, EventArgs e)
        {
            if (loading)
                return;
            if (numMaterQty.Value > numMaterStock.Value)
                numMaterQty.Value = 0;
            numMaterAmount.Value = numMaterQty.Value * numMaterPrice.Value;
        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            if (!validData())
                return;

            pros.delProcess();

            if (pros.result)
                loadData();

            com.showMessage(pros.msg, lblMsg, pros.msg_type, tmrMsg);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if(dgvData.DataSource == pros.tblProcessRaw)
                pros.print();
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numMaterCost_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numLabourCost_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}