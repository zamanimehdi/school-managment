using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Student
{
    public partial class frm_setpassword : Form
    {
        public frm_setpassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_passbefore.Text == Properties.Settings.Default.pass)
            {
                if (txt_newpass1.Text == txt_newpass2.Text)
                {
                    Properties.Settings.Default.pass = txt_newpass1.Text;
                    Properties.Settings.Default.Save();
                   Opacity = 0; Close();
                }
                else
                {
                    MessageBox.Show("رمز عبور را اشتباه وارد کردید");
                    txt_newpass1.Clear();
                    txt_newpass2.Clear();
                    txt_newpass1.Focus();
                }
            }
            else
            {
                MessageBox.Show("رمز قبلی اشتباه می باشد");
            }
        }
        private void nextcontrol(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }
        private void leavecolor(object sender, EventArgs e)
        {
            if (((Control)sender).BackColor != Color.LightPink)
                ((Control)sender).BackColor = Color.Empty;
        }
        private void entercolor(object sender, EventArgs e)
        {
            ((Control)sender).BackColor = Color.SeaShell;
        }

        private void setpassword_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.pass == "") txt_passbefore.Enabled = false;
        }
    }
}