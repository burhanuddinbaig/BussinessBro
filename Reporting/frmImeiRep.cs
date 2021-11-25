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
    public partial class frmImeiRep : frmBaseReportSimple
    {
        public frmImeiRep()
        {
            InitializeComponent();
        }

        public Imei objImei = new Imei();
        bool exists = true;
        void showImeiData()
        {
            objImei.tblTempTable = objImei.getIMEIsForSearch(txtIMEI.Text.Trim().ToString());

            if (objImei.tblTempTable.Rows.Count > 0)
            {
                dgvData.DataSource = objImei.tblTempTable;
                txtIMEI.Text = string.Empty;
            }
           // com.hideColumns(dgvData, new string[] { Imei.col_Sr, Imei.col_prod_id });
        }
     
        bool validData()
        {
            if (!com.chkNull(txtIMEI, "IMEI"))
            {
                exists = false;
                com.setMessage("Enter IMEI", Constants.message_info);
                com.showMessage(lblMsg, tmrMsg);
                dgvData.DataSource = null;
            }          
            else if ( !(objImei.db.dataExist("IMEI", new[] {  "imei", "dr" }, new[] { '=', '>' }, new[] { "'" + txtIMEI.Text.Trim() + "'", "0" })))
            {
                exists = false;
                com.setMessage("There is no any IMEI", Constants.message_info);
                com.showMessage(lblMsg, tmrMsg);
                dgvData.DataSource = null;
            }
            else
            {
                exists = true;
            }
            return exists;
        }

        private void txtIMEI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!validData())
                    return;
                showImeiData();
                txtIMEI.Focus();
            }
        }

        private void frmImeiRep_Load(object sender, EventArgs e)
        {
            com.loadFormInfo(this, "IMEI Search", lblTitle);
            txtIMEI.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            dgvData.DataSource = null;
            txtIMEI.Text = string.Empty;
            txtIMEI.Focus();
        }

        private void txtIMEI_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
