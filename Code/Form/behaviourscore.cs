using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Student
{
    public partial class frm_behaviourscore : Form
    {
        public frm_behaviourscore()
        {
            InitializeComponent();
        }

        private void behaviourscore_Load(object sender, EventArgs e)
        {
            textBox1.Text = Student.Properties.Settings.Default.behav_scor_1.ToString();
            textBox2.Text = Student.Properties.Settings.Default.behav_scor_2.ToString();
            textBox3.Text = Student.Properties.Settings.Default.behav_scor_3.ToString();
            textBox4.Text = Student.Properties.Settings.Default.behav_scor_4.ToString();
            textBox5.Text = Student.Properties.Settings.Default.behav_scor_5.ToString();
            textBox6.Text = Student.Properties.Settings.Default.behav_scor_6.ToString();
            textBox7.Text = Student.Properties.Settings.Default.behav_scor_7.ToString();
            textBox8.Text = Student.Properties.Settings.Default.behav_scor_8.ToString();
            textBox9.Text = Student.Properties.Settings.Default.behav_scor_9.ToString();
            textBox10.Text = Student.Properties.Settings.Default.behav_scor_10.ToString();
            textBox11.Text = Student.Properties.Settings.Default.behav_scor_11.ToString();
            textBox12.Text = Student.Properties.Settings.Default.behav_scor_12.ToString();

            textBox13.Text = Student.Properties.Settings.Default.behav_scor_13.ToString();
            textBox14.Text = Student.Properties.Settings.Default.behav_scor_14.ToString();
            textBox15.Text = Student.Properties.Settings.Default.behav_scor_15.ToString();
            textBox16.Text = Student.Properties.Settings.Default.behav_scor_16.ToString();
            textBox17.Text = Student.Properties.Settings.Default.behav_scor_17.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Student.Properties.Settings.Default.behav_scor_1 = Convert.ToDouble(textBox1.Text);
                Student.Properties.Settings.Default.behav_scor_2 = Convert.ToDouble(textBox2.Text);
                Student.Properties.Settings.Default.behav_scor_3 = Convert.ToDouble(textBox3.Text);
                Student.Properties.Settings.Default.behav_scor_4 = Convert.ToDouble(textBox4.Text);
                Student.Properties.Settings.Default.behav_scor_5 = Convert.ToDouble(textBox5.Text);
                Student.Properties.Settings.Default.behav_scor_6 = Convert.ToDouble(textBox6.Text);
                Student.Properties.Settings.Default.behav_scor_7 = Convert.ToDouble(textBox7.Text);
                Student.Properties.Settings.Default.behav_scor_8 = Convert.ToDouble(textBox8.Text);
                Student.Properties.Settings.Default.behav_scor_9 = Convert.ToDouble(textBox9.Text);
                Student.Properties.Settings.Default.behav_scor_10 = Convert.ToDouble(textBox10.Text);
                Student.Properties.Settings.Default.behav_scor_11 = Convert.ToDouble(textBox11.Text);
                Student.Properties.Settings.Default.behav_scor_12 = Convert.ToDouble(textBox12.Text);

                Student.Properties.Settings.Default.behav_scor_13 = Convert.ToDouble(textBox13.Text);
                Student.Properties.Settings.Default.behav_scor_14 = Convert.ToDouble(textBox14.Text);
                Student.Properties.Settings.Default.behav_scor_15 = Convert.ToDouble(textBox15.Text);
                Student.Properties.Settings.Default.behav_scor_16 = Convert.ToDouble(textBox16.Text);
                Student.Properties.Settings.Default.behav_scor_17 = Convert.ToDouble(textBox17.Text);
                Student.Properties.Settings.Default.Save();
                Close();
            }
            catch
            {
                MessageBox.Show("خطا در ورود اطلاعات");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}