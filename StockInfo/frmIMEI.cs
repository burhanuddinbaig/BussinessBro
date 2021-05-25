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

namespace prjGrow.StockInfo
{
    public partial class frmIMEI : Form
    {
        public frmIMEI()
        {
            InitializeComponent();
        }
        public Imei objImei = new Imei();
        string operation = "";
        Common com = new Common();
        public int counter = 0;
        bool exists = true;
        public long prod_id = 0;
        public bool fromSale = false;
        public bool toReturn = false;
        
        private void frmIMEI_Load(object sender, EventArgs e)
        {
            if (objImei.tblTempTable != null)
                showTempData();
            txtIMEI.Focus();
        }
        
        void showTempData()
        {
            dgvData.DataSource = objImei.tblTempTable;
            if (objImei.tblTempTable.Rows.Count > 0)
            {
                com.filterValue(prod_id.ToString(), Imei.col_prod_id, dgvData, objImei.tblTempTable);
                dgvData.Sort(dgvData.Columns[1], ListSortDirection.Descending);
                if (toReturn)
                    counter = dgvData.Rows.GetRowCount(DataGridViewElementStates.Visible);
            }
            com.hideColumns(dgvData, new string[] { Imei.col_Sr, Imei.col_id, Imei.col_prod_id, Imei.col_tran_id});
        }
        
        bool validData()
        {
            if (!com.chkNull(txtIMEI, "IMEI"))
            {
                exists = false;
                this.Text = "Enter IMEI";
            }
            else if (!toReturn && objImei.tblTempTable.Rows.Count > 0 && com.DataExists(txtIMEI.Text, Imei.col_imei, objImei.tblTempTable))
            {
                exists = false;
                this.Text = "IMEI already exists!";
            }
            else if (fromSale && !(objImei.db.dataExistIMEIs(prod_id.ToString(), txtIMEI.Text.Trim())))
            {
                exists = false;
                this.Text = "It's already sold!";
            }
            else if (fromSale && !(objImei.db.dataExist("IMEI", new[] { "prod_id", "imei", "dr" }, new[] { '=', '=', '>' }, new[] { prod_id.ToString(), "'" + txtIMEI.Text.Trim() + "'", "0" })))
            {
                exists = false;
                this.Text = "There is no such mobie";
            }
            else
            {
                this.Text = "";
                exists = true;
            }
            return exists;
        }
        public void createTempTable()
        {
            objImei.tblTempTable = new DataTable();
            objImei.tblTempTable.Columns.Add(Imei.col_Sr, typeof(long));
            objImei.tblTempTable.Columns.Add(Imei.col_prod_id, typeof(long));
            objImei.tblTempTable.Columns.Add(Imei.col_imei, typeof(string));
        }

        void addToTempTable()
        {
            if (objImei.tblTempTable.Rows.Count <= 0)
                createTempTable();

            DataRow row = objImei.tblTempTable.NewRow();
            row[Imei.col_Sr] = counter = counter + 1;
            row[Imei.col_prod_id] = prod_id;
            row[Imei.col_imei] = txtIMEI.Text.Trim();

            objImei.tblTempTable.Rows.Add(row);
            showTempData();
        }

        void removeFromTmpTable()
        {
            string tmpCode = txtIMEI.Text;
            foreach (DataGridViewRow row in dgvData.Rows)
            {
                if (row.Cells[Imei.col_imei].Value.ToString() == tmpCode)
                {
                    dgvData.Rows.RemoveAt(row.Index);
                    counter--;
                }
            }
        }
      
        private void txtIMEI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!validData())
                    return;
                if (toReturn)
                    removeFromTmpTable();
                else
                    addToTempTable();
                txtIMEI.Text = string.Empty;
                txtIMEI.Focus();
            }
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            DataGridViewRow row = dgvData.Rows[e.RowIndex];
            objImei.imei = row.Cells[Imei.col_imei].Value.ToString();
            operation = dgvData.Columns[e.ColumnIndex].Name;

            if (operation == "Remove")
            {
                if (com.delOption("Record"))
                {
                    if (e.ColumnIndex == 0)
                    {
                        dgvData.Rows.RemoveAt(e.RowIndex);
                        if (toReturn)
                            counter--;
                    }
                    frmIMEI.ActiveForm.Text = "Successfully removed";
                }
                else frmIMEI.ActiveForm.Text = "";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text == "OK")
            {
               // objImei.saveIMEI();
                this.Hide();
            }
        }

        private void dgvData_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            dgvData.EndEdit(DataGridViewDataErrorContexts.RowDeletion);
            if (dgvData.DataSource.GetType() == typeof(DataView))
                objImei.tblTempTable = ((DataView)dgvData.DataSource).ToTable();
            else if(dgvData.DataSource.GetType() == typeof(DataTable))
                objImei.tblTempTable = (DataTable)dgvData.DataSource;
        }
    }
}