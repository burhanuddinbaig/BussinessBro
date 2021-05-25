namespace prjGrow.Manufacture
{
    partial class frmAutoConsume
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAutoConsume));
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Del = new System.Windows.Forms.DataGridViewImageColumn();
            this.lblProd1 = new System.Windows.Forms.Label();
            this.cmbServ = new System.Windows.Forms.ComboBox();
            this.numQty = new System.Windows.Forms.NumericUpDown();
            this.cmbRaw = new System.Windows.Forms.ComboBox();
            this.lblProd2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbSrh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(54, 246);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(534, 254);
            // 
            // btnSaveUpd
            // 
            this.btnSaveUpd.Location = new System.Drawing.Point(318, 254);
            this.btnSaveUpd.Click += new System.EventHandler(this.btnSaveUpd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(426, 254);
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // gbSrh
            // 
            this.gbSrh.Location = new System.Drawing.Point(679, 78);
            this.gbSrh.Size = new System.Drawing.Size(10, 61);
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
            this.Del});
            this.dgvData.Location = new System.Drawing.Point(54, 290);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.Size = new System.Drawing.Size(600, 249);
            this.dgvData.TabIndex = 32;
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
            // Del
            // 
            this.Del.FillWeight = 40F;
            this.Del.HeaderText = "Del";
            this.Del.Image = ((System.Drawing.Image)(resources.GetObject("Del.Image")));
            this.Del.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Del.Name = "Del";
            this.Del.ReadOnly = true;
            // 
            // lblProd1
            // 
            this.lblProd1.AutoSize = true;
            this.lblProd1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblProd1.Location = new System.Drawing.Point(86, 121);
            this.lblProd1.Name = "lblProd1";
            this.lblProd1.Size = new System.Drawing.Size(57, 18);
            this.lblProd1.TabIndex = 33;
            this.lblProd1.Text = "Service";
            // 
            // cmbServ
            // 
            this.cmbServ.FormattingEnabled = true;
            this.cmbServ.Location = new System.Drawing.Point(191, 118);
            this.cmbServ.Name = "cmbServ";
            this.cmbServ.Size = new System.Drawing.Size(200, 26);
            this.cmbServ.TabIndex = 34;
            // 
            // numQty
            // 
            this.numQty.DecimalPlaces = 2;
            this.numQty.Location = new System.Drawing.Point(191, 194);
            this.numQty.Name = "numQty";
            this.numQty.Size = new System.Drawing.Size(100, 24);
            this.numQty.TabIndex = 35;
            // 
            // cmbRaw
            // 
            this.cmbRaw.FormattingEnabled = true;
            this.cmbRaw.Location = new System.Drawing.Point(191, 155);
            this.cmbRaw.Name = "cmbRaw";
            this.cmbRaw.Size = new System.Drawing.Size(200, 26);
            this.cmbRaw.TabIndex = 36;
            // 
            // lblProd2
            // 
            this.lblProd2.AutoSize = true;
            this.lblProd2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblProd2.Location = new System.Drawing.Point(86, 158);
            this.lblProd2.Name = "lblProd2";
            this.lblProd2.Size = new System.Drawing.Size(86, 18);
            this.lblProd2.TabIndex = 37;
            this.lblProd2.Text = "Raw Matiral";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(86, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 18);
            this.label4.TabIndex = 38;
            this.label4.Text = "Consume Qty";
            // 
            // frmAutoConsume
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 561);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblProd2);
            this.Controls.Add(this.cmbRaw);
            this.Controls.Add(this.numQty);
            this.Controls.Add(this.cmbServ);
            this.Controls.Add(this.lblProd1);
            this.Controls.Add(this.dgvData);
            this.Name = "frmAutoConsume";
            this.Text = "Auto Consumption";
            this.Load += new System.EventHandler(this.frmLinkProd_Load);
            this.Controls.SetChildIndex(this.dgvData, 0);
            this.Controls.SetChildIndex(this.lblProd1, 0);
            this.Controls.SetChildIndex(this.cmbServ, 0);
            this.Controls.SetChildIndex(this.numQty, 0);
            this.Controls.SetChildIndex(this.cmbRaw, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lblTitle, 0);
            this.Controls.SetChildIndex(this.lblMsg, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnSaveUpd, 0);
            this.Controls.SetChildIndex(this.btnClear, 0);
            this.Controls.SetChildIndex(this.gbSrh, 0);
            this.Controls.SetChildIndex(this.lblClient, 0);
            this.Controls.SetChildIndex(this.lblProd2, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.gbSrh.ResumeLayout(false);
            this.gbSrh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Label lblProd1;
        private System.Windows.Forms.ComboBox cmbServ;
        private System.Windows.Forms.NumericUpDown numQty;
        private System.Windows.Forms.ComboBox cmbRaw;
        private System.Windows.Forms.Label lblProd2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Del;

    }
}