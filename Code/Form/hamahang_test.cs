using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Student
{
    public partial class frm_hamahang_test : Form
    {
        public DataRow post;
        public frm_hamahang_test()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                testsBindingSource.Filter = "date =" + textBox1.Text;
            }
            catch
            { testsBindingSource.Filter = "date ='sadf'"; }
        }

        private void frm_hamahang_test_Shown(object sender, EventArgs e)
        {
            label3.Text = post[1].ToString();
            label5.Text = "برای افزودن امتحانات انتخاب شده در جعبه بالا به " + post[1].ToString().Trim() + " بر روی دکمه روبرو کلیک کنید";
            label6.Text = "برای حذف امتحان انتخاب شده از " + post[1].ToString().Trim() + " بر روی دکمه روبرو کلیک کنید";
            Refresh();
            this.testsTableAdapter.Fill(this.ds_hamahang_test.tests);
            this.testsTableAdapter.FillBy(this.ds_hamahang_test1.tests, int.Parse(post[0].ToString()));
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                dataGridView1[0, e.RowIndex].Value = dataGridView1[0, e.RowIndex].Value.ToString() == "True" ? "False" : "True";
            }
        }
        private void btn_save_Click(object sender, EventArgs e)
        {

        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            for (int i = dataGridView1.RowCount - 1; i >= 0; i--)
            {
                if (dataGridView1[0, i].Value.ToString() == "True")
                {

                    // add from db
                    int idt = int.Parse(   ((DataRowView)dataGridView1.Rows[i].DataBoundItem).Row["idtest"].ToString()  );
                    DataRow[] drs = ds_hamahang_test1.tests.Select("idt='" + idt.ToString()+"'" );
                    if (drs.Length != 0)
                    {
                        MessageBox.Show("امتحان " + ((DataRowView)dataGridView1.Rows[i].DataBoundItem).Row["lessonname"].ToString() + " در تاریخ" + ((DataRowView)dataGridView1.Rows[i].DataBoundItem).Row["date"].ToString() + " قبلا وارد شده است");
                        continue;
                    }
                    hamahang_testTableAdapter.Insert(int.Parse(post[0].ToString()), idt);
                    //
                    ds_hamahang_test1.tests.AddtestsRow(
                        ((DataRowView)dataGridView1.Rows[i].DataBoundItem).Row["date"].ToString(),
                        ((DataRowView)dataGridView1.Rows[i].DataBoundItem).Row["lessonname"].ToString(),
                        ((DataRowView)dataGridView1.Rows[i].DataBoundItem).Row["classname"].ToString(),
                        byte.Parse(((DataRowView)dataGridView1.Rows[i].DataBoundItem).Row["grade"].ToString()),
                        ((DataRowView)dataGridView1.Rows[i].DataBoundItem).Row["major"].ToString(),
                        "False",
                        int.Parse(((DataRowView)dataGridView1.Rows[i].DataBoundItem).Row["idtest"].ToString()) < 0 ? ((DataRowView)dataGridView1.Rows[i].DataBoundItem).Row["id"].ToString() : ((DataRowView)dataGridView1.Rows[i].DataBoundItem).Row["idtest"].ToString(),
                        post[0].ToString()
                        );
                }
            }
        }
        private void btn_del_Click(object sender, EventArgs e)
        {
            if (dataGridView2.RowCount == 0) return;
            // del from db
            int idt = int.Parse(((DataRowView)dataGridView2.CurrentRow.DataBoundItem).Row["idt"].ToString());
            hamahang_testTableAdapter.Delete(int.Parse(post[0].ToString()), idt);
            //
            ds_hamahang_test1.tests.RemovetestsRow((DataSet.ds_hamahang_test.testsRow)((DataRowView)dataGridView2.CurrentRow.DataBoundItem).Row);
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}