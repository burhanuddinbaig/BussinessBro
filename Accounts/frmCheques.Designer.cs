namespace prjGrow.Accounts
{
    partial class frmCheques
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
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.Cash = new System.Windows.Forms.DataGridViewImageColumn();
            this.rbPayCheq = new System.Windows.Forms.RadioButton();
            this.rbReciveCheq = new System.Windows.Forms.RadioButton();
            this.rbProcessed = new System.Windows.Forms.RadioButton();
            this.rbPending = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gbSrh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(58, 183);
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(55, 50);
            // 
            // lblMsg
            // 
            this.lblMsg.Location = new System.Drawing.Point(273, 90);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(831, 85);
            this.btnClose.Visible = false;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(831, 85);
            this.btnClear.Visible = false;
            // 
            // btnSaveUpd
            // 
            this.btnSaveUpd.Location = new System.Drawing.Point(838, 85);
            this.btnSaveUpd.Visible = false;
            // 
            // gbSrh
            // 
            this.gbSrh.Location = new System.Drawing.Point(810, 88);
            this.gbSrh.Size = new System.Drawing.Size(148, 24);
            this.gbSrh.Visible = false;
            // 
            // lblClient
            // 
            this.lblClient.Location = new System.Drawing.Point(55, 7);
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cash});
            this.dgvData.Location = new System.Drawing.Point(58, 188);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(900, 345);
            this.dgvData.TabIndex = 25;
            // 
            // Cash
            // 
            this.Cash.FillWeight = 50F;
            this.Cash.HeaderText = "Cash";
            this.Cash.Name = "Cash";
            this.Cash.ReadOnly = true;
            // 
            // rbPayCheq
            // 
            this.rbPayCheq.AutoSize = true;
            this.rbPayCheq.Checked = true;
            this.rbPayCheq.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbPayCheq.Location = new System.Drawing.Point(3, 1);
            this.rbPayCheq.Name = "rbPayCheq";
            this.rbPayCheq.Size = new System.Drawing.Size(157, 24);
            this.rbPayCheq.TabIndex = 26;
            this.rbPayCheq.TabStop = true;
            this.rbPayCheq.Text = "Payment Cheques";
            this.rbPayCheq.UseVisualStyleBackColor = true;
            // 
            // rbReciveCheq
            // 
            this.rbReciveCheq.AutoSize = true;
            this.rbReciveCheq.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbReciveCheq.Location = new System.Drawing.Point(200, 1);
            this.rbReciveCheq.Name = "rbReciveCheq";
            this.rbReciveCheq.Size = new System.Drawing.Size(164, 24);
            this.rbReciveCheq.TabIndex = 27;
            this.rbReciveCheq.TabStop = true;
            this.rbReciveCheq.Text = "Recieving Cheques";
            this.rbReciveCheq.UseVisualStyleBackColor = true;
            this.rbReciveCheq.Visible = false;
            // 
            // rbProcessed
            // 
            this.rbProcessed.AutoSize = true;
            this.rbProcessed.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbProcessed.Location = new System.Drawing.Point(200, 3);
            this.rbProcessed.Name = "rbProcessed";
            this.rbProcessed.Size = new System.Drawing.Size(102, 24);
            this.rbProcessed.TabIndex = 29;
            this.rbProcessed.TabStop = true;
            this.rbProcessed.Text = "Processed";
            this.rbProcessed.UseVisualStyleBackColor = true;
            // 
            // rbPending
            // 
            this.rbPending.AutoSize = true;
            this.rbPending.Checked = true;
            this.rbPending.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbPending.Location = new System.Drawing.Point(3, 3);
            this.rbPending.Name = "rbPending";
            this.rbPending.Size = new System.Drawing.Size(85, 24);
            this.rbPending.TabIndex = 28;
            this.rbPending.TabStop = true;
            this.rbPending.Text = "Pending";
            this.rbPending.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbPayCheq);
            this.panel1.Controls.Add(this.rbReciveCheq);
            this.panel1.Location = new System.Drawing.Point(100, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 26);
            this.panel1.TabIndex = 30;
            this.panel1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.rbPending);
            this.panel2.Controls.Add(this.rbProcessed);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Location = new System.Drawing.Point(100, 147);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(366, 33);
            this.panel2.TabIndex = 31;
            // 
            // frmCheques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 561);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvData);
            this.Name = "frmCheques";
            this.Text = "Cheques";
            this.Load += new System.EventHandler(this.frmChequeHis_Load);
            this.Controls.SetChildIndex(this.lblMsg, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lblTitle, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnClear, 0);
            this.Controls.SetChildIndex(this.btnSaveUpd, 0);
            this.Controls.SetChildIndex(this.gbSrh, 0);
            this.Controls.SetChildIndex(this.lblClient, 0);
            this.Controls.SetChildIndex(this.dgvData, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.gbSrh.ResumeLayout(false);
            this.gbSrh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.RadioButton rbPayCheq;
        private System.Windows.Forms.RadioButton rbReciveCheq;
        private System.Windows.Forms.DataGridViewImageColumn Cash;
        private System.Windows.Forms.RadioButton rbProcessed;
        private System.Windows.Forms.RadioButton rbPending;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;

    }
}