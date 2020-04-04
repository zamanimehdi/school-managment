using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Student
{
    
    public partial class frm_st_teacher : Form
    {
        /// Variable
        /// ******************************
        enum statusenum { s_new, s_edit, s_none };
        //statusenum status = statusenum.s_none;
        //bool cangotoeditstatus = true;
        int counterforfilter = 0;
        int recordcount;
        public bool isforperint;
        /// Initialize
        /// ******************************
        public frm_st_teacher()
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
        private void frm_st_teacher_Load(object sender, EventArgs e)
        {
        }
        private void btn_new_Click(object sender, EventArgs e)
        {
            if (teacherBindingSource.Current != null)
            {
                if (!isforperint)
                {
                    frm_lessonteacher form = new frm_lessonteacher();
                    form.post = ((DataRowView)teacherBindingSource.Current).Row;
                    form.ShowDialog();
                }
                else
                {
                    //frm_teacherwork form = new frm_teacherwork();
                    //form.post = ((DataRowView)teacherBindingSource.Current).Row;
                    //form.ShowDialog();
                    DataRow post = ((DataRowView)teacherBindingSource.Current).Row;
                    frm_preview frmp = new frm_preview();
                    teacherworkTableAdapter.Fill(dsp_teacherwork.teacherwork, Int32.Parse(post["idteacher"].ToString()));
                    frmp.setdt = dsp_teacherwork.teacherwork;
                    frmp.Reportsource = "teacherwork";
                    frmp.teachername = post["name"].ToString() + " " + post["lname"].ToString();
                    frmp.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("هیچ معلمی انتخاب نشده است");
            }
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
               Opacity = 0; Close();
                backgroundWorker_s.CancelAsync();
        }
        private void btn_last_Click(object sender, EventArgs e)
        {
            teacherBindingSource.MoveLast();
        }
        private void btn_next_Click(object sender, EventArgs e)
        {
            teacherBindingSource.MoveNext();
        }
        private void btn_prev_Click(object sender, EventArgs e)
        {
            teacherBindingSource.MovePrevious();
        }
        private void btn_first_Click(object sender, EventArgs e)
        {
            teacherBindingSource.MoveFirst();
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
                if (txt_name_f.Text != "") str_f += " name like '" + txt_name_f.Text + "%'";
                if (txt_lname_f.Text != "")
                {
                    if (len_str_f != str_f.Length) { str_f += " and "; len_str_f = str_f.Length; }
                    str_f += " lname like '" + txt_lname_f.Text + "%'";
                }
                if (txt_tell_f.Text != "")
                {
                    if (len_str_f != str_f.Length) { str_f += " and "; len_str_f = str_f.Length; }
                    str_f += " tell like '" + txt_tell_f.Text+"%'";
                }
                if (txt_idcode_f.Text != "")
                {
                    if (len_str_f != str_f.Length) { str_f += " and "; len_str_f = str_f.Length; }
                    str_f += " idteacher =" + txt_idcode_f.Text;
                }
                teacherBindingSource.Filter = str_f;
            }
        }
        private bool canfillter()
        {
            for (int i = 0; i < flp_f.Controls.Count; i++)
                flp_f.Controls[i].Text = flp_f.Controls[i].Text.Trim();
            can test = new can();
            if (test.isnumber(txt_idcode_f) & test.isstring(txt_lname_f, txt_name_f))
                return true;
            else
                return false;
        }
        private void frm_st_teacher_KeyDown(object sender, KeyEventArgs e)
        {

        }
        private void dataGrid_KeyDown(object sender, KeyEventArgs e)
        {
        }
        private void backgroundWorker_s_DoWork(object sender, DoWorkEventArgs e)
        {
            teacherTableAdapter.Fill(this.ds_teacher.teacher);// ☻
        }
        private void backgroundWorker_s_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            timer2.Enabled = false;
            prba.Value = 100;
            prba.Refresh();
            lbl_prba1.Text = "100%";
            lbl_prba1.Refresh();
            teacherBindingSource.DataMember = "teacher";// ☻
            teacherBindingSource.DataSource = this.ds_teacher;// ☻
            teacherBindingSource.Sort = "lname";// ☻
            btn_select.Enabled = true;
            pnl_prba.Visible = false;
            btn_select.Focus();
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            prba.Value = Convert.ToInt32((ds_teacher.teacher.Count * 100) / recordcount);// ☻
            lbl_prba1.Text = prba.Value.ToString() + "%";
            if (recordcount == ds_teacher.teacher.Count) backgroundWorker_s_RunWorkerCompleted(null, null);
        }
        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                frm_lessonteacher form = new frm_lessonteacher();
                form.post = ((DataRowView)teacherBindingSource.Current).Row;
                form.ShowDialog();
            }
        }
        private void frm_st_teacher_Shown(object sender, EventArgs e)
        {
            Refresh();
            Opacity = 1;
            recordcount = Int32.Parse(teacherTableAdapter.recordcount().ToString());// ☻
            if (recordcount < 1) pnl_prba.Visible = false;
            else timer2.Enabled = true;
            backgroundWorker_s.RunWorkerAsync();
            setfilterwidth();
        }
    }
}