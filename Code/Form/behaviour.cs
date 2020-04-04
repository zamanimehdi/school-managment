using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Student
{
    public partial class frm_behaviour : Form
    {
        /// Variable
        /// ******************************
        enum statusenum { s_new, s_edit, s_none };
        statusenum status = statusenum.s_none;
        bool cangotoeditstatus = true;
        int counterforfilter = 0;
        public bool isfromlistnumber = false;
        int recordcount;
        DataRow postdr;
        /// Initialize
        /// ******************************
        public frm_behaviour()
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
        private void inputtxtclear()
        {
            for (int i = 0; i < grb_input.Controls.Count; i++)
                if (grb_input.Controls[i] is TextBox)
                    grb_input.Controls[i].Text = "";
            cmb_b.SelectedIndex = 0;
        }
        private bool allowsave()
        {
            for (int i = 0; i < grb_input.Controls.Count; i++)
                if (grb_input.Controls[i] is TextBox)
                    grb_input.Controls[i].Text = grb_input.Controls[i].Text.Trim(); ;
            can c = new can();
            if (c.isdate(txt_date)) return true;
            else
            {
                MessageBox.Show("تاریخ اشتباه می باشد");
                return false;
            }
        }
        private bool allowdel()
        {
            return true;
        }
        private void norecord()
        {
            if (behaviorBindingSource.Count == 0)
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
        private void frm_phone_Load(object sender, EventArgs e)
        {
        }
        private void btn_new_Click(object sender, EventArgs e)
        {
            cmb_b.Enabled = true;
            invert();
            status = statusenum.s_new;
            inputtxtclear();
            if (pnl_nav.Enabled == false)
                for (int i = 0; i < grb_input.Controls.Count; i++)
                    if (grb_input.Controls[i] is TextBox || grb_input.Controls[i] is CheckBox)
                        grb_input.Controls[i].Enabled = true;
            txt_date.Focus();
            System.Globalization.PersianCalendar pc = new System.Globalization.PersianCalendar();
            DateTime nowt = DateTime.Now;
            txt_date.Text = pc.GetYear(nowt).ToString().Substring(2, 2) + (pc.GetMonth(nowt).ToString().Length == 1 ? "0" + pc.GetMonth(nowt).ToString() : pc.GetMonth(nowt).ToString()) + (pc.GetDayOfMonth(nowt).ToString().Length == 1 ? "0" + pc.GetDayOfMonth(nowt).ToString() : pc.GetDayOfMonth(nowt).ToString());
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (allowsave() && status != statusenum.s_none)
            {
                DataRowView drv;
                string str;
                if (status == statusenum.s_new) drv = (DataRowView)behaviorBindingSource.AddNew();// 1#
                else drv = (DataRowView)behaviorBindingSource.Current;
                // ## For AutoNumber ##
                str = drv["idbehavior"].ToString();
                //str = txt_phone.Text;
                drv.BeginEdit();
                drv["desc"] = txt_behaviour.Text;
                drv["datestr"] = txt_date.Text;
                drv["typeb"] = cmb_b.SelectedIndex;
                drv["idstudent"] = postdr["idstudent"].ToString();
                drv.EndEdit();
                behaviorTableAdapter.Update((Student.DataSet.ds_behaviour.behaviorDataTable)ds_behaviour.behavior.GetChanges());
                if (ds_behaviour.behavior.Count == 1)
                    behaviorTableAdapter.Fill(ds_behaviour.behavior);
                ds_behaviour.behavior.AcceptChanges();
                invert();
                if (status == statusenum.s_new) btn_new.Focus();
                else
                {
                    dataGrid.Focus();
                    behaviorBindingSource.Position = behaviorBindingSource.Find("idbehavior", str);
                    behaviorBindingSource.ResetBindings(false);
                }
                status = statusenum.s_none;
               // cmb_b.Enabled = true;
                norecord();
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
                norecord();
                if (behaviorBindingSource.Count != 0) dataGrid_RowEnter(null, new DataGridViewCellEventArgs(0, behaviorBindingSource.Position));
            }
        }
        private void btn_last_Click(object sender, EventArgs e)
        {
            behaviorBindingSource.MoveLast();
        }
        private void btn_next_Click(object sender, EventArgs e)
        {
            behaviorBindingSource.MoveNext();
        }
        private void btn_del_Click(object sender, EventArgs e)
        {
            if (allowdel() && MessageBox.Show("آیا مایل به حذف این رکورد میباشید ؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                behaviorBindingSource.RemoveCurrent();
                behaviorTableAdapter.Update((Student.DataSet.ds_behaviour.behaviorDataTable)ds_behaviour.behavior.GetChanges());
                ds_behaviour.behavior.AcceptChanges();
            }
            norecord();
        }
        private void btn_prev_Click(object sender, EventArgs e)
        {
            behaviorBindingSource.MovePrevious();
        }
        private void btn_first_Click(object sender, EventArgs e)
        {
            behaviorBindingSource.MoveFirst();
        }
        private void dataGrid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            cangotoeditstatus = false;
            if (status == statusenum.s_none /* && cmb_lname.InvokeRequired==false */)
            // اگر دیتاسورس و ممبر بیندینگ سورس در ورک کمپلته بکگروند تنظیم نشود این خط از خطای تریت جلوگیری میکند
            {
                DataRowView drv = (DataRowView)behaviorBindingSource[e.RowIndex];
                txt_behaviour.Text = drv["desc"].ToString();
                txt_date.Text = drv["datestr"].ToString();
                cmb_b.SelectedIndex = Int32.Parse(drv["typeb"].ToString());
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
            }
        }
        private void inputtxtchange(object sender, EventArgs e)
        {
            if (sender is CheckBox)
                if (((CheckBox)sender).Checked == true)
                {
                    if (txt_behaviour.Text != "") txt_behaviour.Text += ".";
                    txt_behaviour.Text += "دانش آموز در این تاریخ غیبت داشته است";
                }
            if (cangotoeditstatus == true && status == statusenum.s_none && behaviorBindingSource.Count != 0)
            {
                invert();
                status = statusenum.s_edit;
            }
        }
        private void frm_phone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2 && btn_new.Enabled)
                btn_new_Click(null, null);
            if (e.KeyCode == Keys.E && e.Control && btn_exit.Enabled)
            {
                e.SuppressKeyPress = true;
                btn_exit_Click(null, null);
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
            behaviorTableAdapter.Fill(this.ds_behaviour.behavior);
        }
        private void backgroundWorker_s_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            timer2.Enabled = false;
            prba.Value = 100;
            prba.Refresh();
            lbl_prba1.Text = "100%";
            lbl_prba1.Refresh();
            behaviorBindingSource.DataMember = "behavior";
            behaviorBindingSource.DataSource = this.ds_behaviour;
            btn_new.Enabled = true;
            pnl_prba.Visible = false;
            btn_new.Focus();
            norecord();
            // ## For GroupFillter ##
            // actfilter(null, null);
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            prba.Value = Convert.ToInt32((ds_behaviour.behavior.Count * 100) / recordcount);
            lbl_prba1.Text = prba.Value.ToString() + "%";
            if (recordcount == ds_behaviour.behavior.Count) backgroundWorker_s_RunWorkerCompleted(null, null);
        }
        private void dataGrid_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            if (e.ColumnIndex == 0)
                e.Value = (e.RowIndex + 1).ToString();
        }
        // property
        ///////////////////
        public DataRow post
        {
            set
            {
                postdr = value;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            System.Globalization.PersianCalendar pc = new System.Globalization.PersianCalendar();
            DateTime nowt = DateTime.Now;
            string datestr = (pc.GetDayOfMonth(nowt).ToString().Length == 1 ? "0" + pc.GetDayOfMonth(nowt).ToString() : pc.GetDayOfMonth(nowt).ToString()) + "⁄ " + (pc.GetMonth(nowt).ToString().Length == 1 ? "0" + pc.GetMonth(nowt).ToString() : pc.GetMonth(nowt).ToString()) + "⁄ " + pc.GetYear(nowt).ToString().Substring(2, 2);
            txt_behaviour.Text = txt_behaviour.Text + " " + datestr + " ";
            txt_behaviour.Focus();
            txt_behaviour.Select(txt_behaviour.Text.Length, 1);
        }
        private void frm_behaviour_Shown(object sender, EventArgs e)
        {

            // ## Fill ComboBoxes  ##
            // ## For AutoNumber in Database ##
            string str;
            if ((str = behaviorTableAdapter.getmax().ToString()) != "")
                ds_behaviour.behavior.idbehaviorColumn.AutoIncrementSeed = (long.Parse(str) + 1);
            recordcount = Int32.Parse(behaviorTableAdapter.recordcount().ToString());// ☻
            if (recordcount <= 1) pnl_prba.Visible = false;
            else timer2.Enabled = true;
            behaviorBindingSource.Filter = "idstudent=" + postdr["idstudent"];
            lbl_name_info.Text += " " + postdr["name"];
            lbl_idstu_info.Text += " " + postdr["idstudent"];
            if (!isfromlistnumber)
            {
                lbl_lname_info.Text += " " + postdr["lname"];
                lbl_adress2_info.Text += postdr["address"];
                lbl_fname_info.Text += " " + postdr["fname"];
                lbl_shsh_info.Text += " " + postdr["sh"];
                lbl_tell_info.Text += " " + postdr["tell"];
            }
            else
            {
                lbl_adress1_info.Visible = false;
                lbl_fname_info.Visible = false;
                lbl_lname_info.Visible = false;
                lbl_shsh_info.Visible = false;
                lbl_tell_info.Visible = false;
                lbl_name_info.Top = 51;
                grp_stinfo.Height = 80;
                pnl_datagride.Top -= 48;
                grb_input.Top -= 48;
                btn_exit.Top -= 48;
                btn_new.Top -= 48;
                btn_save.Top -= 48;
                this.Height -= 48;
            }
            norecord();
            this.Refresh();
            Opacity = 1;

            backgroundWorker_s.RunWorkerAsync();
            norecord();
        }
        private void dataGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {

                switch (e.Value.ToString())
                {
                    case "0":
                        e.Value = "تاخیر ورود به دبیرستان";
                        break;
                    case "1":
                        e.Value = "تاخیر ورود و خروج از کلاس";
                        break;
                    case "2":
                        e.Value = "اخراج از کلاس";
                        break;
                    case "3":
                        e.Value = "غیبت";
                        break;
                    case "4":
                        e.Value = "درگیری با دانش آموزان";
                        break;
                    case "5":
                        e.Value = "بی حرمتی به عوامل آموزشی";
                        break;
                    case "6":
                        e.Value = "وضع ظاهری";
                        break;
                    case "7":
                        e.Value = "1 سایر موارد";
                        break;
                    case "8":
                        e.Value = "2 سایر موارد";
                        break;
                    case "9":
                        e.Value = "3 سایر موارد";
                        break;
                    case "10":
                        e.Value = "4 سایر موارد";
                        break;
                    case "11":
                        e.Value = "5 سایر موارد";
                        break;
                }
            }
        }
    }
}