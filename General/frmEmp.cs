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
    public partial class frmEmp : frmBaseGeneral
    {
        public frmEmp()
        {
            InitializeComponent();
        }

        DataTable tblData = null;
        Employee emp = new Employee();

        void clear()
        {
            Control[] C = { txtEmpName, mtbCell, mtbCnic, numSal, txtAdrs, dtpJdate };
            com.clearControls(C, txtEmpName, btnSaveUpd);
            chkLeaved.Checked = false;
        }

        void loadData()
        {
            tblData = emp.getEmps();
            dgvData.DataSource = tblData;
            com.hideColumns(dgvData, new string[] { Employee.col_id, Employee.col_acc_id });
        }

        bool validData()
        {
            return com.chkValid(new Control[] { txtEmpName }, new string[] { "Employee Name" }, lblMsg, tmrMsg);
        }

        void getData()
        {
            emp.name = txtEmpName.Text;
            emp.acc_name = emp.name;
            emp.contact = mtbCell.Text;
            emp.cnic = mtbCnic.Text;
            emp.sal = Convert.ToInt64(numSal.Value);
            emp.adrs = txtAdrs.Text;
            emp.jdate = dtpJdate.Value;
            emp.ldate = dtpLdate.Value;
            emp.leaved = chkLeaved.Checked;
        }

        void loadFields(DataGridViewRow row)
        {
            bool active = string.IsNullOrEmpty(row.Cells[Employee.col_ldate].Value.ToString());
            Control[] C = active ? new Control[] { txtEmpName, mtbCell, mtbCnic, numSal, txtAdrs, dtpJdate } : new Control[] { txtEmpName, mtbCell, mtbCnic, numSal, txtAdrs, dtpJdate, dtpLdate };
            string[] S = active ? new string[] { Employee.col_name, Employee.col_contact, Employee.col_cnic, Employee.col_sal, Employee.col_adrs, Employee.col_jdate, Employee.col_ldate } : new string[] { Employee.col_name, Employee.col_contact, Employee.col_cnic, Employee.col_sal, Employee.col_adrs, Employee.col_jdate, Employee.col_ldate };
            com.loadFields(row, C, S, txtEmpName, btnSaveUpd);
            chkLeaved.Checked = !active;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
            loadData();
        }

        private void btnSaveUpd_Click(object sender, EventArgs e)
        {
            if (!validData())
                return;
            getData();

            if (btnSaveUpd.Text == "&Save")
            {
                emp.saveEmp();
            }
            else if (btnSaveUpd.Text == "&Update")
            {
                emp.updEmp();
            }
            if (emp.result)
            {
                loadData();
                clear();
                if (close_on_save)
                    this.Close();
            }
            com.showMessage(emp.msg, lblMsg, emp.msg_type, tmrMsg);
        }

        private void txtSrh_TextChanged(object sender, EventArgs e)
        {
            com.filterData(txtSrh.Text, Customer.col_name, dgvData, tblData);
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            DataGridViewRow row = dgvData.Rows[e.RowIndex];
            emp.id = Convert.ToInt64(row.Cells[Employee.col_id].Value.ToString());
            emp.acc_id = emp.getAccId("Employee", emp.id);
            operation = dgvData.Columns[e.ColumnIndex].Name;

            if (operation == "Edit")
            {
                loadFields(row);
            }
            else if (operation == "Delete")
            {
                if (com.delOption("Employee"))
                {
                    if (emp.haveEntries())
                    {
                        emp.setMessage("Employee have Entries", Constants.message_warning);
                        emp.result = false;
                        return;
                    }
                    emp.deleteAcc("Employee");
                    com.showMessage(emp.msg, lblMsg, emp.msg_type, tmrMsg);
                    if (emp.result)
                    {
                        loadData();
                        clear();
                    }
                }
            }
        }

        private void frmEmp_Load(object sender, EventArgs e)
        {
            com.loadFormInfo(this,"Employee", lblClient, lblTitle);
            loadData();
        }

        private void chkLeaved_CheckedChanged(object sender, EventArgs e)
        {
            pnlLeaving.Visible = chkLeaved.Checked;
        }
    }
}