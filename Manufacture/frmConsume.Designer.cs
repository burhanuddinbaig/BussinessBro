namespace prjGrow.Manufacture
{
    partial class frmConsume
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsume));
            this.btnProd = new System.Windows.Forms.Button();
            this.numCurStock = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numQty = new System.Windows.Forms.NumericUpDown();
            this.cmbProd = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rbFactory = new System.Windows.Forms.RadioButton();
            this.rbStore = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbShop = new System.Windows.Forms.RadioButton();
            this.gbSrh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCurStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(47, 50);
            // 
            // btnSaveUpd
            // 
            this.btnSaveUpd.Click += new System.EventHandler(this.btnSaveUpd_Click);
            // 
            // gbSrh
            // 
            this.gbSrh.Visible = false;
            // 
            // btnProd
            // 
            this.btnProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProd.Location = new System.Drawing.Point(343, 141);
            this.btnProd.Margin = new System.Windows.Forms.Padding(4);
            this.btnProd.Name = "btnProd";
            this.btnProd.Size = new System.Drawing.Size(71, 28);
            this.btnProd.TabIndex = 80;
            this.btnProd.Text = "Add New";
            this.btnProd.UseVisualStyleBackColor = true;
            this.btnProd.Click += new System.EventHandler(this.btnProd_Click);
            // 
            // numCurStock
            // 
            this.numCurStock.Enabled = false;
            this.numCurStock.Location = new System.Drawing.Point(587, 174);
            this.numCurStock.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numCurStock.Name = "numCurStock";
            this.numCurStock.Size = new System.Drawing.Size(103, 26);
            this.numCurStock.TabIndex = 79;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(474, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 78;
            this.label5.Text = "Current Stock";
            // 
            // numQty
            // 
            this.numQty.Location = new System.Drawing.Point(214, 219);
            this.numQty.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numQty.Name = "numQty";
            this.numQty.Size = new System.Drawing.Size(103, 26);
            this.numQty.TabIndex = 77;
            // 
            // cmbProd
            // 
            this.cmbProd.FormattingEnabled = true;
            this.cmbProd.Location = new System.Drawing.Point(214, 173);
            this.cmbProd.Name = "cmbProd";
            this.cmbProd.Size = new System.Drawing.Size(200, 28);
            this.cmbProd.TabIndex = 76;
            this.cmbProd.SelectedIndexChanged += new System.EventHandler(this.cmbProd_SelectedIndexChanged);
            this.cmbProd.SelectedValueChanged += new System.EventHandler(this.cmbProd_SelectedValueChanged);
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(214, 131);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(103, 26);
            this.dtpDate.TabIndex = 75;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(95, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 74;
            this.label4.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(95, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 73;
            this.label3.Text = "Product Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(95, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 72;
            this.label2.Text = "Date";
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AllowUserToResizeColumns = false;
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit,
            this.Delete});
            this.dgvData.Location = new System.Drawing.Point(53, 348);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.Size = new System.Drawing.Size(900, 341);
            this.dgvData.TabIndex = 81;
            this.dgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
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
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(587, 218);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(200, 26);
            this.txtRemarks.TabIndex = 84;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(474, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 85;
            this.label6.Text = "Remarks";
            // 
            // rbFactory
            // 
            this.rbFactory.AutoSize = true;
            this.rbFactory.Checked = true;
            this.rbFactory.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbFactory.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbFactory.Location = new System.Drawing.Point(0, 0);
            this.rbFactory.Name = "rbFactory";
            this.rbFactory.Size = new System.Drawing.Size(80, 27);
            this.rbFactory.TabIndex = 83;
            this.rbFactory.TabStop = true;
            this.rbFactory.Text = "Factory";
            this.rbFactory.UseVisualStyleBackColor = true;
            this.rbFactory.Visible = false;
            this.rbFactory.CheckedChanged += new System.EventHandler(this.rbFactory_CheckedChanged);
            // 
            // rbStore
            // 
            this.rbStore.AutoSize = true;
            this.rbStore.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbStore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbStore.Location = new System.Drawing.Point(80, 0);
            this.rbStore.Name = "rbStore";
            this.rbStore.Size = new System.Drawing.Size(66, 27);
            this.rbStore.TabIndex = 82;
            this.rbStore.Text = "Store";
            this.rbStore.UseVisualStyleBackColor = true;
            this.rbStore.Visible = false;
            this.rbStore.CheckedChanged += new System.EventHandler(this.rbStore_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(474, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 20);
            this.label7.TabIndex = 86;
            this.label7.Text = "From";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbShop);
            this.panel1.Controls.Add(this.rbStore);
            this.panel1.Controls.Add(this.rbFactory);
            this.panel1.Location = new System.Drawing.Point(577, 131);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 27);
            this.panel1.TabIndex = 87;
            // 
            // rbShop
            // 
            this.rbShop.AutoSize = true;
            this.rbShop.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbShop.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbShop.Location = new System.Drawing.Point(146, 0);
            this.rbShop.Name = "rbShop";
            this.rbShop.Size = new System.Drawing.Size(65, 27);
            this.rbShop.TabIndex = 84;
            this.rbShop.Text = "Shop";
            this.rbShop.UseVisualStyleBackColor = true;
            this.rbShop.Visible = false;
            this.rbShop.CheckedChanged += new System.EventHandler(this.rbShop_CheckedChanged);
            // 
            // frmConsume
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 711);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.btnProd);
            this.Controls.Add(this.numCurStock);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numQty);
            this.Controls.Add(this.cmbProd);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "frmConsume";
            this.Text = "Stock Consumption";
            this.Load += new System.EventHandler(this.frmConsume_Load);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.dtpDate, 0);
            this.Controls.SetChildIndex(this.cmbProd, 0);
            this.Controls.SetChildIndex(this.numQty, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.numCurStock, 0);
            this.Controls.SetChildIndex(this.btnProd, 0);
            this.Controls.SetChildIndex(this.dgvData, 0);
            this.Controls.SetChildIndex(this.lblMsg, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lblTitle, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnClear, 0);
            this.Controls.SetChildIndex(this.btnSaveUpd, 0);
            this.Controls.SetChildIndex(this.gbSrh, 0);
            this.Controls.SetChildIndex(this.lblClient, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txtRemarks, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.gbSrh.ResumeLayout(false);
            this.gbSrh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCurStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnProd;
        private System.Windows.Forms.NumericUpDown numCurStock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numQty;
        private System.Windows.Forms.ComboBox cmbProd;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbFactory;
        private System.Windows.Forms.RadioButton rbStore;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbShop;
    }
}