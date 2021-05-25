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
    public partial class frmAutoConsume : frmBaseSimple
    {
        public frmAutoConsume()
        {
            InitializeComponent();
        }

        Product prod = new Product();
        Link_prod lnk = new Link_prod();

        public DataTable tblServ = new DataTable();
        public DataTable tblRaw = new DataTable();
        public DataTable tblData = new DataTable();

        void getData()
        {
            lnk.serv_id = Convert.ToInt64(cmbServ.SelectedValue);
            lnk.raw_id = Convert.ToInt64(cmbRaw.SelectedValue);
            lnk.qty = (float)Convert.ToDouble(numQty.Value);
        }

        bool validation()
        {
            Control[] C = new Control[] { cmbServ, cmbRaw, numQty };
            string[] S = new string[] { "Service", "Raw Material", "Consume Quantity" };

            return com.chkValid(C, S);
        }

        void clear()
        {
            com.clearControls(new Control[] { cmbRaw, cmbServ, numQty }, cmbServ, btnSaveUpd);       
        }

        void customize()
        {
            if (Custom.client_id_active == 2)
            {
                lblProd1.Text = "Pack";
                lblProd2.Text = "Product";
            }
        }

        void loadFields(DataGridViewRow row)
        {
            com.loadFields(row, new Control[] { cmbServ, cmbRaw, numQty }, new string[] { Link_prod.col_prod_id, Link_prod.col_raw_id, Link_prod.col_qty }, cmbServ, btnSaveUpd);
        }

        void loadData()
        {
            tblData = lnk.getLinkProd();
            dgvData.DataSource = tblData;
            com.hideColumns(dgvData, new string[] {Link_prod.col_id, Link_prod.col_prod_id, Link_prod.col_raw_id});
        }

        void loadProd()
        {
            prod.cateRaw = prod.cateStk = prod.cateBakery = prod.multiCate = true;
            tblRaw = prod.getProducts(true);
            com.loadCombo(cmbRaw, tblRaw, Product.col_prod_name, Product.col_prod_id);

            prod.multiCate = false;
            prod.category = Constants.cate_service;
            tblServ = prod.getProducts();
            com.loadCombo(cmbServ, tblServ, Product.col_prod_name, Product.col_id);
        }

        private void frmLinkProd_Load(object sender, EventArgs e)
        {
            com.loadFormInfo(this, "Auto Consumption", lblClient, lblTitle);
            customize();
            loadProd();
            loadData();
        }

        private void btnSaveUpd_Click(object sender, EventArgs e)
        {
            if (!validation())
                return;
            getData();

            operation = btnSaveUpd.Text;

            if (operation == "&Save")
            {
                lnk.save();
            }
            else if (operation == "&Update")
            {
                lnk.update();
            }

            if (prod.result)
            {
                clear();
                loadData();
            }
            com.showMessage(prod.msg, lblMsg, prod.msg_type, tmrMsg);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            
            DataGridViewRow row = dgvData.Rows[e.RowIndex];
            lnk.id = Convert.ToInt64(row.Cells[Link_prod.col_id].Value.ToString());

            if (dgvData.Columns[e.ColumnIndex].Name == "Edit")
            {
                Control[] C = new Control[] { cmbServ, cmbRaw, numQty };
                string[] S = new string[] { Link_prod.col_prod_id, Link_prod.col_raw_id, Link_prod.col_qty };
                com.loadFields(row, C, S, cmbServ, btnSaveUpd);
            }
            else if (dgvData.Columns[e.ColumnIndex].Name == "Del")
            {
                if (com.delOption("Record"))
                {
                    lnk.id = Convert.ToInt64(row.Cells[Link_prod.col_id].Value);
                    lnk.delete();
                    com.showMessage(prod.msg, lblMsg, prod.msg_type, tmrMsg);
                    if (lnk.result)
                        loadData();
                }
            }
        }
    }
}