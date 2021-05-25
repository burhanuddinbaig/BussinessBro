namespace prjGrow.Manufacture
{
    partial class frmBaseComplex
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
            this.components = new System.ComponentModel.Container();
            this.btnSaveUpd = new System.Windows.Forms.Button();
            this.btnReview = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblClient = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.tmrMsg = new System.Windows.Forms.Timer(this.components);
            this.lblSep = new System.Windows.Forms.Label();
            this.gbSrh = new System.Windows.Forms.GroupBox();
            this.txtSrh = new System.Windows.Forms.TextBox();
            this.gbSrh.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSaveUpd
            // 
            this.btnSaveUpd.Location = new System.Drawing.Point(46, 482);
            this.btnSaveUpd.Name = "btnSaveUpd";
            this.btnSaveUpd.Size = new System.Drawing.Size(179, 30);
            this.btnSaveUpd.TabIndex = 1;
            this.btnSaveUpd.Text = "&Save";
            this.btnSaveUpd.UseVisualStyleBackColor = true;
            // 
            // btnReview
            // 
            this.btnReview.Location = new System.Drawing.Point(46, 522);
            this.btnReview.Name = "btnReview";
            this.btnReview.Size = new System.Drawing.Size(179, 30);
            this.btnReview.TabIndex = 2;
            this.btnReview.Text = "Re&view";
            this.btnReview.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(46, 608);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(179, 30);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblClient
            // 
            this.lblClient.BackColor = System.Drawing.Color.Transparent;
            this.lblClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClient.ForeColor = System.Drawing.Color.White;
            this.lblClient.Location = new System.Drawing.Point(7, 9);
            this.lblClient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(1264, 40);
            this.lblClient.TabIndex = 71;
            this.lblClient.Text = "Client Name";
            this.lblClient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMsg
            // 
            this.lblMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.Location = new System.Drawing.Point(244, 95);
            this.lblMsg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(670, 20);
            this.lblMsg.TabIndex = 70;
            this.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(7, 52);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1264, 40);
            this.lblTitle.TabIndex = 69;
            this.lblTitle.Text = "Title";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(46, 565);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(179, 30);
            this.btnClear.TabIndex = 78;
            this.btnClear.Text = "Clea&r";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // tmrMsg
            // 
            this.tmrMsg.Interval = 4000;
            this.tmrMsg.Tick += new System.EventHandler(this.tmrMsg_Tick);
            // 
            // lblSep
            // 
            this.lblSep.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSep.Location = new System.Drawing.Point(256, 338);
            this.lblSep.Name = "lblSep";
            this.lblSep.Size = new System.Drawing.Size(880, 2);
            this.lblSep.TabIndex = 79;
            // 
            // gbSrh
            // 
            this.gbSrh.Controls.Add(this.txtSrh);
            this.gbSrh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbSrh.Location = new System.Drawing.Point(982, 95);
            this.gbSrh.Name = "gbSrh";
            this.gbSrh.Size = new System.Drawing.Size(148, 57);
            this.gbSrh.TabIndex = 80;
            this.gbSrh.TabStop = false;
            this.gbSrh.Text = "Search:";
            // 
            // txtSrh
            // 
            this.txtSrh.Location = new System.Drawing.Point(6, 27);
            this.txtSrh.MaxLength = 8;
            this.txtSrh.Name = "txtSrh";
            this.txtSrh.Size = new System.Drawing.Size(136, 26);
            this.txtSrh.TabIndex = 24;
            this.txtSrh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmBaseComplex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1184, 686);
            this.Controls.Add(this.btnSaveUpd);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReview);
            this.Controls.Add(this.gbSrh);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblSep);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 725);
            this.MinimumSize = new System.Drawing.Size(1200, 725);
            this.Name = "frmBaseComplex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmBaseProcess";
            this.gbSrh.ResumeLayout(false);
            this.gbSrh.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnSaveUpd;
        public System.Windows.Forms.Button btnReview;
        public System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.Label lblClient;
        public System.Windows.Forms.Label lblMsg;
        public System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.Button btnClear;
        public System.Windows.Forms.Timer tmrMsg;
        public System.Windows.Forms.Label lblSep;
        public System.Windows.Forms.GroupBox gbSrh;
        public System.Windows.Forms.TextBox txtSrh;

    }
}