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
    public partial class frmSaleReceipt : frmBaseReportSimple
    {

        public Sale sale = new Sale();
        public Customer cus = new Customer();
        DataTable tblCus = null;
        DataTable tblGrid = null;

        public frmSaleReceipt()
        {
            InitializeComponent();
        }

        private void frmSaleReceipt_Load(object sender, EventArgs e)
        {
            loading = true;
            com.loadFormInfo(this, "Search and Print Sales Receipt", lblTitle);     
            loadCustomers();
            loadCus();
            loading = false;
        }
       
        void loadCustomers()
        {
            tblCus = cus.getCustomers();
            com.loadCombo(cmbClient, tblCus, Customer.col_name, Customer.col_id);
        }

        void loadCus()
        {
            if (sale.cus_id > 0)
            {
                cmbClient.SelectedValue = sale.cus_id;
                ShowData();
            }
        }
        
        void ShowData()
        {
            tblGrid = sale.getSalesReceipts(sale.cus_id);
            if (tblGrid.Rows.Count > 0)
            {
                dgvData.DataSource = tblGrid;
            }
            com.hideColumns(dgvData, new string[] { Sale.col_cus_id, Sale.col_tran_id });
        }
        
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (numInvoiceNo.Value != 0)
            {
                sale.getAccIds();
                sale.showBill();
                numInvoiceNo.Value = 0;
            }
            else
            {
                com.setMessage("Select Bill", Constants.message_info);
                com.showMessage(lblMsg, tmrMsg);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.numInvoiceNo.Value = 0;
            this.Close();
        }

        private void numInvoiceNo_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loading)
                return;
            sale.cus_id = Convert.ToInt64(cmbClient.SelectedValue);
            ShowData();
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            loading = true;
            if (dgvData.Columns[e.ColumnIndex].Name == "Bill_No")
            {
                numInvoiceNo.Value = Convert.ToInt64(dgvData.Rows[e.RowIndex].Cells["Bill_No"].Value.ToString());
                sale.tran_id = Convert.ToInt64(dgvData.Rows[e.RowIndex].Cells["tran_id"].Value.ToString());
            }
            loading = false;
        }
    }
}
