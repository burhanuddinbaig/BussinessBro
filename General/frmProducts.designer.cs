namespace prjGrow.General
{
    partial class frmProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProducts));
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.Disable = new System.Windows.Forms.DataGridViewImageColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlRetail = new System.Windows.Forms.Panel();
            this.numRetail = new System.Windows.Forms.NumericUpDown();
            this.pnlWhole = new System.Windows.Forms.Panel();
            this.numWhole = new System.Windows.Forms.NumericUpDown();
            this.pnlCost = new System.Windows.Forms.Panel();
            this.numCost = new System.Windows.Forms.NumericUpDown();
            this.pnlStock = new System.Windows.Forms.Panel();
            this.numStock = new System.Windows.Forms.NumericUpDown();
            this.txtProdCode = new System.Windows.Forms.TextBox();
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.gbOptions = new System.Windows.Forms.GroupBox();
            this.rbStore = new System.Windows.Forms.RadioButton();
            this.rbShop = new System.Windows.Forms.RadioButton();
            this.chkExpiry = new System.Windows.Forms.CheckBox();
            this.chkStock = new System.Windows.Forms.CheckBox();
            this.chkCost = new System.Windows.Forms.CheckBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddType = new System.Windows.Forms.Button();
            this.rbRaw = new System.Windows.Forms.RadioButton();
            this.rbGadget = new System.Windows.Forms.RadioButton();
            this.pnlCategory = new System.Windows.Forms.Panel();
            this.rbServ = new System.Windows.Forms.RadioButton();
            this.rbPartial = new System.Windows.Forms.RadioButton();
            this.rbMobile = new System.Windows.Forms.RadioButton();
            this.rbCake = new System.Windows.Forms.RadioButton();
            this.rbStock = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.pnlUnit = new System.Windows.Forms.Panel();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlExp = new System.Windows.Forms.Panel();
            this.dtpExpiry = new System.Windows.Forms.DateTimePicker();
            this.lblExpire = new System.Windows.Forms.Label();
            this.gbSrh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.pnlRetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRetail)).BeginInit();
            this.pnlWhole.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWhole)).BeginInit();
            this.pnlCost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCost)).BeginInit();
            this.pnlStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).BeginInit();
            this.gbOptions.SuspendLayout();
            this.pnlCategory.SuspendLayout();
            this.pnlUnit.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnlExp.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Text = "E Light Software Solutions, Pakistan LTD";
            // 
            // lblMsg
            // 
            this.lblMsg.Location = new System.Drawing.Point(228, 93);
            // 
            // btnClear
            // 
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSaveUpd
            // 
            this.btnSaveUpd.Click += new System.EventHandler(this.btnSaveUpd_Click);
            // 
            // txtSrh
            // 
            this.txtSrh.TabIndex = 31;
            this.txtSrh.TextChanged += new System.EventHandler(this.txtSrh_TextChanged);
            // 
            // gbSrh
            // 
            this.gbSrh.Location = new System.Drawing.Point(805, 90);
            this.gbSrh.TabIndex = 30;
            // 
            // lblClient
            // 
            this.lblClient.Location = new System.Drawing.Point(50, 7);
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AllowUserToResizeRows = false;
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit,
            this.Delete,
            this.Disable});
            this.dgvData.Location = new System.Drawing.Point(55, 348);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.Size = new System.Drawing.Size(898, 332);
            this.dgvData.TabIndex = 25;
            this.dgvData.TabStop = false;
            this.dgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
            // 
            // Edit
            // 
            this.Edit.FillWeight = 40F;
            this.Edit.HeaderText = "Edit";
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            // 
            // Delete
            // 
            this.Delete.FillWeight = 40F;
            this.Delete.HeaderText = "Delete";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            // 
            // Disable
            // 
            this.Disable.FillWeight = 50F;
            this.Disable.HeaderText = "Disable";
            this.Disable.Image = global::prjGrow.Properties.Resources.disable;
            this.Disable.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Disable.Name = "Disable";
            this.Disable.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(441, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Product Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(91, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Product Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(64, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Cost";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(53, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 31;
            this.label6.Text = "Whole";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(60, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 20);
            this.label7.TabIndex = 32;
            this.label7.Text = "Retail";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(56, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 20);
            this.label8.TabIndex = 33;
            this.label8.Text = "Stock";
            // 
            // pnlRetail
            // 
            this.pnlRetail.Controls.Add(this.numRetail);
            this.pnlRetail.Controls.Add(this.label7);
            this.pnlRetail.Location = new System.Drawing.Point(469, 3);
            this.pnlRetail.Name = "pnlRetail";
            this.pnlRetail.Size = new System.Drawing.Size(230, 31);
            this.pnlRetail.TabIndex = 6;
            // 
            // numRetail
            // 
            this.numRetail.Location = new System.Drawing.Point(117, 2);
            this.numRetail.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numRetail.Name = "numRetail";
            this.numRetail.Size = new System.Drawing.Size(100, 26);
            this.numRetail.TabIndex = 6;
            this.numRetail.ValueChanged += new System.EventHandler(this.numRetail_ValueChanged);
            // 
            // pnlWhole
            // 
            this.pnlWhole.Controls.Add(this.label6);
            this.pnlWhole.Controls.Add(this.numWhole);
            this.pnlWhole.Location = new System.Drawing.Point(236, 3);
            this.pnlWhole.Name = "pnlWhole";
            this.pnlWhole.Size = new System.Drawing.Size(227, 31);
            this.pnlWhole.TabIndex = 5;
            // 
            // numWhole
            // 
            this.numWhole.DecimalPlaces = 2;
            this.numWhole.Location = new System.Drawing.Point(117, 2);
            this.numWhole.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numWhole.Name = "numWhole";
            this.numWhole.Size = new System.Drawing.Size(100, 26);
            this.numWhole.TabIndex = 5;
            this.numWhole.ValueChanged += new System.EventHandler(this.numWhole_ValueChanged);
            // 
            // pnlCost
            // 
            this.pnlCost.Controls.Add(this.numCost);
            this.pnlCost.Controls.Add(this.label4);
            this.pnlCost.Location = new System.Drawing.Point(3, 3);
            this.pnlCost.Name = "pnlCost";
            this.pnlCost.Size = new System.Drawing.Size(227, 31);
            this.pnlCost.TabIndex = 4;
            // 
            // numCost
            // 
            this.numCost.Location = new System.Drawing.Point(117, 2);
            this.numCost.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numCost.Name = "numCost";
            this.numCost.Size = new System.Drawing.Size(100, 26);
            this.numCost.TabIndex = 4;
            // 
            // pnlStock
            // 
            this.pnlStock.Controls.Add(this.numStock);
            this.pnlStock.Controls.Add(this.label8);
            this.pnlStock.ForeColor = System.Drawing.Color.White;
            this.pnlStock.Location = new System.Drawing.Point(3, 40);
            this.pnlStock.Name = "pnlStock";
            this.pnlStock.Size = new System.Drawing.Size(227, 30);
            this.pnlStock.TabIndex = 7;
            this.pnlStock.Visible = false;
            // 
            // numStock
            // 
            this.numStock.Location = new System.Drawing.Point(116, 3);
            this.numStock.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numStock.Name = "numStock";
            this.numStock.Size = new System.Drawing.Size(100, 26);
            this.numStock.TabIndex = 8;
            // 
            // txtProdCode
            // 
            this.txtProdCode.Location = new System.Drawing.Point(203, 159);
            this.txtProdCode.MaxLength = 32;
            this.txtProdCode.Name = "txtProdCode";
            this.txtProdCode.Size = new System.Drawing.Size(200, 26);
            this.txtProdCode.TabIndex = 1;
            this.txtProdCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtProdCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProdCode_KeyDown);
            // 
            // txtProdName
            // 
            this.txtProdName.Location = new System.Drawing.Point(557, 159);
            this.txtProdName.MaxLength = 40;
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Size = new System.Drawing.Size(200, 26);
            this.txtProdName.TabIndex = 2;
            // 
            // gbOptions
            // 
            this.gbOptions.Controls.Add(this.rbStore);
            this.gbOptions.Controls.Add(this.rbShop);
            this.gbOptions.Controls.Add(this.chkExpiry);
            this.gbOptions.Controls.Add(this.chkStock);
            this.gbOptions.Controls.Add(this.chkCost);
            this.gbOptions.ForeColor = System.Drawing.Color.White;
            this.gbOptions.Location = new System.Drawing.Point(803, 153);
            this.gbOptions.Name = "gbOptions";
            this.gbOptions.Size = new System.Drawing.Size(150, 151);
            this.gbOptions.TabIndex = 32;
            this.gbOptions.TabStop = false;
            this.gbOptions.Text = "Options";
            // 
            // rbStore
            // 
            this.rbStore.AutoSize = true;
            this.rbStore.Location = new System.Drawing.Point(79, 116);
            this.rbStore.Name = "rbStore";
            this.rbStore.Size = new System.Drawing.Size(66, 24);
            this.rbStore.TabIndex = 92;
            this.rbStore.Text = "Store";
            this.rbStore.UseVisualStyleBackColor = true;
            this.rbStore.Visible = false;
            this.rbStore.CheckedChanged += new System.EventHandler(this.rbStore_CheckedChanged);
            // 
            // rbShop
            // 
            this.rbShop.AutoSize = true;
            this.rbShop.Checked = true;
            this.rbShop.Location = new System.Drawing.Point(10, 116);
            this.rbShop.Name = "rbShop";
            this.rbShop.Size = new System.Drawing.Size(65, 24);
            this.rbShop.TabIndex = 91;
            this.rbShop.TabStop = true;
            this.rbShop.Text = "Shop";
            this.rbShop.UseVisualStyleBackColor = true;
            this.rbShop.Visible = false;
            this.rbShop.CheckedChanged += new System.EventHandler(this.rbShop_CheckedChanged);
            // 
            // chkExpiry
            // 
            this.chkExpiry.AutoSize = true;
            this.chkExpiry.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chkExpiry.Location = new System.Drawing.Point(10, 86);
            this.chkExpiry.Name = "chkExpiry";
            this.chkExpiry.Size = new System.Drawing.Size(93, 24);
            this.chkExpiry.TabIndex = 90;
            this.chkExpiry.TabStop = false;
            this.chkExpiry.Text = "Expirable";
            this.chkExpiry.UseVisualStyleBackColor = true;
            this.chkExpiry.Visible = false;
            this.chkExpiry.CheckedChanged += new System.EventHandler(this.chkExpiry_CheckedChanged);
            // 
            // chkStock
            // 
            this.chkStock.AutoSize = true;
            this.chkStock.Location = new System.Drawing.Point(10, 56);
            this.chkStock.Name = "chkStock";
            this.chkStock.Size = new System.Drawing.Size(133, 24);
            this.chkStock.TabIndex = 34;
            this.chkStock.Text = "&Opening Stock";
            this.chkStock.UseVisualStyleBackColor = true;
            this.chkStock.CheckedChanged += new System.EventHandler(this.chkStock_CheckedChanged);
            // 
            // chkCost
            // 
            this.chkCost.AutoSize = true;
            this.chkCost.Location = new System.Drawing.Point(10, 26);
            this.chkCost.Name = "chkCost";
            this.chkCost.Size = new System.Drawing.Size(94, 24);
            this.chkCost.TabIndex = 33;
            this.chkCost.Text = "&Add Cost";
            this.chkCost.UseVisualStyleBackColor = true;
            this.chkCost.CheckedChanged += new System.EventHandler(this.chkCost_CheckedChanged);
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(203, 196);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(200, 28);
            this.cmbType.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(91, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Product Type";
            // 
            // btnAddType
            // 
            this.btnAddType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddType.Location = new System.Drawing.Point(409, 196);
            this.btnAddType.Name = "btnAddType";
            this.btnAddType.Size = new System.Drawing.Size(65, 28);
            this.btnAddType.TabIndex = 35;
            this.btnAddType.TabStop = false;
            this.btnAddType.Text = "Add";
            this.btnAddType.UseVisualStyleBackColor = true;
            this.btnAddType.Click += new System.EventHandler(this.btnAddType_Click);
            // 
            // rbRaw
            // 
            this.rbRaw.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbRaw.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbRaw.Location = new System.Drawing.Point(98, 0);
            this.rbRaw.Name = "rbRaw";
            this.rbRaw.Size = new System.Drawing.Size(139, 26);
            this.rbRaw.TabIndex = 36;
            this.rbRaw.Text = "Raw Materials";
            this.rbRaw.UseVisualStyleBackColor = true;
            this.rbRaw.CheckedChanged += new System.EventHandler(this.rbMatiral_CheckedChanged);
            // 
            // rbGadget
            // 
            this.rbGadget.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbGadget.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbGadget.Location = new System.Drawing.Point(0, 0);
            this.rbGadget.Name = "rbGadget";
            this.rbGadget.Size = new System.Drawing.Size(98, 26);
            this.rbGadget.TabIndex = 37;
            this.rbGadget.Text = "Gadget";
            this.rbGadget.UseVisualStyleBackColor = true;
            this.rbGadget.CheckedChanged += new System.EventHandler(this.rbGadget_CheckedChanged);
            // 
            // pnlCategory
            // 
            this.pnlCategory.Controls.Add(this.rbServ);
            this.pnlCategory.Controls.Add(this.rbPartial);
            this.pnlCategory.Controls.Add(this.rbMobile);
            this.pnlCategory.Controls.Add(this.rbCake);
            this.pnlCategory.Controls.Add(this.rbStock);
            this.pnlCategory.Controls.Add(this.rbRaw);
            this.pnlCategory.Controls.Add(this.rbGadget);
            this.pnlCategory.Location = new System.Drawing.Point(204, 127);
            this.pnlCategory.Name = "pnlCategory";
            this.pnlCategory.Size = new System.Drawing.Size(749, 26);
            this.pnlCategory.TabIndex = 38;
            // 
            // rbServ
            // 
            this.rbServ.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbServ.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbServ.Location = new System.Drawing.Point(631, 0);
            this.rbServ.Name = "rbServ";
            this.rbServ.Size = new System.Drawing.Size(99, 26);
            this.rbServ.TabIndex = 42;
            this.rbServ.Text = "Service";
            this.rbServ.UseVisualStyleBackColor = true;
            this.rbServ.CheckedChanged += new System.EventHandler(this.rbServ_CheckedChanged);
            // 
            // rbPartial
            // 
            this.rbPartial.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbPartial.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbPartial.Location = new System.Drawing.Point(532, 0);
            this.rbPartial.Name = "rbPartial";
            this.rbPartial.Size = new System.Drawing.Size(99, 26);
            this.rbPartial.TabIndex = 41;
            this.rbPartial.Text = "Partial";
            this.rbPartial.UseVisualStyleBackColor = true;
            this.rbPartial.CheckedChanged += new System.EventHandler(this.rbPartial_CheckedChanged);
            // 
            // rbMobile
            // 
            this.rbMobile.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbMobile.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbMobile.Location = new System.Drawing.Point(439, 0);
            this.rbMobile.Name = "rbMobile";
            this.rbMobile.Size = new System.Drawing.Size(93, 26);
            this.rbMobile.TabIndex = 40;
            this.rbMobile.Text = "Mobiles";
            this.rbMobile.UseVisualStyleBackColor = true;
            this.rbMobile.CheckedChanged += new System.EventHandler(this.rbMobile_CheckedChanged);
            // 
            // rbCake
            // 
            this.rbCake.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbCake.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbCake.Location = new System.Drawing.Point(350, 0);
            this.rbCake.Name = "rbCake";
            this.rbCake.Size = new System.Drawing.Size(89, 26);
            this.rbCake.TabIndex = 39;
            this.rbCake.Text = "Bakery";
            this.rbCake.UseVisualStyleBackColor = true;
            this.rbCake.CheckedChanged += new System.EventHandler(this.rbCake_CheckedChanged);
            // 
            // rbStock
            // 
            this.rbStock.Checked = true;
            this.rbStock.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbStock.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbStock.Location = new System.Drawing.Point(237, 0);
            this.rbStock.Name = "rbStock";
            this.rbStock.Size = new System.Drawing.Size(113, 26);
            this.rbStock.TabIndex = 38;
            this.rbStock.TabStop = true;
            this.rbStock.Text = "Stock Item";
            this.rbStock.UseVisualStyleBackColor = true;
            this.rbStock.CheckedChanged += new System.EventHandler(this.rbStock_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(32, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 20);
            this.label9.TabIndex = 40;
            this.label9.Text = "Unit";
            // 
            // pnlUnit
            // 
            this.pnlUnit.Controls.Add(this.cmbUnit);
            this.pnlUnit.Controls.Add(this.label9);
            this.pnlUnit.Location = new System.Drawing.Point(480, 194);
            this.pnlUnit.Name = "pnlUnit";
            this.pnlUnit.Size = new System.Drawing.Size(195, 30);
            this.pnlUnit.TabIndex = 4;
            this.pnlUnit.Visible = false;
            // 
            // cmbUnit
            // 
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.Location = new System.Drawing.Point(77, 0);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(100, 28);
            this.cmbUnit.TabIndex = 41;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.pnlCost);
            this.flowLayoutPanel1.Controls.Add(this.pnlWhole);
            this.flowLayoutPanel1.Controls.Add(this.pnlRetail);
            this.flowLayoutPanel1.Controls.Add(this.pnlStock);
            this.flowLayoutPanel1.Controls.Add(this.pnlExp);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(83, 228);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(704, 76);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // pnlExp
            // 
            this.pnlExp.Controls.Add(this.dtpExpiry);
            this.pnlExp.Controls.Add(this.lblExpire);
            this.pnlExp.ForeColor = System.Drawing.Color.White;
            this.pnlExp.Location = new System.Drawing.Point(236, 40);
            this.pnlExp.Name = "pnlExp";
            this.pnlExp.Size = new System.Drawing.Size(227, 30);
            this.pnlExp.TabIndex = 8;
            this.pnlExp.Visible = false;
            // 
            // dtpExpiry
            // 
            this.dtpExpiry.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpExpiry.Location = new System.Drawing.Point(117, 1);
            this.dtpExpiry.Name = "dtpExpiry";
            this.dtpExpiry.Size = new System.Drawing.Size(100, 26);
            this.dtpExpiry.TabIndex = 88;
            // 
            // lblExpire
            // 
            this.lblExpire.AutoSize = true;
            this.lblExpire.ForeColor = System.Drawing.Color.White;
            this.lblExpire.Location = new System.Drawing.Point(22, 4);
            this.lblExpire.Name = "lblExpire";
            this.lblExpire.Size = new System.Drawing.Size(90, 20);
            this.lblExpire.TabIndex = 89;
            this.lblExpire.Text = "Expiry Date";
            // 
            // frmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 711);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pnlUnit);
            this.Controls.Add(this.pnlCategory);
            this.Controls.Add(this.btnAddType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.gbOptions);
            this.Controls.Add(this.txtProdName);
            this.Controls.Add(this.txtProdCode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvData);
            this.Name = "frmProducts";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.frmProducts_Load);
            this.Controls.SetChildIndex(this.dgvData, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtProdCode, 0);
            this.Controls.SetChildIndex(this.txtProdName, 0);
            this.Controls.SetChildIndex(this.gbOptions, 0);
            this.Controls.SetChildIndex(this.cmbType, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.btnAddType, 0);
            this.Controls.SetChildIndex(this.pnlCategory, 0);
            this.Controls.SetChildIndex(this.pnlUnit, 0);
            this.Controls.SetChildIndex(this.lblMsg, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lblTitle, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnClear, 0);
            this.Controls.SetChildIndex(this.btnSaveUpd, 0);
            this.Controls.SetChildIndex(this.gbSrh, 0);
            this.Controls.SetChildIndex(this.lblClient, 0);
            this.Controls.SetChildIndex(this.flowLayoutPanel1, 0);
            this.gbSrh.ResumeLayout(false);
            this.gbSrh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.pnlRetail.ResumeLayout(false);
            this.pnlRetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRetail)).EndInit();
            this.pnlWhole.ResumeLayout(false);
            this.pnlWhole.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWhole)).EndInit();
            this.pnlCost.ResumeLayout(false);
            this.pnlCost.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCost)).EndInit();
            this.pnlStock.ResumeLayout(false);
            this.pnlStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).EndInit();
            this.gbOptions.ResumeLayout(false);
            this.gbOptions.PerformLayout();
            this.pnlCategory.ResumeLayout(false);
            this.pnlUnit.ResumeLayout(false);
            this.pnlUnit.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnlExp.ResumeLayout(false);
            this.pnlExp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numRetail;
        private System.Windows.Forms.NumericUpDown numWhole;
        private System.Windows.Forms.NumericUpDown numCost;
        private System.Windows.Forms.Panel pnlStock;
        private System.Windows.Forms.NumericUpDown numStock;
        private System.Windows.Forms.TextBox txtProdName;
        private System.Windows.Forms.GroupBox gbOptions;
        private System.Windows.Forms.CheckBox chkStock;
        private System.Windows.Forms.CheckBox chkCost;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddType;
        private System.Windows.Forms.RadioButton rbRaw;
        private System.Windows.Forms.RadioButton rbGadget;
        private System.Windows.Forms.Panel pnlCategory;
        private System.Windows.Forms.RadioButton rbStock;
        private System.Windows.Forms.RadioButton rbMobile;
        private System.Windows.Forms.RadioButton rbCake;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pnlUnit;
        private System.Windows.Forms.ComboBox cmbUnit;
        private System.Windows.Forms.RadioButton rbPartial;
        private System.Windows.Forms.Panel pnlRetail;
        private System.Windows.Forms.Panel pnlCost;
        private System.Windows.Forms.Panel pnlWhole;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton rbServ;
        private System.Windows.Forms.Panel pnlExp;
        private System.Windows.Forms.DateTimePicker dtpExpiry;
        private System.Windows.Forms.Label lblExpire;
        private System.Windows.Forms.CheckBox chkExpiry;
        public System.Windows.Forms.TextBox txtProdCode;
        private System.Windows.Forms.RadioButton rbShop;
        private System.Windows.Forms.RadioButton rbStore;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.DataGridViewImageColumn Disable;
    }
}