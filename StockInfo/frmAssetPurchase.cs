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
    public partial class frmAssetPurchase : frmBaseGeneral
    {
        public frmAssetPurchase()
        {
            InitializeComponent();
        }
        Asset ast = new Asset();
        Asset_Purchase astPur = new Asset_Purchase();
        Supplier sup = new Supplier();

        DataTable tblData = null;
        DataTable tblAsset = null;
        DataTable tblSup = null;

        void loadData()
        {
            tblData = astPur.getAssetPur();
            dgvData.DataSource = tblData;
         //   com.filterValue("sup_id", Asset_Purchase.col_sup_id, dgvData, tblData);          

            com.hideColumns(dgvData, new string[] { Asset_Purchase.col_id, Asset_Purchase.col_tran_id, Asset_Purchase.col_sup_id, Asset_Purchase.col_asset_id});
        }

        void loadAsset()
        {
            tblAsset = ast.getAssets();
            com.loadCombo(cmbAsset, tblAsset, Asset.col_asset_Name, Asset.col_id);
        }

        void loadSupplier()
        {
            tblSup = sup.getSupliers();
            com.loadCombo(cmbSupplier, tblSup, Supplier.col_sup_name, Supplier.col_id);
        }

        void getData()
        {
            astPur.sup_id = Convert.ToInt64(cmbSupplier.SelectedValue);
            astPur.date = dtpDate.Value;
            astPur.asset_id = Convert.ToInt64(cmbAsset.SelectedValue);
            astPur.description = txtDescription.Text;
            astPur.quantity = Convert.ToInt64(numQuantity.Value);
            astPur.cost = Convert.ToInt64(numCost.Value);
            astPur.paid = Convert.ToInt64(numPaid.Value);
            astPur.credit = Convert.ToInt64(numCredit.Value);
           
        }

        void clear()
        {
            Control[] C = new Control[] { dtpDate, cmbAsset, cmbSupplier, txtDescription, numQuantity, numCost, numPaid, numCredit };
            com.clearControls(C, cmbSupplier, btnSaveUpd);
        }

        void loadFields(DataGridViewRow row)
        {
            Control[] C = new Control[] { dtpDate, cmbAsset, cmbSupplier, txtDescription, numQuantity, numCost, numPaid, numCredit };
            string[] S = new string[] { Asset_Purchase.col_date, Asset_Purchase.col_asset_id, Asset_Purchase.col_sup_id, Asset_Purchase.col_descrip, Asset_Purchase.col_qty, Asset_Purchase.col_cost, Asset_Purchase.col_paid, Asset_Purchase.col_credit };

            com.loadFields(row, C, S);
            astPur.id = Convert.ToInt64(row.Cells[Asset_Purchase.col_id].Value);
            btnSaveUpd.Text = "&Update";
        }

        bool validData()
        {
            Control[] C = new Control[] { dtpDate, cmbAsset, numQuantity, numCost};
            string[] S = new string[] { Asset_Purchase.col_date, Asset.col_asset_Name, Asset_Purchase.col_qty, Asset_Purchase.col_cost };
            bool res = com.chkValid(C, S, lblMsg, tmrMsg);
            return res;
        }

        void calculate()
        {
            if (Convert.ToInt64(numPaid.Value) > Convert.ToInt64(numCost.Value))
            {
                numPaid.Value = numCost.Value;
                numCredit.Value = 0;
            }
            else if (Convert.ToInt32(cmbSupplier.SelectedValue) < 1)
            {
                numPaid.Value = numCost.Value;
                numCredit.Value = 0;
            }
            else
                numCredit.Value = Convert.ToInt64(numCost.Value) - Convert.ToInt64(numPaid.Value);
        }

        private void frmAssetPurchase_Load(object sender, EventArgs e)
        {
            loading = true;
            loadData();
            loadSupplier();
            loadAsset();
            com.loadFormInfo(this, "Asset Purchase", lblTitle);
            loading = false;
        }

        private void btnSaveUpd_Click(object sender, EventArgs e)
        {
            if (!validData())
                return;
            getData();

            if (btnSaveUpd.Text == "&Save")
            {
                astPur.saveAssetPurchase();
            }
            else if (btnSaveUpd.Text == "&Update")
            {
                astPur.updateAssetPurchase();
            }
            if (astPur.result)
            {
                loadData();
                clear();
            }

            com.showMessage(astPur.msg, lblMsg, astPur.msg_type, tmrMsg);
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            clear();
            this.Close();
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            DataGridViewRow row = dgvData.Rows[e.RowIndex];
            astPur.id = Convert.ToInt64(row.Cells[Asset_Purchase.col_id].Value.ToString());

            if (dgvData.Columns[e.ColumnIndex].Name == "Edit")
            {
                loadFields(row);
            }
            else if (dgvData.Columns[e.ColumnIndex].Name == "Delete")
            {
                if (com.delOption("Asset Purchase"))
                {
                    astPur.deleteAssetPurchase();
                    com.showMessage(astPur.msg, lblMsg, astPur.msg_type, tmrMsg);
                    if (astPur.result)
                    {
                        loadData();
                        clear();
                    }
                }
            }
        }

        private void btnAddNewAsset_Click(object sender, EventArgs e)
        {
            frmAssets astt = new frmAssets();
            astt.ShowDialog();
            loadAsset();
        }

        private void btnAddNewSup_Click(object sender, EventArgs e)
        {
            frmSuplier supp = new frmSuplier();
            supp.ShowDialog();
            loadSupplier();
        }

        private void numPaid_ValueChanged(object sender, EventArgs e)
        {
            calculate();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void numCost_ValueChanged(object sender, EventArgs e)
        {
            calculate();
        }
       
        private void cmbSupplier_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!loading)
                calculate();
        }

        private void cmbSupplier_TextChanged(object sender, EventArgs e)
        {
            if (!loading)
                calculate();
        }

        private void txtSrh_TextChanged(object sender, EventArgs e)
        {
            com.filterData(txtSrh.Text, "[" + Asset_Purchase.col_asset_name+ "]", dgvData, tblData);
        }

    }
}
