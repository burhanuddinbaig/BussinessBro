namespace prjGrow.StockInfo
{
    partial class frmPurchaseReview
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPurchaseReview));
            this.btnDel = new System.Windows.Forms.Button();
            this.btnSrh = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.Return = new System.Windows.Forms.DataGridViewImageColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.numCost = new System.Windows.Forms.NumericUpDown();
            this.numRetail = new System.Windows.Forms.NumericUpDown();
            this.numStock = new System.Windows.Forms.NumericUpDown();
            this.numWhole = new System.Windows.Forms.NumericUpDown();
            this.numQty = new System.Windows.Forms.NumericUpDown();
            this.btnAddtoCart = new System.Windows.Forms.Button();
            this.cmbProd = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.numAmount = new System.Windows.Forms.NumericUpDown();
            this.label23 = new System.Windows.Forms.Label();
            this.btnAddIMEI = new System.Windows.Forms.Button();
            this.numCredit = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.numBillTotal = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.numDiscount = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.numPaid = new System.Windows.Forms.NumericUpDown();
            this.lblPaid = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.label24 = new System.Windows.Forms.Label();
            this.pnlTots = new System.Windows.Forms.Panel();
            this.pnlCheq = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.dtpCheqDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCheq_no = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numInvoiceno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numClientBal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWhole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCredit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBillTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPaid)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            this.pnlTots.SuspendLayout();
            this.pnlCheq.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMsg
            // 
            this.lblMsg.Location = new System.Drawing.Point(277, 91);
            this.lblMsg.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(-4, 207);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(48, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            // 
            // numInvoiceno
            // 
            this.numInvoiceno.Enabled = true;
            this.numInvoiceno.Location = new System.Drawing.Point(150, 131);
            this.numInvoiceno.Margin = new System.Windows.Forms.Padding(5);
            this.numInvoiceno.ReadOnly = false;
            this.numInvoiceno.TabIndex = 1;
            this.numInvoiceno.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numInvoiceno_KeyUp);
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(324, 167);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(5);
            this.dtpDate.Size = new System.Drawing.Size(124, 29);
            // 
            // cmbClient
            // 
            this.cmbClient.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbClient.Enabled = false;
            this.cmbClient.Location = new System.Drawing.Point(484, 166);
            this.cmbClient.Margin = new System.Windows.Forms.Padding(5);
            this.cmbClient.Size = new System.Drawing.Size(247, 32);
            // 
            // lblProdCode
            // 
            this.lblProdCode.Location = new System.Drawing.Point(1346, 145);
            this.lblProdCode.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblProdCode.Visible = false;
            // 
            // txtProdCode
            // 
            this.txtProdCode.Location = new System.Drawing.Point(1336, 176);
            this.txtProdCode.Margin = new System.Windows.Forms.Padding(5);
            this.txtProdCode.Visible = false;
            // 
            // lblProdName
            // 
            this.lblProdName.Location = new System.Drawing.Point(1417, 388);
            this.lblProdName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblProdName.Visible = false;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(287, 122);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Size = new System.Drawing.Size(2, 90);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(328, 139);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Size = new System.Drawing.Size(53, 24);
            this.label8.Text = "Date:";
            // 
            // txtProdName
            // 
            this.txtProdName.Location = new System.Drawing.Point(1321, 502);
            this.txtProdName.Margin = new System.Windows.Forms.Padding(5);
            this.txtProdName.Visible = false;
            // 
            // txtAccno
            // 
            this.txtAccno.Location = new System.Drawing.Point(1370, 451);
            this.txtAccno.Margin = new System.Windows.Forms.Padding(5);
            this.txtAccno.Visible = false;
            // 
            // cmbBank
            // 
            this.cmbBank.Enabled = false;
            this.cmbBank.Location = new System.Drawing.Point(769, 166);
            this.cmbBank.Margin = new System.Windows.Forms.Padding(5);
            this.cmbBank.Size = new System.Drawing.Size(240, 32);
            this.cmbBank.SelectedValueChanged += new System.EventHandler(this.cmbBank_SelectedValueChanged);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(765, 139);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(1370, 295);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Visible = false;
            // 
            // numClientBal
            // 
            this.numClientBal.Location = new System.Drawing.Point(1364, 323);
            this.numClientBal.Margin = new System.Windows.Forms.Padding(5);
            this.numClientBal.Visible = false;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(1370, 424);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Visible = false;
            // 
            // btnBank
            // 
            this.btnBank.Location = new System.Drawing.Point(1421, 216);
            this.btnBank.Margin = new System.Windows.Forms.Padding(5);
            this.btnBank.Visible = false;
            // 
            // btnClient
            // 
            this.btnClient.Location = new System.Drawing.Point(1421, 252);
            this.btnClient.Margin = new System.Windows.Forms.Padding(5);
            this.btnClient.Visible = false;
            // 
            // btnProduct
            // 
            this.btnProduct.Location = new System.Drawing.Point(1351, 236);
            this.btnProduct.Margin = new System.Windows.Forms.Padding(5);
            this.btnProduct.Visible = false;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(16, 340);
            this.btnDel.Margin = new System.Windows.Forms.Padding(4);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(209, 38);
            this.btnDel.TabIndex = 23;
            this.btnDel.Text = "&Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnSrh
            // 
            this.btnSrh.Location = new System.Drawing.Point(59, 169);
            this.btnSrh.Margin = new System.Windows.Forms.Padding(4);
            this.btnSrh.Name = "btnSrh";
            this.btnSrh.Size = new System.Drawing.Size(186, 36);
            this.btnSrh.TabIndex = 32;
            this.btnSrh.Text = "Searc&h";
            this.btnSrh.UseVisualStyleBackColor = true;
            this.btnSrh.Click += new System.EventHandler(this.btnSrh_Click);
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToResizeRows = false;
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.BackgroundColor = System.Drawing.Color.White;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Return});
            this.dgvData.Location = new System.Drawing.Point(4, 145);
            this.dgvData.Margin = new System.Windows.Forms.Padding(4);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(1008, 279);
            this.dgvData.TabIndex = 73;
            this.dgvData.TabStop = false;
            this.dgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
            this.dgvData.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellEndEdit);
            // 
            // Return
            // 
            this.Return.HeaderText = "Return";
            this.Return.Image = ((System.Drawing.Image)(resources.GetObject("Return.Image")));
            this.Return.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Return.Name = "Return";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(92, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 24);
            this.label3.TabIndex = 74;
            this.label3.Text = "Cost";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(433, 16);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 24);
            this.label14.TabIndex = 75;
            this.label14.Text = "Whole";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.Transparent;
            this.label19.Location = new System.Drawing.Point(704, 17);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(56, 24);
            this.label19.TabIndex = 76;
            this.label19.Text = "Retail";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.Transparent;
            this.label20.Location = new System.Drawing.Point(60, 108);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(78, 24);
            this.label20.TabIndex = 77;
            this.label20.Text = "Quantity";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.Color.Transparent;
            this.label21.Location = new System.Drawing.Point(704, 63);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(56, 24);
            this.label21.TabIndex = 78;
            this.label21.Text = "Stock";
            // 
            // numCost
            // 
            this.numCost.Location = new System.Drawing.Point(155, 61);
            this.numCost.Margin = new System.Windows.Forms.Padding(4);
            this.numCost.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numCost.Name = "numCost";
            this.numCost.Size = new System.Drawing.Size(122, 29);
            this.numCost.TabIndex = 5;
            this.numCost.ValueChanged += new System.EventHandler(this.numCost_ValueChanged);
            // 
            // numRetail
            // 
            this.numRetail.Location = new System.Drawing.Point(810, 14);
            this.numRetail.Margin = new System.Windows.Forms.Padding(4);
            this.numRetail.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numRetail.Name = "numRetail";
            this.numRetail.Size = new System.Drawing.Size(122, 29);
            this.numRetail.TabIndex = 4;
            // 
            // numStock
            // 
            this.numStock.Enabled = false;
            this.numStock.Location = new System.Drawing.Point(810, 59);
            this.numStock.Margin = new System.Windows.Forms.Padding(4);
            this.numStock.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numStock.Name = "numStock";
            this.numStock.ReadOnly = true;
            this.numStock.Size = new System.Drawing.Size(122, 29);
            this.numStock.TabIndex = 81;
            // 
            // numWhole
            // 
            this.numWhole.Location = new System.Drawing.Point(524, 14);
            this.numWhole.Margin = new System.Windows.Forms.Padding(4);
            this.numWhole.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numWhole.Name = "numWhole";
            this.numWhole.Size = new System.Drawing.Size(122, 29);
            this.numWhole.TabIndex = 3;
            // 
            // numQty
            // 
            this.numQty.Location = new System.Drawing.Point(155, 106);
            this.numQty.Margin = new System.Windows.Forms.Padding(4);
            this.numQty.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numQty.Name = "numQty";
            this.numQty.Size = new System.Drawing.Size(122, 29);
            this.numQty.TabIndex = 6;
            this.numQty.ValueChanged += new System.EventHandler(this.numQty_ValueChanged);
            // 
            // btnAddtoCart
            // 
            this.btnAddtoCart.Image = ((System.Drawing.Image)(resources.GetObject("btnAddtoCart.Image")));
            this.btnAddtoCart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddtoCart.Location = new System.Drawing.Point(437, 99);
            this.btnAddtoCart.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddtoCart.Name = "btnAddtoCart";
            this.btnAddtoCart.Size = new System.Drawing.Size(264, 36);
            this.btnAddtoCart.TabIndex = 7;
            this.btnAddtoCart.Text = "&Add to Cart";
            this.btnAddtoCart.UseVisualStyleBackColor = true;
            this.btnAddtoCart.Click += new System.EventHandler(this.btnAddtoCart_Click);
            // 
            // cmbProd
            // 
            this.cmbProd.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbProd.FormattingEnabled = true;
            this.cmbProd.Location = new System.Drawing.Point(155, 13);
            this.cmbProd.Margin = new System.Windows.Forms.Padding(4);
            this.cmbProd.Name = "cmbProd";
            this.cmbProd.Size = new System.Drawing.Size(244, 32);
            this.cmbProd.TabIndex = 2;
            this.cmbProd.SelectedValueChanged += new System.EventHandler(this.cmbProd_SelectedValueChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.Color.Transparent;
            this.label22.Location = new System.Drawing.Point(480, 139);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(141, 24);
            this.label22.TabIndex = 86;
            this.label22.Text = "Supplier Name:";
            // 
            // numAmount
            // 
            this.numAmount.Enabled = false;
            this.numAmount.Location = new System.Drawing.Point(524, 59);
            this.numAmount.Margin = new System.Windows.Forms.Padding(4);
            this.numAmount.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numAmount.Name = "numAmount";
            this.numAmount.ReadOnly = true;
            this.numAmount.Size = new System.Drawing.Size(122, 29);
            this.numAmount.TabIndex = 87;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.ForeColor = System.Drawing.Color.Transparent;
            this.label23.Location = new System.Drawing.Point(433, 62);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(76, 24);
            this.label23.TabIndex = 88;
            this.label23.Text = "Amount";
            // 
            // btnAddIMEI
            // 
            this.btnAddIMEI.Enabled = false;
            this.btnAddIMEI.Location = new System.Drawing.Point(721, 97);
            this.btnAddIMEI.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddIMEI.Name = "btnAddIMEI";
            this.btnAddIMEI.Size = new System.Drawing.Size(144, 38);
            this.btnAddIMEI.TabIndex = 91;
            this.btnAddIMEI.Text = "Add IMEIs";
            this.btnAddIMEI.UseVisualStyleBackColor = true;
            this.btnAddIMEI.Visible = false;
            this.btnAddIMEI.Click += new System.EventHandler(this.btnAddIMEI_Click);
            // 
            // numCredit
            // 
            this.numCredit.Enabled = false;
            this.numCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCredit.Location = new System.Drawing.Point(16, 198);
            this.numCredit.Margin = new System.Windows.Forms.Padding(4);
            this.numCredit.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numCredit.Name = "numCredit";
            this.numCredit.Size = new System.Drawing.Size(209, 31);
            this.numCredit.TabIndex = 112;
            this.numCredit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numCredit.ThousandsSeparator = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(15, 174);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 20);
            this.label12.TabIndex = 116;
            this.label12.Text = "Credit:";
            // 
            // numBillTotal
            // 
            this.numBillTotal.Enabled = false;
            this.numBillTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numBillTotal.Location = new System.Drawing.Point(16, 24);
            this.numBillTotal.Margin = new System.Windows.Forms.Padding(4);
            this.numBillTotal.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numBillTotal.Name = "numBillTotal";
            this.numBillTotal.Size = new System.Drawing.Size(211, 31);
            this.numBillTotal.TabIndex = 109;
            this.numBillTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numBillTotal.ThousandsSeparator = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Transparent;
            this.label17.Location = new System.Drawing.Point(15, 0);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(83, 20);
            this.label17.TabIndex = 115;
            this.label17.Text = "Bill Total:";
            // 
            // numDiscount
            // 
            this.numDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDiscount.Location = new System.Drawing.Point(16, 78);
            this.numDiscount.Margin = new System.Windows.Forms.Padding(4);
            this.numDiscount.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numDiscount.Name = "numDiscount";
            this.numDiscount.Size = new System.Drawing.Size(211, 31);
            this.numDiscount.TabIndex = 110;
            this.numDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numDiscount.ThousandsSeparator = true;
            this.numDiscount.ValueChanged += new System.EventHandler(this.numDiscount_ValueChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(15, 59);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(85, 20);
            this.label15.TabIndex = 114;
            this.label15.Text = "Discount:";
            // 
            // numPaid
            // 
            this.numPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPaid.Location = new System.Drawing.Point(16, 139);
            this.numPaid.Margin = new System.Windows.Forms.Padding(4);
            this.numPaid.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numPaid.Name = "numPaid";
            this.numPaid.Size = new System.Drawing.Size(211, 31);
            this.numPaid.TabIndex = 111;
            this.numPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numPaid.ThousandsSeparator = true;
            this.numPaid.ValueChanged += new System.EventHandler(this.numPaid_ValueChanged);
            // 
            // lblPaid
            // 
            this.lblPaid.AutoSize = true;
            this.lblPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaid.ForeColor = System.Drawing.Color.Transparent;
            this.lblPaid.Location = new System.Drawing.Point(15, 115);
            this.lblPaid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaid.Name = "lblPaid";
            this.lblPaid.Size = new System.Drawing.Size(119, 20);
            this.lblPaid.TabIndex = 113;
            this.lblPaid.Text = "Paid as Cash:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(16, 386);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(209, 38);
            this.btnClose.TabIndex = 119;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(16, 294);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(209, 38);
            this.btnClear.TabIndex = 118;
            this.btnClear.Text = "Clea&r Cart";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(16, 248);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(209, 38);
            this.btnSave.TabIndex = 117;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Location = new System.Drawing.Point(8, 236);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(232, 2);
            this.label13.TabIndex = 120;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.pnlGrid);
            this.flowLayoutPanel1.Controls.Add(this.pnlTots);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(38, 216);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1283, 440);
            this.flowLayoutPanel1.TabIndex = 121;
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.numStock);
            this.pnlGrid.Controls.Add(this.label24);
            this.pnlGrid.Controls.Add(this.label3);
            this.pnlGrid.Controls.Add(this.label14);
            this.pnlGrid.Controls.Add(this.label19);
            this.pnlGrid.Controls.Add(this.label20);
            this.pnlGrid.Controls.Add(this.label21);
            this.pnlGrid.Controls.Add(this.numCost);
            this.pnlGrid.Controls.Add(this.numRetail);
            this.pnlGrid.Controls.Add(this.numWhole);
            this.pnlGrid.Controls.Add(this.numQty);
            this.pnlGrid.Controls.Add(this.btnAddtoCart);
            this.pnlGrid.Controls.Add(this.cmbProd);
            this.pnlGrid.Controls.Add(this.label23);
            this.pnlGrid.Controls.Add(this.numAmount);
            this.pnlGrid.Controls.Add(this.btnAddIMEI);
            this.pnlGrid.Controls.Add(this.dgvData);
            this.pnlGrid.Location = new System.Drawing.Point(4, 4);
            this.pnlGrid.Margin = new System.Windows.Forms.Padding(4);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(1018, 429);
            this.pnlGrid.TabIndex = 123;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.ForeColor = System.Drawing.Color.Transparent;
            this.label24.Location = new System.Drawing.Point(13, 17);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(131, 24);
            this.label24.TabIndex = 122;
            this.label24.Text = "Product Name";
            // 
            // pnlTots
            // 
            this.pnlTots.Controls.Add(this.btnClose);
            this.pnlTots.Controls.Add(this.label13);
            this.pnlTots.Controls.Add(this.btnDel);
            this.pnlTots.Controls.Add(this.lblPaid);
            this.pnlTots.Controls.Add(this.numPaid);
            this.pnlTots.Controls.Add(this.label15);
            this.pnlTots.Controls.Add(this.numDiscount);
            this.pnlTots.Controls.Add(this.label17);
            this.pnlTots.Controls.Add(this.numBillTotal);
            this.pnlTots.Controls.Add(this.label12);
            this.pnlTots.Controls.Add(this.numCredit);
            this.pnlTots.Controls.Add(this.btnSave);
            this.pnlTots.Controls.Add(this.btnClear);
            this.pnlTots.Location = new System.Drawing.Point(1030, 4);
            this.pnlTots.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTots.Name = "pnlTots";
            this.pnlTots.Size = new System.Drawing.Size(247, 429);
            this.pnlTots.TabIndex = 0;
            // 
            // pnlCheq
            // 
            this.pnlCheq.Controls.Add(this.label16);
            this.pnlCheq.Controls.Add(this.dtpCheqDate);
            this.pnlCheq.Controls.Add(this.label4);
            this.pnlCheq.Controls.Add(this.txtCheq_no);
            this.pnlCheq.Location = new System.Drawing.Point(1028, 144);
            this.pnlCheq.Name = "pnlCheq";
            this.pnlCheq.Size = new System.Drawing.Size(293, 54);
            this.pnlCheq.TabIndex = 122;
            this.pnlCheq.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(162, 0);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 24);
            this.label16.TabIndex = 99;
            this.label16.Text = "Date";
            // 
            // dtpCheqDate
            // 
            this.dtpCheqDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCheqDate.Location = new System.Drawing.Point(164, 25);
            this.dtpCheqDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpCheqDate.Name = "dtpCheqDate";
            this.dtpCheqDate.Size = new System.Drawing.Size(120, 29);
            this.dtpCheqDate.TabIndex = 98;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(11, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 24);
            this.label4.TabIndex = 97;
            this.label4.Text = "Cheque no.";
            // 
            // txtCheq_no
            // 
            this.txtCheq_no.Location = new System.Drawing.Point(13, 25);
            this.txtCheq_no.Name = "txtCheq_no";
            this.txtCheq_no.Size = new System.Drawing.Size(120, 29);
            this.txtCheq_no.TabIndex = 34;
            // 
            // frmPurchaseReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 687);
            this.Controls.Add(this.pnlCheq);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.btnSrh);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximumSize = new System.Drawing.Size(1934, 1027);
            this.Name = "frmPurchaseReview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Purchase Review";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.Load += new System.EventHandler(this.frmPurchaseReview_Load);
            this.Controls.SetChildIndex(this.btnSrh, 0);
            this.Controls.SetChildIndex(this.label22, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lblTitle, 0);
            this.Controls.SetChildIndex(this.lblMsg, 0);
            this.Controls.SetChildIndex(this.lblClient, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.numInvoiceno, 0);
            this.Controls.SetChildIndex(this.dtpDate, 0);
            this.Controls.SetChildIndex(this.cmbClient, 0);
            this.Controls.SetChildIndex(this.lblProdCode, 0);
            this.Controls.SetChildIndex(this.txtProdCode, 0);
            this.Controls.SetChildIndex(this.lblProdName, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.txtProdName, 0);
            this.Controls.SetChildIndex(this.cmbBank, 0);
            this.Controls.SetChildIndex(this.txtAccno, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.numClientBal, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.btnBank, 0);
            this.Controls.SetChildIndex(this.btnClient, 0);
            this.Controls.SetChildIndex(this.btnProduct, 0);
            this.Controls.SetChildIndex(this.flowLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.pnlCheq, 0);
            ((System.ComponentModel.ISupportInitialize)(this.numInvoiceno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numClientBal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWhole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCredit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBillTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPaid)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnlGrid.ResumeLayout(false);
            this.pnlGrid.PerformLayout();
            this.pnlTots.ResumeLayout(false);
            this.pnlTots.PerformLayout();
            this.pnlCheq.ResumeLayout(false);
            this.pnlCheq.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnSrh;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.NumericUpDown numCost;
        private System.Windows.Forms.NumericUpDown numRetail;
        private System.Windows.Forms.NumericUpDown numStock;
        private System.Windows.Forms.NumericUpDown numWhole;
        private System.Windows.Forms.NumericUpDown numQty;
        private System.Windows.Forms.Button btnAddtoCart;
        private System.Windows.Forms.ComboBox cmbProd;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.NumericUpDown numAmount;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button btnAddIMEI;
        private System.Windows.Forms.DataGridViewImageColumn Return;
        public System.Windows.Forms.NumericUpDown numCredit;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.NumericUpDown numBillTotal;
        public System.Windows.Forms.Label label17;
        public System.Windows.Forms.NumericUpDown numDiscount;
        public System.Windows.Forms.Label label15;
        public System.Windows.Forms.NumericUpDown numPaid;
        public System.Windows.Forms.Label lblPaid;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        protected System.Windows.Forms.Label label13;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel pnlTots;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.Panel pnlCheq;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker dtpCheqDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCheq_no;
    }
}