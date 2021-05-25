namespace prjGrow.Reporting
{
    partial class frmSupLed
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
            this.cmbSup = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.pnlDates.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // numYear
            // 
            this.numYear.Location = new System.Drawing.Point(113, 3);
            this.numYear.Value = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            // 
            // cmbMonth
            // 
            this.cmbMonth.Location = new System.Drawing.Point(270, 2);
            this.cmbMonth.Size = new System.Drawing.Size(66, 26);
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(392, 3);
            this.dtpDate.Value = new System.DateTime(2020, 9, 15, 17, 24, 22, 191);
            this.dtpDate.Visible = false;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(69, 5);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(214, 5);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(400, 5);
            this.label4.Visible = false;
            // 
            // rbYear
            // 
            this.rbYear.Checked = true;
            // 
            // rbMonth
            // 
            this.rbMonth.Location = new System.Drawing.Point(164, 14);
            this.rbMonth.TabStop = false;
            // 
            // rbDaily
            // 
            this.rbDaily.Location = new System.Drawing.Point(403, 14);
            this.rbDaily.TabStop = false;
            this.rbDaily.Visible = false;
            // 
            // rbAll
            // 
            this.rbAll.Location = new System.Drawing.Point(296, 14);
            this.rbAll.TabStop = false;
            this.rbAll.Visible = true;
            // 
            // cmbSup
            // 
            this.cmbSup.FormattingEnabled = true;
            this.cmbSup.Location = new System.Drawing.Point(186, 162);
            this.cmbSup.Name = "cmbSup";
            this.cmbSup.Size = new System.Drawing.Size(200, 26);
            this.cmbSup.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(119, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 18);
            this.label5.TabIndex = 106;
            this.label5.Text = "Supplier";
            // 
            // frmSupLed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 300);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbSup);
            this.Name = "frmSupLed";
            this.Text = "Supplier Ledger";
            this.Load += new System.EventHandler(this.frmSupLed_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lblMsg, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnGenerate, 0);
            this.Controls.SetChildIndex(this.lblTitle, 0);
            this.Controls.SetChildIndex(this.lblClient, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.pnlDates, 0);
            this.Controls.SetChildIndex(this.cmbSup, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlDates.ResumeLayout(false);
            this.pnlDates.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSup;
        private System.Windows.Forms.Label label5;
    }
}