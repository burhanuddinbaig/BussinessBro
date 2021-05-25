namespace prjGrow.StockInfo
{
    partial class frmTmp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTmp));
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtReference = new System.Windows.Forms.TextBox();
            this.rbRetail = new System.Windows.Forms.RadioButton();
            this.rbWhole = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.chkBill = new System.Windows.Forms.CheckBox();
            this.btnReiew = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.numChange = new System.Windows.Forms.NumericUpDown();
            this.btnAddIMEI = new System.Windows.Forms.Button();
            this.btnDeliver = new System.Windows.Forms.Button();
            this.portCusDisplay = new System.IO.Ports.SerialPort(this.components);
            this.flpOption = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlEmp = new System.Windows.Forms.Panel();
            this.cmbEmp = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.pnlVeh = new System.Windows.Forms.Panel();
            this.cmbVeh = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.btnServ = new System.Windows.Forms.Button();
            this.flpSale = new System.Windows.Forms.FlowLayoutPanel();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.Remove = new System.Windows.Forms.DataGridViewImageColumn();
            this.pnlTots = new System.Windows.Forms.Panel();
            this.numCredit = new System.Windows.Forms.NumericUpDown();
            this.label22 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCart = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.numBillTotal = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.numDiscount = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.numPaid = new System.Windows.Forms.NumericUpDown();
            this.lblPaid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numInvoiceno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numClientBal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChange)).BeginInit();
            this.flpOption.SuspendLayout();
            this.pnlEmp.SuspendLayout();
            this.pnlVeh.SuspendLayout();
            this.flpSale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.pnlTots.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCredit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBillTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPaid)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClient
            // 
            this.lblClient.Location = new System.Drawing.Point(1, 13);
            this.lblClient.Size = new System.Drawing.Size(1495, 40);
            // 
            // lblMsg
            // 
            this.lblMsg.Location = new System.Drawing.Point(300, 93);
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(0, 53);
            this.lblTitle.Size = new System.Drawing.Size(1496, 40);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(1057, 647);
            this.label1.Size = new System.Drawing.Size(2, 150);
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(49, 106);
            this.label2.Visible = false;
            // 
            // numInvoiceno
            // 
            this.numInvoiceno.Location = new System.Drawing.Point(157, 104);
            this.numInvoiceno.Size = new System.Drawing.Size(110, 29);
            this.numInvoiceno.Visible = false;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(137, 137);
            this.dtpDate.Size = new System.Drawing.Size(110, 29);
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // cmbClient
            // 
            this.cmbClient.Location = new System.Drawing.Point(307, 159);
            this.cmbClient.Size = new System.Drawing.Size(200, 32);
            this.cmbClient.SelectedValueChanged += new System.EventHandler(this.cmbClient_SelectedValueChanged);
            this.cmbClient.TextChanged += new System.EventHandler(this.cmbClient_TextChanged);
            this.cmbClient.Leave += new System.EventHandler(this.cmbClient_Leave);
            // 
            // label5
            // 
            this.lblProdCode.Location = new System.Drawing.Point(303, 208);
            // 
            // txtProdCode
            // 
            this.txtProdCode.Location = new System.Drawing.Point(430, 206);
            this.txtProdCode.Size = new System.Drawing.Size(200, 29);
            this.txtProdCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProdCode_KeyDown);
            this.txtProdCode.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txtProdCode_MouseUp);
            // 
            // label6
            // 
            this.lblProdName.Location = new System.Drawing.Point(665, 208);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(275, 119);
            this.label7.Size = new System.Drawing.Size(2, 130);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(49, 141);
            // 
            // txtProdName
            // 
            this.txtProdName.Location = new System.Drawing.Point(798, 206);
            this.txtProdName.Size = new System.Drawing.Size(200, 29);
            this.txtProdName.TextChanged += new System.EventHandler(this.txtProdName_TextChanged);
            // 
            // txtAccno
            // 
            this.txtAccno.Location = new System.Drawing.Point(1660, 260);
            this.txtAccno.Size = new System.Drawing.Size(17, 29);
            this.txtAccno.Visible = false;
            this.txtAccno.TextChanged += new System.EventHandler(this.txtAccno_TextChanged);
            // 
            // cmbBank
            // 
            this.cmbBank.Location = new System.Drawing.Point(665, 159);
            this.cmbBank.Size = new System.Drawing.Size(200, 32);
            this.cmbBank.SelectedIndexChanged += new System.EventHandler(this.cmbBank_SelectedIndexChanged);
            this.cmbBank.TextChanged += new System.EventHandler(this.cmbBank_TextChanged);
            this.cmbBank.Leave += new System.EventHandler(this.cmbBank_Leave);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(662, 133);
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(514, 134);
            // 
            // numClientBal
            // 
            this.numClientBal.Location = new System.Drawing.Point(514, 161);
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(1655, 238);
            this.label11.Visible = false;
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // btnBank
            // 
            this.btnBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBank.Location = new System.Drawing.Point(798, 129);
            this.btnBank.Size = new System.Drawing.Size(66, 29);
            this.btnBank.TabStop = false;
            this.btnBank.Text = "Add";
            this.btnBank.Click += new System.EventHandler(this.btnBank_Click);
            // 
            // btnClient
            // 
            this.btnClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClient.Location = new System.Drawing.Point(451, 129);
            this.btnClient.Size = new System.Drawing.Size(56, 29);
            this.btnClient.TabStop = false;
            this.btnClient.Text = "Add";
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.Location = new System.Drawing.Point(1002, 206);
            this.btnProduct.Size = new System.Drawing.Size(57, 29);
            this.btnProduct.TabStop = false;
            this.btnProduct.Text = "Add";
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.Transparent;
            this.label19.Location = new System.Drawing.Point(302, 134);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(152, 24);
            this.label19.TabIndex = 68;
            this.label19.Text = "Customer Name:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.Transparent;
            this.label20.Location = new System.Drawing.Point(887, 131);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(103, 24);
            this.label20.TabIndex = 69;
            this.label20.Text = "Reference:";
            // 
            // txtReference
            // 
            this.txtReference.Location = new System.Drawing.Point(891, 159);
            this.txtReference.Margin = new System.Windows.Forms.Padding(4);
            this.txtReference.MaxLength = 50;
            this.txtReference.Name = "txtReference";
            this.txtReference.Size = new System.Drawing.Size(167, 29);
            this.txtReference.TabIndex = 34;
            // 
            // rbRetail
            // 
            this.rbRetail.AutoSize = true;
            this.rbRetail.Checked = true;
            this.rbRetail.ForeColor = System.Drawing.Color.Transparent;
            this.rbRetail.Location = new System.Drawing.Point(33, 175);
            this.rbRetail.Margin = new System.Windows.Forms.Padding(4);
            this.rbRetail.Name = "rbRetail";
            this.rbRetail.Size = new System.Drawing.Size(74, 28);
            this.rbRetail.TabIndex = 72;
            this.rbRetail.TabStop = true;
            this.rbRetail.Text = "Retail";
            this.rbRetail.UseVisualStyleBackColor = true;
            this.rbRetail.CheckedChanged += new System.EventHandler(this.rbWhole_CheckedChanged);
            // 
            // rbWhole
            // 
            this.rbWhole.AutoSize = true;
            this.rbWhole.ForeColor = System.Drawing.Color.Transparent;
            this.rbWhole.Location = new System.Drawing.Point(132, 174);
            this.rbWhole.Margin = new System.Windows.Forms.Padding(4);
            this.rbWhole.Name = "rbWhole";
            this.rbWhole.Size = new System.Drawing.Size(125, 28);
            this.rbWhole.TabIndex = 73;
            this.rbWhole.Text = "Whole Sale";
            this.rbWhole.UseVisualStyleBackColor = true;
            this.rbWhole.CheckedChanged += new System.EventHandler(this.rbWhole_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(4, 247);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 75;
            this.label3.Text = "Change:";
            // 
            // chkBill
            // 
            this.chkBill.AutoSize = true;
            this.chkBill.ForeColor = System.Drawing.Color.Transparent;
            this.chkBill.Location = new System.Drawing.Point(33, 206);
            this.chkBill.Margin = new System.Windows.Forms.Padding(4);
            this.chkBill.Name = "chkBill";
            this.chkBill.Size = new System.Drawing.Size(186, 28);
            this.chkBill.TabIndex = 77;
            this.chkBill.TabStop = false;
            this.chkBill.Text = "Enable Bill &Printing";
            this.chkBill.UseVisualStyleBackColor = true;
            // 
            // btnReiew
            // 
            this.btnReiew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReiew.Location = new System.Drawing.Point(9, 450);
            this.btnReiew.Margin = new System.Windows.Forms.Padding(4);
            this.btnReiew.Name = "btnReiew";
            this.btnReiew.Size = new System.Drawing.Size(116, 50);
            this.btnReiew.TabIndex = 48;
            this.btnReiew.Text = "Re&view";
            this.btnReiew.UseVisualStyleBackColor = true;
            this.btnReiew.Click += new System.EventHandler(this.btnReview_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Image = ((System.Drawing.Image)(resources.GetObject("btnOrder.Image")));
            this.btnOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrder.Location = new System.Drawing.Point(548, 4);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(160, 35);
            this.btnOrder.TabIndex = 79;
            this.btnOrder.TabStop = false;
            this.btnOrder.Text = "&Orders";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // numChange
            // 
            this.numChange.Enabled = false;
            this.numChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numChange.InterceptArrowKeys = false;
            this.numChange.Location = new System.Drawing.Point(9, 275);
            this.numChange.Margin = new System.Windows.Forms.Padding(4);
            this.numChange.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numChange.Name = "numChange";
            this.numChange.Size = new System.Drawing.Size(102, 40);
            this.numChange.TabIndex = 46;
            this.numChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numChange.ThousandsSeparator = true;
            this.numChange.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // btnAddIMEI
            // 
            this.btnAddIMEI.Enabled = false;
            this.btnAddIMEI.Location = new System.Drawing.Point(884, 4);
            this.btnAddIMEI.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddIMEI.Name = "btnAddIMEI";
            this.btnAddIMEI.Size = new System.Drawing.Size(160, 35);
            this.btnAddIMEI.TabIndex = 91;
            this.btnAddIMEI.TabStop = false;
            this.btnAddIMEI.Text = "Add IMEIs";
            this.btnAddIMEI.UseVisualStyleBackColor = true;
            this.btnAddIMEI.Visible = false;
            this.btnAddIMEI.Click += new System.EventHandler(this.btnAddIMEI_Click);
            // 
            // btnDeliver
            // 
            this.btnDeliver.Enabled = false;
            this.btnDeliver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeliver.Location = new System.Drawing.Point(716, 4);
            this.btnDeliver.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeliver.Name = "btnDeliver";
            this.btnDeliver.Size = new System.Drawing.Size(160, 35);
            this.btnDeliver.TabIndex = 92;
            this.btnDeliver.TabStop = false;
            this.btnDeliver.Text = "&Delivery";
            this.btnDeliver.UseVisualStyleBackColor = true;
            this.btnDeliver.Visible = false;
            this.btnDeliver.Click += new System.EventHandler(this.btnDeliver_Click);
            // 
            // portCusDisplay
            // 
            this.portCusDisplay.PortName = "COM3";
            // 
            // flpOption
            // 
            this.flpOption.Controls.Add(this.pnlEmp);
            this.flpOption.Controls.Add(this.pnlVeh);
            this.flpOption.Controls.Add(this.btnOrder);
            this.flpOption.Controls.Add(this.btnDeliver);
            this.flpOption.Controls.Add(this.btnAddIMEI);
            this.flpOption.Controls.Add(this.btnServ);
            this.flpOption.Location = new System.Drawing.Point(29, 634);
            this.flpOption.Margin = new System.Windows.Forms.Padding(4);
            this.flpOption.Name = "flpOption";
            this.flpOption.Size = new System.Drawing.Size(1266, 42);
            this.flpOption.TabIndex = 93;
            // 
            // pnlEmp
            // 
            this.pnlEmp.Controls.Add(this.cmbEmp);
            this.pnlEmp.Controls.Add(this.label13);
            this.pnlEmp.Location = new System.Drawing.Point(4, 4);
            this.pnlEmp.Margin = new System.Windows.Forms.Padding(4);
            this.pnlEmp.Name = "pnlEmp";
            this.pnlEmp.Size = new System.Drawing.Size(251, 36);
            this.pnlEmp.TabIndex = 96;
            this.pnlEmp.Visible = false;
            // 
            // cmbEmp
            // 
            this.cmbEmp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbEmp.FormattingEnabled = true;
            this.cmbEmp.Location = new System.Drawing.Point(70, 0);
            this.cmbEmp.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEmp.Name = "cmbEmp";
            this.cmbEmp.Size = new System.Drawing.Size(180, 32);
            this.cmbEmp.TabIndex = 71;
            this.cmbEmp.SelectedValueChanged += new System.EventHandler(this.cmbEmp_SelectedValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(7, 3);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 24);
            this.label13.TabIndex = 70;
            this.label13.Text = "Emp:";
            // 
            // pnlVeh
            // 
            this.pnlVeh.Controls.Add(this.cmbVeh);
            this.pnlVeh.Controls.Add(this.label24);
            this.pnlVeh.Location = new System.Drawing.Point(263, 4);
            this.pnlVeh.Margin = new System.Windows.Forms.Padding(4);
            this.pnlVeh.Name = "pnlVeh";
            this.pnlVeh.Size = new System.Drawing.Size(277, 36);
            this.pnlVeh.TabIndex = 97;
            // 
            // cmbVeh
            // 
            this.cmbVeh.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbVeh.FormattingEnabled = true;
            this.cmbVeh.Location = new System.Drawing.Point(94, 0);
            this.cmbVeh.Margin = new System.Windows.Forms.Padding(4);
            this.cmbVeh.Name = "cmbVeh";
            this.cmbVeh.Size = new System.Drawing.Size(176, 32);
            this.cmbVeh.TabIndex = 71;
            this.cmbVeh.SelectedIndexChanged += new System.EventHandler(this.cmbVeh_SelectedIndexChanged);
            this.cmbVeh.SelectedValueChanged += new System.EventHandler(this.cmbVeh_SelectedValueChanged);
            this.cmbVeh.TextChanged += new System.EventHandler(this.cmbVeh_TextChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.ForeColor = System.Drawing.Color.Transparent;
            this.label24.Location = new System.Drawing.Point(7, 0);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(79, 24);
            this.label24.TabIndex = 70;
            this.label24.Text = "Vehicle:";
            // 
            // btnServ
            // 
            this.btnServ.Location = new System.Drawing.Point(1052, 4);
            this.btnServ.Margin = new System.Windows.Forms.Padding(4);
            this.btnServ.Name = "btnServ";
            this.btnServ.Size = new System.Drawing.Size(160, 35);
            this.btnServ.TabIndex = 93;
            this.btnServ.TabStop = false;
            this.btnServ.Text = "Serv&ices";
            this.btnServ.UseVisualStyleBackColor = true;
            this.btnServ.Visible = false;
            this.btnServ.Click += new System.EventHandler(this.btnServ_Click);
            // 
            // flpSale
            // 
            this.flpSale.Controls.Add(this.dgvData);
            this.flpSale.Location = new System.Drawing.Point(29, 243);
            this.flpSale.Margin = new System.Windows.Forms.Padding(4);
            this.flpSale.Name = "flpSale";
            this.flpSale.Size = new System.Drawing.Size(1041, 391);
            this.flpSale.TabIndex = 40;
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
            this.Remove});
            this.dgvData.Location = new System.Drawing.Point(4, 4);
            this.dgvData.Margin = new System.Windows.Forms.Padding(4);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersVisible = false;
            this.dgvData.Size = new System.Drawing.Size(1026, 382);
            this.dgvData.TabIndex = 42;
            this.dgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
            this.dgvData.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellEndEdit);
            // 
            // Remove
            // 
            this.Remove.FillWeight = 50F;
            this.Remove.HeaderText = "Remove";
            this.Remove.Image = ((System.Drawing.Image)(resources.GetObject("Remove.Image")));
            this.Remove.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Remove.Name = "Remove";
            this.Remove.ReadOnly = true;
            // 
            // pnlTots
            // 
            this.pnlTots.Controls.Add(this.numCredit);
            this.pnlTots.Controls.Add(this.label22);
            this.pnlTots.Controls.Add(this.btnClose);
            this.pnlTots.Controls.Add(this.btnCart);
            this.pnlTots.Controls.Add(this.btnSave);
            this.pnlTots.Controls.Add(this.label12);
            this.pnlTots.Controls.Add(this.numBillTotal);
            this.pnlTots.Controls.Add(this.label17);
            this.pnlTots.Controls.Add(this.numDiscount);
            this.pnlTots.Controls.Add(this.label15);
            this.pnlTots.Controls.Add(this.numPaid);
            this.pnlTots.Controls.Add(this.lblPaid);
            this.pnlTots.Controls.Add(this.numChange);
            this.pnlTots.Controls.Add(this.label3);
            this.pnlTots.Controls.Add(this.btnReiew);
            this.pnlTots.Location = new System.Drawing.Point(1078, 129);
            this.pnlTots.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTots.Name = "pnlTots";
            this.pnlTots.Size = new System.Drawing.Size(254, 505);
            this.pnlTots.TabIndex = 41;
            // 
            // numCredit
            // 
            this.numCredit.Enabled = false;
            this.numCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCredit.InterceptArrowKeys = false;
            this.numCredit.Location = new System.Drawing.Point(119, 275);
            this.numCredit.Margin = new System.Windows.Forms.Padding(4);
            this.numCredit.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numCredit.Name = "numCredit";
            this.numCredit.Size = new System.Drawing.Size(125, 40);
            this.numCredit.TabIndex = 45;
            this.numCredit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numCredit.ThousandsSeparator = true;
            this.numCredit.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Transparent;
            this.label22.Location = new System.Drawing.Point(115, 247);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(64, 24);
            this.label22.TabIndex = 97;
            this.label22.Text = "Credit:";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(129, 450);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(116, 50);
            this.btnClose.TabIndex = 50;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCart
            // 
            this.btnCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCart.Location = new System.Drawing.Point(8, 393);
            this.btnCart.Margin = new System.Windows.Forms.Padding(4);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(237, 50);
            this.btnCart.TabIndex = 49;
            this.btnCart.Text = "Clea&r Cart";
            this.btnCart.UseVisualStyleBackColor = true;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(8, 338);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(237, 50);
            this.btnSave.TabIndex = 47;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Location = new System.Drawing.Point(1, 325);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(257, 2);
            this.label12.TabIndex = 85;
            // 
            // numBillTotal
            // 
            this.numBillTotal.Enabled = false;
            this.numBillTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numBillTotal.InterceptArrowKeys = false;
            this.numBillTotal.Location = new System.Drawing.Point(9, 31);
            this.numBillTotal.Margin = new System.Windows.Forms.Padding(4);
            this.numBillTotal.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numBillTotal.Name = "numBillTotal";
            this.numBillTotal.Size = new System.Drawing.Size(237, 49);
            this.numBillTotal.TabIndex = 42;
            this.numBillTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numBillTotal.ThousandsSeparator = true;
            this.numBillTotal.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Transparent;
            this.label17.Location = new System.Drawing.Point(6, 5);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(85, 24);
            this.label17.TabIndex = 87;
            this.label17.Text = "Bill Total:";
            // 
            // numDiscount
            // 
            this.numDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDiscount.InterceptArrowKeys = false;
            this.numDiscount.Location = new System.Drawing.Point(10, 116);
            this.numDiscount.Margin = new System.Windows.Forms.Padding(4);
            this.numDiscount.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numDiscount.Name = "numDiscount";
            this.numDiscount.Size = new System.Drawing.Size(237, 40);
            this.numDiscount.TabIndex = 43;
            this.numDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numDiscount.ThousandsSeparator = true;
            this.numDiscount.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numDiscount.ValueChanged += new System.EventHandler(this.numDiscount_ValueChanged);
            this.numDiscount.Enter += new System.EventHandler(this.numDiscount_Enter);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(6, 88);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 24);
            this.label15.TabIndex = 85;
            this.label15.Text = "Discount:";
            // 
            // numPaid
            // 
            this.numPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPaid.ForeColor = System.Drawing.Color.ForestGreen;
            this.numPaid.InterceptArrowKeys = false;
            this.numPaid.Location = new System.Drawing.Point(9, 191);
            this.numPaid.Margin = new System.Windows.Forms.Padding(4);
            this.numPaid.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numPaid.Name = "numPaid";
            this.numPaid.Size = new System.Drawing.Size(237, 49);
            this.numPaid.TabIndex = 44;
            this.numPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numPaid.ThousandsSeparator = true;
            this.numPaid.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numPaid.ValueChanged += new System.EventHandler(this.numPaid_ValueChanged);
            this.numPaid.Enter += new System.EventHandler(this.numPaid_Enter);
            // 
            // lblPaid
            // 
            this.lblPaid.AutoSize = true;
            this.lblPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaid.ForeColor = System.Drawing.Color.Transparent;
            this.lblPaid.Location = new System.Drawing.Point(5, 163);
            this.lblPaid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaid.Name = "lblPaid";
            this.lblPaid.Size = new System.Drawing.Size(124, 24);
            this.lblPaid.TabIndex = 83;
            this.lblPaid.Text = "Paid as Cash:";
            // 
            // frmTmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1348, 687);
            this.Controls.Add(this.pnlTots);
            this.Controls.Add(this.flpSale);
            this.Controls.Add(this.flpOption);
            this.Controls.Add(this.chkBill);
            this.Controls.Add(this.rbWhole);
            this.Controls.Add(this.rbRetail);
            this.Controls.Add(this.txtReference);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximumSize = new System.Drawing.Size(2003, 1305);
            this.MinimumSize = new System.Drawing.Size(1252, 699);
            this.Name = "frmTmp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = " Sale Corner";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.Load += new System.EventHandler(this.frmSale_Load);
            this.Controls.SetChildIndex(this.label19, 0);
            this.Controls.SetChildIndex(this.label20, 0);
            this.Controls.SetChildIndex(this.txtReference, 0);
            this.Controls.SetChildIndex(this.rbRetail, 0);
            this.Controls.SetChildIndex(this.rbWhole, 0);
            this.Controls.SetChildIndex(this.chkBill, 0);
            this.Controls.SetChildIndex(this.flpOption, 0);
            this.Controls.SetChildIndex(this.flpSale, 0);
            this.Controls.SetChildIndex(this.pnlTots, 0);
            this.Controls.SetChildIndex(this.btnProduct, 0);
            this.Controls.SetChildIndex(this.btnClient, 0);
            this.Controls.SetChildIndex(this.btnBank, 0);
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
            ((System.ComponentModel.ISupportInitialize)(this.numInvoiceno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numClientBal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChange)).EndInit();
            this.flpOption.ResumeLayout(false);
            this.pnlEmp.ResumeLayout(false);
            this.pnlEmp.PerformLayout();
            this.pnlVeh.ResumeLayout(false);
            this.pnlVeh.PerformLayout();
            this.flpSale.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.pnlTots.ResumeLayout(false);
            this.pnlTots.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCredit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBillTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPaid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        public System.Windows.Forms.TextBox txtReference;
        public System.Windows.Forms.RadioButton rbRetail;
        public System.Windows.Forms.RadioButton rbWhole;
        public System.Windows.Forms.CheckBox chkBill;
        public System.Windows.Forms.Button btnReiew;
        public System.Windows.Forms.Button btnOrder;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.NumericUpDown numChange;
        private System.Windows.Forms.Button btnAddIMEI;
        public System.Windows.Forms.Button btnDeliver;
        private System.IO.Ports.SerialPort portCusDisplay;
        private System.Windows.Forms.FlowLayoutPanel flpOption;
        private System.Windows.Forms.Button btnServ;
        private System.Windows.Forms.FlowLayoutPanel flpSale;
        private System.Windows.Forms.Panel pnlTots;
        public System.Windows.Forms.NumericUpDown numBillTotal;
        public System.Windows.Forms.Label label17;
        public System.Windows.Forms.NumericUpDown numDiscount;
        public System.Windows.Forms.Label label15;
        public System.Windows.Forms.NumericUpDown numPaid;
        public System.Windows.Forms.Label lblPaid;
        public System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.Button btnCart;
        public System.Windows.Forms.Button btnSave;
        protected System.Windows.Forms.Label label12;
        public System.Windows.Forms.NumericUpDown numCredit;
        public System.Windows.Forms.Label label22;
        private System.Windows.Forms.Panel pnlEmp;
        private System.Windows.Forms.ComboBox cmbEmp;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel pnlVeh;
        private System.Windows.Forms.ComboBox cmbVeh;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.DataGridViewImageColumn Remove;

    }
}