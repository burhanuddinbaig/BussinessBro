namespace prjGrow.Manufacture
{
    partial class frmOrderReview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrderReview));
            this.pnlTime = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.dtpTarget = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.Remove = new System.Windows.Forms.DataGridViewImageColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.numOrder = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.numRemain = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.numAmount = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.numAdvance = new System.Windows.Forms.NumericUpDown();
            this.numTotal = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numDiscount = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCusName = new System.Windows.Forms.TextBox();
            this.lblQty = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbProdName = new System.Windows.Forms.ComboBox();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.numQty = new System.Windows.Forms.NumericUpDown();
            this.numAmtProd = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnProd = new System.Windows.Forms.Button();
            this.txtDescrip = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.gbProd = new System.Windows.Forms.GroupBox();
            this.numAdv = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.numDist = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.gbSrh.SuspendLayout();
            this.pnlTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRemain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAdvance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAmtProd)).BeginInit();
            this.gbProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAdv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDist)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSaveUpd
            // 
            this.btnSaveUpd.Location = new System.Drawing.Point(45, 403);
            this.btnSaveUpd.Size = new System.Drawing.Size(179, 35);
            this.btnSaveUpd.TabIndex = 31;
            this.btnSaveUpd.Click += new System.EventHandler(this.btnSaveUpd_Click);
            // 
            // btnReview
            // 
            this.btnReview.Location = new System.Drawing.Point(45, 444);
            this.btnReview.Size = new System.Drawing.Size(179, 35);
            this.btnReview.TabIndex = 32;
            this.btnReview.Text = "&Delete";
            this.btnReview.Click += new System.EventHandler(this.btnReview_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(45, 614);
            this.btnClose.Size = new System.Drawing.Size(179, 35);
            this.btnClose.TabIndex = 36;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(45, 572);
            this.btnClear.Size = new System.Drawing.Size(179, 35);
            this.btnClear.TabIndex = 35;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblSep
            // 
            this.lblSep.Location = new System.Drawing.Point(239, 94);
            this.lblSep.Size = new System.Drawing.Size(2, 700);
            // 
            // txtSrh
            // 
            this.txtSrh.TextChanged += new System.EventHandler(this.txtSrh_TextChanged);
            // 
            // pnlTime
            // 
            this.pnlTime.Controls.Add(this.label2);
            this.pnlTime.Controls.Add(this.dtpTime);
            this.pnlTime.Location = new System.Drawing.Point(660, 157);
            this.pnlTime.Name = "pnlTime";
            this.pnlTime.Size = new System.Drawing.Size(220, 28);
            this.pnlTime.TabIndex = 2;
            this.pnlTime.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(8, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Target Time";
            // 
            // dtpTime
            // 
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTime.Location = new System.Drawing.Point(104, 1);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(113, 26);
            this.dtpTime.TabIndex = 4;
            this.dtpTime.Value = new System.DateTime(2020, 8, 29, 18, 0, 0, 0);
            // 
            // dtpTarget
            // 
            this.dtpTarget.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTarget.Location = new System.Drawing.Point(390, 159);
            this.dtpTarget.Name = "dtpTarget";
            this.dtpTarget.Size = new System.Drawing.Size(100, 26);
            this.dtpTarget.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(278, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 20);
            this.label7.TabIndex = 100;
            this.label7.Text = "Target Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(278, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 93;
            this.label1.Text = "Customer";
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AllowUserToOrderColumns = true;
            this.dgvData.AllowUserToResizeRows = false;
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Remove});
            this.dgvData.Location = new System.Drawing.Point(247, 330);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.Size = new System.Drawing.Size(883, 320);
            this.dgvData.TabIndex = 102;
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
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Location = new System.Drawing.Point(1, 91);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(240, 3);
            this.label12.TabIndex = 105;
            // 
            // label17
            // 
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label17.Location = new System.Drawing.Point(1, 388);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(240, 3);
            this.label17.TabIndex = 104;
            // 
            // label16
            // 
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label16.Location = new System.Drawing.Point(1, 177);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(240, 3);
            this.label16.TabIndex = 103;
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(124, 142);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(100, 26);
            this.dtpDate.TabIndex = 42;
            // 
            // numOrder
            // 
            this.numOrder.Location = new System.Drawing.Point(124, 104);
            this.numOrder.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numOrder.Name = "numOrder";
            this.numOrder.Size = new System.Drawing.Size(100, 26);
            this.numOrder.TabIndex = 41;
            this.numOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numOrder.ThousandsSeparator = true;
            this.numOrder.ValueChanged += new System.EventHandler(this.numOrder_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(36, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 107;
            this.label6.Text = "Order no";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(36, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 106;
            this.label4.Text = "Order Date";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(45, 530);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(179, 35);
            this.btnPrint.TabIndex = 34;
            this.btnPrint.Text = "&Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // numRemain
            // 
            this.numRemain.Enabled = false;
            this.numRemain.Location = new System.Drawing.Point(124, 350);
            this.numRemain.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numRemain.Name = "numRemain";
            this.numRemain.Size = new System.Drawing.Size(100, 26);
            this.numRemain.TabIndex = 120;
            this.numRemain.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numRemain.ThousandsSeparator = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label18.Location = new System.Drawing.Point(36, 352);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(85, 20);
            this.label18.TabIndex = 119;
            this.label18.Text = "Remaining";
            // 
            // numAmount
            // 
            this.numAmount.Enabled = false;
            this.numAmount.Location = new System.Drawing.Point(124, 270);
            this.numAmount.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numAmount.Name = "numAmount";
            this.numAmount.Size = new System.Drawing.Size(100, 26);
            this.numAmount.TabIndex = 115;
            this.numAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numAmount.ThousandsSeparator = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Location = new System.Drawing.Point(36, 272);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 20);
            this.label14.TabIndex = 113;
            this.label14.Text = "Amount";
            // 
            // numAdvance
            // 
            this.numAdvance.Enabled = false;
            this.numAdvance.Location = new System.Drawing.Point(124, 310);
            this.numAdvance.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numAdvance.Name = "numAdvance";
            this.numAdvance.Size = new System.Drawing.Size(100, 26);
            this.numAdvance.TabIndex = 22;
            this.numAdvance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numAdvance.ThousandsSeparator = true;
            // 
            // numTotal
            // 
            this.numTotal.Enabled = false;
            this.numTotal.Location = new System.Drawing.Point(124, 191);
            this.numTotal.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numTotal.Name = "numTotal";
            this.numTotal.Size = new System.Drawing.Size(100, 26);
            this.numTotal.TabIndex = 116;
            this.numTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numTotal.ThousandsSeparator = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label15.Location = new System.Drawing.Point(36, 312);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 20);
            this.label15.TabIndex = 114;
            this.label15.Text = "Advance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(36, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 111;
            this.label5.Text = "Total";
            // 
            // numDiscount
            // 
            this.numDiscount.Enabled = false;
            this.numDiscount.Location = new System.Drawing.Point(124, 230);
            this.numDiscount.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numDiscount.Name = "numDiscount";
            this.numDiscount.Size = new System.Drawing.Size(100, 26);
            this.numDiscount.TabIndex = 21;
            this.numDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numDiscount.ThousandsSeparator = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(36, 232);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 20);
            this.label13.TabIndex = 112;
            this.label13.Text = "Discount";
            // 
            // txtCusName
            // 
            this.txtCusName.Location = new System.Drawing.Point(390, 122);
            this.txtCusName.Name = "txtCusName";
            this.txtCusName.ReadOnly = true;
            this.txtCusName.Size = new System.Drawing.Size(200, 26);
            this.txtCusName.TabIndex = 95;
            this.txtCusName.TabStop = false;
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(683, 23);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(68, 20);
            this.lblQty.TabIndex = 7;
            this.lblQty.Text = "Quantity";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 20);
            this.label10.TabIndex = 8;
            this.label10.Text = "Product Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(447, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Price";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Amount";
            // 
            // cmbProdName
            // 
            this.cmbProdName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbProdName.FormattingEnabled = true;
            this.cmbProdName.Location = new System.Drawing.Point(143, 20);
            this.cmbProdName.Name = "cmbProdName";
            this.cmbProdName.Size = new System.Drawing.Size(200, 28);
            this.cmbProdName.TabIndex = 12;
            // 
            // numPrice
            // 
            this.numPrice.Location = new System.Drawing.Point(518, 21);
            this.numPrice.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(100, 26);
            this.numPrice.TabIndex = 13;
            this.numPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numPrice.ThousandsSeparator = true;
            this.numPrice.ValueChanged += new System.EventHandler(this.numPrice_ValueChanged);
            // 
            // numQty
            // 
            this.numQty.Location = new System.Drawing.Point(760, 21);
            this.numQty.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numQty.Name = "numQty";
            this.numQty.Size = new System.Drawing.Size(100, 26);
            this.numQty.TabIndex = 14;
            this.numQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numQty.ThousandsSeparator = true;
            this.numQty.ValueChanged += new System.EventHandler(this.numPrice_ValueChanged);
            // 
            // numAmtProd
            // 
            this.numAmtProd.Enabled = false;
            this.numAmtProd.Location = new System.Drawing.Point(143, 58);
            this.numAmtProd.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numAmtProd.Name = "numAmtProd";
            this.numAmtProd.Size = new System.Drawing.Size(100, 26);
            this.numAmtProd.TabIndex = 16;
            this.numAmtProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numAmtProd.ThousandsSeparator = true;
            this.numAmtProd.ValueChanged += new System.EventHandler(this.numAmtProd_ValueChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAdd.Location = new System.Drawing.Point(687, 95);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(173, 30);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnProd
            // 
            this.btnProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnProd.Location = new System.Drawing.Point(349, 20);
            this.btnProd.Name = "btnProd";
            this.btnProd.Size = new System.Drawing.Size(53, 28);
            this.btnProd.TabIndex = 92;
            this.btnProd.TabStop = false;
            this.btnProd.Text = "Add";
            this.btnProd.UseVisualStyleBackColor = true;
            this.btnProd.Click += new System.EventHandler(this.btnProd_Click);
            // 
            // txtDescrip
            // 
            this.txtDescrip.Location = new System.Drawing.Point(143, 95);
            this.txtDescrip.Name = "txtDescrip";
            this.txtDescrip.Size = new System.Drawing.Size(475, 26);
            this.txtDescrip.TabIndex = 15;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(31, 98);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(89, 20);
            this.label19.TabIndex = 94;
            this.label19.Text = "Description";
            // 
            // gbProd
            // 
            this.gbProd.Controls.Add(this.numAdv);
            this.gbProd.Controls.Add(this.label20);
            this.gbProd.Controls.Add(this.numDist);
            this.gbProd.Controls.Add(this.label3);
            this.gbProd.Controls.Add(this.label19);
            this.gbProd.Controls.Add(this.txtDescrip);
            this.gbProd.Controls.Add(this.btnProd);
            this.gbProd.Controls.Add(this.btnAdd);
            this.gbProd.Controls.Add(this.numAmtProd);
            this.gbProd.Controls.Add(this.numQty);
            this.gbProd.Controls.Add(this.numPrice);
            this.gbProd.Controls.Add(this.cmbProdName);
            this.gbProd.Controls.Add(this.label8);
            this.gbProd.Controls.Add(this.label9);
            this.gbProd.Controls.Add(this.label10);
            this.gbProd.Controls.Add(this.lblQty);
            this.gbProd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbProd.Location = new System.Drawing.Point(247, 188);
            this.gbProd.Name = "gbProd";
            this.gbProd.Size = new System.Drawing.Size(883, 136);
            this.gbProd.TabIndex = 10;
            this.gbProd.TabStop = false;
            this.gbProd.Text = "Products";
            // 
            // numAdv
            // 
            this.numAdv.Location = new System.Drawing.Point(760, 58);
            this.numAdv.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numAdv.Name = "numAdv";
            this.numAdv.Size = new System.Drawing.Size(100, 26);
            this.numAdv.TabIndex = 98;
            this.numAdv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numAdv.ThousandsSeparator = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(683, 60);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(71, 20);
            this.label20.TabIndex = 97;
            this.label20.Text = "Advance";
            // 
            // numDist
            // 
            this.numDist.Location = new System.Drawing.Point(518, 58);
            this.numDist.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numDist.Name = "numDist";
            this.numDist.Size = new System.Drawing.Size(100, 26);
            this.numDist.TabIndex = 96;
            this.numDist.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numDist.ThousandsSeparator = true;
            this.numDist.ValueChanged += new System.EventHandler(this.numDist_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(447, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 95;
            this.label3.Text = "Discount";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(45, 487);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(179, 35);
            this.btnShow.TabIndex = 33;
            this.btnShow.Text = "S&how Orders";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // frmOrderReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 686);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.txtCusName);
            this.Controls.Add(this.numRemain);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.numAmount);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.numAdvance);
            this.Controls.Add(this.numTotal);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numDiscount);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.numOrder);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.pnlTime);
            this.Controls.Add(this.dtpTarget);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbProd);
            this.Name = "frmOrderReview";
            this.Text = "Order Review";
            this.Load += new System.EventHandler(this.frmOrderReview_Load);
            this.Controls.SetChildIndex(this.gbProd, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.dtpTarget, 0);
            this.Controls.SetChildIndex(this.pnlTime, 0);
            this.Controls.SetChildIndex(this.dgvData, 0);
            this.Controls.SetChildIndex(this.label16, 0);
            this.Controls.SetChildIndex(this.label17, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.numOrder, 0);
            this.Controls.SetChildIndex(this.dtpDate, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.numDiscount, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label15, 0);
            this.Controls.SetChildIndex(this.numTotal, 0);
            this.Controls.SetChildIndex(this.numAdvance, 0);
            this.Controls.SetChildIndex(this.label14, 0);
            this.Controls.SetChildIndex(this.numAmount, 0);
            this.Controls.SetChildIndex(this.label18, 0);
            this.Controls.SetChildIndex(this.numRemain, 0);
            this.Controls.SetChildIndex(this.txtCusName, 0);
            this.Controls.SetChildIndex(this.btnSaveUpd, 0);
            this.Controls.SetChildIndex(this.btnReview, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.lblTitle, 0);
            this.Controls.SetChildIndex(this.lblMsg, 0);
            this.Controls.SetChildIndex(this.lblClient, 0);
            this.Controls.SetChildIndex(this.btnClear, 0);
            this.Controls.SetChildIndex(this.lblSep, 0);
            this.Controls.SetChildIndex(this.gbSrh, 0);
            this.Controls.SetChildIndex(this.btnShow, 0);
            this.gbSrh.ResumeLayout(false);
            this.gbSrh.PerformLayout();
            this.pnlTime.ResumeLayout(false);
            this.pnlTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRemain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAdvance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAmtProd)).EndInit();
            this.gbProd.ResumeLayout(false);
            this.gbProd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAdv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.DateTimePicker dtpTarget;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvData;
        protected System.Windows.Forms.Label label12;
        protected System.Windows.Forms.Label label17;
        protected System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.NumericUpDown numOrder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.NumericUpDown numRemain;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown numAmount;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown numAdvance;
        private System.Windows.Forms.NumericUpDown numTotal;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numDiscount;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCusName;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbProdName;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.NumericUpDown numQty;
        private System.Windows.Forms.NumericUpDown numAmtProd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnProd;
        private System.Windows.Forms.TextBox txtDescrip;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox gbProd;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.DataGridViewImageColumn Remove;
        private System.Windows.Forms.NumericUpDown numAdv;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.NumericUpDown numDist;
        private System.Windows.Forms.Label label3;
    }
}