using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Student
{
    public partial class frm_report_hazyneha : Form
    {
        public frm_report_hazyneha()
        {
            InitializeComponent();
        }

        private void frm_report_hazyneha_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds_cost.costlist' table. You can move, or remove it, as needed.
            this.costlistTableAdapter.Fill(this.ds_cost.costlist);
        }
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                e.Value= e.Value.ToString().Insert(2, "/").Insert(5, "/");
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string str = "";
            if (txt_type.Text != "")
                str += "type like '%" + txt_type.Text+"%'";
            else str += "id<>-1";
            if (textBox3.Visible == true && textBox3.Text!="")
            {
                str += " and who_id like  '%" + textBox3.Text + "%'";
            }
            if (textBox1.Text != "")
                str += " and date>=" + textBox1.Text;
            if (textBox2.Text != "")
                str += " and date<=" + textBox2.Text;
            costlistBindingSource.Filter = str;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = ((DataView)costlistBindingSource.List).ToTable();

            frm_preview frm_previw = new frm_preview();
            frm_previw.teachername = textBox4.Text;
            frm_previw.setdt = dt;
            frm_previw.Reportsource = "cost";
            frm_previw.ShowDialog();
        }

    }
}
