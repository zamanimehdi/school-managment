using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Student
{
    public partial class frm_prepaid : Form
    {
        /// Variable
        /// ******************************
        enum statusenum { s_edit, s_none };
        statusenum status = statusenum.s_none;
        bool cangotoeditstatus = true;
        int counterforfilter = 0;
        int recordcount;
        Student.DataSet.ds_prepaidstudentTableAdapters.prepaidTableAdapter pda = new Student.DataSet.ds_prepaidstudentTableAdapters.prepaidTableAdapter();
        /// Initialize
        /// ******************************
        public frm_prepaid()
        {
            InitializeComponent();
        }
        /// Method
        /// ******************************
        private void invert()
        {
            pnl_title.Enabled = !pnl_title.Enabled;
            button1.Enabled = !button1.Enabled;
            pnl_datagride.Enabled = !pnl_datagride.Enabled;
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
            can test=new can();
            if (test.checkempty(txt_lessen))
                return true;
            else
            {
                MessageBox.Show("اطلاعات کامل نیست");
                return false;
            }
        }
        private bool allowdel()
        {
            return true;
        }
        private void norecord()
        {
            if (dataTable1BindingSource.Count == 0)
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
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (allowsave() && status != statusenum.s_none)
            {
                DataRowView drv;
                //string str;// برای ذخیره موقت کلید اصلی تا وقتی در حالت ویرایش
                // دکمه سیو زده شد حتی بعد از حذف فیلتر هم روی همان رکورد باقی بماند
                if (txt_lessen.Text != "")
                {
                    drv = (DataRowView)dataTable1BindingSource.Current;
                    drv.BeginEdit();
                    if (txt_lessen.Text == "")
                        drv["lessen"] = "0";
                    else drv["lessen"] = txt_lessen.Text;     // ☻
                    drv.EndEdit();
                    Student.DataSet.ds_prepaidstudent.prepaidRow pr = ds_prepaidstudent.prepaid.FindByidstudent(UInt64.Parse(drv["idstudent"].ToString()));
                    if (pr == null)
                    {
                        dataTable1TableAdapter.InsertQuery(UInt64.Parse(drv["idstudent"].ToString()), 0, Int32.Parse(txt_lessen.Text == "" ? "0" : txt_lessen.Text));
                        ds_prepaidstudent.prepaid.AddprepaidRow(UInt64.Parse(drv["idstudent"].ToString()));
                    }
                    else
                    {
                        dataTable1TableAdapter.Update(ds_prepaidstudent.DataTable1);
                    }
                    ds_prepaidstudent.DataTable1.AcceptChanges();// ☻
                }
                invert();
                dataGrid.Focus();
                filtertxtclear();
                dataTable1BindingSource.ResetBindings(false);// برای تنظیم اسکرولبار
                status = statusenum.s_none;
                norecord();// برای خارج شدن از حالت نورکورد

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
                if (dataTable1BindingSource.Count != 0) dataGrid_RowEnter(null, new DataGridViewCellEventArgs(0, dataTable1BindingSource.Position));
                /// بعد از زدن دکمه انصراف اطلاعات اطلاعات  // ▲
                /// رکورد جاری در تکس باکس ها نمایش داده شود  
            }
        }
        private void btn_next_Click(object sender, EventArgs e)
        {
            dataTable1BindingSource.MoveNext();
        }
        private void btn_prev_Click(object sender, EventArgs e)
        {
            dataTable1BindingSource.MovePrevious();
        }
        private void btn_last_Click(object sender, EventArgs e)
        {
            dataTable1BindingSource.MoveLast();
        }
        private void btn_first_Click(object sender, EventArgs e)
        {
            dataTable1BindingSource.MoveFirst();
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
                DataRowView drv = (DataRowView)dataTable1BindingSource[e.RowIndex];
                txt_lessen.Text = drv["lessen"].ToString();   // ☻
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
                if (txt_code_f.Text != "") str_f += " idstudent=" + txt_code_f.Text;
                if (txt_lname_f.Text != "")
                {
                    if (len_str_f != str_f.Length) { str_f += " and "; len_str_f = str_f.Length; }
                    str_f += " lname like '" + txt_lname_f.Text + "%'";
                }
                if (txt_name_f.Text != "")
                {
                    if (len_str_f != str_f.Length) { str_f += " and "; len_str_f = str_f.Length; }
                    str_f += " name like '" + txt_name_f.Text+ "%'";
                }
                if (txt_prepaid_f.Text != "")
                {
                    if (len_str_f != str_f.Length) { str_f += " and "; len_str_f = str_f.Length; }
                    str_f += " prepaid =" + txt_prepaid_f.Text;
                }
                if (txt_lessen_f.Text != "")
                {
                    if (len_str_f != str_f.Length) { str_f += " and "; len_str_f = str_f.Length; }
                    str_f += " lessen =" + txt_lessen_f.Text;
                }
                if(cmb_class.Text!="")

                    if (cmb_class.SelectedValue != null && classBindingSource.DataSource != null)
                    {
                        if (str_f != "")
                            str_f += " and idclass=" + cmb_class.SelectedValue.ToString();
                        else str_f = " idclass=" + cmb_class.SelectedValue.ToString();
                    }
                dataTable1BindingSource.Filter = str_f;
                norecord();
            }
        }
        private bool canfillter()
        {
            for (int i = 0; i < flp_f.Controls.Count; i++)
                flp_f.Controls[i].Text = flp_f.Controls[i].Text.Trim();
            can test = new can();
            if (test.isnumber(txt_code_f, txt_lessen_f, txt_prepaid_f) & test.isstring(txt_lname_f, txt_name_f))
                return true;
            else
                return false;
        }
        private void inputtxtchange(object sender, EventArgs e)
        {
            if (cangotoeditstatus == true && status == statusenum.s_none && dataTable1BindingSource.Count != 0)
            {
                invert();
                status = statusenum.s_edit;
            }
        }
        private void frm_DataTable1_KeyDown(object sender, KeyEventArgs e)
        {
            
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
        private void backgroundWorker_s_DoWork(object sender, DoWorkEventArgs e)
        {
            dataTable1TableAdapter.Fill(this.ds_prepaidstudent.DataTable1);// ☻
        }
        private void backgroundWorker_s_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            timer2.Enabled = false;
            prba.Value = 100;
            prba.Refresh();
            lbl_prba1.Text = "100%";
            lbl_prba1.Refresh();
            dataTable1BindingSource.DataMember = "DataTable1";// ☻
            dataTable1BindingSource.DataSource = this.ds_prepaidstudent;// ☻
            dataTable1BindingSource.Sort = "lname";// ☻
            pnl_prba.Visible = false;
            norecord();
            actfilter(null, null);
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            prba.Value = Convert.ToInt32((ds_prepaidstudent.DataTable1.Count * 100) / recordcount);// ☻
            lbl_prba1.Text = prba.Value.ToString() + "%";
            if (recordcount == ds_prepaidstudent.DataTable1.Count) backgroundWorker_s_RunWorkerCompleted(null, null);
        }
        private void frm_prepaid_Load(object sender, EventArgs e)
        {
            
        }
        private void cmb_class_SelectedValueChanged(object sender, EventArgs e)
        {
            filtertxtclear();
        }
        private void txt_prepaid_KeyDown(object sender, KeyEventArgs e)
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
                    e.KeyCode != Keys.D8 && e.KeyCode != Keys.D9)
                    e.SuppressKeyPress = true;
        }
        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                frm_aghsat frm = new frm_aghsat();
                frm.idstudent=Int32.Parse(((DataRowView)dataTable1BindingSource.Current).Row["idstudent"].ToString());
                frm.studentname = ((DataRowView)dataTable1BindingSource.Current).Row["name"].ToString() + " " + ((DataRowView)dataTable1BindingSource.Current).Row["lname"].ToString();
                if (((DataRowView)dataTable1BindingSource.Current).Row["lessen"].ToString() == "")
                    MessageBox.Show("شهریه دانش آموز باید تعیین شده باشد");
                else
                {
                    frm.shahrye = Int32.Parse(((DataRowView)dataTable1BindingSource.Current).Row["lessen"].ToString());
                    frm.ShowDialog();
                }
            }
        }

        private void frm_prepaid_Shown(object sender, EventArgs e)
        {
            setfilterwidth();
            Refresh();
            norecord();
            Opacity = 1;
            // TODO: This line of code loads data into the 'ds_prepaidstudent._class' table. You can move, or remove it, as needed.
            this.classTableAdapter.Fill(this.ds_prepaidstudent._class);
            pda.Fill(ds_prepaidstudent.prepaid);
            recordcount = Int32.Parse(dataTable1TableAdapter.recordcount().ToString());// ☻
            if (recordcount <= 1) pnl_prba.Visible = false;
            else timer2.Enabled = true;
            backgroundWorker_s.RunWorkerAsync();
            norecord();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            frm_cost frm = new frm_cost();
            frm.ShowDialog();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int tt = (Int32.Parse(textBox1.Text));
            }
            catch
            {
                MessageBox.Show("داده ورودي اشتباه مي‌باشد لطفا مجددا سعي نماييد");
                textBox1.Text = "";
                return;
            }
            bool first = true;
            do
            {
                if (first)
                {
                    dataTable1BindingSource.MoveFirst();
                    first = false;
                }
                else
                    dataTable1BindingSource.MoveNext();
                DataRowView drv = (DataRowView)dataTable1BindingSource.Current;
                if (drv["lessen"].ToString() != "") continue;
                drv.BeginEdit();
                if (textBox1.Text == "")
                    drv["lessen"] = "0";
                else drv["lessen"] = textBox1.Text;     // ☻
                drv.EndEdit();
                Student.DataSet.ds_prepaidstudent.prepaidRow pr = ds_prepaidstudent.prepaid.FindByidstudent(UInt64.Parse(drv["idstudent"].ToString()));
                if (pr == null)
                {
                    dataTable1TableAdapter.InsertQuery(UInt64.Parse(drv["idstudent"].ToString()), 0, Int32.Parse(drv["lessen"].ToString()));
                    ds_prepaidstudent.prepaid.AddprepaidRow(UInt64.Parse(drv["idstudent"].ToString()));
                }else
                {
                    MessageBox.Show("Error n : 4223453");
                    //dataTable1TableAdapter.Update(ds_prepaidstudent.DataTable1);
                }
                ds_prepaidstudent.DataTable1.AcceptChanges();// ☻

            } while (!(dataTable1BindingSource.Current == dataTable1BindingSource.List[dataTable1BindingSource.Count - 1]));

        }
    }
}