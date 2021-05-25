using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using prjGrow.Classes;

namespace prjGrow.General
{
    public partial class frmAssets :  frmBaseSimple
    {
        public frmAssets()
        {
            InitializeComponent();
        }

        DataTable tblAsset = null;
        Asset ast= new Asset();

        void loadData()
        {
            tblAsset = ast.getAssets();
            dgvData.DataSource = tblAsset;
            com.hideColumns(dgvData, new string[] { Asset.col_id, Asset.col_acc_id, Asset.col_asset_type, Asset.col_asset_code });
        }

        void getData()
        {
            ast.assetName = txtAssetName.Text;
            ast.assetCode = "";
            ast.assetType = 0;

            ast.acc_name = ast.assetName;
        }

        bool validData()
        {

            if (!com.chkNull(txtAssetName, "Asset Name"))
            {
                com.showMessage(lblMsg, tmrMsg);
                return false;
            }
            else if (com.DataExists(txtAssetName.Text, Asset.col_asset_Name, tblAsset) && btnSaveUpd.Text != "&Update")
            {
                com.setMessage("Asset Name Already Exists", Constants.message_warning);
                com.showMessage(lblMsg, tmrMsg);
                return false;
            }
            //else if (txtAssetCode.Text.Trim()!="" && com.DataExists(txtAssetCode.Text, Asset.col_asset_code, tblAsset) && btnSaveUpd.Text != "&Update")
            //{
            //    com.setMessage("Asset Code Already Exists", Constants.message_warning);
            //    com.showMessage(lblMsg, tmrMsg);
            //    return false;
            //}
            else
                return true;
         
        }

        void loadFields(DataGridViewRow row)
        {
            Control[] C = new Control[] { txtAssetName, txtAssetCode};
            string[] S = new string[] { Asset.col_asset_Name, Asset.col_asset_code};

            com.loadFields(row, C, S, txtAssetName, btnSaveUpd);
        }

        void clear()
        {
            Control[] C = new Control[] { txtAssetName, txtAssetCode};
            com.clearControls(C, txtAssetName, btnSaveUpd);
        }

        private void frmAssets_Load(object sender, EventArgs e)
        {
            loadData();
            com.loadFormInfo(this, "Asset", lblClient, lblTitle);
        }

        private void btnSaveUpd_Click(object sender, EventArgs e)
        {
            if (!validData())
                return;

            getData();

            if (btnSaveUpd.Text == "&Save")
            {
                ast.saveAsset();
            }
            else if (btnSaveUpd.Text == "&Update")
            {
                ast.updAsset();
            }

            if (ast.result)
            {
                clear();
                loadData();
                if (close_on_save)
                    this.Close();
            }

            com.showMessage(ast.msg, lblMsg, ast.msg_type, tmrMsg);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
                return;
           // loading = true;

            string colName = dgvData.Columns[e.ColumnIndex].Name;
            DataGridViewRow row = dgvData.Rows[e.RowIndex];
            ast.id = Convert.ToInt64(row.Cells[Product.col_id].Value.ToString());

            if (colName == "Edit")
            {
                loadFields(row);
            }
            else if (colName == "Delete")
            {
                if (com.delOption("Asset"))
                {
                    ast.delSup();

                    com.showMessage(ast.msg, lblMsg, ast.msg_type, tmrMsg);
                    if (ast.result)
                    {
                        loadData();
                        clear();
                    }
                }
            }
           // loading = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void txtSrh_TextChanged(object sender, EventArgs e)
        {
            com.filterData(txtSrh.Text, "[" + Asset.col_asset_Name + "]", dgvData, tblAsset);
        }
    }
}
