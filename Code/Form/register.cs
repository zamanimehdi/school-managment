using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Student
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Rcount = 1;
            if (button2.Text == "ادامه")
            {
                DialogResult = DialogResult.Retry;
            }
            else
            {
                DialogResult = DialogResult.Ignore;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.schoolname = textBox2.Text;
            string schoolname = Properties.Settings.Default.schoolname;
            double s = 0;
            foreach (char ch in schoolname)
            {
                s += ((double)ch) * 2 + s;
            }
            s += 2291602;
            if (textBox1.Text == (s.ToString() + "584"))
            {
                Properties.Settings.Default.Rcount = -1;
                MessageBox.Show("برنامه با موفقیت ثبت شد");
                string strpath = System.IO.Path.GetTempPath();
                string[] strar = strpath.Split(char.Parse("\\"));
                strpath = strar[0] + "\\" + strar[1] + "\\";
                try
                {
                    System.IO.File.SetAttributes(strpath + "setting.ini", System.IO.FileAttributes.Normal);
                    System.IO.File.WriteAllText(strpath + "setting.ini", s.ToString() + "584");
                    System.IO.File.SetAttributes(strpath + "setting.ini", System.IO.FileAttributes.System);
                    System.IO.File.SetAttributes(strpath + "setting.ini", System.IO.FileAttributes.Hidden);
                }
                catch { MessageBox.Show("برای ثبت برنامه ، می بایست برنامه در حالت مدیر ارشد اجرا گردد"); Properties.Settings.Default.Rcount = 1; }
                Properties.Settings.Default.Save();
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("رمز اشتباه می باشد");
                Properties.Settings.Default.Save();
                textBox1.Clear();
            }
        }

        private void register_Load(object sender, EventArgs e)
        {
            textBox2.Text=Properties.Settings.Default.schoolname;
            try
            {
                string strpath = System.IO.Path.GetTempPath();
                string[] strar = strpath.Split(char.Parse("\\"));
                strpath = strar[0] + "\\" + strar[1] + "\\";
                string read;
                if (System.IO.File.Exists(strpath + "setting.ini"))
                {

                    read = System.IO.File.ReadAllText(strpath + "setting.ini");
                    if (read.Length > 2 || Int32.Parse(read) == 0)
                    {
                        Height = 164;
                        button2.Text = "خروج";
                    }
                }
            }
            catch
            {}
        }
    }
}