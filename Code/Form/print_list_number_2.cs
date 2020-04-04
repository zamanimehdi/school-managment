using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Student
{
    public partial class print_list_number_2 : Form
    {
        public print_list_number_2()
        {
            InitializeComponent();
        }
        private void print_list_number_Load(object sender, EventArgs e)
        {
            this.studentTableAdapter.Fill(this.dsp_list_number2.student);
            this.classTableAdapter.Fill(this.dsp_list_number2._class);
        }
        private void btn_preview_Click(object sender, EventArgs e)
        {
            if (cmb_class.SelectedValue == null) return;
            /////// find select idlessen 
            string stridlesson = "";
            for (int i = 0; i < dataGridView2.RowCount; i++)
                if (dataGridView2[0, i].Value!=null)
                    if (dataGridView2[0, i].Value.ToString() == "True")
                    {
                        stridlesson += dataGridView2[1, i].Value.ToString() + ".00 ";
                    }
            /////////////////////////////
            can cano = new can();
            if ((d1.Text == "" || cano.isdate(d1)) && (d2.Text == "" || cano.isdate(d2)))
            {
                frm_preview pre = new frm_preview();
                pre.array_param = new object[12];
                string start = "000000";
                string end = "999999";
                if (d1.Text != "") start = d1.Text;
                if (d2.Text != "") end = d2.Text;
                System.Collections.ArrayList al = new System.Collections.ArrayList();
                int indexparam = 0;
                for (int i = 0; i < dataGridView1.RowCount; i++)
                    if (dataGridView1[0, i].Value.ToString() == "True")
                    {
                        al.Add(dataGridView1[1, i].Value);
                        if (indexparam <= 9)
                            pre.array_param[indexparam++] = dataGridView1[3, i].Value.ToString();
                    }
                for (int j = al.Count; j < 10; j++)
                {
                    al.Add(-1);
                    pre.array_param[j] = "- - -";
                }

                /////////////////////////////////////
                string cmd = @"SELECT        test.idtest, lesson.name as lessonname, test.idlesson, test.idclass, derivedtbl_1.score, derivedtbl_2.score AS Expr1, derivedtbl_3.score AS Expr2, derivedtbl_4.score AS Expr3, 
                         derivedtbl_5.score AS Expr4, derivedtbl_6.score AS Expr5, derivedtbl_7.score AS Expr6, derivedtbl_8.score AS Expr7, derivedtbl_9.score AS Expr8, 
                         derivedtbl_10.score AS Expr9, test.[date]
                         FROM            (((((((((((test INNER JOIN
                         lesson ON test.idlesson = lesson.idlesson) LEFT OUTER JOIN
                             (SELECT        test_5.idtest, score_4.score
                               FROM            (score score_4 LEFT OUTER JOIN
                                                         test test_5 ON score_4.idtest = test_5.idtest)
                               WHERE        (score_4.idstudent = " + al[4].ToString() + @")
                               GROUP BY test_5.idtest, score_4.score) derivedtbl_5 ON test.idtest = derivedtbl_5.idtest) LEFT OUTER JOIN
                             (SELECT        test_8.idtest, score_7.score
                               FROM            (score score_7 LEFT OUTER JOIN
                                                         test test_8 ON score_7.idtest = test_8.idtest)
                               WHERE        (score_7.idstudent = " + al[7].ToString() + @")
                               GROUP BY test_8.idtest, score_7.score) derivedtbl_8 ON test.idtest = derivedtbl_8.idtest) LEFT OUTER JOIN
                             (SELECT        test_10.idtest, score_9.score
                               FROM            (score score_9 LEFT OUTER JOIN
                                                         test test_10 ON score_9.idtest = test_10.idtest)
                               WHERE        (score_9.idstudent = " + al[9].ToString() + @")
                               GROUP BY test_10.idtest, score_9.score) derivedtbl_10 ON test.idtest = derivedtbl_10.idtest) LEFT OUTER JOIN
                             (SELECT        test_9.idtest, score_8.score
                               FROM            (score score_8 LEFT OUTER JOIN
                                                         test test_9 ON score_8.idtest = test_9.idtest)
                               WHERE        (score_8.idstudent = " + al[8].ToString() + @")
                               GROUP BY test_9.idtest, score_8.score) derivedtbl_9 ON test.idtest = derivedtbl_9.idtest) LEFT OUTER JOIN
                             (SELECT        test_7.idtest, score_6.score
                               FROM            (score score_6 LEFT OUTER JOIN
                                                         test test_7 ON score_6.idtest = test_7.idtest)
                               WHERE        (score_6.idstudent = " + al[6].ToString() + @")
                               GROUP BY test_7.idtest, score_6.score) derivedtbl_7 ON test.idtest = derivedtbl_7.idtest) LEFT OUTER JOIN
                             (SELECT        test_6.idtest, score_5.score
                               FROM            (score score_5 LEFT OUTER JOIN
                                                         test test_6 ON score_5.idtest = test_6.idtest)
                               WHERE        (score_5.idstudent = " + al[5].ToString() + @")
                               GROUP BY test_6.idtest, score_5.score) derivedtbl_6 ON test.idtest = derivedtbl_6.idtest) LEFT OUTER JOIN
                             (SELECT        test_4.idtest, score_3.score
                               FROM            (score score_3 LEFT OUTER JOIN
                                                         test test_4 ON score_3.idtest = test_4.idtest)
                               WHERE        (score_3.idstudent = " + al[3].ToString() + @")
                               GROUP BY test_4.idtest, score_3.score) derivedtbl_4 ON test.idtest = derivedtbl_4.idtest) LEFT OUTER JOIN
                             (SELECT        test_3.idtest, score_2.score
                               FROM            (score score_2 LEFT OUTER JOIN
                                                         test test_3 ON score_2.idtest = test_3.idtest)
                               WHERE        (score_2.idstudent = " + al[2].ToString() + @")
                               GROUP BY test_3.idtest, score_2.score) derivedtbl_3 ON test.idtest = derivedtbl_3.idtest) LEFT OUTER JOIN
                             (SELECT        test_2.idtest, score_1.score
                               FROM            (score score_1 LEFT OUTER JOIN
                                                         test test_2 ON score_1.idtest = test_2.idtest)
                               WHERE        (score_1.idstudent = " + al[1].ToString() + @")
                               GROUP BY test_2.idtest, score_1.score) derivedtbl_2 ON test.idtest = derivedtbl_2.idtest) LEFT OUTER JOIN
                             (SELECT        test_1.idtest, score.score
                               FROM            (score LEFT OUTER JOIN
                                                         test test_1 ON score.idtest = test_1.idtest)
                               WHERE        (score.idstudent = " + al[0].ToString() + @")
                               GROUP BY test_1.idtest, score.score) derivedtbl_1 ON test.idtest = derivedtbl_1.idtest)
                                WHERE        (test.[date] >= '" + start + @"' AND test.[date] <= '" + end + @"')";
                System.Data.OleDb.OleDbDataAdapter da = new System.Data.OleDb.OleDbDataAdapter(cmd, classTableAdapter.Connection);
                DataTable dt = new DataTable("a");
                da.Fill(dt);
                System.Windows.Forms.BindingSource bs = new BindingSource();
                bs.DataSource = dt;
                bs.Filter = "idclass=" + cmb_class.SelectedValue.ToString();
                dt = ((DataView)bs.List).ToTable();
                ///////////////
                pre.setdt = dt;
                pre.Reportsource = "list_number_tiz2";
                pre.strhead = cmb_class.Text;
                pre.strbehav = txt_head.Text;
                pre.strtmp = "کلاس" + " " + cmb_class.Text;
                pre.strtmp2 = stridlesson.Trim();
                pre.teachername = "";
                if (d1.Text.Length == 6 && d2.Text.Length == 6)
                    pre.teachername = "از تاریخ " + d1.Text.Insert(2, "/").Insert(5, "/") + " تا " + d2.Text.Insert(2, "/").Insert(5, "/");
                if (d1.Text.Length == 6 && d2.Text.Length != 6)
                    pre.teachername = "از تاریخ " + d1.Text.Insert(2, "/").Insert(5, "/");
                if (d1.Text.Length != 6 && d2.Text.Length == 6)
                    pre.teachername = "از ابتدای سال تحصیلی تا  " + d2.Text.Insert(2, "/").Insert(5, "/");
                pre.ShowDialog();
            }
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void classBindingSource_PositionChanged(object sender, EventArgs e)
        {
            string class_id = ((DataRowView)classBindingSource.Current)["idclass"].ToString();
            string class_grade = ((DataRowView)classBindingSource.Current)["grade"].ToString();
            string class_idmajor = ((DataRowView)classBindingSource.Current)["idmajor"].ToString();
            studentBindingSource.Filter = "idclass=" + class_id;
            lessonTableAdapter.Fill(dsp_list_number2.lesson, byte.Parse(class_grade), int.Parse(class_idmajor));
        }

    }
}
