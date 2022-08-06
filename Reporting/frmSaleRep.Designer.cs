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
            this.gbRepType = new System.Windows.Forms.GroupBox();
            this.rbDetailed = new System.Windows.Forms.RadioButton();
            this.rbSimple = new System.Windows.Forms.RadioButton();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.pnlDates.SuspendLayout();
            this.gbRepType.SuspendLayout();
            this.gbSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(51, 295);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(289, 300);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(144, 300);
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // numYear
            // 
            this.numYear.Enabled = false;
            this.numYear.Location = new System.Drawing.Point(51, 3);
            this.numYear.Value = new decimal(new int[] {
            2022,
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
            this.dtpDate.Value = new System.DateTime(2022, 5, 31, 19, 26, 5, 105);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(7, 5);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(50, 212);
            this.groupBox1.Size = new System.Drawing.Size(437, 44);
            // 
            // rbYear
            // 
            this.rbYear.TabStop = false;
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
            this.pnlDates.Location = new System.Drawing.Point(50, 262);
            this.pnlDates.Size = new System.Drawing.Size(438, 32);
            // 
            // gbRepType
            // 
            this.gbRepType.Controls.Add(this.rbDetailed);
            this.gbRepType.Controls.Add(this.rbSimple);
            this.gbRepType.Location = new System.Drawing.Point(50, 74);
            this.gbRepType.Name = "gbRepType";
            this.gbRepType.Size = new System.Drawing.Size(436, 46);
            this.gbRepType.TabIndex = 105;
            this.gbRepType.TabStop = false;
            // 
            // rbDetailed
            // 
            this.rbDetailed.AutoSize = true;
            this.rbDetailed.ForeColor = System.Drawing.Color.LavenderBlush;
            this.rbDetailed.Location = new System.Drawing.Point(223, 21);
            this.rbDetailed.Name = "rbDetailed";
            this.rbDetailed.Size = new System.Drawing.Size(79, 22);
            this.rbDetailed.TabIndex = 1;
            this.rbDetailed.TabStop = true;
            this.rbDetailed.Text = "Detailed";
            this.rbDetailed.UseVisualStyleBackColor = true;
            this.rbDetailed.CheckedChanged += new System.EventHandler(this.rbDetailed_CheckedChanged);
            // 
            // rbSimple
            // 
            this.rbSimple.AutoSize = true;
            this.rbSimple.Checked = true;
            this.rbSimple.ForeColor = System.Drawing.Color.LavenderBlush;
            this.rbSimple.Location = new System.Drawing.Point(68, 21);
            this.rbSimple.Name = "rbSimple";
            this.rbSimple.Size = new System.Drawing.Size(71, 22);
            this.rbSimple.TabIndex = 0;
            this.rbSimple.TabStop = true;
            this.rbSimple.Text = "Simple";
            this.rbSimple.UseVisualStyleBackColor = true;
            this.rbSimple.CheckedChanged += new System.EventHandler(this.rbSimple_CheckedChanged);
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.cmbProduct);
            this.gbSearch.Controls.Add(this.cmbCustomer);
            this.gbSearch.Controls.Add(this.label6);
            this.gbSearch.Controls.Add(this.label5);
            this.gbSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbSearch.Location = new System.Drawing.Point(50, 126);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(436, 83);
            this.gbSearch.TabIndex = 106;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Search By";
            // 
            // cmbProduct
            // 
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(145, 51);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(200, 26);
            this.cmbProduct.TabIndex = 3;
            this.cmbProduct.SelectedIndexChanged += new System.EventHandler(this.cmbProduct_SelectedIndexChanged);
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(145, 19);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(200, 26);
            this.cmbCustomer.TabIndex = 2;
            this.cmbCustomer.SelectedIndexChanged += new System.EventHandler(this.cmbCustomer_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "Product Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Customer Name";
            // 
            // frmSaleRep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 371);
            this.Controls.Add(this.gbSearch);
            this.Controls.Add(this.gbRepType);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmSaleRep";
            this.Text = "Sale Report";
            this.Load += new System.EventHandler(this.frmSaleRep_Load);
            this.Controls.SetChildIndex(this.gbRepType, 0);
            this.Controls.SetChildIndex(this.gbSearch, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lblMsg, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnGenerate, 0);
            this.Controls.SetChildIndex(this.lblTitle, 0);
            this.Controls.SetChildIndex(this.lblClient, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.pnlDates, 0);
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.pnlDates.ResumeLayout(false);
            this.pnlDates.PerformLayout();
            this.gbRepType.ResumeLayout(false);
            this.gbRepType.PerformLayout();
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRepType;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.RadioButton rbDetailed;
        private System.Windows.Forms.RadioButton rbSimple;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}