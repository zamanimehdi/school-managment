using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Student
{
    public partial class frm_schooltype: Form
    {
        public frm_schooltype()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*System.Data.OleDb.OleDbCommand cmd = new System.Data.OleDb.OleDbCommand();
            System.Data.OleDb.OleDbConnection con = new System.Data.OleDb.OleDbConnection(Student.Properties.Settings.Default.DataConnectionString);
            cmd.Connection = con;
            cmd.CommandText = "SELECT COUNT(*) FROM major";
            con.Open();
            int x = (Int32)cmd.ExecuteScalar();
            if (cmb_schooltype.Text == "نظری" && x==0)
            {
                cmd.CommandText = "INSERT INTO major(name) VALUES('عمومی')";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO major(name) VALUES('ریاضی')";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO major(name) VALUES('تجربی')";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO major(name) VALUES('انسانی')";
                cmd.ExecuteNonQuery();
            }
            else
            if (cmb_schooltype.Text != "نظری")
            {
                cmd.CommandText = "DELETE FROM major WHERE (name ='عمومی')";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "DELETE FROM major WHERE (name ='ریاضی')";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "DELETE FROM major WHERE (name ='تجربی')";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "DELETE FROM major WHERE (name ='انسانی')";
                cmd.ExecuteNonQuery();
            }
            con.Close();*/
        
            Student.Properties.Settings.Default.schooltype = cmb_schooltype.Text;
            Student.Properties.Settings.Default.schoolname = txt_schoolname.Text.Trim();
            Student.Properties.Settings.Default.Save();
            Close();
           
        }
        private void frm_setting_Load(object sender, EventArgs e)
        {
            System.Data.OleDb.OleDbCommand cmd = new System.Data.OleDb.OleDbCommand();
            System.Data.OleDb.OleDbConnection con = new System.Data.OleDb.OleDbConnection(Student.Properties.Settings.Default.DataConnectionString);
            cmd.Connection = con;
            cmd.CommandText = "SELECT COUNT(*) FROM major";
            con.Open();
            int x = (Int32)cmd.ExecuteScalar();
            if (x > 0) cmb_schooltype.Enabled = false;
            con.Close();
          
            if (Student.Properties.Settings.Default.Rcount == -10) txt_schoolname.Enabled = false;
            cmb_schooltype.Text = Student.Properties.Settings.Default.schooltype;
            txt_schoolname.Text = Student.Properties.Settings.Default.schoolname;
        }

    }
}