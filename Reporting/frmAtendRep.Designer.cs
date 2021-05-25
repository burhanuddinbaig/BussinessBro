namespace prjGrow.Reporting
{
    partial class frmAtendRep
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
            this.numYear.Location = new System.Drawing.Point(91, 2);
            this.numYear.Value = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            // 
            // cmbMonth
            // 
            this.cmbMonth.Location = new System.Drawing.Point(285, 1);
            this.cmbMonth.Size = new System.Drawing.Size(66, 26);
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(401, 2);
            this.dtpDate.Size = new System.Drawing.Size(34, 24);
            this.dtpDate.Value = new System.DateTime(2020, 8, 29, 14, 9, 33, 869);
            this.dtpDate.Visible = false;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(47, 4);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(229, 4);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(398, 3);
            this.label4.Visible = false;
            // 
            // rbYear
            // 
            this.rbYear.Location = new System.Drawing.Point(91, 14);
            this.rbYear.TabStop = false;
            // 
            // rbMonth
            // 
            this.rbMonth.Checked = true;
            this.rbMonth.Location = new System.Drawing.Point(236, 14);
            // 
            // rbDaily
            // 
            this.rbDaily.Location = new System.Drawing.Point(401, 14);
            this.rbDaily.TabStop = false;
            this.rbDaily.Visible = false;
            // 
            // rbAll
            // 
            this.rbAll.Location = new System.Drawing.Point(401, 14);
            this.rbAll.TabStop = false;
            // 
            // frmAtendRep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 300);
            this.Name = "frmAtendRep";
            this.Text = "Attendance Report";
            this.Load += new System.EventHandler(this.frmAtendRep_Load);
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