using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Student
{
    public partial class frm_cost : Form
    {
        public frm_cost()
        {
            InitializeComponent();
        }


        private void frm_cost_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds_cost.costlist' table. You can move, or remove it, as needed.
            this.costlistTableAdapter.Fill(this.ds_cost.costlist);
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            can c = new can();
            try
            {

                if (c.isdate(txt_date))
                {
                    if (comboBox1.SelectedIndex == 0 && txt_who.Text == "")
                    {
                        MessageBox.Show("ذينفع نبايد خالي باشد");

                    }
                    else
                    {
                        ds_cost.costlist.AddcostlistRow(Int32.Parse(txt_costval.Text), txt_txt.Text, (comboBox1.SelectedIndex == 0 ? "حقوق ماهيانه " + comboBox2.Text + " ماه" : (comboBox1.SelectedIndex == 4 ? txt_type.Text : comboBox1.Text)), txt_date.Text, txt_who.Text);
                        costlistTableAdapter.Update(ds_cost.costlist);
                        costlistTableAdapter.Fill(ds_cost.costlist);
                        button1.Visible = button3.Visible = groupBox2.Visible = false;
                        groupBox1.Visible = true;
                        button4.Visible = button2.Visible = button5.Visible = true;
                        Height = 371;

                    }
                }
                else
                {
                    MessageBox.Show("اطلاعات اشتباه مي‌باشد / اطلاعات كامل نمي‌باشد");
                }
            }
            catch
            {
                MessageBox.Show("اطلاعات اشتباه مي‌باشد / اطلاعات كامل نمي‌باشد");
                txt_type.Text = "";
                txt_who.Text = "";
            }
            txt_type.Text = "";
            txt_who.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            costlistBindingSource.RemoveCurrent();
            costlistTableAdapter.Update(ds_cost.costlist);
            costlistTableAdapter.Fill(ds_cost.costlist);
        }
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                e.Value = e.Value.ToString().Insert(2, "/").Insert(5, "/");
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            button1.Visible = button3.Visible = groupBox2.Visible = true;
            groupBox1.Visible = false;
            button4.Visible = button2.Visible = button5.Visible = false;
            Height = 227;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            button1.Visible = button3.Visible = groupBox2.Visible = false;
            groupBox1.Visible = true;
            button4.Visible = button2.Visible = button5.Visible = true;
            Height = 371;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                comboBox2.SelectedIndex = 0;
                label4.Visible = txt_who.Visible = comboBox2.Visible = true;
                txt_type.Visible = label6.Visible = false;
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                label4.Visible = txt_who.Visible = comboBox2.Visible = false;
                txt_type.Visible = label6.Visible = true;
            }
            else
            {
                label4.Visible = txt_who.Visible = comboBox2.Visible = false;
                txt_type.Visible = label6.Visible = false;
            }
        }

    }
}
