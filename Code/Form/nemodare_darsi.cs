using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Student
{
    public partial class frm_nemodare_darsi : Form
    {
        public frm_nemodare_darsi()
        {
            InitializeComponent();
        }
        private void nemodare_darsi_Load(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if ( rb_class.Checked)
                {
                    can cano = new can();
                    if ((txt_datef.Text != "" ? cano.isdate(txt_datef) : true) & (txt_datet.Text != "" ? cano.isdate(txt_datet) : true))
                    {
                        string datef = (txt_datef.Text == "" ? "0" : txt_datef.Text);
                        string datet = (txt_datet.Text == "" ? "999999" : txt_datet.Text);
                        // if (datef != "0") datef = Convert.ToString(Int32.Parse(datef));
                        // if (datet != "999999") datet = Convert.ToString(Int32.Parse(datet));
                        this.nemmodarclassTableAdapter.Fill(this.dsp_nemodar.nemmodarclass, datef, datet);
                        frm_preview frm = new frm_preview();
                        System.Data.DataSet ds = new System.Data.DataSet();
                        ds.Tables.Add((DataTable)dsp_nemodar.nemmodarclass.Copy());
                        frm.ds = ds;
                        frm.strhead = datef;
                        frm.strbehav = datet;
                        frm.Reportsource = "nemodar";
                        frm.ShowDialog();
                    }
                }
                if ( rb_paye.Checked)
                {
                    can cano = new can();
                    if ((txt_datef.Text != "" ? cano.isdate(txt_datef) : true) & (txt_datet.Text != "" ? cano.isdate(txt_datet) : true))
                    {
                        string datef = (txt_datef.Text == "" ? "0" : txt_datef.Text);
                        string datet = (txt_datet.Text == "" ? "999999" : txt_datet.Text);
                        // if (datef != "0") datef = Convert.ToString(Int32.Parse(datef));
                        // if (datet != "999999") datet = Convert.ToString(Int32.Parse(datet));
                        this.nemodarpayeTableAdapter.Fill(this.dsp_nemodar.nemodarpaye, datef, datet);
                        frm_preview frm = new frm_preview();
                        System.Data.DataSet ds = new System.Data.DataSet();
                        ds.Tables.Add((DataTable)dsp_nemodar.nemodarpaye.Copy());
                        frm.ds = ds;
                        frm.strhead = datef;
                        frm.strbehav = datet;
                        frm.Reportsource = "nemodar_paye";
                        frm.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                frm_exception frm = new frm_exception(ex.Message + "\n\n" + ex.StackTrace);
                frm.ShowDialog();
            }
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
           Opacity = 0; Close();
        }
        private void txt_datef_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txt_datet.Focus();
        }
        private void txt_datet_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_pre.Focus();
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

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}