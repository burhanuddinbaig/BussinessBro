namespace prjGrow.Manufacture
{
    partial class frmProgress
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProgress));
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.Factory = new System.Windows.Forms.DataGridViewImageColumn();
            this.Ready = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnOdr = new System.Windows.Forms.Button();
            this.gbSrh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMsg
            // 
            this.lblMsg.Size = new System.Drawing.Size(1077, 22);
            // 
            // lblTitle
            // 
            this.lblTitle.Size = new System.Drawing.Size(1079, 35);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(54, 446);
            this.label1.Size = new System.Drawing.Size(994, 2);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(923, 453);
            // 
            // btnSaveUpd
            // 
            this.btnSaveUpd.Location = new System.Drawing.Point(1062, 327);
            this.btnSaveUpd.Size = new System.Drawing.Size(10, 30);
            this.btnSaveUpd.Visible = false;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(1071, 327);
            this.btnClear.Size = new System.Drawing.Size(10, 30);
            this.btnClear.Visible = false;
            // 
            // gbSrh
            // 
            this.gbSrh.Location = new System.Drawing.Point(1055, 259);
            this.gbSrh.Size = new System.Drawing.Size(26, 44);
            this.gbSrh.Visible = false;
            // 
            // lblClient
            // 
            this.lblClient.Size = new System.Drawing.Size(1080, 35);
            // 
            // txtSrh
            // 
            this.txtSrh.Location = new System.Drawing.Point(8, 10);
            this.txtSrh.Size = new System.Drawing.Size(10, 24);
            this.txtSrh.Visible = false;
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
            this.Factory,
            this.Ready});
            this.dgvData.Location = new System.Drawing.Point(54, 106);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.Size = new System.Drawing.Size(994, 337);
            this.dgvData.TabIndex = 32;
            this.dgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
            // 
            // Factory
            // 
            this.Factory.FillWeight = 60F;
            this.Factory.HeaderText = "Factory";
            this.Factory.Image = ((System.Drawing.Image)(resources.GetObject("Factory.Image")));
            this.Factory.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Factory.Name = "Factory";
            this.Factory.ReadOnly = true;
            // 
            // Ready
            // 
            this.Ready.FillWeight = 60F;
            this.Ready.HeaderText = "Ready";
            this.Ready.Image = ((System.Drawing.Image)(resources.GetObject("Ready.Image")));
            this.Ready.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Ready.Name = "Ready";
            this.Ready.ReadOnly = true;
            // 
            // btnOdr
            // 
            this.btnOdr.Location = new System.Drawing.Point(63, 453);
            this.btnOdr.Name = "btnOdr";
            this.btnOdr.Size = new System.Drawing.Size(146, 30);
            this.btnOdr.TabIndex = 33;
            this.btnOdr.Text = "New Order";
            this.btnOdr.UseVisualStyleBackColor = true;
            this.btnOdr.Click += new System.EventHandler(this.btnOdr_Click);
            // 
            // frmProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 512);
            this.Controls.Add(this.btnOdr);
            this.Controls.Add(this.dgvData);
            this.Name = "frmProgress";
            this.Text = "Order Progress";
            this.Load += new System.EventHandler(this.frmProgress_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lblTitle, 0);
            this.Controls.SetChildIndex(this.lblMsg, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnSaveUpd, 0);
            this.Controls.SetChildIndex(this.btnClear, 0);
            this.Controls.SetChildIndex(this.gbSrh, 0);
            this.Controls.SetChildIndex(this.lblClient, 0);
            this.Controls.SetChildIndex(this.dgvData, 0);
            this.Controls.SetChildIndex(this.btnOdr, 0);
            this.gbSrh.ResumeLayout(false);
            this.gbSrh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.DataGridViewImageColumn Factory;
        private System.Windows.Forms.DataGridViewImageColumn Ready;
        private System.Windows.Forms.Button btnOdr;
    }
}