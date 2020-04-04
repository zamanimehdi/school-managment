using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Student
{
    public partial class frm_reporttofamily : Form
    {
        Student.Report.tofamily tofamilyr = new Student.Report.tofamily();
        double max = -1;
        double min = 25;
        double av = 0;
        int rotbe = 0;
        int rotbepaye = 0;
        double stumoadelkol = 0;
        public frm_reporttofamily()
        {
            InitializeComponent();
        }
        private void frm_reporttofamily_Load(object sender, EventArgs e)
        {
        }
        #region printkoli ghadimi 
        /*
        private void btn_prev_Click(object sender, EventArgs e)
        {
            can cano = new can();
           // try
           // {
                if (classstudentBindingSource.Count != 0 & (txt_datef.Text != "" ? cano.isdate(txt_datef) : true) & (txt_datet.Text != "" ? cano.isdate(txt_datet) : true))
                {
                    PrintDialog pd = new PrintDialog();
                    if (pd.ShowDialog() == DialogResult.OK)
                    {
                        this.Refresh();
                        btn_prev.Enabled = false;
                        btn_prepreview.Enabled = false;
                        foreach (Control ct in grp_settting.Controls)
                        {
                            switch (ct.Name)
                            {
                                case "chk_lessennumber":
                                    Properties.Settings.Default["tofamily_1"] = ((CheckBox)ct).Checked;
                                    break;
                                case "chk_avelesson":
                                    Properties.Settings.Default["tofamily_2"] = ((CheckBox)ct).Checked;
                                    break;
                                case "chk_leassonchartstu":
                                    Properties.Settings.Default["tofamily_3"] = ((CheckBox)ct).Checked;
                                    break;
                                case "chk_moadelkol":
                                    Properties.Settings.Default["tofamily_4"] = ((CheckBox)ct).Checked;
                                    break;
                                case "chk_rotbe":
                                    Properties.Settings.Default["tofamily_5"] = ((CheckBox)ct).Checked;
                                    break;
                                case "chk_nsbatbeclass":
                                    Properties.Settings.Default["tofamily_6"] = ((CheckBox)ct).Checked;
                                    break;
                                case "chk_enzebati":
                                    Properties.Settings.Default["tofamily_7"] = ((CheckBox)ct).Checked;
                                    break;
                                case "txt_hedertext":
                                    Properties.Settings.Default["tofamily_8"] = ((TextBox)ct).Text;
                                    break;
                            }
                        }
                        Properties.Settings.Default.Save();
                        ////////////
                        int countstu = 0;
                        System.Collections.ArrayList arl = new System.Collections.ArrayList();
                        foreach (DataGridViewRow dr in dataGridView1.Rows)
                            if (dr.Cells[3].Value != null)
                                if (((bool)dr.Cells[3].Value) == true)
                                {
                                    countstu++;
                                    arl.Add(dr);
                                }
                        if (arl.Count == 0)
                        {
                            MessageBox.Show("هیچ دانش آموزی انتخاب نشده است");
                            btn_prev.Enabled = true;
                            btn_prepreview.Enabled = true;
                            return;
                        }
                        string datef = (txt_datef.Text == "" ? "0" : txt_datef.Text);
                        string datet = (txt_datet.Text == "" ? "999999" : txt_datet.Text);
                        if (datef != "0") datef = Convert.ToString(Int32.Parse(datef) - 1);
                        if (datet != "999999") datet = Convert.ToString(Int32.Parse(datet) + 1);
                        int idstudent;
                        string strbehav = "";
                        int s = 0;









                        #region
                        /////// moadel kol hameye student
                        double max = -1;
                        double min = 25;
                        double av = 0;
                        int rotbe = 0;
                        double stumoadelkol = 0;
                        BindingSource bs = new BindingSource(ds_reporttofamily, "moadelkol");
                        Student.DataSet.ds_reporttofamilyTableAdapters.sumvahedtbTableAdapter sumvahed = new Student.DataSet.ds_reporttofamilyTableAdapters.sumvahedtbTableAdapter();
                        Student.DataSet.ds_reporttofamilyTableAdapters.zarbshodetbTableAdapter zarbshode = new Student.DataSet.ds_reporttofamilyTableAdapters.zarbshodetbTableAdapter();
                     //   if (chk_rotbe.Checked || chk_nsbatbeclass.Checked || chk_moadelkol.Checked)
                        {
                            int i = 0;
                            Student.DataSet.ds_reporttofamilyTableAdapters.moadelkolTableAdapter moadelkol = new Student.DataSet.ds_reporttofamilyTableAdapters.moadelkolTableAdapter();
                            moadelkol.Fill(ds_reporttofamily.moadelkol, (Int32)cmb_class.SelectedValue);
                            foreach (DataRow row in ds_reporttofamily.moadelkol.Rows)
                            {
                                i++;
                                progressBar1.Value = (100 * i) / ds_reporttofamily.moadelkol.Rows.Count;
                                sumvahed.Fill(ds_reporttofamily.sumvahedtb, Int32.Parse(row["idstudent"].ToString()), datef, datet);
                                zarbshode.Fill(ds_reporttofamily.zarbshodetb, Int32.Parse(row["idstudent"].ToString()), datef, datet);
                                double temp;
                                if (ds_reporttofamily.zarbshodetb.Rows.Count != 0)
                                {
                                    temp = double.Parse(ds_reporttofamily.zarbshodetb.Rows[0][1].ToString()) / double.Parse(ds_reporttofamily.sumvahedtb.Rows[0][1].ToString());
                                    if (max < temp) max = temp;
                                    if (min > temp) min = temp;
                                    av += temp;
                                    row["moadelkol"] = Convert.ToString(temp);
                                }
                            }
                            av = av / ds_reporttofamily.moadelkol.Rows.Count;
                            bs.Sort = "moadelkol DESC";
                        }
                        ///////// end moadelkol
                        #endregion


                        foreach (DataGridViewRow dr in arl)
                        {
                            Student.Report.tofamily tofamilyr = new Student.Report.tofamily();
                            strbehav = "";
                            progressBar1.Value = 100 * (++s) / arl.Count;
                            progressBar1.Refresh();
                            idstudent = Int32.Parse(dr.Cells[0].Value.ToString());
                            Student.DataSet.ds_reporttofamilyTableAdapters.lessonTableAdapter lta = new Student.DataSet.ds_reporttofamilyTableAdapters.lessonTableAdapter();
                            Student.DataSet.ds_reporttofamilyTableAdapters.scoreTableAdapter scta = new Student.DataSet.ds_reporttofamilyTableAdapters.scoreTableAdapter();
                            Student.DataSet.ds_reporttofamilyTableAdapters.studentTableAdapter stta = new Student.DataSet.ds_reporttofamilyTableAdapters.studentTableAdapter();
                            Student.DataSet.ds_reporttofamilyTableAdapters.avelessonTableAdapter ata = new Student.DataSet.ds_reporttofamilyTableAdapters.avelessonTableAdapter();
                            Student.DataSet.ds_reporttofamilyTableAdapters.behaviorTableAdapter behav = new Student.DataSet.ds_reporttofamilyTableAdapters.behaviorTableAdapter();
                            lta.Fill(ds_reporttofamily.lesson);
                            scta.Fill(ds_reporttofamily.score, idstudent, datef, datet);
                            stta.Fill(ds_reporttofamily.student, idstudent);
                            ata.Fill(ds_reporttofamily.avelesson, idstudent, datef, datet);
                            if (datef == "0" && datet == "999999") behav.Fillwithoutdate(ds_reporttofamily.behavior, idstudent);
                            else behav.Fillwithdate(ds_reporttofamily.behavior, idstudent, datef, datet);
                            //progressBar1.Value = 0;
                            if (ds_reporttofamily.behavior.Count == 0) strbehav = "دانش آموز هیچ مورد انضباطی ندارد";


                            BindingSource bs1 = new BindingSource(ds_reporttofamily, "behavior");
                            bs1.Filter = "typeb=0";
                            int t1 = bs1.Count;
                            bs1.Filter = "typeb=1";
                            int t2 = bs1.Count;
                            bs1.Filter = "typeb=2";
                            int t3 = bs1.Count;
                            bs1.Filter = "typeb=3";
                            int t4 = bs1.Count;
                            bs1.Filter = "typeb=4";
                            int t5 = bs1.Count;
                            bs1.Filter = "typeb=5";
                            int t6 = bs1.Count;
                            bs1.Filter = "typeb=6";
                            int t7 = bs1.Count;
                            bs1.Filter = "typeb=7";
                            int t8 = bs1.Count;
                            bs1.Filter = "typeb=8";
                            int t9 = bs1.Count;
                            bs1.Filter = "typeb=9";
                            int t10 = bs1.Count;
                            bs1.Filter = "typeb=10";
                            int t11 = bs1.Count;
                            bs1.Filter = "typeb=11";
                            int t12 = bs1.Count;
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
                            double sumb = t1 * z1 + t2 * z2 + t3 * z3 + t4 * z4 + t5 * z5 + t6 * z6 + t7 * z7 + t8 * z8 + t9 * z9 + t10 * z10 + t11 * z11 + t12 * z12;
                            sumb = 20 - sumb;
                    



                            if (((DataRowView)bs.List[bs.Find("idstudent", (object)idstudent)]).Row[1].ToString()!="")
                                stumoadelkol = double.Parse(((DataRowView)bs.List[bs.Find("idstudent", (object)idstudent)]).Row[1].ToString());
                            rotbe = bs.Find("idstudent", (object)idstudent) + 1;
                            progressBar1.Refresh();

                            bool[] arb = new bool[8];
                            if (chk_lessennumber.Checked) arb[1] = true; else arb[1] = false;
                            if (chk_avelesson.Checked) arb[2] = true; else arb[2] = false;
                            if (chk_leassonchartstu.Checked) arb[3] = true; else arb[3] = false;
                            if (chk_moadelkol.Checked) arb[4] = true; else arb[4] = false;
                            if (chk_rotbe.Checked) arb[5] = true; else arb[5] = false;
                            if (chk_nsbatbeclass.Checked) arb[6] = true; else arb[6] = false;
                            if (chk_enzebati.Checked) arb[7] = true; else arb[7] = false;
                            //progressBar1.Value = 0;
                            tofamilyr.SetDataSource((System.Data.DataSet)ds_reporttofamily);
                            for (int i = 1; i <= 7; i++)
                                tofamilyr.SetParameterValue("sus_" + i.ToString(), (object)(!arb[i]));
                            tofamilyr.SetParameterValue("sn", Properties.Settings.Default.schoolname);
                            tofamilyr.SetParameterValue("rotbe", rotbe.ToString());
                            tofamilyr.SetParameterValue("maxp", max.ToString());
                            tofamilyr.SetParameterValue("minp", min.ToString());
                            tofamilyr.SetParameterValue("ave", av.ToString());
                            tofamilyr.SetParameterValue("stum", stumoadelkol.ToString());
                            tofamilyr.SetParameterValue("strhead", txt_hedertext.Text);
                            tofamilyr.SetParameterValue("strbehav", strbehav);
                            tofamilyr.SetParameterValue("scorebehav", sumb.ToString().Replace('.','/'));
                            tofamilyr.PrintOptions.PrinterName = pd.PrinterSettings.PrinterName;// pyFrom(pd.PrinterSettings, new System.Drawing.Printing.PageSettings(pd.PrinterSettings));
                            tofamilyr.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait;
                            tofamilyr.PrintOptions.ApplyPageMargins(new CrystalDecisions.Shared.PageMargins(30, 30, 30, 30));
                            progressBar1.Refresh();
                            tofamilyr.PrintToPrinter(1, false, 1, 100);
                            for (int kkk = 1; kkk <= 999; kkk++) lbl_matne.Refresh();
                            tofamilyr.Close();
                            tofamilyr.Dispose();
                        }
                        progressBar1.Value = 0;
                        btn_prev.Enabled = true;
                        btn_prepreview.Enabled = true;
                    }
                }

         //   }
         //   catch (Exception ex)
         //   {
         //       frm_exception frm = new frm_exception(ex.Message + "\n\n" + ex.StackTrace);
         //       frm.ShowDialog();
         //   }
        }*/
        #endregion
        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value = true;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in dataGridView1.Rows)
                dr.Cells[3].Value = true;
        }
        private void btn_deselectall_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in dataGridView1.Rows)
                dr.Cells[3].Value = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control ct in grp_settting.Controls)
            {
                switch (ct.Name)
                {
                    case "chk_lessennumber":
                        Properties.Settings.Default["tofamily_1"] = ((CheckBox)ct).Checked;
                        break;
                    case "chk_avelesson":
                        Properties.Settings.Default["tofamily_2"] = ((CheckBox)ct).Checked;
                        break;
                    case "chk_leassonchartstu":
                        Properties.Settings.Default["tofamily_3"] = ((CheckBox)ct).Checked;
                        break;
                    case "chk_moadelkol":
                        Properties.Settings.Default["tofamily_4"] = ((CheckBox)ct).Checked;
                        break;
                    case "chk_rotbe":
                        Properties.Settings.Default["tofamily_5"] = ((CheckBox)ct).Checked;
                        break;
                    case "chk_nsbatbeclass":
                        Properties.Settings.Default["tofamily_6"] = ((CheckBox)ct).Checked;
                        break;
                    case "chk_enzebati":
                        Properties.Settings.Default["tofamily_7"] = ((CheckBox)ct).Checked;
                        break;
                    case "txt_hedertext":
                        Properties.Settings.Default["tofamily_8"] = ((TextBox)ct).Text;
                        break;
                }
            }
            Properties.Settings.Default.Save();
            try
            {
                can cano = new can();
                if (classstudentBindingSource.Count != 0 & (txt_datef.Text != "" ? cano.isdate(txt_datef) : true) & (txt_datet.Text != "" ? cano.isdate(txt_datet) : true))
                {
                    string strbehav = "";
                    int idstudent = Int32.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    int stu_grade = int.Parse(((DataRowView)classBindingSource.Current)["grade"].ToString());
                    int stu_idclass = int.Parse(((DataRowView)classBindingSource.Current)["idclass"].ToString());
                    int stu_idmajor = int.Parse(((DataRowView)classBindingSource.Current)["idmajor"].ToString());
                    string datef = (txt_datef.Text == "" ? "0" : txt_datef.Text);
                    string datet = (txt_datet.Text == "" ? "999999" : txt_datet.Text);
                    if (datef != "0") datef = Convert.ToString(Int32.Parse(datef) - 1);
                    if (datet != "999999") datet = Convert.ToString(Int32.Parse(datet) + 1);
                    Student.DataSet.ds_reporttofamilyTableAdapters.lessonTableAdapter lta = new Student.DataSet.ds_reporttofamilyTableAdapters.lessonTableAdapter();
                    Student.DataSet.ds_reporttofamilyTableAdapters.scoreTableAdapter scta = new Student.DataSet.ds_reporttofamilyTableAdapters.scoreTableAdapter();
                    Student.DataSet.ds_reporttofamilyTableAdapters.studentTableAdapter stta = new Student.DataSet.ds_reporttofamilyTableAdapters.studentTableAdapter();
                    Student.DataSet.ds_reporttofamilyTableAdapters.avelessonTableAdapter ata = new Student.DataSet.ds_reporttofamilyTableAdapters.avelessonTableAdapter();
                    //Student.DataSet.ds_reporttofamilyTableAdapters.sumvahedtbTableAdapter sumvahed = new Student.DataSet.ds_reporttofamilyTableAdapters.sumvahedtbTableAdapter();
                    //Student.DataSet.ds_reporttofamilyTableAdapters.zarbshodetbTableAdapter zarbshode = new Student.DataSet.ds_reporttofamilyTableAdapters.zarbshodetbTableAdapter();
                    Student.DataSet.ds_reporttofamilyTableAdapters.behaviorTableAdapter behav = new Student.DataSet.ds_reporttofamilyTableAdapters.behaviorTableAdapter();
                    lta.Fill(ds_reporttofamily.lesson);
                    scta.Fill(ds_reporttofamily.score, idstudent, datef, datet);
                    stta.Fill(ds_reporttofamily.student, idstudent);
                    ata.Fill(ds_reporttofamily.avelesson, idstudent, datef, datet);
                    //sumvahed.Fill(ds_reporttofamily.sumvahedtb, idstudent, datef, datet);
                    //zarbshode.Fill(ds_reporttofamily.zarbshodetb, idstudent, datef, datet);
                    if (datef == "0" && datet == "999999") behav.Fillwithoutdate(ds_reporttofamily.behavior, idstudent);
                    else behav.Fillwithdate(ds_reporttofamily.behavior, idstudent, datef, datet);
                    if (ds_reporttofamily.behavior.Count == 0) strbehav = "دانش آموز هیچ مورد انضباطی ندارد";


                    BindingSource bs1 = new BindingSource(ds_reporttofamily, "behavior");
                    bs1.Filter = "typeb=0";
                    int t1 = bs1.Count;
                    bs1.Filter = "typeb=1";
                    int t2 = bs1.Count;
                    bs1.Filter = "typeb=2";
                    int t3 = bs1.Count;
                    bs1.Filter = "typeb=3";
                    int t4 = bs1.Count;
                    bs1.Filter = "typeb=4";
                    int t5 = bs1.Count;
                    bs1.Filter = "typeb=5";
                    int t6 = bs1.Count;
                    bs1.Filter = "typeb=6";
                    int t7 = bs1.Count;
                    bs1.Filter = "typeb=7";
                    int t8 = bs1.Count;

                    bs1.Filter = "typeb=8";
                    int t9 = bs1.Count;
                    bs1.Filter = "typeb=9";
                    int t10 = bs1.Count;
                    bs1.Filter = "typeb=10";
                    int t11 = bs1.Count;
                    bs1.Filter = "typeb=11";
                    int t12 = bs1.Count;

                    bs1.Filter = "typeb=12";
                    int t13 = bs1.Count;
                    bs1.Filter = "typeb=13";
                    int t14 = bs1.Count;
                    bs1.Filter = "typeb=14";
                    int t15 = bs1.Count;
                    bs1.Filter = "typeb=15";
                    int t16 = bs1.Count;
                    bs1.Filter = "typeb=16";
                    int t17 = bs1.Count;

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
                    #region moadel kol ghadimi
                    // progressBar1.Value = 0;
                    /////// moadel kol hameye student 
                    /*if (isdatechanghe)
                    {
                        max = -1;
                        min = 25;
                        av = 0;
                        rotbe = 0;
                        stumoadelkol = 0;
                       // if (chk_rotbe.Checked || chk_nsbatbeclass.Checked || chk_moadelkol.Checked)
                        {
                            int i = 0;
                            Student.DataSet.ds_reporttofamilyTableAdapters.moadelkolTableAdapter moadelkol = new Student.DataSet.ds_reporttofamilyTableAdapters.moadelkolTableAdapter();
                            moadelkol.Fill(ds_reporttofamily.moadelkol, (Int32)cmb_class.SelectedValue);
                            foreach (DataRow row in ds_reporttofamily.moadelkol.Rows)
                            {
                                i++;
                                progressBar1.Value = (100 * i) / ds_reporttofamily.moadelkol.Rows.Count;
                                sumvahed.Fill(ds_reporttofamily.sumvahedtb, Int32.Parse(row["idstudent"].ToString()), datef, datet);
                                zarbshode.Fill(ds_reporttofamily.zarbshodetb, Int32.Parse(row["idstudent"].ToString()), datef, datet);
                                double temp;
                                if (ds_reporttofamily.zarbshodetb.Rows.Count != 0)
                                {
                                    temp = double.Parse(ds_reporttofamily.zarbshodetb.Rows[0][1].ToString()) / double.Parse(ds_reporttofamily.sumvahedtb.Rows[0][1].ToString());
                                    if (max < temp) max = temp;
                                    if (min > temp) min = temp;
                                    av += temp;
                                    row["moadelkol"] = Convert.ToString(temp);
                                }
                            }
                            bs = new BindingSource(ds_reporttofamily, "moadelkol");
                            av = av / ds_reporttofamily.moadelkol.Rows.Count;
                            bs.Sort = "moadelkol DESC";
                        }
                        ///////// end moadelkol
                        isdatechanghe = false;
                    }
                    string tempstr = ((DataRowView)bs.List[bs.Find("idstudent", (object)idstudent)]).Row[1].ToString();
                    if (tempstr != "")
                        stumoadelkol = double.Parse(tempstr);
                    
                    while (!bs.IsSorted) ;
                    rotbe = bs.Find("idstudent", (object)idstudent) + 1;
                     */
                    #endregion
                    //====================== rotbe and moadel - new method
                    string selectcomd = @"SELECT        SUM(scoresum * vahed) / SUM(vahed) AS miangin, derivedtbl_1.idstudent, derivedtbl_2.name AS classname, student_1.name AS stu_name, 
                        student_1.lname AS stu_lname, student_1.fname
                        FROM            (((SELECT        AVG(score.score) AS scoresum, test.idlesson, score.idstudent, COUNT(score.score) * lesson.vahed AS vahed
                        FROM            ((score INNER JOIN
                        test ON score.idtest = test.idtest) INNER JOIN
                        lesson ON test.idlesson = lesson.idlesson)
                        WHERE        (test.[date] > '" + datef + @"') AND (test.[date] < '" + datet + @"')
                        GROUP BY test.idlesson, score.idstudent, lesson.vahed) derivedtbl_1 INNER JOIN
                        (SELECT        student.idstudent, class.grade, class.name, class.idmajor
                        FROM            (student LEFT OUTER JOIN
                        class ON student.idclass = class.idclass)) derivedtbl_2 ON derivedtbl_1.idstudent = derivedtbl_2.idstudent) INNER JOIN
                        student student_1 ON derivedtbl_1.idstudent = student_1.idstudent)
                        GROUP BY derivedtbl_1.idstudent, derivedtbl_2.grade, derivedtbl_2.name, student_1.name, student_1.lname, student_1.fname, derivedtbl_2.idmajor
                        HAVING        (derivedtbl_2.grade = " + stu_grade.ToString() + @") AND (derivedtbl_2.idmajor = " + stu_idmajor + @")
                        ORDER BY SUM(scoresum * vahed) / SUM(vahed) DESC";
                    string selectcmd_class = @"SELECT        SUM(scoresum * vahed) / SUM(vahed) AS miangin, derivedtbl_1.idstudent, derivedtbl_2.name AS classname, student_1.name AS stu_name, 
                        student_1.lname AS stu_lname, student_1.fname
                        FROM            (((SELECT        AVG(score.score) AS scoresum, test.idlesson, score.idstudent, COUNT(score.score) * lesson.vahed AS vahed
                        FROM            ((score INNER JOIN
                        test ON score.idtest = test.idtest) INNER JOIN
                        lesson ON test.idlesson = lesson.idlesson)
                        WHERE        (test.[date]> '" + datef + @"') AND (test.[date] < '" + datet + @"')
                        GROUP BY test.idlesson, score.idstudent, lesson.vahed) derivedtbl_1 INNER JOIN
                        (SELECT        student.idstudent, class.grade, class.name, class.idclass
                        FROM            (student LEFT OUTER JOIN
                        class ON student.idclass = class.idclass)) derivedtbl_2 ON derivedtbl_1.idstudent = derivedtbl_2.idstudent) INNER JOIN
                        student student_1 ON derivedtbl_1.idstudent = student_1.idstudent)
                        GROUP BY derivedtbl_1.idstudent, derivedtbl_2.grade, derivedtbl_2.name, student_1.name, student_1.lname, student_1.fname, derivedtbl_2.idclass
                        HAVING        (derivedtbl_2.idclass =" + stu_idclass.ToString() + @")" +
                        "ORDER BY SUM(scoresum * vahed) / SUM(vahed) DESC";
                    System.Data.OleDb.OleDbDataAdapter da = new System.Data.OleDb.OleDbDataAdapter(selectcmd_class, classTableAdapter.Connection);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dt.Columns.Add("rank");
                    max = -1;
                    min = 25;
                    av = 0;
                    for (int kk = 0; kk < dt.Rows.Count; kk++)
                    {
                        dt.Rows[kk]["rank"] = (kk + 1).ToString();
                        if (double.Parse(dt.Rows[kk]["miangin"].ToString()) > max) max = double.Parse(dt.Rows[kk]["miangin"].ToString());
                        if (double.Parse(dt.Rows[kk]["miangin"].ToString()) < min) min = double.Parse(dt.Rows[kk]["miangin"].ToString());
                        av = av + double.Parse(dt.Rows[kk]["miangin"].ToString());
                    }
                    av = av / dt.Rows.Count;
                    DataRow[] fdr = dt.Select("idstudent=" + idstudent.ToString());
                    rotbe = int.Parse(fdr[0]["rank"].ToString());
                    stumoadelkol = double.Parse(fdr[0]["miangin"].ToString());
                    //-----------------------
                    da = new System.Data.OleDb.OleDbDataAdapter(selectcomd, classTableAdapter.Connection);
                    dt = new DataTable();
                    da.Fill(dt);
                    dt.Columns.Add("rank");
                    for (int kk = 0; kk < dt.Rows.Count; kk++)
                        dt.Rows[kk]["rank"] = (kk + 1).ToString();
                    fdr = dt.Select("idstudent=" + idstudent.ToString());
                    rotbepaye = int.Parse(fdr[0]["rank"].ToString());
                    //======================
                    bool[] arb = new bool[8];
                    if (chk_lessennumber.Checked) arb[1] = true; else arb[1] = false;
                    if (chk_avelesson.Checked) arb[2] = true; else arb[2] = false;
                    if (chk_leassonchartstu.Checked) arb[3] = true; else arb[3] = false;
                    if (chk_moadelkol.Checked) arb[4] = true; else arb[4] = false;
                    if (chk_rotbe.Checked) arb[5] = true; else arb[5] = false;
                    if (chk_nsbatbeclass.Checked) arb[6] = true; else arb[6] = false;
                    if (chk_enzebati.Checked) arb[7] = true; else arb[7] = false;
                    frm_preview frm_previw = new frm_preview();
                    //
                    frm_previw.ds = (System.Data.DataSet)ds_reporttofamily;
                    frm_previw.rotbe = rotbe;
                    frm_previw.rotbepaye = rotbepaye;
                    frm_previw.max = max;
                    frm_previw.min = min;
                    frm_previw.av = av;
                    frm_previw.stumoadelkol = stumoadelkol;
                    frm_previw.strhead = txt_hedertext.Text;
                    frm_previw.arb = arb;
                    frm_previw.strbehav = strbehav;
                    frm_previw.sumbehav = sumb.ToString().Replace('.', '/');
                    frm_previw.strtmp = textBox1.Text;
                    frm_previw.Reportsource = "family";
                    
                    if (chk_dublex.Checked == true)
                        frm_previw.strtmp2 = "d";
                    else
                        frm_previw.strtmp2 = " ";

                    if (sender == null)
                    {
                        frm_previw.directprint = true;
                        frm_previw.pd = pd;
                    }
                    frm_previw.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                frm_exception frm = new frm_exception(ex.Message + "\n\n" + ex.StackTrace);
                frm.ShowDialog();
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
        private void frm_reporttofamily_Shown(object sender, EventArgs e)
        {
            foreach (Control ct in grp_settting.Controls)
            {
                switch (ct.Name)
                {
                    case "chk_lessennumber":
                        ((CheckBox)ct).Checked = (bool)Properties.Settings.Default["tofamily_1"];
                        break;
                    case "chk_avelesson":
                        ((CheckBox)ct).Checked = (bool)Properties.Settings.Default["tofamily_2"];
                        break;
                    case "chk_leassonchartstu":
                        ((CheckBox)ct).Checked = (bool)Properties.Settings.Default["tofamily_3"];
                        break;
                    case "chk_moadelkol":
                        ((CheckBox)ct).Checked = (bool)Properties.Settings.Default["tofamily_4"];
                        break;
                    case "chk_rotbe":
                        ((CheckBox)ct).Checked = (bool)Properties.Settings.Default["tofamily_5"];
                        break;
                    case "chk_nsbatbeclass":
                        ((CheckBox)ct).Checked = (bool)Properties.Settings.Default["tofamily_6"];
                        break;
                    case "chk_enzebati":
                        ((CheckBox)ct).Checked = (bool)Properties.Settings.Default["tofamily_7"];
                        break;
                    case "txt_hedertext":
                        ((TextBox)ct).Text = (string)Properties.Settings.Default["tofamily_8"];
                        break;
                }
            }
            Refresh();
            Opacity = 1;
            this.studentTableAdapter.Fill(this.ds_classstudent.student);
            this.classTableAdapter.Fill(this.ds_classstudent._class);
        }
        private PrintDialog pd;
        private void btn_print_koli_click(object sender, EventArgs e)
        {
            can cano = new can();
            if (classstudentBindingSource.Count != 0 & (txt_datef.Text != "" ? cano.isdate(txt_datef) : true) & (txt_datet.Text != "" ? cano.isdate(txt_datet) : true))
            {
                pd = new PrintDialog();
                if (pd.ShowDialog() == DialogResult.OK)
                {
                    this.Refresh();
                    grp_settting.Enabled = false;
                    grp_select.Enabled = false;
                    btn_print_koli.Enabled = false;
                    btn_exit.Enabled = false;
                    int count = 0;
                    for (int index = 0; index < dataGridView1.RowCount; index++)
                        if (dataGridView1[3, index].Value != null && (bool)dataGridView1[3, index].Value == true)
                            count++;
                    progressBar1.Maximum=count;
                    //===========================
                    int count2=0;
                    for (int index = 0; index < dataGridView1.RowCount; index++)
                    {
                        if (dataGridView1[3, index].Value != null && (bool)dataGridView1[3, index].Value == true)
                        {
                            progressBar1.Value = ++count2; Refresh();
                            dataGridView1.Rows[index].Selected = true;
                            classstudentBindingSource.Position = index;
                            button1_Click(null, null);
                        }
                    }
                    //=============================
                    grp_settting.Enabled = true;
                    grp_select.Enabled = true;
                    btn_print_koli.Enabled = true;
                    btn_exit.Enabled = true;
                }
            }
        }
    }
}