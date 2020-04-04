using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Student
{
    public partial class frm_listnumber : Form
    {
        frm_proces frm_p = new frm_proces();
        frm_preview form = new frm_preview();
        public frm_listnumber()
        {
            InitializeComponent();
        }
        private void listnumber_Load(object sender, EventArgs e)
        {
            Text = "صبر کنید";
            Enabled = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (cmb_class.Text != "")
            {
                Properties.Settings.Default.ln_chk_lessonchart = chk_lessonchart.Checked;
                Properties.Settings.Default.ln_chk_classavgchart = chk_classavgchart.Checked;
                Properties.Settings.Default.ln_chk_footer = chk_footer.Checked;
                Properties.Settings.Default.ln_chk_groupstudent = chk_groupstudent.Checked;
                Properties.Settings.Default.ln_chk_pagenumber = chk_pagenumber.Checked;
                Properties.Settings.Default.ln_chk_title = chk_title.Checked;
                Properties.Settings.Default.ln_rab_selsectclass = rab_selsectclass.Checked;
                Properties.Settings.Default.ln_txt_footer = txt_footer.Text;
                Properties.Settings.Default.ln_txt_title = txt_title.Text;
                Properties.Settings.Default.ln_chk_listnumber = chk_numberlist.Checked;
                Properties.Settings.Default.ln_chk_avnumber = chk_avnumber.Checked;
                Properties.Settings.Default.printkarnamedatefrom = txt_datefrom.Text;
                Properties.Settings.Default.printkarnamedateto = txt_dateto.Text;
                Properties.Settings.Default.Save();
                string str = "";
                can test = new can();
                bool b = true;
                if (chk_groupstudent.Checked)
                {
                    if (rab_selsectclass.Checked)
                    {
                        b = test.checkempty(cmb_class);
                        if (cmb_class.Text != "همه کلاسها")
                            str += "classname = '" + cmb_class.Text + "'";
                    }
                    else
                    {
                        b = test.checkempty(txt_idstudent) && test.isnumber(txt_idstudent);
                        str += "idstudent=" + txt_idstudent.Text;
                    }
                    form.Reportsource = "listnumber_1";
                    if (b && rab_selsectclass.Checked)
                    {
                        try
                        {
                            bool m = true;
                            if (txt_datefrom.Text != "" && txt_dateto.Text == "")
                            {
                                if (str.Length != 0) str += " and";
                                str += " date>='" + txt_datefrom.Text + "'";
                                m = test.isdate(txt_datefrom);
                            }
                            if (txt_datefrom.Text == "" && txt_dateto.Text != "")
                            {
                                if (str.Length != 0) str += " and";
                                str += " date<='" + txt_dateto.Text + "'";
                                m = test.isdate(txt_dateto);
                            }
                            if (txt_datefrom.Text != "" && txt_dateto.Text != "")
                            {
                                if (str.Length != 0) str += " and";
                                str += " date<='" + txt_dateto.Text + "' and " +
                                    " date>='" + txt_datefrom.Text + "'";
                                m = test.isdate(txt_dateto) && test.isdate(txt_datefrom);
                            }
                            if (m)
                            {
                                //timer1.Enabled = true;
                                //frm_p.Show();
                                //frm_p.Refresh();
                                studentBindingSource.Filter = str;
                                string datefromstr = "0";
                                string datetostr = "999999";
                                if (txt_datefrom.Text != "") datefromstr = txt_datefrom.Text;
                                if (txt_dateto.Text != "") datetostr = txt_dateto.Text;
                                PrintDialog pd = new PrintDialog();
                                pd.UseEXDialog = false;
                                pd.ShowHelp = false;
                                pd.AllowSomePages = false;
                                pd.AllowSelection = false;
                                pd.AllowPrintToFile = false;
                                pd.AllowCurrentPage = false;
                                this.Refresh();
                                if (pd.ShowDialog() == DialogResult.OK)
                                {
                                    student_listTableAdapter.Fill(dsp_listnumber.student_list, (Int32)cmb_class.SelectedValue);
                                    pnl_p1.Visible = pnl_p2.Visible = prg_p.Visible = lbl_p.Visible = true;
                                    groupBox1.Enabled = chk_groupstudent.Enabled = chk_grouptest.Enabled = grp_setting.Enabled = groupBox2.Enabled = btn_exit.Enabled = btn_preview.Enabled = false;
                                    for (int ci = 0; ci < dsp_listnumber.student_list.Rows.Count; ci++)
                                    {
                                        prg_p.Value = ((100 * ci) / dsp_listnumber.student_list.Rows.Count);
                                        lbl_p.Text = "در حال پرینت " + Convert.ToString(ci + 1) + " از " + dsp_listnumber.student_list.Rows.Count + " دانش آموز";
                                        this.Refresh();
                                        this.studentTableAdapter.Fill(this.dsp_listnumber.student, decimal.Parse(dsp_listnumber.student_list.Rows[ci][0].ToString()));
                                        moadelTableAdapter.Fill(dsp_listnumber.moadel, datefromstr, datetostr);
                                        //avgclassTableAdapter.Fill(dsp_listnumber.avgclass, datefromstr, datetostr, (Int32)cmb_class.SelectedValue);
                                        moadelkolTableAdapter.Fill(dsp_listnumber.moadelkol, datefromstr, datetostr);
                                        DataTable dt = ((DataView)studentBindingSource.List).ToTable();
                                        System.Data.DataSet ds = new System.Data.DataSet();
                                        ds.Tables.Add(dt);
                                        ds.Tables.Add(dsp_listnumber.moadel.Copy());
                                        //ds.Tables.Add(dsp_listnumber.avgclass.Copy());
                                        ds.Tables.Add(dsp_listnumber.moadelkol.Copy());
                                        ////
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
                                        if (!Properties.Settings.Default.ln_chk_avnumber)
                                            listnumber1.GroupHeaderSection5.SectionFormat.EnableSuppress = true;
                                        if (!Properties.Settings.Default.ln_chk_listnumber)
                                            listnumber1.GroupHeaderSection2.SectionFormat.EnableSuppress = true;
                                        if (!Properties.Settings.Default.ln_chk_classavgchart)
                                            listnumber1.GroupHeaderSection7.SectionFormat.EnableSuppress = true;
                                        if (!Properties.Settings.Default.ln_chk_pagenumber)
                                            listnumber1.Section5.ReportObjects[0].Width = 0;
                                        //crystalReportViewer1.ReportSource = listnumber1;

                                        listnumber1.PrintOptions.CopyFrom(pd.PrinterSettings, new System.Drawing.Printing.PageSettings());
                                        listnumber1.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Landscape;
                                        listnumber1.PrintOptions.ApplyPageMargins(new CrystalDecisions.Shared.PageMargins(65, 65, 65, 65));
                                        listnumber1.PrintToPrinter(1, false, 1, 50);
                                        // crystalReportViewer1.PrintReport();
                                    }
                                    pnl_p1.Visible = pnl_p2.Visible = prg_p.Visible = lbl_p.Visible = false;
                                    groupBox1.Enabled = chk_groupstudent.Enabled = chk_grouptest.Enabled = grp_setting.Enabled = groupBox2.Enabled = btn_exit.Enabled = btn_preview.Enabled = true;
                                    //crystalReportViewer1.Zoom(1);
                                    ////
                                    //form.ds = ds;
                                    //backgroundWorker1.RunWorkerAsync();
                                }
                            }
                            else
                            {
                                MessageBox.Show("اطلاعات ورودی اشتباه می باشد");
                            }
                        }
                        catch
                        {
                            MessageBox.Show("اطلاعات ورودی اشتباه می باشد");
                        }
                    }
                    else if (b && rab_onestudentselect.Checked)
                    {
                        bool m = true;
                        if (txt_datefrom.Text != "" && txt_dateto.Text == "")
                        {
                            if (str.Length != 0) str += " and";
                            str += " date>='" + txt_datefrom.Text + "'";
                            m = test.isdate(txt_datefrom);
                        }
                        if (txt_datefrom.Text == "" && txt_dateto.Text != "")
                        {
                            if (str.Length != 0) str += " and";
                            str += " date<='" + txt_dateto.Text + "'";
                            m = test.isdate(txt_dateto);
                        }
                        if (txt_datefrom.Text != "" && txt_dateto.Text != "")
                        {
                            if (str.Length != 0) str += " and";
                            str += " date<='" + txt_dateto.Text + "' and " +
                                " date>='" + txt_datefrom.Text + "'";
                            m = test.isdate(txt_dateto) && test.isdate(txt_datefrom);
                        }
                        if (m)
                        {
                            timer1.Enabled = true;
                            frm_p.Show();
                            frm_p.Refresh();
                            studentBindingSource.Filter = str;
                            string datefromstr = "0";
                            string datetostr = "999999";
                            if (txt_datefrom.Text != "") datefromstr = txt_datefrom.Text;
                            if (txt_dateto.Text != "") datetostr = txt_dateto.Text;
                            this.studentTableAdapter.Fill(this.dsp_listnumber.student, decimal.Parse(txt_idstudent.Text));
                            moadelTableAdapter.Fill(dsp_listnumber.moadel, datefromstr, datetostr);
                            //avgclassTableAdapter.Fill(dsp_listnumber.avgclass, datefromstr, datetostr, Int32.Parse(dsp_listnumber.student[0]["grade"].ToString()));
                            moadelkolTableAdapter.Fill(dsp_listnumber.moadelkol, datefromstr, datetostr);
                            DataTable dt = ((DataView)studentBindingSource.List).ToTable();
                            System.Data.DataSet ds = new System.Data.DataSet();
                            ds.Tables.Add(dt);
                            ds.Tables.Add(dsp_listnumber.moadel.Copy());
                            //ds.Tables.Add(dsp_listnumber.avgclass.Copy());
                            ds.Tables.Add(dsp_listnumber.moadelkol.Copy());
                            form.ds = ds;
                            backgroundWorker1.RunWorkerAsync();
                        }
                    }
                    else
                    {
                        MessageBox.Show("اطلاعات ورودی اشتباه می باشد");
                    }
                }
                else
                {
                    string start="000000";
                    string end="999999";
                    if (txt_datefrom2.Text != "") start = txt_datefrom2.Text;
                    if (txt_dateto2.Text != "") end = txt_dateto2.Text;
                    this.listnumber3TableAdapter.Fill(this.dsp_listnumber3.listnumber3, Int32.Parse((((DataView)(classBindingSource2.List))[cmb_lesson.SelectedIndex][2]).ToString()), Int32.Parse((((DataView)(classBindingSource2.List))[cmb_lesson.SelectedIndex][1]).ToString()),start,end);
                    str = "";
                    form.Reportsource = "listnumber_2";
                    bool m = true;
                    if (txt_datefrom2.Text != "" && txt_dateto2.Text == "")
                    {
                        if (str.Length != 0) str += " and";
                        str += " date>='" + txt_datefrom2.Text + "'";
                        m = test.isdate(txt_datefrom2);
                    }
                    if (txt_datefrom2.Text == "" && txt_dateto2.Text != "")
                    {
                        if (str.Length != 0) str += " and";
                        str += " date<='" + txt_dateto2.Text + "'";
                        m = test.isdate(txt_dateto2);
                    }
                    if (txt_datefrom2.Text != "" && txt_dateto2.Text != "")
                    {
                        if (str.Length != 0) str += " and";
                        str += " date<='" + txt_dateto2.Text + "' and " +
                            " date>='" + txt_datefrom2.Text + "'";
                        m = test.isdate(txt_dateto2) && test.isdate(txt_datefrom2);
                    }
                    if (m)
                    {
                        Properties.Settings.Default.tempstr = cmb_lesson.Text;
                        timer1.Enabled = true;
                        frm_p.Show();
                        frm_p.Refresh();
                       // listnumber3BindingSource.Filter = str;
                        DataTable dt = ((DataView)listnumber3BindingSource.List).ToTable();
                        form.setdt = dt;
                        backgroundWorker1.RunWorkerAsync();
                    }
                    else
                    {
                        MessageBox.Show("اطلاعات ورودی اشتباه می باشد");
                    }

                }

            }
        }
        private void chk_groupstudent_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_groupstudent.Checked)
            {
                groupBox2.Enabled = chk_grouptest.Checked = false;
                chk_groupstudent.Checked = groupBox1.Enabled = true;
            }
            else
            {
               // chk_groupstudent.Checked = true;
                groupBox2.Enabled = chk_grouptest.Checked = true;
                chk_groupstudent.Checked = groupBox1.Enabled = false;
            }
        }
        private void chk_title_CheckedChanged(object sender, EventArgs e)
        {
            txt_title.Enabled = !txt_title.Enabled;
        }
        private void chk_footer_CheckedChanged(object sender, EventArgs e)
        {
            txt_footer.Enabled = !txt_footer.Enabled;
        }
        private void chk_grouptest_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_grouptest.Checked)
            {
               // MessageBox.Show("این قسمت غیر فعال می باشد");
                //chk_grouptest.Checked = false;
                groupBox2.Enabled = chk_grouptest.Checked = true;
                chk_groupstudent.Checked = groupBox1.Enabled = false;
            }
            else
            {
                groupBox2.Enabled = chk_grouptest.Checked = false;
                chk_groupstudent.Checked = groupBox1.Enabled = true;
            }
        }
        private void rab_selsectclass_CheckedChanged(object sender, EventArgs e)
        {
            cmb_class.Enabled = rab_selsectclass.Checked;
        }
        private void rab_onestudentselect_CheckedChanged(object sender, EventArgs e)
        {
            txt_idstudent.Enabled=btn_stselect.Enabled = rab_onestudentselect.Checked;
        }
        private void leavecolor(object sender, EventArgs e)
        {
            ((Control)sender).BackColor = Color.Empty;
        }
        private void entercolor(object sender, EventArgs e)
        {
            ((Control)sender).BackColor = Color.SeaShell;
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
           Opacity = 0; Close();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.proc_finish)
            {
                timer1.Enabled = false;
                frm_p.Close();
                Properties.Settings.Default.proc_finish = true;
               Opacity = 0; Close();
            }
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            frm_preview frm_previw = new frm_preview();
            frm_previw.setdt = form.setdt;
            frm_previw.Reportsource = form.Reportsource;
            frm_previw.ds = form.ds;
            frm_previw.ShowDialog();
        }
        private void btn_stselect_Click(object sender, EventArgs e)
        {
            try
            {
                frm_choosest frm = new frm_choosest();
                frm.forselectstudentinprintnumberlist = true;
                if (frm.ShowDialog() == DialogResult.OK)
                    txt_idstudent.Text = frm.idstudentforselectesstudentforprintnumberlist.ToString();
            }
            catch { }
        }

        private void frm_listnumber_Shown(object sender, EventArgs e)
        {
            this.Refresh();

            // TODO: This line of code loads data into the 'dsp_listnumber3._class' table. You can move, or remove it, as needed.
            this.classTableAdapter1.Fill(this.dsp_listnumber3._class);
            // TODO: This line of code loads data into the 'dsp_listnumber3.listnumber3' table. You can move, or remove it, as needed.
            this.dsp_listnumber2._class.idclassColumn.AutoIncrementSeed = Int32.Parse((this.classTableAdapter.maxidclass().ToString() == "") ? "0" : this.classTableAdapter.maxidclass().ToString()) + 1;
            this.dsp_listnumber2.lesson.idlessonColumn.AutoIncrementSeed = Int32.Parse((this.lessonTableAdapter.maxidlesson().ToString() == "") ? "0" : this.lessonTableAdapter.maxidlesson().ToString()) + 1;
            //dsp_listnumber2.lesson.AddlessonRow("همه دروس");
            classTableAdapter.ClearBeforeFill = false;
            lessonTableAdapter.ClearBeforeFill = false;
            // TODO: This line of code loads data into the 'dsp_listnumber2.lesson' table. You can move, or remove it, as needed.
            this.lessonTableAdapter.Fill(this.dsp_listnumber2.lesson);
            // TODO: This line of code loads data into the 'dsp_listnumber2._class' table. You can move, or remove it, as needed.
            this.classTableAdapter.Fill(this.dsp_listnumber2._class);
            // TODO: This line of code loads data into the 'ds_numberlist.student' table. You can move, or remove it, as needed.
            rab_selsectclass.Checked = Properties.Settings.Default.ln_rab_selsectclass;
            if (Properties.Settings.Default.ln_rab_selsectclass)
                btn_stselect.Enabled = txt_idstudent.Enabled = false;
            else cmb_class.Enabled = false;
            txt_footer.Enabled = chk_footer.Checked = Properties.Settings.Default.ln_chk_footer;
            //bool temp=chk_groupstudent.Checked = groupBox1.Enabled = Properties.Settings.Default.ln_chk_groupstudent;
            groupBox2.Enabled = chk_grouptest.Checked = true;
            chk_pagenumber.Checked = Properties.Settings.Default.ln_chk_pagenumber;
            txt_title.Enabled = chk_title.Checked = Properties.Settings.Default.ln_chk_title;
            txt_title.Text = Properties.Settings.Default.ln_txt_title;
            txt_footer.Text = Properties.Settings.Default.ln_txt_footer;
            chk_lessonchart.Checked = Properties.Settings.Default.ln_chk_lessonchart;
            chk_classavgchart.Checked = Properties.Settings.Default.ln_chk_classavgchart;
            chk_avnumber.Checked = Properties.Settings.Default.ln_chk_avnumber;
            chk_numberlist.Checked = Properties.Settings.Default.ln_chk_listnumber;
            txt_datefrom.Text = Properties.Settings.Default.printkarnamedatefrom;
            txt_dateto.Text = Properties.Settings.Default.printkarnamedateto;
            ///
            Text = "";
            Enabled = true;
        }
    }
}