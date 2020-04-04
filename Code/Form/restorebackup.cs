using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Student
{
    public partial class frm_restorebackup : Form
    {
        string pathbackup;
        public frm_restorebackup(string str)
        {
            pathbackup = str;
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.pass == txt_pass.Text)
            {
                try
                {
                    System.IO.File.Copy(pathbackup, Application.StartupPath + "\\data.mdb", true);
                    System.IO.File.SetAttributes(Application.StartupPath + "\\data.mdb", System.IO.FileAttributes.Normal);
                    lbl_messeage.Visible = true;
                    btn_exit.Visible = true;
                    btn_no.Visible = false;
                    btn_ok.Visible = false;
                }
                catch (ArgumentException)
                {}
            }
            else
            {
                MessageBox.Show("رمز اشتباه می باشد");
                txt_pass.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           Opacity = 0; Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           Opacity = 0; Close();
        }

        private void frm_restorebackup_Load(object sender, EventArgs e)
        {

        }
        private void nextcontrol(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1_Click(null, null);
        }
   
    }
}