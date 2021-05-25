namespace prjGrow.StockInfo
{
    partial class frmBaseSalePur
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
            this.lblClient = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numInvoiceno = new System.Windows.Forms.NumericUpDown();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cmbClient = new System.Windows.Forms.ComboBox();
            this.lblProdCode = new System.Windows.Forms.Label();
            this.txtProdCode = new System.Windows.Forms.TextBox();
            this.lblProdName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.txtAccno = new System.Windows.Forms.TextBox();
            this.cmbBank = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.numClientBal = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.btnBank = new System.Windows.Forms.Button();
            this.btnClient = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.tmrMsg = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numInvoiceno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numClientBal)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClient
            // 
            this.lblClient.BackColor = System.Drawing.Color.Transparent;
            this.lblClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClient.ForeColor = System.Drawing.Color.White;
            this.lblClient.Location = new System.Drawing.Point(1, 11);
            this.lblClient.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(1320, 40);
            this.lblClient.TabIndex = 28;
            this.lblClient.Text = "Client Name";
            this.lblClient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMsg
            // 
            this.lblMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.Location = new System.Drawing.Point(323, 91);
            this.lblMsg.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(780, 24);
            this.lblMsg.TabIndex = 27;
            this.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(1, 51);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1320, 40);
            this.lblTitle.TabIndex = 26;
            this.lblTitle.Text = "Sale Corner";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(-4, 277);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 4);
            this.label1.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(48, 160);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 30;
            this.label2.Text = "Invoice No";
            // 
            // numInvoiceno
            // 
            this.numInvoiceno.Enabled = false;
            this.numInvoiceno.Location = new System.Drawing.Point(150, 156);
            this.numInvoiceno.Margin = new System.Windows.Forms.Padding(4);
            this.numInvoiceno.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numInvoiceno.Name = "numInvoiceno";
            this.numInvoiceno.ReadOnly = true;
            this.numInvoiceno.Size = new System.Drawing.Size(128, 29);
            this.numInvoiceno.TabIndex = 31;
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(150, 194);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(127, 29);
            this.dtpDate.TabIndex = 31;
            // 
            // cmbClient
            // 
            this.cmbClient.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbClient.FormattingEnabled = true;
            this.cmbClient.Location = new System.Drawing.Point(323, 187);
            this.cmbClient.Margin = new System.Windows.Forms.Padding(4);
            this.cmbClient.Name = "cmbClient";
            this.cmbClient.Size = new System.Drawing.Size(220, 32);
            this.cmbClient.TabIndex = 32;
            // 
            // lblProdCode
            // 
            this.lblProdCode.AutoSize = true;
            this.lblProdCode.BackColor = System.Drawing.Color.Transparent;
            this.lblProdCode.ForeColor = System.Drawing.Color.White;
            this.lblProdCode.Location = new System.Drawing.Point(319, 254);
            this.lblProdCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProdCode.Name = "lblProdCode";
            this.lblProdCode.Size = new System.Drawing.Size(126, 24);
            this.lblProdCode.TabIndex = 36;
            this.lblProdCode.Text = "Product Code";
            // 
            // txtProdCode
            // 
            this.txtProdCode.Location = new System.Drawing.Point(449, 250);
            this.txtProdCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtProdCode.MaxLength = 40;
            this.txtProdCode.Name = "txtProdCode";
            this.txtProdCode.Size = new System.Drawing.Size(220, 29);
            this.txtProdCode.TabIndex = 1;
            this.txtProdCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblProdName
            // 
            this.lblProdName.AutoSize = true;
            this.lblProdName.BackColor = System.Drawing.Color.Transparent;
            this.lblProdName.ForeColor = System.Drawing.Color.White;
            this.lblProdName.Location = new System.Drawing.Point(722, 254);
            this.lblProdName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProdName.Name = "lblProdName";
            this.lblProdName.Size = new System.Drawing.Size(131, 24);
            this.lblProdName.TabIndex = 39;
            this.lblProdName.Text = "Product Name";
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(287, 143);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(2, 138);
            this.label7.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(48, 198);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 24);
            this.label8.TabIndex = 43;
            this.label8.Text = "Date";
            // 
            // txtProdName
            // 
            this.txtProdName.Location = new System.Drawing.Point(857, 250);
            this.txtProdName.Margin = new System.Windows.Forms.Padding(4);
            this.txtProdName.MaxLength = 40;
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Size = new System.Drawing.Size(220, 29);
            this.txtProdName.TabIndex = 2;
            // 
            // txtAccno
            // 
            this.txtAccno.Enabled = false;
            this.txtAccno.Location = new System.Drawing.Point(969, 190);
            this.txtAccno.Margin = new System.Windows.Forms.Padding(4);
            this.txtAccno.Name = "txtAccno";
            this.txtAccno.ReadOnly = true;
            this.txtAccno.Size = new System.Drawing.Size(134, 29);
            this.txtAccno.TabIndex = 46;
            // 
            // cmbBank
            // 
            this.cmbBank.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbBank.FormattingEnabled = true;
            this.cmbBank.Location = new System.Drawing.Point(721, 187);
            this.cmbBank.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBank.Name = "cmbBank";
            this.cmbBank.Size = new System.Drawing.Size(220, 32);
            this.cmbBank.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(721, 162);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 24);
            this.label9.TabIndex = 47;
            this.label9.Text = "Bank:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(557, 160);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 24);
            this.label10.TabIndex = 48;
            this.label10.Text = "Balance:";
            // 
            // numClientBal
            // 
            this.numClientBal.Enabled = false;
            this.numClientBal.Location = new System.Drawing.Point(551, 187);
            this.numClientBal.Margin = new System.Windows.Forms.Padding(4);
            this.numClientBal.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numClientBal.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.numClientBal.Name = "numClientBal";
            this.numClientBal.ReadOnly = true;
            this.numClientBal.Size = new System.Drawing.Size(115, 29);
            this.numClientBal.TabIndex = 49;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(969, 162);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 24);
            this.label11.TabIndex = 50;
            this.label11.Text = "Account no:";
            // 
            // btnBank
            // 
            this.btnBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBank.Location = new System.Drawing.Point(870, 156);
            this.btnBank.Margin = new System.Windows.Forms.Padding(4);
            this.btnBank.Name = "btnBank";
            this.btnBank.Size = new System.Drawing.Size(92, 29);
            this.btnBank.TabIndex = 69;
            this.btnBank.Text = "Add New";
            this.btnBank.UseVisualStyleBackColor = true;
            // 
            // btnClient
            // 
            this.btnClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClient.Location = new System.Drawing.Point(449, 157);
            this.btnClient.Margin = new System.Windows.Forms.Padding(4);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(94, 29);
            this.btnClient.TabIndex = 70;
            this.btnClient.Text = "Add New";
            this.btnClient.UseVisualStyleBackColor = true;
            // 
            // btnProduct
            // 
            this.btnProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.Location = new System.Drawing.Point(1111, 251);
            this.btnProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(92, 29);
            this.btnProduct.TabIndex = 71;
            this.btnProduct.Text = "Add New";
            this.btnProduct.UseVisualStyleBackColor = true;
            // 
            // tmrMsg
            // 
            this.tmrMsg.Interval = 5000;
            this.tmrMsg.Tick += new System.EventHandler(this.tmrMsg_Tick);
            // 
            // frmBaseSalePur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1028, 749);
            this.Controls.Add(this.btnProduct);
            this.Controls.Add(this.btnClient);
            this.Controls.Add(this.btnBank);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.numClientBal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtAccno);
            this.Controls.Add(this.cmbBank);
            this.Controls.Add(this.txtProdName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblProdName);
            this.Controls.Add(this.txtProdCode);
            this.Controls.Add(this.lblProdCode);
            this.Controls.Add(this.cmbClient);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.numInvoiceno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1585, 862);
            this.MinimumSize = new System.Drawing.Size(1022, 726);
            this.Name = "frmBaseSalePur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBaseSalePur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numInvoiceno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numClientBal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label lblClient;
        protected System.Windows.Forms.Label lblMsg;
        protected System.Windows.Forms.Label lblTitle;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.NumericUpDown numInvoiceno;
        protected System.Windows.Forms.DateTimePicker dtpDate;
        protected System.Windows.Forms.ComboBox cmbClient;
        protected System.Windows.Forms.Label lblProdCode;
        protected System.Windows.Forms.TextBox txtProdCode;
        protected System.Windows.Forms.Label lblProdName;
        protected System.Windows.Forms.Label label7;
        protected System.Windows.Forms.Label label8;
        protected System.Windows.Forms.TextBox txtProdName;
        protected System.Windows.Forms.TextBox txtAccno;
        protected System.Windows.Forms.ComboBox cmbBank;
        protected System.Windows.Forms.Label label9;
        protected System.Windows.Forms.Label label10;
        protected System.Windows.Forms.NumericUpDown numClientBal;
        protected System.Windows.Forms.Label label11;
        public System.Windows.Forms.Button btnBank;
        public System.Windows.Forms.Button btnClient;
        public System.Windows.Forms.Button btnProduct;
        public System.Windows.Forms.Timer tmrMsg;
    }
}