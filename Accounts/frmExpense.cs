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
    public partial class frmExpense : frmBaseAccounts
    {
        public frmExpense()
        {
            InitializeComponent();
        }

        Expense exp = new Expense();
        Exp_type type = new Exp_type();
        
        DataTable tblData = null;
        DataTable tblExpTypes = null;

        void loadData()
        {
            tblData = exp.getExpense();
            dgvData.DataSource = tblData;

            com.hideColumns(dgvData, new string[]{ Expense.col_id, Expense.col_tran_id, Expense.col_type_id });
        }

        void loadTypes()
        {
            tblExpTypes = type.getExpTypes();
            com.loadCombo(cmbAccName, tblExpTypes, Exp_type.col_name, Exp_type.col_id);
        }

        void getData()
        {
            exp.date = dtpDate.Value;
            exp.type_id = Convert.ToInt64(cmbAccName.SelectedValue);
            exp.amount = Convert.ToInt64(numAmt.Value);
            exp.remarks = txtRemarks.Text;
            exp.narration = "Expense: " + cmbAccName.Text + " " + exp.remarks;
            exp.reference = txtRef.Text;
        }

        void clear()
        {
            Control[] C = new Control[] { dtpDate, cmbAccName, numAmt, txtRemarks };
            com.clearControls(C, numAmt, btnSaveUpd);
        }

        void loadFields(DataGridViewRow row)
        {
            Control[] C = new Control[] { dtpDate, cmbAccName, numAmt, txtRemarks };
            string[] S = new string[] { Expense.col_date, Expense.col_type_id, Expense.col_amount, Expense.col_remarks };

            com.loadFields(row,C, S);
            exp.id = Convert.ToInt64(row.Cells[Expense.col_id].Value);
            btnSaveUpd.Text = "&Update";
        }

        bool validData()
        {
            Control[] C = new Control[] { dtpDate, cmbAccName, numAmt };
            string[] S =  new string[] { Expense.col_date, Expense.col_exp_type, Expense.col_amount };
            bool res = com.chkValid( C, S, lblMsg, tmrMsg);
            return res;
        }

        private void frmExpense_Load(object sender, EventArgs e)
        {
            loadData();
            loadTypes();
            com.loadFormInfo( this, "Expense", lblHead, lblTitle );
        }

        private void btnSaveUpd_Click(object sender, EventArgs e)
        {
            if (!validData())
                return;
            getData();

            if (btnSaveUpd.Text == "&Save")
            {
                exp.saveExpense();
            }
            else if (btnSaveUpd.Text == "&Update")
            {
                exp.updateExpense();
            }
            if (exp.result)
            {
                loadData();
                clear();
            }

            com.showMessage(exp.msg, lblMsg, exp.msg_type, tmrMsg);
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            DataGridViewRow row = dgvData.Rows[e.RowIndex];
            exp.id = Convert.ToInt64(row.Cells[Expense.col_id].Value.ToString());

            if (dgvData.Columns[e.ColumnIndex].Name == "Edit")
            {
                loadFields(row);
            }
            else if (dgvData.Columns[e.ColumnIndex].Name == "Delete")
            {
                if (com.delOption("Expense"))
                {
                    exp.deleteExpense();
                    com.showMessage(exp.msg, lblMsg, exp.msg_type, tmrMsg);
                    if (exp.result)
                    {
                        loadData();
                        clear();
                    }
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmExpType etype = new frmExpType();
            etype.ShowDialog();
            loadTypes();
        }
    }
}