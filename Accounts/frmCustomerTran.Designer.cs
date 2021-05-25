namespace prjGrow.Accounts
{
    partial class frmCustomerTran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomerTran));
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.pnlBnk = new System.Windows.Forms.Panel();
            this.dtpCheqDate = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCheq = new System.Windows.Forms.TextBox();
            this.txtBankName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvDataCus = new System.Windows.Forms.DataGridView();
            this.Update = new System.Windows.Forms.DataGridViewImageColumn();
            this.Del = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnInvoice = new System.Windows.Forms.Button();
            this.gbOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAmt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBalance)).BeginInit();
            this.pnlBank.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBankBal)).BeginInit();
            this.pnlBnk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataCus)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMsg
            // 
            this.lblMsg.Location = new System.Drawing.Point(228, 95);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(805, 314);
            // 
            // btnSaveUpd
            // 
            this.btnSaveUpd.Location = new System.Drawing.Point(553, 314);
            this.btnSaveUpd.Click += new System.EventHandler(this.btnSaveUpd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(679, 314);
            // 
            // gbOptions
            // 
            this.gbOptions.Location = new System.Drawing.Point(828, 122);
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(221, 135);
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(221, 265);
            // 
            // numAmt
            // 
            this.numAmt.Location = new System.Drawing.Point(221, 233);
            this.numAmt.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(82, 140);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(82, 235);
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.Text = "Received Amount";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(82, 265);
            // 
            // cmbAccName
            // 
            this.cmbAccName.Location = new System.Drawing.Point(221, 167);
            this.cmbAccName.Size = new System.Drawing.Size(200, 28);
            this.cmbAccName.SelectedValueChanged += new System.EventHandler(this.cmbAccName_SelectedValueChanged);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(82, 170);
            this.label6.Size = new System.Drawing.Size(124, 20);
            this.label6.Text = "Customer Name";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(82, 203);
            // 
            // numBalance
            // 
            this.numBalance.Location = new System.Drawing.Point(221, 201);
            this.numBalance.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numBalance.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(346, 201);
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // pnlBank
            // 
            this.pnlBank.Location = new System.Drawing.Point(440, 198);
            this.pnlBank.Size = new System.Drawing.Size(359, 103);
            // 
            // chkCheq
            // 
            this.chkCheq.CheckedChanged += new System.EventHandler(this.chkCheq_CheckedChanged);
            // 
            // cmbBank
            // 
            this.cmbBank.Location = new System.Drawing.Point(128, 6);
            this.cmbBank.Size = new System.Drawing.Size(200, 28);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(19, 73);
            // 
            // txtBankAccno
            // 
            this.txtBankAccno.Location = new System.Drawing.Point(128, 71);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(19, 9);
            // 
            // btnAddBank
            // 
            this.btnAddBank.Location = new System.Drawing.Point(253, 42);
            // 
            // numBankBal
            // 
            this.numBankBal.Location = new System.Drawing.Point(128, 40);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(19, 41);
            // 
            // Edit
            // 
            this.Edit.FillWeight = 40F;
            this.Edit.HeaderText = "Edit";
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            // 
            // Delete
            // 
            this.Delete.FillWeight = 40F;
            this.Delete.HeaderText = "Delete";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            // 
            // pnlBnk
            // 
            this.pnlBnk.Controls.Add(this.dtpCheqDate);
            this.pnlBnk.Controls.Add(this.label14);
            this.pnlBnk.Controls.Add(this.txtCheq);
            this.pnlBnk.Controls.Add(this.txtBankName);
            this.pnlBnk.Controls.Add(this.label13);
            this.pnlBnk.Controls.Add(this.label12);
            this.pnlBnk.Location = new System.Drawing.Point(440, 133);
            this.pnlBnk.Name = "pnlBnk";
            this.pnlBnk.Size = new System.Drawing.Size(359, 105);
            this.pnlBnk.TabIndex = 44;
            this.pnlBnk.Visible = false;
            // 
            // dtpCheqDate
            // 
            this.dtpCheqDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCheqDate.Location = new System.Drawing.Point(122, 69);
            this.dtpCheqDate.Name = "dtpCheqDate";
            this.dtpCheqDate.Size = new System.Drawing.Size(118, 26);
            this.dtpCheqDate.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Location = new System.Drawing.Point(15, 71);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 20);
            this.label14.TabIndex = 4;
            this.label14.Text = "Issue Date";
            // 
            // txtCheq
            // 
            this.txtCheq.Location = new System.Drawing.Point(122, 34);
            this.txtCheq.Name = "txtCheq";
            this.txtCheq.Size = new System.Drawing.Size(200, 26);
            this.txtCheq.TabIndex = 3;
            // 
            // txtBankName
            // 
            this.txtBankName.Location = new System.Drawing.Point(122, 2);
            this.txtBankName.Name = "txtBankName";
            this.txtBankName.Size = new System.Drawing.Size(200, 26);
            this.txtBankName.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(15, 37);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 20);
            this.label13.TabIndex = 1;
            this.label13.Text = "Cheque No";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(15, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Bank Name";
            // 
            // dgvDataCus
            // 
            this.dgvDataCus.AllowUserToAddRows = false;
            this.dgvDataCus.AllowUserToDeleteRows = false;
            this.dgvDataCus.AllowUserToResizeRows = false;
            this.dgvDataCus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDataCus.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvDataCus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataCus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Update,
            this.Del});
            this.dgvDataCus.Location = new System.Drawing.Point(50, 350);
            this.dgvDataCus.Name = "dgvDataCus";
            this.dgvDataCus.Size = new System.Drawing.Size(900, 332);
            this.dgvDataCus.TabIndex = 45;
            this.dgvDataCus.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDataCus_CellClick);
            // 
            // Update
            // 
            this.Update.FillWeight = 50F;
            this.Update.HeaderText = "Update";
            this.Update.Image = ((System.Drawing.Image)(resources.GetObject("Update.Image")));
            this.Update.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Update.Name = "Update";
            this.Update.ReadOnly = true;
            // 
            // Del
            // 
            this.Del.FillWeight = 50F;
            this.Del.HeaderText = "Del";
            this.Del.Image = ((System.Drawing.Image)(resources.GetObject("Del.Image")));
            this.Del.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Del.Name = "Del";
            this.Del.ReadOnly = true;
            // 
            // btnInvoice
            // 
            this.btnInvoice.Location = new System.Drawing.Point(86, 314);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Size = new System.Drawing.Size(141, 30);
            this.btnInvoice.TabIndex = 46;
            this.btnInvoice.Text = "Invoices";
            this.btnInvoice.UseVisualStyleBackColor = true;
            this.btnInvoice.Click += new System.EventHandler(this.btnInvoice_Click);
            // 
            // frmCustomerTran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 711);
            this.Controls.Add(this.btnInvoice);
            this.Controls.Add(this.dgvDataCus);
            this.Controls.Add(this.pnlBnk);
            this.Name = "frmCustomerTran";
            this.Text = "Customer Transactions";
            this.Load += new System.EventHandler(this.frmCustomerTran_Load);
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
            this.Controls.SetChildIndex(this.pnlBnk, 0);
            this.Controls.SetChildIndex(this.dgvDataCus, 0);
            this.Controls.SetChildIndex(this.btnInvoice, 0);
            this.gbOptions.ResumeLayout(false);
            this.gbOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAmt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBalance)).EndInit();
            this.pnlBank.ResumeLayout(false);
            this.pnlBank.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBankBal)).EndInit();
            this.pnlBnk.ResumeLayout(false);
            this.pnlBnk.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataCus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

     //   private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.Panel pnlBnk;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCheq;
        private System.Windows.Forms.TextBox txtBankName;
        private System.Windows.Forms.DateTimePicker dtpCheqDate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dgvDataCus;
        private System.Windows.Forms.DataGridViewImageColumn Update;
        private System.Windows.Forms.DataGridViewImageColumn Del;
        private System.Windows.Forms.Button btnInvoice;
    }
}