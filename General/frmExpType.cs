using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using prjGrow.Classes;

namespace prjGrow.General
{
    public partial class frmExpType : prjGrow.General.frmBaseSimple
    {
        public frmExpType()
        {
            InitializeComponent();
        }
        DataTable tblExpType = new DataTable();
        Exp_type exp = new Exp_type();

        void loadData()
        {
            tblExpType = exp.getExpTypes();
            dgvData.DataSource = tblExpType;
            com.hideColumns(dgvData, new string[] { Exp_type.col_id, Exp_type.col_acc_id });
        }
        void getData()
        {
            exp.name = txtExpType.Text;

            exp.acc_name = exp.name;
        }

        bool validData()
        {
            bool res = com.chkNull(txtExpType, "Expense Type");
            if (!res)
                com.showMessage(lblMsg, tmrMsg);
            return res;
        }

        void loadFields(DataGridViewRow row)
        {
            Control[] C = new Control[] { txtExpType};
            string[] S = new string[] { Exp_type.col_name};

            com.loadFields(row, C, S, txtExpType, btnSaveUpd);
        }
        void clear()
        {
            Control[] C = new Control[] { txtExpType };
            com.clearControls(C, txtExpType, btnSaveUpd);
        }

        private void frmExpType_Load(object sender, EventArgs e)
        {
            loadData();
            com.loadFormInfo(this, "Expense Type", lblClient, lblTitle);
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
                exp.saveExpType();
            }
            else if (btnSaveUpd.Text == "&Update")
            {
                exp.updExpType();
            }

            if (exp.result)
            {
                clear();
                loadData();
            }

            com.showMessage(exp.msg, lblMsg, exp.msg_type, tmrMsg);
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
                return;
            // loading = true;

            string colName = dgvData.Columns[e.ColumnIndex].Name;
            DataGridViewRow row = dgvData.Rows[e.RowIndex];
            exp.id = Convert.ToInt64(row.Cells[Exp_type.col_id].Value.ToString());

            if (colName == "Edit")
            {
                loadFields(row);
            }
            else if (colName == "Delete")
            {
                if (com.delOption("Expense Type"))
                {
                    exp.delExpType();

                    com.showMessage(exp.msg, lblMsg, exp.msg_type, tmrMsg);
                    if (exp.result)
                    {
                        loadData();
                        clear();
                    }
                }
            }
          //  loading = false;
        }

        private void txtSrh_TextChanged(object sender, EventArgs e)
        {
            com.filterData(txtSrh.Text, Exp_type.col_name, dgvData, tblExpType);
        }
    }
}
