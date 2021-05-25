namespace prjGrow.Reporting
{
    partial class frmJournal
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
            // lblMsg
            // 
            this.lblMsg.Location = new System.Drawing.Point(2, 51);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // numYear
            // 
            this.numYear.Value = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            // 
            // cmbMonth
            // 
            this.cmbMonth.Size = new System.Drawing.Size(66, 26);
            // 
            // dtpDate
            // 
            this.dtpDate.Value = new System.DateTime(2020, 8, 19, 23, 34, 2, 276);
            // 
            // rbYear
            // 
            this.rbYear.Location = new System.Drawing.Point(42, 16);
            // 
            // rbMonth
            // 
            this.rbMonth.Location = new System.Drawing.Point(185, 16);
            // 
            // rbDaily
            // 
            this.rbDaily.Location = new System.Drawing.Point(332, 16);
            // 
            // rbAll
            // 
            this.rbAll.Location = new System.Drawing.Point(406, 16);
            // 
            // frmJournal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 300);
            this.Name = "frmJournal";
            this.Text = "General Journal";
            this.Load += new System.EventHandler(this.frmJournal_Load);
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