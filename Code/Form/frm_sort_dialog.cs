using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Student
{
    public partial class frm_sort_dialog : Form
    {
        public frm_sort_dialog()
        {
            InitializeComponent();
        }
        public string res = "lname";
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked) res = "id";
            DialogResult = DialogResult.OK;
        }
    }
}
