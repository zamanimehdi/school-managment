using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Student
{
    public partial class frm_teacher : Form
    {
        /// Variable
        /// ******************************
        enum statusenum { s_new, s_edit, s_none };
        statusenum status = statusenum.s_none;
        bool cangotoeditstatus = true;
        int counterforfilter = 0;
        int recordcount;
        /// Initialize
        /// ******************************
        public frm_teacher()
        {
            InitializeComponent();
        }
        /// Method
        /// ******************************
        private void invert()
        {
            pnl_datagride.Enabled = !pnl_datagride.Enabled;
            btn_new.Enabled = !btn_new.Enabled;
            btn_save.Enabled = !btn_save.Enabled;
            if (btn_exit.Text == "بازگشت") btn_exit.Text = "انصراف";
            else btn_exit.Text = "بازگشت";
        }
        private void setfilterwidth()
        {
            bool b;
            for (int i = 0; i < flp_f.Controls.Count - 1; i++)
            {
                if (i % 2 == 0) b = true; else b = false;
                flp_f.Controls[i].Width = dataGrid.Columns[i].Width - (b ? 0 : 1);
            }
            flp_f.Controls[flp_f.Controls.Count - 1].Width += flp_f.Controls[flp_f.Controls.Count - 1].Location.X;
        }
        private void inputtxtclear()
        {
            for (int i = 0; i < grb_input.Controls.Count; i++)
                if (grb_input.Controls[i] is TextBox)
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
                if (grb_input.Controls[i] is TextBox)
                    grb_input.Controls[i].Text = grb_input.Controls[i].Text.Trim(); ;
            can test = new can();
            if (test.isnumber(txt_idcode) & test.isstring(txt_lname, txt_name) & test.checkempty(txt_idcode,txt_lname,txt_name,txt_tell))
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
            if (teacherBindingSource.Count == 0)
            {
                pnl_nav.Enabled = false;
                for (int i = 0; i < grb_input.Controls.Count; i++)
                    if (grb_input.Controls[i] is TextBox)
                        grb_input.Controls[i].Enabled = false;
                inputtxtclear();
            }
            else if (pnl_nav.Enabled != true)
            {
                pnl_nav.Enabled = true;
                for (int i = 0; i < grb_input.Controls.Count; i++)
                    if (grb_input.Controls[i] is TextBox)
                        grb_input.Controls[i].Enabled = true;
            }
        }
        /// Event 
        /// ******************************
        private void frm_teacher_Load(object sender, EventArgs e)
        {
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
                    if (grb_input.Controls[i] is TextBox)
                        grb_input.Controls[i].Enabled = true;

            txt_idcode.Focus();// ☻
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (allowsave() && status != statusenum.s_none)
                {
                    DataRowView drv;
                    string str;// برای ذخیره موقت کلید اصلی تا وقتی در حالت ویرایش
                    // دکمه سیو زده شد حتی بعد از حذف فیلتر هم روی همان رکورد باقی بماند
                    if (status == statusenum.s_new) drv = (DataRowView)teacherBindingSource.AddNew();// 1#
                    else drv = (DataRowView)teacherBindingSource.Current;
                    drv.BeginEdit();
                    drv["lname"] = txt_lname.Text;   // ☻
                    drv["name"] = txt_name.Text;     // ☻
                    drv["tell"] = txt_tell.Text; // ☻
                    drv["idteacher"] = txt_idcode.Text;
                    drv.EndEdit();
                    str = txt_idcode.Text; // ☻
                    teacherTableAdapter.Update((Student.DataSet.ds_teacher.teacherDataTable)ds_teacher.teacher.GetChanges());// ☻
                    ds_teacher.teacher.AcceptChanges();// ☻
                    invert();
                    if (status == statusenum.s_new) btn_new.Focus();
                    else
                    {
                        dataGrid.Focus();
                        filtertxtclear();
                        teacherBindingSource.Position = teacherBindingSource.Find("idteacher", str);// ☻
                        teacherBindingSource.ResetBindings(false);// برای تنظیم اسکرولبار
                    }
                    status = statusenum.s_none;
                    norecord();// برای خارج شدن از حالت نورکورد
                }
            }
            catch (ConstraintException)
            {
                if (status == statusenum.s_new) teacherBindingSource.Remove(teacherBindingSource.Current);
                else teacherBindingSource.CancelEdit();
                txt_idcode.BackColor = System.Drawing.Color.LightPink;
                MessageBox.Show("کد پرسنلی تکراری می باشد");
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
                if (teacherBindingSource.Count != 0) dataGrid_RowEnter(null, new DataGridViewCellEventArgs(0, teacherBindingSource.Position));
                /// بعد از زدن دکمه انصراف اطلاعات اطلاعات  // ▲
                /// رکورد جاری در تکس باکس ها نمایش داده شود  
            }
        }
        private void btn_last_Click(object sender, EventArgs e)
        {
            teacherBindingSource.MoveLast();
        }
        private void btn_next_Click(object sender, EventArgs e)
        {
            teacherBindingSource.MoveNext();
        }
        private void btn_del_Click(object sender, EventArgs e)
        {
            if (allowdel() && MessageBox.Show("آیا مایل به حذف این رکورد میباشید ؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                teacherBindingSource.RemoveCurrent();
                teacherTableAdapter.Update((Student.DataSet.ds_teacher.teacherDataTable)ds_teacher.teacher.GetChanges());// ☻
                ds_teacher.teacher.AcceptChanges();
                filtertxtclear();
            }
            norecord();
        }
        private void btn_prev_Click(object sender, EventArgs e)
        {
            teacherBindingSource.MovePrevious();
        }
        private void btn_first_Click(object sender, EventArgs e)
        {
            teacherBindingSource.MoveFirst();
        }
        private void dataGrid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            /// با وجود اینکه در حالت ذخیره دیتاگرید غیرفعال است ولی
            /// با زدن دکمه ذخیره بعد از وارد کردن اطلاعات جدید 
            /// وقتی که به خط #1 میرسیم با ایجاد خط جدید خالی 
            /// و انتقال موقعیت به "آن متد رواینتر باعث میشود که
            /// تمامی تکس باکس ها خالی شود و اطلاعات به درستی ذخیره نمی شود 
            cangotoeditstatus = false;
            if (status == statusenum.s_none) // ▲
            {
                DataRowView drv = (DataRowView)teacherBindingSource[e.RowIndex];
                txt_lname.Text = drv["lname"].ToString();   // ☻
                txt_name.Text = drv["name"].ToString();     // ☻
                txt_tell.Text = drv["tell"].ToString(); // ☻
                txt_idcode.Text = drv["idteacher"].ToString();
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
            if (((Control)sender).BackColor != Color.LightPink)
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
                    str_f += " tell =" + txt_tell_f.Text;
                }
                if (txt_idcode_f.Text != "")
                {
                    if (len_str_f != str_f.Length) { str_f += " and "; len_str_f = str_f.Length; }
                    str_f += " idteacher =" + txt_idcode_f.Text;
                }
                teacherBindingSource.Filter = str_f;
                norecord();
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
        private void inputtxtchange(object sender, EventArgs e)
        {
            if (cangotoeditstatus == true && status == statusenum.s_none && teacherBindingSource.Count != 0)
            {
                invert();
                status = statusenum.s_edit;
            }
        }
        private void frm_teacher_KeyDown(object sender, KeyEventArgs e)
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
            btn_new.Enabled = true;
            pnl_prba.Visible = false;
            btn_new.Focus();
            norecord();
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
        private void frm_teacher_Shown(object sender, EventArgs e)
        {
            setfilterwidth();
            norecord();
            Refresh();
            Opacity = 1;
            recordcount = Int32.Parse(teacherTableAdapter.recordcount().ToString());// ☻
            if (recordcount < 1) pnl_prba.Visible = false;
            else timer2.Enabled = true;
            backgroundWorker_s.RunWorkerAsync();
            norecord();
            
        }
    }
}