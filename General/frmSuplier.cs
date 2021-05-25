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
    public partial class frmSuplier : frmBaseGeneral
    {
        public frmSuplier()
        {
            InitializeComponent();
        }

        DataTable tblSuplier = null;
        Supplier sup = new Supplier();

        void loadData()
        {
            tblSuplier = sup.getSupliers();
            dgvData.DataSource = tblSuplier;
            com.hideColumns(dgvData, new string[] {Supplier.col_id, Supplier.col_acc_id, Supplier.col_balance});
        }

        void getData()
        {
            sup.name = txtSupName.Text;
            sup.contact = txtContact.Text;
            sup.cell = txtCellno.Text;
            sup.adrs = txtAdrs.Text;

            sup.acc_name = sup.name;
        }

        bool validData()
        {
            bool res = com.chkNull(txtSupName, "Suplier Name");
            if (!res)
                com.showMessage(lblMsg, tmrMsg);
            return res;
        }

        void loadFields(DataGridViewRow row)
        {
            Control[] C = new Control[] { txtSupName, txtCellno, txtContact, txtAdrs };
            string[] S = new string[] { Supplier.col_sup_name, Supplier.col_cell, Supplier.col_contact, Supplier.col_adrs };

            com.loadFields(row, C, S, txtSupName, btnSaveUpd);
        }

        void clear()
        {
            Control[] C = new Control[] { txtSupName, txtCellno, txtContact, txtAdrs };
            com.clearControls(C, txtSupName, btnSaveUpd);
        }

        private void btnSaveUpd_Click(object sender, EventArgs e)
        {
            if (!validData())
                return;

            getData();

            if (btnSaveUpd.Text == "&Save")
            {
                sup.saveSup();
            }
            else if (btnSaveUpd.Text == "&Update")
            {
                sup.updSup();
            }

            if (sup.result)
            {
                clear();
                loadData();

                if (close_on_save)
                    this.Close();
            }

            com.showMessage(sup.msg, lblMsg, sup.msg_type, tmrMsg);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
                return;
            loading = true;

            string colName = dgvData.Columns[e.ColumnIndex].Name;
            DataGridViewRow row = dgvData.Rows[e.RowIndex];
            sup.id = Convert.ToInt64(row.Cells[Product.col_id].Value.ToString());

            if (colName == "Edit")
            {
                loadFields(row);
            }
            else if (colName == "Delete")
            {
                if (com.delOption("Supplier"))
                {
                    sup.delSup();

                    com.showMessage(sup.msg, lblMsg, sup.msg_type, tmrMsg);
                    if (sup.result)
                    {
                        loadData();
                        clear();
                    }
                }
            }
            loading = false;
        }

        private void txtSrh_TextChanged(object sender, EventArgs e)
        {
            com.filterData(txtSrh.Text, Supplier.col_sup_name, dgvData, tblSuplier);
        }

        private void frmSuplier_Load(object sender, EventArgs e)
        {
            loadData();
            com.loadFormInfo(this, "Supplier",lblClient, lblTitle);
        }
    }
}
