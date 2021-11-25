using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using prjGrow.General;
using prjGrow.Reports;
using prjGrow.StockInfo;
using prjGrow.Users;
using prjGrow.Accounts;
using prjGrow.Reporting;
using prjGrow.Manufacture;
using prjGrow.Classes;
using prjGrow.Fnb;

namespace prjGrow
{
    public partial class frmDashboard : Form
    {
        private int childFormNumber = 0;
        Custom custom = new Custom();
        Orders odr = new Orders();
        
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void showFrm(Form frm)
        {
            if (Constants.multiple_forms)
                frm.Show();
            else
                frm.ShowDialog();
        //    frm.BringToFront();
        }

        void processes()
        {
            process_cheq();
        }

        void process_cheq()
        {
            Cheque cheq = new Cheque();
            cheq.processCheque();
        }

        void loadDashboardInfo()
        {
            lblWelcome.Text = "Wellcome, Mr. " + User.curfullName;
            lblClient.Text = Constants.client_name;
            lblContact.Text = Constants.client_contact;
            lblAdrs.Text = Constants.client_adrs;
        }
        
        void resize()
        {
            Size siz = SystemInformation.VirtualScreen.Size;
            if(siz.Height == 768 && siz.Width == 1024)
                this.Font = new Font("Segoe UI", 9, FontStyle.Bold);

            if (Custom.largeScreen)
                this.Font = new Font("Serif", 16);
        }

        void customDashboard()
        {

            pnlOrder.Visible = (Custom.mod_manufact && !(Custom.client_id_active == 7)) || Custom.mod_bakers;
            pnlManufacture.Visible = Custom.mod_manufact;
            pnlManufactRep.Visible = Custom.mod_manufact || Custom.mod_fnb;
            pnlOrdersRep.Visible = (Custom.mod_manufact && !(Custom.client_id_active == 7)) || Custom.mod_bakers;
            menuManufacture.Visible = Custom.mod_manufact || Custom.mod_fnb;
            pnlLogistic.Visible = Custom.mod_bakers || Custom.mod_manufact;
            pnlImei.Visible = Custom.mod_mobile;
            pnlOrderProg.Visible = Custom.mod_manufact;
            pnlInvoice.Visible = !(Custom.client_id_active == 5);

            mtmTables.Visible = Custom.mod_fnb;
            mtmComp.Visible = Custom.mod_fnb;
            mtmSale.Visible = !Custom.mod_fnb;
            mtmSaleReview.Visible = !Custom.mod_fnb;
            mtmOrder.Visible = (Custom.mod_manufact && !(Custom.client_id_active == 7)) || Custom.mod_bakers;
            mtmCusOrder.Visible = Custom.mod_bakers;
            mtmOrderReview.Visible = (Custom.mod_manufact && !(Custom.client_id_active == 7)) || Custom.mod_bakers;
            mtmBarcode.Visible = Custom.mod_bakers || Custom.mod_mobile;
            mtmOrdAct.Visible = (Custom.mod_manufact && !(Custom.client_id_active == 7)) || Custom.mod_bakers;
            mtmOrderProg.Visible = sepOrder.Visible = Custom.client_id_active == 2;
            mtmFoodOrder.Visible = mtmFoodReview.Visible = Custom.mod_fnb;
            mtmExpiryRep.Visible = Custom.mod_bakers;
            mtmAutoConsume.Visible = Custom.client_id_active == 5;
            mtmClient.Visible = User.curAuth == 1;
            mtmInbd.Visible = mtmInbdRep.Visible = Custom.mod_bakers || Custom.mod_manufact;
            mtmStkDis.Visible = Custom.client_id_active == 7;
            mtmAutoConsumeS.Visible = Custom.client_id_active == 2;
            mtmVehicle.Visible = Custom.client_id_active == 7;
            mtmIMEI.Visible = Custom.mod_mobile;

            pnlOrdersDisp.Visible = Custom.mod_manufact && !(Custom.client_id_active == 7);
            if (pnlOrdersDisp.Visible)
                showOrdersOnDashboard();

            if (Custom.mod_fnb)
            {
                menuManufacture.Text = "Food and Beverage";
                lblSale.Text = mtmSale.Text = "Food Orders";
                lblOrderProg.Text = mtmOrder.Text = "Special Orders";
                lblProcessing.Text = mtmProcess.Text = "Food Costing";
                mtmProcessReview.Text = "Consting Review";
            }

            if (Custom.mod_manufact)
            {
                mtmSale.Text = "Sale and Delivery";
                mtmSaleReview.Text = "Sale and Delivery Review";
                lblSale.Text = "Sale and Delivery";
            }

            if (Custom.client_id_active == 5)
            {
                mtmInbd.Visible = mtmInbdRep.Visible = true;
                mtmProcessReview.Visible = true;
            }

            if (lblClient.Text.Length > 40)
                lblClient.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Bold);
        }

