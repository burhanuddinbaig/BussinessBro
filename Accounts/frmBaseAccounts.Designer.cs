namespace prjGrow.Accounts
{
    partial class frmBaseAccounts
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
            this.components = new System.ComponentModel.Container();
            this.lblHead = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSaveUpd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.gbOptions = new System.Windows.Forms.GroupBox();
            this.chkCheq = new System.Windows.Forms.CheckBox();
            this.chkBank = new System.Windows.Forms.CheckBox();
            this.tmrMsg = new System.Windows.Forms.Timer(this.components);
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.numAmt = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbAccName = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numBalance = new System.Windows.Forms.NumericUpDown();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.pnlBank = new System.Windows.Forms.Panel();
            this.cmbBank = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBankAccno = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAddBank = new System.Windows.Forms.Button();
            this.numBankBal = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.gbOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAmt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBalance)).BeginInit();
            this.pnlBank.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBankBal)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHead
            // 
            this.lblHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHead.ForeColor = System.Drawing.Color.White;
            this.lblHead.Location = new System.Drawing.Point(60, 9);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(903, 40);
            this.lblHead.TabIndex = 28;
            this.lblHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(60, 52);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(903, 40);
            this.lblTitle.TabIndex = 26;
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(50, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(900, 2);
            this.label1.TabIndex = 25;
            // 
            // lblMsg
            // 
            this.lblMsg.BackColor = System.Drawing.Color.Transparent;
            this.lblMsg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.Location = new System.Drawing.Point(238, 95);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(467, 24);
            this.lblMsg.TabIndex = 27;
            this.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(810, 312);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 30);
            this.btnClose.TabIndex = 23;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSaveUpd
            // 
            this.btnSaveUpd.Location = new System.Drawing.Point(558, 312);
            this.btnSaveUpd.Name = "btnSaveUpd";
            this.btnSaveUpd.Size = new System.Drawing.Size(120, 30);
            this.btnSaveUpd.TabIndex = 21;
            this.btnSaveUpd.Text = "&Save";
            this.btnSaveUpd.UseVisualStyleBackColor = true;
            this.btnSaveUpd.Click += new System.EventHandler(this.btnSaveUpd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(684, 312);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 30);
            this.btnClear.TabIndex = 22;
            this.btnClear.Text = "Clea&r";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // gbOptions
            // 
            this.gbOptions.Controls.Add(this.chkCheq);
            this.gbOptions.Controls.Add(this.chkBank);
            this.gbOptions.ForeColor = System.Drawing.Color.White;
            this.gbOptions.Location = new System.Drawing.Point(810, 120);
            this.gbOptions.Name = "gbOptions";
            this.gbOptions.Size = new System.Drawing.Size(140, 54);
            this.gbOptions.TabIndex = 10;
            this.gbOptions.TabStop = false;
            this.gbOptions.Text = "Options";
            this.gbOptions.Visible = false;
            // 
            // chkCheq
            // 
            this.chkCheq.AutoSize = true;
            this.chkCheq.Location = new System.Drawing.Point(6, 25);
            this.chkCheq.Name = "chkCheq";
            this.chkCheq.Size = new System.Drawing.Size(125, 24);
            this.chkCheq.TabIndex = 1;
            this.chkCheq.Text = "&Bank Cheque";
            this.chkCheq.UseVisualStyleBackColor = true;
            this.chkCheq.CheckedChanged += new System.EventHandler(this.chkCheq_CheckedChanged);
            // 
            // chkBank
            // 
            this.chkBank.AutoSize = true;
            this.chkBank.Location = new System.Drawing.Point(6, 55);
            this.chkBank.Name = "chkBank";
            this.chkBank.Size = new System.Drawing.Size(128, 24);
            this.chkBank.TabIndex = 0;
            this.chkBank.Text = "&Bank Transfer";
            this.chkBank.UseVisualStyleBackColor = true;
            this.chkBank.CheckedChanged += new System.EventHandler(this.chkBank_CheckedChanged);
            // 
            // tmrMsg
            // 
            this.tmrMsg.Interval = 4000;
            this.tmrMsg.Tick += new System.EventHandler(this.tmrMsg_Tick);
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(206, 131);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(100, 26);
            this.dtpDate.TabIndex = 1;
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(206, 274);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(200, 26);
            this.txtRemarks.TabIndex = 6;
            // 
            // numAmt
            // 
            this.numAmt.Location = new System.Drawing.Point(206, 239);
            this.numAmt.Name = "numAmt";
            this.numAmt.Size = new System.Drawing.Size(100, 26);
            this.numAmt.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(100, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(100, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(98, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 37;
            this.label5.Text = "Remarks";
            // 
            // cmbAccName
            // 
            this.cmbAccName.FormattingEnabled = true;
            this.cmbAccName.Location = new System.Drawing.Point(206, 166);
            this.cmbAccName.Name = "cmbAccName";
            this.cmbAccName.Size = new System.Drawing.Size(200, 28);
            this.cmbAccName.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(100, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 20);
            this.label6.TabIndex = 39;
            this.label6.Text = "Bank Name";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(99, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 41;
            this.label4.Text = "Balance";
            // 
            // numBalance
            // 
            this.numBalance.Enabled = false;
            this.numBalance.Location = new System.Drawing.Point(206, 204);
            this.numBalance.Name = "numBalance";
            this.numBalance.ReadOnly = true;
            this.numBalance.Size = new System.Drawing.Size(100, 26);
            this.numBalance.TabIndex = 5;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.Location = new System.Drawing.Point(331, 204);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 26);
            this.btnAddNew.TabIndex = 3;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            // 
            // pnlBank
            // 
            this.pnlBank.Controls.Add(this.cmbBank);
            this.pnlBank.Controls.Add(this.label9);
            this.pnlBank.Controls.Add(this.txtBankAccno);
            this.pnlBank.Controls.Add(this.label8);
            this.pnlBank.Controls.Add(this.btnAddBank);
            this.pnlBank.Controls.Add(this.numBankBal);
            this.pnlBank.Controls.Add(this.label7);
            this.pnlBank.Location = new System.Drawing.Point(440, 118);
            this.pnlBank.Name = "pnlBank";
            this.pnlBank.Size = new System.Drawing.Size(345, 112);
            this.pnlBank.TabIndex = 10;
            this.pnlBank.Visible = false;
            this.pnlBank.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBank_Paint);
            // 
            // cmbBank
            // 
            this.cmbBank.FormattingEnabled = true;
            this.cmbBank.Location = new System.Drawing.Point(123, 11);
            this.cmbBank.Name = "cmbBank";
            this.cmbBank.Size = new System.Drawing.Size(200, 28);
            this.cmbBank.TabIndex = 1;
            this.cmbBank.SelectedValueChanged += new System.EventHandler(this.cmbBank_SelectedValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(14, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 20);
            this.label9.TabIndex = 48;
            this.label9.Text = "Bank Account";
            // 
            // txtBankAccno
            // 
            this.txtBankAccno.Location = new System.Drawing.Point(123, 82);
            this.txtBankAccno.Name = "txtBankAccno";
            this.txtBankAccno.ReadOnly = true;
            this.txtBankAccno.Size = new System.Drawing.Size(200, 26);
            this.txtBankAccno.TabIndex = 47;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(14, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 20);
            this.label8.TabIndex = 45;
            this.label8.Text = "Bank Name";
            // 
            // btnAddBank
            // 
            this.btnAddBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBank.Location = new System.Drawing.Point(248, 49);
            this.btnAddBank.Name = "btnAddBank";
            this.btnAddBank.Size = new System.Drawing.Size(75, 23);
            this.btnAddBank.TabIndex = 2;
            this.btnAddBank.Text = "Add New";
            this.btnAddBank.UseVisualStyleBackColor = true;
            // 
            // numBankBal
            // 
            this.numBankBal.Enabled = false;
            this.numBankBal.Location = new System.Drawing.Point(123, 47);
            this.numBankBal.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numBankBal.Minimum = new decimal(new int[] {
            9999999,
            0,
            0,
            -2147483648});
            this.numBankBal.Name = "numBankBal";
            this.numBankBal.ReadOnly = true;
            this.numBankBal.Size = new System.Drawing.Size(100, 26);
            this.numBankBal.TabIndex = 44;
            this.numBankBal.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(14, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 46;
            this.label7.Text = "Balance";
            this.label7.Visible = false;
            // 
            // frmBaseAccounts
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1004, 711);
            this.Controls.Add(this.pnlBank);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numBalance);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbAccName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numAmt);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.gbOptions);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSaveUpd);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblHead);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMsg);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Name = "frmBaseAccounts";
            this.Text = "frmBaseAccounts";
            this.Load += new System.EventHandler(this.frmBaseAccounts_Load);
            this.gbOptions.ResumeLayout(false);
            this.gbOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAmt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBalance)).EndInit();
            this.pnlBank.ResumeLayout(false);
            this.pnlBank.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBankBal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblHead;
        public System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblMsg;
        public System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.Button btnSaveUpd;
        public System.Windows.Forms.Button btnClear;
        public System.Windows.Forms.GroupBox gbOptions;
        public System.Windows.Forms.Timer tmrMsg;
        public System.Windows.Forms.DateTimePicker dtpDate;
        public System.Windows.Forms.TextBox txtRemarks;
        public System.Windows.Forms.NumericUpDown numAmt;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox cmbAccName;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.NumericUpDown numBalance;
        public System.Windows.Forms.Button btnAddNew;
        public System.Windows.Forms.Panel pnlBank;
        public System.Windows.Forms.CheckBox chkBank;
        public System.Windows.Forms.CheckBox chkCheq;
        public System.Windows.Forms.ComboBox cmbBank;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtBankAccno;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Button btnAddBank;
        public System.Windows.Forms.NumericUpDown numBankBal;
        public System.Windows.Forms.Label label7;
    }
}