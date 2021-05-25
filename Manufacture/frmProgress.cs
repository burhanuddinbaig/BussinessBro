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
    public partial class frmProgress : frmBaseSimple
    {
        public frmProgress()
        {
            InitializeComponent();
        }

        Orders odr = new Orders();
        DataTable tblData = new DataTable();

        void loadData()
        {
            tblData = odr.getOrderProgress();
            dgvData.DataSource = tblData;
            com.hideColumns(dgvData, new string[] { Orders.col_prod_id, Orders.col_tran_id, Orders.col_prog_id, Orders.col_price});
            com.enableColumns(dgvData, new string[] { Orders.col_factory }, Custom.mod_bakers);
        }

        void getData(int i)
        {
            odr.id = Convert.ToInt64(dgvData.Rows[i].Cells[Orders.col_order_no].Value);
            odr.prod_id = Convert.ToInt64(dgvData.Rows[i].Cells[Orders.col_prod_id].Value);
            odr.prog = Convert.ToInt16(dgvData.Rows[i].Cells[Orders.col_prog_id].Value);

            odr.stk.prod_id = odr.prod_id;
            odr.stk.price = Convert.ToInt64(dgvData.Rows[i].Cells[Orders.col_price].Value);
            odr.stk.dr = Convert.ToInt64(dgvData.Rows[i].Cells[Orders.col_qty].Value);
        }

        void customize()
        {
            if(Custom.client_id_active == 2)
            dgvData.Columns[1].Name = "Display";
        }

        private void frmProgress_Load(object sender, EventArgs e)
        {
            com.loadFormInfo(this, dgvData, "Order Progress", lblClient, lblTitle);
            loadData();
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0||e.ColumnIndex > 1)
                return;
            operation = dgvData.Columns[e.ColumnIndex].Name;
            if (!com.sureOption("Are You Sure"))
                return;
            getData(e.RowIndex);
            if(operation == "Factory" && odr.prog < 2)
            {
                odr.progressOrder(Orders.order_factory);
                com.showMessage(odr.msg, lblMsg, odr.msg_type, tmrMsg);
                loadData();
            }
            else if (operation == "Ready" && odr.prog < 3)
            {
                odr.progressOrder(Orders.order_ready);
                com.showMessage(odr.msg, lblMsg, odr.msg_type, tmrMsg);
                loadData();
            }
        }

        private void btnOdr_Click(object sender, EventArgs e)
        {
            frmOrders frmOrd = new frmOrders();
            frmOrd.ShowDialog();
            loadData();
        }
    }
}