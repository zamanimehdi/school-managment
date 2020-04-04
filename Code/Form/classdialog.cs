using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Student
{
    public partial class frm_classdialog : StyledForms.GoogleTalkForm
    {
        string classnamex;
        int idmajorx;
        int gradex;
        string majornamex;
        public double vahed;
        public frm_classdialog()
        {
            InitializeComponent();
        }
        private void classdialog_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds_classdialog.major' table. You can move, or remove it, as needed.
            this.majorTableAdapter.Fill(this.ds_classdialog.major);
            string str = Student.Properties.Settings.Default.schooltype;
            switch (str)
            {
                case "نظری":
                    cmb_grade.Items.Add("پایه اول");
                    cmb_grade.Items.Add("پایه دوم");
                    cmb_grade.Items.Add("پایه سوم");
                    cmb_grade.Items.Add("پیش دانشگاهی");
                    break;
                case "فنی و حرفه ای":
                case "کار دانش":
                    cmb_grade.Items.Add("پایه دوم");
                    cmb_grade.Items.Add("پایه سوم");
                    break;
                case "ابتدایی":
                    cmb_grade.Items.Add("پایه اول");
                    cmb_grade.Items.Add("پایه دوم");
                    cmb_grade.Items.Add("پایه سوم");
                    cmb_grade.Items.Add("پایه چهارم");
                    cmb_grade.Items.Add("پایه پنجم");
                    cmb_grade.Items.Add("پایه ششم");
                    break;
                case "متوسطه اول":
                    cmb_grade.Items.Add("-");
                    cmb_grade.Items.Add("-");
                    cmb_grade.Items.Add("-");
                    cmb_grade.Items.Add("-");
                    cmb_grade.Items.Add("-");
                    cmb_grade.Items.Add("-");
                    cmb_grade.Items.Add("پایه هفتم");
                    cmb_grade.Items.Add("پایه هشتم");
                    cmb_grade.Items.Add("پایه نهم");
                    break;
                case "متوسطه دوم":
                    cmb_grade.Items.Add("-");
                    cmb_grade.Items.Add("-");
                    cmb_grade.Items.Add("-");
                    cmb_grade.Items.Add("-");
                    cmb_grade.Items.Add("-");
                    cmb_grade.Items.Add("-");
                    cmb_grade.Items.Add("-");
                    cmb_grade.Items.Add("-");
                    cmb_grade.Items.Add("-");

                    cmb_grade.Items.Add("پایه دهم");
                    cmb_grade.Items.Add("پایه یازدهم");
                    cmb_grade.Items.Add("پایه دوازدهم");
                    break;
                default:
                    MessageBox.Show("first");
                    break;
            }
            //cmb_grade.SelectedIndex = 0;
            txt_classname.Text = classname;
            if (Student.Properties.Settings.Default.schooltype == "کار دانش" || Student.Properties.Settings.Default.schooltype == "فنی و حرفه ای")
                try { cmb_grade.SelectedIndex = Int32.Parse(grade) - 2; }
                catch
                {
                }
            else
                cmb_grade.SelectedIndex = Int32.Parse(grade) - 1;
            cmb_major.Text = majorname;
        }
        public string classname
        {
            set
            {
                classnamex = value;
            }
            get
            {
                return classnamex;
            }
        }
        public string idmajor
        {
            set
            {
                idmajorx = Int32.Parse(value);
            }
            get
            {
                return idmajorx.ToString();
            }
        }
        public string majorname
        {
            set
            {
                majornamex = value;
            }
            get
            {
                return majornamex;
            }
        }
        public string grade
        {
            set
            {
                gradex = Int32.Parse(value);
            }
            get
            {
                return gradex.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            can test = new can();
            if (test.checkempty(txt_classname, cmb_grade, cmb_major))
            {
                if (lbl_vahed.Visible == true)
                {
                    if (test.checkempty(txt_vahed))
                    {
                        try
                        {
                            vahed = Convert.ToDouble(txt_vahed.Text);
                        }
                        catch { }
                    }
                    else
                    {
                        MessageBox.Show("اطلاعات کامل نمی باشد");
                        return;
                    }
                }
                classname = txt_classname.Text;
                majornamex = cmb_major.Text;
                idmajorx = Int32.Parse(cmb_major.SelectedValue.ToString());
                /*switch (cmb_grade.Text)
                {
                    case "پایه اول": gradex = 1;
                        break;
                    case "پایه دوم": gradex = 2;
                        break;
                    case "پایه سوم": gradex = 3;
                        break;
                    case "پیش دانشگاهی": gradex = 4;
                        break;
                }*/

                gradex = cmb_grade.SelectedIndex + 1;
                DialogResult = DialogResult.OK;
               Opacity = 0; Close();
            }
            else
                MessageBox.Show("اطلاعات کامل نمی باشد");
        }
        private void txt_classname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                this.SelectNextControl(((Control)sender), true, true, true, true);
            }
        }

        private void cmb_grade_SelectedIndexChanged(object sender, EventArgs e)
        {
          /*  if (cmb_grade.Text == "پایه اول")
            {
                cmb_major.Enabled = false;
                cmb_major.BackColor = Color.Empty;
                cmb_major.Text = "عمومی";
                cmb_major.Refresh();
            }
            else
                cmb_major.Enabled = true;*/
        }
    }
}