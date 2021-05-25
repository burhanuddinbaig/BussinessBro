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
    public partial class frmInbound : frmBaseGeneral
    {
        public frmInbound()
        {
            InitializeComponent();
        }

        Product pro = new Product();
        DataTable tblPro = null;
        DataTable tblData = new DataTable();
        Inbound inbd = new Inbound();
        Stock stk = new Stock();

        void loadProduct()
        {
            tblPro = inbd.getProdInbound();
            com.loadCombo(cmbProdName, tblPro, Inbound.col_prod_name, Inbound.col_prod_id);
        }
        void customize()
        {
            if(Custom.mod_manufact)
                lblShop.Text = "Stock Factory";
        }
        void loadStock()
        {
            if (!com.chkCombo(cmbProdName)|| loading)
                return;
            DataRow row = tblPro.Rows[cmbProdName.SelectedIndex]; // (DataRow)cmbProdName.SelectedItem;
            com.loadFields(row, new Control[] { txtProdCode, numTotalStk, numStkShop, numStkStore }, new string[] { Inbound.col_prod_code, Inbound.col_stock, Inbound.col_shop, Inbound.col_store });
        }
        bool validData()
        {
            if (!(com.chkNum(numQnty) || com.chkCombo(cmbProdName)))
            {
                com.showMessage("Please select product and enter quantity", lblMsg, Constants.message_info, tmrMsg);
                return false;
            }
            else if (numQnty.Value > numStkStore.Value)
            {
                com.showMessage("You are entering a quantity more than stock", lblMsg, Constants.message_info, tmrMsg);
                return false;
            }
            else
                return true;
        }
        void getData()
        {
            int i = cmbProdName.SelectedIndex;
            inbd.indate = dtpDate.Value;
            inbd.qty = Convert.ToInt64(numQnty.Value);
            inbd.pro_id = Convert.ToInt64(cmbProdName.SelectedValue);
            inbd.cost = Convert.ToInt64(tblPro.Rows[i][Stock.col_cost]);
            inbd.whole = Convert.ToInt64(tblPro.Rows[i][Stock.col_whole]);
            inbd.retail = Convert.ToInt64(tblPro.Rows[i][Stock.col_retail]);
        }
        void loadData()
        {
            loading = true;
            tblData = inbd.getStoreData(dtpDate.Value);
            dgvData.DataSource = tblData;
            com.hideColumns(dgvData, new string[] { Inbound.col_id, Inbound.col_prod_id, Inbound.col_tran_id, Inbound.col_stock });
            loading = false;
        }
        void clear()
        {
            loading = true;
            Control[] C = new Control[] { numQnty, cmbProdName,txtProdCode, numStkShop, numStkStore, numTotalStk};
            com.clearControls(C, txtProdCode, btnSaveUpd);
            loading = false;
        }
        private void frmInbound_Load(object sender, EventArgs e)
        {
            loading = true;
            com.loadFormInfo(this ,"Store",lblClient, lblTitle);
            loadProduct();
            loadData();
            customize();
            loading = false;
        }

        private void btnSaveUpd_Click(object sender, EventArgs e)
        {
            if (!validData())
                return;
            getData();
            if (btnSaveUpd.Text == "&Save")
            {
                inbd.saveInbound();
            }
            else if (btnSaveUpd.Text == "&Update")
            {
                
            }
            if (inbd.result)
            {
                loadData();
                loadProduct();
                clear();
            }
            com.showMessage(inbd.msg, lblMsg, inbd.msg_type, tmrMsg);
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            DataGridViewRow row = dgvData.Rows[e.RowIndex];
            inbd.id = Convert.ToInt64(row.Cells[Inbound.col_id].Value.ToString());
            inbd.tran_id = Convert.ToInt64(row.Cells[Inbound.col_tran_id].Value.ToString());
            operation = dgvData.Columns[e.ColumnIndex].Name;

            if (operation == "Remove")
            {
                if (com.delOption("Record"))
                {
                    inbd.delInbound();
                    com.showMessage(inbd.msg, lblMsg, inbd.msg_type, tmrMsg);

                    if (inbd.result)
                    {
                        loadData();
                        clear();
                    }
                }
            }
        }       

        private void cmbProdName_SelectedValueChanged(object sender, EventArgs e)
        {
            loadStock();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void txtProdCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (loading)
                    return;
                string tmpCode = txtProdCode.Text;
                if (tmpCode.Equals(""))
                    return;
                int x =  com.searchTableIndex(tblPro, Inbound.col_prod_code, tmpCode);
                cmbProdName.SelectedIndex = x;
                numQnty.Focus();
            }
        }

        private void numStkStore_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numStkShop_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblClient_Click(object sender, EventArgs e)
        {

        }
    }
}