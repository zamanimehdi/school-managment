using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Student
{
    public partial class frm_test : Form
    {
        /// Variable
        /// ******************************
        enum statusenum { s_new, s_edit, s_none };
        statusenum status = statusenum.s_none;
        bool cangotoeditstatus = true;
        int counterforfilter = 0;
        int recordcount;
        string datestr;
        //bool allshow = false;
        /// Initialize
        /// ******************************
        public frm_test()
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
                    grb_input.Controls[i].Text = grb_input.Controls[i].Text.Trim(); ;
            can test = new can();
            if (test.isdate(txt_date) & test.checkempty(txt_date,cmb_classname,cmb_lessonname))
                return true;
            else
            {
                MessageBox.Show("اطلاعات اشتباه می باشد");
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
        private void goto_new_surface()
        {
            pnl_datagride.Visible = false;
            grb_input.Top = 10;
            btn_exit.Top = btn_new.Top = btn_save.Top = 130;
            Height -= 400;
            grb_input.Text = "اطلاعات آزمون جديد";
            btn_new.Visible = false;
        }
        private void goto_edit_surface()
        {
            pnl_datagride.Visible = true;
            grb_input.Top = 412;
            btn_exit.Top = btn_new.Top = btn_save.Top = 527;
            Height = 606;
            grb_input.Text = "اطلاعات آزمون";
            btn_new.Visible = true;
        }
        private void btn_new_Click(object sender, EventArgs e)
        {
            goto_new_surface();
            invert();
            status = statusenum.s_new;
            inputtxtclear();
            filtertxtclear();            
            txt_date.Text = datestr;

            if (pnl_nav.Enabled == false)
                for (int i = 0; i < grb_input.Controls.Count; i++)
                    if (grb_input.Controls[i] is TextBox || grb_input.Controls[i] is ComboBox)
                        grb_input.Controls[i].Enabled = true;

            cmb_classname.Focus();
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            
            // DialogResult dr = DialogResult.Ignore;
           // if (datestr != txt_date.Text && !allshow)
          //      dr = MessageBox.Show("تاریخ برگزاری امتحان با تاریخ روز متفاوت است" + "\n\n" + "برای افزودن امتحان در تاریخی غیر از " + "\n" + "امروز باید تمام امتحانات نمایش داده شود" + "\n" + "آیا مایلید تمام امتحانات نشان داده شود؟", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
           // if (dr == DialogResult.Ignore || dr == DialogResult.OK)
           // {
             //   if (dr == DialogResult.OK) button1_Click(null, null);
                if (allowsave() && status != statusenum.s_none)
                {
                    DataRowView drv;
                    string str;
                    if (status == statusenum.s_new) drv = (DataRowView)dataTable1BindingSource.AddNew();// 1#
                    else
                    {
                        drv = (DataRowView)dataTable1BindingSource.Current;
                        cmb_classname.Enabled = true;
                    }
                    // ## For AutoNumber ##
                    str = drv["idtest"].ToString();
                    drv.BeginEdit();
                    drv["name"] = cmb_lessonname.Text;
                    drv["classname"] = cmb_classname.Text;
                    drv["idlesson"] = cmb_lessonname.SelectedValue;
                    drv["date"] = txt_date.Text;
                    drv["idclass"] = cmb_classname.SelectedValue;
                    drv.EndEdit();
                    dataTable1TableAdapter.Update((Student.DataSet.ds_score.DataTable1DataTable)ds_score.DataTable1.GetChanges());
                    //if (ds_score.DataTable1.Count == 1 || dataTable1BindingSource.Count==1)
                    dataTable1TableAdapter.Fill(ds_score.DataTable1);
                    ds_score.DataTable1.AcceptChanges();
                    invert();
                    if (status == statusenum.s_new) btn_new.Focus();
                    else
                    {
                        dataGrid.Focus();
                        filtertxtclear();
                        dataTable1BindingSource.Position = dataTable1BindingSource.Find("idtest", str);
                        dataTable1BindingSource.ResetBindings(false);
                    }

                    status = statusenum.s_none;
                    norecord();
                    dataGrid.Focus();
                    filtertxtclear();
                    dataTable1BindingSource.Position = dataTable1BindingSource.Find("idtest", str);
                    dataTable1BindingSource.ResetBindings(false);
                    goto_edit_surface();
                    frm_inputnumber form = new frm_inputnumber();
                    form.post = ((DataRowView)dataTable1BindingSource.Current).Row;
                    form.ShowDialog();
                }
           // }
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            goto_edit_surface();
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
                if (status == statusenum.s_edit) cmb_classname.Enabled = true;
                status = statusenum.s_none;
                norecord();
                if (dataTable1BindingSource.Count != 0) dataGrid_RowEnter(null, new DataGridViewCellEventArgs(0, dataTable1BindingSource.Position));
            }
        }
        private void btn_last_Click(object sender, EventArgs e)
        {
            dataTable1BindingSource.MoveLast();
        }
        private void btn_next_Click(object sender, EventArgs e)
        {
            dataTable1BindingSource.MoveNext();
        }
        private void btn_del_Click(object sender, EventArgs e)
        {
            if (allowdel() && MessageBox.Show("آیا مایل به حذف این رکورد میباشید ؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                dataTable1BindingSource.RemoveCurrent();
                dataTable1TableAdapter.Update((Student.DataSet.ds_score.DataTable1DataTable)ds_score.DataTable1.GetChanges());
                ds_score.DataTable1.AcceptChanges();
                filtertxtclear();
            }
            norecord();
        }
        private void btn_prev_Click(object sender, EventArgs e)
        {
            dataTable1BindingSource.MovePrevious();
        }
        private void btn_first_Click(object sender, EventArgs e)
        {
            dataTable1BindingSource.MoveFirst();
        }
        private void dataGrid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            cangotoeditstatus = false;
            if (status == statusenum.s_none /* && cmb_lname.InvokeRequired==false */)
            // اگر دیتاسورس و ممبر بیندینگ سورس در ورک کمپلته بکگروند تنظیم نشود این خط از خطای تریت جلوگیری میکند
            {
                DataRowView drv = (DataRowView)dataTable1BindingSource[e.RowIndex];
                cmb_classname.SelectedValue = drv["idclass"];
                cmb_classname.Text = drv["classname"].ToString();
                cmb_lessonname.SelectedValue = drv["idlesson"];
                cmb_lessonname.Text = drv["name"].ToString();
                txt_date.Text = drv["date"].ToString();
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
                setfilterwidth();
            }
        }
        private void actfilter(object sender, EventArgs e)
        {
            if (canfillter())
            {
                string str_f="";
               // if (!allshow) str_f = "date like '" + datestr + "'";
                int len_str_f = 0;
                if (txt_classname_f.Text != "")
                {
               //     if (!allshow) str_f += " and ";
                    str_f += "classname like '" + txt_classname_f.Text + "%'";
                }
                if (txt_lessonname_f.Text != "")
                {
                    if (len_str_f != str_f.Length) { str_f += " and "; len_str_f = str_f.Length; }
                    str_f += " name like '" + txt_lessonname_f.Text + "%'";
                }
                if (txt_date_f.Text != "")
                {
                    if (len_str_f != str_f.Length) { str_f += " and "; len_str_f = str_f.Length; }
                    str_f += " date like '" + txt_date_f.Text+ "%'";
                }
                // ## For GroupFillter ##
                //if (comboBox1.SelectedValue != null && choosestBindingSource.DataSource != null)
                //{
                //    if (str_f != "")
                //        str_f += " and idclass=" + comboBox1.SelectedValue.ToString();
                //    else str_f = " idclass=" + comboBox1.SelectedValue.ToString();
                //}
                dataTable1BindingSource.Filter = str_f;
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
            if (cangotoeditstatus == true && status == statusenum.s_none && dataTable1BindingSource.Count != 0)
            {
                 if (sender is ComboBox  && ((ComboBox)sender).Name == "cmb_classname")
                {
                  //  DataRowView drv = (DataRowView)dataTable1BindingSource.Current;
                  //  cmb_classname.SelectedValue = drv["idclass"];
               }
                else
                {
                    invert();
                    status = statusenum.s_edit;
                    cmb_classname.Enabled = false;
                }
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
            dataTable1TableAdapter.Fill(this.ds_score.DataTable1);
        }
        private void backgroundWorker_s_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            timer2.Enabled = false;
            prba.Value = 100;
            prba.Refresh();
            lbl_prba1.Text = "100%";
            lbl_prba1.Refresh();
            dataTable1BindingSource.DataMember = "DataTable1";
            dataTable1BindingSource.DataSource = this.ds_score;
            dataTable1BindingSource.Sort = "date DESC";
            btn_new.Enabled = true;
            pnl_prba.Visible = false;
            btn_new.Focus();
          //  if (!allshow)dataTable1BindingSource.Filter = "date like '" + datestr + "'";
            norecord();
            // ## For GroupFillter ##
            //actfilter(null, null);
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            prba.Value = Convert.ToInt32((ds_score.DataTable1.Count * 100) / recordcount);
            lbl_prba1.Text = prba.Value.ToString() + "%";
            if (recordcount == ds_score.DataTable1.Count) backgroundWorker_s_RunWorkerCompleted(null, null);
        }
        private void classBindingSource_PositionChanged(object sender, EventArgs e)
        {
            lessonBindingSource.Filter = "idmajor=" + ((DataRowView)classBindingSource.Current)["idmajor"].ToString() + " and grade=" + ((DataRowView)classBindingSource.Current)["grade"].ToString();
        }
        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                
                frm_inputnumber form = new frm_inputnumber();
                form.post = ((DataRowView)dataTable1BindingSource.Current).Row;
                form.ShowDialog();
            }
        }
        private void cmb_classname_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cangotoeditstatus == true && status == statusenum.s_none && dataTable1BindingSource.Count != 0)
            {
                DataRowView drv = (DataRowView)dataTable1BindingSource.Current;
                cmb_classname.SelectedValue = drv["idclass"];
            }
        }
        private void dataGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex==2)
                e.Value = e.Value.ToString().Insert(2, "/").Insert(5, "/");
        }
        private void txt_date_f_KeyDown(object sender, KeyEventArgs e)
        {
            nextcontrol((Control)sender, e);
            if (e.KeyCode == Keys.OemQuestion)
                e.SuppressKeyPress = true;
        }

        private void frm_test_Shown(object sender, EventArgs e)
        {
            setfilterwidth();
            norecord();
            Refresh();
            Opacity = 1;
            System.Globalization.PersianCalendar pc = new System.Globalization.PersianCalendar();
            DateTime nowt = DateTime.Now;
            datestr = pc.GetYear(nowt).ToString().Substring(2, 2) + (pc.GetMonth(nowt).ToString().Length == 1 ? "0" + pc.GetMonth(nowt).ToString() : pc.GetMonth(nowt).ToString()) + (pc.GetDayOfMonth(nowt).ToString().Length == 1 ? "0" + pc.GetDayOfMonth(nowt).ToString() : pc.GetDayOfMonth(nowt).ToString());

            // TODO: This line of code loads data into the 'ds_score.lesson' table. You can move, or remove it, as needed.
            this.lessonTableAdapter.Fill(this.ds_score.lesson);
            // TODO: This line of code loads data into the 'ds_score._class' table. You can move, or remove it, as needed.
            this.classTableAdapter.Fill(this.ds_score._class);
            // ## Fill ComboBoxes  ##
            // ## For AutoNumber in Database ##
            string str;
            if ((str = dataTable1TableAdapter.getmax().ToString()) != "")
                ds_score.DataTable1.idtestColumn.AutoIncrementSeed = (long.Parse(str) + 1);
            recordcount = Int32.Parse(dataTable1TableAdapter.recordcount().ToString());// ☻
            if (recordcount <= 1) pnl_prba.Visible = false;
            else timer2.Enabled = true;
            backgroundWorker_s.RunWorkerAsync();
            norecord();

        }

        private void lbl_prba1_Click(object sender, EventArgs e)
        {

        }

        private void dataGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 3)
            {
                frm_inputnumber form = new frm_inputnumber();
                form.post = ((DataRowView)dataTable1BindingSource.Current).Row;
                form.ShowDialog();
            }
        }
    }
}