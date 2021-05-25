using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using prjGrow.Classes;

namespace prjGrow.Reporting
{
    public partial class frmEmpLed :  Reporting.frmBaseReport
    {
        public frmEmpLed()
        {
            InitializeComponent();
        }

        DataTable tblEmp = null;
        Emp_ledger el = new Emp_ledger();
        Account_cycle acc = new Account_cycle();
        frmDisplayRep display = new frmDisplayRep("Employee Ledger");

        void getData()
        {
            acc.emp_id = Convert.ToInt64(cmbEmp.SelectedValue);
            if (rbAll.Checked)
            {
                acc.year = 0;
                acc.month = 0;
            }
            else if(rbYear.Checked)
            {
                acc.year = Convert.ToInt32(numYear.Value);
                acc.month = 0;
            }
            else if (rbMonth.Checked)
            {
                acc.year = Convert.ToInt32(numYear.Value);
                acc.month = Convert.ToInt16(cmbMonth.SelectedIndex + 1);
            }
        }

        void loadEmp()
        {
            tblEmp = el.emp.getEmps();
            com.loadCombo(cmbEmp, tblEmp, Customer.col_name, Customer.col_id);
        }

        private void frmEmpLed_Load(object sender, EventArgs e)
        {
            com.loadFormInfo(this, "Employee Ledger", lblTitle);
            loadEmp();
            rbYear.Checked = true;
            rbDaily.Visible = false;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (!com.chkCombo(cmbEmp, "Employee"))
                return;
            getData();
            acc.empLedger();

            display.rep = acc.getReport("repEmpLedger.rpt");
            display.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
