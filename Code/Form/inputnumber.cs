using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Student
{
    public partial class frm_inputnumber : Form
    {
        /// Variable
        /// ******************************
        int counterforfilter = 0;
        int recordcount;
        DataRow postdr;
        /// Initialize
        /// ******************************
        public frm_inputnumber()
        {
            InitializeComponent();
        }
        /// Method
        /// ******************************
        private void invert()
        {
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
        private void filtertxtclear()
        {
            for (int i = 0; i < flp_f.Controls.Count; i++)
                flp_f.Controls[i].Text = "";
        }
        private bool allowsave()
        {
            return true;
        }
        private bool allowdel()
        {
            return true;
        }
        /// Event 
        /// ******************************
        private void btn_save_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Refresh();
            for (int i = 0; i < scoreBindingSource.Count; i++)
            {
                if (((DataRowView)scoreBindingSource.List[i])["score"].ToString() != "")
                {
                    if (null != scoreTableAdapter.edit_or_insert(UInt64.Parse(((DataRowView)scoreBindingSource.List[i])["idstudent"].ToString()), Int32.Parse(postdr["idtest"].ToString())))
                        //update
                        scoreTableAdapter.UpdateQuery(Convert.ToDecimal(((DataRowView)scoreBindingSource.List[i])["score"]), Int32.Parse(postdr["idtest"].ToString()), UInt64.Parse(((DataRowView)scoreBindingSource.List[i])["idstudent"].ToString()));
                    else
                        //insert
                        scoreTableAdapter.InsertQuery(Int32.Parse(postdr["idtest"].ToString()), UInt64.Parse(((DataRowView)scoreBindingSource.List[i])["idstudent"].ToString()),   Convert.ToDecimal(((DataRowView)scoreBindingSource.List[i])["score"])    );
                }
                else
                    //delete
                    scoreTableAdapter.DeleteQuery(Int32.Parse(postdr["idtest"].ToString()), UInt64.Parse(((DataRowView)scoreBindingSource.List[i])["idstudent"].ToString()));
            }
            Opacity = 0;
           Opacity = 0; Close();
            //ds_inputnumber.score.AcceptChanges();
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
           Opacity = 0; Close();
        }
        private void btn_next_Click(object sender, EventArgs e)
        {
            scoreBindingSource.MoveNext();
        }
        private void btn_prev_Click(object sender, EventArgs e)
        {
            scoreBindingSource.MovePrevious();
        }
        private void btn_last_Click(object sender, EventArgs e)
        {
            scoreBindingSource.MoveLast();
        }
        private void btn_first_Click(object sender, EventArgs e)
        {
            scoreBindingSource.MoveFirst();
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
                if (txt_idstudent_f.Text != "") str_f += " idstudent=" + txt_idstudent_f.Text;
                if (txt_name_f.Text != "")
                {
                    if (len_str_f != str_f.Length) { str_f += " and "; len_str_f = str_f.Length; }
                    str_f += " name like '" + txt_name_f.Text + "%'";
                }
                if (txt_score_f.Text != "")
                {
                    if (len_str_f != str_f.Length) { str_f += " and "; len_str_f = str_f.Length; }
                    str_f += " score = " + txt_score_f.Text + "";
                }
                try
                {
                    scoreBindingSource.Filter = str_f;
                }
                catch
                {
                    str_f = "";
                }
            }
        }
        private bool canfillter()
        {
            for (int i = 0; i < flp_f.Controls.Count; i++)
                flp_f.Controls[i].Text = flp_f.Controls[i].Text.Trim();
            return true;
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
            this.scoreTableAdapter.Fill(this.ds_inputnumber.score, Int32.Parse(postdr["idclass"].ToString()));
            for (int i = 0; i < ds_inputnumber.score.Count; i++)
            {
                Student.DataSet.ds_inputnumberTableAdapters.QueriesTableAdapter myq = new Student.DataSet.ds_inputnumberTableAdapters.QueriesTableAdapter();
                object temp = (object)myq.getscore(Int32.Parse(postdr["idtest"].ToString()), ds_inputnumber.score[i].idstudent);
                if (temp != null)
                    ds_inputnumber.score[i].score = (double)temp;
            }
        }
        private void backgroundWorker_s_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            timer2.Enabled = false;
            prba.Value = 100;
            prba.Refresh();
            lbl_prba1.Text = "100%";
            lbl_prba1.Refresh();
            scoreBindingSource.DataMember = "score";// ☻
            scoreBindingSource.DataSource = this.ds_inputnumber;// ☻
            scoreBindingSource.Sort = "name";// ☻
            pnl_prba.Visible = false;
            actfilter(null, null);
            if (dataGrid.Rows.Count != 0)
                dataGrid.CurrentCell = dataGrid.Rows[0].Cells[2];
            btn_save.Enabled = false;
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (recordcount != 0)
            {
                try
                {
                    prba.Value = Convert.ToInt32((ds_inputnumber.score.Count * 100) / recordcount);// ☻
                    lbl_prba1.Text = prba.Value.ToString() + "%";
                    if (recordcount == ds_inputnumber.score.Count) backgroundWorker_s_RunWorkerCompleted(null, null);
                }
                catch { }
            }
            else
            {
                prba.Value = 50;
                lbl_prba1.Text = "50%";
            }
        }
        private void frm_inputnumber_Load(object sender, EventArgs e)
        {
            recordcount = Int32.Parse(scoreTableAdapter.recordcount(Int32.Parse(postdr["idclass"].ToString()), Int32.Parse(postdr["idtest"].ToString())).ToString());// ☻
            //if (recordcount <= 0) pnl_prba.Visible = false;
            //else 
            timer2.Enabled = true;
            lbl_class_info.Text += " " + postdr["classname"].ToString();
            lbl_data_info.Text += " " + postdr["date"].ToString().Insert(2, "/").Insert(5, "/"); ;
            lbl_lesson_info.Text += " " + postdr["name"].ToString();
            backgroundWorker_s.RunWorkerAsync();
            setfilterwidth();
        }
        private void dataGrid_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                dataGrid.CurrentCell = dataGrid[2, dataGrid.CurrentCell.RowIndex];
            }
            catch { }
            //  dataGrid[2, dataGrid.CurrentCell.RowIndex].Value = e.KeyValue.ToString();
        }
        private void dataGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == dataGrid.Rows.Count - 1)
                btn_save.Focus();
            try
            {
                if (double.Parse(dataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()) > 20 ||
                    double.Parse(dataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()) < 0)
                {
                    //if (double.Parse(dataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()) != 98)
                    {
                        MessageBox.Show("عدد خارج از محدوده می باشد");
                        dataGrid[2, e.RowIndex].Value = DBNull.Value;
                    }
                }
                else if (double.Parse(dataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()) == 0)
                    dataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 0.0000001;
            }
            catch
            { }
        }
        private void dataGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            btn_save.Enabled = true;
        }
        private void dataGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2)
                if (dataGrid.Rows[e.RowIndex].Cells[2].Value.ToString() != "")
                    if (double.Parse(dataGrid.Rows[e.RowIndex].Cells[2].Value.ToString()) < 0.000001)
                        e.Value = "صفر";
        }
        private void dataGrid_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("عدد اشتباه می باشد");
            dataGrid.CancelEdit();
        }
        private void leavecolor(object sender, EventArgs e)
        {
            ((Control)sender).BackColor = Color.Empty;
            filtertxtclear();
        }
        private void entercolor(object sender, EventArgs e)
        {
            ((Control)sender).BackColor = Color.SeaShell;
        }

        // property
        /////////////////
        public DataRow post
        {
            set
            {
                postdr = value;
            }
        }

        private void dataGrid_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                contextMenuStrip1.Show(MousePosition);
        }

        private void انضباتیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_behaviour frm = new frm_behaviour();
            frm.Opacity = 0;
            frm.post = ((DataRowView)scoreBindingSource.Current).Row;
            frm.isfromlistnumber = true;
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((DataRowView)scoreBindingSource.Current != null)
            {
                frm_behaviour frm = new frm_behaviour();
                frm.Opacity = 0;
                frm.post = ((DataRowView)scoreBindingSource.Current).Row;
                frm.isfromlistnumber = true;
                frm.ShowDialog();
            }
            else
                MessageBox.Show("دانش آموزی انتخاب نشده است");

        }
    }
}