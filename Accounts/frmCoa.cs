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

namespace prjGrow.Accounts
{
    public partial class frmCoa : frmBaseGeneral
    {
        public frmCoa()
        {
            InitializeComponent();
        }

        Coa coa = new Coa();
        DataTable tblData = null;

        bool validData()
        {
            return true;
        }

        void getData()
        {
            coa.drBal = Convert.ToInt64(numBalDr.Value);
            coa.crBal = Convert.ToInt64(numBalCr.Value);
        }

        void loadData()
        {
            tblData = coa.getCoaData();
            dgvData.DataSource = tblData;
            com.hideColumns(dgvData, new string[]{Coa.col_acc_id});
        }

        void loadFields(DataGridViewRow row)
        {
            Control[] C =  new Control[]{ txtAccCode, txtAccName, numAccNo, numBalDr, numBalCr };
            string[] S = new string[]{ Coa.col_acc_code, Coa.col_acc_name, Coa.col_acc_no, Coa.col_dr_bal, Coa.col_cr_bal };
            com.loadFields(row, C, S, null, btnSaveUpd);
        }

        void clear()
        {
            Control[] C = new Control[] { txtAccCode, txtAccName, numAccNo, numBalDr, numBalCr};
            com.clearControls(C, null, btnSaveUpd);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void numBal_ValueChanged(object sender, EventArgs e)
        {
            if (numBalCr.Value > 0)
                numBalCr.Value = 0;
        }

        private void numBalCr_ValueChanged(object sender, EventArgs e)
        {
            if (numBalDr.Value > 0)
                numBalDr.Value = 0;
        }

        private void frmCoa_Load(object sender, EventArgs e)
        {
            com.loadFormInfo(this,"Chart of Account", lblClient, lblTitle);
            loadData();
        }

        private void btnSaveUpd_Click(object sender, EventArgs e)
        {
            if (!validData())
                return;
            getData();
            if (btnSaveUpd.Text == "&Update")
            {
                coa.updCoa();
            }
            if (coa.result)
            {
                clear();
                loadData();
            }
            com.showMessage(coa.msg, lblMsg, coa.msg_type, tmrMsg);
        }

        private void txtSrh_TextChanged(object sender, EventArgs e)
        {
            com.filterData(txtSrh.Text, "[" + Coa.col_acc_name + "]", dgvData, tblData);
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                clear();
                return;
            }
            string colName = dgvData.Columns[e.ColumnIndex].Name;
            loading = true;
            DataGridViewRow row = dgvData.Rows[e.RowIndex];
            coa.acc_id = Convert.ToInt64(row.Cells[Coa.col_acc_id].Value.ToString());
            if (colName == "Edit")
            {
                loadFields(row);
            }
            loading = false;
        }
    }
}