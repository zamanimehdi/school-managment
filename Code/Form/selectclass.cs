using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Student
{
    public partial class frm_selectclass : Form
    {
        public string usefor = "";
        public frm_selectclass()
        {
            InitializeComponent();
        }
        private void selectclass_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds_class._class' table. You can move, or remove it, as needed.
            this.classTableAdapter.Fill(this.ds_class._class);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            can cano = new can();
            if (comboBox1.Text != "" & (txt_datef.Text != "" ? cano.isdate(txt_datef) : true) & (txt_datet.Text != "" ? cano.isdate(txt_datet) : true))
            {
                behaviorBindingSource.Filter = "";
                can c = new can();
                if (txt_datef.Text != "") if (!c.isdate(txt_datef)) return;
                if (txt_datet.Text != "") if (!c.isdate(txt_datet)) return;
                string str = "نمايش موارد انضباطي ";
                string behavscore = "";
                str += " کلاس " + comboBox1.Text;
                string dfrom = txt_datef.Text;
                string dto = txt_datet.Text;
                str += "  ";
                if (dto != "" || dfrom != "")
                {
                    if (dfrom == "")
                    {
                        dfrom = "000000";
                    }
                    else str += " از تاریخ " + dfrom;
                    if (dto == "")
                    {
                        dto = "999999";
                    }
                    else str += " تا تاریخ " + dto;
                }
                if (dto == "") dto = "999999";
                if (dfrom == "") dfrom = "000000";

                if (rb_all.Checked)
                {
                    behaviorTableAdapter.Fill(dsp_behavclass.behavior, (Int32)comboBox1.SelectedValue,dfrom,dto);
                    str += "--  ";
                    str += "نمایش تمامی موارد انضباطی";
                    stTableAdapter.Fill(dsp_behavclass.st, comboBox1.Text);
                    for (int i=0;i<dsp_behavclass.st.Count;i++)
                    {
                        DataRow dr=dsp_behavclass.st[i];
                        behaviorBindingSource.Filter = "typeb=0 and idstudent=" + dr[0].ToString();
                        int t1 = behaviorBindingSource.Count;
                        behaviorBindingSource.Filter = "typeb=1 and idstudent=" + dr[0].ToString();
                        int t2 = behaviorBindingSource.Count;
                        behaviorBindingSource.Filter = "typeb=2 and idstudent=" + dr[0].ToString();
                        int t3 = behaviorBindingSource.Count;
                        behaviorBindingSource.Filter = "typeb=3 and idstudent=" + dr[0].ToString();
                        int t4 = behaviorBindingSource.Count;
                        behaviorBindingSource.Filter = "typeb=4 and idstudent=" + dr[0].ToString();
                        int t5 = behaviorBindingSource.Count;
                        behaviorBindingSource.Filter = "typeb=5 and idstudent=" + dr[0].ToString();
                        int t6 = behaviorBindingSource.Count;
                        behaviorBindingSource.Filter = "typeb=6 and idstudent=" + dr[0].ToString();
                        int t7 = behaviorBindingSource.Count;
                        behaviorBindingSource.Filter = "typeb=7 and idstudent=" + dr[0].ToString();
                        int t8 = behaviorBindingSource.Count;

                        behaviorBindingSource.Filter = "typeb=8 and idstudent=" + dr[0].ToString();
                        int t9 = behaviorBindingSource.Count;
                        behaviorBindingSource.Filter = "typeb=9 and idstudent=" + dr[0].ToString();
                        int t10 = behaviorBindingSource.Count;
                        behaviorBindingSource.Filter = "typeb=10 and idstudent=" + dr[0].ToString();
                        int t11 = behaviorBindingSource.Count;
                        behaviorBindingSource.Filter = "typeb=11 and idstudent=" + dr[0].ToString();
                        int t12 = behaviorBindingSource.Count;

                        behaviorBindingSource.Filter = "typeb=12 and idstudent=" + dr[0].ToString();
                        int t13 = behaviorBindingSource.Count;
                        behaviorBindingSource.Filter = "typeb=13 and idstudent=" + dr[0].ToString();
                        int t14 = behaviorBindingSource.Count;
                        behaviorBindingSource.Filter = "typeb=14 and idstudent=" + dr[0].ToString();
                        int t15 = behaviorBindingSource.Count;
                        behaviorBindingSource.Filter = "typeb=15 and idstudent=" + dr[0].ToString();
                        int t16 = behaviorBindingSource.Count;
                        behaviorBindingSource.Filter = "typeb=16 and idstudent=" + dr[0].ToString();
                        int t17 = behaviorBindingSource.Count;

                        double z1 = double.Parse(Student.Properties.Settings.Default.behav_scor_1.ToString());
                        double z2 = double.Parse(Student.Properties.Settings.Default.behav_scor_2.ToString());
                        double z3 = double.Parse(Student.Properties.Settings.Default.behav_scor_3.ToString());
                        double z4 = double.Parse(Student.Properties.Settings.Default.behav_scor_4.ToString());
                        double z5 = double.Parse(Student.Properties.Settings.Default.behav_scor_5.ToString());
                        double z6 = double.Parse(Student.Properties.Settings.Default.behav_scor_6.ToString());
                        double z7 = double.Parse(Student.Properties.Settings.Default.behav_scor_7.ToString());
                        double z8 = double.Parse(Student.Properties.Settings.Default.behav_scor_8.ToString());

                        double z9 = double.Parse(Student.Properties.Settings.Default.behav_scor_9.ToString());
                        double z10 = double.Parse(Student.Properties.Settings.Default.behav_scor_10.ToString());
                        double z11 = double.Parse(Student.Properties.Settings.Default.behav_scor_11.ToString());
                        double z12 = double.Parse(Student.Properties.Settings.Default.behav_scor_12.ToString());

                        double z13 = double.Parse(Student.Properties.Settings.Default.behav_scor_13.ToString());
                        double z14 = double.Parse(Student.Properties.Settings.Default.behav_scor_14.ToString());
                        double z15 = double.Parse(Student.Properties.Settings.Default.behav_scor_15.ToString());
                        double z16 = double.Parse(Student.Properties.Settings.Default.behav_scor_16.ToString());
                        double z17 = double.Parse(Student.Properties.Settings.Default.behav_scor_17.ToString());
                        double sumb = t1 * z1 + t2 * z2 + t3 * z3 + t4 * z4 + t5 * z5 + t6 * z6 + t7 * z7 + t8 * z8 + t9 * z9 + t10 * z10 + t11 * z11 + t12 * z12
                            + t13 * z13 + t14 * z14 + t15 * z15 + t16 * z16 + t17 * z17;
                        sumb = 20 - sumb;
                        behavscore = sumb.ToString().Replace('.', '/');
                        dsp_behavclass.st[i]["score"] = behavscore;
                    }
                }
                else 
                {
                    stTableAdapter.Fill(dsp_behavclass.st, comboBox1.Text);
                    behaviorTableAdapter.Fillakhlaghi(dsp_behavclass.behavior, (Int32)comboBox1.SelectedValue, (decimal)cmb_b.SelectedIndex, dfrom, dto);
                    str += "--  " + "نمایش مورد انضباطی " + cmb_b.Text;
                }



                frm_preview pre = new frm_preview();
                System.Data.DataSet ds = new System.Data.DataSet();
                behaviorBindingSource.Filter = "";
                ds.Tables.Add(((DataView)behaviorBindingSource.List).ToTable());
                ds.Tables.Add(((DataView)stBindingSource.List).ToTable());
                pre.ds = ds;
                pre.Reportsource = "behavclasss";
                Properties.Settings.Default.tempstr = str;
                pre.ShowDialog();
            }
        }
        private void nextcontrol(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }
        private void leavecolor(object sender, EventArgs e)
        {
            if (((Control)sender).BackColor != Color.LightPink)
                ((Control)sender).BackColor = Color.Empty;
        }
        private void entercolor(object sender, EventArgs e)
        {
            ((Control)sender).BackColor = Color.SeaShell;
        }

    }
}