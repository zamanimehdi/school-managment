using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Student
{
    public partial class frm_ravand_salane : Form
    {
        public frm_ravand_salane()
        {
            InitializeComponent();
        }
        private void frm_class_salane_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds_hamhang._class' table. You can move, or remove it, as needed.
            this.classTableAdapter.Fill(this.ds_hamhang._class);
            // TODO: This line of code loads data into the 'ds_hamhang.hamahang' table. You can move, or remove it, as needed.
            this.hamahangTableAdapter.Fill(this.ds_hamhang.hamahang);
            
        }
        private void btn_preview_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            label3.Refresh();
            tb_ravand_salaneTableAdapter.Fill(ds_hamhang.tb_ravand_salane,(int)comboBox1.SelectedValue);
            frm_preview frm = new frm_preview();
            System.Data.DataSet ds = new System.Data.DataSet();
            frm.dt = (DataTable)ds_hamhang.tb_ravand_salane;
            frm.strtmp = "گزارش روند آزمون" + " " + comboBox1.Text.Trim() + " " + "سال تحصیلی " + textBox1.Text ;
            frm.Reportsource = "ravand_salane";
            frm.ShowDialog();
            label3.Visible = false;
            label3.Refresh();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
