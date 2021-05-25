namespace prjGrow.Users
{
    partial class frmChangePass
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
            this.btnChange = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUname = new System.Windows.Forms.TextBox();
            this.passOld = new System.Windows.Forms.TextBox();
            this.passNew = new System.Windows.Forms.TextBox();
            this.passConfirm = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMsg
            // 
            this.lblMsg.Location = new System.Drawing.Point(4, 58);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(57, 279);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(264, 286);
            this.btnClear.Text = "&Cancel";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(145, 286);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(112, 32);
            this.btnChange.TabIndex = 30;
            this.btnChange.Text = "C&hange";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(83, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 18);
            this.label2.TabIndex = 31;
            this.label2.Text = "User Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(83, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 18);
            this.label3.TabIndex = 32;
            this.label3.Text = "Old Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(83, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 18);
            this.label4.TabIndex = 33;
            this.label4.Text = "New Password";
            // 
            // txtUname
            // 
            this.txtUname.Location = new System.Drawing.Point(217, 93);
            this.txtUname.Name = "txtUname";
            this.txtUname.ReadOnly = true;
            this.txtUname.Size = new System.Drawing.Size(200, 24);
            this.txtUname.TabIndex = 34;
            // 
            // passOld
            // 
            this.passOld.Location = new System.Drawing.Point(217, 132);
            this.passOld.Name = "passOld";
            this.passOld.PasswordChar = '*';
            this.passOld.Size = new System.Drawing.Size(200, 24);
            this.passOld.TabIndex = 35;
            // 
            // passNew
            // 
            this.passNew.Location = new System.Drawing.Point(217, 172);
            this.passNew.Name = "passNew";
            this.passNew.PasswordChar = '*';
            this.passNew.Size = new System.Drawing.Size(200, 24);
            this.passNew.TabIndex = 36;
            // 
            // passConfirm
            // 
            this.passConfirm.Location = new System.Drawing.Point(217, 211);
            this.passConfirm.Name = "passConfirm";
            this.passConfirm.PasswordChar = '*';
            this.passConfirm.Size = new System.Drawing.Size(200, 24);
            this.passConfirm.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(83, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 18);
            this.label5.TabIndex = 38;
            this.label5.Text = "Confirm Password";
            // 
            // frmChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 361);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.passConfirm);
            this.Controls.Add(this.passNew);
            this.Controls.Add(this.passOld);
            this.Controls.Add(this.txtUname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnChange);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmChangePass";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Change Password";
            this.Load += new System.EventHandler(this.frmChangePass_Load);
            this.Controls.SetChildIndex(this.lblTitle, 0);
            this.Controls.SetChildIndex(this.lblMsg, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btnClear, 0);
            this.Controls.SetChildIndex(this.btnChange, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtUname, 0);
            this.Controls.SetChildIndex(this.passOld, 0);
            this.Controls.SetChildIndex(this.passNew, 0);
            this.Controls.SetChildIndex(this.passConfirm, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUname;
        private System.Windows.Forms.TextBox passOld;
        private System.Windows.Forms.TextBox passNew;
        private System.Windows.Forms.TextBox passConfirm;
        private System.Windows.Forms.Label label5;
    }
}