        void showOrdersOnDashboard()
        {
            odr.getDashboardOrders();
            lblPendingOrders.Text = Orders.pendingOrders;
            lblReadyOrders.Text = Orders.readyOrders;
            lblOverdueOrders.Text = Orders.overdueOrders;
        }

        public void secureDashboard()
        {
            bool isAdmin = User.curAuth == 1 || User.curAuth == 2;

            pnlPls.Visible = isAdmin;
            mtmBalSheet.Enabled = isAdmin;
            mtmBank.Enabled = isAdmin;
            mtmTrialBal.Enabled = isAdmin;
            mtmCashFlow.Enabled = isAdmin;
            mtmDraw.Enabled = isAdmin;
            mtmEmpPay.Enabled = isAdmin;
            mtmEmpLed.Enabled = isAdmin;
            mtmEmp.Enabled = isAdmin;
            mtmStockRep.Enabled = isAdmin;
            
            mtmSaleRep.Enabled = isAdmin;
            mtmSupPay.Enabled = isAdmin;
            mtmSupplier.Enabled = isAdmin;
            mtmPurRep.Enabled = isAdmin;
            mtmDraw.Enabled = isAdmin;
            mtmDamage.Enabled = isAdmin;
            mtmBankTran.Enabled = isAdmin;
            mtmBankLed.Enabled = isAdmin;
            mtmAutoConsume.Enabled = isAdmin;
            mtmAsset.Enabled = isAdmin;
            mtmAssetPurchase.Enabled = isAdmin;
            mtmBankCheques.Enabled = isAdmin;
            mtmPls.Enabled = isAdmin;

            if (Custom.client_id_active == 1)
            {
                mtmEmpLed.Enabled = mtmEmpPay.Enabled = true;
                mtmBankLed.Enabled = mtmBankTran.Enabled = true;
            }
            if (Custom.client_id_active == 7)
            {
                mtmProcess.Enabled = pnlManufacture.Enabled = isAdmin;
                mtmProcessReview.Enabled = isAdmin;
            }

            else if (Custom.client_id_active == 6)
            {
                mtmPurchase.Enabled = lblPurchase.Enabled = pbPurchase.Enabled = mtmPurReview.Enabled = mtmPurRep.Enabled = isAdmin;
                mtmSupLed.Enabled = isAdmin;
            }

            else if (Custom.client_id_active == 3)
            {
                mtmSaleReview.Enabled = isAdmin;
            }
        }

        private void treeMain_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string btnName = e.Node.Text;

