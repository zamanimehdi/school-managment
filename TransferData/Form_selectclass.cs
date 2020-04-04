using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Internet_SM
{
    public partial class Form_selectclass : Form
    {
        public int schollcode;
        public Form_selectclass()
        {
            InitializeComponent();
        }
        static DBDataSet.studentDataTable st;
        private void button1_Click(object sender, EventArgs e)
        {
            st = studentTableAdapter.GetData();
            Random rnd = new Random();
            for (int i = 0; i < st.Rows.Count; i++)
            {
                st[i]["idstudent"] = Internet_SM.Properties.Settings.Default.SchoolCode.ToString() + st[i]["idstudent"].ToString();
                st[i]["pass"] = rnd.Next(1000, 9999); Refresh();
            }
            backgroundWorker1.RunWorkerAsync();
        }
        private void Form_selectclass_Shown(object sender, EventArgs e)
        {
            Refresh();
            // TODO: This line of code loads data into the 'webDataSet.userPassTable' table. You can move, or remove it, as needed.
            this.userPassTableTableAdapter.Fill(this.webDataSet.userPassTable); Refresh();
            // TODO: This line of code loads data into the 'dBDataSet.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.dBDataSet.student);
            // TODO: This line of code loads data into the 'dBDataSet._class' table. You can move, or remove it, as needed.
            this.classTableAdapter.Fill(this.dBDataSet._class);
            Refresh();
            button1_Click(null, null);
        }
        static WebDataSet.userPassTableDataTable webtb;
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            webtb = userPassTableTableAdapter.GetData();
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            for (int i = 0; i < st.Rows.Count; i++)
            {
                string stid = st[i]["idstudent"].ToString();
                DataRow[] dr = webtb.Select("usreName='" + stid + "'");
                if (dr.Count() != 0)
                {
                    st[i]["pass"] = dr[0]["pass"].ToString();
                }
                else
                {
                    userPassTableTableAdapter.InsertUserPass(stid, st[i]["pass"].ToString());
                }
                Refresh();
            }
            string url = label2.Text;
            report frm = new report();
            frm.userNamePass1.SetDataSource((DataTable)st);
             frm.userNamePass1.SetParameterValue("siteUrl", url);
            frm.ShowDialog();
            st.Clear(); st.Clone(); st.Dispose();
            webtb.Clear(); webtb.Clone(); webtb.Dispose();
            Close();
        }

        private void Form_selectclass_Load(object sender, EventArgs e)
        {
            
        }
    }
}
