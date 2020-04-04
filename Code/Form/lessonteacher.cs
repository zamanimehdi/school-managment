using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Student.DataSet.ds_lessonteacherTableAdapters;

namespace Student
{
    public partial class frm_lessonteacher : Form
    {
        /// Variable
        /// ******************************
        enum statusenum { s_new, s_edit, s_none };
        statusenum status = statusenum.s_none;
        bool cangotoeditstatus = true;
        int counterforfilter = 0;
        int recordcount;
        DataRow postdr;
        /// Initialize
        /// ******************************
        public frm_lessonteacher()
        {
            InitializeComponent();
        }
        /// Method
        /// ******************************
        private void invert()
        {
            pnl_nav_datagride.Enabled = !pnl_nav_datagride.Enabled;
            btn_new.Enabled = !btn_new.Enabled;
            btn_save.Enabled = !btn_save.Enabled;
            if (btn_exit.Text == "بازگشت") btn_exit.Text = "انصراف";
            else btn_exit.Text = "بازگشت";
        }
        private void setfilterwidth()
        {
            bool b;
            for (int i = 0; i < flp_f.Controls.Count; i++)
            {
                if (i % 2 == 0) b = true; else b = false;
                flp_f.Controls[i].Width = dataGrid.Columns[i].Width - (b ? 0 : 1);
            }
            flp_f.Controls[flp_f.Controls.Count - 1].Width += flp_f.Controls[flp_f.Controls.Count - 1].Location.X;
        }
        private void inputtxtclear()
        {
            for (int i = 0; i < grb_input.Controls.Count; i++)
                if (grb_input.Controls[i] is ComboBox)
                    grb_input.Controls[i].Text = "";
        }
        private void filtertxtclear()
        {
            for (int i = 0; i < flp_f.Controls.Count; i++)
                flp_f.Controls[i].Text = "";
        }
        private bool allowsave()
        {
            for (int i = 0; i < grb_input.Controls.Count; i++)
                if (grb_input.Controls[i] is ComboBox)
                    grb_input.Controls[i].Text = grb_input.Controls[i].Text.Trim(); ;
            can test = new can();
            if (test.checkempty(cmb_class,cmb_lesson))
                return true;
            else
            {
                MessageBox.Show("اطلاعات ورودی اشتباه می باشد");
                return false;
            }
        }
        private bool allowdel()
        {
            return true;
        }
        private void norecord()
        {
            if (dtlessonteacherBindingSource.Count == 0)
            {
                pnl_nav.Enabled = false;
                for (int i = 0; i < grb_input.Controls.Count; i++)
                    if (grb_input.Controls[i] is ComboBox)
                        grb_input.Controls[i].Enabled = false;
                inputtxtclear();
            }
            else if (pnl_nav.Enabled != true)
            {
                pnl_nav.Enabled = true;
                for (int i = 0; i < grb_input.Controls.Count; i++)
                    if (grb_input.Controls[i] is ComboBox)
                        grb_input.Controls[i].Enabled = true;
            }
        }
        /// Event 
        /// ******************************
        private void frm_lessonteacher_Load(object sender, EventArgs e)
        {
            this.lessonTableAdapter.Fill(this.ds_lessonteacher.lesson);
            this.classTableAdapter.Fill(this.ds_lessonteacher._class);
            string str;
            if ((str=dt_lessonteacherTableAdapter.getmax().ToString())!="")
                ds_lessonteacher.dt_lessonteacher.idlesson_teacherColumn.AutoIncrementSeed = (long.Parse(str)+1);
            this.dt_lessonteacherTableAdapter.Fill(this.ds_lessonteacher.dt_lessonteacher);
            recordcount = Int32.Parse(dt_lessonteacherTableAdapter.recordcount().ToString());// ☻
            if (recordcount <= 1) pnl_prba.Visible = false;
            else timer2.Enabled = true;
            dtlessonteacherBindingSource.Filter = "idteacher=" + postdr["idteacher"].ToString();
            lbl_code_info.Text += " " + postdr["idteacher"].ToString();
            lbl_lname_info.Text += " " + postdr["lname"].ToString();
            lbl_name_info.Text += " " + postdr["name"].ToString();
            lbl_tell_info.Text += " " + postdr["tell"].ToString();
            backgroundWorker_s.RunWorkerAsync();
            norecord();
            setfilterwidth();
        }
        private void btn_new_Click(object sender, EventArgs e)
        {
            invert();
            status = statusenum.s_new;
            inputtxtclear();
            filtertxtclear();
            // فعال کردن تکسباکسها وقتی رکوردی وجود ندارد ▼
            if (pnl_nav.Enabled == false)
                for (int i = 0; i < grb_input.Controls.Count; i++)
                    if (grb_input.Controls[i] is ComboBox)
                        grb_input.Controls[i].Enabled = true;

            cmb_class.Focus();// ☻
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            int x=Int32.Parse(Convert.ToString(dt_lessonteacherTableAdapter.exist_ago((Int32)cmb_lesson.SelectedValue, (Int32)cmb_class.SelectedValue)));
            if (x == 0)
            {
                if (allowsave() && status != statusenum.s_none)
                {
                    DataRowView drv;
                    string str;
                    if (status == statusenum.s_new) drv = (DataRowView)dtlessonteacherBindingSource.AddNew();
                    else drv = (DataRowView)dtlessonteacherBindingSource.Current;
                    str = drv["idlesson_teacher"].ToString();
                    drv.BeginEdit();
                    drv["idclass"] = cmb_class.SelectedValue;    // ☻
                    drv["idlesson"] = cmb_lesson.SelectedValue;
                    drv["name"] = cmb_class.Text;
                    drv["namelesson"] = cmb_lesson.Text;
                    drv["idteacher"] = postdr["idteacher"].ToString();
                    drv.EndEdit();
                    dt_lessonteacherTableAdapter.Update(ds_lessonteacher.dt_lessonteacher);
                    if (ds_lessonteacher.dt_lessonteacher.Count == 1)
                        dt_lessonteacherTableAdapter.Fill(ds_lessonteacher.dt_lessonteacher);
                    ds_lessonteacher.dt_lessonteacher.AcceptChanges();// ☻
                    invert();
                    if (status == statusenum.s_new) btn_new.Focus();
                    else
                    {
                        dataGrid.Focus();
                        filtertxtclear();
                        dtlessonteacherBindingSource.Position = dtlessonteacherBindingSource.Find("idlesson_teacher", str);// ☻
                        dtlessonteacherBindingSource.ResetBindings(false);// برای تنظیم اسکرولبار
                    }
                    status = statusenum.s_none;
                    norecord();
                }
            }
            else
            {
                MessageBox.Show("!این درس در این کلاس دارای معلم می باشد");
            }
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            if (btn_exit.Text == "بازگشت")
            {
               Opacity = 0; Close();
                backgroundWorker_s.CancelAsync();
            }
            else
            {
                invert();
                status = statusenum.s_none;
                can test = new can();
                test.recolortextbox(grb_input);
                norecord(); // برای غیر فعال کردن مجدد اینپودتکست باکس ها
                if (dtlessonteacherBindingSource.Count != 0) dataGrid_RowEnter(null, new DataGridViewCellEventArgs(0, dtlessonteacherBindingSource.Position));
                /// بعد از زدن دکمه انصراف اطلاعات اطلاعات  // ▲
                /// رکورد جاری در تکس باکس ها نمایش داده شود  
            }
        }
        private void btn_next_Click(object sender, EventArgs e)
        {
            dtlessonteacherBindingSource.MoveNext();
        }
        private void btn_del_Click(object sender, EventArgs e)
        {
            if (allowdel() && MessageBox.Show("آیا مایل به حذف این رکورد میباشید ؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                dtlessonteacherBindingSource.RemoveCurrent();
                dt_lessonteacherTableAdapter.Update((Student.DataSet.ds_lessonteacher.dt_lessonteacherDataTable)ds_lessonteacher.dt_lessonteacher.GetChanges());// ☻
                ds_lessonteacher.dt_lessonteacher.AcceptChanges();
                filtertxtclear();
            }
            norecord();
        }
        private void btn_prev_Click(object sender, EventArgs e)
        {
            dtlessonteacherBindingSource.MovePrevious();
        }
        private void btn_first_Click(object sender, EventArgs e)
        {
            dtlessonteacherBindingSource.MoveFirst();
        }
        private void dataGrid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            cangotoeditstatus = false;
            if (status == statusenum.s_none /*&& cmb_class.InvokeRequired==false*/) // ▲
            {
                DataRowView drv = (DataRowView)dtlessonteacherBindingSource[e.RowIndex];
                cmb_class.Text =  drv["name"].ToString();   // ☻
                cmb_lesson.Text = drv["namelesson"].ToString();     // ☻
            }
            cangotoeditstatus = true;
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
                int len_str_f = 0;
                if (txt_class_f.Text != "") str_f += " name like '" + txt_class_f.Text + "%'";
                if (txt_lesson_f.Text != "")
                {
                    if (len_str_f != str_f.Length) { str_f += " and "; len_str_f = str_f.Length; }
                    str_f += " namelesson like '" + txt_lesson_f.Text + "%'";
                }
                dtlessonteacherBindingSource.Filter = str_f;
                norecord();
            }
        }
        private bool canfillter()
        {
            for (int i = 0; i < flp_f.Controls.Count; i++)
                flp_f.Controls[i].Text = flp_f.Controls[i].Text.Trim();
            return true;
        }
        private void inputtxtchange(object sender, EventArgs e)
        {
            if (cangotoeditstatus == true && status == statusenum.s_none && dtlessonteacherBindingSource.Count != 0)
            {
                invert();
                status = statusenum.s_edit;
            }
        }
        private void frm_lessonteacher_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2 && btn_new.Enabled)
                btn_new_Click(null, null);
            if (e.KeyCode == Keys.E && e.Control && btn_exit.Enabled)
            {
                e.SuppressKeyPress = true;
                btn_exit_Click(null, null);
            }
            if (e.KeyCode == Keys.F && e.Control && flp_f.Enabled)
            {
                e.SuppressKeyPress = true;
                flp_f.Controls[0].Focus();
            }
            if (e.KeyCode == Keys.End && e.Control && btn_save.Enabled)
            {
                Control ctr = this.ActiveControl;
                btn_save_Click(null, null);
                ActiveControl = ctr;
            }

        }
        private void dataGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete) btn_del_Click(null, null);
        }
        private void backgroundWorker_s_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            timer2.Enabled = false;
            prba.Value = 100;
            prba.Refresh();
            lbl_prba1.Text = "100%";
            lbl_prba1.Refresh();
            dtlessonteacherBindingSource.DataMember = "dt_lessonteacher";// ☻
            dtlessonteacherBindingSource.DataSource = this.ds_lessonteacher;// ☻
            dtlessonteacherBindingSource.Sort = "name";// ☻
            btn_new.Enabled = true;
            pnl_prba.Visible = false;
            btn_new.Focus();
            norecord();
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            prba.Value = Convert.ToInt32((ds_lessonteacher.dt_lessonteacher.Count * 100) / recordcount);// ☻
            lbl_prba1.Text = prba.Value.ToString() + "%";
            if (recordcount == ds_lessonteacher.dt_lessonteacher.Count) backgroundWorker_s_RunWorkerCompleted(null, null);
        }
        private void backgroundWorker_s_DoWork(object sender, DoWorkEventArgs e)
        {
            this.dt_lessonteacherTableAdapter.Fill(this.ds_lessonteacher.dt_lessonteacher);
        }
        private void entercolor(object sender, EventArgs e)
        {
            ((Control)sender).BackColor = Color.SeaShell;
        }
        private void classBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (lessonBindingSource.DataSource != null && classBindingSource.Current!=null)
                lessonBindingSource.Filter = "idmajor =" + ((DataRowView)classBindingSource.Current)["idmajor"] + " and" + " grade=" + ((DataRowView)classBindingSource.Current)["grade"];
        }
        // property
        ////////////////
        public DataRow post
        {
            set
            {
                postdr = value;
            }
        }
    }
}