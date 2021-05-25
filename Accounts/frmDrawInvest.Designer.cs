namespace prjGrow.Accounts
{
    partial class frmDrawInvest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDrawInvest));
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.numInvest = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.gbOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAmt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBankBal)).BeginInit();
            this.pnlBank.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInvest)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSaveUpd
            // 
            this.btnSaveUpd.Click += new System.EventHandler(this.btnSaveUpd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // gbOptions
            // 
            this.gbOptions.Size = new System.Drawing.Size(122, 70);
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(206, 240);
            // 
            // numAmt
            // 
            this.numAmt.Location = new System.Drawing.Point(206, 204);
            this.numAmt.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numAmt.TabIndex = 5;
            this.numAmt.ThousandsSeparator = true;
            this.numAmt.ValueChanged += new System.EventHandler(this.numAmt_ValueChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(100, 206);
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.Text = "Drawing";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(100, 243);
            // 
            // cmbAccName
            // 
            this.cmbAccName.Location = new System.Drawing.Point(578, 248);
            this.cmbAccName.Size = new System.Drawing.Size(200, 28);
            this.cmbAccName.Visible = false;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(469, 256);
            this.label6.Visible = false;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(469, 285);
            this.label4.Visible = false;
            // 
            // numBalance
            // 
            this.numBalance.Location = new System.Drawing.Point(578, 280);
            this.numBalance.Visible = false;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(697, 282);
            this.btnAddNew.Visible = false;
            // 
            // label7
            // 
            this.label7.Visible = true;
            // 
            // numBankBal
            // 
            this.numBankBal.Visible = true;
            // 
            // pnlBank
            // 
            this.pnlBank.Size = new System.Drawing.Size(362, 120);
            // 
            // cmbBank
            // 
            this.cmbBank.Size = new System.Drawing.Size(200, 28);
            this.cmbBank.TextChanged += new System.EventHandler(this.cmbBank_TextChanged);
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
            this.dgvData.Location = new System.Drawing.Point(50, 348);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.Size = new System.Drawing.Size(900, 338);
            this.dgvData.TabIndex = 42;
            this.dgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
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
            // numInvest
            // 
            this.numInvest.Location = new System.Drawing.Point(206, 168);
            this.numInvest.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numInvest.Name = "numInvest";
            this.numInvest.Size = new System.Drawing.Size(100, 26);
            this.numInvest.TabIndex = 4;
            this.numInvest.ThousandsSeparator = true;
            this.numInvest.ValueChanged += new System.EventHandler(this.numInvest_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(100, 170);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 20);
            this.label10.TabIndex = 51;
            this.label10.Text = "Investment";
            // 
            // frmDrawInvest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 711);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.numInvest);
            this.Controls.Add(this.dgvData);
            this.Name = "frmDrawInvest";
            this.Text = "Drawing and Investment";
            this.Load += new System.EventHandler(this.frmDrawInvest_Load);
            this.Controls.SetChildIndex(this.pnlBank, 0);
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
            this.Controls.SetChildIndex(this.dgvData, 0);
            this.Controls.SetChildIndex(this.numInvest, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.gbOptions.ResumeLayout(false);
            this.gbOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAmt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBankBal)).EndInit();
            this.pnlBank.ResumeLayout(false);
            this.pnlBank.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInvest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.NumericUpDown numInvest;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}