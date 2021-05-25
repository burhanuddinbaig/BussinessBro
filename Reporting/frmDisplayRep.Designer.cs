namespace prjGrow.Reporting
{
    partial class frmDisplayRep
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
            this.crvRptViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvRptViewer
            // 
            this.crvRptViewer.ActiveViewIndex = -1;
            this.crvRptViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvRptViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvRptViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvRptViewer.Location = new System.Drawing.Point(0, 0);
            this.crvRptViewer.Name = "crvRptViewer";
            this.crvRptViewer.Size = new System.Drawing.Size(644, 461);
            this.crvRptViewer.TabIndex = 0;
            this.crvRptViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmDisplayRep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 461);
            this.Controls.Add(this.crvRptViewer);
            this.MaximizeBox = false;
            this.Name = "frmDisplayRep";
            this.Text = "frmDisplayRep";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDisplayRep_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvRptViewer;
    }
}