using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Data;

namespace prjGrow.Reporting
{
    public partial class frmDisplayRep : Form
    {
        public frmDisplayRep(string repName)
        {
            InitializeComponent();
            this.Text = repName;
        }
        
        public object rep = null;

        private void frmDisplayRep_Load(object sender, EventArgs e)
        {
            crvRptViewer.ReportSource = rep;
        }
    }
}