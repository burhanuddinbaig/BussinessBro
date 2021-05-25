using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using prjGrow.Classes;
using prjGrow.General;

namespace prjGrow.Fnb
{
    public partial class frmTable : frmBaseMicro
    {
        public frmTable()
        {
            InitializeComponent();
        }

        DataTable tblData = new DataTable();
        clsTable tbl = new clsTable();

        bool validData()
        {
            return com.chkNull(txtName, "Table Name");
        }

        void clear()
        {
            com.clearControls(new Control[] { txtName }, txtName, btnSave);
        }

        void getData()
        {
            tbl.tbl_name = txtName.Text;
        }

        void loadData()
        {
            tblData = tbl.getTables();
            dgvData.DataSource = tblData;
            com.hideColumns(dgvData, new string[] { clsTable.col_id });
        }

        void loadFields(DataGridViewRow row)
        {
            Control[] C = new Control[] { txtName };
            string[] S = new string[] { clsTable.col_tbl_name };

            com.loadFields(row, C, S, txtName, btnSave);
        }

        private void frmTable_Load(object sender, EventArgs e)
        {
            com.loadFormInfo("Add Tables", lblTitle);
            loadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!validData())
                return;
            getData();

            if (btnSave.Text == "&Save")
            {
                tbl.saveTable();
            }
            else if (btnSave.Text == "&Update")
            {
                tbl.updTable();
            }
            if (tbl.result)
            {
                clear();
                loadData();
            }

            com.showMessage(tbl.msg, lblMsg, tbl.msg_type, tmrMsg);
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
                return;

            operation = dgvData.Columns[e.ColumnIndex].Name;
            DataGridViewRow row = dgvData.Rows[e.RowIndex];
            tbl.id = Convert.ToInt64(row.Cells[clsTable.col_id].Value.ToString());

            if (operation == "Edit")
            {
                loadFields(row);
            }
            else if (operation == "Del")
            {
                if (com.delOption("Table"))
                {
                    tbl.delTable();

                    com.showMessage(tbl.msg, lblMsg, tbl.msg_type, tmrMsg);
                    if (tbl.result)
                    {
                        loadData();
                        clear();
                    }
                }
            }
        }
    }
}
