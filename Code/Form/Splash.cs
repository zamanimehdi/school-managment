using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Diagnostics;

namespace Student
{
    public partial class Frm_Splash : Form
    {
        public bool iamclose = false;
        public Frm_Splash()
        {
            InitializeComponent();
        }
        private void Frm_Splash_Load(object sender, EventArgs e)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            label1.Text = FileVersionInfo.GetVersionInfo(assembly.Location).FileVersion.ToString();

            Opacity = 100;
            this.Refresh();
        }

        private void Frm_Splash_Shown(object sender, EventArgs e)
        {
            try
            {
                Form f1 = new frm_choosest();
                f1.Opacity=0;
                f1.Show();
                f1.Close();
            }
            catch 
            {}
        }

    }
}