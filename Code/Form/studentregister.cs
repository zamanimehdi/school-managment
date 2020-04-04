using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Student
{
    public partial class frm_student : Form
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
        public frm_student()
        {
            InitializeComponent();

        }
        /// Method
        /// ******************************
        private void invert()
        {
            panel1.Enabled = !panel1.Enabled;
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
                if (grb_input.Controls[i] is TextBox || grb_input.Controls[i] is ComboBox)
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
                if (grb_input.Controls[i] is TextBox || grb_input.Controls[i] is ComboBox)
                {
                    grb_input.Controls[i].Text = grb_input.Controls[i].Text.Trim();
                }
            can test = new can();
            if (test.isnumber(txt_idstudent) & test.isstring(txt_fname, txt_lname, txt_name) & test.checkempty(cmb_idclass, txt_name, txt_lname, txt_fname, txt_idstudent, txt_sh, txt_address))
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
            if (studentBindingSource.Count == 0)
            {
                pnl_nav.Enabled = false;
                for (int i = 0; i < grb_input.Controls.Count; i++)
                    if (grb_input.Controls[i] is TextBox || grb_input.Controls[i] is ComboBox)
                        grb_input.Controls[i].Enabled = false;
                inputtxtclear();
            }
            else if (pnl_nav.Enabled != true)
            {
                pnl_nav.Enabled = true;
                for (int i = 0; i < grb_input.Controls.Count; i++)
                    if (grb_input.Controls[i] is TextBox || grb_input.Controls[i] is ComboBox)
                        grb_input.Controls[i].Enabled = true;
            }
        }
        /// Event 
        /// ******************************
        private void frm_student_Load(object sender, EventArgs e)
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
                    if (grb_input.Controls[i] is TextBox || grb_input.Controls[i] is ComboBox)
                        grb_input.Controls[i].Enabled = true;

            txt_idstudent.Focus();// ☻
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
                    if (status == statusenum.s_new) drv = (DataRowView)studentBindingSource.AddNew();// 1#
                    else drv = (DataRowView)studentBindingSource.Current;
                    drv.BeginEdit();
                    drv["idclass"] = cmb_idclass.SelectedValue.ToString();   // ☻
                    drv["idstudent"] = txt_idstudent.Text;     // ☻
                    drv["lname"] = txt_lname.Text; // ☻
                    drv["name"] = txt_name.Text; // ☻
                    drv["sh"] = txt_sh.Text; // ☻
                    drv["fname"] = txt_fname.Text; // ☻
                    drv["tell"] = txt_tell.Text; // ☻
                    drv["address"] = txt_address.Text; // ☻
                    drv.EndEdit();
                    str = txt_idstudent.Text; // ☻
                    studentTableAdapter.Update((Student.DataSet.ds_student.studentDataTable)ds_student.student.GetChanges());// ☻
                    ds_student.student.AcceptChanges();// ☻
                    invert();
                    if (status == statusenum.s_new) btn_new.Focus();
                    else dataGrid.Focus();
                    if (status == statusenum.s_edit)
                    {
                        filtertxtclear();
                        studentBindingSource.Position = studentBindingSource.Find("idstudent", str);// ☻
                        studentBindingSource.ResetBindings(false);// برای تنظیم اسکرولبار
                    }
                    status = statusenum.s_none;
                    norecord();// برای خارج شدن از حالت نورکورد
                    lbl_count.Text = studentBindingSource.Count.ToString();
                }
            }
            catch (ConstraintException)
            {
                if (status == statusenum.s_new) studentBindingSource.Remove(studentBindingSource.Current);
                else studentBindingSource.CancelEdit();
                txt_idstudent.BackColor = System.Drawing.Color.LightPink;
                MessageBox.Show("کد دانش آموزی تکراری می باشد");
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
                can test = new can();
                test.recolortextbox(grb_input);
                invert();
                status = statusenum.s_none;
                norecord(); // برای غیر فعال کردن مجدد اینپودتکست باکس ها
                if (studentBindingSource.Count != 0) dataGrid_RowEnter(null, new DataGridViewCellEventArgs(0, studentBindingSource.Position));
                /// بعد از زدن دکمه انصراف اطلاعات اطلاعات  // ▲
                /// رکورد جاری در تکس باکس ها نمایش داده شود  
            }
        }
        private void btn_last_Click(object sender, EventArgs e)
        {
            studentBindingSource.MoveLast();
        }
        private void btn_next_Click(object sender, EventArgs e)
        {
            studentBindingSource.MoveNext();
        }
        private void btn_del_Click(object sender, EventArgs e)
        {
            if (allowdel() && MessageBox.Show("آیا مایل به حذف این رکورد میباشید ؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                studentBindingSource.RemoveCurrent();
                studentTableAdapter.Update((Student.DataSet.ds_student.studentDataTable)ds_student.student.GetChanges());// ☻
                ds_student.student.AcceptChanges();
                filtertxtclear();
            }
            norecord();
            lbl_count.Text = studentBindingSource.Count.ToString();
        }
        private void btn_prev_Click(object sender, EventArgs e)
        {
            studentBindingSource.MovePrevious();
        }
        private void btn_first_Click(object sender, EventArgs e)
        {
            studentBindingSource.MoveFirst();
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
                DataRowView drv = (DataRowView)studentBindingSource[e.RowIndex];
                cmb_idclass.SelectedValue = drv["idclass"].ToString();   // ☻
                txt_idstudent.Text = drv["idstudent"].ToString();     // ☻
                txt_lname.Text = drv["lname"].ToString(); // ☻
                txt_name.Text = drv["name"].ToString(); // ☻
                txt_sh.Text = drv["sh"].ToString(); // ☻
                txt_fname.Text = drv["fname"].ToString(); // ☻
                txt_tell.Text = drv["tell"].ToString(); // ☻
                txt_address.Text = drv["address"].ToString(); // ☻
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
                if (txt_idstudent_f.Text != "") str_f += " idstudent = '" + txt_idstudent_f.Text + "'";
                if (txt_lname_f.Text != "")
                {
                    if (len_str_f != str_f.Length) { str_f += " and "; len_str_f = str_f.Length; }
                    str_f += " lname like '" + txt_lname_f.Text + "%'";
                }
                if (txt_name_f.Text != "")
                {
                    if (len_str_f != str_f.Length) { str_f += " and "; len_str_f = str_f.Length; }
                    str_f += " name like '" + txt_name_f.Text + "%'";
                }
                if (txt_sh_f.Text != "")
                {
                    if (len_str_f != str_f.Length) { str_f += " and "; len_str_f = str_f.Length; }
                    str_f += " sh = '" + txt_sh_f.Text + "'";
                }
                if (txt_tell_f.Text != "")
                {
                    if (len_str_f != str_f.Length) { str_f += " and "; len_str_f = str_f.Length; }
                    str_f += " tell like '" + txt_tell_f.Text + "%'";
                }
                if (cmb_idclass.DataSource != null && cmb_idclass.SelectedValue != null)
                {
                    if (str_f != "")
                        str_f += " and idclass=" + cmb_idclass.SelectedValue.ToString();
                    else str_f = " idclass=" + cmb_idclass.SelectedValue.ToString();
                }
                studentBindingSource.Filter = str_f;
                norecord();
            }
        }
        private bool canfillter()
        {
            for (int i = 0; i < flp_f.Controls.Count; i++)
                flp_f.Controls[i].Text = flp_f.Controls[i].Text.Trim();
            can test = new can();
            if (test.isnumber(txt_idstudent_f) & test.isstring(txt_lname_f, txt_name_f))
                return true;
            else
                return false;
        }
        private void inputtxtchange(object sender, EventArgs e)
        {
            if (cangotoeditstatus == true && status == statusenum.s_none && studentBindingSource.Count != 0)
            {
                invert();
                status = statusenum.s_edit;
            }
        }
        private void frm_student_KeyDown(object sender, KeyEventArgs e)
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
            studentTableAdapter.Fill(this.ds_student.student);// ☻
        }
        private void backgroundWorker_s_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            timer2.Enabled = false;
            prba.Value = 100;
            prba.Refresh();
            lbl_prba1.Text = "100%";
            lbl_prba1.Refresh();
            studentBindingSource.DataMember = "student";// ☻
            studentBindingSource.DataSource = this.ds_student;// ☻
            studentBindingSource.Sort = "lname";// ☻
            btn_new.Enabled = true;
            pnl_prba.Visible = false;
            btn_new.Focus();
            norecord();
            lbl_count.Text = studentBindingSource.Count.ToString();
            classBindingSource.MoveFirst();

        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            prba.Value = Convert.ToInt32((ds_student.student.Count * 100) / recordcount);// ☻
            lbl_prba1.Text = prba.Value.ToString() + "%";
            if (recordcount == ds_student.student.Count) backgroundWorker_s_RunWorkerCompleted(null, null);
        }
        private void cmb_idclass_SelectedIndexChanged(object sender, EventArgs e)
        {
            actfilter(null, null);
            filtertxtclear();
            lbl_count.Text = studentBindingSource.Count.ToString();
        }
        private void txt_sh_KeyDown(object sender, KeyEventArgs e)
        {
            nextcontrol((Control)sender, e);
            if (e.KeyCode != Keys.Delete && e.KeyCode != Keys.Back &&
                e.KeyCode != Keys.Left && e.KeyCode != Keys.Right &&
                e.KeyCode != Keys.Home && e.KeyCode != Keys.End)
                if (e.KeyCode != Keys.NumPad0 && e.KeyCode != Keys.NumPad1 &&
                    e.KeyCode != Keys.NumPad2 && e.KeyCode != Keys.NumPad3 &&
                    e.KeyCode != Keys.NumPad4 && e.KeyCode != Keys.NumPad5 &&
                    e.KeyCode != Keys.NumPad6 && e.KeyCode != Keys.NumPad7 &&
                    e.KeyCode != Keys.NumPad8 && e.KeyCode != Keys.NumPad9 &&
                    e.KeyCode != Keys.D0 && e.KeyCode != Keys.D1 &&
                    e.KeyCode != Keys.D2 && e.KeyCode != Keys.D3 &&
                    e.KeyCode != Keys.D4 && e.KeyCode != Keys.D5 &&
                    e.KeyCode != Keys.D6 && e.KeyCode != Keys.D7 &&
                    e.KeyCode != Keys.D8 && e.KeyCode != Keys.D9 &&
                    e.KeyCode != Keys.OemMinus && e.KeyCode != Keys.Subtract
                    )
                    e.SuppressKeyPress = true;
        }
        private void frm_student_Shown(object sender, EventArgs e)
        {
            setfilterwidth();
            norecord();
            this.Refresh();
            Opacity = 1;
            // TODO: This line of code loads data into the 'ds_student._class' table. You can move, or remove it, as needed.
            this.classTableAdapter.Fill(this.ds_student._class);
            recordcount = Int32.Parse(studentTableAdapter.recordcount().ToString());// ☻
            if (recordcount <= 1) pnl_prba.Visible = false;
            else timer2.Enabled = true;
            if (cmb_idclass.SelectedValue != null)
                studentBindingSource.Filter = " idclass=" + cmb_idclass.SelectedValue.ToString();
            backgroundWorker_s.RunWorkerAsync();
            norecord();
        }
    }
}