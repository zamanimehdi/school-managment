using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Student
{
    public partial class print_lesson : Form
    {
        frm_proces frm_p = new frm_proces();
        frm_preview form = new frm_preview();
        public print_lesson()
        {
            InitializeComponent();
        }
        private void print_lesson_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsp_print_lesson._class' table. You can move, or remove it, as needed.
            this.classTableAdapter.Fill(this.dsp_print_lesson._class);
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btn_preview_Click(object sender, EventArgs e)
        {
            if (cmb_lesson.Text == "") return;
            can cano = new can();
            if ((txt_datef.Text != "" ? cano.isdate(txt_datef) : true) & (txt_datet.Text != "" ? cano.isdate(txt_datet) : true))
            {
                string start = (txt_datef.Text == "" ? "0" : txt_datef.Text);
                string end = (txt_datet.Text == "" ? "999999" : txt_datet.Text);
                int classid = int.Parse(cmb_lesson.SelectedValue.ToString());
                lessonTableAdapter.Fill(dsp_print_lesson.lesson, (int)classid, (int)classid, (int)classid,
                    start, end, (int)classid, start, end, (int)classid, start, end);

                frm_preview frm = new frm_preview();
                System.Data.DataSet ds = new System.Data.DataSet();
                ds.Tables.Add((DataTable)dsp_print_lesson.lesson.Copy());
                frm.ds = ds;
                frm.strhead = start;
                frm.strbehav = end;
                frm.teachername = cmb_lesson.Text;
                frm.Reportsource = "lesseonreport";
                frm.ShowDialog();
            }

        }

    }
}