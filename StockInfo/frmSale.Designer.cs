namespace prjGrow.StockInfo
{
    partial class frmSale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSale));
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
            this.btnPurchase = new System.Windows.Forms.Button();
            this.btnSp1 = new System.Windows.Forms.Button();
            this.btnSp2 = new System.Windows.Forms.Button();
            this.btnSwitchUser = new System.Windows.Forms.Button();
            this.btnSupOrder = new System.Windows.Forms.Button();
            this.lblCp = new System.Windows.Forms.Label();
            this.flpSale = new System.Windows.Forms.FlowLayoutPanel();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.Remove = new System.Windows.Forms.DataGridViewImageColumn();
            this.CP = new System.Windows.Forms.DataGridViewImageColumn();
            this.pnlTots = new System.Windows.Forms.Panel();
            this.numAmt = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBill = new System.Windows.Forms.Button();
            this.numCredit = new System.Windows.Forms.NumericUpDown();
            this.label22 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCart = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.numBillTotal = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.numDiscount = new System.Windows.Forms.NumericUpDown();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.numPaid = new System.Windows.Forms.NumericUpDown();
            this.lblPaid = new System.Windows.Forms.Label();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            this.cmbCell = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.pnlCell = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numInvoiceno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numClientBal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChange)).BeginInit();
            this.flpOption.SuspendLayout();
            this.pnlEmp.SuspendLayout();
            this.pnlVeh.SuspendLayout();
            this.flpSale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.pnlTots.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAmt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCredit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBillTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPaid)).BeginInit();
            this.pnlCell.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblClient
            // 
            this.lblClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClient.Location = new System.Drawing.Point(9, 4);
            this.lblClient.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblClient.Size = new System.Drawing.Size(1359, 48);
            // 
            // lblMsg
            // 
            this.lblMsg.Location = new System.Drawing.Point(248, 85);
            this.lblMsg.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMsg.Size = new System.Drawing.Size(833, 24);
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(9, 52);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTitle.Size = new System.Drawing.Size(1359, 33);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(1375, 231);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Size = new System.Drawing.Size(2, 59);
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(-10, 671);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Visible = false;
            // 
            // numInvoiceno
            // 
            this.numInvoiceno.Location = new System.Drawing.Point(73, 666);
            this.numInvoiceno.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.numInvoiceno.Size = new System.Drawing.Size(10, 29);
            this.numInvoiceno.Visible = false;
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Location = new System.Drawing.Point(15, 400);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.dtpDate.Size = new System.Drawing.Size(219, 31);
            this.dtpDate.TabStop = false;
            // 
            // cmbClient
            // 
            this.cmbClient.Location = new System.Drawing.Point(15, 148);
            this.cmbClient.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.cmbClient.Size = new System.Drawing.Size(219, 32);
            this.cmbClient.TabIndex = 22;
            this.cmbClient.SelectedValueChanged += new System.EventHandler(this.cmbClient_SelectedValueChanged);
            this.cmbClient.TextChanged += new System.EventHandler(this.cmbClient_TextChanged);
            this.cmbClient.Leave += new System.EventHandler(this.cmbClient_Leave);
            // 
            // lblProdCode
            // 
            this.lblProdCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdCode.Location = new System.Drawing.Point(243, 120);
            this.lblProdCode.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblProdCode.Size = new System.Drawing.Size(138, 24);
            // 
            // txtProdCode
            // 
            this.txtProdCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdCode.Location = new System.Drawing.Point(392, 117);
            this.txtProdCode.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtProdCode.Size = new System.Drawing.Size(219, 31);
            this.txtProdCode.TabIndex = 31;
            this.txtProdCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProdCode_KeyDown);
            this.txtProdCode.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txtProdCode_MouseUp);
            // 
            // lblProdName
            // 
            this.lblProdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdName.Location = new System.Drawing.Point(623, 120);
            this.lblProdName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblProdName.Size = new System.Drawing.Size(143, 24);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(-6, 683);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Size = new System.Drawing.Size(13, 9);
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 374);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Size = new System.Drawing.Size(58, 24);
            this.label8.Text = "Date:";
            // 
            // txtProdName
            // 
            this.txtProdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdName.Location = new System.Drawing.Point(771, 117);
            this.txtProdName.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtProdName.Size = new System.Drawing.Size(219, 31);
            this.txtProdName.TabIndex = 32;
            this.txtProdName.TextChanged += new System.EventHandler(this.txtProdName_TextChanged);
            this.txtProdName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProdName_KeyDown);
            // 
            // txtAccno
            // 
            this.txtAccno.Location = new System.Drawing.Point(1363, 152);
            this.txtAccno.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtAccno.Size = new System.Drawing.Size(24, 29);
            this.txtAccno.Visible = false;
            // 
            // cmbBank
            // 
            this.cmbBank.Location = new System.Drawing.Point(15, 275);
            this.cmbBank.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.cmbBank.Size = new System.Drawing.Size(219, 32);
            this.cmbBank.TabIndex = 23;
            this.cmbBank.SelectedIndexChanged += new System.EventHandler(this.cmbBank_SelectedIndexChanged);
            this.cmbBank.TextChanged += new System.EventHandler(this.cmbBank_TextChanged);
            this.cmbBank.Leave += new System.EventHandler(this.cmbBank_Leave);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 249);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Size = new System.Drawing.Size(62, 24);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(11, 182);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Size = new System.Drawing.Size(91, 24);
            // 
            // numClientBal
            // 
            this.numClientBal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numClientBal.ForeColor = System.Drawing.Color.White;
            this.numClientBal.Location = new System.Drawing.Point(15, 207);
            this.numClientBal.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.numClientBal.Size = new System.Drawing.Size(219, 31);
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(1359, 124);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Visible = false;
            // 
            // btnBank
            // 
            this.btnBank.Location = new System.Drawing.Point(162, 246);
            this.btnBank.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnBank.Size = new System.Drawing.Size(73, 28);
            this.btnBank.TabStop = false;
            this.btnBank.Click += new System.EventHandler(this.btnBank_Click);
            // 
            // btnClient
            // 
            this.btnClient.Location = new System.Drawing.Point(162, 119);
            this.btnClient.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnClient.Size = new System.Drawing.Size(72, 28);
            this.btnClient.TabStop = false;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.Location = new System.Drawing.Point(998, 117);
            this.btnProduct.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnProduct.Size = new System.Drawing.Size(79, 31);
            this.btnProduct.TabStop = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Transparent;
            this.label19.Location = new System.Drawing.Point(12, 121);
            this.label19.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(105, 24);
            this.label19.TabIndex = 68;
            this.label19.Text = "Customer:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Transparent;
            this.label20.Location = new System.Drawing.Point(13, 315);
            this.label20.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(113, 24);
            this.label20.TabIndex = 69;
            this.label20.Text = "Reference:";
            // 
            // txtReference
            // 
            this.txtReference.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReference.Location = new System.Drawing.Point(15, 339);
            this.txtReference.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.txtReference.MaxLength = 50;
            this.txtReference.Name = "txtReference";
            this.txtReference.Size = new System.Drawing.Size(219, 31);
            this.txtReference.TabIndex = 24;
            // 
            // rbRetail
            // 
            this.rbRetail.AutoSize = true;
            this.rbRetail.Checked = true;
            this.rbRetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRetail.ForeColor = System.Drawing.Color.Transparent;
            this.rbRetail.Location = new System.Drawing.Point(16, 438);
            this.rbRetail.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.rbRetail.Name = "rbRetail";
            this.rbRetail.Size = new System.Drawing.Size(80, 28);
            this.rbRetail.TabIndex = 72;
            this.rbRetail.TabStop = true;
            this.rbRetail.Text = "Retail";
            this.rbRetail.UseVisualStyleBackColor = true;
            this.rbRetail.CheckedChanged += new System.EventHandler(this.rbWhole_CheckedChanged);
            // 
            // rbWhole
            // 
            this.rbWhole.AutoSize = true;
            this.rbWhole.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbWhole.ForeColor = System.Drawing.Color.Transparent;
            this.rbWhole.Location = new System.Drawing.Point(99, 438);
            this.rbWhole.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.rbWhole.Name = "rbWhole";
            this.rbWhole.Size = new System.Drawing.Size(135, 28);
            this.rbWhole.TabIndex = 73;
            this.rbWhole.Text = "Whole Sale";
            this.rbWhole.UseVisualStyleBackColor = true;
            this.rbWhole.CheckedChanged += new System.EventHandler(this.rbWhole_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(6, 262);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 24);
            this.label3.TabIndex = 75;
            this.label3.Text = "Change:";
            // 
            // chkBill
            // 
            this.chkBill.AutoSize = true;
            this.chkBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBill.ForeColor = System.Drawing.Color.Transparent;
            this.chkBill.Location = new System.Drawing.Point(16, 472);
            this.chkBill.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.chkBill.Name = "chkBill";
            this.chkBill.Size = new System.Drawing.Size(206, 28);
            this.chkBill.TabIndex = 77;
            this.chkBill.TabStop = false;
            this.chkBill.Text = "Enable Bill &Printing";
            this.chkBill.UseVisualStyleBackColor = true;
            this.chkBill.CheckedChanged += new System.EventHandler(this.chkBill_CheckedChanged);
            // 
            // btnReiew
            // 
            this.btnReiew.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReiew.Location = new System.Drawing.Point(6, 435);
            this.btnReiew.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.btnReiew.Name = "btnReiew";
            this.btnReiew.Size = new System.Drawing.Size(121, 39);
            this.btnReiew.TabIndex = 48;
            this.btnReiew.Text = "Re&view";
            this.btnReiew.UseVisualStyleBackColor = true;
            this.btnReiew.Click += new System.EventHandler(this.btnReview_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrder.Location = new System.Drawing.Point(586, 3);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(180, 33);
            this.btnOrder.TabIndex = 79;
            this.btnOrder.TabStop = false;
            this.btnOrder.Text = "&Orders";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // numChange
            // 
            this.numChange.Enabled = false;
            this.numChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numChange.Location = new System.Drawing.Point(6, 287);
            this.numChange.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.numChange.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numChange.Name = "numChange";
            this.numChange.Size = new System.Drawing.Size(242, 35);
            this.numChange.TabIndex = 46;
            this.numChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numChange.ThousandsSeparator = true;
            this.numChange.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // btnAddIMEI
            // 
            this.btnAddIMEI.Enabled = false;
            this.btnAddIMEI.Location = new System.Drawing.Point(390, 42);
            this.btnAddIMEI.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.btnAddIMEI.Name = "btnAddIMEI";
            this.btnAddIMEI.Size = new System.Drawing.Size(180, 32);
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
            this.btnDeliver.Location = new System.Drawing.Point(6, 42);
            this.btnDeliver.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.btnDeliver.Name = "btnDeliver";
            this.btnDeliver.Size = new System.Drawing.Size(180, 32);
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
            this.flpOption.Controls.Add(this.btnServ);
            this.flpOption.Controls.Add(this.btnAddIMEI);
            this.flpOption.Controls.Add(this.btnPurchase);
            this.flpOption.Controls.Add(this.btnSp1);
            this.flpOption.Controls.Add(this.btnSp2);
            this.flpOption.Controls.Add(this.btnSwitchUser);
            this.flpOption.Controls.Add(this.btnSupOrder);
            this.flpOption.Controls.Add(this.lblCp);
            this.flpOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flpOption.Location = new System.Drawing.Point(241, 629);
            this.flpOption.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.flpOption.Name = "flpOption";
            this.flpOption.Size = new System.Drawing.Size(842, 40);
            this.flpOption.TabIndex = 93;
            // 
            // pnlEmp
            // 
            this.pnlEmp.Controls.Add(this.cmbEmp);
            this.pnlEmp.Controls.Add(this.label13);
            this.pnlEmp.Location = new System.Drawing.Point(6, 3);
            this.pnlEmp.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.pnlEmp.Name = "pnlEmp";
            this.pnlEmp.Size = new System.Drawing.Size(286, 32);
            this.pnlEmp.TabIndex = 96;
            this.pnlEmp.Visible = false;
            // 
            // cmbEmp
            // 
            this.cmbEmp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbEmp.FormattingEnabled = true;
            this.cmbEmp.Location = new System.Drawing.Point(105, 0);
            this.cmbEmp.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.cmbEmp.Name = "cmbEmp";
            this.cmbEmp.Size = new System.Drawing.Size(180, 33);
            this.cmbEmp.TabIndex = 71;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(4, 3);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 25);
            this.label13.TabIndex = 70;
            this.label13.Text = "Employee:";
            // 
            // pnlVeh
            // 
            this.pnlVeh.Controls.Add(this.cmbVeh);
            this.pnlVeh.Controls.Add(this.label24);
            this.pnlVeh.Location = new System.Drawing.Point(304, 3);
            this.pnlVeh.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.pnlVeh.Name = "pnlVeh";
            this.pnlVeh.Size = new System.Drawing.Size(270, 32);
            this.pnlVeh.TabIndex = 97;
            // 
            // cmbVeh
            // 
            this.cmbVeh.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbVeh.FormattingEnabled = true;
            this.cmbVeh.Location = new System.Drawing.Point(88, 0);
            this.cmbVeh.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.cmbVeh.Name = "cmbVeh";
            this.cmbVeh.Size = new System.Drawing.Size(180, 33);
            this.cmbVeh.TabIndex = 71;
            this.cmbVeh.SelectedValueChanged += new System.EventHandler(this.cmbVeh_SelectedValueChanged);
            this.cmbVeh.TextChanged += new System.EventHandler(this.cmbVeh_TextChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.ForeColor = System.Drawing.Color.Transparent;
            this.label24.Location = new System.Drawing.Point(6, 3);
            this.label24.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(89, 25);
            this.label24.TabIndex = 70;
            this.label24.Text = "Vehicle:";
            // 
            // btnServ
            // 
            this.btnServ.Location = new System.Drawing.Point(198, 42);
            this.btnServ.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.btnServ.Name = "btnServ";
            this.btnServ.Size = new System.Drawing.Size(180, 32);
            this.btnServ.TabIndex = 93;
            this.btnServ.TabStop = false;
            this.btnServ.Text = "Serv&ices";
            this.btnServ.UseVisualStyleBackColor = true;
            this.btnServ.Visible = false;
            this.btnServ.Click += new System.EventHandler(this.btnServ_Click);
            // 
            // btnPurchase
            // 
            this.btnPurchase.Location = new System.Drawing.Point(582, 42);
            this.btnPurchase.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(180, 32);
            this.btnPurchase.TabIndex = 98;
            this.btnPurchase.TabStop = false;
            this.btnPurchase.Text = "P&urchase";
            this.btnPurchase.UseVisualStyleBackColor = true;
            this.btnPurchase.Visible = false;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // btnSp1
            // 
            this.btnSp1.Location = new System.Drawing.Point(6, 80);
            this.btnSp1.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.btnSp1.Name = "btnSp1";
            this.btnSp1.Size = new System.Drawing.Size(100, 32);
            this.btnSp1.TabIndex = 99;
            this.btnSp1.TabStop = false;
            this.btnSp1.Text = "spBtn1";
            this.btnSp1.UseVisualStyleBackColor = true;
            this.btnSp1.Visible = false;
            this.btnSp1.Click += new System.EventHandler(this.btnSp1_Click);
            // 
            // btnSp2
            // 
            this.btnSp2.Location = new System.Drawing.Point(118, 80);
            this.btnSp2.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.btnSp2.Name = "btnSp2";
            this.btnSp2.Size = new System.Drawing.Size(100, 32);
            this.btnSp2.TabIndex = 100;
            this.btnSp2.TabStop = false;
            this.btnSp2.Text = "spBtn2";
            this.btnSp2.UseVisualStyleBackColor = true;
            this.btnSp2.Visible = false;
            this.btnSp2.Click += new System.EventHandler(this.btnSp2_Click);
            // 
            // btnSwitchUser
            // 
            this.btnSwitchUser.Location = new System.Drawing.Point(230, 80);
            this.btnSwitchUser.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.btnSwitchUser.Name = "btnSwitchUser";
            this.btnSwitchUser.Size = new System.Drawing.Size(180, 32);
            this.btnSwitchUser.TabIndex = 101;
            this.btnSwitchUser.TabStop = false;
            this.btnSwitchUser.Text = "S&witch User";
            this.btnSwitchUser.UseVisualStyleBackColor = true;
            this.btnSwitchUser.Click += new System.EventHandler(this.btnSwitchUser_Click);
            // 
            // btnSupOrder
            // 
            this.btnSupOrder.Location = new System.Drawing.Point(422, 80);
            this.btnSupOrder.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.btnSupOrder.Name = "btnSupOrder";
            this.btnSupOrder.Size = new System.Drawing.Size(180, 32);
            this.btnSupOrder.TabIndex = 102;
            this.btnSupOrder.TabStop = false;
            this.btnSupOrder.Text = "Order Stock";
            this.btnSupOrder.UseVisualStyleBackColor = true;
            this.btnSupOrder.Visible = false;
            this.btnSupOrder.Click += new System.EventHandler(this.btnSupOrder_Click);
            // 
            // lblCp
            // 
            this.lblCp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCp.Location = new System.Drawing.Point(612, 77);
            this.lblCp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCp.Name = "lblCp";
            this.lblCp.Size = new System.Drawing.Size(149, 32);
            this.lblCp.TabIndex = 94;
            this.lblCp.Text = "label4";
            this.lblCp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCp.Visible = false;
            this.lblCp.Click += new System.EventHandler(this.lblCp_Click);
            // 
            // flpSale
            // 
            this.flpSale.Controls.Add(this.dgvData);
            this.flpSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flpSale.Location = new System.Drawing.Point(241, 155);
            this.flpSale.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.flpSale.Name = "flpSale";
            this.flpSale.Size = new System.Drawing.Size(842, 471);
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
            this.Remove,
            this.CP});
            this.dgvData.Location = new System.Drawing.Point(6, 3);
            this.dgvData.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersVisible = false;
            this.dgvData.Size = new System.Drawing.Size(836, 465);
            this.dgvData.TabIndex = 42;
            this.dgvData.TabStop = false;
            this.dgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
            this.dgvData.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentDoubleClick);
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
            // CP
            // 
            this.CP.FillWeight = 20F;
            this.CP.HeaderText = "";
            this.CP.Image = ((System.Drawing.Image)(resources.GetObject("CP.Image")));
            this.CP.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.CP.Name = "CP";
            this.CP.ReadOnly = true;
            this.CP.Visible = false;
            // 
            // pnlTots
            // 
            this.pnlTots.Controls.Add(this.numAmt);
            this.pnlTots.Controls.Add(this.label4);
            this.pnlTots.Controls.Add(this.btnBill);
            this.pnlTots.Controls.Add(this.numCredit);
            this.pnlTots.Controls.Add(this.label22);
            this.pnlTots.Controls.Add(this.btnClose);
            this.pnlTots.Controls.Add(this.btnCart);
            this.pnlTots.Controls.Add(this.btnSave);
            this.pnlTots.Controls.Add(this.label12);
            this.pnlTots.Controls.Add(this.numBillTotal);
            this.pnlTots.Controls.Add(this.label17);
            this.pnlTots.Controls.Add(this.numDiscount);
            this.pnlTots.Controls.Add(this.lblDiscount);
            this.pnlTots.Controls.Add(this.numPaid);
            this.pnlTots.Controls.Add(this.lblPaid);
            this.pnlTots.Controls.Add(this.numChange);
            this.pnlTots.Controls.Add(this.label3);
            this.pnlTots.Controls.Add(this.btnReiew);
            this.pnlTots.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlTots.Location = new System.Drawing.Point(1086, 113);
            this.pnlTots.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.pnlTots.Name = "pnlTots";
            this.pnlTots.Size = new System.Drawing.Size(255, 515);
            this.pnlTots.TabIndex = 41;
            // 
            // numAmt
            // 
            this.numAmt.Enabled = false;
            this.numAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numAmt.ForeColor = System.Drawing.Color.White;
            this.numAmt.Location = new System.Drawing.Point(6, 142);
            this.numAmt.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.numAmt.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numAmt.Name = "numAmt";
            this.numAmt.Size = new System.Drawing.Size(242, 47);
            this.numAmt.TabIndex = 99;
            this.numAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numAmt.ThousandsSeparator = true;
            this.numAmt.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(6, 120);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 24);
            this.label4.TabIndex = 100;
            this.label4.Text = "Bill Amount:";
            // 
            // btnBill
            // 
            this.btnBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBill.Location = new System.Drawing.Point(128, 435);
            this.btnBill.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(121, 39);
            this.btnBill.TabIndex = 98;
            this.btnBill.Text = "Last &Bill";
            this.btnBill.UseVisualStyleBackColor = true;
            this.btnBill.Click += new System.EventHandler(this.button1_Click);
            // 
            // numCredit
            // 
            this.numCredit.Enabled = false;
            this.numCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCredit.ForeColor = System.Drawing.Color.White;
            this.numCredit.Location = new System.Drawing.Point(6, 346);
            this.numCredit.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.numCredit.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numCredit.Name = "numCredit";
            this.numCredit.Size = new System.Drawing.Size(242, 35);
            this.numCredit.TabIndex = 45;
            this.numCredit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numCredit.ThousandsSeparator = true;
            this.numCredit.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Transparent;
            this.label22.Location = new System.Drawing.Point(6, 324);
            this.label22.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(71, 24);
            this.label22.TabIndex = 97;
            this.label22.Text = "Credit:";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(128, 475);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(121, 39);
            this.btnClose.TabIndex = 50;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCart
            // 
            this.btnCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCart.Location = new System.Drawing.Point(6, 475);
            this.btnCart.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(121, 39);
            this.btnCart.TabIndex = 49;
            this.btnCart.Text = "Clea&r Cart";
            this.btnCart.UseVisualStyleBackColor = true;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(6, 389);
            this.btnSave.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(244, 45);
            this.btnSave.TabIndex = 47;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.Leave += new System.EventHandler(this.btnSave_Leave);
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Location = new System.Drawing.Point(0, 385);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(255, 2);
            this.label12.TabIndex = 85;
            // 
            // numBillTotal
            // 
            this.numBillTotal.Enabled = false;
            this.numBillTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numBillTotal.ForeColor = System.Drawing.Color.White;
            this.numBillTotal.Location = new System.Drawing.Point(6, 22);
            this.numBillTotal.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.numBillTotal.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numBillTotal.Name = "numBillTotal";
            this.numBillTotal.Size = new System.Drawing.Size(242, 35);
            this.numBillTotal.TabIndex = 42;
            this.numBillTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numBillTotal.ThousandsSeparator = true;
            this.numBillTotal.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Transparent;
            this.label17.Location = new System.Drawing.Point(6, 1);
            this.label17.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(96, 24);
            this.label17.TabIndex = 87;
            this.label17.Text = "Bill Total:";
            // 
            // numDiscount
            // 
            this.numDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDiscount.Location = new System.Drawing.Point(6, 82);
            this.numDiscount.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.numDiscount.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numDiscount.Name = "numDiscount";
            this.numDiscount.Size = new System.Drawing.Size(242, 35);
            this.numDiscount.TabIndex = 43;
            this.numDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numDiscount.ThousandsSeparator = true;
            this.numDiscount.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numDiscount.ValueChanged += new System.EventHandler(this.numDiscount_ValueChanged);
            this.numDiscount.Enter += new System.EventHandler(this.numDiscount_Enter);
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.ForeColor = System.Drawing.Color.Transparent;
            this.lblDiscount.Location = new System.Drawing.Point(6, 60);
            this.lblDiscount.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(97, 24);
            this.lblDiscount.TabIndex = 85;
            this.lblDiscount.Text = "Discount:";
            // 
            // numPaid
            // 
            this.numPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPaid.ForeColor = System.Drawing.Color.DarkGreen;
            this.numPaid.Location = new System.Drawing.Point(6, 213);
            this.numPaid.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.numPaid.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numPaid.Name = "numPaid";
            this.numPaid.Size = new System.Drawing.Size(242, 47);
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
            this.lblPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaid.ForeColor = System.Drawing.Color.Transparent;
            this.lblPaid.Location = new System.Drawing.Point(6, 191);
            this.lblPaid.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPaid.Name = "lblPaid";
            this.lblPaid.Size = new System.Drawing.Size(137, 24);
            this.lblPaid.TabIndex = 83;
            this.lblPaid.Text = "Paid as Cash:";
            // 
            // tmr
            // 
            this.tmr.Interval = 1000;
            this.tmr.Tick += new System.EventHandler(this.tmr_Tick);
            // 
            // cmbCell
            // 
            this.cmbCell.FormattingEnabled = true;
            this.cmbCell.Location = new System.Drawing.Point(10, 26);
            this.cmbCell.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.cmbCell.Name = "cmbCell";
            this.cmbCell.Size = new System.Drawing.Size(219, 32);
            this.cmbCell.TabIndex = 7;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(6, 0);
            this.label16.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(81, 25);
            this.label16.TabIndex = 97;
            this.label16.Text = "Cell No:";
            // 
            // pnlCell
            // 
            this.pnlCell.Controls.Add(this.label16);
            this.pnlCell.Controls.Add(this.cmbCell);
            this.pnlCell.Location = new System.Drawing.Point(4, 55);
            this.pnlCell.Name = "pnlCell";
            this.pnlCell.Size = new System.Drawing.Size(236, 63);
            this.pnlCell.TabIndex = 98;
            // 
            // frmSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1361, 691);
            this.Controls.Add(this.pnlCell);
            this.Controls.Add(this.pnlTots);
            this.Controls.Add(this.flpSale);
            this.Controls.Add(this.flpOption);
            this.Controls.Add(this.chkBill);
            this.Controls.Add(this.rbWhole);
            this.Controls.Add(this.rbRetail);
            this.Controls.Add(this.txtReference);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.MaximumSize = new System.Drawing.Size(2002, 1306);
            this.MinimumSize = new System.Drawing.Size(1022, 698);
            this.Name = "frmSale";
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
            this.Controls.SetChildIndex(this.pnlCell, 0);
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
            ((System.ComponentModel.ISupportInitialize)(this.numAmt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCredit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBillTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPaid)).EndInit();
            this.pnlCell.ResumeLayout(false);
            this.pnlCell.PerformLayout();
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
        public System.Windows.Forms.Label lblDiscount;
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
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Button btnSp1;
        private System.Windows.Forms.Button btnSp2;
        private System.Windows.Forms.Label lblCp;
        private System.Windows.Forms.DataGridViewImageColumn Remove;
        private System.Windows.Forms.DataGridViewImageColumn CP;
        private System.Windows.Forms.Button btnSwitchUser;
        private System.Windows.Forms.Button btnSupOrder;
        public System.Windows.Forms.Button btnBill;
        public System.Windows.Forms.NumericUpDown numAmt;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer tmr;
        private System.Windows.Forms.ComboBox cmbCell;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel pnlCell;

    }
}