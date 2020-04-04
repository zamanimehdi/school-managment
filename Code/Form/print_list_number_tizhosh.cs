using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Student
{
    public partial class print_list_number : Form
    {
        public print_list_number()
        {
            InitializeComponent();
        }

        private void print_list_number_Load(object sender, EventArgs e)
        {
            this.classTableAdapter.Fill(this.dsp_list_number_tizhoshan._class);
            this.lessonTableAdapter.Fill(this.dsp_list_number_tizhoshan.lesson);

        }
        private void btn_preview_Click(object sender, EventArgs e)
        {
            if (cmb_class.SelectedValue == null) return;
            can cano = new can();
            if ((d1.Text == "" || cano.isdate(d1)) && (d2.Text== "" || cano.isdate(d2)))
            {
                frm_preview pre = new frm_preview();
                pre.array_param= new object[12];
                string start = "000000";
                string end = "999999";
                if (d1.Text != "") start = d1.Text;
                if (d2.Text != "") end = d2.Text;
                System.Collections.ArrayList al = new System.Collections.ArrayList();
                int indexparam=0;
                for (int i = 0; i < dataGridView1.RowCount; i++)
                    if ((bool)dataGridView1[1, i].Value == true)
                    {
                        al.Add(dataGridView1[0, i].Value);
                        if (indexparam <= 11)
                            pre.array_param[indexparam++] = dataGridView1[2, i].Value.ToString();
                    }
                for (int j = al.Count; j < 12; j++)
                {
                    al.Add(-1);
                    pre.array_param[j] = "- - -";
                }//array_param
                if (rb_avg.Checked)
                    tb_list_numberTableAdapter.Fill(dsp_list_number_tizhoshan.tb_list_number,
                        start, end, (int)al[0],
                        start, end, (int)al[1],
                        start, end, (int)al[2],
                        start, end, (int)al[3],
                        start, end, (int)al[4],
                        start, end, (int)al[5],
                        start, end, (int)al[6],
                        start, end, (int)al[7],
                        start, end, (int)al[8],
                        start, end, (int)al[9],
                        start, end, (int)al[10],
                        start, end, (int)al[11]);
                if (rb_max.Checked)
                    tb_list_numberTableAdapter.FillBymax(dsp_list_number_tizhoshan.tb_list_number,
                        start, end, (int)al[0],
                        start, end, (int)al[1],
                        start, end, (int)al[2],
                        start, end, (int)al[3],
                        start, end, (int)al[4],
                        start, end, (int)al[5],
                        start, end, (int)al[6],
                        start, end, (int)al[7],
                        start, end, (int)al[8],
                        start, end, (int)al[9],
                        start, end, (int)al[10],
                        start, end, (int)al[11]);
                if (rb_min.Checked)
                    tb_list_numberTableAdapter.FillBymin(dsp_list_number_tizhoshan.tb_list_number,
                        start, end, (int)al[0],
                        start, end, (int)al[1],
                        start, end, (int)al[2],
                        start, end, (int)al[3],
                        start, end, (int)al[4],
                        start, end, (int)al[5],
                        start, end, (int)al[6],
                        start, end, (int)al[7],
                        start, end, (int)al[8],
                        start, end, (int)al[9],
                        start, end, (int)al[10],
                        start, end, (int)al[11]);
                tblistnumberBindingSource.Filter="idclass=" + cmb_class.SelectedValue.ToString();
                DataTable dt=((DataView)tblistnumberBindingSource.List).ToTable();
                ///////////////
                pre.setdt = dt;
                foreach (DataRow dtrow in dt.Rows)
                {
                    dtrow[13] = dtrow[12] + " " + dtrow[13];
                }
                if (rb_sort_id.Checked == true)
                    pre.Reportsource = "list_number_tizhoshan";
                else
                    pre.Reportsource = "list_number_tizhoshan_sort_lname";
                pre.strhead = cmb_class.Text;
                pre.strbehav = txt_head.Text;
                pre.teachername = "";
                if (d1.Text.Length == 6 && d2.Text.Length == 6)
                    pre.teachername = "از تاریخ " + d1.Text.Insert(2, "/").Insert(5, "/") + " تا " + d2.Text.Insert(2, "/").Insert(5, "/");
                if (d1.Text.Length == 6 && d2.Text.Length != 6)
                    pre.teachername = "از تاریخ " + d1.Text.Insert(2, "/").Insert(5, "/");
                if (d1.Text.Length != 6 && d2.Text.Length == 6)
                    pre.teachername = "از ابتدای سال تحصیلی تا  " + d2.Text.Insert(2, "/").Insert(5, "/");
                pre.ShowDialog();
            }
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void classBindingSource_PositionChanged(object sender, EventArgs e)
        {
            string idmajor = ((DataRowView)classBindingSource.Current)["idmajor"].ToString();
            string grade = ((DataRowView)classBindingSource.Current)["grade"].ToString();
            lessonBindingSource.Filter = "idmajor=" + idmajor + " and grade=" + grade;
        }
    }
}