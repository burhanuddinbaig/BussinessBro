namespace prjGrow.Accounts
{
    partial class frmSupplierTran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSupplierTran));
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.numAmount = new System.Windows.Forms.NumericUpDown();
            this.cmbSup = new System.Windows.Forms.ComboBox();
            this.cmbBank = new System.Windows.Forms.ComboBox();
            this.numBalance = new System.Windows.Forms.NumericUpDown();
            this.txtAccno = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpIssue = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCheq_no = new System.Windows.Forms.TextBox();
            this.txtReference = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.numDist = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.gbSrh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDist)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(49, 292);
            // 
            // lblTitle
            // 
            this.lblTitle.Text = "E Light Software Solutions, Pakistan LTD";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(806, 297);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(680, 297);
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSaveUpd
            // 
            this.btnSaveUpd.Location = new System.Drawing.Point(554, 297);
            this.btnSaveUpd.Click += new System.EventHandler(this.btnSaveUpd_Click);
            // 
            // txtSrh
            // 
            this.txtSrh.TextChanged += new System.EventHandler(this.txtSrh_TextChanged);
            // 
            // gbSrh
            // 
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
            this.dgvData.Location = new System.Drawing.Point(53, 333);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.Size = new System.Drawing.Size(900, 355);
            this.dgvData.TabIndex = 25;
            this.dgvData.TabStop = false;
            this.dgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(100, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Supplier Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(100, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Paid Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(100, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Bank Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(100, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Date";
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(213, 121);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(100, 26);
            this.dtpDate.TabIndex = 1;
            // 
            // numAmount
            // 
            this.numAmount.Location = new System.Drawing.Point(213, 221);
            this.numAmount.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numAmount.Name = "numAmount";
            this.numAmount.Size = new System.Drawing.Size(100, 26);
            this.numAmount.TabIndex = 4;
            this.numAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numAmount.ThousandsSeparator = true;
            this.numAmount.ValueChanged += new System.EventHandler(this.numAmount_ValueChanged);
            // 
            // cmbSup
            // 
            this.cmbSup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbSup.FormattingEnabled = true;
            this.cmbSup.Location = new System.Drawing.Point(213, 153);
            this.cmbSup.Name = "cmbSup";
            this.cmbSup.Size = new System.Drawing.Size(200, 28);
            this.cmbSup.TabIndex = 2;
            this.cmbSup.SelectedValueChanged += new System.EventHandler(this.cmbSup_SelectedValueChanged);
            // 
            // cmbBank
            // 
            this.cmbBank.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbBank.FormattingEnabled = true;
            this.cmbBank.Location = new System.Drawing.Point(213, 187);
            this.cmbBank.Name = "cmbBank";
            this.cmbBank.Size = new System.Drawing.Size(200, 28);
            this.cmbBank.TabIndex = 3;
            this.cmbBank.TextChanged += new System.EventHandler(this.cmbBank_TextChanged);
            // 
            // numBalance
            // 
            this.numBalance.Location = new System.Drawing.Point(608, 124);
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
            this.numBalance.TabIndex = 41;
            this.numBalance.TabStop = false;
            this.numBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numBalance.ThousandsSeparator = true;
            // 
            // txtAccno
            // 
            this.txtAccno.Location = new System.Drawing.Point(608, 158);
            this.txtAccno.Name = "txtAccno";
            this.txtAccno.ReadOnly = true;
            this.txtAccno.Size = new System.Drawing.Size(100, 26);
            this.txtAccno.TabIndex = 44;
            this.txtAccno.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(473, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 20);
            this.label8.TabIndex = 47;
            this.label8.Text = "Bank Acc No";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(473, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 20);
            this.label10.TabIndex = 45;
            this.label10.Text = "Supplier Balance";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(473, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 48;
            this.label6.Text = "Cheque No";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpIssue
            // 
            this.dtpIssue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIssue.Location = new System.Drawing.Point(608, 189);
            this.dtpIssue.Name = "dtpIssue";
            this.dtpIssue.Size = new System.Drawing.Size(100, 26);
            this.dtpIssue.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(473, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 20);
            this.label7.TabIndex = 50;
            this.label7.Text = "Cheque Date";
            // 
            // txtCheq_no
            // 
            this.txtCheq_no.Location = new System.Drawing.Point(608, 222);
            this.txtCheq_no.Name = "txtCheq_no";
            this.txtCheq_no.Size = new System.Drawing.Size(199, 26);
            this.txtCheq_no.TabIndex = 7;
            // 
            // txtReference
            // 
            this.txtReference.Location = new System.Drawing.Point(608, 255);
            this.txtReference.Name = "txtReference";
            this.txtReference.Size = new System.Drawing.Size(199, 26);
            this.txtReference.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(473, 258);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 20);
            this.label9.TabIndex = 52;
            this.label9.Text = "Reference";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numDist
            // 
            this.numDist.Location = new System.Drawing.Point(213, 256);
            this.numDist.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numDist.Name = "numDist";
            this.numDist.Size = new System.Drawing.Size(100, 26);
            this.numDist.TabIndex = 5;
            this.numDist.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numDist.ThousandsSeparator = true;
            this.numDist.ValueChanged += new System.EventHandler(this.numDist_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(100, 258);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 20);
            this.label11.TabIndex = 54;
            this.label11.Text = "Discount";
            // 
            // frmSupplierTran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 711);
            this.Controls.Add(this.numDist);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtReference);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCheq_no);
            this.Controls.Add(this.dtpIssue);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtAccno);
            this.Controls.Add(this.numBalance);
            this.Controls.Add(this.cmbBank);
            this.Controls.Add(this.cmbSup);
            this.Controls.Add(this.numAmount);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvData);
            this.Name = "frmSupplierTran";
            this.Text = "Supplier Log";
            this.Load += new System.EventHandler(this.frmSupplierLog_Load);
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
            this.Controls.SetChildIndex(this.dtpDate, 0);
            this.Controls.SetChildIndex(this.numAmount, 0);
            this.Controls.SetChildIndex(this.cmbSup, 0);
            this.Controls.SetChildIndex(this.cmbBank, 0);
            this.Controls.SetChildIndex(this.numBalance, 0);
            this.Controls.SetChildIndex(this.txtAccno, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.dtpIssue, 0);
            this.Controls.SetChildIndex(this.txtCheq_no, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.txtReference, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.numDist, 0);
            this.gbSrh.ResumeLayout(false);
            this.gbSrh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.NumericUpDown numAmount;
        private System.Windows.Forms.ComboBox cmbSup;
        private System.Windows.Forms.ComboBox cmbBank;
        private System.Windows.Forms.NumericUpDown numBalance;
        private System.Windows.Forms.TextBox txtAccno;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpIssue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCheq_no;
        private System.Windows.Forms.TextBox txtReference;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numDist;
        private System.Windows.Forms.Label label11;
    }
}