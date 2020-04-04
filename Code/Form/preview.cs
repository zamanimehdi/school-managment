using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Student
{
    public partial class frm_preview : Form
    {
        public DataTable dt;
        public System.Data.DataSet ds;
        string reportsource;
        public double x = 0;
        public string teachername; // for case "teacherwork"
        public string strtmp, strtmp2;
        public int rotbe = 0;
        public int rotbepaye = 0;
        public double max, min, av, stumoadelkol;
        public string strhead = "", strbehav = "";
        public bool[] arb;
        public string sumbehav = "";
        public bool directprint = false;
        public PrintDialog pd;
        public object[] array_param;
        public frm_preview()
        {
            InitializeComponent();
        }
        private void frm_preview_Load(object sender, EventArgs e)
        {
            if (directprint) { Opacity = 0; Refresh(); }
            switch (reportsource)
            {
                case "student_class":
                    student_class1.InitReport += new System.EventHandler(loadfinish);
                    student_class1.SetDataSource(dt);
                    student_class1.SetParameterValue("schoolname", Properties.Settings.Default.schoolname);
                    if (Properties.Settings.Default.ps_chk_pagetitle)
                        student_class1.SetParameterValue("title", Properties.Settings.Default.ps_txt_pagetitle);
                    else
                        student_class1.SetParameterValue("title", "");
                    if (Properties.Settings.Default.ps_chk_footer)
                        student_class1.SetParameterValue("footer", Properties.Settings.Default.ps_txt_footer);
                    else
                        student_class1.SetParameterValue("footer", "");
                    if (!Properties.Settings.Default.ps_pagenumber)
                        student_class1.Section5.ReportObjects[0].Width = 0;
                    crystalReportViewer1.ReportSource = student_class1;
                    crystalReportViewer1.Zoom(1);
                    break;
                case "student_grade":
                    student_grade1.InitReport += new System.EventHandler(loadfinish);
                    student_grade1.SetDataSource(dt);
                    student_grade1.SetParameterValue("schoolname", Properties.Settings.Default.schoolname);
                    if (Properties.Settings.Default.ps_chk_pagetitle)
                        student_grade1.SetParameterValue("title", Properties.Settings.Default.ps_txt_pagetitle);
                    else
                        student_grade1.SetParameterValue("title", "");
                    if (Properties.Settings.Default.ps_chk_footer)
                        student_grade1.SetParameterValue("footer", Properties.Settings.Default.ps_txt_footer);
                    else
                        student_grade1.SetParameterValue("footer", "");
                    if (!Properties.Settings.Default.ps_pagenumber)
                        student_grade1.Section5.ReportObjects[0].Width = 0;
                    crystalReportViewer1.ReportSource = student_grade1;
                    crystalReportViewer1.Zoom(1);
                    break;
                case "student_major":
                    student_major1.InitReport += new System.EventHandler(loadfinish);

                    student_major1.SetDataSource(dt);
                    student_major1.SetParameterValue("schoolname", Properties.Settings.Default.schoolname);
                    if (Properties.Settings.Default.ps_chk_pagetitle)
                        student_major1.SetParameterValue("title", Properties.Settings.Default.ps_txt_pagetitle);
                    else
                        student_major1.SetParameterValue("title", "");
                    if (Properties.Settings.Default.ps_chk_footer)
                        student_major1.SetParameterValue("footer", Properties.Settings.Default.ps_txt_footer);
                    else
                        student_major1.SetParameterValue("footer", "");
                    if (!Properties.Settings.Default.ps_pagenumber)
                        student_major1.Section5.ReportObjects[0].Width = 0;
                    crystalReportViewer1.ReportSource = student_major1;
                    crystalReportViewer1.Zoom(1);
                    break;
                case "student_nogroup":
                    student_nogroup1.InitReport += new System.EventHandler(loadfinish);
                    student_nogroup1.SetDataSource(dt);
                    student_nogroup1.SetParameterValue("schoolname", Properties.Settings.Default.schoolname);
                    if (Properties.Settings.Default.ps_chk_pagetitle)
                        student_nogroup1.SetParameterValue("title", Properties.Settings.Default.ps_txt_pagetitle);
                    else
                        student_nogroup1.SetParameterValue("title", "");
                    if (Properties.Settings.Default.ps_chk_footer)
                        student_nogroup1.SetParameterValue("footer", Properties.Settings.Default.ps_txt_footer);
                    else
                        student_nogroup1.SetParameterValue("footer", "");
                    if (!Properties.Settings.Default.ps_pagenumber)
                        student_nogroup1.Section5.ReportObjects[0].Width = 0;
                    crystalReportViewer1.ReportSource = student_nogroup1;
                    crystalReportViewer1.Zoom(1);
                    break;
                case "listnumber_1":
                    listnumber1.InitReport += new System.EventHandler(loadfinish);
                    listnumber1.SetDataSource(ds);
                    listnumber1.SetParameterValue("schoolname", Properties.Settings.Default.schoolname);
                    if (Properties.Settings.Default.ln_chk_title)
                        listnumber1.SetParameterValue("title", Properties.Settings.Default.ln_txt_title);
                    else
                        listnumber1.SetParameterValue("title", "");
                    if (Properties.Settings.Default.ln_chk_footer)
                        listnumber1.SetParameterValue("footer", Properties.Settings.Default.ln_txt_footer);
                    else
                    {
                        listnumber1.GroupFooterSection3.SectionFormat.EnableSuppress = true;
                        listnumber1.SetParameterValue("footer", " ");
                    }
                    if (!Properties.Settings.Default.ln_chk_lessonchart)
                        listnumber1.GroupHeaderSection6.SectionFormat.EnableSuppress = true;
                    // listavg
                    // listnumber
                    if (!Properties.Settings.Default.ln_chk_avnumber)
                        listnumber1.GroupHeaderSection5.SectionFormat.EnableSuppress = true;
                    if (!Properties.Settings.Default.ln_chk_listnumber)
                        listnumber1.GroupHeaderSection2.SectionFormat.EnableSuppress = true;
                    if (!Properties.Settings.Default.ln_chk_classavgchart)
                        listnumber1.GroupHeaderSection7.SectionFormat.EnableSuppress = true;
                    if (!Properties.Settings.Default.ln_chk_pagenumber)
                        listnumber1.Section5.ReportObjects[0].Width = 0;
                    crystalReportViewer1.ReportSource = listnumber1;
                    crystalReportViewer1.Zoom(1);
                    break;
                case "listnumber_2":
                    listnumber21.InitReport += new System.EventHandler(loadfinish);
                    listnumber21.SetDataSource(dt);
                    listnumber21.SetParameterValue("strpost", Properties.Settings.Default.tempstr);
                    listnumber21.SetParameterValue("schoolname", Properties.Settings.Default.schoolname);
                    if (Properties.Settings.Default.ln_chk_title)
                        listnumber21.SetParameterValue("title", Properties.Settings.Default.ln_txt_title);
                    else
                        listnumber21.SetParameterValue("title", "");
                    if (Properties.Settings.Default.ln_chk_footer)
                        listnumber21.SetParameterValue("footer", Properties.Settings.Default.ln_txt_footer);
                    else
                        listnumber21.SetParameterValue("footer", "");
                    if (!Properties.Settings.Default.ln_chk_pagenumber)
                        listnumber21.Section5.ReportObjects[0].Width = 0;
                    crystalReportViewer1.ReportSource = listnumber21;
                    crystalReportViewer1.Zoom(1);
                    break;
                case "behav":
                    behav1.InitReport += new System.EventHandler(loadfinish);
                    behav1.SetDataSource(dt);
                    behav1.SetParameterValue("schoolname", Properties.Settings.Default.schoolname);
                    behav1.SetParameterValue("student", Properties.Settings.Default.student);
                    behav1.SetParameterValue("behavscore", sumbehav.Replace('.', '/'));
                    behav1.SetParameterValue("txt", strhead);
                    crystalReportViewer1.ReportSource = behav1;
                    crystalReportViewer1.Zoom(1);
                    break;
                case "mali":
                    mali1.InitReport += new System.EventHandler(loadfinish);
                    mali1.SetDataSource(ds);
                    mali1.SetParameterValue("sn", Properties.Settings.Default.schoolname);
                    mali1.SetParameterValue("sum_pardakhti", x);
                    crystalReportViewer1.ReportSource = mali1;
                    crystalReportViewer1.Zoom(1);
                    break;
                case "teacherwork":
                    teacherwork1.InitReport += new System.EventHandler(loadfinish);
                    System.Globalization.PersianCalendar pc = new System.Globalization.PersianCalendar();
                    DateTime nowt = DateTime.Now;
                    string strdate = pc.GetYear(nowt).ToString().Substring(2, 2) + "/" + (pc.GetMonth(nowt).ToString().Length == 1 ? "0" + pc.GetMonth(nowt).ToString() : pc.GetMonth(nowt).ToString()) + "/" + (pc.GetDayOfMonth(nowt).ToString().Length == 1 ? "0" + pc.GetDayOfMonth(nowt).ToString() : pc.GetDayOfMonth(nowt).ToString());
                    teacherwork1.SetDataSource(ds);
                    teacherwork1.SetParameterValue("schoolname", Properties.Settings.Default.schoolname);
                    teacherwork1.SetParameterValue("datestr", strhead);
                    crystalReportViewer1.ReportSource = teacherwork1;
                    crystalReportViewer1.Zoom(1);
                    break;
                case "nemodar":
                    nemodar1.InitReport += new System.EventHandler(loadfinish);
                    nemodar1.SetDataSource(ds);
                    nemodar1.SetParameterValue("schoolname", Properties.Settings.Default.schoolname);
                    nemodar1.SetParameterValue("datef", strhead);
                    nemodar1.SetParameterValue("datet", strbehav);
                    crystalReportViewer1.ReportSource = nemodar1;
                    crystalReportViewer1.Zoom(1);
                    break;
                case "lesseonreport":
                    lessonreport1.InitReport += new System.EventHandler(loadfinish);
                    lessonreport1.SetDataSource(ds);
                    lessonreport1.SetParameterValue("schoolname", Properties.Settings.Default.schoolname);
                    lessonreport1.SetParameterValue("datef", strhead);
                    lessonreport1.SetParameterValue("datet", strbehav);
                    lessonreport1.SetParameterValue("classname", teachername);
                    crystalReportViewer1.ReportSource = lessonreport1;
                    crystalReportViewer1.Zoom(1);
                    break;
                case "hamahangreport_0":
                    hamahang_01.InitReport += new System.EventHandler(loadfinish);
                    /////////////// load bitmap
                    try
                    {
                        string filename = Student.Properties.Settings.Default.armlocation;
                        //Read file and make it to arrays of bytes
                        System.IO.FileStream fs = new System.IO.FileStream(filename, System.IO.FileMode.Open);
                        System.IO.BinaryReader br = new System.IO.BinaryReader(fs);
                        byte[] bs = br.ReadBytes((int)fs.Length);
                        fs.Close();
                        br.Close();
                        for (int tt = 0; tt < ds.Tables["hamahang_0"].Rows.Count; tt++)
                            ds.Tables["hamahang_0"].Rows[tt]["LOGO"] = bs;
                    }
                    catch
                    { }
                    ///////////////////////////

                    hamahang_01.SetDataSource(ds);
                    hamahang_01.SetParameterValue("schoolname", Properties.Settings.Default.schoolname);
                    hamahang_01.SetParameterValue("hamahang_name", strhead);
                    hamahang_01.SetParameterValue("saletahsili", strbehav);
                    hamahang_01.SetParameterValue("classname", teachername);
                    crystalReportViewer1.ReportSource = hamahang_01;
                    crystalReportViewer1.Zoom(1);
                    break;
                case "hamahangreport_0_ver2":
                    hamahang_0_ver21.InitReport += new System.EventHandler(loadfinish);
                    /////////////// load bitmap
                    try
                    {
                        string filename = Student.Properties.Settings.Default.armlocation;
                        //Read file and make it to arrays of bytes
                        System.IO.FileStream fs = new System.IO.FileStream(filename, System.IO.FileMode.Open);
                        System.IO.BinaryReader br = new System.IO.BinaryReader(fs);
                        byte[] bs = br.ReadBytes((int)fs.Length);
                        fs.Close();
                        br.Close();
                        for (int tt = 0; tt < ds.Tables["hamahang_0"].Rows.Count; tt++)
                            ds.Tables["hamahang_0"].Rows[tt]["LOGO"] = bs;
                    }
                    catch
                    { }
                    ///////////////////////////

                    hamahang_0_ver21.SetDataSource(ds);
                    hamahang_0_ver21.SetParameterValue("schoolname", Properties.Settings.Default.schoolname);
                    hamahang_0_ver21.SetParameterValue("hamahang_name", strhead);
                    hamahang_0_ver21.SetParameterValue("saletahsili", strbehav);
                    hamahang_0_ver21.SetParameterValue("classname", teachername);
                    crystalReportViewer1.ReportSource = hamahang_0_ver21;
                    crystalReportViewer1.Zoom(1);
                    break;
                case "hamahangreport_listnumber2":
                    hamahang_listnumber21.SetDataSource(setdt);
                    hamahang_listnumber21.SetParameterValue("school", Properties.Settings.Default.schoolname);
                    hamahang_listnumber21.SetParameterValue("title", strhead);
                    DataTable dtlesson = (DataTable)array_param[0];
                    for (int i = 0; i < dtlesson.Rows.Count; i++)
                        hamahang_listnumber21.SetParameterValue("s" + (i + 1).ToString(), dtlesson.Rows[i][1].ToString());
                    for (int j = dtlesson.Rows.Count; j < 20; j++)
                        hamahang_listnumber21.SetParameterValue("s" + (j + 1).ToString(), "  ");
                    crystalReportViewer1.ReportSource = hamahang_listnumber21;
                    crystalReportViewer1.Zoom(1);
                    break;
                case "hamahangreport_2":
                    hamahang_2_dorosreport1.InitReport += new System.EventHandler(loadfinish);
                    hamahang_2_dorosreport1.SetDataSource(ds);
                    hamahang_2_dorosreport1.SetParameterValue("schoolname", Properties.Settings.Default.schoolname);
                    hamahang_2_dorosreport1.SetParameterValue("hamahang_name", strhead);
                    hamahang_2_dorosreport1.SetParameterValue("saletahsili", strbehav);
                    crystalReportViewer1.ReportSource = hamahang_2_dorosreport1;
                    crystalReportViewer1.Zoom(1);
                    break;
                case "nemodar_paye":
                    nemodar_paye1.InitReport += new System.EventHandler(loadfinish);
                    nemodar_paye1.SetDataSource(ds);
                    nemodar_paye1.SetParameterValue("schoolname", Properties.Settings.Default.schoolname);
                    nemodar_paye1.SetParameterValue("datef", strhead);
                    nemodar_paye1.SetParameterValue("datet", strbehav);
                    crystalReportViewer1.ReportSource = nemodar_paye1;
                    crystalReportViewer1.Zoom(1);
                    break;
                case "mali_2":
                    mali21.InitReport += new System.EventHandler(loadfinish);
                    mali21.SetDataSource(ds);
                    mali21.SetParameterValue("sn", Properties.Settings.Default.schoolname);
                    mali21.SetParameterValue("head", strhead);
                    crystalReportViewer1.ReportSource = mali21;
                    crystalReportViewer1.Zoom(1);
                    break;
                case "stu_av":
                    studentlist_av1.InitReport += new System.EventHandler(loadfinish);
                    studentlist_av1.SetDataSource(dt);
                    studentlist_av1.SetParameterValue("sn", Properties.Settings.Default.schoolname);
                    studentlist_av1.SetParameterValue("classname", Properties.Settings.Default.tempstr);
                    studentlist_av1.SetParameterValue("str", strhead);
                    crystalReportViewer1.ReportSource = studentlist_av1;
                    crystalReportViewer1.Zoom(1);
                    break;
                case "grade_av_list":
                    grade_av_list1.InitReport += new System.EventHandler(loadfinish);
                    grade_av_list1.SetDataSource(dt);
                    grade_av_list1.SetParameterValue("sn", Properties.Settings.Default.schoolname);
                    grade_av_list1.SetParameterValue("paye", strhead);
                    grade_av_list1.SetParameterValue("str", teachername);
                    grade_av_list1.SetParameterValue("lesson_list", strtmp);
                    crystalReportViewer1.ReportSource = grade_av_list1;
                    crystalReportViewer1.Zoom(1);
                    break;
                case "list_number_tizhoshan":
                    listnumber_tizhoshan1.InitReport += new System.EventHandler(loadfinish);
                    /////////////// load bitmap
                    try
                    {
                        string filename = Student.Properties.Settings.Default.armlocation;
                        //Read file and make it to arrays of bytes
                        System.IO.FileStream fs = new System.IO.FileStream(filename, System.IO.FileMode.Open);
                        System.IO.BinaryReader br = new System.IO.BinaryReader(fs);
                        byte[] bs = br.ReadBytes((int)fs.Length);
                        fs.Close();
                        br.Close();
                        for (int tt = 0; tt < dt.Rows.Count; tt++)
                            dt.Rows[tt]["LOGO"] = bs;
                    }
                    catch
                    { }
                    ///////////////////////////                     
                    listnumber_tizhoshan1.SetDataSource(dt);
                    listnumber_tizhoshan1.SetParameterValue("sch", Properties.Settings.Default.schoolname);
                    listnumber_tizhoshan1.SetParameterValue("class", strhead);
                    listnumber_tizhoshan1.SetParameterValue("strdate", teachername);
                    listnumber_tizhoshan1.SetParameterValue("head", strbehav);
                    for (int i = 1; i <= 12; i++)
                    {
                        listnumber_tizhoshan1.SetParameterValue("l_" + i.ToString(), array_param[i - 1].ToString());
                    }
                    crystalReportViewer1.ReportSource = listnumber_tizhoshan1;
                    crystalReportViewer1.Zoom(1);
                    break;
                case "list_number_tizhoshan_sort_lname":
                    listnumber_tizhoshan_sort_lname1.InitReport += new System.EventHandler(loadfinish);
                    /////////////// load bitmap
                    try
                    {
                        string filename = Student.Properties.Settings.Default.armlocation;
                        //Read file and make it to arrays of bytes
                        System.IO.FileStream fs = new System.IO.FileStream(filename, System.IO.FileMode.Open);
                        System.IO.BinaryReader br = new System.IO.BinaryReader(fs);
                        byte[] bs = br.ReadBytes((int)fs.Length);
                        fs.Close();
                        br.Close();
                        for (int tt = 0; tt < dt.Rows.Count; tt++)
                            dt.Rows[tt]["LOGO"] = bs;
                    }
                    catch
                    { }
                    ///////////////////////////                     
                    listnumber_tizhoshan_sort_lname1.SetDataSource(dt);
                    listnumber_tizhoshan_sort_lname1.SetParameterValue("sch", Properties.Settings.Default.schoolname);
                    listnumber_tizhoshan_sort_lname1.SetParameterValue("class", strhead);
                    listnumber_tizhoshan_sort_lname1.SetParameterValue("strdate", teachername);
                    listnumber_tizhoshan_sort_lname1.SetParameterValue("head", strbehav);
                    for (int i = 1; i <= 12; i++)
                    {
                        listnumber_tizhoshan_sort_lname1.SetParameterValue("l_" + i.ToString(), array_param[i - 1].ToString());
                    }
                    crystalReportViewer1.ReportSource = listnumber_tizhoshan_sort_lname1;
                    crystalReportViewer1.Zoom(1);
                    break;
                case "list_number_tiz2":
                    list__number_tiz21.InitReport += new System.EventHandler(loadfinish);
                    list__number_tiz21.SetDataSource(dt);
                    list__number_tiz21.SetParameterValue("sch", Properties.Settings.Default.schoolname);
                    list__number_tiz21.SetParameterValue("ids_lesson", strtmp2);
                    list__number_tiz21.SetParameterValue("strclass", strtmp);

                    list__number_tiz21.SetParameterValue("strhead", strbehav);
                    for (int i = 1; i <= 10; i++)
                    {
                        list__number_tiz21.SetParameterValue("s" + i.ToString(), array_param[i - 1].ToString());
                    }
                    crystalReportViewer1.ReportSource = list__number_tiz21;
                    crystalReportViewer1.Zoom(1);
                    break;
                case "behavclasss":
                    classbehav1.InitReport += new System.EventHandler(loadfinish);
                    classbehav1.SetDataSource(ds);
                    classbehav1.SetParameterValue("schoolname", Properties.Settings.Default.schoolname);
                    classbehav1.SetParameterValue("strpost", Properties.Settings.Default.tempstr);
                    crystalReportViewer1.ReportSource = classbehav1;
                    crystalReportViewer1.Zoom(1);
                    break;
                case "family":
                    tofamily1.InitReport += new System.EventHandler(loadfinish);
                    /////////////// load bitmap
                    try
                    {
                        string filename = Student.Properties.Settings.Default.armlocation;
                        //Read file and make it to arrays of bytes
                        System.IO.FileStream fs = new System.IO.FileStream(filename, System.IO.FileMode.Open);
                        System.IO.BinaryReader br = new System.IO.BinaryReader(fs);
                        byte[] bs = br.ReadBytes((int)fs.Length);
                        fs.Close();
                        br.Close();
                        ds.Tables["student"].Rows[0][4] = bs;
                    }
                    catch
                    { }
                    ///////////////////////////
                    tofamily1.SetDataSource(ds);
                    for (int i = 1; i <= 7; i++)
                        tofamily1.SetParameterValue("sus_" + i.ToString(), (object)(!arb[i]));
                    tofamily1.SetParameterValue("sn", Properties.Settings.Default.schoolname);
                    tofamily1.SetParameterValue("rotbe", rotbe.ToString());
                    tofamily1.SetParameterValue("rotbepaye", rotbepaye.ToString());
                    tofamily1.SetParameterValue("maxp", max.ToString());
                    tofamily1.SetParameterValue("minp", min.ToString());
                    if (av.ToString() == "NaN") av = 0;
                    tofamily1.SetParameterValue("ave", av.ToString());
                    tofamily1.SetParameterValue("stum", stumoadelkol.ToString());
                    tofamily1.SetParameterValue("strhead", strhead);
                    tofamily1.SetParameterValue("strbehav", strbehav);
                    tofamily1.SetParameterValue("scorebehav", sumbehav);
                    tofamily1.SetParameterValue("email", strtmp);

                    if (strtmp2 == "d")
                        tofamily1.PrintOptions.PrinterDuplex = CrystalDecisions.Shared.PrinterDuplex.Vertical;

                    if (directprint)
                    {
                        tofamily1.PrintOptions.PrinterName = pd.PrinterSettings.PrinterName;
                        tofamily1.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait;
                        tofamily1.PrintOptions.ApplyPageMargins(new CrystalDecisions.Shared.PageMargins(30, 30, 30, 30));
                        while (!tofamily1.IsLoaded) ;
                        tofamily1.PrintToPrinter(1, false, 1, 100);
                        Close();
                    }
                    crystalReportViewer1.ReportSource = tofamily1;
                    crystalReportViewer1.Zoom(1);
                    break;
                case "cost":
                    cost1.SetDataSource(dt);
                    cost1.SetParameterValue("t", teachername);
                    crystalReportViewer1.ReportSource = cost1;
                    crystalReportViewer1.Zoom(1);
                    break;
                case "class_salane":
                    class_salane1.SetDataSource(dt);
                    class_salane1.SetParameterValue("sch", Properties.Settings.Default.schoolname);
                    class_salane1.SetParameterValue("line", strtmp);
                    crystalReportViewer1.ReportSource = class_salane1;
                    crystalReportViewer1.Zoom(1);
                    break;
                case "ravand_salane":
                    ravand_salane1.SetDataSource(dt);
                    ravand_salane1.SetParameterValue("sn", Properties.Settings.Default.schoolname);
                    ravand_salane1.SetParameterValue("line", strtmp);
                    crystalReportViewer1.ReportSource = ravand_salane1;
                    crystalReportViewer1.Zoom(1);
                    break;
                case "rep3_salane":
                    rep3_salane1.SetDataSource(dt);
                    rep3_salane1.SetParameterValue("sch", Properties.Settings.Default.schoolname);
                    rep3_salane1.SetParameterValue("line", strtmp);
                    crystalReportViewer1.ReportSource = rep3_salane1;
                    crystalReportViewer1.Zoom(1);
                    break;

            }
            Properties.Settings.Default.proc_finish = true;
            Text = "پیش نمایش";
        }
        public DataTable setdt
        {
            set
            {
                dt = value;
            }
            get
            {
                return dt;
            }
        }
        public string Reportsource
        {
            set
            {
                reportsource = value;
            }
            get
            {
                return reportsource;
            }
        }
        private void loadfinish(object sender, EventArgs e)
        {
            if (!directprint)
                Text = "پیش نمایش";
        }
    }
}