using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Student
{
    public partial class frm_workteacher : Form
    {
        public frm_workteacher()
        {
            InitializeComponent();
        }
        private void btn_preview_Click(object sender, EventArgs e)
        {
            can co = new can();
            if (textBox1.Text != "") if (!co.isdate(textBox1)) return;
            if (textBox2.Text != "") if (!co.isdate(textBox2)) return;
            string dfrom = "000000";
            string dto = "999999";
            if (textBox1.Text != "") dfrom = textBox1.Text;
            if (textBox2.Text != "") dto = textBox2.Text;
            // TODO: This line of code loads data into the 'workteacher1.DataTable2' table. You can move, or remove it, as needed.
            this.dataTable2TableAdapter.Fill(this.workteacher1.DataTable2);
            // TODO: This line of code loads data into the 'workteacher1.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.Fill(this.workteacher1.DataTable1, dfrom, dto);
            frm_preview frm_previw = new frm_preview();
            frm_previw.ds = workteacher1;
            if (dfrom == "000000" && dto == "999999")
                frm_previw.strhead = "گزارش متوسط پرسش کلاسی از هر دانش آموز ";
            if (dfrom == "000000" && dto != "999999")
                frm_previw.strhead = "گزارش متوسط پرسش کلاسی از هر دانش آموز تا تاریخ  " + dto.Insert(2, "/").Insert(5, "/"); 
            if (dfrom != "000000" && dto == "999999")
                frm_previw.strhead = "گزارش متوسط پرسش کلاسی از هر دانش آموز از تاریخ " + dfrom.Insert(2, "/").Insert(5, "/") + " تا کنون";
            if (dfrom != "000000" && dto != "999999")
                frm_previw.strhead = "گزارش متوسط پرسش کلاسی از هر دانش آموز از تاریخ " + dfrom.Insert(2, "/").Insert(5, "/") + " تا تاریخ " + dto.Insert(2, "/").Insert(5, "/");
            frm_previw.Reportsource = "teacherwork";
            this.Opacity = 0;
            frm_previw.ShowDialog();
            Close();

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox2.Focus();
                e.SuppressKeyPress = true;
            }
            
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_preview.Focus();
                e.SuppressKeyPress = true;
            }
        }
    }
}