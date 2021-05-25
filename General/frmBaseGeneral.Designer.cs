namespace prjGrow.General
{
    partial class frmBaseGeneral
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSaveUpd = new System.Windows.Forms.Button();
            this.txtSrh = new System.Windows.Forms.TextBox();
            this.gbSrh = new System.Windows.Forms.GroupBox();
            this.lblClient = new System.Windows.Forms.Label();
            this.tmrMsg = new System.Windows.Forms.Timer(this.components);
            this.gbSrh.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(53, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(900, 2);
            this.label1.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(50, 50);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(903, 40);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMsg
            // 
            this.lblMsg.BackColor = System.Drawing.Color.Transparent;
            this.lblMsg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.Location = new System.Drawing.Point(228, 90);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(467, 24);
            this.lblMsg.TabIndex = 3;
            this.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(810, 312);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 30);
            this.btnClose.TabIndex = 23;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(684, 312);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 30);
            this.btnClear.TabIndex = 22;
            this.btnClear.Text = "Clea&r";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSaveUpd
            // 
            this.btnSaveUpd.Location = new System.Drawing.Point(558, 312);
            this.btnSaveUpd.Name = "btnSaveUpd";
            this.btnSaveUpd.Size = new System.Drawing.Size(120, 30);
            this.btnSaveUpd.TabIndex = 21;
            this.btnSaveUpd.Text = "&Save";
            this.btnSaveUpd.UseVisualStyleBackColor = true;
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
            // gbSrh
            // 
            this.gbSrh.Controls.Add(this.txtSrh);
            this.gbSrh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbSrh.Location = new System.Drawing.Point(800, 90);
            this.gbSrh.Name = "gbSrh";
            this.gbSrh.Size = new System.Drawing.Size(148, 57);
            this.gbSrh.TabIndex = 11;
            this.gbSrh.TabStop = false;
            this.gbSrh.Text = "Search:";
            // 
            // lblClient
            // 
            this.lblClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClient.ForeColor = System.Drawing.Color.White;
            this.lblClient.Location = new System.Drawing.Point(47, 7);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(903, 40);
            this.lblClient.TabIndex = 24;
            this.lblClient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrMsg
            // 
            this.tmrMsg.Interval = 4000;
            this.tmrMsg.Tick += new System.EventHandler(this.tmrMsg_Tick);
            // 
            // frmBaseGeneral
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1014, 711);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.gbSrh);
            this.Controls.Add(this.btnSaveUpd);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMsg);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1030, 750);
            this.MinimumSize = new System.Drawing.Size(1030, 600);
            this.Name = "frmBaseGeneral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmBaseGeneral_Load);
            this.gbSrh.ResumeLayout(false);
            this.gbSrh.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Timer tmrMsg;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.Label lblMsg;
        public System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.Button btnClear;
        public System.Windows.Forms.Button btnSaveUpd;
        public System.Windows.Forms.TextBox txtSrh;
        public System.Windows.Forms.GroupBox gbSrh;
        public System.Windows.Forms.Label lblClient;
    }
}