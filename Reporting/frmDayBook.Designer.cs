namespace prjGrow.Reporting
{
    partial class frmDayBook
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
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(50, 173);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(286, 178);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(141, 178);
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // numYear
            // 
            this.numYear.Location = new System.Drawing.Point(384, 4);
            this.numYear.Value = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            this.numYear.Visible = false;
            // 
            // cmbMonth
            // 
            this.cmbMonth.Location = new System.Drawing.Point(292, 2);
            this.cmbMonth.Size = new System.Drawing.Size(66, 26);
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(121, 3);
            this.dtpDate.Value = new System.DateTime(2021, 2, 24, 17, 19, 22, 983);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(397, 4);
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(242, 5);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(76, 6);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(67, 83);
            this.groupBox1.Size = new System.Drawing.Size(418, 44);
            // 
            // rbYear
            // 
            this.rbYear.TabStop = false;
            this.rbYear.Visible = false;
            // 
            // rbMonth
            // 
            this.rbMonth.TabStop = false;
            // 
            // rbDaily
            // 
            this.rbDaily.Checked = true;
            // 
            // rbAll
            // 
            this.rbAll.TabStop = false;
            // 
            // pnlDates
            // 
            this.pnlDates.Location = new System.Drawing.Point(50, 135);
            // 
            // frmDayBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 245);
            this.Name = "frmDayBook";
            this.Text = "Day Book";
            this.Load += new System.EventHandler(this.frmDayBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.pnlDates.ResumeLayout(false);
            this.pnlDates.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}