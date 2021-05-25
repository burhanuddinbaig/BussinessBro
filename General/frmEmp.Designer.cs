namespace prjGrow.General
{
    partial class frmEmp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmp));
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.mtbCell = new System.Windows.Forms.MaskedTextBox();
            this.mtbCnic = new System.Windows.Forms.MaskedTextBox();
            this.txtAdrs = new System.Windows.Forms.TextBox();
            this.numSal = new System.Windows.Forms.NumericUpDown();
            this.dtpJdate = new System.Windows.Forms.DateTimePicker();
            this.dtpLdate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chkLeaved = new System.Windows.Forms.CheckBox();
            this.pnlLeaving = new System.Windows.Forms.Panel();
            this.gbSrh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSal)).BeginInit();
            this.pnlLeaving.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSaveUpd
            // 
            this.btnSaveUpd.Click += new System.EventHandler(this.btnSaveUpd_Click);
            // 
            // txtSrh
            // 
            this.txtSrh.TextChanged += new System.EventHandler(this.txtSrh_TextChanged);
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AllowUserToResizeColumns = false;
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit,
            this.Delete});
            this.dgvData.Location = new System.Drawing.Point(53, 348);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.Size = new System.Drawing.Size(901, 341);
            this.dgvData.TabIndex = 25;
            this.dgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
            // 
            // Edit
            // 
            this.Edit.FillWeight = 40F;
            this.Edit.HeaderText = "Edit";
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            // 
            // Delete
            // 
            this.Delete.FillWeight = 40F;
            this.Delete.HeaderText = "Delete";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(100, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Employee Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(100, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "CNIC";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(467, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "Cell no";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(100, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 31;
            this.label7.Text = "Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(467, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 20);
            this.label8.TabIndex = 32;
            this.label8.Text = "Salary";
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(231, 117);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(200, 26);
            this.txtEmpName.TabIndex = 1;
            // 
            // mtbCell
            // 
            this.mtbCell.Location = new System.Drawing.Point(531, 117);
            this.mtbCell.Mask = "0000-0000-000";
            this.mtbCell.Name = "mtbCell";
            this.mtbCell.Size = new System.Drawing.Size(200, 26);
            this.mtbCell.TabIndex = 2;
            this.mtbCell.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mtbCnic
            // 
            this.mtbCnic.Location = new System.Drawing.Point(231, 201);
            this.mtbCnic.Mask = "00000-0000000-0";
            this.mtbCnic.Name = "mtbCnic";
            this.mtbCnic.Size = new System.Drawing.Size(200, 26);
            this.mtbCnic.TabIndex = 5;
            // 
            // txtAdrs
            // 
            this.txtAdrs.Location = new System.Drawing.Point(231, 242);
            this.txtAdrs.Name = "txtAdrs";
            this.txtAdrs.Size = new System.Drawing.Size(400, 26);
            this.txtAdrs.TabIndex = 7;
            // 
            // numSal
            // 
            this.numSal.Location = new System.Drawing.Point(531, 201);
            this.numSal.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numSal.Name = "numSal";
            this.numSal.Size = new System.Drawing.Size(100, 26);
            this.numSal.TabIndex = 6;
            this.numSal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numSal.ThousandsSeparator = true;
            // 
            // dtpJdate
            // 
            this.dtpJdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpJdate.Location = new System.Drawing.Point(231, 159);
            this.dtpJdate.Name = "dtpJdate";
            this.dtpJdate.Size = new System.Drawing.Size(100, 26);
            this.dtpJdate.TabIndex = 3;
            // 
            // dtpLdate
            // 
            this.dtpLdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpLdate.Location = new System.Drawing.Point(74, 4);
            this.dtpLdate.Name = "dtpLdate";
            this.dtpLdate.Size = new System.Drawing.Size(100, 26);
            this.dtpLdate.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(100, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = "Joining Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(10, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 36;
            this.label5.Text = "Leaving";
            // 
            // chkLeaved
            // 
            this.chkLeaved.AutoSize = true;
            this.chkLeaved.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chkLeaved.Location = new System.Drawing.Point(647, 155);
            this.chkLeaved.Name = "chkLeaved";
            this.chkLeaved.Size = new System.Drawing.Size(84, 24);
            this.chkLeaved.TabIndex = 37;
            this.chkLeaved.Text = "Unhired";
            this.chkLeaved.UseVisualStyleBackColor = true;
            this.chkLeaved.CheckedChanged += new System.EventHandler(this.chkLeaved_CheckedChanged);
            // 
            // pnlLeaving
            // 
            this.pnlLeaving.Controls.Add(this.dtpLdate);
            this.pnlLeaving.Controls.Add(this.label5);
            this.pnlLeaving.Location = new System.Drawing.Point(457, 154);
            this.pnlLeaving.Name = "pnlLeaving";
            this.pnlLeaving.Size = new System.Drawing.Size(180, 36);
            this.pnlLeaving.TabIndex = 38;
            this.pnlLeaving.Visible = false;
            // 
            // frmEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 711);
            this.Controls.Add(this.pnlLeaving);
            this.Controls.Add(this.chkLeaved);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpJdate);
            this.Controls.Add(this.numSal);
            this.Controls.Add(this.txtAdrs);
            this.Controls.Add(this.mtbCnic);
            this.Controls.Add(this.mtbCell);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvData);
            this.Name = "frmEmp";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.frmEmp_Load);
            this.Controls.SetChildIndex(this.dgvData, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.txtEmpName, 0);
            this.Controls.SetChildIndex(this.mtbCell, 0);
            this.Controls.SetChildIndex(this.mtbCnic, 0);
            this.Controls.SetChildIndex(this.txtAdrs, 0);
            this.Controls.SetChildIndex(this.numSal, 0);
            this.Controls.SetChildIndex(this.lblMsg, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lblTitle, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnClear, 0);
            this.Controls.SetChildIndex(this.btnSaveUpd, 0);
            this.Controls.SetChildIndex(this.gbSrh, 0);
            this.Controls.SetChildIndex(this.lblClient, 0);
            this.Controls.SetChildIndex(this.dtpJdate, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.chkLeaved, 0);
            this.Controls.SetChildIndex(this.pnlLeaving, 0);
            this.gbSrh.ResumeLayout(false);
            this.gbSrh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSal)).EndInit();
            this.pnlLeaving.ResumeLayout(false);
            this.pnlLeaving.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.MaskedTextBox mtbCell;
        private System.Windows.Forms.MaskedTextBox mtbCnic;
        private System.Windows.Forms.TextBox txtAdrs;
        private System.Windows.Forms.NumericUpDown numSal;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.DateTimePicker dtpJdate;
        private System.Windows.Forms.DateTimePicker dtpLdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkLeaved;
        private System.Windows.Forms.Panel pnlLeaving;
    }
}