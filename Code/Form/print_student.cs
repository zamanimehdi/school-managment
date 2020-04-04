using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Student
{
    public partial class frmp_student : Form
    {
        /// Variable
        /// ******************************
        enum statusenum { s_new, s_edit, s_none };
        //statusenum status = statusenum.s_none;
        //bool cangotoeditstatus = true;
        int counterforfilter = 0;
        int recordcount;
        frm_proces frm_p = new frm_proces();
        frm_preview form = new frm_preview();

        /// Initialize
        /// ******************************
        public frmp_student()
        {
            InitializeComponent();
        }
        /// Method
        /// ******************************
        private void setfilterwidth()
        {
            bool b;
            for (int i = 0; i < flp_f.Controls.Count ; i++)
            {
                if (i % 2 == 0) b = true; else b = false;
                flp_f.Controls[i].Width = dataGrid.Columns[i].Width - (b ? 0 : 1);
            }
            flp_f.Controls[flp_f.Controls.Count - 1].Width += flp_f.Controls[flp_f.Controls.Count - 1].Location.X;
        }
        private void filtertxtclear()
        {
            for (int i = 0; i < flp_f.Controls.Count; i++)
                flp_f.Controls[i].Text = "";
        }
        /// Event 
        /// ******************************
        private void frmp_student_Load(object sender, EventArgs e)
        {
        }
        private void btn_new_Click(object sender, EventArgs e)
        {
            timer3.Enabled = true;
            frm_p.Show();
            frm_p.Refresh();
            Properties.Settings.Default.ps_chk_footer = chk_footer.Checked;
            Properties.Settings.Default.ps_chk_group = chk_group.Checked;
            Properties.Settings.Default.ps_chk_pagetitle = chk_title.Checked;
            Properties.Settings.Default.ps_pagenumber = chk_pagenumber.Checked;
            if (rab_class.Checked) Properties.Settings.Default.ps_rabs = 1;
            if (rab_major.Checked) Properties.Settings.Default.ps_rabs = 2;
            if (rab_grade.Checked) Properties.Settings.Default.ps_rabs = 3;
            if (rab_a.Checked) Properties.Settings.Default.ps_rab_sorttype = 1;
            else Properties.Settings.Default.ps_rab_sorttype = 2;
            if (rab_idstudent.Checked) Properties.Settings.Default.ps_rab_sortby = 1;
            if (rab_lname.Checked) Properties.Settings.Default.ps_rab_sortby = 2;
            if (rab_name.Checked) Properties.Settings.Default.ps_rab_sortby = 3;
            Properties.Settings.Default.ps_txt_footer = txt_footer.Text;
            Properties.Settings.Default.ps_txt_pagetitle = txt_title.Text;
            Properties.Settings.Default.Save();

            form.setdt = ((DataView)studentBindingSource.List).ToTable();
            if (!chk_group.Checked) form.Reportsource = "student_nogroup";
            else
            {
                if (rab_class.Checked) form.Reportsource = "student_class";
                if (rab_grade.Checked) form.Reportsource = "student_grade";
                if (rab_major.Checked) form.Reportsource = "student_major";
            }
            backgroundWorker3.RunWorkerAsync();
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
               Opacity = 0; Close();
                backgroundWorker_s.CancelAsync();
        }
        private void btn_last_Click(object sender, EventArgs e)
        {
            studentBindingSource.MoveLast();
        }
        private void btn_next_Click(object sender, EventArgs e)
        {
            studentBindingSource.MoveNext();
        }
        private void btn_prev_Click(object sender, EventArgs e)
        {
            studentBindingSource.MovePrevious();
        }
        private void btn_first_Click(object sender, EventArgs e)
        {
            studentBindingSource.MoveFirst();
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
            ((Control)sender).BackColor = Color.Empty;
        }
        private void entercolor(object sender, EventArgs e)
        {
            ((Control)sender).BackColor = Color.SeaShell;
        }
        private void dataGrid_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            if (timer1.Enabled == false) timer1.Enabled = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            counterforfilter++;
            if (counterforfilter == 2)
            {
                counterforfilter = 0;
                timer1.Enabled = false;
                setfilterwidth();
            }
        }
        private void actfilter(object sender, EventArgs e)
        {
            if (canfillter())
            {
                string str_f = "";
                int len_str_f = 0;      // ☻// ☻// ☻
                if (txt_idstudent_f.Text != "") str_f += " idstudent = " + txt_idstudent_f.Text ;
                if (txt_lname_f.Text != "")
                {
                    if (len_str_f != str_f.Length) { str_f += " and "; len_str_f = str_f.Length; }
                    str_f += " lname like '" + txt_lname_f.Text + "%'";
                }
                if (txt_name_f.Text != "")
                {
                    if (len_str_f != str_f.Length) { str_f += " and "; len_str_f = str_f.Length; }
                    str_f += " name like '" + txt_name_f.Text+"%'";
                }
                if (txt_sh_f.Text != "")
                {
                    if (len_str_f != str_f.Length) { str_f += " and "; len_str_f = str_f.Length; }
                    str_f += " sh like '" + txt_sh_f.Text+"%'";
                }
                if (txt_fname_f.Text != "")
                {
                    if (len_str_f != str_f.Length) { str_f += " and "; len_str_f = str_f.Length; }
                    str_f += " fname like '" + txt_fname_f.Text + "%'";
                }
                if (txt_tell_f.Text != "")
                {
                    if (len_str_f != str_f.Length) { str_f += " and "; len_str_f = str_f.Length; }
                    str_f += " tell like '" + txt_tell_f.Text + "%'";
                }
                if (txt_classname_f.Text != "")
                {
                    if (len_str_f != str_f.Length) { str_f += " and "; len_str_f = str_f.Length; }
                    str_f += " classname like '" + txt_classname_f.Text + "%'";
                }
                if (txt_grade_f.Text != "")
                {
                    if (len_str_f != str_f.Length) { str_f += " and "; len_str_f = str_f.Length; }
                    str_f += " grade = " + txt_grade_f.Text ;
                }
                if (txt_majorname_f.Text != "")
                {
                    if (len_str_f != str_f.Length) { str_f += " and "; len_str_f = str_f.Length; }
                    str_f += " majorname like '" + txt_majorname_f.Text + "%'";
                }
                studentBindingSource.Filter = str_f;
            }
        }
        private bool canfillter()
        {
            for (int i = 0; i < flp_f.Controls.Count; i++)
                flp_f.Controls[i].Text = flp_f.Controls[i].Text.Trim();
            can test = new can();
            if (test.isnumber(txt_idstudent_f,txt_grade_f) & test.isstring(txt_lname_f, txt_name_f,txt_fname_f))
                return true;
            else
                return false;
        }
        private void backgroundWorker_s_DoWork(object sender, DoWorkEventArgs e)
        {
            this.studentTableAdapter.Fill(this.dsp_student.student);
        }
        private void backgroundWorker_s_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            timer2.Enabled = false;
            prba.Value = 100;
            prba.Refresh();
            lbl_prba1.Text = "100%";
            lbl_prba1.Refresh();
            this.dataGrid.DataSource = this.studentBindingSource;
            btn_preview.Enabled = true;
            pnl_prba.Visible = false;
            btn_preview.Focus();
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            prba.Value = Convert.ToInt32((dsp_student.student.Count * 100) / recordcount);// ☻
            lbl_prba1.Text = prba.Value.ToString() + "%";
            if (recordcount == dsp_student.student.Count) backgroundWorker_s_RunWorkerCompleted(null, null);
        }
        private void chk_group_CheckedChanged(object sender, EventArgs e)
        {
            rab_class.Enabled = rab_grade.Enabled = rab_major.Enabled = chk_group.Checked;
        }
        private void chk_title_CheckedChanged(object sender, EventArgs e)
        {
            txt_title.Enabled = chk_title.Checked;
        }
        private void chk_footer_CheckedChanged(object sender, EventArgs e)
        {
            txt_footer.Enabled = chk_footer.Checked;
        }
        private void rab_sortby_CheckedChanged(object sender, EventArgs e)
        {
            if (rab_idstudent.Checked) studentBindingSource.Sort = "idstudent " + (rab_a.Checked == true ? "ASC" : "DESC");
            if (rab_lname.Checked) studentBindingSource.Sort = "lname " + (rab_a.Checked == true ? "ASC" : "DESC");
            if (rab_name.Checked) studentBindingSource.Sort = "name " + (rab_a.Checked == true ? "ASC" : "DESC");
        }
        private void rab_sorttype_change(object sender, EventArgs e)
        {
            if (rab_idstudent.Checked) studentBindingSource.Sort = "idstudent " + (rab_a.Checked == true ? "ASC" : "DESC");
            if (rab_lname.Checked) studentBindingSource.Sort = "lname " + (rab_a.Checked == true ? "ASC" : "DESC");
            if (rab_name.Checked) studentBindingSource.Sort = "name " + (rab_a.Checked == true ? "ASC" : "DESC");
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.proc_finish)
            {
                timer3.Enabled = false;
                frm_p.Close();
                Properties.Settings.Default.proc_finish = true;
               Opacity = 0; Close();
            }
        }
        private void backgroundWorker3_DoWork(object sender, DoWorkEventArgs e)
        {
            frm_preview frm_previw = new frm_preview();
            frm_previw.setdt = form.setdt;
            frm_previw.Reportsource = form.Reportsource;
            frm_previw.ShowDialog();
        }
        private void frmp_student_Shown(object sender, EventArgs e)
        {
            dataGrid.AutoGenerateColumns = false;
            setfilterwidth();
            Refresh();
            Opacity = 1;
            switch (Properties.Settings.Default.ps_rab_sorttype)
            {
                case 1:
                    rab_a.Checked = true;
                    break;
                case 2:
                    rab_d.Checked = true;
                    break;
            }
            switch (Properties.Settings.Default.ps_rab_sortby)
            {
                case 1:
                    rab_idstudent.Checked = true;
                    studentBindingSource.Sort = "idstudent " + (rab_a.Checked == true ? "ASC" : "DESC");
                    dataGrid.Sort(dataGrid.Columns[0], rab_a.Checked == true ? ListSortDirection.Ascending : ListSortDirection.Descending);
                    break;
                case 2:
                    rab_lname.Checked = true;
                    studentBindingSource.Sort = "lname " + (rab_a.Checked == true ? "ASC" : "DESC");
                    break;
                case 3:
                    rab_name.Checked = true;
                    studentBindingSource.Sort = "name " + (rab_a.Checked == true ? "ASC" : "DESC");
                    break;
            }
            txt_footer.Enabled = chk_footer.Checked = Properties.Settings.Default.ps_chk_footer;
            rab_class.Enabled = rab_grade.Enabled = rab_major.Enabled = chk_group.Checked = Properties.Settings.Default.ps_chk_group;
            txt_title.Enabled = chk_title.Checked = Properties.Settings.Default.ps_chk_pagetitle;
            chk_pagenumber.Checked = Properties.Settings.Default.ps_pagenumber;
            switch (Properties.Settings.Default.ps_rabs)
            {
                case 1:
                    rab_class.Checked = true;
                    break;
                case 2:
                    rab_major.Checked = true;
                    break;
                case 3:
                    rab_grade.Checked = true;
                    break;
            }
            txt_footer.Text = Properties.Settings.Default.ps_txt_footer;
            txt_title.Text = Properties.Settings.Default.ps_txt_pagetitle;

            recordcount = Int32.Parse(studentTableAdapter.recordcount().ToString());// ☻
            if (recordcount < 1) pnl_prba.Visible = false;
            else timer2.Enabled = true;
            backgroundWorker_s.RunWorkerAsync();
            

        }
    }
}