using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Student
{
    public partial class frm_proces : Form
    {
        public frm_proces()
        {
            InitializeComponent();
        }
        private void frm_proces_Load(object sender, EventArgs e)
        {
            progressRoller1.Run("... لطفا صبر کنید");
            progressRoller1.Refresh();
        }
    }
}