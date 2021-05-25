namespace prjGrow.Accounts
{
    partial class frmCoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCoa));
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.numBalDr = new System.Windows.Forms.NumericUpDown();
            this.txtAccCode = new System.Windows.Forms.TextBox();
            this.txtAccName = new System.Windows.Forms.TextBox();
            this.numBalCr = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numAccNo = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.gbSrh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBalDr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBalCr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAccNo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMsg
            // 
            this.lblMsg.Location = new System.Drawing.Point(258, 93);
            // 
            // btnClear
            // 
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSaveUpd
            // 
            this.btnSaveUpd.Click += new System.EventHandler(this.btnSaveUpd_Click);
            // 
            // txtSrh
            // 
            this.txtSrh.TextChanged += new System.EventHandler(this.txtSrh_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(97, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 106;
            this.label5.Text = "Account Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(97, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 107;
            this.label2.Text = "Account Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(97, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 20);
            this.label3.TabIndex = 108;
            this.label3.Text = "Opening Balance DR";
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
            this.Edit});
            this.dgvData.Location = new System.Drawing.Point(52, 348);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.Size = new System.Drawing.Size(901, 339);
            this.dgvData.TabIndex = 110;
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
            // numBalDr
            // 
            this.numBalDr.Location = new System.Drawing.Point(256, 230);
            this.numBalDr.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numBalDr.Name = "numBalDr";
            this.numBalDr.Size = new System.Drawing.Size(100, 26);
            this.numBalDr.TabIndex = 1;
            this.numBalDr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numBalDr.ThousandsSeparator = true;
            this.numBalDr.ValueChanged += new System.EventHandler(this.numBal_ValueChanged);
            // 
            // txtAccCode
            // 
            this.txtAccCode.Location = new System.Drawing.Point(256, 124);
            this.txtAccCode.MaxLength = 32;
            this.txtAccCode.Name = "txtAccCode";
            this.txtAccCode.ReadOnly = true;
            this.txtAccCode.Size = new System.Drawing.Size(100, 26);
            this.txtAccCode.TabIndex = 112;
            this.txtAccCode.TabStop = false;
            this.txtAccCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAccName
            // 
            this.txtAccName.Location = new System.Drawing.Point(256, 195);
            this.txtAccName.MaxLength = 32;
            this.txtAccName.Name = "txtAccName";
            this.txtAccName.ReadOnly = true;
            this.txtAccName.Size = new System.Drawing.Size(200, 26);
            this.txtAccName.TabIndex = 113;
            this.txtAccName.TabStop = false;
            this.txtAccName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numBalCr
            // 
            this.numBalCr.Location = new System.Drawing.Point(256, 266);
            this.numBalCr.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numBalCr.Name = "numBalCr";
            this.numBalCr.Size = new System.Drawing.Size(100, 26);
            this.numBalCr.TabIndex = 2;
            this.numBalCr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numBalCr.ThousandsSeparator = true;
            this.numBalCr.ValueChanged += new System.EventHandler(this.numBalCr_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(97, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 20);
            this.label4.TabIndex = 115;
            this.label4.Text = "Opening Balance CR";
            // 
            // numAccNo
            // 
            this.numAccNo.Enabled = false;
            this.numAccNo.Location = new System.Drawing.Point(256, 160);
            this.numAccNo.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numAccNo.Name = "numAccNo";
            this.numAccNo.Size = new System.Drawing.Size(100, 26);
            this.numAccNo.TabIndex = 116;
            this.numAccNo.TabStop = false;
            this.numAccNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numAccNo.ThousandsSeparator = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(97, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 117;
            this.label6.Text = "Account no";
            // 
            // frmCoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 711);
            this.Controls.Add(this.numAccNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numBalCr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAccName);
            this.Controls.Add(this.txtAccCode);
            this.Controls.Add(this.numBalDr);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Name = "frmCoa";
            this.Text = "Chart of Account";
            this.Load += new System.EventHandler(this.frmCoa_Load);
            this.Controls.SetChildIndex(this.lblMsg, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lblTitle, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnClear, 0);
            this.Controls.SetChildIndex(this.btnSaveUpd, 0);
            this.Controls.SetChildIndex(this.gbSrh, 0);
            this.Controls.SetChildIndex(this.lblClient, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.dgvData, 0);
            this.Controls.SetChildIndex(this.numBalDr, 0);
            this.Controls.SetChildIndex(this.txtAccCode, 0);
            this.Controls.SetChildIndex(this.txtAccName, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.numBalCr, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.numAccNo, 0);
            this.gbSrh.ResumeLayout(false);
            this.gbSrh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBalDr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBalCr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAccNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.NumericUpDown numBalDr;
        private System.Windows.Forms.TextBox txtAccCode;
        private System.Windows.Forms.TextBox txtAccName;
        private System.Windows.Forms.NumericUpDown numBalCr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numAccNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
    }
}