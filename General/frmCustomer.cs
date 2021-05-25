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
    public partial class frmCustomer : frmBaseGeneral
    {
        public frmCustomer()
        {
            InitializeComponent();
        }

        Customer cus = new Customer();
        public const string col_id = "Id", col_name = "Name", col_contact = "Contact", col_cnic = "CNIC", col_adrs = "Address";
        DataTable tblData = null;

        void customize()
        {
            pnlChestNo.Visible = Custom.client_id_active == 6;
        }

        void loadData()
        {
            tblData = cus.getCustomers();
            dgvData.DataSource = tblData;
            com.hideColumns(dgvData, new string[]{ col_id, Customer.col_chassis, Customer.col_balance});
            if (Custom.client_id_active == 6)
                com.showColumns(dgvData, new string[]{ Customer.col_chassis });

        }

        bool validData()
        {
            return com.chkValid(new Control[]{txtName},new string[]{"Customer Name"}, lblMsg, tmrMsg);
        }

        void getData()
        {
            cus.name = txtName.Text;
            cus.acc_name = cus.name;
            cus.contact = txtContact.Text;
            cus.cnic = mtbCnic.Text;
            cus.adrs = txtAdrs.Text;
            cus.chest_no = txtChestNo.Text;
        }

        void clear()
        {
            Control[] C = new Control[] { txtName, txtContact, mtbCnic, txtAdrs, txtChestNo };
            com.clearControls(C, txtName, btnSaveUpd);
        }

        void loadFields(DataGridViewRow row)
        {
            Control[] C = new Control[] { txtName, txtContact, mtbCnic, txtAdrs, txtChestNo };
            string[] S = new string[] { Customer.col_name, Customer.col_contact, Customer.col_cnic, Customer.col_adrs, Customer.col_chassis };
            com.loadFields(row, C, S, txtName, btnSaveUpd);
        }

        private void frmClient_Load(object sender, EventArgs e)
        {
            customize();
            loadData();
            com.loadFormInfo(this, "Customer Information", lblClient, lblTitle);
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
            cus.id = Convert.ToInt64(row.Cells[Customer.col_id].Value.ToString());
            cus.acc_id = cus.getAccId("Customer",cus.id);

            operation = dgvData.Columns[e.ColumnIndex].Name;

            if (operation == "Edit")
            {
                loadFields(row);
            }
            else if (operation == "Delete")
            {
                if (cus.haveEntries())
                {
                    cus.setMessage("Customer have Entries", Constants.message_warning);
                    cus.result = false;
                    return;
                }

                if (com.delOption("Customer"))
                {
                    cus.deleteAcc("Customer");

                    com.showMessage(cus.msg, lblMsg, cus.msg_type, tmrMsg);
                    if (cus.result)
                    {
                        loadData();
                        clear();
                    }
                }
            }
        }

        private void btnSaveUpd_Click(object sender, EventArgs e)
        {
            if (!validData())
                return;
            getData();

            if (btnSaveUpd.Text == "&Save")
            {
                cus.saveCustomer();
            }
            else if (btnSaveUpd.Text == "&Update")
            {
                cus.updateCustomer();
            }
            if (cus.result)
            {
                loadData();
                clear();
            }
            com.showMessage(cus.msg, lblMsg, cus.msg_type, tmrMsg);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}