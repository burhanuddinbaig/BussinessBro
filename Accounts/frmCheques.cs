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
    public partial class frmCheques : frmBaseGeneral
    {
        public frmCheques()
        {
            InitializeComponent();
        }

        DataTable tblData = new DataTable();
        Cheque cheq = new Cheque();

        public void loadPayCheques()
        {
            cheq.progress = rbPending.Checked ? Constants.cheq_status_pending : Constants.cheq_status_processed;
            tblData = cheq.getPayCheques();
            dgvData.DataSource = tblData;
            com.hideColumns(dgvData, new string[] { Cheque.col_id, Cheque.col_type_id, Cheque.col_bnk_id, "Cash" });
        }

        private void frmChequeHis_Load(object sender, EventArgs e)
        {
            com.loadFormInfo(this, "Cheques History", lblClient, lblTitle);
            loadPayCheques();
        }

        private void rbPending_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
