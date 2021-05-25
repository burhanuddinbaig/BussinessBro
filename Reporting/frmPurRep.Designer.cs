namespace prjGrow.Reporting
{
    partial class frmPurRep
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
            this.numYear.Location = new System.Drawing.Point(49, 2);
            this.numYear.Value = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            // 
            // cmbMonth
            // 
            this.cmbMonth.Enabled = false;
            this.cmbMonth.Location = new System.Drawing.Point(206, 1);
            this.cmbMonth.Size = new System.Drawing.Size(66, 26);
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(329, 2);
            this.dtpDate.Value = new System.DateTime(2021, 2, 6, 10, 33, 3, 770);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(5, 5);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(150, 5);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(288, 5);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(78, 77);
            this.groupBox1.Size = new System.Drawing.Size(407, 44);
            // 
            // rbYear
            // 
            this.rbYear.TabStop = false;
            // 
            // rbMonth
            // 
            this.rbMonth.Checked = true;
            // 
            // rbDaily
            // 
            this.rbDaily.TabStop = false;
            // 
            // rbAll
            // 
            this.rbAll.TabStop = false;
            // 
            // pnlDates
            // 
            this.pnlDates.Location = new System.Drawing.Point(50, 130);
            this.pnlDates.Size = new System.Drawing.Size(435, 30);
            // 
            // frmPurRep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 300);
            this.Name = "frmPurRep";
            this.Text = "Purchase Report";
            this.Load += new System.EventHandler(this.frmPurRep_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.pnlDates.ResumeLayout(false);
            this.pnlDates.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}