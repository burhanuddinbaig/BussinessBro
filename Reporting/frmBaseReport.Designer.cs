namespace prjGrow.Reporting
{
    partial class frmBaseReport
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
            this.btnGenerate = new System.Windows.Forms.Button();
            this.rbYear = new System.Windows.Forms.RadioButton();
            this.rbMonth = new System.Windows.Forms.RadioButton();
            this.rbDaily = new System.Windows.Forms.RadioButton();
            this.numYear = new System.Windows.Forms.NumericUpDown();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblClient = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.tmrMsg = new System.Windows.Forms.Timer(this.components);
            this.pnlDates = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.pnlDates.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMsg
            // 
            this.lblMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.Location = new System.Drawing.Point(4, 51);
            this.lblMsg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(541, 20);
            this.lblMsg.TabIndex = 9;
            this.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitle.Location = new System.Drawing.Point(2, 13);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(541, 35);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(50, 227);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 2);
            this.label1.TabIndex = 7;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(286, 232);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 30);
            this.btnClose.TabIndex = 102;
            this.btnClose.Text = "&Cancel";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(141, 232);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(139, 30);
            this.btnGenerate.TabIndex = 101;
            this.btnGenerate.Text = "&Show Report";
            this.btnGenerate.UseVisualStyleBackColor = true;
            // 
            // rbYear
            // 
            this.rbYear.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbYear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbYear.Location = new System.Drawing.Point(3, 20);
            this.rbYear.Name = "rbYear";
            this.rbYear.Size = new System.Drawing.Size(104, 21);
            this.rbYear.TabIndex = 1;
            this.rbYear.TabStop = true;
            this.rbYear.Text = "&Yearly";
            this.rbYear.UseVisualStyleBackColor = true;
            this.rbYear.CheckedChanged += new System.EventHandler(this.rbYear_CheckedChanged);
            // 
            // rbMonth
            // 
            this.rbMonth.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbMonth.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbMonth.Location = new System.Drawing.Point(107, 20);
            this.rbMonth.Name = "rbMonth";
            this.rbMonth.Size = new System.Drawing.Size(116, 21);
            this.rbMonth.TabIndex = 2;
            this.rbMonth.TabStop = true;
            this.rbMonth.Text = "&Monthly";
            this.rbMonth.UseVisualStyleBackColor = true;
            this.rbMonth.CheckedChanged += new System.EventHandler(this.rbMonth_CheckedChanged);
            // 
            // rbDaily
            // 
            this.rbDaily.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbDaily.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbDaily.Location = new System.Drawing.Point(223, 20);
            this.rbDaily.Name = "rbDaily";
            this.rbDaily.Size = new System.Drawing.Size(96, 21);
            this.rbDaily.TabIndex = 3;
            this.rbDaily.TabStop = true;
            this.rbDaily.Text = "&Daily";
            this.rbDaily.UseVisualStyleBackColor = true;
            this.rbDaily.CheckedChanged += new System.EventHandler(this.rbDaily_CheckedChanged);
            // 
            // numYear
            // 
            this.numYear.Location = new System.Drawing.Point(42, 3);
            this.numYear.Maximum = new decimal(new int[] {
            2099,
            0,
            0,
            0});
            this.numYear.Minimum = new decimal(new int[] {
            2019,
            0,
            0,
            0});
            this.numYear.Name = "numYear";
            this.numYear.Size = new System.Drawing.Size(66, 24);
            this.numYear.TabIndex = 11;
            this.numYear.Value = new decimal(new int[] {
            2019,
            0,
            0,
            0});
            // 
            // cmbMonth
            // 
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Items.AddRange(new object[] {
            "Jan",
            "Feb",
            "Mar",
            "April",
            "May",
            "June",
            "July",
            "Aug",
            "Sep",
            "Oct",
            "Nov",
            "Dec"});
            this.cmbMonth.Location = new System.Drawing.Point(195, 2);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(66, 26);
            this.cmbMonth.TabIndex = 12;
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(332, 2);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(103, 24);
            this.dtpDate.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(-2, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "Year";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(139, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 18);
            this.label3.TabIndex = 20;
            this.label3.Text = "Month";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(287, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 18);
            this.label4.TabIndex = 21;
            this.label4.Text = "Date";
            // 
            // lblClient
            // 
            this.lblClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClient.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblClient.Location = new System.Drawing.Point(2, 3);
            this.lblClient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(541, 10);
            this.lblClient.TabIndex = 22;
            this.lblClient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblClient.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbAll);
            this.groupBox1.Controls.Add(this.rbDaily);
            this.groupBox1.Controls.Add(this.rbMonth);
            this.groupBox1.Controls.Add(this.rbYear);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(92, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 44);
            this.groupBox1.TabIndex = 103;
            this.groupBox1.TabStop = false;
            // 
            // rbAll
            // 
            this.rbAll.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbAll.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbAll.Location = new System.Drawing.Point(319, 20);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(113, 21);
            this.rbAll.TabIndex = 4;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "&All in All";
            this.rbAll.UseVisualStyleBackColor = true;
            this.rbAll.Visible = false;
            this.rbAll.CheckedChanged += new System.EventHandler(this.rbAll_CheckedChanged);
            // 
            // tmrMsg
            // 
            this.tmrMsg.Interval = 4000;
            this.tmrMsg.Tick += new System.EventHandler(this.tmrMsg_Tick);
            // 
            // pnlDates
            // 
            this.pnlDates.Controls.Add(this.numYear);
            this.pnlDates.Controls.Add(this.label2);
            this.pnlDates.Controls.Add(this.label3);
            this.pnlDates.Controls.Add(this.label4);
            this.pnlDates.Controls.Add(this.cmbMonth);
            this.pnlDates.Controls.Add(this.dtpDate);
            this.pnlDates.Location = new System.Drawing.Point(50, 124);
            this.pnlDates.Name = "pnlDates";
            this.pnlDates.Size = new System.Drawing.Size(435, 32);
            this.pnlDates.TabIndex = 104;
            // 
            // frmBaseReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(544, 300);
            this.Controls.Add(this.pnlDates);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmBaseReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmBaseReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.pnlDates.ResumeLayout(false);
            this.pnlDates.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Timer tmrMsg;
        public System.Windows.Forms.Label lblMsg;
        public System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.Button btnGenerate;
        public System.Windows.Forms.NumericUpDown numYear;
        public System.Windows.Forms.ComboBox cmbMonth;
        public System.Windows.Forms.DateTimePicker dtpDate;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label lblClient;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.RadioButton rbYear;
        public System.Windows.Forms.RadioButton rbMonth;
        public System.Windows.Forms.RadioButton rbDaily;
        public System.Windows.Forms.RadioButton rbAll;
        public System.Windows.Forms.Panel pnlDates;
    }
}