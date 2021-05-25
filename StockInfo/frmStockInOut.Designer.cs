namespace prjGrow.StockInfo
{
    partial class frmStockInOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStockInOut));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cmbProd = new System.Windows.Forms.ComboBox();
            this.numStock = new System.Windows.Forms.NumericUpDown();
            this.numQty = new System.Windows.Forms.NumericUpDown();
            this.cmbVeh = new System.Windows.Forms.ComboBox();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.rbStockOut = new System.Windows.Forms.RadioButton();
            this.rbStockIn = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gbSrh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(50, 234);
            // 
            // lblMsg
            // 
            this.lblMsg.Location = new System.Drawing.Point(194, 93);
            this.lblMsg.Size = new System.Drawing.Size(614, 24);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(808, 239);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(682, 239);
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSaveUpd
            // 
            this.btnSaveUpd.Location = new System.Drawing.Point(556, 239);
            this.btnSaveUpd.Click += new System.EventHandler(this.btnSaveUpd_Click);
            // 
            // gbSrh
            // 
            this.gbSrh.Location = new System.Drawing.Point(968, 90);
            this.gbSrh.Size = new System.Drawing.Size(10, 57);
            this.gbSrh.Visible = false;
            // 
            // lblClient
            // 
            this.lblClient.Location = new System.Drawing.Point(50, 7);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(467, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(95, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Vehicle:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(95, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Product Name:";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblStock.Location = new System.Drawing.Point(697, 198);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(97, 20);
            this.lblStock.TabIndex = 28;
            this.lblStock.Text = "Stock Store:";
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblQty.Location = new System.Drawing.Point(467, 198);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(77, 20);
            this.lblQty.TabIndex = 29;
            this.lblQty.Text = "Load Qty:";
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(550, 153);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(100, 26);
            this.dtpDate.TabIndex = 4;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // cmbProd
            // 
            this.cmbProd.FormattingEnabled = true;
            this.cmbProd.Location = new System.Drawing.Point(215, 195);
            this.cmbProd.Name = "cmbProd";
            this.cmbProd.Size = new System.Drawing.Size(200, 28);
            this.cmbProd.TabIndex = 6;
            this.cmbProd.SelectedValueChanged += new System.EventHandler(this.cmbProd_SelectedValueChanged);
            // 
            // numStock
            // 
            this.numStock.Enabled = false;
            this.numStock.Location = new System.Drawing.Point(800, 196);
            this.numStock.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numStock.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.numStock.Name = "numStock";
            this.numStock.Size = new System.Drawing.Size(100, 26);
            this.numStock.TabIndex = 34;
            // 
            // numQty
            // 
            this.numQty.Location = new System.Drawing.Point(550, 196);
            this.numQty.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numQty.Name = "numQty";
            this.numQty.Size = new System.Drawing.Size(100, 26);
            this.numQty.TabIndex = 7;
            this.numQty.ValueChanged += new System.EventHandler(this.numQty_ValueChanged);
            // 
            // cmbVeh
            // 
            this.cmbVeh.FormattingEnabled = true;
            this.cmbVeh.Location = new System.Drawing.Point(215, 151);
            this.cmbVeh.Name = "cmbVeh";
            this.cmbVeh.Size = new System.Drawing.Size(200, 28);
            this.cmbVeh.TabIndex = 3;
            this.cmbVeh.SelectedValueChanged += new System.EventHandler(this.cmbVeh_SelectedValueChanged);
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
            this.Delete});
            this.dgvData.Location = new System.Drawing.Point(50, 275);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(900, 260);
            this.dgvData.TabIndex = 37;
            this.dgvData.TabStop = false;
            this.dgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
            // 
            // Delete
            // 
            this.Delete.FillWeight = 30F;
            this.Delete.HeaderText = "Delete";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            // 
            // rbStockOut
            // 
            this.rbStockOut.AutoSize = true;
            this.rbStockOut.Checked = true;
            this.rbStockOut.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbStockOut.Location = new System.Drawing.Point(215, 118);
            this.rbStockOut.Name = "rbStockOut";
            this.rbStockOut.Size = new System.Drawing.Size(98, 24);
            this.rbStockOut.TabIndex = 1;
            this.rbStockOut.TabStop = true;
            this.rbStockOut.Text = "Stock Out";
            this.rbStockOut.UseVisualStyleBackColor = true;
            this.rbStockOut.CheckedChanged += new System.EventHandler(this.rbStockOut_CheckedChanged);
            // 
            // rbStockIn
            // 
            this.rbStockIn.AutoSize = true;
            this.rbStockIn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbStockIn.Location = new System.Drawing.Point(333, 119);
            this.rbStockIn.Name = "rbStockIn";
            this.rbStockIn.Size = new System.Drawing.Size(86, 24);
            this.rbStockIn.TabIndex = 2;
            this.rbStockIn.Text = "Stock In";
            this.rbStockIn.UseVisualStyleBackColor = true;
            this.rbStockIn.CheckedChanged += new System.EventHandler(this.rbStockIn_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(95, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 41;
            this.label6.Text = "Items:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(290, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 20);
            this.label8.TabIndex = 42;
            this.label8.Text = "Net Worth:";
            // 
            // frmStockInOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 561);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rbStockIn);
            this.Controls.Add(this.rbStockOut);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.cmbVeh);
            this.Controls.Add(this.numQty);
            this.Controls.Add(this.numStock);
            this.Controls.Add(this.cmbProd);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "frmStockInOut";
            this.Text = "Stock In Out";
            this.Load += new System.EventHandler(this.frmStockInOut_Load);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.lblMsg, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lblTitle, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnClear, 0);
            this.Controls.SetChildIndex(this.btnSaveUpd, 0);
            this.Controls.SetChildIndex(this.gbSrh, 0);
            this.Controls.SetChildIndex(this.lblClient, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.lblStock, 0);
            this.Controls.SetChildIndex(this.lblQty, 0);
            this.Controls.SetChildIndex(this.dtpDate, 0);
            this.Controls.SetChildIndex(this.cmbProd, 0);
            this.Controls.SetChildIndex(this.numStock, 0);
            this.Controls.SetChildIndex(this.numQty, 0);
            this.Controls.SetChildIndex(this.cmbVeh, 0);
            this.Controls.SetChildIndex(this.dgvData, 0);
            this.Controls.SetChildIndex(this.rbStockOut, 0);
            this.Controls.SetChildIndex(this.rbStockIn, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.gbSrh.ResumeLayout(false);
            this.gbSrh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox cmbProd;
        private System.Windows.Forms.NumericUpDown numStock;
        private System.Windows.Forms.NumericUpDown numQty;
        private System.Windows.Forms.ComboBox cmbVeh;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.RadioButton rbStockOut;
        private System.Windows.Forms.RadioButton rbStockIn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}