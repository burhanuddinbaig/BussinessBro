namespace prjGrow.StockInfo
{
    partial class frmSupplierOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSupplierOrders));
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.cmbProd = new System.Windows.Forms.ComboBox();
            this.cmbSupName = new System.Windows.Forms.ComboBox();
            this.numQty = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnOrderRep = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.gbSrh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(49, 259);
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(47, 50);
            // 
            // lblMsg
            // 
            this.lblMsg.Location = new System.Drawing.Point(265, 90);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(806, 264);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(680, 264);
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSaveUpd
            // 
            this.btnSaveUpd.Location = new System.Drawing.Point(399, 264);
            this.btnSaveUpd.Click += new System.EventHandler(this.btnSaveUpd_Click);
            // 
            // gbSrh
            // 
            this.gbSrh.Location = new System.Drawing.Point(938, 90);
            this.gbSrh.Size = new System.Drawing.Size(10, 57);
            this.gbSrh.Visible = false;
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
            this.Delete});
            this.dgvData.Location = new System.Drawing.Point(48, 300);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(900, 237);
            this.dgvData.TabIndex = 25;
            this.dgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
            // 
            // cmbProd
            // 
            this.cmbProd.FormattingEnabled = true;
            this.cmbProd.Location = new System.Drawing.Point(214, 131);
            this.cmbProd.Name = "cmbProd";
            this.cmbProd.Size = new System.Drawing.Size(201, 28);
            this.cmbProd.TabIndex = 1;
            // 
            // cmbSupName
            // 
            this.cmbSupName.FormattingEnabled = true;
            this.cmbSupName.Location = new System.Drawing.Point(577, 131);
            this.cmbSupName.Name = "cmbSupName";
            this.cmbSupName.Size = new System.Drawing.Size(190, 28);
            this.cmbSupName.TabIndex = 2;
            this.cmbSupName.SelectedValueChanged += new System.EventHandler(this.cmbSupName_SelectedValueChanged);
            // 
            // numQty
            // 
            this.numQty.Location = new System.Drawing.Point(214, 175);
            this.numQty.Name = "numQty";
            this.numQty.Size = new System.Drawing.Size(101, 26);
            this.numQty.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(98, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Product Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(458, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "Supplier Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(98, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 33;
            this.label6.Text = "Quantity";
            // 
            // btnOrderRep
            // 
            this.btnOrderRep.Location = new System.Drawing.Point(525, 264);
            this.btnOrderRep.Name = "btnOrderRep";
            this.btnOrderRep.Size = new System.Drawing.Size(149, 30);
            this.btnOrderRep.TabIndex = 35;
            this.btnOrderRep.Text = "Order Report";
            this.btnOrderRep.UseVisualStyleBackColor = true;
            this.btnOrderRep.Click += new System.EventHandler(this.btnOrderRep_Click);
            // 
            // Edit
            // 
            this.Edit.FillWeight = 50F;
            this.Edit.HeaderText = "Edit";
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            // 
            // Delete
            // 
            this.Delete.FillWeight = 50F;
            this.Delete.HeaderText = "Delete";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            // 
            // frmSupplierOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 561);
            this.Controls.Add(this.btnOrderRep);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numQty);
            this.Controls.Add(this.cmbSupName);
            this.Controls.Add(this.cmbProd);
            this.Controls.Add(this.dgvData);
            this.Name = "frmSupplierOrders";
            this.Text = "Supplier Orders";
            this.Load += new System.EventHandler(this.frmSupplierOrders_Load);
            this.Controls.SetChildIndex(this.lblMsg, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lblTitle, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnClear, 0);
            this.Controls.SetChildIndex(this.btnSaveUpd, 0);
            this.Controls.SetChildIndex(this.gbSrh, 0);
            this.Controls.SetChildIndex(this.lblClient, 0);
            this.Controls.SetChildIndex(this.dgvData, 0);
            this.Controls.SetChildIndex(this.cmbProd, 0);
            this.Controls.SetChildIndex(this.cmbSupName, 0);
            this.Controls.SetChildIndex(this.numQty, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.btnOrderRep, 0);
            this.gbSrh.ResumeLayout(false);
            this.gbSrh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.ComboBox cmbProd;
        private System.Windows.Forms.ComboBox cmbSupName;
        private System.Windows.Forms.NumericUpDown numQty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnOrderRep;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}