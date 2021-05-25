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

namespace prjGrow.Accounts
{
    public partial class frmEmpTran : frmBaseAccounts
    {
        public frmEmpTran()
        {
            InitializeComponent();
        }
        DataTable tblData = new DataTable();
        Emp_ledger empled = new Emp_ledger();
        DataTable tblEmp = null;

        void loadEmp()
        {
            tblEmp = empled.emp.getEmps();
            com.loadCombo(cmbAccName, tblEmp, Customer.col_name, Customer.col_id);
        }

        void loadData()
        {
            tblData = empled.getEmpledger(Convert.ToInt64(cmbAccName.SelectedValue));
            dgvData.DataSource = tblData;

            com.hideColumns(dgvData, new string[] { Emp_ledger.col_id,Emp_ledger.col_emp_id, Emp_ledger.col_tran_id, Emp_ledger.col_acc_id});
        }

        bool validData()
        {
            if (!com.chkValid(new Control[] { cmbAccName, dtpDate }, new string[] { "Employee", "Date" }))
                com.result = false;
            else if (!(com.chkNum(numAmt) || com.chkNum(numAdv) || com.chkNum(numAllocation) || com.chkNum(numDeduct)))
            {
                com.result = false;
                com.setMessage("Please enter advance or salary allocation or paid amount", Constants.message_info);
            }

            if (!com.result)
                com.showMessage(lblMsg,tmrMsg);
            return com.result;
        }

        void getData()
        {
            empled.date = dtpDate.Value;
            empled.emp_id = Convert.ToInt64(cmbAccName.SelectedValue);
            empled.remarks = txtRemarks.Text;
            empled.adv = Convert.ToInt64(numAdv.Value);
            empled.aloc = Convert.ToInt64(numAllocation.Value);
            empled.deduc = Convert.ToInt64(numDeduct.Value);
            empled.paid = Convert.ToInt64(numAmt.Value);
            empled.narration = cmbAccName.Text + " " + txtRemarks.Text;
        }
        void clear()
        {
            Control[] C = new Control[] { txtRemarks, numAmt, numAdv, numAllocation, numDeduct };
            com.clearControls(C, null, btnSaveUpd);
        }

        void loadFields(DataGridViewRow row)
        {
            Control[] C = new Control[] { dtpDate, txtRemarks };
            string[] S = new string[] { Emp_ledger.col_date, Emp_ledger.col_remarks};
            com.loadFields(row, C, S, null, btnSaveUpd);
        }

        private void frmEmpTran_Load(object sender, EventArgs e)
        {
            loading = true;
            com.loadFormInfo(this, "Employee Transaction", lblHead, lblTitle);          
            loadEmp();
            loading = false;
        }

        private void btnSaveUpd_Click(object sender, EventArgs e)
        {
            if (!validData())
                return;

            getData();
            if (btnSaveUpd.Text == "&Save")
            {
                empled.savEmpledger();
            }
            else if (btnSaveUpd.Text == "&Update")
            {
                empled.upEmpledger();
            }
            if (empled.result)
            {
                clear();
                loadData();
            }
            com.showMessage(empled.msg, lblMsg, empled.msg_type, tmrMsg);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            DataGridViewRow row = dgvData.Rows[e.RowIndex];
            empled.id = Convert.ToInt64(row.Cells[Emp_ledger.col_id].Value.ToString());
            empled.tran_id = Convert.ToInt64(row.Cells[Emp_ledger.col_tran_id].Value.ToString());
            operation = dgvData.Columns[e.ColumnIndex].Name;

            if (operation == "Edit")
            {
                loadFields(row);
            }
            else if (operation == "Delete")
            {
                if (com.delOption("Record"))
                {
                    empled.deleteTransaction("Emp_ledger");
                    com.showMessage(empled.msg, lblMsg, empled.msg_type, tmrMsg);

                    if (empled.result)
                    {
                        loadData();
                        clear();
                    }
                }
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmEmp emp = new frmEmp();
            emp.ShowDialog();
            loadEmp();
        }

        private void numAdv_ValueChanged(object sender, EventArgs e)
        {
            if (numAdv.Value > 0)
            {
                numAmt.Value = 0;
                numAllocation.Value = 0;
            }
        }

        private void numAllocation_ValueChanged(object sender, EventArgs e)
        {
            if (numAllocation.Value > 0)
            {
                numAdv.Value = 0;
                numAmt.Value = 0;
            }
        }

        private void numAmt_ValueChanged(object sender, EventArgs e)
        {
            if (numAmt.Value > 0)
            {
                numAdv.Value = 0;
                numAllocation.Value = 0;
            }
        }

        private void cmbAccName_SelectedValueChanged(object sender, EventArgs e)
        {
            if (com.chkCombo(cmbAccName) && !loading)
                loadData();
        }

        private void btnSalAloc_Click(object sender, EventArgs e)
        {
            if (!com.chkNull(txtRemarks, "Remarks"))
            {
                com.showMessage(lblMsg,tmrMsg);
                return;
            }
            getData();
            empled.allocateSalaries();

            com.showMessage(empled.msg, lblMsg, empled.msg_type, tmrMsg);
        }
    }
}