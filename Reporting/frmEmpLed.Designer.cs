namespace prjGrow.Reporting
{
    partial class frmEmpLed
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
            this.cmbEmp = new System.Windows.Forms.ComboBox();
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
            this.numYear.Location = new System.Drawing.Point(94, 5);
            this.numYear.Value = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            // 
            // cmbMonth
            // 
            this.cmbMonth.Location = new System.Drawing.Point(273, 4);
            this.cmbMonth.Size = new System.Drawing.Size(66, 26);
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(441, 2);
            this.dtpDate.Size = new System.Drawing.Size(41, 24);
            this.dtpDate.Value = new System.DateTime(2020, 8, 28, 16, 27, 4, 843);
            this.dtpDate.Visible = false;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(50, 7);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(217, 7);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(396, 5);
            this.label4.Visible = false;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // rbYear
            // 
            this.rbYear.Location = new System.Drawing.Point(52, 14);
            // 
            // rbMonth
            // 
            this.rbMonth.Location = new System.Drawing.Point(161, 14);
            // 
            // rbDaily
            // 
            this.rbDaily.Location = new System.Drawing.Point(399, 14);
            this.rbDaily.Visible = false;
            // 
            // rbAll
            // 
            this.rbAll.Location = new System.Drawing.Point(270, 14);
            this.rbAll.Visible = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(109, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 18);
            this.label5.TabIndex = 108;
            this.label5.Text = "Employee:";
            // 
            // cmbEmp
            // 
            this.cmbEmp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbEmp.FormattingEnabled = true;
            this.cmbEmp.Location = new System.Drawing.Point(186, 177);
            this.cmbEmp.Name = "cmbEmp";
            this.cmbEmp.Size = new System.Drawing.Size(200, 26);
            this.cmbEmp.TabIndex = 107;
            // 
            // frmEmpLed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 300);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbEmp);
            this.Name = "frmEmpLed";
            this.Text = "Employee Ledger";
            this.Load += new System.EventHandler(this.frmEmpLed_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lblMsg, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnGenerate, 0);
            this.Controls.SetChildIndex(this.lblTitle, 0);
            this.Controls.SetChildIndex(this.lblClient, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.pnlDates, 0);
            this.Controls.SetChildIndex(this.cmbEmp, 0);
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

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbEmp;
    }
}