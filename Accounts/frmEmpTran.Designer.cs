namespace prjGrow.Accounts
{
    partial class frmEmpTran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpTran));
            this.label10 = new System.Windows.Forms.Label();
            this.numAdv = new System.Windows.Forms.NumericUpDown();
            this.numAllocation = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.numDeduct = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSalAloc = new System.Windows.Forms.Button();
            this.gbOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAmt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBalance)).BeginInit();
            this.pnlBank.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBankBal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAdv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAllocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDeduct)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.TabIndex = 29;
            // 
            // btnSaveUpd
            // 
            this.btnSaveUpd.Location = new System.Drawing.Point(351, 312);
            this.btnSaveUpd.Click += new System.EventHandler(this.btnSaveUpd_Click);
            // 
            // btnClear
            // 
            this.btnClear.TabIndex = 28;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(178, 131);
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(178, 209);
            this.txtRemarks.TabIndex = 3;
            // 
            // numAmt
            // 
            this.numAmt.Location = new System.Drawing.Point(660, 210);
            this.numAmt.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numAmt.TabIndex = 6;
            this.numAmt.ValueChanged += new System.EventHandler(this.numAmt_ValueChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(91, 136);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(554, 212);
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.Text = "Paid Amount";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(91, 212);
            // 
            // cmbAccName
            // 
            this.cmbAccName.Location = new System.Drawing.Point(178, 169);
            this.cmbAccName.Size = new System.Drawing.Size(200, 28);
            this.cmbAccName.SelectedValueChanged += new System.EventHandler(this.cmbAccName_SelectedValueChanged);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(91, 173);
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.Text = "Employee";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(840, 237);
            this.label4.Visible = false;
            // 
            // numBalance
            // 
            this.numBalance.Location = new System.Drawing.Point(844, 268);
            this.numBalance.Visible = false;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(384, 169);
            this.btnAddNew.Size = new System.Drawing.Size(75, 28);
            this.btnAddNew.TabStop = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // pnlBank
            // 
            this.pnlBank.Location = new System.Drawing.Point(956, 185);
            this.pnlBank.Size = new System.Drawing.Size(36, 121);
            // 
            // cmbBank
            // 
            this.cmbBank.Size = new System.Drawing.Size(200, 28);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(554, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 20);
            this.label10.TabIndex = 42;
            this.label10.Text = "Advance";
            // 
            // numAdv
            // 
            this.numAdv.Location = new System.Drawing.Point(660, 134);
            this.numAdv.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numAdv.Name = "numAdv";
            this.numAdv.Size = new System.Drawing.Size(100, 26);
            this.numAdv.TabIndex = 4;
            this.numAdv.ValueChanged += new System.EventHandler(this.numAdv_ValueChanged);
            // 
            // numAllocation
            // 
            this.numAllocation.Location = new System.Drawing.Point(660, 263);
            this.numAllocation.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numAllocation.Name = "numAllocation";
            this.numAllocation.Size = new System.Drawing.Size(100, 26);
            this.numAllocation.TabIndex = 5;
            this.numAllocation.Visible = false;
            this.numAllocation.ValueChanged += new System.EventHandler(this.numAllocation_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(528, 266);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 20);
            this.label11.TabIndex = 44;
            this.label11.Text = "Salary Allocation";
            this.label11.Visible = false;
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
            this.dgvData.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvData.Location = new System.Drawing.Point(51, 347);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.Size = new System.Drawing.Size(900, 348);
            this.dgvData.TabIndex = 45;
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
            // numDeduct
            // 
            this.numDeduct.Location = new System.Drawing.Point(660, 171);
            this.numDeduct.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numDeduct.Name = "numDeduct";
            this.numDeduct.Size = new System.Drawing.Size(100, 26);
            this.numDeduct.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(554, 173);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 20);
            this.label12.TabIndex = 47;
            this.label12.Text = "Deduction";
            // 
            // btnSalAloc
            // 
            this.btnSalAloc.Location = new System.Drawing.Point(477, 313);
            this.btnSalAloc.Name = "btnSalAloc";
            this.btnSalAloc.Size = new System.Drawing.Size(201, 28);
            this.btnSalAloc.TabIndex = 22;
            this.btnSalAloc.Text = "Auto Salary Allocation";
            this.btnSalAloc.UseVisualStyleBackColor = true;
            this.btnSalAloc.Click += new System.EventHandler(this.btnSalAloc_Click);
            // 
            // frmEmpTran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 711);
            this.Controls.Add(this.btnSalAloc);
            this.Controls.Add(this.numDeduct);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.numAllocation);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.numAdv);
            this.Controls.Add(this.label10);
            this.Name = "frmEmpTran";
            this.Text = "Employee Transaction";
            this.Load += new System.EventHandler(this.frmEmpTran_Load);
            this.Controls.SetChildIndex(this.lblMsg, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lblTitle, 0);
            this.Controls.SetChildIndex(this.lblHead, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnSaveUpd, 0);
            this.Controls.SetChildIndex(this.btnClear, 0);
            this.Controls.SetChildIndex(this.gbOptions, 0);
            this.Controls.SetChildIndex(this.dtpDate, 0);
            this.Controls.SetChildIndex(this.txtRemarks, 0);
            this.Controls.SetChildIndex(this.numAmt, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.cmbAccName, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.numBalance, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.btnAddNew, 0);
            this.Controls.SetChildIndex(this.pnlBank, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.numAdv, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.numAllocation, 0);
            this.Controls.SetChildIndex(this.dgvData, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.numDeduct, 0);
            this.Controls.SetChildIndex(this.btnSalAloc, 0);
            this.gbOptions.ResumeLayout(false);
            this.gbOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAmt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBalance)).EndInit();
            this.pnlBank.ResumeLayout(false);
            this.pnlBank.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBankBal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAdv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAllocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDeduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numAdv;
        private System.Windows.Forms.NumericUpDown numAllocation;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.NumericUpDown numDeduct;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnSalAloc;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}