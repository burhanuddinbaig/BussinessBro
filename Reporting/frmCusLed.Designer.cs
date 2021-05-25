namespace prjGrow.Reporting
{
    partial class frmCusLed
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
            this.cmbCus = new System.Windows.Forms.ComboBox();
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
            this.numYear.Location = new System.Drawing.Point(114, 3);
            this.numYear.Value = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            // 
            // cmbMonth
            // 
            this.cmbMonth.Location = new System.Drawing.Point(305, 2);
            this.cmbMonth.Size = new System.Drawing.Size(66, 26);
        //    this.cmbMonth.SelectedIndexChanged += new System.EventHandler(this.cmbMonth_SelectedIndexChanged);
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(392, -1);
            this.dtpDate.Value = new System.DateTime(2020, 8, 17, 23, 30, 19, 187);
            this.dtpDate.Visible = false;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(37, 5);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(233, 5);
      //      this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(404, 4);
            this.label4.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Size = new System.Drawing.Size(435, 44);
            // 
            // rbYear
            // 
            this.rbYear.Location = new System.Drawing.Point(176, 14);
            // 
            // rbMonth
            // 
            this.rbMonth.Location = new System.Drawing.Point(293, 14);
            // 
            // rbDaily
            // 
            this.rbDaily.Location = new System.Drawing.Point(407, 16);
            this.rbDaily.Visible = false;
            // 
            // rbAll
            // 
            this.rbAll.Location = new System.Drawing.Point(40, 14);
            this.rbAll.Visible = true;
            // 
            // cmbCus
            // 
            this.cmbCus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCus.FormattingEnabled = true;
            this.cmbCus.Location = new System.Drawing.Point(164, 162);
            this.cmbCus.Name = "cmbCus";
            this.cmbCus.Size = new System.Drawing.Size(200, 26);
            this.cmbCus.TabIndex = 105;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(87, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 18);
            this.label5.TabIndex = 106;
            this.label5.Text = "Customer:";
            // 
            // frmCusLed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 300);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbCus);
            this.Name = "frmCusLed";
            this.Text = "Customer Ledger";
            this.Load += new System.EventHandler(this.frmCusLed_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lblMsg, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnGenerate, 0);
            this.Controls.SetChildIndex(this.lblTitle, 0);
            this.Controls.SetChildIndex(this.lblClient, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.pnlDates, 0);
            this.Controls.SetChildIndex(this.cmbCus, 0);
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

        private System.Windows.Forms.ComboBox cmbCus;
        private System.Windows.Forms.Label label5;
    }
}