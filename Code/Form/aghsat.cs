using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Student
{
    public partial class frm_aghsat : Form
    {
        /// Variable
        /// ******************************
        enum statusenum { s_new, s_edit, s_none };
        statusenum status = statusenum.s_none;
        bool cangotoeditstatus = true;
        int counterforfilter = 0;
        int recordcount;
        public Int32 idstudent;
        public string studentname;
        public Int32 shahrye;
        /// Initialize
        /// ******************************
        public frm_aghsat()
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
                if (grb_input.Controls[i] is TextBox || grb_input.Controls[i] is ComboBox)
                    grb_input.Controls[i].Text = "";
        }
        private bool allowsave()
        {
            for (int i = 0; i < grb_input.Controls.Count; i++)
                if (grb_input.Controls[i] is TextBox || grb_input.Controls[i] is ComboBox)
                    grb_input.Controls[i].Text = grb_input.Controls[i].Text.Trim(); ;
            can test = new can();
            if (test.isdate(txt_date) & test.checkempty(txt_cost,txt_date))
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
            if (remainderBindingSource.Count == 0)
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
            lbl_poststudentname.Text += studentname;
            try
            {
                lbl_sumcost.Text = remainderTableAdapter.sumcost(decimal.Parse(Convert.ToString(idstudent))).ToString();
                lbl_mande.Text = Convert.ToString(shahrye - Int32.Parse(lbl_sumcost.Text));
            }
            catch { }
            // ## Fill ComboBoxes  ##
            // ## For AutoNumber in Database ##
            string str;
            if ((str = remainderTableAdapter.getmax().ToString()) != "")
            ds_aghsat.remainder.idremainderColumn.AutoIncrementSeed = (long.Parse(str) + 1);
            recordcount = Int32.Parse(remainderTableAdapter.recordcount().ToString());// ☻
            if (recordcount <= 1) pnl_prba.Visible = false;
            else timer2.Enabled = true;
            backgroundWorker_s.RunWorkerAsync();
            norecord();
        }
        private void btn_new_Click(object sender, EventArgs e)
        {
            invert();
            status = statusenum.s_new;
            inputtxtclear();
            System.Globalization.PersianCalendar pc = new System.Globalization.PersianCalendar();
            DateTime nowt = DateTime.Now;
            txt_date.Text = pc.GetYear(nowt).ToString().Substring(2, 2)+(pc.GetMonth(nowt).ToString().Length==1?"0"+pc.GetMonth(nowt).ToString():pc.GetMonth(nowt).ToString())+(pc.GetDayOfMonth(nowt).ToString().Length==1?"0"+pc.GetDayOfMonth(nowt).ToString():pc.GetDayOfMonth(nowt).ToString());
            if (pnl_nav.Enabled == false)
                for (int i = 0; i < grb_input.Controls.Count; i++)
                    if (grb_input.Controls[i] is TextBox || grb_input.Controls[i] is ComboBox)
                        grb_input.Controls[i].Enabled = true;
            txt_fishid.Focus();
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (allowsave() && status != statusenum.s_none)
            {
                DataRowView drv;
                string str;
                if (status == statusenum.s_new) drv = (DataRowView)remainderBindingSource.AddNew();// 1#
                else
                {
                    drv = (DataRowView)remainderBindingSource.Current;
                }
                try
                {
                    // ## For AutoNumber ##
                    str = drv["idremainder"].ToString();
                    drv.BeginEdit();
                    drv["fishnumber"] = txt_fishid.Text;
                    drv["cost"] = txt_cost.Text;
                    drv["date"] = txt_date.Text;
                    drv["idstudent"] = idstudent.ToString();
                    drv.EndEdit();
                    remainderTableAdapter.Update((Student.DataSet.ds_aghsat.remainderDataTable)ds_aghsat.remainder.GetChanges());
                    if (ds_aghsat.remainder.Count == 1)
                        remainderTableAdapter.Fill(ds_aghsat.remainder, decimal.Parse(idstudent.ToString()));
                    ds_aghsat.remainder.AcceptChanges();
                    invert();
                    if (status == statusenum.s_new) btn_new.Focus();
                    else
                    {
                        dataGrid.Focus();
                        remainderBindingSource.Position = remainderBindingSource.Find("idremainder", str);
                        remainderBindingSource.ResetBindings(false);
                    }
                    status = statusenum.s_none;
                    norecord();

                    lbl_sumcost.Text = remainderTableAdapter.sumcost(decimal.Parse(Convert.ToString(idstudent))).ToString();
                    lbl_mande.Text = Convert.ToString(shahrye - Int32.Parse(lbl_sumcost.Text));
                }
                catch
                {
                    drv.CancelEdit();
                    MessageBox.Show("اطلاعات اشتباه مي‌باشد");
                }
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
                norecord();
                if (remainderBindingSource.Count != 0) dataGrid_RowEnter(null, new DataGridViewCellEventArgs(0, remainderBindingSource.Position));
            }
        }
        private void btn_last_Click(object sender, EventArgs e)
        {
            remainderBindingSource.MoveLast();
        }
        private void btn_next_Click(object sender, EventArgs e)
        {
            remainderBindingSource.MoveNext();
        }
        private void btn_del_Click(object sender, EventArgs e)
        {
            if (allowdel() && MessageBox.Show("آیا مایل به حذف این رکورد میباشید ؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                remainderBindingSource.RemoveCurrent();
                remainderTableAdapter.Update((Student.DataSet.ds_aghsat.remainderDataTable)ds_aghsat.remainder.GetChanges());
                ds_aghsat.remainder.AcceptChanges();
            }
            norecord();
        }
        private void btn_prev_Click(object sender, EventArgs e)
        {
            remainderBindingSource.MovePrevious();
        }
        private void btn_first_Click(object sender, EventArgs e)
        {
            remainderBindingSource.MoveFirst();
        }
        private void dataGrid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            cangotoeditstatus = false;
            if (status == statusenum.s_none /* && cmb_lname.InvokeRequired==false */)
            // اگر دیتاسورس و ممبر بیندینگ سورس در ورک کمپلته بکگروند تنظیم نشود این خط از خطای تریت جلوگیری میکند
            {
                DataRowView drv = (DataRowView)remainderBindingSource[e.RowIndex];
                txt_cost.Text = drv["cost"].ToString();
                txt_fishid.Text = drv["fishnumber"].ToString();
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
            }
        }
        /*private void actfilter(object sender, EventArgs e)
        {
            if (canfillter())
            {
                string str_f = "";
                int len_str_f = 0;
                if (txt_classname_f.Text != "") str_f += " classname like '" + txt_classname_f.Text + "%'";
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
                remainderBindingSource.Filter = str_f;
                norecord();
            }
        }*/
        private void inputtxtchange(object sender, EventArgs e)
        {
            if (cangotoeditstatus == true && status == statusenum.s_none && remainderBindingSource.Count != 0)
            {
                 if (sender is ComboBox  && ((ComboBox)sender).Name == "cmb_classname")
                {
                  //  DataRowView drv = (DataRowView)remainderBindingSource.Current;
                  //  cmb_classname.SelectedValue = drv["idclass"];
               }
                else
                {
                    invert();
                    status = statusenum.s_edit;
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
            remainderTableAdapter.Fill(this.ds_aghsat.remainder,decimal.Parse(idstudent.ToString()));
        }
        private void backgroundWorker_s_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            timer2.Enabled = false;
            prba.Value = 100;
            prba.Refresh();
            lbl_prba1.Text = "100%";
            lbl_prba1.Refresh();
            remainderBindingSource.DataMember = "remainder";
            remainderBindingSource.DataSource = this.ds_aghsat;
            remainderBindingSource.Sort = "date";
            btn_new.Enabled = true;
            pnl_prba.Visible = false;
            btn_new.Focus();
            norecord();
            // ## For GroupFillter ##
            //actfilter(null, null);
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            prba.Value = Convert.ToInt32((ds_aghsat.remainder.Count * 100) / recordcount);
            lbl_prba1.Text = prba.Value.ToString() + "%";
            if (recordcount == ds_aghsat.remainder.Count) backgroundWorker_s_RunWorkerCompleted(null, null);
        }
        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                frm_inputnumber form = new frm_inputnumber();
                form.post = ((DataRowView)remainderBindingSource.Current).Row;
                form.ShowDialog();
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
    }
}