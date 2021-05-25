namespace prjGrow.Reporting
{
    partial class frmExpiryRep
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
            this.rbFour = new System.Windows.Forms.RadioButton();
            this.rbTwo = new System.Windows.Forms.RadioButton();
            this.rbExpired = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(1, 29);
            // 
            // lblMsg
            // 
            this.lblMsg.Location = new System.Drawing.Point(2, 67);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(47, 154);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(138, 160);
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(285, 160);
            // 
            // rbFour
            // 
            this.rbFour.AutoSize = true;
            this.rbFour.Checked = true;
            this.rbFour.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbFour.Location = new System.Drawing.Point(94, 96);
            this.rbFour.Name = "rbFour";
            this.rbFour.Size = new System.Drawing.Size(111, 22);
            this.rbFour.TabIndex = 23;
            this.rbFour.TabStop = true;
            this.rbFour.Text = "Four months";
            this.rbFour.UseVisualStyleBackColor = true;
            // 
            // rbTwo
            // 
            this.rbTwo.AutoSize = true;
            this.rbTwo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbTwo.Location = new System.Drawing.Point(235, 96);
            this.rbTwo.Name = "rbTwo";
            this.rbTwo.Size = new System.Drawing.Size(109, 22);
            this.rbTwo.TabIndex = 24;
            this.rbTwo.Text = "Two months";
            this.rbTwo.UseVisualStyleBackColor = true;
            // 
            // rbExpired
            // 
            this.rbExpired.AutoSize = true;
            this.rbExpired.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbExpired.Location = new System.Drawing.Point(371, 96);
            this.rbExpired.Name = "rbExpired";
            this.rbExpired.Size = new System.Drawing.Size(75, 22);
            this.rbExpired.TabIndex = 25;
            this.rbExpired.Text = "Expired";
            this.rbExpired.UseVisualStyleBackColor = true;
            // 
            // frmExpiryRep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 239);
            this.Controls.Add(this.rbExpired);
            this.Controls.Add(this.rbTwo);
            this.Controls.Add(this.rbFour);
            this.Name = "frmExpiryRep";
            this.Text = "Expiry Report";
            this.Load += new System.EventHandler(this.frmExpiryRep_Load);
            this.Controls.SetChildIndex(this.rbFour, 0);
            this.Controls.SetChildIndex(this.rbTwo, 0);
            this.Controls.SetChildIndex(this.rbExpired, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lblMsg, 0);
            this.Controls.SetChildIndex(this.lblTitle, 0);
            this.Controls.SetChildIndex(this.btnGenerate, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbFour;
        private System.Windows.Forms.RadioButton rbTwo;
        private System.Windows.Forms.RadioButton rbExpired;
    }
}