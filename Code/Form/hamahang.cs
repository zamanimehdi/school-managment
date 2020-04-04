using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Student
{
    public partial class frm_hamahang : Form
    {
        public frm_hamahang()
        {
            InitializeComponent();
        }
        private void frm_hamahang_Load(object sender, EventArgs e)
        {
            try
            {
                this.hamahangTableAdapter.Fill(this.ds_hamhang.hamahang);
            }
            catch
            {
                System.Data.OleDb.OleDbCommand cmd = new System.Data.OleDb.OleDbCommand();
                cmd.Connection = hamahangTableAdapter.Connection ;
                cmd.Connection.Open();
                cmd.CommandText = "CREATE TABLE hamahang" +
                    "(" +
                    "[id] AUTOINCREMENT(1, 1)," +
                    "[name] CHAR(50)  WITH COMPRESSION," +
                    "[desc] CHAR(100)  WITH COMPRESSION" +
                    ");";
                cmd.ExecuteNonQuery();
                cmd.CommandText ="CREATE TABLE hamahang_test" +
                    "(" +
                    "[id] INTEGER ," +
                    "idtest INTEGER " +
                    ");";
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
        }
        private void btn_select_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = "";
            pnl_center.Visible = true;
            dataGridView1.Enabled = false;
            button1.Enabled = btn_add.Enabled = false;
            textBox1.Focus();
        }

        private void btn_cancle_Click(object sender, EventArgs e)
        {
            pnl_center.Visible = false;
            dataGridView1.Enabled = true;
            button1.Enabled = btn_add.Enabled = true;
            
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != "")
            {
                hamahangTableAdapter.Insert(textBox1.Text.Trim(), textBox2.Text.Trim());
                this.hamahangTableAdapter.Fill(this.ds_hamhang.hamahang);
            }
            else
            {
                MessageBox.Show("نام امتحانات هماهنگ باید وارد گردد");
                return;
            }
            pnl_center.Visible = false;
            dataGridView1.Enabled = true;
            button1.Enabled = btn_add.Enabled = true;
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                frm_hamahang_test form = new frm_hamahang_test();
                form.post = ((DataRowView)hamahangBindingSource.Current).Row;
                form.ShowDialog();
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (hamahangBindingSource.Current != null)
            {
                string id = (((DataRowView)hamahangBindingSource.Current).Row)[0].ToString();
                hamahangTableAdapter.Delete(int.Parse(id));
                hamahangTableAdapter.Delete_from_hamahang_test(decimal.Parse(id));
                this.hamahangTableAdapter.Fill(this.ds_hamhang.hamahang);
            }
        }
    }
}