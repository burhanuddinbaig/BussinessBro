namespace prjGrow.General
{
    partial class frmBaseSimple
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
            this.lblMsg = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSaveUpd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.gbSrh = new System.Windows.Forms.GroupBox();
            this.txtSrh = new System.Windows.Forms.TextBox();
            this.lblClient = new System.Windows.Forms.Label();
            this.tmrMsg = new System.Windows.Forms.Timer(this.components);
            this.gbSrh.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMsg
            // 
            this.lblMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMsg.Location = new System.Drawing.Point(4, 78);
            this.lblMsg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(711, 22);
            this.lblMsg.TabIndex = 6;
            this.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(2, 41);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(711, 35);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(54, 229);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(600, 2);
            this.label1.TabIndex = 4;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(534, 237);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 30);
            this.btnClose.TabIndex = 29;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSaveUpd
            // 
            this.btnSaveUpd.Location = new System.Drawing.Point(318, 237);
            this.btnSaveUpd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSaveUpd.Name = "btnSaveUpd";
            this.btnSaveUpd.Size = new System.Drawing.Size(100, 30);
            this.btnSaveUpd.TabIndex = 20;
            this.btnSaveUpd.Text = "&Save";
            this.btnSaveUpd.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(426, 237);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 30);
            this.btnClear.TabIndex = 28;
            this.btnClear.Text = "Clea&r";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // gbSrh
            // 
            this.gbSrh.Controls.Add(this.txtSrh);
            this.gbSrh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbSrh.Location = new System.Drawing.Point(534, 105);
            this.gbSrh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbSrh.Name = "gbSrh";
            this.gbSrh.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbSrh.Size = new System.Drawing.Size(167, 61);
            this.gbSrh.TabIndex = 30;
            this.gbSrh.TabStop = false;
            this.gbSrh.Text = "Search";
            // 
            // txtSrh
            // 
            this.txtSrh.Location = new System.Drawing.Point(9, 27);
            this.txtSrh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSrh.MaxLength = 8;
            this.txtSrh.Name = "txtSrh";
            this.txtSrh.Size = new System.Drawing.Size(150, 24);
            this.txtSrh.TabIndex = 30;
            this.txtSrh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblClient
            // 
            this.lblClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClient.ForeColor = System.Drawing.Color.White;
            this.lblClient.Location = new System.Drawing.Point(1, 2);
            this.lblClient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(711, 35);
            this.lblClient.TabIndex = 31;
            this.lblClient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrMsg
            // 
            this.tmrMsg.Interval = 3000;
            this.tmrMsg.Tick += new System.EventHandler(this.tmrMsg_Tick);
            // 
            // frmBaseSimple
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(714, 561);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.gbSrh);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSaveUpd);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmBaseSimple";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmBaseSimple";
            this.Load += new System.EventHandler(this.frmBaseSimple_Load);
            this.gbSrh.ResumeLayout(false);
            this.gbSrh.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Label lblMsg;
        protected System.Windows.Forms.Label lblTitle;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Button btnClose;
        protected System.Windows.Forms.Button btnSaveUpd;
        protected System.Windows.Forms.Button btnClear;
        protected System.Windows.Forms.GroupBox gbSrh;
        protected System.Windows.Forms.Label lblClient;
        protected System.Windows.Forms.TextBox txtSrh;
        public System.Windows.Forms.Timer tmrMsg;
    }
}