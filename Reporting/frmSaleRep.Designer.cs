namespace prjGrow.Reporting
{
    partial class frmSaleRep
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
            this.numYear.Enabled = false;
            this.numYear.Value = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            // 
            // cmbMonth
            // 
            this.cmbMonth.Enabled = false;
            this.cmbMonth.Size = new System.Drawing.Size(85, 26);
            // 
            // dtpDate
            // 
            this.dtpDate.Value = new System.DateTime(2020, 11, 30, 18, 31, 30, 590);
            // 
            // rbYear
            // 
            this.rbYear.Location = new System.Drawing.Point(331, 14);
            this.rbYear.TabStop = false;
            this.rbYear.Visible = false;
            // 
            // rbMonth
            // 
            this.rbMonth.Location = new System.Drawing.Point(41, 14);
            this.rbMonth.TabStop = false;
            // 
            // rbDaily
            // 
            this.rbDaily.Checked = true;
            this.rbDaily.Location = new System.Drawing.Point(181, 14);
            // 
            // rbAll
            // 
            this.rbAll.TabStop = false;
            // 
            // frmSaleRep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 301);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmSaleRep";
            this.Text = "Sale Report";
            this.Load += new System.EventHandler(this.frmSaleRep_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlDates.ResumeLayout(false);
            this.pnlDates.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}