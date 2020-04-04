using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Student
{
    public partial class frm_student_av_list : Form
    {
        public frm_student_av_list()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void frm_student_av_list_Load(object sender, EventArgs e)
        {
            this.majorTableAdapter.Fill(this.ds_paye_av_list.major);
            this.classTableAdapter.Fill(this.ds_class._class);
            try
            {
                comboBox2.SelectedIndex = 0;
                comboBox3.SelectedIndex = 0;
            }
            catch
            {
                MessageBox.Show("در حال حاضر امکان تهیه این گزارش وجود ندارد");
                Close();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            can cano = new can();
            if (radioButton1.Checked)
            {
                if (comboBox1.Text != "" & (txt_datef.Text != "" ? cano.isdate(txt_datef) : true) & (txt_datet.Text != "" ? cano.isdate(txt_datet) : true))
                {
                    double max, min, av;
                    DataSet.ds_studentbyclass ds_datasetave = new Student.DataSet.ds_studentbyclass();
                    BindingSource bs;
                    max = -1;
                    min = 25;
                    av = 0;
                    int i = 0; string str = "";
                    string datef = (txt_datef.Text == "" ? "0" : txt_datef.Text);
                    string datet = (txt_datet.Text == "" ? "999999" : txt_datet.Text);
                    if (datef != "0" || datet != "999999")
                    {
                        if (datef != "0") str += " از تاریخ " + datef;
                        if (datet != "999999") str += " تا تاریخ " + datet;
                    }
                    if (datef != "0") datef = Convert.ToString(Int32.Parse(datef) - 1);
                    if (datet != "999999") datet = Convert.ToString(Int32.Parse(datet) + 1);
                    DataSet.ds_studentbyclassTableAdapters.moadelkolTableAdapter moadelkol = new Student.DataSet.ds_studentbyclassTableAdapters.moadelkolTableAdapter();
                    DataSet.ds_studentbyclassTableAdapters.sumvahedtbTableAdapter sumvahed = new Student.DataSet.ds_studentbyclassTableAdapters.sumvahedtbTableAdapter();
                    DataSet.ds_studentbyclassTableAdapters.zarbshodetbTableAdapter zarbshode = new Student.DataSet.ds_studentbyclassTableAdapters.zarbshodetbTableAdapter();
                    moadelkol.Fill(ds_datasetave.moadelkol, (Int32)comboBox1.SelectedValue);
                    foreach (DataRow row in ds_datasetave.moadelkol.Rows)
                    {
                        i++;
                        progressBar1.Value = (100 * i) / ds_datasetave.moadelkol.Rows.Count;
                        sumvahed.Fill(ds_datasetave.sumvahedtb, Int32.Parse(row["idstudent"].ToString()), datef, datet);
                        zarbshode.Fill(ds_datasetave.zarbshodetb, Int32.Parse(row["idstudent"].ToString()), datef, datet);
                        double temp;
                        if (ds_datasetave.zarbshodetb.Rows.Count != 0)
                        {
                            temp = double.Parse(ds_datasetave.zarbshodetb.Rows[0][1].ToString()) / double.Parse(ds_datasetave.sumvahedtb.Rows[0][1].ToString());
                            if (max < temp) max = temp;
                            if (min > temp) min = temp;
                            av += temp;
                            row["moadelkol"] = Convert.ToString(temp);
                        }
                    }
                    bs = new BindingSource(ds_datasetave, "moadelkol");
                    av = av / ds_datasetave.moadelkol.Rows.Count;
                    bs.Sort = "moadelkol DESC";
                    frm_preview pre = new frm_preview();
                    pre.setdt = ((DataView)bs.List).ToTable();
                    Properties.Settings.Default.tempstr = comboBox1.Text.ToString();
                    pre.Reportsource = "stu_av";
                    pre.strhead = str;
                    pre.ShowDialog();
                    progressBar1.Value = 0;
                }
            }
            else
            {
                if (comboBox3.Text == "") return;
                string startdate = "000000";
                string enddate = "999999";
                if ((textBox1.Text != "" ? cano.isdate(textBox1) : true) & (textBox2.Text != "" ? cano.isdate(textBox2) : true))
                {
                    //AND (test.idlesson = 114
                    string str_add_sql = "";
                    string lesson_names = "";
                    int tmpcount=0;
                    for (int index = 0; index < dataGridView2.RowCount; index++)
                    {
                        if ((bool)dataGridView2[0, index].Value == true)
                        {
                            tmpcount++;
                            str_add_sql += "test.idlesson =" + dataGridView2[1, index].Value.ToString() + " or ";
                            lesson_names += dataGridView2[2, index].Value.ToString() + " ، ";
                        }
                    }
                    if (tmpcount == dataGridView2.RowCount) lesson_names = "تمامی دروس";
                    if (str_add_sql.Length != 0)
                    {
                        str_add_sql = str_add_sql.Substring(0, str_add_sql.Length - 3);
                        str_add_sql = " and (" + str_add_sql + ")";
                    }
                    else
                    {
                        MessageBox.Show("حداقل یک درس باید انتخاب شود");
                        return;
                    }
                    if (textBox1.Text != "") startdate = textBox1.Text;
                    if (textBox2.Text != "") enddate = textBox2.Text;
                    string selectcomd = @"SELECT        SUM(scoresum * vahed) / SUM(vahed) AS miangin, derivedtbl_1.idstudent, derivedtbl_2.name AS classname, student_1.name AS stu_name, 
                        student_1.lname AS stu_lname, student_1.fname
                        FROM            (((SELECT        AVG(score.score) AS scoresum, test.idlesson, score.idstudent, lesson.vahed
                        FROM            ((score INNER JOIN
                        test ON score.idtest = test.idtest) INNER JOIN
                        lesson ON test.idlesson = lesson.idlesson)
                        WHERE        (test.[date] > '" + startdate + @"') AND (test.[date] < '" + enddate + @"') "+ str_add_sql+
                        @"GROUP BY test.idlesson, score.idstudent, lesson.vahed) derivedtbl_1 INNER JOIN
                        (SELECT        student.idstudent, class.grade, class.name, class.idmajor
                        FROM            (student LEFT OUTER JOIN
                        class ON student.idclass = class.idclass)) derivedtbl_2 ON derivedtbl_1.idstudent = derivedtbl_2.idstudent) INNER JOIN
                        student student_1 ON derivedtbl_1.idstudent = student_1.idstudent)
                        GROUP BY derivedtbl_1.idstudent, derivedtbl_2.grade, derivedtbl_2.name, student_1.name, student_1.lname, student_1.fname, derivedtbl_2.idmajor
                        HAVING        (derivedtbl_2.grade = " + Convert.ToString((int)comboBox2.SelectedIndex + 1) + @") AND (derivedtbl_2.idmajor = " + comboBox3.SelectedValue.ToString() + @")
                        ORDER BY SUM(scoresum * vahed) / SUM(vahed) DESC";

                    System.Data.OleDb.OleDbDataAdapter da = new System.Data.OleDb.OleDbDataAdapter(selectcomd, dt_grade_av_listTableAdapter.Connection);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    frm_preview pre = new frm_preview();
                    pre.setdt = dt;
                    pre.Reportsource = "grade_av_list";
                    pre.strhead = comboBox2.Text;
                    pre.strtmp = lesson_names;
                    pre.teachername = comboBox3.Text;
                    if (textBox1.Text.Length == 6 && textBox2.Text.Length == 6)
                        pre.teachername = "از تاریخ " + textBox1.Text.Insert(2, "/").Insert(5, "/") + " تا " + textBox2.Text.Insert(2, "/").Insert(5, "/");
                    if (textBox1.Text.Length == 6 && textBox2.Text.Length != 6)
                        pre.teachername = "از تاریخ " + textBox1.Text.Insert(2, "/").Insert(5, "/");
                    if (textBox1.Text.Length != 6 && textBox2.Text.Length == 6)
                        pre.teachername = "از ابتدای سال تحصیلی تا  " + textBox2.Text.Insert(2, "/").Insert(5, "/");

                    pre.ShowDialog();
                    progressBar1.Value = 0;
                }
                else
                {
                    MessageBox.Show("تاریخ اشتباه وارد شده است" + "\r\n" + "مثال 890101");
                }

            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void txt_datef_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txt_datet.Focus();
        }
        private void txt_datet_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1.Focus();
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                groupBox1.Enabled = true;
                groupBox3.Enabled = false;
            }
            else
            {
                groupBox1.Enabled = !true;
                groupBox3.Enabled = !false;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lessonTableAdapter.Fill(ds_class.lesson, int.Parse(comboBox3.SelectedValue.ToString()), Convert.ToByte(comboBox2.SelectedIndex + 1));
                for (int i = 0; i < dataGridView2.RowCount; i++)
                    dataGridView2[0, i].Value = true;
            }
            catch
            { }
        }

    }
}