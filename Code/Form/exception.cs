using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Student
{
    public partial class frm_exception : Form
    {
        public frm_exception(String str)
        {
            InitializeComponent();
            textBox1.Text = str;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           Opacity = 0; Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.CheckFileExists = false;
            sfd.Filter = "Text files (*.sme)|*.sme";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamWriter sw = new System.IO.StreamWriter(sfd.FileName);
                sw.Write(textBox1.Text);
                sw.Close();
            }
        }
    }
}