namespace prjGrow.Reporting
{
    partial class frmOrderRepAct
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
            this.rbReady = new System.Windows.Forms.RadioButton();
            this.rbNew = new System.Windows.Forms.RadioButton();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.rbFactory = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(2, 9);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // rbReady
            // 
            this.rbReady.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbReady.Location = new System.Drawing.Point(342, 0);
            this.rbReady.Name = "rbReady";
            this.rbReady.Size = new System.Drawing.Size(108, 49);
            this.rbReady.TabIndex = 3;
            this.rbReady.Text = "Ready";
            this.rbReady.UseVisualStyleBackColor = true;
            // 
            // rbNew
            // 
            this.rbNew.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbNew.Location = new System.Drawing.Point(126, 0);
            this.rbNew.Name = "rbNew";
            this.rbNew.Size = new System.Drawing.Size(108, 49);
            this.rbNew.TabIndex = 4;
            this.rbNew.Text = "Pending";
            this.rbNew.UseVisualStyleBackColor = true;
            // 
            // rbAll
            // 
            this.rbAll.Checked = true;
            this.rbAll.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbAll.Location = new System.Drawing.Point(0, 0);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(126, 49);
            this.rbAll.TabIndex = 2;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "All Active";
            this.rbAll.UseVisualStyleBackColor = true;
            // 
            // rbFactory
            // 
            this.rbFactory.AllowDrop = true;
            this.rbFactory.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbFactory.Location = new System.Drawing.Point(234, 0);
            this.rbFactory.Name = "rbFactory";
            this.rbFactory.Size = new System.Drawing.Size(108, 49);
            this.rbFactory.TabIndex = 1;
            this.rbFactory.Text = "Factory";
            this.rbFactory.UseVisualStyleBackColor = true;
            this.rbFactory.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbReady);
            this.panel1.Controls.Add(this.rbFactory);
            this.panel1.Controls.Add(this.rbNew);
            this.panel1.Controls.Add(this.rbAll);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(47, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 49);
            this.panel1.TabIndex = 24;
            // 
            // frmOrderRepAct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 239);
            this.Controls.Add(this.panel1);
            this.Name = "frmOrderRepAct";
            this.Text = "Current Orders Report";
            this.Load += new System.EventHandler(this.frmOrderRepAct_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lblMsg, 0);
            this.Controls.SetChildIndex(this.lblTitle, 0);
            this.Controls.SetChildIndex(this.btnGenerate, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbNew;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.RadioButton rbFactory;
        private System.Windows.Forms.RadioButton rbReady;
        private System.Windows.Forms.Panel panel1;
    }
}