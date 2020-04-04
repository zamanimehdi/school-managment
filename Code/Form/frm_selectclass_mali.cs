using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Student
{
    public partial class frm_selectclass_mali : Form
    {
        public frm_selectclass_mali()
        {
            InitializeComponent();
        }
        private void frm_selectclass_mali_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds_class._class' table. You can move, or remove it, as needed.
            this.classTableAdapter.Fill(this.ds_class._class);

        }
    }
}
