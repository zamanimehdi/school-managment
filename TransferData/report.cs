using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Internet_SM
{
    public partial class report : Form
    {
        public report()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void report_Shown(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = userNamePass1;
        }
    }
}
