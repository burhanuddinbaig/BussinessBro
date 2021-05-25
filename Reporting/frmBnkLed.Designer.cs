namespace prjGrow.Reporting
{
    partial class frmBnkLed
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
            this.label5 = new System.Windows.Forms.Label();
            this.cmbBank = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.pnlDates.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(50, 226);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(286, 231);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(141, 231);
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // numYear
            // 
            this.numYear.Location = new System.Drawing.Point(90, 4);
            this.numYear.Value = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            // 
            // cmbMonth
            // 
            this.cmbMonth.Location = new System.Drawing.Point(267, 3);
            this.cmbMonth.Size = new System.Drawing.Size(66, 26);
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(371, 2);
            this.dtpDate.Value = new System.DateTime(2020, 8, 26, 13, 31, 20, 4);
            this.dtpDate.Visible = false;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(42, 7);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(205, 6);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(372, 5);
            this.label4.Visible = false;
            // 
            // rbYear
            // 
            this.rbYear.Checked = true;
            this.rbYear.Location = new System.Drawing.Point(45, 14);
            // 
            // rbMonth
            // 
            this.rbMonth.Location = new System.Drawing.Point(168, 14);
            this.rbMonth.TabStop = false;
            // 
            // rbDaily
            // 
            this.rbDaily.Location = new System.Drawing.Point(389, 14);
            this.rbDaily.TabStop = false;
            this.rbDaily.Visible = false;
            // 
            // rbAll
            // 
            this.rbAll.Location = new System.Drawing.Point(295, 14);
            this.rbAll.TabStop = false;
            this.rbAll.Visible = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(92, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 18);
            this.label5.TabIndex = 105;
            this.label5.Text = "Bank Name";
            // 
            // cmbBank
            // 
            this.cmbBank.FormattingEnabled = true;
            this.cmbBank.Location = new System.Drawing.Point(184, 167);
            this.cmbBank.Name = "cmbBank";
            this.cmbBank.Size = new System.Drawing.Size(200, 26);
            this.cmbBank.TabIndex = 0;
            // 
            // frmBnkLed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 300);
            this.Controls.Add(this.cmbBank);
            this.Controls.Add(this.label5);
            this.Name = "frmBnkLed";
            this.Text = "Bank Ledger";
            this.Load += new System.EventHandler(this.frmBnkLed_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lblMsg, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnGenerate, 0);
            this.Controls.SetChildIndex(this.lblTitle, 0);
            this.Controls.SetChildIndex(this.lblClient, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.pnlDates, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.cmbBank, 0);
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlDates.ResumeLayout(false);
            this.pnlDates.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbBank;
    }
}