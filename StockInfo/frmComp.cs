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
    public partial class frmComp : frmBaseGeneral
    {
        public frmComp()
        {
            InitializeComponent();
        }

        Product prod = new Product();
        Complementry comp = new Complementry();

        bool validData()
        {
            bool res = true;
            res = com.chkValid(new Control[]{numQty, cmbProduct}, new string[]{"Quantity","Product Name"});

            if (res)
            {
                res = com.chkNum(numStock);
                if (!res)
                    com.setMessage("Sorry, Not enough stock",Constants.message_info);
            }
            if (!res)
                com.showMessage(lblMsg, tmrMsg);
            return res;
        }

        void loadData()
        {
            comp.date = dtpDate.Value;
            comp.tblData = comp.getComp();
            dgvData.DataSource = comp.tblData;
            com.hideColumns(dgvData, new string[]{Complementry.col_id, Complementry.col_tran_id, Complementry.col_prod_id});
        }

        void getData()
        {
            comp.prod_id = Convert.ToInt64(cmbProduct.SelectedValue);
            comp.qty = Convert.ToDouble(numQty.Value);
            comp.remarks = txtRemarks.Text;
        }

        void clear()
        {
            Control[] C = new Control[] { cmbProduct, numStock, numQty, txtRemarks };
            com.clearControls(C, cmbProduct, btnSaveUpd);
        }

        void loadFields(DataGridViewRow row)
        {
            com.loadFields(row, new Control[]{cmbProduct, numQty, txtRemarks}, new string[]{Complementry.col_prod_id, Complementry.col_qty, Complementry.col_remarks}, cmbProduct, btnSaveUpd);
        }

        void loadProds()
        {
            prod.onlyAvailable = true;
            if (Custom.mod_fnb)
                prod.cateGadget = prod.cateStk = true;
            comp.tblProd = prod.getProducts(true);
            com.loadCombo(cmbProduct, comp.tblProd, Product.col_prod_name, Product.col_prod_id);
        }

        void loadProdData()
        {
            if (!com.chkCombo(cmbProduct) || loading)
                return;

            DataRow row = comp.tblProd.Rows[cmbProduct.SelectedIndex];
            Control[] C = new Control[] { cmbProduct, numStock };
            String[] S = new string[] { Product.col_prod_name, Product.col_stock };
            comp.cost = Convert.ToInt64(comp.tblProd.Rows[cmbProduct.SelectedIndex][Journal.col_cost]);

            com.loadFields(row, C, S);
        }

        private void frmComp_Load(object sender, EventArgs e)
        {
            loading = true;
            com.loadFormInfo(this, "Complimentary", lblClient, lblTitle);
            loadProds();
            loadData();
            loading = false;
        }

        private void btnSaveUpd_Click(object sender, EventArgs e)
        {
            if (!validData())
                return;
            getData();

            if (btnSaveUpd.Text == "&Save")
            {
                comp.saveComp();
            }
            else if (btnSaveUpd.Text == "&Update")
            {
                comp.saveComp();
            }

            if (comp.result)
            {
                clear();
                loadData();
                loadProds();
            }
            com.showMessage(comp.msg, lblMsg, comp.msg_type, tmrMsg);
        }

        private void cmbProduct_SelectedValueChanged(object sender, EventArgs e)
        {
            loadProdData();
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            loading = true;
            DataGridViewRow row = dgvData.Rows[e.RowIndex];
            numStock.Value = 0;
            comp.tran_id = Convert.ToInt64(row.Cells[Journal.col_tran_id].Value);

            string operation = dgvData.Columns[e.ColumnIndex].Name;
            if (operation == "Edit")
            {
                Control[] C = new Control[] { cmbProduct, numQty, txtRemarks };
                string[] S = new string[] { Complementry.col_prod_id, Complementry.col_qty, Complementry.col_remarks };
                com.loadFields(row, C, S, cmbProduct, btnSaveUpd);
            }
            else if (operation == "Delete")
            {
                if (!com.delOption("Complementry"))
                    return;
                comp.delComp();
                if (comp.result)
                {
                    loading = true;
                    loadData();
                    loadProds();
                    loading = false;
                }
                com.showMessage(comp.msg, lblMsg, comp.msg_type, tmrMsg);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}