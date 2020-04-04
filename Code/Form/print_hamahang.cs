using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Student
{
    public partial class frm_print_hamahang : Form
    {
        frm_proces frm_p = new frm_proces();
        frm_preview form = new frm_preview();
        public frm_print_hamahang()
        {
            InitializeComponent();
        }
        public string fix(string score)
        {
            string str = score;
            if (str == "") return str;
            if (double.Parse(str) == -1) return "";
            if (double.Parse(str) == 110) return "";
            if (str.Contains("."))
            {
                string d1 = str.Split('.')[0];
                if (str.Split('.')[1].ToString().Length >= 2)
                    return d1 + "/" + str.Split('.')[1].ToString().Substring(0, 2);
                else
                    return d1 + "/" + str.Split('.')[1].ToString();
            }
            else
            {
                return str;
            }
            //if (str.Length >= 5)
            //    str = str.Substring(0, 5);
            //str = double.Parse(str).ToString();
            //str = str.Replace(".", "/");
            //return str;
        }
        private void print_lesson_Load(object sender, EventArgs e)
        {
            try
            {
                this.hamahangTableAdapter.Fill(this.dsp_hhamahang_report.hamahang);
            }
            catch
            {
                MessageBox.Show("در حال حاضر قادر به تهیه این گزارش نمی باشید");
                Close();
            }
            cmb_typereport.SelectedIndex = 0;
            this.classTableAdapter.Fill(this.dsp_hhamahang_report._class);
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btn_preview_Click(object sender, EventArgs e)
        {
            label4.Visible = true;
            this.Refresh();
            if (cmb_class.Text == "" || cmb_emtehan.Text == "") return;
            if (cmb_typereport.SelectedIndex == 0 || cmb_typereport.SelectedIndex == 1)
            {
                hamahang_0TableAdapter.Fill(dsp_hhamahang_report.hamahang_0, (int)cmb_class.SelectedValue, (int)cmb_emtehan.SelectedValue, (int)cmb_class.SelectedValue);
                hamahang_0_mianginclassTableAdapter.Fill(dsp_hhamahang_report.hamahang_0_mianginclass,
                    (int)cmb_class.SelectedValue,
                    (int)cmb_emtehan.SelectedValue,
                    (int)cmb_class.SelectedValue,
                    (int)cmb_class.SelectedValue,
                    (int)cmb_emtehan.SelectedValue,
                    (int)cmb_class.SelectedValue);
                hamahang_0_mianginpayeTableAdapter.Fill(dsp_hhamahang_report.hamahang_0_mianginpaye,
                    (int)cmb_emtehan.SelectedValue,
                    (int)cmb_emtehan.SelectedValue);
                lessonTableAdapter.Fill(dsp_hhamahang_report.lesson);
                frm_preview frm = new frm_preview();
                System.Data.DataSet ds = new System.Data.DataSet();
                ds.Tables.Add((DataTable)dsp_hhamahang_report.hamahang_0.Copy());
                ds.Tables.Add((DataTable)dsp_hhamahang_report.hamahang_0_mianginclass.Copy());
                ds.Tables.Add((DataTable)dsp_hhamahang_report.lesson.Copy());
                ds.Tables.Add((DataTable)dsp_hhamahang_report.hamahang_0_mianginpaye.Copy());
                //ds.Tables.Add((DataTable)dsp_hamahang_st_sort._dsp_hamahang_st_sort.Copy()); //rotbe
                frm.ds = ds;
                frm.strhead = cmb_emtehan.Text.Trim();
                DateTime dt = DateTime.Now;
                System.Globalization.PersianCalendar pc = new System.Globalization.PersianCalendar();
                string saletahsili;
                if (pc.GetMonth(dt) <= 4)
                {
                    saletahsili = Convert.ToString(pc.GetYear(dt) - 1) + "-" + Convert.ToString(int.Parse(pc.GetYear(dt).ToString().Substring(2, 2)));
                }
                else
                {
                    saletahsili = pc.GetYear(dt).ToString() + "-" + Convert.ToString(int.Parse(pc.GetYear(dt).ToString().Substring(2, 2)) + 1);
                }
                frm.strbehav = saletahsili;
                frm.teachername = cmb_class.Text; // class name
                if (cmb_typereport.SelectedIndex == 0)
                    frm.Reportsource = "hamahangreport_0";
                else frm.Reportsource = "hamahangreport_0_ver2";
                frm.ShowDialog();
            }

            if (cmb_typereport.SelectedIndex == 2)
            {
                doros_reportTableAdapter.Fill(dsp_hhamahang_report.doros_report,
                    (int)cmb_emtehan.SelectedValue, (int)cmb_class.SelectedValue, (int)cmb_class.SelectedValue);

                frm_preview frm = new frm_preview();
                System.Data.DataSet ds = new System.Data.DataSet();
                ds.Tables.Add((DataTable)dsp_hhamahang_report.doros_report.Copy());
                frm.ds = ds;
                frm.strhead =cmb_emtehan.Text.Trim();
                DateTime dt = DateTime.Now;
                System.Globalization.PersianCalendar pc = new System.Globalization.PersianCalendar();
                string saletahsili;
                if (pc.GetMonth(dt) <= 4)
                {
                    saletahsili = Convert.ToString(pc.GetYear(dt) - 1) + "-" + Convert.ToString(int.Parse(pc.GetYear(dt).ToString().Substring(2, 2)));
                }
                else
                {
                    saletahsili = pc.GetYear(dt).ToString() + "-" + Convert.ToString(int.Parse(pc.GetYear(dt).ToString().Substring(2, 2)) + 1);
                }
                frm.strbehav = cmb_class.Text;//+"  "+saletahsili;
               // frm.teachername = cmb_class.Text;
                frm.Reportsource = "hamahangreport_2";
                frm.ShowDialog();
            }
            if (cmb_typereport.SelectedIndex == 3)
            {
                dsp_hamahang_st_sortTableAdapter.Fill(dsp_hamahang_st_sort._dsp_hamahang_st_sort,
                    (int)cmb_emtehan.SelectedValue,
                    (int)cmb_class.SelectedValue
                     );
                frm_preview pre = new frm_preview();
                pre.setdt = (DataTable)dsp_hamahang_st_sort._dsp_hamahang_st_sort;
                pre.Reportsource = "grade_av_list";
                pre.strhead = cmb_emtehan.Text;
                pre.strtmp = "امتحانات هماهنگ";
                pre.teachername = "کلاس" + " " + cmb_class.Text;
                pre.ShowDialog();
            }

            if (cmb_typereport.SelectedIndex == 4)
            {
                label4.Visible = false;
                this.Refresh();
                frm_sort_dialog dial = new frm_sort_dialog();
                if (!(dial.ShowDialog() == DialogResult.OK))
                    return;
                label4.Visible = true;
                btn_exit.Enabled = false;
                btn_preview.Enabled = false;
                this.Refresh();
                DataSet.dsp_hamahang_list2TableAdapters.dt_lessonsTableAdapter ta = new Student.DataSet.dsp_hamahang_list2TableAdapters.dt_lessonsTableAdapter();
                DataSet.dsp_hamahang_list2.dt_lessonsDataTable dt_lesson = ta.GetData((int)cmb_emtehan.SelectedValue, (int)cmb_class.SelectedValue);
                // dt_lesson[row][0] : id       dt_lesson[row][1] : name        dt_lesson[row][3] : vahed
                //========================================
                DataSet.dsp_hamahang_list2TableAdapters.studentTableAdapter ta2 = new Student.DataSet.dsp_hamahang_list2TableAdapters.studentTableAdapter();
                DataSet.dsp_hamahang_list2.studentDataTable dt_student;
                if (dial.res == "id")
                    dt_student = ta2.GetData_sortbyid((int)cmb_class.SelectedValue);
                else
                    dt_student = ta2.GetData((int)cmb_class.SelectedValue);
                // idstudent  name  lname  sh   fname
                //========================================
                DataSet.dsp_hamahang_list2.rows_reportDataTable report_row = new Student.DataSet.dsp_hamahang_list2.rows_reportDataTable();
                DataSet.dsp_hamahang_list2TableAdapters.scoreTableAdapter ta_s = new Student.DataSet.dsp_hamahang_list2TableAdapters.scoreTableAdapter();
                int id_hamahang = (int)cmb_emtehan.SelectedValue;
                //===================================================
                double[] col_sum = new double[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                double[] col_count = new double[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                double[] col_balatarin = new double[] { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 };
                double[] col_payntarin = new double[] { 110, 110, 110, 110, 110, 110, 110, 110, 110, 110, 110, 110, 110, 110, 110, 110, 110, 110, 110, 110 };
                for (int row = 0; row < dt_student.Rows.Count; row++)
                {

                    //======= RANK ========================
                    DataSet.dsp_hamahang_list2TableAdapters.ranktbTableAdapter ta_rank = new Student.DataSet.dsp_hamahang_list2TableAdapters.ranktbTableAdapter();
                    DataSet.dsp_hamahang_list2.ranktbDataTable tb_rank = ta_rank.GetData((int)cmb_emtehan.SelectedValue, (int)cmb_class.SelectedValue);
                    string rotbe = "";
                    for (int j = 0; j < tb_rank.Rows.Count; j++)
                    {
                        if (int.Parse(dt_student[row][0].ToString()) == int.Parse(tb_rank[j][1].ToString()))
                        {
                            rotbe = (j + 1).ToString();
                            break;
                        }
                    }
                    //==== RANK ====================
                    report_row.Addrows_reportRow(Convert.ToString(row + 1),
                        dt_student[row][2].ToString() + " " + dt_student[row][1].ToString(),
                        dt_student[row][4].ToString(),
                        dt_student[row][3].ToString(),
                        "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", ""
                        , "", "","","", rotbe);
                    double sumcol = 0;
                    double sumvahed = 0;
                    for (int col = 0; col < dt_lesson.Rows.Count; col++)
                    {
                        int id_stu = int.Parse(dt_student[row][0].ToString());
                        int id_lesson = int.Parse(dt_lesson[col][0].ToString());
                        report_row[row][4 + col] =fix( ta_s.GetData(id_hamahang, id_stu, id_lesson)[0][0].ToString());
                        if (report_row[row][4 + col].ToString() != "")
                        {
                            if (col_balatarin[col] < double.Parse(report_row[row][4 + col].ToString().Replace("/", ".")))
                                col_balatarin[col] = double.Parse(report_row[row][4 + col].ToString().Replace("/", "."));
                            if (col_payntarin[col] > double.Parse(report_row[row][4 + col].ToString().Replace("/", ".")))
                                col_payntarin[col] = double.Parse(report_row[row][4 + col].ToString().Replace("/", "."));
                            //if (col_balatarin[col].ToString() == "-1") col_payntarin[col] = -1;
                            col_sum[col] = col_sum[col] + double.Parse(report_row[row][4 + col].ToString().Replace("/", "."));
                            col_count[col] = col_count[col] + 1;
                            sumcol = sumcol + (double.Parse(report_row[row][4 + col].ToString().Replace("/", "."))) * (double.Parse(dt_lesson[col][2].ToString().Replace("/", ".")));
                            sumvahed = sumvahed + (double.Parse(dt_lesson[col][2].ToString()));
                        }
                    }
                    if (sumcol != 0)
                    {
                        report_row[row]["sum_s"] = fix(sumcol.ToString());
                        report_row[row]["avg_s"] = fix((sumcol / sumvahed).ToString());
                    }
                }
                //======== sum col
                report_row.Addrows_reportRow("",
                        "مجموع",
                        "",
                        "",
                        fix(col_sum[0].ToString()), fix(col_sum[1].ToString()), fix(col_sum[2].ToString()), fix(col_sum[3].ToString()),
                        fix(col_sum[4].ToString()), fix(col_sum[5].ToString()), fix(col_sum[6].ToString()), fix(col_sum[7].ToString()),
                        fix(col_sum[8].ToString()), fix(col_sum[9].ToString()), fix(col_sum[10].ToString()), fix(col_sum[11].ToString()),
                        fix(col_sum[12].ToString()), fix(col_sum[13].ToString()), fix(col_sum[14].ToString()), fix(col_sum[15].ToString()),
                        fix(col_sum[16].ToString()), fix(col_sum[17].ToString()),fix(col_sum[18].ToString()),fix(col_sum[19].ToString())
                        , "", "", "");

                //===========  payntarin
                report_row.Addrows_reportRow("",
                        "پایین‌ترین",
                        "",
                        "",
                        fix(col_payntarin[0].ToString()), fix(col_payntarin[1].ToString()), fix(col_payntarin[2].ToString()), fix(col_payntarin[3].ToString()),
                        fix(col_payntarin[4].ToString()), fix(col_payntarin[5].ToString()), fix(col_payntarin[6].ToString()), fix(col_payntarin[7].ToString()),
                        fix(col_payntarin[8].ToString()), fix(col_payntarin[9].ToString()), fix(col_payntarin[10].ToString()), fix(col_payntarin[11].ToString()),
                        fix(col_payntarin[12].ToString()), fix(col_payntarin[13].ToString()), fix(col_payntarin[14].ToString()), fix(col_payntarin[15].ToString()),
                        fix(col_payntarin[16].ToString()), fix(col_payntarin[17].ToString()),fix(col_payntarin[18].ToString()),fix(col_payntarin[19].ToString())
                       , "", "", "");
                //===========  balatarin
                report_row.Addrows_reportRow("",
                        "بالاترین",
                        "",
                        "",
                        fix(col_balatarin[0].ToString()), fix(col_balatarin[1].ToString()), fix(col_balatarin[2].ToString()), fix(col_balatarin[3].ToString()),
                        fix(col_balatarin[4].ToString()), fix(col_balatarin[5].ToString()), fix(col_balatarin[6].ToString()), fix(col_balatarin[7].ToString()),
                        fix(col_balatarin[8].ToString()), fix(col_balatarin[9].ToString()), fix(col_balatarin[10].ToString()), fix(col_balatarin[11].ToString()),
                        fix(col_balatarin[12].ToString()), fix(col_balatarin[13].ToString()), fix(col_balatarin[14].ToString()), fix(col_balatarin[15].ToString()),
                        fix(col_balatarin[16].ToString()), fix(col_balatarin[17].ToString()), fix(col_balatarin[18].ToString()), fix(col_balatarin[19].ToString())
                        , "", "", "");
                
                //======== avg col
                report_row.Addrows_reportRow("",
                        "میانگین",
                        "",
                        "",
                         fix((col_sum[0] / col_count[0]).ToString()),
                         fix((col_sum[1] / col_count[1]).ToString()), fix((col_sum[2] / col_count[2]).ToString()),
                         fix((col_sum[3] / col_count[3]).ToString()), fix((col_sum[4] / col_count[4]).ToString()),
                         fix((col_sum[5] / col_count[5]).ToString()), fix((col_sum[6] / col_count[6]).ToString()),
                         fix((col_sum[7] / col_count[7]).ToString()), fix((col_sum[8] / col_count[8]).ToString()),
                         fix((col_sum[9] / col_count[9]).ToString()), fix((col_sum[10] / col_count[10]).ToString()),
                         fix((col_sum[11] / col_count[11]).ToString()), fix((col_sum[12] / col_count[12]).ToString()),
                         fix((col_sum[13] / col_count[13]).ToString()), fix((col_sum[14] / col_count[14]).ToString()),
                         fix((col_sum[15] / col_count[15]).ToString()), fix((col_sum[16] / col_count[16]).ToString()),
                         fix((col_sum[17] / col_count[17]).ToString()),fix((col_sum[18] / col_count[18]).ToString()),
                         fix((col_sum[19] / col_count[19]).ToString())
                        , "", "", "");
                for (int index = 1; index <= 20; index++)
                {
                    if (report_row[report_row.Rows.Count - 1][index + 4].ToString() == "NaN") report_row[report_row.Rows.Count - 1][index + 4] = "";
                    if (report_row[report_row.Rows.Count - 1][index + 4].ToString().Length >= 6)
                        report_row[report_row.Rows.Count - 1][index + 4] = report_row[report_row.Rows.Count - 1][index + 4].ToString().Substring(0, 5);
                }
                //=======================
                frm_preview pre = new frm_preview();
                pre.setdt = (DataTable)report_row;
                pre.strhead = "لیست نمرات امتحانات هماهنگ " + cmb_emtehan.Text + "   کلاس " + cmb_class.Text;
                pre.Reportsource = "hamahangreport_listnumber2";
                pre.array_param = new object[1];
                pre.array_param[0] = dt_lesson;
                pre.ShowDialog();

            } // end listnumber
            label4.Visible = false;
            btn_exit.Enabled = btn_preview.Enabled = true;
            this.Refresh();

        }// end bouttom
    }
}