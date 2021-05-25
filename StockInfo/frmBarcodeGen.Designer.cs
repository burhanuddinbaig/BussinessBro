namespace prjGrow.StockInfo
{
    partial class frmBarcodeGen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBarcodeGen));
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.Remove = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.numQty = new System.Windows.Forms.NumericUpDown();
            this.cmbProd = new System.Windows.Forms.ComboBox();
            this.rbExist = new System.Windows.Forms.RadioButton();
            this.rbNew = new System.Windows.Forms.RadioButton();
            this.btnClr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Size = new System.Drawing.Size(661, 35);
            // 
            // lblMsg
            // 
            this.lblMsg.Size = new System.Drawing.Size(660, 20);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(51, 207);
            this.label1.Size = new System.Drawing.Size(550, 2);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(313, 212);
            this.btnGenerate.Text = "Start &Printing";
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(458, 212);
            this.btnCancel.Text = "&Close";
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
            this.dgvData.Location = new System.Drawing.Point(50, 248);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(550, 191);
            this.dgvData.TabIndex = 23;
            this.dgvData.TabStop = false;
            this.dgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
            // 
            // Remove
            // 
            this.Remove.FillWeight = 50F;
            this.Remove.HeaderText = "Remove";
            this.Remove.Image = ((System.Drawing.Image)(resources.GetObject("Remove.Image")));
            this.Remove.Name = "Remove";
            this.Remove.ReadOnly = true;
            this.Remove.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(88, 212);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(107, 30);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(85, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 18);
            this.label3.TabIndex = 26;
            this.label3.Text = "Product Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(85, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 18);
            this.label4.TabIndex = 27;
            this.label4.Text = "Product Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(85, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 28;
            this.label5.Text = "Quantity";
            // 
            // txtCode
            // 
            this.txtCode.Enabled = false;
            this.txtCode.Location = new System.Drawing.Point(191, 107);
            this.txtCode.MaxLength = 20;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(200, 24);
            this.txtCode.TabIndex = 3;
            this.txtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCode_KeyDown);
            // 
            // numQty
            // 
            this.numQty.InterceptArrowKeys = false;
            this.numQty.Location = new System.Drawing.Point(191, 174);
            this.numQty.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numQty.Name = "numQty";
            this.numQty.Size = new System.Drawing.Size(100, 24);
            this.numQty.TabIndex = 5;
            this.numQty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numQty_KeyDown);
            // 
            // cmbProd
            // 
            this.cmbProd.FormattingEnabled = true;
            this.cmbProd.Location = new System.Drawing.Point(191, 139);
            this.cmbProd.Name = "cmbProd";
            this.cmbProd.Size = new System.Drawing.Size(200, 26);
            this.cmbProd.TabIndex = 4;
            this.cmbProd.SelectedValueChanged += new System.EventHandler(this.cmbProd_SelectedValueChanged);
            // 
            // rbExist
            // 
            this.rbExist.AutoSize = true;
            this.rbExist.Checked = true;
            this.rbExist.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbExist.Location = new System.Drawing.Point(272, 77);
            this.rbExist.Name = "rbExist";
            this.rbExist.Size = new System.Drawing.Size(77, 22);
            this.rbExist.TabIndex = 2;
            this.rbExist.TabStop = true;
            this.rbExist.Text = "&Existing";
            this.rbExist.UseVisualStyleBackColor = true;
            this.rbExist.CheckedChanged += new System.EventHandler(this.rbNew_CheckedChanged);
            // 
            // rbNew
            // 
            this.rbNew.AutoSize = true;
            this.rbNew.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbNew.Location = new System.Drawing.Point(190, 77);
            this.rbNew.Name = "rbNew";
            this.rbNew.Size = new System.Drawing.Size(56, 22);
            this.rbNew.TabIndex = 1;
            this.rbNew.Text = "&New";
            this.rbNew.UseVisualStyleBackColor = true;
            this.rbNew.CheckedChanged += new System.EventHandler(this.rbNew_CheckedChanged);
            // 
            // btnClr
            // 
            this.btnClr.Location = new System.Drawing.Point(201, 212);
            this.btnClr.Name = "btnClr";
            this.btnClr.Size = new System.Drawing.Size(107, 30);
            this.btnClr.TabIndex = 20;
            this.btnClr.Text = "&Clear";
            this.btnClr.UseVisualStyleBackColor = true;
            this.btnClr.Click += new System.EventHandler(this.btnClr_Click);
            // 
            // frmBarcodeGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(664, 461);
            this.Controls.Add(this.btnClr);
            this.Controls.Add(this.rbNew);
            this.Controls.Add(this.rbExist);
            this.Controls.Add(this.cmbProd);
            this.Controls.Add(this.numQty);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvData);
            this.MaximumSize = new System.Drawing.Size(680, 600);
            this.MinimumSize = new System.Drawing.Size(680, 500);
            this.Name = "frmBarcodeGen";
            this.Text = "Barcode Generator";
            this.Load += new System.EventHandler(this.frmBarcodeGen_Load);
            this.Controls.SetChildIndex(this.dgvData, 0);
            this.Controls.SetChildIndex(this.btnAdd, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtCode, 0);
            this.Controls.SetChildIndex(this.numQty, 0);
            this.Controls.SetChildIndex(this.cmbProd, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lblMsg, 0);
            this.Controls.SetChildIndex(this.lblTitle, 0);
            this.Controls.SetChildIndex(this.btnGenerate, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.rbExist, 0);
            this.Controls.SetChildIndex(this.rbNew, 0);
            this.Controls.SetChildIndex(this.btnClr, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.NumericUpDown numQty;
        private System.Windows.Forms.ComboBox cmbProd;
        private System.Windows.Forms.RadioButton rbExist;
        private System.Windows.Forms.RadioButton rbNew;
        private System.Windows.Forms.DataGridViewImageColumn Remove;
        private System.Windows.Forms.Button btnClr;
    }
}