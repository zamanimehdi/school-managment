using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Student
{
    public partial class frm_arm : Form
    {
        public frm_arm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr= openFileDialog1.ShowDialog();
            if (dr==DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
                try
                {
                    pictureBox1.ImageLocation = openFileDialog1.FileName;
                }
                catch
                {
                    MessageBox.Show("تصویر انتخابی شما سازگار با برنامه نمی باشد");

                }
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Student.Properties.Settings.Default.Save();
            Close();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frm_arm_Load(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.ImageLocation = Student.Properties.Settings.Default.armlocation;
            }
            catch
            {
            }
        }
    }
}
