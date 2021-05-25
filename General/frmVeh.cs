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
    public partial class frmVeh : frmBaseSimple
    {
        public frmVeh()
        {
            InitializeComponent();
        }

        Vehicle veh = new Vehicle();
        DataTable tblData = new DataTable();

        void clear()
        {
            Control[] C = new Control[] { txtPlateno, txtVehName };
            com.clearControls(C, txtVehName, btnSaveUpd);
        }

        void getData()
        {
            veh.veh_name = txtVehName.Text;
            veh.plate_no = txtPlateno.Text;

            veh.termin.title = veh.veh_name;
        }

        void loadData()
        {
            tblData = veh.getVehicles();
            dgvData.DataSource = tblData;
            com.hideColumns(dgvData, new string[] { Vehicle.col_veh_id, Vehicle.col_term_id });
        }

        void loadFields(DataGridViewRow row)
        {
            Control[] C = new Control[] { txtVehName, txtPlateno };
            string[] S = new string[] { Vehicle.col_veh_name, Vehicle.col_plate_no };
            com.loadFields(row, C, S, txtVehName, btnSaveUpd);
        }

        bool validData()
        {
            return com.chkValid(new Control[]{txtVehName}, new string[] {"Vehicle Name"}, lblMsg, tmrMsg);
        }

        private void frmVeh_Load(object sender, EventArgs e)
        {
            loading = true;
            com.loadFormInfo(this, "Vehicle Info", lblClient, lblTitle);
            loadData();
            loading = false;
        }

        private void btnSaveUpd_Click(object sender, EventArgs e)
        {
            if (!validData())
                return;

            getData();
            operation = btnSaveUpd.Text;

            if (operation == "&Save")
            {
                veh.saveVeh();
            }
            else if (operation == "&Update")
            {
                veh.updVeh();
            }

            if (veh.result)
            {
                clear();
                loadData();
                if (close_on_save)
                    this.Close();
            }

            com.showMessage(veh.msg, lblMsg, veh.msg_type, tmrMsg);
        }

        private void dgData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            DataGridViewRow row = dgvData.Rows[e.RowIndex];
            veh.id = Convert.ToInt64(row.Cells[Vehicle.col_veh_id].Value.ToString());
            veh.term_id = Convert.ToInt64(row.Cells[Vehicle.col_term_id].Value.ToString());

            operation = dgvData.Columns[e.ColumnIndex].Name;

            if (operation == "Edit")
            {
                loadFields(row);
            }
            else if (operation == "Del")
            {
                if (com.delOption("Vehicle"))
                {
                    veh.delVeh();

                    com.showMessage(veh.msg, lblMsg, veh.msg_type, tmrMsg);
                    if (veh.result)
                    {
                        loadData();
                        clear();
                    }
                }
            }
        }
    }
}
