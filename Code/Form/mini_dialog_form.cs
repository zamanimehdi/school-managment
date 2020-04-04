using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Student
{
    public partial class frm_mini_dialog : StyledForms.GoogleTalkForm
    {
        string str;
        public frm_mini_dialog()
        {
            InitializeComponent();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            result = textBox1.Text;
        }
        public string result
        {
            get
            {
                return str;
            }
            set
            {
                str = value;
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ok.Focus();
        }

        private void frm_mini_dialog_Load(object sender, EventArgs e)
        {
            textBox1.Text = str;
        }
    }
}