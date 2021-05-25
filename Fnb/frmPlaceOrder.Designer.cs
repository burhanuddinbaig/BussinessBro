namespace prjGrow.Fnb
{
    partial class frmPlaceOrder
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlaceOrder));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTbl = new System.Windows.Forms.Label();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.Del = new System.Windows.Forms.DataGridViewImageColumn();
            this.fpnlTbl = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.fpnlDish = new System.Windows.Forms.FlowLayoutPanel();
            this.lblClient = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvPending = new System.Windows.Forms.DataGridView();
            this.btnQeuty = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnReview = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.numBillTot = new System.Windows.Forms.NumericUpDown();
            this.numDist = new System.Windows.Forms.NumericUpDown();
            this.label28 = new System.Windows.Forms.Label();
            this.numBillAmt = new System.Windows.Forms.NumericUpDown();
            this.label29 = new System.Windows.Forms.Label();
            this.numPaid = new System.Windows.Forms.NumericUpDown();
            this.label30 = new System.Windows.Forms.Label();
            this.btnClient = new System.Windows.Forms.Button();
            this.numClientBal = new System.Windows.Forms.NumericUpDown();
            this.label31 = new System.Windows.Forms.Label();
            this.cmbClient = new System.Windows.Forms.ComboBox();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.numChange = new System.Windows.Forms.NumericUpDown();
            this.label35 = new System.Windows.Forms.Label();
            this.numCredit = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.chkPrint = new System.Windows.Forms.CheckBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.tmrMsg = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.fpnlTbl.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPending)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBillTot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBillAmt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPaid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numClientBal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCredit)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.lblTbl);
            this.flowLayoutPanel1.Controls.Add(this.dgvOrders);
            this.flowLayoutPanel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(958, 315);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(380, 382);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Order Details";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTbl
            // 
            this.lblTbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTbl.Location = new System.Drawing.Point(200, 0);
            this.lblTbl.Name = "lblTbl";
            this.lblTbl.Size = new System.Drawing.Size(162, 25);
            this.lblTbl.TabIndex = 5;
            this.lblTbl.Text = "TB-01";
            this.lblTbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AllowUserToDeleteRows = false;
            this.dgvOrders.AllowUserToResizeRows = false;
            this.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrders.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Del});
            this.dgvOrders.Location = new System.Drawing.Point(3, 28);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.RowHeadersVisible = false;
            this.dgvOrders.Size = new System.Drawing.Size(377, 354);
            this.dgvOrders.TabIndex = 6;
            this.dgvOrders.TabStop = false;
            this.dgvOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrders_CellClick);
            this.dgvOrders.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrders_CellEndEdit);
            // 
            // Del
            // 
            this.Del.FillWeight = 50F;
            this.Del.HeaderText = "Del";
            this.Del.Image = ((System.Drawing.Image)(resources.GetObject("Del.Image")));
            this.Del.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Del.Name = "Del";
            this.Del.ReadOnly = true;
            // 
            // fpnlTbl
            // 
            this.fpnlTbl.BackColor = System.Drawing.Color.LightSeaGreen;
            this.fpnlTbl.Controls.Add(this.label1);
            this.fpnlTbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.fpnlTbl.Location = new System.Drawing.Point(12, 153);
            this.fpnlTbl.Name = "fpnlTbl";
            this.fpnlTbl.Size = new System.Drawing.Size(256, 544);
            this.fpnlTbl.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tables";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fpnlDish
            // 
            this.fpnlDish.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fpnlDish.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.fpnlDish.Location = new System.Drawing.Point(274, 310);
            this.fpnlDish.Name = "fpnlDish";
            this.fpnlDish.Size = new System.Drawing.Size(678, 387);
            this.fpnlDish.TabIndex = 23;
            // 
            // lblClient
            // 
            this.lblClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClient.ForeColor = System.Drawing.Color.White;
            this.lblClient.Location = new System.Drawing.Point(7, 9);
            this.lblClient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(1350, 35);
            this.lblClient.TabIndex = 34;
            this.lblClient.Text = "Saugat Resturant";
            this.lblClient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMsg
            // 
            this.lblMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMsg.Location = new System.Drawing.Point(275, 89);
            this.lblMsg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(658, 22);
            this.lblMsg.TabIndex = 33;
            this.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(8, 48);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1350, 35);
            this.lblTitle.TabIndex = 32;
            this.lblTitle.Text = "Orders Corner";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.label5);
            this.flowLayoutPanel4.Controls.Add(this.dgvPending);
            this.flowLayoutPanel4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(958, 119);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(380, 190);
            this.flowLayoutPanel4.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(377, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Pending Orders";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvPending
            // 
            this.dgvPending.AllowUserToAddRows = false;
            this.dgvPending.AllowUserToDeleteRows = false;
            this.dgvPending.AllowUserToResizeRows = false;
            this.dgvPending.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPending.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvPending.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPending.Location = new System.Drawing.Point(3, 28);
            this.dgvPending.Name = "dgvPending";
            this.dgvPending.ReadOnly = true;
            this.dgvPending.Size = new System.Drawing.Size(377, 162);
            this.dgvPending.TabIndex = 7;
            this.dgvPending.TabStop = false;
            this.dgvPending.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPending_CellClick);
            // 
            // btnQeuty
            // 
            this.btnQeuty.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnQeuty.Location = new System.Drawing.Point(677, 269);
            this.btnQeuty.Name = "btnQeuty";
            this.btnQeuty.Size = new System.Drawing.Size(120, 35);
            this.btnQeuty.TabIndex = 14;
            this.btnQeuty.Text = "&K.O.T";
            this.btnQeuty.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(803, 269);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 35);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnReview
            // 
            this.btnReview.Location = new System.Drawing.Point(551, 269);
            this.btnReview.Name = "btnReview";
            this.btnReview.Size = new System.Drawing.Size(120, 35);
            this.btnReview.TabIndex = 13;
            this.btnReview.Text = "&Review";
            this.btnReview.UseVisualStyleBackColor = true;
            this.btnReview.Click += new System.EventHandler(this.btnReview_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(299, 269);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 35);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label27.Location = new System.Drawing.Point(278, 184);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(68, 20);
            this.label27.TabIndex = 40;
            this.label27.Text = "Bill Total";
            // 
            // numBillTot
            // 
            this.numBillTot.Enabled = false;
            this.numBillTot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numBillTot.Location = new System.Drawing.Point(366, 182);
            this.numBillTot.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numBillTot.Name = "numBillTot";
            this.numBillTot.Size = new System.Drawing.Size(120, 26);
            this.numBillTot.TabIndex = 41;
            this.numBillTot.ThousandsSeparator = true;
            // 
            // numDist
            // 
            this.numDist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDist.Location = new System.Drawing.Point(584, 182);
            this.numDist.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numDist.Name = "numDist";
            this.numDist.Size = new System.Drawing.Size(120, 26);
            this.numDist.TabIndex = 2;
            this.numDist.ThousandsSeparator = true;
            this.numDist.ValueChanged += new System.EventHandler(this.numDist_ValueChanged);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label28.Location = new System.Drawing.Point(508, 184);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(72, 20);
            this.label28.TabIndex = 42;
            this.label28.Text = "Discount";
            // 
            // numBillAmt
            // 
            this.numBillAmt.Enabled = false;
            this.numBillAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numBillAmt.Location = new System.Drawing.Point(827, 182);
            this.numBillAmt.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numBillAmt.Name = "numBillAmt";
            this.numBillAmt.Size = new System.Drawing.Size(120, 26);
            this.numBillAmt.TabIndex = 45;
            this.numBillAmt.ThousandsSeparator = true;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label29.Location = new System.Drawing.Point(725, 184);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(89, 20);
            this.label29.TabIndex = 44;
            this.label29.Text = "Bill Amount";
            // 
            // numPaid
            // 
            this.numPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPaid.Location = new System.Drawing.Point(366, 222);
            this.numPaid.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numPaid.Name = "numPaid";
            this.numPaid.Size = new System.Drawing.Size(120, 26);
            this.numPaid.TabIndex = 3;
            this.numPaid.ThousandsSeparator = true;
            this.numPaid.ValueChanged += new System.EventHandler(this.numPaid_ValueChanged);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label30.Location = new System.Drawing.Point(278, 224);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(40, 20);
            this.label30.TabIndex = 46;
            this.label30.Text = "Paid";
            // 
            // btnClient
            // 
            this.btnClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClient.Location = new System.Drawing.Point(584, 135);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(77, 24);
            this.btnClient.TabIndex = 77;
            this.btnClient.TabStop = false;
            this.btnClient.Text = "Add New";
            this.btnClient.UseVisualStyleBackColor = true;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // numClientBal
            // 
            this.numClientBal.Enabled = false;
            this.numClientBal.Location = new System.Drawing.Point(827, 134);
            this.numClientBal.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numClientBal.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.numClientBal.Name = "numClientBal";
            this.numClientBal.ReadOnly = true;
            this.numClientBal.Size = new System.Drawing.Size(120, 26);
            this.numClientBal.TabIndex = 75;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.Transparent;
            this.label31.ForeColor = System.Drawing.Color.White;
            this.label31.Location = new System.Drawing.Point(725, 136);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(71, 20);
            this.label31.TabIndex = 74;
            this.label31.Text = "Balance:";
            // 
            // cmbClient
            // 
            this.cmbClient.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbClient.FormattingEnabled = true;
            this.cmbClient.Location = new System.Drawing.Point(366, 133);
            this.cmbClient.Name = "cmbClient";
            this.cmbClient.Size = new System.Drawing.Size(212, 28);
            this.cmbClient.TabIndex = 1;
            this.cmbClient.SelectedValueChanged += new System.EventHandler(this.cmbClient_SelectedValueChanged);
            this.cmbClient.TextChanged += new System.EventHandler(this.cmbClient_TextChanged);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.Color.Transparent;
            this.label33.ForeColor = System.Drawing.Color.White;
            this.label33.Location = new System.Drawing.Point(278, 136);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(82, 20);
            this.label33.TabIndex = 78;
            this.label33.Text = "Customer:";
            // 
            // label32
            // 
            this.label32.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label32.Location = new System.Drawing.Point(278, 261);
            this.label32.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(670, 2);
            this.label32.TabIndex = 79;
            // 
            // label34
            // 
            this.label34.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label34.Location = new System.Drawing.Point(279, 169);
            this.label34.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(670, 2);
            this.label34.TabIndex = 80;
            // 
            // numChange
            // 
            this.numChange.Enabled = false;
            this.numChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numChange.Location = new System.Drawing.Point(827, 222);
            this.numChange.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numChange.Name = "numChange";
            this.numChange.Size = new System.Drawing.Size(120, 26);
            this.numChange.TabIndex = 82;
            this.numChange.ThousandsSeparator = true;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label35.Location = new System.Drawing.Point(725, 224);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(65, 20);
            this.label35.TabIndex = 81;
            this.label35.Text = "Change";
            // 
            // numCredit
            // 
            this.numCredit.Enabled = false;
            this.numCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCredit.Location = new System.Drawing.Point(584, 222);
            this.numCredit.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numCredit.Name = "numCredit";
            this.numCredit.Size = new System.Drawing.Size(120, 26);
            this.numCredit.TabIndex = 84;
            this.numCredit.ThousandsSeparator = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(508, 224);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 20);
            this.label11.TabIndex = 83;
            this.label11.Text = "Credit";
            // 
            // chkPrint
            // 
            this.chkPrint.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chkPrint.Location = new System.Drawing.Point(12, 114);
            this.chkPrint.Name = "chkPrint";
            this.chkPrint.Size = new System.Drawing.Size(256, 30);
            this.chkPrint.TabIndex = 21;
            this.chkPrint.Text = "Print Reciept";
            this.chkPrint.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(425, 269);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(120, 35);
            this.btnPrint.TabIndex = 12;
            this.btnPrint.Text = "&Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // tmrMsg
            // 
            this.tmrMsg.Interval = 3000;
            this.tmrMsg.Tick += new System.EventHandler(this.tmrMsg_Tick);
            // 
            // frmPlaceOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnQeuty);
            this.Controls.Add(this.numCredit);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.numChange);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.btnClient);
            this.Controls.Add(this.numClientBal);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.cmbClient);
            this.Controls.Add(this.chkPrint);
            this.Controls.Add(this.numPaid);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.numBillAmt);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.numDist);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.numBillTot);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnReview);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.flowLayoutPanel4);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.fpnlDish);
            this.Controls.Add(this.fpnlTbl);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmPlaceOrder";
            this.Text = "Orders Corner";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPlaceOrder_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.fpnlTbl.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPending)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBillTot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBillAmt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPaid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numClientBal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCredit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel fpnlTbl;
        private System.Windows.Forms.FlowLayoutPanel fpnlDish;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Label lblClient;
        protected System.Windows.Forms.Label lblMsg;
        protected System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTbl;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnReview;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.NumericUpDown numBillTot;
        private System.Windows.Forms.NumericUpDown numDist;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.NumericUpDown numBillAmt;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.NumericUpDown numPaid;
        private System.Windows.Forms.Label label30;
        public System.Windows.Forms.Button btnClient;
        protected System.Windows.Forms.NumericUpDown numClientBal;
        protected System.Windows.Forms.Label label31;
        protected System.Windows.Forms.ComboBox cmbClient;
        protected System.Windows.Forms.Label label33;
        protected System.Windows.Forms.Label label32;
        protected System.Windows.Forms.Label label34;
        private System.Windows.Forms.NumericUpDown numChange;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.DataGridView dgvPending;
        private System.Windows.Forms.NumericUpDown numCredit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox chkPrint;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnQeuty;
        private System.Windows.Forms.Timer tmrMsg;
        private System.Windows.Forms.DataGridViewImageColumn Del;

    }
}