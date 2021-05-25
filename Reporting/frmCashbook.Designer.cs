namespace prjGrow.Reports
{
    partial class frmCashbook
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
            this.SuspendLayout();
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
            this.cmbMonth.Size = new System.Drawing.Size(85, 26);
            // 
            // dtpDate
            // 
            this.dtpDate.Value = new System.DateTime(2020, 8, 17, 22, 42, 12, 321);
            // 
            // rbYear
            // 
            this.rbYear.Location = new System.Drawing.Point(331, 14);
            this.rbYear.Visible = false;
            // 
            // rbMonth
            // 
            this.rbMonth.Location = new System.Drawing.Point(41, 14);
            // 
            // rbDaily
            // 
            this.rbDaily.Location = new System.Drawing.Point(194, 14);
            // 
            // frmCashbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 321);
            this.Name = "frmCashbook";
            this.Text = "Cash Book";
            this.Load += new System.EventHandler(this.frmCashbook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}