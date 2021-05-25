namespace prjGrow.StockInfo
{
    partial class frmInbound
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInbound));
            this.label6 = new System.Windows.Forms.Label();
            this.txtProdCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbProdName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numTotalStk = new System.Windows.Forms.NumericUpDown();
            this.numStkStore = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numQnty = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numStkShop = new System.Windows.Forms.NumericUpDown();
            this.lblShop = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblNote = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Remove = new System.Windows.Forms.DataGridViewImageColumn();
            this.gbSrh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalStk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStkStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQnty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStkShop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(47, 245);
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(47, 50);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(810, 250);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(684, 250);
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSaveUpd
            // 
            this.btnSaveUpd.Location = new System.Drawing.Point(558, 250);
            this.btnSaveUpd.Click += new System.EventHandler(this.btnSaveUpd_Click);
            // 
            // lblClient
            // 
            this.lblClient.Click += new System.EventHandler(this.lblClient_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(400, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 20);
            this.label6.TabIndex = 43;
            this.label6.Text = "Product Name";
            // 
            // txtProdCode
            // 
            this.txtProdCode.Location = new System.Drawing.Point(177, 209);
            this.txtProdCode.MaxLength = 40;
            this.txtProdCode.Name = "txtProdCode";
            this.txtProdCode.Size = new System.Drawing.Size(201, 26);
            this.txtProdCode.TabIndex = 2;
            this.txtProdCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtProdCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProdCode_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(65, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 42;
            this.label5.Text = "Product Code";
            // 
            // cmbProdName
            // 
            this.cmbProdName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbProdName.FormattingEnabled = true;
            this.cmbProdName.Location = new System.Drawing.Point(516, 209);
            this.cmbProdName.Name = "cmbProdName";
            this.cmbProdName.Size = new System.Drawing.Size(203, 28);
            this.cmbProdName.TabIndex = 3;
            this.cmbProdName.SelectedValueChanged += new System.EventHandler(this.cmbProdName_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(65, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 45;
            this.label2.Text = "Total Stock";
            // 
            // numTotalStk
            // 
            this.numTotalStk.Location = new System.Drawing.Point(177, 170);
            this.numTotalStk.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numTotalStk.Name = "numTotalStk";
            this.numTotalStk.ReadOnly = true;
            this.numTotalStk.Size = new System.Drawing.Size(100, 26);
            this.numTotalStk.TabIndex = 46;
            // 
            // numStkStore
            // 
            this.numStkStore.Location = new System.Drawing.Point(516, 169);
            this.numStkStore.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numStkStore.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.numStkStore.Name = "numStkStore";
            this.numStkStore.ReadOnly = true;
            this.numStkStore.Size = new System.Drawing.Size(100, 26);
            this.numStkStore.TabIndex = 48;
            this.numStkStore.ValueChanged += new System.EventHandler(this.numStkStore_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(400, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 47;
            this.label3.Text = "Stock Store";
            // 
            // numQnty
            // 
            this.numQnty.Location = new System.Drawing.Point(842, 210);
            this.numQnty.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numQnty.Name = "numQnty";
            this.numQnty.Size = new System.Drawing.Size(100, 26);
            this.numQnty.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(736, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 51;
            this.label4.Text = "Quantity";
            // 
            // numStkShop
            // 
            this.numStkShop.Location = new System.Drawing.Point(110, 3);
            this.numStkShop.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numStkShop.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.numStkShop.Name = "numStkShop";
            this.numStkShop.ReadOnly = true;
            this.numStkShop.Size = new System.Drawing.Size(100, 26);
            this.numStkShop.TabIndex = 50;
            this.numStkShop.ValueChanged += new System.EventHandler(this.numStkShop_ValueChanged);
            // 
            // lblShop
            // 
            this.lblShop.AutoSize = true;
            this.lblShop.BackColor = System.Drawing.Color.Transparent;
            this.lblShop.ForeColor = System.Drawing.Color.White;
            this.lblShop.Location = new System.Drawing.Point(4, 5);
            this.lblShop.Name = "lblShop";
            this.lblShop.Size = new System.Drawing.Size(92, 20);
            this.lblShop.TabIndex = 49;
            this.lblShop.Text = "Stock Shop";
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
            this.dgvData.Location = new System.Drawing.Point(47, 286);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.Size = new System.Drawing.Size(898, 254);
            this.dgvData.TabIndex = 53;
            this.dgvData.TabStop = false;
            this.dgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(65, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 20);
            this.label8.TabIndex = 55;
            this.label8.Text = "Date";
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(177, 130);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(100, 26);
            this.dtpDate.TabIndex = 1;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(65, 255);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(303, 20);
            this.lblNote.TabIndex = 56;
            this.lblNote.Text = "note: Stock will be consumed on issuance";
            this.lblNote.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numStkShop);
            this.panel1.Controls.Add(this.lblShop);
            this.panel1.Location = new System.Drawing.Point(730, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 34);
            this.panel1.TabIndex = 57;
            // 
            // Remove
            // 
            this.Remove.HeaderText = "Return";
            this.Remove.Image = ((System.Drawing.Image)(resources.GetObject("Remove.Image")));
            this.Remove.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Remove.Name = "Remove";
            this.Remove.ReadOnly = true;
            // 
            // frmInbound
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.numQnty);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numStkStore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numTotalStk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtProdCode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbProdName);
            this.Name = "frmInbound";
            this.Text = "Store";
            this.Load += new System.EventHandler(this.frmInbound_Load);
            this.Controls.SetChildIndex(this.lblMsg, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lblTitle, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnClear, 0);
            this.Controls.SetChildIndex(this.btnSaveUpd, 0);
            this.Controls.SetChildIndex(this.gbSrh, 0);
            this.Controls.SetChildIndex(this.lblClient, 0);
            this.Controls.SetChildIndex(this.cmbProdName, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtProdCode, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.numTotalStk, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.numStkStore, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.numQnty, 0);
            this.Controls.SetChildIndex(this.dgvData, 0);
            this.Controls.SetChildIndex(this.dtpDate, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.lblNote, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.gbSrh.ResumeLayout(false);
            this.gbSrh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalStk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStkStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQnty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStkShop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label label6;
        protected System.Windows.Forms.TextBox txtProdCode;
        protected System.Windows.Forms.Label label5;
        protected System.Windows.Forms.ComboBox cmbProdName;
        protected System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numTotalStk;
        private System.Windows.Forms.NumericUpDown numStkStore;
        protected System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numQnty;
        protected System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numStkShop;
        protected System.Windows.Forms.Label lblShop;
        private System.Windows.Forms.DataGridView dgvData;
        protected System.Windows.Forms.Label label8;
        protected System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewImageColumn Remove;

    }
}