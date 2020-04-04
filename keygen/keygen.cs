using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace keygen
{
    public partial class keygen : Form
    {
        public keygen()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double s=0;
            foreach (char ch in txt_name.Text.ToString())
            {
                s+=((double)ch)*2+s;
            }
            s += 2291602;
            txt_key.Text = s.ToString() + "584";         
        }
    }
}