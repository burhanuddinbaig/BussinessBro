namespace prjGrow.StockInfo
{
    partial class frmPurchase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPurchase));
            this.numWhole = new System.Windows.Forms.NumericUpDown();
            this.numCost = new System.Windows.Forms.NumericUpDown();
            this.numRetail = new System.Windows.Forms.NumericUpDown();
            this.numQty = new System.Windows.Forms.NumericUpDown();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.Remove = new System.Windows.Forms.DataGridViewImageColumn();
            this.Review = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnAddtoCart = new System.Windows.Forms.Button();
            this.lblCost = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.btnReview = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.numAmount = new System.Windows.Forms.NumericUpDown();
            this.lblExpire = new System.Windows.Forms.Label();
            this.dtpExpiry = new System.Windows.Forms.DateTimePicker();
            this.chkExpiry = new System.Windows.Forms.CheckBox();
            this.btnAddIMEI = new System.Windows.Forms.Button();
            this.pnlWhole = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlCost = new System.Windows.Forms.Panel();
            this.pnlRetail = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numCredit = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
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
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTermin = new System.Windows.Forms.ComboBox();
            this.pnlPurchase = new System.Windows.Forms.Panel();
            this.txtCheq_no = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.pnlCheq = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.dtpCheqDate = new System.Windows.Forms.DateTimePicker();
            this.pnlFrieght = new System.Windows.Forms.Panel();
            this.numFrieght = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numInvoiceno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numClientBal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWhole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).BeginInit();
            this.pnlWhole.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnlCost.SuspendLayout();
            this.pnlRetail.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCredit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBillTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPaid)).BeginInit();
            this.pnlPurchase.SuspendLayout();
            this.pnlCheq.SuspendLayout();
            this.pnlFrieght.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFrieght)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(-4, 230);
            // 
            // numInvoiceno
            // 
            this.numInvoiceno.Location = new System.Drawing.Point(149, 156);
            // 
            // cmbClient
            // 
            this.cmbClient.Location = new System.Drawing.Point(316, 155);
            this.cmbClient.Margin = new System.Windows.Forms.Padding(5);
            this.cmbClient.Size = new System.Drawing.Size(200, 32);
            this.cmbClient.SelectedIndexChanged += new System.EventHandler(this.cmbClient_SelectedIndexChanged);
            this.cmbClient.TextChanged += new System.EventHandler(this.cmbClient_TextChanged);
            // 
            // lblProdCode
            // 
            this.lblProdCode.Location = new System.Drawing.Point(312, 206);
            this.lblProdCode.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            // 
            // txtProdCode
            // 
            this.txtProdCode.Location = new System.Drawing.Point(442, 202);
            this.txtProdCode.Margin = new System.Windows.Forms.Padding(5);
            this.txtProdCode.Size = new System.Drawing.Size(200, 29);
            this.txtProdCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProdCode_KeyDown);
            // 
            // lblProdName
            // 
            this.lblProdName.Location = new System.Drawing.Point(666, 206);
            this.lblProdName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblProdName.Size = new System.Drawing.Size(75, 24);
            this.lblProdName.Text = "Product";
            // 
            // label7
            // 
            this.label7.Size = new System.Drawing.Size(2, 90);
            // 
            // txtProdName
            // 
            this.txtProdName.Location = new System.Drawing.Point(751, 203);
            this.txtProdName.Margin = new System.Windows.Forms.Padding(5);
            this.txtProdName.Size = new System.Drawing.Size(200, 29);
            this.txtProdName.TextChanged += new System.EventHandler(this.txtProdName_TextChanged);
            // 
            // txtAccno
            // 
            this.txtAccno.Location = new System.Drawing.Point(885, 156);
            this.txtAccno.Margin = new System.Windows.Forms.Padding(5);
            this.txtAccno.Size = new System.Drawing.Size(120, 29);
            this.txtAccno.TabIndex = 35;
            // 
            // cmbBank
            // 
            this.cmbBank.Location = new System.Drawing.Point(670, 154);
            this.cmbBank.Margin = new System.Windows.Forms.Padding(5);
            this.cmbBank.Size = new System.Drawing.Size(200, 32);
            this.cmbBank.SelectedValueChanged += new System.EventHandler(this.cmbBank_SelectedValueChanged);
            this.cmbBank.TextChanged += new System.EventHandler(this.cmbBank_TextChanged);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(666, 129);
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(533, 129);
            // 
            // numClientBal
            // 
            this.numClientBal.Location = new System.Drawing.Point(527, 158);
            this.numClientBal.TabIndex = 33;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(887, 129);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            // 
            // btnBank
            // 
            this.btnBank.Location = new System.Drawing.Point(798, 123);
            this.btnBank.Size = new System.Drawing.Size(72, 29);
            this.btnBank.TabIndex = 35;
            this.btnBank.TabStop = false;
            this.btnBank.Click += new System.EventHandler(this.btnBank_Click);
            // 
            // btnClient
            // 
            this.btnClient.Location = new System.Drawing.Point(442, 124);
            this.btnClient.Size = new System.Drawing.Size(74, 29);
            this.btnClient.TabIndex = 34;
            this.btnClient.TabStop = false;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.Location = new System.Drawing.Point(952, 201);
            this.btnProduct.Margin = new System.Windows.Forms.Padding(5);
            this.btnProduct.Size = new System.Drawing.Size(75, 31);
            this.btnProduct.TabIndex = 8;
            this.btnProduct.TabStop = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // numWhole
            // 
            this.numWhole.Location = new System.Drawing.Point(141, 5);
            this.numWhole.Margin = new System.Windows.Forms.Padding(4);
            this.numWhole.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numWhole.Name = "numWhole";
            this.numWhole.Size = new System.Drawing.Size(122, 29);
            this.numWhole.TabIndex = 4;
            this.numWhole.ThousandsSeparator = true;
            this.numWhole.Leave += new System.EventHandler(this.numWhole_Leave);
            // 
            // numCost
            // 
            this.numCost.Location = new System.Drawing.Point(112, 4);
            this.numCost.Margin = new System.Windows.Forms.Padding(4);
            this.numCost.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numCost.Name = "numCost";
            this.numCost.Size = new System.Drawing.Size(122, 29);
            this.numCost.TabIndex = 3;
            this.numCost.ThousandsSeparator = true;
            this.numCost.ValueChanged += new System.EventHandler(this.numCost_ValueChanged);
            // 
            // numRetail
            // 
            this.numRetail.Location = new System.Drawing.Point(128, 4);
            this.numRetail.Margin = new System.Windows.Forms.Padding(4);
            this.numRetail.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numRetail.Name = "numRetail";
            this.numRetail.Size = new System.Drawing.Size(122, 29);
            this.numRetail.TabIndex = 5;
            this.numRetail.ThousandsSeparator = true;
            this.numRetail.Leave += new System.EventHandler(this.numRetail_Leave);
            // 
            // numQty
            // 
            this.numQty.Location = new System.Drawing.Point(112, 4);
            this.numQty.Margin = new System.Windows.Forms.Padding(4);
            this.numQty.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numQty.Name = "numQty";
            this.numQty.Size = new System.Drawing.Size(122, 29);
            this.numQty.TabIndex = 6;
            this.numQty.ThousandsSeparator = true;
            this.numQty.ValueChanged += new System.EventHandler(this.numQty_ValueChanged);
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToResizeRows = false;
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Remove,
            this.Review});
            this.dgvData.Location = new System.Drawing.Point(4, 145);
            this.dgvData.Margin = new System.Windows.Forms.Padding(4);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(989, 280);
            this.dgvData.TabIndex = 77;
            this.dgvData.TabStop = false;
            this.dgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
            // 
            // Remove
            // 
            this.Remove.HeaderText = "Remove";
            this.Remove.Image = ((System.Drawing.Image)(resources.GetObject("Remove.Image")));
            this.Remove.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Remove.Name = "Remove";
            this.Remove.ReadOnly = true;
            // 
            // Review
            // 
            this.Review.HeaderText = "Review";
            this.Review.Image = ((System.Drawing.Image)(resources.GetObject("Review.Image")));
            this.Review.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Review.Name = "Review";
            this.Review.ReadOnly = true;
            this.Review.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Review.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnAddtoCart
            // 
            this.btnAddtoCart.Image = ((System.Drawing.Image)(resources.GetObject("btnAddtoCart.Image")));
            this.btnAddtoCart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddtoCart.Location = new System.Drawing.Point(120, 103);
            this.btnAddtoCart.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddtoCart.Name = "btnAddtoCart";
            this.btnAddtoCart.Size = new System.Drawing.Size(258, 38);
            this.btnAddtoCart.TabIndex = 10;
            this.btnAddtoCart.Text = "&Add to Cart";
            this.btnAddtoCart.UseVisualStyleBackColor = true;
            this.btnAddtoCart.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.ForeColor = System.Drawing.Color.White;
            this.lblCost.Location = new System.Drawing.Point(5, 7);
            this.lblCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(95, 24);
            this.lblCost.TabIndex = 79;
            this.lblCost.Text = "Cost Price";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(5, 6);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 24);
            this.label14.TabIndex = 80;
            this.label14.Text = "Quantity";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(16, 6);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(104, 24);
            this.label19.TabIndex = 81;
            this.label19.Text = "Retail Price";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(11, 7);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(113, 24);
            this.label20.TabIndex = 82;
            this.label20.Text = "Whole Price";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(312, 128);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(130, 24);
            this.label21.TabIndex = 83;
            this.label21.Text = "Suplier Name:";
            // 
            // btnReview
            // 
            this.btnReview.Location = new System.Drawing.Point(18, 342);
            this.btnReview.Margin = new System.Windows.Forms.Padding(4);
            this.btnReview.Name = "btnReview";
            this.btnReview.Size = new System.Drawing.Size(228, 38);
            this.btnReview.TabIndex = 84;
            this.btnReview.Text = "Purchase Re&view";
            this.btnReview.UseVisualStyleBackColor = true;
            this.btnReview.Click += new System.EventHandler(this.btnReview_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(270, 6);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(76, 24);
            this.label22.TabIndex = 86;
            this.label22.Text = "Amount";
            // 
            // numAmount
            // 
            this.numAmount.Enabled = false;
            this.numAmount.Location = new System.Drawing.Point(400, 4);
            this.numAmount.Margin = new System.Windows.Forms.Padding(4);
            this.numAmount.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numAmount.Name = "numAmount";
            this.numAmount.Size = new System.Drawing.Size(122, 29);
            this.numAmount.TabIndex = 7;
            this.numAmount.ThousandsSeparator = true;
            // 
            // lblExpire
            // 
            this.lblExpire.AutoSize = true;
            this.lblExpire.ForeColor = System.Drawing.Color.White;
            this.lblExpire.Location = new System.Drawing.Point(16, 6);
            this.lblExpire.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExpire.Name = "lblExpire";
            this.lblExpire.Size = new System.Drawing.Size(106, 24);
            this.lblExpire.TabIndex = 87;
            this.lblExpire.Text = "Expiry Date";
            this.lblExpire.Visible = false;
            // 
            // dtpExpiry
            // 
            this.dtpExpiry.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpExpiry.Location = new System.Drawing.Point(128, 4);
            this.dtpExpiry.Margin = new System.Windows.Forms.Padding(4);
            this.dtpExpiry.Name = "dtpExpiry";
            this.dtpExpiry.Size = new System.Drawing.Size(121, 29);
            this.dtpExpiry.TabIndex = 8;
            this.dtpExpiry.Visible = false;
            // 
            // chkExpiry
            // 
            this.chkExpiry.AutoSize = true;
            this.chkExpiry.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chkExpiry.Location = new System.Drawing.Point(790, 109);
            this.chkExpiry.Margin = new System.Windows.Forms.Padding(4);
            this.chkExpiry.Name = "chkExpiry";
            this.chkExpiry.Size = new System.Drawing.Size(109, 28);
            this.chkExpiry.TabIndex = 89;
            this.chkExpiry.TabStop = false;
            this.chkExpiry.Text = "Expirable";
            this.chkExpiry.UseVisualStyleBackColor = true;
            this.chkExpiry.Visible = false;
            this.chkExpiry.CheckedChanged += new System.EventHandler(this.chkExpiry_CheckedChanged);
            // 
            // btnAddIMEI
            // 
            this.btnAddIMEI.Enabled = false;
            this.btnAddIMEI.Location = new System.Drawing.Point(386, 103);
            this.btnAddIMEI.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddIMEI.Name = "btnAddIMEI";
            this.btnAddIMEI.Size = new System.Drawing.Size(144, 38);
            this.btnAddIMEI.TabIndex = 90;
            this.btnAddIMEI.TabStop = false;
            this.btnAddIMEI.Text = "Add IMEIs";
            this.btnAddIMEI.UseVisualStyleBackColor = true;
            this.btnAddIMEI.Visible = false;
            this.btnAddIMEI.Click += new System.EventHandler(this.btnAddIMEI_Click);
            // 
            // pnlWhole
            // 
            this.pnlWhole.Controls.Add(this.numWhole);
            this.pnlWhole.Controls.Add(this.label20);
            this.pnlWhole.Location = new System.Drawing.Point(263, 4);
            this.pnlWhole.Margin = new System.Windows.Forms.Padding(4);
            this.pnlWhole.Name = "pnlWhole";
            this.pnlWhole.Size = new System.Drawing.Size(341, 41);
            this.pnlWhole.TabIndex = 41;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.pnlCost);
            this.flowLayoutPanel1.Controls.Add(this.pnlWhole);
            this.flowLayoutPanel1.Controls.Add(this.pnlRetail);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(980, 97);
            this.flowLayoutPanel1.TabIndex = 92;
            // 
            // pnlCost
            // 
            this.pnlCost.Controls.Add(this.numCost);
            this.pnlCost.Controls.Add(this.lblCost);
            this.pnlCost.Location = new System.Drawing.Point(4, 4);
            this.pnlCost.Margin = new System.Windows.Forms.Padding(4);
            this.pnlCost.Name = "pnlCost";
            this.pnlCost.Size = new System.Drawing.Size(251, 41);
            this.pnlCost.TabIndex = 41;
            // 
            // pnlRetail
            // 
            this.pnlRetail.Controls.Add(this.numRetail);
            this.pnlRetail.Controls.Add(this.label19);
            this.pnlRetail.Location = new System.Drawing.Point(612, 4);
            this.pnlRetail.Margin = new System.Windows.Forms.Padding(4);
            this.pnlRetail.Name = "pnlRetail";
            this.pnlRetail.Size = new System.Drawing.Size(355, 41);
            this.pnlRetail.TabIndex = 43;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.numAmount);
            this.panel2.Controls.Add(this.numQty);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Location = new System.Drawing.Point(4, 53);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 41);
            this.panel2.TabIndex = 44;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtpExpiry);
            this.panel3.Controls.Add(this.lblExpire);
            this.panel3.Location = new System.Drawing.Point(612, 53);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(355, 41);
            this.panel3.TabIndex = 45;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.panel4);
            this.flowLayoutPanel2.Controls.Add(this.panel1);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(30, 242);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1278, 435);
            this.flowLayoutPanel2.TabIndex = 93;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.flowLayoutPanel1);
            this.panel4.Controls.Add(this.btnAddtoCart);
            this.panel4.Controls.Add(this.btnAddIMEI);
            this.panel4.Controls.Add(this.dgvData);
            this.panel4.Controls.Add(this.chkExpiry);
            this.panel4.Location = new System.Drawing.Point(4, 4);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(999, 430);
            this.panel4.TabIndex = 94;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numCredit);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.numBillTotal);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.numDiscount);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.numPaid);
            this.panel1.Controls.Add(this.lblPaid);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnReview);
            this.panel1.Location = new System.Drawing.Point(1011, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 428);
            this.panel1.TabIndex = 94;
            // 
            // numCredit
            // 
            this.numCredit.Enabled = false;
            this.numCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCredit.Location = new System.Drawing.Point(18, 206);
            this.numCredit.Margin = new System.Windows.Forms.Padding(4);
            this.numCredit.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numCredit.Name = "numCredit";
            this.numCredit.Size = new System.Drawing.Size(228, 31);
            this.numCredit.TabIndex = 101;
            this.numCredit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numCredit.ThousandsSeparator = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(14, 182);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 108;
            this.label3.Text = "Credit:";
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Location = new System.Drawing.Point(-21, 245);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(293, 2);
            this.label12.TabIndex = 106;
            // 
            // numBillTotal
            // 
            this.numBillTotal.Enabled = false;
            this.numBillTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numBillTotal.Location = new System.Drawing.Point(19, 29);
            this.numBillTotal.Margin = new System.Windows.Forms.Padding(4);
            this.numBillTotal.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numBillTotal.Name = "numBillTotal";
            this.numBillTotal.Size = new System.Drawing.Size(228, 31);
            this.numBillTotal.TabIndex = 98;
            this.numBillTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numBillTotal.ThousandsSeparator = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Transparent;
            this.label17.Location = new System.Drawing.Point(17, 4);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(83, 20);
            this.label17.TabIndex = 107;
            this.label17.Text = "Bill Total:";
            // 
            // numDiscount
            // 
            this.numDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDiscount.Location = new System.Drawing.Point(18, 87);
            this.numDiscount.Margin = new System.Windows.Forms.Padding(4);
            this.numDiscount.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numDiscount.Name = "numDiscount";
            this.numDiscount.Size = new System.Drawing.Size(228, 31);
            this.numDiscount.TabIndex = 99;
            this.numDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numDiscount.ThousandsSeparator = true;
            this.numDiscount.ValueChanged += new System.EventHandler(this.numDiscount_ValueChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(17, 63);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(85, 20);
            this.label15.TabIndex = 105;
            this.label15.Text = "Discount:";
            // 
            // numPaid
            // 
            this.numPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPaid.Location = new System.Drawing.Point(18, 149);
            this.numPaid.Margin = new System.Windows.Forms.Padding(4);
            this.numPaid.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numPaid.Name = "numPaid";
            this.numPaid.Size = new System.Drawing.Size(228, 31);
            this.numPaid.TabIndex = 100;
            this.numPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numPaid.ThousandsSeparator = true;
            this.numPaid.ValueChanged += new System.EventHandler(this.numPaid_ValueChanged);
            // 
            // lblPaid
            // 
            this.lblPaid.AutoSize = true;
            this.lblPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaid.ForeColor = System.Drawing.Color.Transparent;
            this.lblPaid.Location = new System.Drawing.Point(17, 125);
            this.lblPaid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaid.Name = "lblPaid";
            this.lblPaid.Size = new System.Drawing.Size(119, 20);
            this.lblPaid.TabIndex = 104;
            this.lblPaid.Text = "Paid as Cash:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(18, 387);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(228, 38);
            this.btnClose.TabIndex = 87;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(18, 296);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(228, 38);
            this.btnClear.TabIndex = 86;
            this.btnClear.Text = "Clea&r Cart";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(18, 251);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(228, 38);
            this.btnSave.TabIndex = 85;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(4, 2);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 24);
            this.label4.TabIndex = 82;
            this.label4.Text = "Purchase to:";
            // 
            // cmbTermin
            // 
            this.cmbTermin.FormattingEnabled = true;
            this.cmbTermin.Location = new System.Drawing.Point(7, 27);
            this.cmbTermin.Name = "cmbTermin";
            this.cmbTermin.Size = new System.Drawing.Size(226, 32);
            this.cmbTermin.TabIndex = 94;
            // 
            // pnlPurchase
            // 
            this.pnlPurchase.Controls.Add(this.cmbTermin);
            this.pnlPurchase.Controls.Add(this.label4);
            this.pnlPurchase.Location = new System.Drawing.Point(44, 88);
            this.pnlPurchase.Name = "pnlPurchase";
            this.pnlPurchase.Size = new System.Drawing.Size(249, 64);
            this.pnlPurchase.TabIndex = 95;
            // 
            // txtCheq_no
            // 
            this.txtCheq_no.Location = new System.Drawing.Point(8, 25);
            this.txtCheq_no.Name = "txtCheq_no";
            this.txtCheq_no.Size = new System.Drawing.Size(120, 29);
            this.txtCheq_no.TabIndex = 34;
            this.txtCheq_no.TextChanged += new System.EventHandler(this.txtCheq_no_TextChanged);
            this.txtCheq_no.Leave += new System.EventHandler(this.txtCheq_no_Leave);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(4, 0);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 24);
            this.label13.TabIndex = 97;
            this.label13.Text = "Cheque no.";
            // 
            // pnlCheq
            // 
            this.pnlCheq.Controls.Add(this.label16);
            this.pnlCheq.Controls.Add(this.dtpCheqDate);
            this.pnlCheq.Controls.Add(this.label13);
            this.pnlCheq.Controls.Add(this.txtCheq_no);
            this.pnlCheq.Location = new System.Drawing.Point(1017, 130);
            this.pnlCheq.Name = "pnlCheq";
            this.pnlCheq.Size = new System.Drawing.Size(291, 54);
            this.pnlCheq.TabIndex = 98;
            this.pnlCheq.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(155, -1);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 24);
            this.label16.TabIndex = 99;
            this.label16.Text = "Date";
            // 
            // dtpCheqDate
            // 
            this.dtpCheqDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCheqDate.Location = new System.Drawing.Point(150, 24);
            this.dtpCheqDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpCheqDate.Name = "dtpCheqDate";
            this.dtpCheqDate.Size = new System.Drawing.Size(120, 29);
            this.dtpCheqDate.TabIndex = 98;
            // 
            // pnlFrieght
            // 
            this.pnlFrieght.Controls.Add(this.numFrieght);
            this.pnlFrieght.Controls.Add(this.label18);
            this.pnlFrieght.Location = new System.Drawing.Point(1041, 197);
            this.pnlFrieght.Margin = new System.Windows.Forms.Padding(4);
            this.pnlFrieght.Name = "pnlFrieght";
            this.pnlFrieght.Size = new System.Drawing.Size(267, 36);
            this.pnlFrieght.TabIndex = 99;
            this.pnlFrieght.Visible = false;
            // 
            // numFrieght
            // 
            this.numFrieght.Location = new System.Drawing.Point(94, 3);
            this.numFrieght.Margin = new System.Windows.Forms.Padding(4);
            this.numFrieght.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numFrieght.Name = "numFrieght";
            this.numFrieght.Size = new System.Drawing.Size(152, 29);
            this.numFrieght.TabIndex = 5;
            this.numFrieght.ThousandsSeparator = true;
            this.numFrieght.ValueChanged += new System.EventHandler(this.numFrieght_ValueChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(17, 6);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(74, 24);
            this.label18.TabIndex = 81;
            this.label18.Text = "Freight:";
            // 
            // frmPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 687);
            this.Controls.Add(this.pnlFrieght);
            this.Controls.Add(this.pnlCheq);
            this.Controls.Add(this.pnlPurchase);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.label21);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = true;
            this.MaximumSize = new System.Drawing.Size(2441, 1192);
            this.Name = "frmPurchase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Purchase";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.Load += new System.EventHandler(this.frmPurchase_Load);
            this.Controls.SetChildIndex(this.label21, 0);
            this.Controls.SetChildIndex(this.flowLayoutPanel2, 0);
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
            this.Controls.SetChildIndex(this.pnlPurchase, 0);
            this.Controls.SetChildIndex(this.pnlCheq, 0);
            this.Controls.SetChildIndex(this.pnlFrieght, 0);
            ((System.ComponentModel.ISupportInitialize)(this.numInvoiceno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numClientBal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWhole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).EndInit();
            this.pnlWhole.ResumeLayout(false);
            this.pnlWhole.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnlCost.ResumeLayout(false);
            this.pnlCost.PerformLayout();
            this.pnlRetail.ResumeLayout(false);
            this.pnlRetail.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCredit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBillTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPaid)).EndInit();
            this.pnlPurchase.ResumeLayout(false);
            this.pnlPurchase.PerformLayout();
            this.pnlCheq.ResumeLayout(false);
            this.pnlCheq.PerformLayout();
            this.pnlFrieght.ResumeLayout(false);
            this.pnlFrieght.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFrieght)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numWhole;
        private System.Windows.Forms.NumericUpDown numCost;
        private System.Windows.Forms.NumericUpDown numRetail;
        private System.Windows.Forms.NumericUpDown numQty;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Button btnAddtoCart;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnReview;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.NumericUpDown numAmount;
        private System.Windows.Forms.Label lblExpire;
        private System.Windows.Forms.DateTimePicker dtpExpiry;
        private System.Windows.Forms.CheckBox chkExpiry;
        private System.Windows.Forms.Button btnAddIMEI;
        private System.Windows.Forms.DataGridViewImageColumn Remove;
        private System.Windows.Forms.DataGridViewImageColumn Review;
        private System.Windows.Forms.Panel pnlWhole;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel pnlCost;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlRetail;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.NumericUpDown numCredit;
        public System.Windows.Forms.Label label3;
        protected System.Windows.Forms.Label label12;
        public System.Windows.Forms.NumericUpDown numBillTotal;
        public System.Windows.Forms.Label label17;
        public System.Windows.Forms.NumericUpDown numDiscount;
        public System.Windows.Forms.Label label15;
        public System.Windows.Forms.NumericUpDown numPaid;
        public System.Windows.Forms.Label lblPaid;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTermin;
        private System.Windows.Forms.Panel pnlPurchase;
        private System.Windows.Forms.TextBox txtCheq_no;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel pnlCheq;
        private System.Windows.Forms.DateTimePicker dtpCheqDate;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel pnlFrieght;
        private System.Windows.Forms.NumericUpDown numFrieght;
        private System.Windows.Forms.Label label18;
    }
}