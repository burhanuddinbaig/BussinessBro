using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using prjGrow.Classes;

namespace prjGrow.Manufacture
{
    public partial class frmDelivery : Form
    {
        public frmDelivery()
        {
            InitializeComponent();
        }

        public long cusId = 0;
        public bool indexChanged = false;
        public short rowCount = 0;
        public DataTable tblOrders = new DataTable();
        Orders odr = new Orders();
        Common com = new Common();

        void loadOrders()
        {
            odr.cus_id = cusId;
            tblOrders = odr.getOrderProd(true);
            dgvOrders.DataSource = tblOrders;
            com.hideColumns(dgvOrders, new string[]{Orders.col_prod_id, Orders.col_descrip, Orders.col_cus_name, Orders.col_progress, Orders.col_cost});
            indexChanged = false;
        }

        private void frmDelivery_Load(object sender, EventArgs e)
        {
            if(indexChanged)
                loadOrders();
        }

        private void dgvOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if (dgvOrders.Columns[e.ColumnIndex].Name == "Remove")
            {
                tblOrders.Rows.RemoveAt(e.RowIndex);
                dgvOrders.DataSource = tblOrders;
            }
        }
    }
}