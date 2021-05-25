using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using prjGrow.Classes;
using prjGrow.General.ClientDSTableAdapters;

namespace prjGrow.General
{
    public partial class frmAddClient : frmBaseGeneral
    {
        Common cmn = new Common();
        Client clnt = new Client();
        ClientDS clDS = new ClientDS();
        ClientTableAdapter objClTA = new ClientTableAdapter();
        DataTable tblAsset = null;
        byte[] picInBytes = null;
        public frmAddClient()
        {
            InitializeComponent();
        }
        private void frmAddClient_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            //To where your opendialog box get starting location. My initial directory location is desktop.
            openFileDialogLogo.InitialDirectory = "C://Desktop";
            //Your opendialog box title name.
            openFileDialogLogo.Title = "Select file to be upload.";
            //which type file format you want to upload in database. just add them.
            openFileDialogLogo.Filter = "Select Valid Document(*.jpeg; |*.jpg; | *.png; |*.bmp)";
            //FilterIndex property represents the index of the filter currently selected in the file dialog box.
            openFileDialogLogo.FilterIndex = 1;
            try
            {
                if (openFileDialogLogo.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (openFileDialogLogo.CheckFileExists )
                    {
                        if (CheckSizeOfPic())
                        {
                            string path = System.IO.Path.GetFullPath(openFileDialogLogo.FileName);
                            label1.Text = path;
                            pictureBoxLogo.Image = Image.FromFile(path);
                        }
                        else
                        {
                            cmn.showMessage(lblMsg, tmrMsg);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Select Logo.");
                    }
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private byte[] ConvertImage()
        {

            FileInfo objFileInfo = new FileInfo(label1.Text);
            long m_lImageFileLength = objFileInfo.Length;
            byte[] m_barrImg = new byte[Convert.ToInt32(m_lImageFileLength)];
            FileStream fs = new FileStream(label1.Text, FileMode.Open, FileAccess.Read, FileShare.Read);
            int iBytesRead = fs.Read(m_barrImg, 0, Convert.ToInt32(m_lImageFileLength));
            fs.Flush();
            fs.Close();
            return m_barrImg;

        }
        private void getData()
        {
            clnt.full_name = txtClientFullName.Text.Trim();
            clnt.short_name = txtShortName.Text.Trim();
            clnt.adrs = txtAddress.Text.Trim();
            clnt.cell = txtCell.Text.Trim();
            clnt.phone = txtPhone.Text.Trim();
            clnt.email = txtemail.Text.Trim();
            clnt.status = chkBoxStatus.Checked == true ? 1 : 0;
            clnt.qoute = txtQuote.Text.Trim();
            byte[] picInBytes = (byte[])ConvertImage();
            clnt.logo = picInBytes;
         

        }
        private bool CheckSizeOfPic()
        {
            // Here 1024 bytes = 1 kilobyte.
            FileInfo objFileInfo = new FileInfo(openFileDialogLogo.FileName);
            long m_lImageFileLength = objFileInfo.Length;
           
            if (m_lImageFileLength < 1024 * 100)
            {
                return true;
            }
            else
            {
                clnt.setMessage("Client Information", "Over Size Logo");
                return false;
            }
        }
      
        private void btnSaveUpd_Click(object sender, EventArgs e)
        {
            if (!validData())
                return;
            byte stat = (chkBoxStatus.Checked == true ? Convert.ToByte(1) : Convert.ToByte(0));
            if(label1.Text!="")
                  picInBytes = (byte[])ConvertImage();
            if (btnSaveUpd.Text == "&Save")
            {
                objClTA.InsertQuery(txtClientFullName.Text, txtShortName.Text, txtAddress.Text, txtCell.Text, txtPhone.Text, txtemail.Text, stat, txtQuote.Text, picInBytes);
                clnt.setMessage("Client Information", "Saved");
            }
            else if (btnSaveUpd.Text == "&Update")
            {
                objClTA.UpdateQuery(txtClientFullName.Text, txtShortName.Text, txtAddress.Text, txtCell.Text, txtPhone.Text, txtemail.Text, stat, txtQuote.Text, picInBytes, clnt.id);
                clnt.setMessage("Client Information", "Updated");
            }
            cmn.showMessage(lblMsg, tmrMsg);
            LoadData();
            if (label1.Text != "")
                pictureBoxLogo.Image.Dispose();
            clearAll();
        }
        bool validData()
        {
            return com.chkValid(new Control[] { txtClientFullName, txtShortName, txtAddress, txtCell }, new string[] { "Full Name", "Short Name", "Address", "Cell" }, lblMsg, tmrMsg);
        }
      
        private void LoadData()
        {
            tblAsset = clnt.getClients();
            dgvData.DataSource = tblAsset;
            com.hideColumns(dgvData, new string[] { "logo" });
      
        }
        private void clearAll()
        {
          
            txtAddress.Text = string.Empty;
            txtCell.Text = string.Empty;
            txtClientFullName.Text = string.Empty;
            txtemail.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtQuote.Text = string.Empty;
            txtShortName.Text = string.Empty;
        }
        void loadFields(DataGridViewRow row)
        {
            Control[] C = new Control[] { txtClientFullName, txtShortName, txtAddress, txtCell, txtPhone, txtemail, txtQuote };
            string[] S = new string[] { Client.col_name, Client.col_sname, Client.col_adrs, Client.col_cell, Client.col_contact, Client.col_email, Client.col_quote};
            com.loadFields(row, C, S, txtClientFullName, btnSaveUpd);
        }
        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
                return;

            string colName = dgvData.Columns[e.ColumnIndex].Name;
            DataGridViewRow row = dgvData.Rows[e.RowIndex];
            clnt.id = Convert.ToInt32(row.Cells[Client.col_id].Value.ToString());

            if (colName == "Edit")
            {
                loadFields(row);
            }
            else if (colName == "Delete")
            {
                if (com.delOption("Client"))
                {
                    objClTA.DeleteQuery(clnt.id);
                    com.showMessage(clnt.msg, lblMsg, clnt.msg_type, tmrMsg);
                    LoadData();
                }
            }
        }
    }
}
