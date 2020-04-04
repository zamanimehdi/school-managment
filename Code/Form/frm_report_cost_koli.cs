using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Student
{
    public partial class frm_report_cost_koli : Form
    {
        public frm_report_cost_koli()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void frm_report_cost_koli_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'ds_cost_koli.hazime' table. You can move, or remove it, as needed.
                this.hazimeTableAdapter.Fill(this.ds_cost_koli.hazime);
                // TODO: This line of code loads data into the 'ds_cost_koli.kol_pardakhti' table. You can move, or remove it, as needed.
                this.kol_pardakhtiTableAdapter.Fill(this.ds_cost_koli.kol_pardakhti);
                // TODO: This line of code loads data into the 'ds_cost_koli.kol_mablagh' table. You can move, or remove it, as needed.
                this.kol_mablaghTableAdapter.Fill(this.ds_cost_koli.kol_mablagh);
                long hazyne = Int32.Parse(ds_cost_koli.hazime[0][0].ToString());
                long kolpardakhti = Int32.Parse(ds_cost_koli.kol_pardakhti[0][0].ToString());
                long kolmablagh = Int32.Parse(ds_cost_koli.kol_mablagh[0][0].ToString());
                long mandevosoli = kolmablagh - kolpardakhti;
                long sod = kolmablagh - hazyne;
                long baghimande_sandogh = kolpardakhti - hazyne;

                label7.Text = hazyne.ToString();
                label8.Text = kolmablagh.ToString();
                label9.Text = kolpardakhti.ToString();
                label10.Text = mandevosoli.ToString();
                label11.Text = baghimande_sandogh.ToString();
                label12.Text = sod.ToString();
            }
            catch
            {
                MessageBox.Show("اطلاعات براي اجراي اين قسمت كافي نمي‌باشد");
            }
        }
    }
}
