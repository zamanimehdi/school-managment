using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace NetworkTransfer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (DialogResult.OK == folderBrowserDialog1.ShowDialog())
            {
                textBox1.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Process proc = Process.GetProcessesByName("school management")[0];
                proc.Kill();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            System.IO.File.Copy(textBox1.Text + "\\data.mdb", ".\\data.mdb", true);
            NetworkTransfer.Properties.Settings.Default.Save();
            Process.Start(Application.StartupPath+"\\school management.exe");
            
        }
    }
}
