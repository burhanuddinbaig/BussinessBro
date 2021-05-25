namespace prjGrow.Accounts
{
    partial class frmExpense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExpense));
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtRef = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.gbOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAmt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBalance)).BeginInit();
            this.pnlBank.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBankBal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHead
            // 
            this.lblHead.Location = new System.Drawing.Point(51, 7);
            // 
            // lblMsg
            // 
            this.lblMsg.Location = new System.Drawing.Point(228, 93);
            // 
            // btnSaveUpd
            // 
            this.btnSaveUpd.Click += new System.EventHandler(this.btnSaveUpd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(206, 239);
            // 
            // numAmt
            // 
            this.numAmt.Location = new System.Drawing.Point(206, 204);
            this.numAmt.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(91, 136);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(91, 206);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(91, 242);
            // 
            // cmbAccName
            // 
            this.cmbAccName.Size = new System.Drawing.Size(200, 28);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(91, 171);
            this.label6.Size = new System.Drawing.Size(109, 20);
            this.label6.Text = "Expense Type";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(863, 197);
            this.label4.Visible = false;
            // 
            // numBalance
            // 
            this.numBalance.Location = new System.Drawing.Point(850, 191);
            this.numBalance.Visible = false;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(331, 131);
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // cmbBank
            // 
            this.cmbBank.Size = new System.Drawing.Size(200, 28);
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AllowUserToOrderColumns = true;
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit,
            this.Delete});
            this.dgvData.Location = new System.Drawing.Point(55, 348);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(898, 335);
            this.dgvData.TabIndex = 25;
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
            // txtRef
            // 
            this.txtRef.Location = new System.Drawing.Point(206, 274);
            this.txtRef.Name = "txtRef";
            this.txtRef.Size = new System.Drawing.Size(200, 26);
            this.txtRef.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(91, 280);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 20);
            this.label10.TabIndex = 43;
            this.label10.Text = "Reference";
            // 
            // frmExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 711);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtRef);
            this.Controls.Add(this.dgvData);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Name = "frmExpense";
            this.Text = "Expense";
            this.Load += new System.EventHandler(this.frmExpense_Load);
            this.Controls.SetChildIndex(this.pnlBank, 0);
            this.Controls.SetChildIndex(this.btnAddNew, 0);
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
            this.Controls.SetChildIndex(this.lblMsg, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lblTitle, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnClear, 0);
            this.Controls.SetChildIndex(this.btnSaveUpd, 0);
            this.Controls.SetChildIndex(this.gbOptions, 0);
            this.Controls.SetChildIndex(this.lblHead, 0);
            this.Controls.SetChildIndex(this.dgvData, 0);
            this.Controls.SetChildIndex(this.txtRef, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.gbOptions.ResumeLayout(false);
            this.gbOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAmt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBalance)).EndInit();
            this.pnlBank.ResumeLayout(false);
            this.pnlBank.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBankBal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.TextBox txtRef;
        private System.Windows.Forms.Label label10;
    }
}