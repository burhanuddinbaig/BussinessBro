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
using prjGrow.Reporting;

namespace prjGrow.Accounts
{
    public partial class frmCustomerTran : frmBaseAccounts
    {
        public frmCustomerTran()
        {
            InitializeComponent();
        }

        DataTable tblData = null;
        DataTable tblCus = null;

        Cus_ledger cl = new Cus_ledger();


        bool validData()
        {
            bool isValid = false;
            Control[] C = new Control[] { dtpDate, cmbAccName, numAmt };
            string[] S = new string[] { "Date", "Customer", "Amount" };
            isValid = com.chkValid(C, S, lblMsg, tmrMsg);
            
         //       if(isValid && chkBank.Checked)
         //       isValid = com.chkValid[] {  }

            return isValid;
        }
        void loadCus()
        {
            tblCus = cl.cus.getCustomers();
            com.loadCombo(cmbAccName, tblCus, Customer.col_name, Customer.col_id);
        }
        void loadData()
        {
            if (loading)
                return;

            if (cmbAccName.SelectedIndex >= 0)
            {
                cl.cus_id = Convert.ToInt64(cmbAccName.SelectedValue.ToString());
                tblData = cl.getCusLedger();
                tblCus = cl.cus.getCustomers();
                dgvDataCus.DataSource = tblData;
                numBalance.Value = Convert.ToInt64(tblCus.Rows[cmbAccName.SelectedIndex][Customer.col_balance].ToString());
                com.hideColumns(dgvDataCus, new string[] { Cus_ledger.col_tran_id, Cus_ledger.col_id });
            }
        }
        void getData()
        {
            cl.cus_id = Convert.ToInt64(cmbAccName.SelectedValue);
            cl.date = dtpDate.Value;
            cl.remarks = txtRemarks.Text;
            cl.amount_recive = Convert.ToInt64(numAmt.Value);
            cl.narration = "Reciept by " + cmbAccName.Text + " " + cl.remarks;

            cl.by_cheq = chkCheq.Checked;
            
            cl.cheq.cheq_no = txtCheq.Text;
            cl.cheq.bnk_name = cmbBank.Text;
            cl.cheq.amt = Convert.ToInt64(numAmt.Value);
        }
        void clear()
        {
            Control[] C = new Control[] { dtpDate, numAmt, txtRemarks };
            com.clearControls(C, numAmt, btnSaveUpd);
        }
        void loadFields(DataGridViewRow row)
        {
            Control[] C = new Control[] { dtpDate, numAmt, txtRemarks };
            string[] S = new string[] { Cus_ledger.col_date, Cus_ledger.col_credit, Cus_ledger.col_remarks };
            com.loadFields(row, C, S, numAmt, btnSaveUpd);
        }
        private void frmCustomerTran_Load(object sender, EventArgs e)
        {
            loading = true;

            com.loadFormInfo(this, "Customer Transactions", lblHead, lblTitle);
            loadCus();

            loading = false;
        }
        private void btnSaveUpd_Click(object sender, EventArgs e)
        {
            if (!validData())
                return;
            getData();
            if (btnSaveUpd.Text == "&Save")
            {
                cl.saveCusLedger();
            }
            else if (btnSaveUpd.Text == "&Update")
            {
                cl.updateCusLedger();
            }
            if (cl.result)
            {
                clear();
                loadData();
            }
            com.showMessage(cl.msg, lblMsg, cl.msg_type, tmrMsg);
        }
        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void cmbAccName_SelectedValueChanged(object sender, EventArgs e)
        {
            loadData();
        }
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmCustomer frmCus = new frmCustomer();
            frmCus.ShowDialog();
            loadCus();
        }

        private void chkCheq_CheckedChanged(object sender, EventArgs e)
        {
            pnlBnk.Visible = chkCheq.Checked;
        }

        private void dgvDataCus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            DataGridViewRow row = dgvDataCus.Rows[e.RowIndex];
            cl.id = Convert.ToInt64(row.Cells[Cus_ledger.col_id].Value.ToString());
            cl.tran_id = Convert.ToInt64(row.Cells[Cus_ledger.col_tran_id].Value.ToString());
            operation = dgvDataCus.Columns[e.ColumnIndex].Name;

            if (cl.haveLinks("Sale"))
            {
                com.showMessage("Transaction cannot be updated or deleted from here", lblMsg, Constants.message_warning, tmrMsg);
                return;
            }

            if (operation == "Update")
            {
                loadFields(row);
            }
            else if (operation == "Del")
            {
                if (com.delOption("Customer Transaction"))
                {
                    cl.deleteTransaction("Cus_ledger");
                    com.showMessage(cl.msg, lblMsg, cl.msg_type, tmrMsg);

                    if (cl.result)
                    {
                        loadData();
                        clear();
                    }
                }
            }
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            frmSaleReceipt inv = new frmSaleReceipt();
            inv.sale.cus_id = Convert.ToInt64(cmbAccName.SelectedValue);
            inv.ShowDialog();
        }
    }
}