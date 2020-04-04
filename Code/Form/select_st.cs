using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Student
{
    public partial class frm_choosest : Form
    {
        /// Variable
        /// ******************************
        int counterforfilter = 0;
        int recordcount;
        bool isforperint;
        public bool forselectstudentinprintnumberlist;
        public decimal idstudentforselectesstudentforprintnumberlist;
        frm_proces frm_p = new frm_proces();
        frm_preview form = new frm_preview();
        DataSet.dsp_behavTableAdapters.behaviorTableAdapter ta;
        DataSet.dsp_behav ds;
        double sumb;
        /// Initialize
        /// ******************************
        public frm_choosest()
        {
            InitializeComponent();
        }
        /// Method
        /// ******************************
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
        private void filtertxtclear()
        {
            for (int i = 0; i < flp_f.Controls.Count; i++)
                flp_f.Controls[i].Text = "";
        }
        /// Event 
        /// ******************************
        private void btn_last_Click(object sender, EventArgs e)
        {
            choosestBindingSource.MoveLast();
        }
        private void btn_next_Click(object sender, EventArgs e)
        {
            choosestBindingSource.MoveNext();
        }
        private void btn_prev_Click(object sender, EventArgs e)
        {
            choosestBindingSource.MovePrevious();
        }
        private void btn_first_Click(object sender, EventArgs e)
        {
            choosestBindingSource.MoveFirst();
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
                string str_f = "";
                if (canfillter())
                {
                    int len_str_f = 0;      // ☻// ☻// ☻
                    if (txt_idstudent_f.Text != "") str_f += " idstudent = " + txt_idstudent_f.Text + "";
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
                    if (txt_tell_f.Text != "")
                    {
                        if (len_str_f != str_f.Length) { str_f += " and "; len_str_f = str_f.Length; }
                        str_f += " tell like '" + txt_tell_f.Text + "%'";
                    }
                    if (comboBox1.SelectedValue != null && choosestBindingSource.DataSource != null)
                    {
                        if (str_f != "")
                            str_f += " and idclass=" + comboBox1.SelectedValue.ToString();
                        else str_f = " idclass=" + comboBox1.SelectedValue.ToString();
                    }
                    choosestBindingSource.Filter = str_f;
                }
        }
        private bool canfillter()
        {
            for (int i = 0; i < flp_f.Controls.Count; i++)
                flp_f.Controls[i].Text = flp_f.Controls[i].Text.Trim();
            can test=new can();
            if (test.isnumber(txt_idstudent_f) & test.isstring(txt_lname_f, txt_name_f))
                return true;
            else
                return false;
        }
        private void frm_choosest_KeyDown(object sender, KeyEventArgs e)
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
        }
        private void backgroundWorker_s_DoWork(object sender, DoWorkEventArgs e)
        {
            this.choosestTableAdapter.Fill(this.ds_choosest.choosest);
        }
        private void backgroundWorker_s_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            timer2.Enabled = false;
            prba.Value = 100;
            prba.Refresh();
            lbl_prba1.Text = "100%";
            lbl_prba1.Refresh();
            choosestBindingSource.DataMember = "choosest";// ☻
            choosestBindingSource.DataSource = this.ds_choosest;// ☻
            choosestBindingSource.Sort = "lname";// ☻
            pnl_prba.Visible = false;
            actfilter(null, null);
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            prba.Value = Convert.ToInt32((ds_choosest.choosest.Count * 100) / recordcount);// ☻
            lbl_prba1.Text = prba.Value.ToString() + "%";
            if (recordcount == ds_choosest.choosest.Count) backgroundWorker_s_RunWorkerCompleted(null, null);
        }
        private void btn_select_Click(object sender, EventArgs e)
        {
            if (!isforperint)
            {
                if (choosestBindingSource.Current != null)
                {
                    if (!forselectstudentinprintnumberlist)
                    {
                        frm_behaviour form = new frm_behaviour();
                        form.Opacity = 0;
                        form.post = ((DataRowView)choosestBindingSource.Current).Row;
                        form.ShowDialog();
                    }
                    else
                    {
                        idstudentforselectesstudentforprintnumberlist = decimal.Parse((((DataRowView)choosestBindingSource.Current).Row)["idstudent"].ToString());
                        DialogResult = DialogResult.OK;
                        Opacity = 0; Close();
                    }
                }
            }
            else
            {
                //timer3.Enabled = true;
                //frm_p.Show();
                //frm_p.Refresh();
                ta = new Student.DataSet.dsp_behavTableAdapters.behaviorTableAdapter();
                ds = new Student.DataSet.dsp_behav();
                ta.Fill(ds.behavior, UInt64.Parse(((DataRowView)choosestBindingSource.Current).Row["idstudent"].ToString()));
                BindingSource bs = new BindingSource(ds, "behavior");
                bs.Filter = "typeb=0";
                int t1=bs.Count;
                bs.Filter = "typeb=1";
                int t2 = bs.Count;
                bs.Filter = "typeb=2";
                int t3 = bs.Count;
                bs.Filter = "typeb=3";
                int t4 = bs.Count;
                bs.Filter = "typeb=4";
                int t5 = bs.Count;
                bs.Filter = "typeb=5";
                int t6 = bs.Count;
                bs.Filter = "typeb=6";
                int t7 = bs.Count;
                bs.Filter = "typeb=7";
                int t8 = bs.Count;

                bs.Filter = "typeb=8";
                int t9 = bs.Count;
                bs.Filter = "typeb=9";
                int t10 = bs.Count;
                bs.Filter = "typeb=10";
                int t11 = bs.Count;
                bs.Filter = "typeb=11";
                int t12 = bs.Count;

                bs.Filter = "typeb=12";
                int t13 = bs.Count;
                bs.Filter = "typeb=13";
                int t14 = bs.Count;
                bs.Filter = "typeb=14";
                int t15 = bs.Count;
                bs.Filter = "typeb=15";
                int t16 = bs.Count;
                bs.Filter = "typeb=16";
                int t17 = bs.Count;
                double z1 = double.Parse(Student.Properties.Settings.Default.behav_scor_1.ToString());
                double z2 = double.Parse(Student.Properties.Settings.Default.behav_scor_2.ToString());
                double z3 = double.Parse(Student.Properties.Settings.Default.behav_scor_3.ToString());
                double z4 = double.Parse(Student.Properties.Settings.Default.behav_scor_4.ToString());
                double z5 = double.Parse(Student.Properties.Settings.Default.behav_scor_5.ToString());
                double z6 = double.Parse(Student.Properties.Settings.Default.behav_scor_6.ToString());
                double z7 = double.Parse(Student.Properties.Settings.Default.behav_scor_7.ToString());
                double z8 = double.Parse(Student.Properties.Settings.Default.behav_scor_8.ToString());

                double z9 = double.Parse(Student.Properties.Settings.Default.behav_scor_9.ToString());
                double z10 = double.Parse(Student.Properties.Settings.Default.behav_scor_10.ToString());
                double z11 = double.Parse(Student.Properties.Settings.Default.behav_scor_11.ToString());
                double z12 = double.Parse(Student.Properties.Settings.Default.behav_scor_12.ToString());

                double z13 = double.Parse(Student.Properties.Settings.Default.behav_scor_13.ToString());
                double z14 = double.Parse(Student.Properties.Settings.Default.behav_scor_14.ToString());
                double z15 = double.Parse(Student.Properties.Settings.Default.behav_scor_15.ToString());
                double z16 = double.Parse(Student.Properties.Settings.Default.behav_scor_16.ToString());
                double z17 = double.Parse(Student.Properties.Settings.Default.behav_scor_17.ToString());
                sumb = t1 * z1 + t2 * z2 + t3 * z3 + t4 * z4 + t5 * z5 + t6 * z6 + t7 * z7 + t8 * z8 + t9 * z9 + t10 * z10 + t11 * z11 + t12 * z12
                    + t13 * z13 + t14 * z14 + t15 * z15 + t16 * z16 + t17 * z17;
                sumb = 20 - sumb;
                Properties.Settings.Default.student = ((DataRowView)choosestBindingSource.Current).Row["name"].ToString() + " " + ((DataRowView)choosestBindingSource.Current).Row["lname"].ToString();
               // backgroundWorker3.RunWorkerAsync();
                panel2.Visible = true;
                flp_f.Enabled = false;
                pnl_nav.Enabled = false;
                dataGrid.Enabled = false;
                btn_exit.Enabled = false;
                btn_select.Enabled = false;
                comboBox1.Enabled = false;
                textBox1.Focus();
            }
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            if (btn_exit.Text == "بازگشت") 
            {
               Opacity = 0; Close();
                backgroundWorker_s.CancelAsync();
            }
        }
        private void frm_choosest_Load(object sender, EventArgs e)
        {
            
        }
        private void choosestBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (choosestBindingSource.Count == 0) btn_select.Enabled = false;
            else btn_select.Enabled = true;
        }
        public bool Isforprint
        {
            get
            {
                return isforperint;
            }
            set
            {
                isforperint = value;
            }

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
           
        }

        private void frm_choosest_Shown(object sender, EventArgs e)
        {
            setfilterwidth();
            Refresh();
            Opacity = 1;
            this.classTableAdapter.Fill(this.ds_choosest._class);
            recordcount = Int32.Parse(choosestTableAdapter.recordcount().ToString());// ☻
            if (recordcount <= 1) pnl_prba.Visible = false;
            else timer2.Enabled = true;
            backgroundWorker_s.RunWorkerAsync();
        }

        private void pnl_datagride_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Visible = !true;
            flp_f.Enabled = !false;
            pnl_nav.Enabled = !false;
            dataGrid.Enabled = !false;
            btn_exit.Enabled = !false;
            comboBox1.Enabled = !false;
            btn_select.Enabled = !false;
        }

        private void btn_preview_Click(object sender, EventArgs e)
        {
            
            frm_preview frm_previw = new frm_preview();
            Student.Properties.Settings.Default.Save();
            frm_previw.setdt = (DataTable)ds.behavior;
            frm_previw.Reportsource = "behav";
            frm_previw.sumbehav = sumb.ToString();
            frm_previw.strhead = textBox1.Text ;
            panel2.Visible = !true;
            flp_f.Enabled = !false;
            pnl_nav.Enabled = !false;
            dataGrid.Enabled = !false;
            btn_exit.Enabled = !false;
            comboBox1.Enabled = !false;
            btn_select.Enabled = !false;
            frm_previw.ShowDialog();
        }
    }
}