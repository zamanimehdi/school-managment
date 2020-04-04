using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Student
{
    public partial class frm_db : Form
    {
        public frm_db()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                if (radioButton1.Checked)
                {
                    string ypath = Application.ExecutablePath.ToString().Substring(0, Application.ExecutablePath.ToString().Length - 21);
                    try
                    {
                        System.IO.File.Copy(ypath + "null.mdb", ypath + "\\years\\" + textBox3.Text + ".mdb", false);
                    }
                    catch
                    { MessageBox.Show("فایل ریست کننده دیتابیس پیدا نشده است. برنامه را مجددا نصب نمایید"); }
                    if (Student.Properties.Settings.Default.db == "")
                        Student.Properties.Settings.Default.db = textBox3.Text;
                    Close();
                }
                else
                {
                    if (System.IO.File.Exists(textBox2.Text))
                    {
                        string ypath = Application.ExecutablePath.ToString().Substring(0, Application.ExecutablePath.ToString().Length - 21);
                        System.IO.File.Copy(textBox2.Text, ypath + "\\years\\" + textBox3.Text + ".mdb", false);
                        if (Student.Properties.Settings.Default.db == "")
                            Student.Properties.Settings.Default.db = textBox3.Text;
                        Close();
                    }
                    else MessageBox.Show("فايل وجود ندارد");
                }
            }
            else MessageBox.Show("اسم ديتابيس انتخاب نشده است");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = false;
            ofd.Filter = "smb file|*.smb";
            ofd.ShowDialog();
            textBox2.Text = ofd.FileName;
        }
    }
}
