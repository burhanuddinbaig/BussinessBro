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

namespace prjGrow.Manufacture
{
    public partial class frmLabour : frmBaseSimple
    {
        public frmLabour()
        {
            InitializeComponent();
        }

        public bool fromReview = false;
        public DataTable tblLabour = new DataTable();
        DataTable tblEmp = null;
        Employee emp = new Employee();
        public long serv_amt = 0;

        long emp_id = 0;
        long acc_id = 0;
        string e_name = "";
        long amount = 0;

        void createTable()
        {
            if (tblLabour == null || tblLabour.Rows.Count <= 0)
            {
                tblLabour = new DataTable();
                DataColumn[] Cols = new DataColumn[] {
                    new DataColumn(Processing.col_emp_id, typeof(long)),
                    new DataColumn(Processing.col_acc_id, typeof(long)), 
                    new DataColumn(Processing.col_emp_name, typeof(string)), 
                    new DataColumn(Processing.col_amount, typeof(long))};
                tblLabour.Columns.AddRange(Cols);
                dgvData.DataSource = tblLabour;
                com.hideColumns(dgvData, new string[] { Processing.col_emp_id, Processing.col_acc_id, Processing.col_tran_id });
            }
        }

        public void clear()
        {
            Control[] C = new Control[] { cmbEmp, numAmount };
            com.clearControls(C, cmbEmp, null);
        }

        public bool validEmp()
        {
            bool res = true;
            res = com.chkValid(new Control[]{cmbEmp, numAmount}, new string[]{"Employee Name", "Amount"}, lblMsg, tmrMsg);
            if (res && tblLabour.Rows.Count > 0)
                res = !com.DataExists(cmbEmp.Text, Processing.col_emp_name, tblLabour);
            return res;
        }

        public void loadEmps()
        {
            tblEmp = emp.getEmps();
            com.loadCombo(cmbEmp, tblEmp, Employee.col_name, Employee.col_id);
        }

        public void addEmp()
        {
            if (!validEmp())
                return;
            emp_id = Convert.ToInt64(cmbEmp.SelectedValue);
            acc_id = Convert.ToInt64((tblEmp.Rows[cmbEmp.SelectedIndex][Employee.col_acc_id].ToString()));
            e_name = cmbEmp.Text;
            amount = Convert.ToInt64(numAmount.Value);
            tblLabour.Rows.Add(emp_id, acc_id, e_name, amount);
            clear();
        }

        public void loadData()
        {
            dgvData.DataSource = tblLabour;
            com.hideColumns(dgvData, new string [] { Processing.col_emp_id, Processing.col_id, Processing.col_acc_id, Processing.col_tran_id });
        }

        public void loadServAmt()
        {
            if (serv_amt > 0)
                lblServ.Text = serv_amt + "";
            else
                lblServ.Text = "000";

            if (tblLabour.Rows.Count <= 0)
                numAmount.Value = serv_amt;
        }

        private void frmLabour_Load(object sender, EventArgs e)
        {
            createTable();
            com.loadFormInfo(this, "Service Charges", lblTitle);
            loadEmps();
            if (fromReview)
                loadData();
            loadServAmt();
        }

        private void btnSaveUpd_Click(object sender, EventArgs e)
        {
            addEmp();
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
                return;
            if (dgvData.Columns[e.ColumnIndex].Name == "Remove")
            {
                tblLabour.Rows.RemoveAt(e.RowIndex);
                dgvData.DataSource = tblLabour;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}