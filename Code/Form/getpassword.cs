using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Student
{
    public partial class frm_getpassword : Form
    {
        public frm_getpassword()
        {
            InitializeComponent();
        }
        private void nextcontrol(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_ok_Click(null, null);
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
        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (txt_passbefore.Text == Properties.Settings.Default.pass)
            {
                DialogResult = DialogResult.OK;
               Opacity = 0; Close();
            }
            else
            {
                txt_passbefore.Clear();
                MessageBox.Show("رمز اشتباه می باشد");
            }
        }
        private void btn_exit_click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Ignore;
           Opacity = 0; Close();
        }
        private void frm_getpassword_Shown(object sender, EventArgs e)
        {
            Refresh();
            Opacity = 1;
            Refresh();
            //Activate();
            txt_passbefore.Focus();
        }

        private void frm_getpassword_Deactivate(object sender, EventArgs e)
        {
            Activate();
        }
    }
}