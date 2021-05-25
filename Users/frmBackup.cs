using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using prjGrow.Reporting;
using prjGrow.Classes;

namespace prjGrow.Users
{
    public partial class frmBackup : frmBaseReportSimple
    {
        public frmBackup()
        {
            InitializeComponent();
        }

        string drive = "D:\\";
        string folder = "dbBackup\\";
        clsDb db = new clsDb();
        bool result = false;

        void setPath()
        {
            switch (Custom.client_id_active)
            { 
                case 1: //malik steel
                    break;
                case 2: //alkarim Bakers
                    drive = "E:\\";
                    break;
                case 3: //dubai mobiles
                    break;
            }
            db.pathBackup = drive + folder;
        }

        private void frmBackup_Load(object sender, EventArgs e)
        {
            com.loadFormInfo("Database Backup", lblTitle);
            setPath();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            result = db.dbBackup();
            if (result)
            {
                com.showMessage("Database Backup Successfull", lblMsg, Constants.message_success, tmrMsg);
                btnCancel.Focus();
                btnExit.Enabled = true;
            }
            else
                com.showMessage("Backup Interupted", lblMsg, Constants.message_error, tmrMsg);
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
