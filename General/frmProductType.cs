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
    public partial class frmProductType : prjGrow.General.frmBaseSimple
    {
        public frmProductType()
        {
            InitializeComponent();
        }

        DataTable tblExpType = new DataTable();
        Prod_type prodType = new Prod_type();

        void loadData()
        {
            tblExpType = prodType.getTypes();
            dgvData.DataSource = tblExpType;
            com.hideColumns(dgvData, new string[] { Prod_type.col_prod_type_id });
        }
        void getData()
        {
            prodType.name = txtProductType.Text;
        }

        bool validData()
        {
            bool res = com.chkNull(txtProductType, "Expense Type");
            if (!res)
                com.showMessage(lblMsg, tmrMsg);
            return res;
        }

        void loadFields(DataGridViewRow row)
        {
            Control[] C = new Control[] { txtProductType };
            string[] S = new string[] { Prod_type.col_prod_type};

            com.loadFields(row, C, S, txtProductType, btnSaveUpd);
        }
        void clear()
        {
            Control[] C = new Control[] { txtProductType };
            com.clearControls(C, txtProductType, btnSaveUpd);
        }


        private void frmProductType_Load(object sender, EventArgs e)
        {
            loadData();
            com.loadFormInfo(this, "Product Type", lblClient, lblTitle);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnSaveUpd_Click(object sender, EventArgs e)
        {
            if (!validData())
                return;

            getData();

            if (btnSaveUpd.Text == "&Save")
            {
                prodType.saveProType();
            }
            else if (btnSaveUpd.Text == "&Update")
            {
                prodType.updProType();
            }

            if (prodType.result)
            {
                clear();
                loadData();
            }

            com.showMessage(prodType.msg, lblMsg, prodType.msg_type, tmrMsg);
        }

        private void txtSrh_TextChanged(object sender, EventArgs e)
        {
            com.filterData(txtSrh.Text, Prod_type.col_prod_type, dgvData, tblExpType);
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
                return;
            // loading = true;

            string colName = dgvData.Columns[e.ColumnIndex].Name;
            DataGridViewRow row = dgvData.Rows[e.RowIndex];
            prodType.id = Convert.ToInt64(row.Cells[Prod_type.col_prod_type_id].Value.ToString());

            if (colName == "Edit")
            {
                loadFields(row);
            }
            else if (colName == "Delete")
            {
                if (com.delOption("Product Type"))
                {
                    prodType.delProdType();

                    com.showMessage(prodType.msg, lblMsg, prodType.msg_type, tmrMsg);
                    if (prodType.result)
                    {
                        loadData();
                        clear();
                    }
                }
            }
            //  loading = false;
        }
    }
}