            switch (btnName)
            { 
                case "Sale":
                    mtmSale_Click(sender, e);
                    break;
                case "Sale Review":
                    mtmSaleReview_Click(sender, e);
                    break;
                case "Purchase":
                    mtmPurchase_Click(sender, e);
                    break;
                case "Purchase Review":
                    mtmPurReview_Click(sender, e);
                    break;
                case "Stock Damage":
                    mtmDamage_Click(sender, e);
                    break;

                case "Purchase Report":
                    mtmPurRep_Click(sender, e);
                    break;
                case "Sale Report":
                    mtmSaleRep_Click(sender, e);
                    break;
                case "Stock Report":
                    mtmStockRep_Click(sender, e);
                    break;

                case "Product":
                    mtmProd_Click(sender, e);
                    break;
                case "Bank":
                    mtmBank_Click(sender, e);
                    break;
                case "Supplier":
                    mtmSupplier_Click(sender, e);
                    break;
                case "Customer":
                    mtmCustomer_Click(sender, e);
                    break;

                case "Customer Transactions":
                    mtmCusReciept_Click(sender, e);
                    break;
                case "Supplier Transactions":
                    mtmSupPay_Click(sender, e);
                    break;
                case "Bank Transactions":
                    mtmBankTran_Click(sender, e);
                    break;
                case "Expense":
                    mtmExpense_Click(sender, e);
                    break;

                case "General Journal":
                    mtmJournal_Click(sender, e);
                    break;
                case "Cash Book":
                    mtmCashBook_Click(sender, e);
                    break;
                case "Customer Ledger":
                    mtmCusLed_Click(sender, e);
                    break;
                case "Supplier Ledger":
                    mtmSupLed_Click(sender, e);
                    break;
                case "Trial Balance":
                    mtmTrialBal_Click(sender, e);
                    break;
                case "Balance Sheet":
                    mtmBalSheet_Click(sender, e);
                    break;
                case "Expiry Report":
                    mtmExpiryRep_Click(sender, e);
                    break;

                case "Add New User":
                    mtmAddUser_Click(sender, e);
                    break;
                case "Change Password":
                    mtmChangePass_Click(sender, e);
                    break;
            }
        }

        private void mtmSale_Click(object sender, EventArgs e)
        {
            if (Custom.mod_fnb)
                showFrm(new frmPlaceOrder());
            else
                showFrm(new frmSale());
            if (pnlOrdersDisp.Visible && Custom.mod_manufact)
                showOrdersOnDashboard();
        }

        private void pbSale_Click(object sender, EventArgs e)
        {
            mtmSale_Click(sender, e);
        }

        private void mtmSaleReview_Click(object sender, EventArgs e)
        {
            showFrm(new frmSaleReview());
        }

        private void mtmBank_Click(object sender, EventArgs e)
        {
            showFrm(new frmBank());
        }

        private void txtSrh_TextChanged(object sender, EventArgs e)
        {
            bool found = false;
            string str = txtSrh.Text;
            if (str.Length < 3)
                return;
            str = str.ToUpper();
            string nodeName = "";

            treeMain.CollapseAll();

            foreach (TreeNode node in treeMain.Nodes)
            {
                foreach (TreeNode chield in node.Nodes)
                {
                    nodeName = chield.Text.ToUpper();
                    if (nodeName.Contains(str))
                    {
                        treeMain.SelectedNode = chield;
                        treeMain.Focus();

                        found = true;
                        break;
                    }
                }
                if (found)
                    break;
            }
        }

        private void mtmPurReview_Click(object sender, EventArgs e)
        {
            showFrm(new frmPurchaseReview());
        }

        private void mtmProd_Click(object sender, EventArgs e)
        {
            showFrm(new frmProducts());
        }

        private void mtmDamage_Click(object sender, EventArgs e)
        {
            showFrm(new frmDamage());
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            custom.Customize();
            loadDashboardInfo();
            resize();
            customDashboard();
            secureDashboard();
            processes();
        }

        private void mtmPurchase_Click(object sender, EventArgs e)
        {
            showFrm(new frmPurchase());
        }

        private void pbPurchase_Click(object sender, EventArgs e)
        {
            mtmPurchase_Click(sender, e);
        }

        private void lnkPurchase_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mtmPurchase_Click(sender, e);
        }

        private void lnkSale_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mtmSale_Click(sender, e);
        }

        private void mtmAddUser_Click(object sender, EventArgs e)
        {
            showFrm(new frmUserInfo());
        }

        private void mtmChangePass_Click(object sender, EventArgs e)
        {
            showFrm(new frmChangePass());
        }

        private void mtmExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lnkCusLedger_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mtmCusReciept_Click(sender, e);
        }

        private void mtmSupPay_Click(object sender, EventArgs e)
        {
            showFrm(new frmSupplierTran());
        }

        private void mtmSupplier_Click(object sender, EventArgs e)
        {
            showFrm(new frmSuplier());
        }

        private void mtmBankTran_Click(object sender, EventArgs e)
        {
            showFrm(new frmBankTran());
        }

        private void mtmCustomer_Click(object sender, EventArgs e)
        {
            showFrm(new frmCustomer());
        }

        private void mtmExpType_Click(object sender, EventArgs e)
        {
            showFrm(new frmExpType());
        }

        private void mtmCusReciept_Click(object sender, EventArgs e)
        {
            showFrm(new frmCustomerTran());
        }

        private void lnkCusLedger_Click(object sender, EventArgs e)
        {
            mtmCusLed_Click(sender, e);
        }

        private void lnkPls_Click(object sender, EventArgs e)
        {
            mtmPls_Click(sender, e);
        }

        private void mtmExpense_Click(object sender, EventArgs e)
        {
            showFrm(new frmExpense());
        }

        private void pbCusLog_Click(object sender, EventArgs e)
        {
            mtmCusReciept_Click(sender, e);
        }

        private void lnkCusLog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mtmCusReciept_Click(sender, e);
        }

        private void pbExpense_Click(object sender, EventArgs e)
        {
            mtmExpense_Click(sender, e);
        }

        private void lnkExp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mtmExpense_Click(sender, e);
        }

        private void mtmJournal_Click(object sender, EventArgs e)
        {
            showFrm(new frmJournal());
        }

        private void mtmCashBook_Click(object sender, EventArgs e)
        {
            showFrm(new frmCashbook());
        }

        private void mtmCusLed_Click(object sender, EventArgs e)
        {
            showFrm(new frmCusLed());
        }

        private void mtmSupLed_Click(object sender, EventArgs e)
        {
            showFrm(new frmSupLed());
        }

        private void mtmBankLed_Click(object sender, EventArgs e)
        {
            showFrm(new frmBnkLed());
        }

        private void mtmPls_Click(object sender, EventArgs e)
        {
            showFrm(new frmProfitLoss());
        }

        private void mtmTrialBal_Click(object sender, EventArgs e)
        {
            showFrm(new frmTrialBal());
        }

        private void mtmPurRep_Click(object sender, EventArgs e)
        {
            showFrm(new frmPurRep());
        }

        private void mtmSaleRep_Click(object sender, EventArgs e)
        {
            showFrm(new frmSaleRep());
        }

        private void mtmStockRep_Click(object sender, EventArgs e)
        {
            showFrm(new frmStockRep());
        }

        private void mtmEmpPay_Click(object sender, EventArgs e)
        {
            showFrm(new frmEmpTran());
        }

        private void lnkCashBook_Click(object sender, EventArgs e)
        {
            mtmCashBook_Click(sender, e);
        }

        private void mtmDraw_Click(object sender, EventArgs e)
        {
            showFrm(new frmDrawInvest());
        }

        private void mtmOrder_Click(object sender, EventArgs e)
        {
            showFrm(new frmOrders());
            showOrdersOnDashboard();
        }

        private void mtmProcess_Click(object sender, EventArgs e)
        {
            showFrm(new frmProduction());
            showOrdersOnDashboard();
        }

        private void pbOrder_Click(object sender, EventArgs e)
        {
            mtmOrder_Click(sender, e);
        }

        private void lnkOrder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mtmOrder_Click(sender, e);
        }

        private void pbProcess_Click(object sender, EventArgs e)
        {
            mtmProcess_Click(sender, e);
        }

        private void lnkProcess_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mtmProcess_Click(sender, e);
        }

        private void mtmOrderRep_Click(object sender, EventArgs e)
        {
        }

        private void mtmCusOrder_Click(object sender, EventArgs e)
        {
            mtmOrder_Click(sender, e);
        }

        private void mtmDayBook_Click(object sender, EventArgs e)
        {
            showFrm(new frmDayBook());
        }

        private void expenseReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showFrm(new frmExpLedger());
        }

        private void pbDayBook_Click(object sender, EventArgs e)
        {
            mtmDayBook_Click(sender,e);
        }

        private void lnkDayBook_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mtmDayBook_Click(sender, e);
        }

        private void mtmAtend_Click(object sender, EventArgs e)
        {
            showFrm( new frmAtendRep());
        }

        private void mtmDrawInvest_Click(object sender, EventArgs e)
        {
            showFrm(new frmDrawInvest());
        }

        private void mtmCoa_Click(object sender, EventArgs e)
        {
            showFrm(new frmCoa());
        }

        private void mtmProdType_Click(object sender, EventArgs e)
        {
            showFrm(new frmProductType());
        }

        private void mtmInbd_Click(object sender, EventArgs e)
        {
            showFrm(new frmInbound());
        }

        private void mtmEmpLed_Click(object sender, EventArgs e)
        {
            showFrm(new frmEmpLed());
        }

        private void mtmEmp_Click(object sender, EventArgs e)
        {
            showFrm(new frmEmp());
        }

        private void pbInbound_Click(object sender, EventArgs e)
        {
            mtmInbd_Click(sender, e);
        }

        private void lnkInbound_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mtmInbd_Click(sender, e);
        }

        private void mtmBackup_Click(object sender, EventArgs e)
        {
            showFrm(new frmBackup());
        }

        private void mtmBalSheet_Click(object sender, EventArgs e)
        {
            showFrm(new frmBalSheet());
        }

        private void mtmExpiryRep_Click(object sender, EventArgs e)
        {
            showFrm(new frmExpiryRep());
        }

        private void lnkImei_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            showFrm(new frmImeiRep());
        }

        private void lnkPreviousInvoice_Click(object sender, EventArgs e)
        {
            showFrm(new frmSaleReceipt());
        }

        private void mtmOrderProg_Click(object sender, EventArgs e)
        {
            showFrm(new frmProgress());
        }

        private void mtmOrdAct_Click(object sender, EventArgs e)
        {
            showFrm(new frmOrderRepAct());
        }

        private void pbOrderActRep_Click(object sender, EventArgs e)
        {
            mtmOrdAct_Click(sender, e);
        }

        private void lnkActiveOrderRep_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mtmOrdAct_Click(sender, e);
        }

        private void pbInvoice_Click(object sender, EventArgs e)
        {
            lnkPreviousInvoice_Click(sender, e);
        }

        private void productionReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showFrm(new frmProductionReport());
        }

        private void lnlOrderRep_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            productionReportToolStripMenuItem_Click(sender, e);
        }

        private void pbProductionRep_Click(object sender, EventArgs e)
        {
            productionReportToolStripMenuItem_Click(sender, e);
        }

        private void mtmConsumeRep_Click(object sender, EventArgs e)
        {
            showFrm(new frmConsumeRep());
        }

        private void pbConsumeRep_Click(object sender, EventArgs e)
        {
            mtmConsumeRep_Click(sender, e);
        }

        private void lnkComsumeRep_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mtmConsumeRep_Click(sender, e);
        }

        private void assetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showFrm(new frmAssets());
        }

        private void assetPurchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showFrm(new frmAssetPurchase());
        }

        private void barcodeGeneratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showFrm(new frmBarcodeGen());
        }

        private void pbImei_Click(object sender, EventArgs e)
        {

        }

        private void mtmInbdRep_Click(object sender, EventArgs e)
        {
            showFrm(new frmInboundRep());
        }

        private void mtmTables_Click(object sender, EventArgs e)
        {
            showFrm(new frmTable());
        }

        private void mtmFoodOrder_Click(object sender, EventArgs e)
        {
            showFrm(new frmPlaceOrder());
        }

        private void mtmFoodReview_Click(object sender, EventArgs e)
        {
            showFrm(new frmSaleReview());
        }

        private void mtmProcessReview_Click(object sender, EventArgs e)
        {
            showFrm(new frmProcessReview());
        }

        private void mtmComp_Click(object sender, EventArgs e)
        {
            showFrm(new frmComp());
        }

        private void mtmAtend_Click_1(object sender, EventArgs e)
        {
            showFrm(new frmEmpAtend());
        }

        private void mtmOrderReview_Click(object sender, EventArgs e)
        {
            showFrm(new frmOrderReview());
        }

        private void mtmAutoConsume_Click(object sender, EventArgs e)
        {
            showFrm(new frmAutoConsume());
        }

        private void mtmPriceList_Click(object sender, EventArgs e)
        {
            showFrm(new frmPriceList());
        }

        private void mtmCashFlow_Click(object sender, EventArgs e)
        {
            showFrm(new frmCashflow());
        }

        private void mtmCusVisitSum_Click(object sender, EventArgs e)
        {
            showFrm(new frmCusVisitSummary());
        }

        private void saleSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showFrm(new frmSaleSummary());
        }

        private void mtmStkDis_Click(object sender, EventArgs e)
        {
            showFrm(new frmStockInOut());
        }

        private void mtmVehicle_Click(object sender, EventArgs e)
        {
            showFrm(new frmVeh());
        }

        private void mtmAutoConsumeS_Click(object sender, EventArgs e)
        {
            showFrm(new frmAutoConsume());
        }

        private void mtmShortStock_Click(object sender, EventArgs e)
        {
            showFrm(new frmShortStock());
        }

        private void mtmShortStockRep_Click(object sender, EventArgs e)
        {
            showFrm(new frmShortStockRep());
        }

        private void lnkCashBook_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void pnlRepCom_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mtmBankCheques_Click(object sender, EventArgs e)
        {
            showFrm(new frmCheques());
        }

        private void mtmConsume_Click(object sender, EventArgs e)
        {
            showFrm(new frmConsume());
        }

        private void switchUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmlogin log = new frmlogin();
            log.ShowDialog();
            if(User.login_success)
            {
                string tmpStr = "";
                for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
                {
                    tmpStr = Application.OpenForms[i].Name;
                    if (tmpStr != "frmDashboard" && tmpStr != "frmSale")
                        Application.OpenForms[i].Close();
                }
                secureDashboard();
            }
        }

        private void frmDashboard_Activated(object sender, EventArgs e)
        {
            if (Sale.toSwitch)
            {
                secureDashboard();
                Sale.toSwitch = false;
            }
        }

        private void mtmSupOrder_Click(object sender, EventArgs e)
        {
            showFrm(new frmSupplierOrders());
        }

        private void supplierOrdersReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showFrm(new frmSupOrder() );
        }

        private void pbCashFlow_Click(object sender, EventArgs e)
        {
            mtmCashFlow_Click(sender, e);
        }

        private void lnkCashFlow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mtmCashFlow_Click(sender, e);
        }

        private void pnlPls_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lnkOrderProg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mtmOrderProg_Click(sender, e);
        }

        private void pbOrderProg_Click(object sender, EventArgs e)
        {
            mtmOrderProg_Click(sender, e);
        }

        private void label15_Click(object sender, EventArgs e)
        {
            
        }

        private void lblPurchase_Click(object sender, EventArgs e)
        {
            mtmPurchase_Click(sender, e);
        }

        private void lblCusOrders_Click(object sender, EventArgs e)
        {
            mtmOrder_Click(sender, e);
        }

        private void lblSale_Click(object sender, EventArgs e)
        {
            mtmSale_Click(sender, e);
        }

        private void lblProcessing_Click(object sender, EventArgs e)
        {
            mtmProcess_Click(sender, e);
        }

        private void lblOrderProg_Click(object sender, EventArgs e)
        {
            mtmOrderProg_Click(sender, e);
        }

        private void lblCusTran_Click(object sender, EventArgs e)
        {
            mtmCusReciept_Click(sender, e);
        }

        private void lblExpense_Click(object sender, EventArgs e)
        {
            mtmExpense_Click(sender, e);
        }

        private void lblIEMI_Click(object sender, EventArgs e)
        {
            
        }

        private void lblStore_Click(object sender, EventArgs e)
        {
            mtmInbd_Click(sender, e);
        }

        private void lblDayBook_Click(object sender, EventArgs e)
        {
            mtmDayBook_Click(sender, e);
        }

        private void lblCusLedger_Click(object sender, EventArgs e)
        {
            mtmCusLed_Click(sender, e);
        }

        private void lblCashFlow_Click(object sender, EventArgs e)
        {
            mtmCashFlow_Click(sender, e);
        }

        private void lblProfitLoss_Click(object sender, EventArgs e)
        {
            mtmPls_Click(sender, e);
        }

        private void lblActiveOrders_Click(object sender, EventArgs e)
        {
            mtmCusOrder_Click(sender, e);
        }

        private void lblProdRep_Click(object sender, EventArgs e)
        {
            
        }

        private void lblConsumeRep_Click(object sender, EventArgs e)
        {
            mtmConsume_Click(sender, e);
        }

        private void lblInvoice_Click(object sender, EventArgs e)
        {
            mtmCusReciept_Click(sender, e);
        }

        private void mtmIMEI_Click(object sender, EventArgs e)
        {
            showFrm(new frmIMEI());
        }

/*        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }*/
    }
}
