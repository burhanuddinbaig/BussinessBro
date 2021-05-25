namespace prjGrow.Reporting
{
    partial class frmShortStockRep
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
            this.label3 = new System.Windows.Forms.Label();
            this.rbShort = new System.Windows.Forms.RadioButton();
            this.rbBelow = new System.Windows.Forms.RadioButton();
            this.numBelowQty = new System.Windows.Forms.NumericUpDown();
            this.pnlBelow = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numBelowQty)).BeginInit();
            this.pnlBelow.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(47, 157);
            this.label1.Visible = false;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(139, 164);
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(286, 164);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(14, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 18);
            this.label3.TabIndex = 24;
            this.label3.Text = "Below Quanity";
            // 
            // rbShort
            // 
            this.rbShort.AutoSize = true;
            this.rbShort.Checked = true;
            this.rbShort.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbShort.Location = new System.Drawing.Point(139, 77);
            this.rbShort.Name = "rbShort";
            this.rbShort.Size = new System.Drawing.Size(102, 22);
            this.rbShort.TabIndex = 26;
            this.rbShort.TabStop = true;
            this.rbShort.Text = "Short Items";
            this.rbShort.UseVisualStyleBackColor = true;
            this.rbShort.CheckedChanged += new System.EventHandler(this.rbShort_CheckedChanged);
            // 
            // rbBelow
            // 
            this.rbBelow.AutoSize = true;
            this.rbBelow.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbBelow.Location = new System.Drawing.Point(283, 77);
            this.rbBelow.Name = "rbBelow";
            this.rbBelow.Size = new System.Drawing.Size(110, 22);
            this.rbBelow.TabIndex = 27;
            this.rbBelow.Text = "Below Stock";
            this.rbBelow.UseVisualStyleBackColor = true;
            this.rbBelow.CheckedChanged += new System.EventHandler(this.rbBelow_CheckedChanged);
            // 
            // numBelowQty
            // 
            this.numBelowQty.Location = new System.Drawing.Point(147, 4);
            this.numBelowQty.Name = "numBelowQty";
            this.numBelowQty.Size = new System.Drawing.Size(120, 24);
            this.numBelowQty.TabIndex = 28;
            // 
            // pnlBelow
            // 
            this.pnlBelow.Controls.Add(this.numBelowQty);
            this.pnlBelow.Controls.Add(this.label3);
            this.pnlBelow.Enabled = false;
            this.pnlBelow.Location = new System.Drawing.Point(124, 114);
            this.pnlBelow.Name = "pnlBelow";
            this.pnlBelow.Size = new System.Drawing.Size(280, 35);
            this.pnlBelow.TabIndex = 29;
            // 
            // frmShortStockRep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 221);
            this.Controls.Add(this.pnlBelow);
            this.Controls.Add(this.rbBelow);
            this.Controls.Add(this.rbShort);
            this.MaximumSize = new System.Drawing.Size(560, 260);
            this.MinimumSize = new System.Drawing.Size(560, 260);
            this.Name = "frmShortStockRep";
            this.Text = "Short Stock";
            this.Load += new System.EventHandler(this.frmShortStockRep_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lblMsg, 0);
            this.Controls.SetChildIndex(this.lblTitle, 0);
            this.Controls.SetChildIndex(this.btnGenerate, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.rbShort, 0);
            this.Controls.SetChildIndex(this.rbBelow, 0);
            this.Controls.SetChildIndex(this.pnlBelow, 0);
            ((System.ComponentModel.ISupportInitialize)(this.numBelowQty)).EndInit();
            this.pnlBelow.ResumeLayout(false);
            this.pnlBelow.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbShort;
        private System.Windows.Forms.RadioButton rbBelow;
        private System.Windows.Forms.NumericUpDown numBelowQty;
        private System.Windows.Forms.Panel pnlBelow;
    }
}