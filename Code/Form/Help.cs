using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Student
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void Help_Load(object sender, EventArgs e)
        {
            string str=System.Windows.Forms.Application.ExecutablePath.ToString().Substring(0,System.Windows.Forms.Application.ExecutablePath.ToString().Length-21)+"help\\help.htm";
            System.Uri url = new Uri(str);
            webBrowser1.Url =url;
        }

        private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            toolStripProgressBar1.Value = (int)(100 * e.CurrentProgress / e.MaximumProgress);
        }
    }
}