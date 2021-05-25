namespace prjGrow.Accounts
{
    partial class frmBankTran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBankTran));
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numDeposit = new System.Windows.Forms.NumericUpDown();
            this.numWithdraw = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbBankName = new System.Windows.Forms.ComboBox();
            this.txtAccno = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.btnAddBank = new System.Windows.Forms.Button();
            this.numBalance = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.gbSrh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDeposit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWithdraw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBalance)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Text = "E Light Software Solutions, Pakistan LTD";
            // 
            // lblMsg
            // 
            this.lblMsg.Location = new System.Drawing.Point(228, 93);
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
            // gbSrh
            // 
            this.gbSrh.Location = new System.Drawing.Point(805, 94);
            this.gbSrh.Visible = false;
            // 
            // lblClient
            // 
            this.lblClient.Location = new System.Drawing.Point(50, 7);
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
            this.Edit,
            this.Delete});
            this.dgvData.Location = new System.Drawing.Point(52, 348);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.Size = new System.Drawing.Size(901, 339);
            this.dgvData.TabIndex = 25;
            this.dgvData.TabStop = false;
            this.dgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
            // 
            // Edit
            // 
            this.Edit.FillWeight = 35F;
            this.Edit.HeaderText = "Edit";
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            // 
            // Delete
            // 
            this.Delete.FillWeight = 35F;
            this.Delete.HeaderText = "Delete";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(101, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Bank Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(492, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Withdraw";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(492, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Bank Acc no";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(101, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Date";
            // 
            // numDeposit
            // 
            this.numDeposit.Location = new System.Drawing.Point(196, 210);
            this.numDeposit.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numDeposit.Name = "numDeposit";
            this.numDeposit.Size = new System.Drawing.Size(100, 26);
            this.numDeposit.TabIndex = 3;
            this.numDeposit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numDeposit.ThousandsSeparator = true;
            this.numDeposit.ValueChanged += new System.EventHandler(this.numDeposit_ValueChanged);
            // 
            // numWithdraw
            // 
            this.numWithdraw.Location = new System.Drawing.Point(606, 210);
            this.numWithdraw.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numWithdraw.Name = "numWithdraw";
            this.numWithdraw.Size = new System.Drawing.Size(100, 26);
            this.numWithdraw.TabIndex = 4;
            this.numWithdraw.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numWithdraw.ThousandsSeparator = true;
            this.numWithdraw.ValueChanged += new System.EventHandler(this.numWithdraw_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(101, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 20);
            this.label7.TabIndex = 35;
            this.label7.Text = "Deposit";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(101, 255);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 20);
            this.label8.TabIndex = 36;
            this.label8.Text = "Remarks";
            // 
            // cmbBankName
            // 
            this.cmbBankName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbBankName.FormattingEnabled = true;
            this.cmbBankName.Location = new System.Drawing.Point(196, 166);
            this.cmbBankName.Name = "cmbBankName";
            this.cmbBankName.Size = new System.Drawing.Size(200, 28);
            this.cmbBankName.TabIndex = 2;
            this.cmbBankName.SelectedValueChanged += new System.EventHandler(this.cmbBankName_SelectedValueChanged);
            // 
            // txtAccno
            // 
            this.txtAccno.Location = new System.Drawing.Point(604, 166);
            this.txtAccno.Name = "txtAccno";
            this.txtAccno.ReadOnly = true;
            this.txtAccno.Size = new System.Drawing.Size(200, 26);
            this.txtAccno.TabIndex = 38;
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(196, 125);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(100, 26);
            this.dtpDate.TabIndex = 1;
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(196, 252);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(200, 26);
            this.txtRemarks.TabIndex = 5;
            // 
            // btnAddBank
            // 
            this.btnAddBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBank.Location = new System.Drawing.Point(402, 166);
            this.btnAddBank.Name = "btnAddBank";
            this.btnAddBank.Size = new System.Drawing.Size(72, 28);
            this.btnAddBank.TabIndex = 39;
            this.btnAddBank.Text = "Add New";
            this.btnAddBank.UseVisualStyleBackColor = true;
            this.btnAddBank.Click += new System.EventHandler(this.btnAddBank_Click);
            // 
            // numBalance
            // 
            this.numBalance.Enabled = false;
            this.numBalance.Location = new System.Drawing.Point(606, 125);
            this.numBalance.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numBalance.Minimum = new decimal(new int[] {
            9999999,
            0,
            0,
            -2147483648});
            this.numBalance.Name = "numBalance";
            this.numBalance.ReadOnly = true;
            this.numBalance.Size = new System.Drawing.Size(100, 26);
            this.numBalance.TabIndex = 40;
            this.numBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numBalance.ThousandsSeparator = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(492, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 20);
            this.label6.TabIndex = 41;
            this.label6.Text = "Bank Balance";
            // 
            // frmBankTran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 711);
            this.Controls.Add(this.numBalance);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAddBank);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.txtAccno);
            this.Controls.Add(this.cmbBankName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numWithdraw);
            this.Controls.Add(this.numDeposit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvData);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Name = "frmBankTran";
            this.Text = "Bank Transactions";
            this.Load += new System.EventHandler(this.frmBankLog_Load);
            this.Controls.SetChildIndex(this.lblMsg, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lblTitle, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnClear, 0);
            this.Controls.SetChildIndex(this.btnSaveUpd, 0);
            this.Controls.SetChildIndex(this.gbSrh, 0);
            this.Controls.SetChildIndex(this.lblClient, 0);
            this.Controls.SetChildIndex(this.dgvData, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.numDeposit, 0);
            this.Controls.SetChildIndex(this.numWithdraw, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.cmbBankName, 0);
            this.Controls.SetChildIndex(this.txtAccno, 0);
            this.Controls.SetChildIndex(this.dtpDate, 0);
            this.Controls.SetChildIndex(this.txtRemarks, 0);
            this.Controls.SetChildIndex(this.btnAddBank, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.numBalance, 0);
            this.gbSrh.ResumeLayout(false);
            this.gbSrh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDeposit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWithdraw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBalance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numDeposit;
        private System.Windows.Forms.NumericUpDown numWithdraw;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbBankName;
        private System.Windows.Forms.TextBox txtAccno;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Button btnAddBank;
        private System.Windows.Forms.NumericUpDown numBalance;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}