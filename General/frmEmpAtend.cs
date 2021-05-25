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
    public partial class frmEmpAtend : frmBaseGeneral
    {
        public frmEmpAtend()
        {
            InitializeComponent();
        }

        DataTable tblData = new DataTable();
        DataTable tblEmp = new DataTable();
        Emp_atend atd = new Emp_atend();
        Employee emp = new Employee();

        bool validData()
        {
            bool result = true;

            if (!com.chkValid(new Control[] { cmbName, cmbStat }, new string[] { "Employee Name", "Present or Absant" }, lblMsg, tmrMsg))
                result = false;
            else if (com.DataExists(cmbName.Text, Emp_atend.col_emp_name, tblData))
            {
                com.setMessage("Sorry, Atendance Already Exists", Constants.message_info);
                result = false;
            }

            if (!result)
                com.showMessage(lblMsg,tmrMsg);

            return result;
        }

        void loadData()
        {
            atd.date = dtpDate.Value;
            tblData = atd.getAtend();
            dgvData.DataSource = tblData;
            com.hideColumns(dgvData, new string[] { Emp_atend.col_id, Emp_atend.col_emp_id, Emp_atend.col_date });
        }

        void loadEmps()
        {
            tblEmp = emp.getEmps();
            com.loadCombo(cmbName, tblEmp, Employee.col_name, Employee.col_id);
        }

        void getData()
        {
            atd.date = dtpDate.Value;
            atd.emp_id = Convert.ToInt64(cmbName.SelectedValue.ToString());
            atd.present = cmbStat.Text[0];
        }

        void loadFields(DataGridViewRow row)
        {
            Control[] C = new Control[] { cmbName};
            string[] S = new string[] { Emp_atend.col_emp_id};
            com.loadFields(row, C, S, cmbStat, btnSaveUpd);
        }

        void clear()
        {
            Control[] C = new Control[] { cmbName, dtpDate };
            com.clearControls(C, cmbName, btnSaveUpd);
        }

        void setFocus()
        {
            if (cmbName.SelectedIndex < cmbName.Items.Count - 1)
                cmbName.SelectedIndex++;
            cmbStat.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void frmEmpAtend_Load(object sender, EventArgs e)
        {
            com.loadFormInfo(this,"Employee Atendance", lblClient, lblTitle);
            loadEmps();
            loadData();
            setFocus();
        }

        private void btnSaveUpd_Click(object sender, EventArgs e)
        {
            if (!validData())
                return;
            getData();

            if (btnSaveUpd.Text == "&Save")
            {
                atd.saveAtend();
            }
            else if (btnSaveUpd.Text == "&Update")
            {
                atd.updAtend();
            }
            if (atd.result)
            {
                loadData();
                setFocus();
            }
            com.showMessage(atd.msg, lblMsg, atd.msg_type, tmrMsg);
        }

        private void dgData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            DataGridViewRow row = dgvData.Rows[e.RowIndex];
            atd.id = Convert.ToInt64(row.Cells[Emp_atend.col_id].Value.ToString());

            operation = dgvData.Columns[e.ColumnIndex].Name;

            if (operation == "Edit")
            {
                loadFields(row);
            }
            else if (operation == "Delete")
            {
                if (com.delOption("Atendance"))
                {
                    atd.delAtend();

                    com.showMessage(atd.msg, lblMsg, atd.msg_type, tmrMsg);
                    if (atd.result)
                    {
                        loadData();
                        clear();
                    }
                }
            }
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            dtpDate.Enabled = false;

            atd.date = dtpDate.Value;
            loadData();
            cmbName.SelectedIndex = 0;
            dtpDate.Enabled = true;
            dtpDate.Focus();
        }

        private void cmbStat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btnSaveUpd_Click(sender, e);
        }
    }
}