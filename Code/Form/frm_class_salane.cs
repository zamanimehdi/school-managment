using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Student
{
    public partial class frm_class_salane : Form
    {
        public frm_class_salane()
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
            System.Data.OleDb.OleDbCommand cmd = new System.Data.OleDb.OleDbCommand("class_salane");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("idhamahang", comboBox1.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("idclass", comboBox2.SelectedValue.ToString());

            System.Data.OleDb.OleDbDataAdapter da = new System.Data.OleDb.OleDbDataAdapter();
            da.SelectCommand = cmd;
            da.SelectCommand.Connection = classTableAdapter.Connection;

            DataTable dt = new DataTable("mydt_class_salane");
            try
            {
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" +
                System.Windows.Forms.Application.StartupPath
                + "\\data.mdb;Persist Security Info=True";

                {
                    ADOX.CatalogClass cat = new ADOX.CatalogClass();
                    ADODB.Connection connection = new ADODB.ConnectionClass();
                    connection.Open(connectionString, "", "", 0);
                    cat.ActiveConnection = connection;
                    StringBuilder sb = new StringBuilder();
                    ADODB.CommandClass command = new ADODB.CommandClass();
                    command.CommandType = ADODB.CommandTypeEnum.adCmdText;
                    command.CommandText = @"SELECT lesson.name, Count(score.idstudent) AS st_count, Sum(score.score) AS sum_score, Avg(score.score) AS avg_score, Min(score.score) AS min_score, Max(score.score) AS max_score, lesson.idlesson
                FROM (lesson INNER JOIN (hamahang_test INNER JOIN test ON hamahang_test.idtest = test.idtest) ON lesson.idlesson = test.idlesson) INNER JOIN score ON test.idtest = score.idtest
                WHERE (((hamahang_test.id)=[?idhamahang]) AND ((test.idclass)=[?idclass]))
                GROUP BY lesson.name, lesson.idlesson;";
                    cat.Procedures.Append("Query1", command);
                    cat = null;
                }
                {
                    ADOX.CatalogClass cat = new ADOX.CatalogClass();
                    ADODB.Connection connection = new ADODB.ConnectionClass();
                    connection.Open(connectionString, "", "", 0);
                    cat.ActiveConnection = connection;
                    StringBuilder sb = new StringBuilder();
                    ADODB.CommandClass command = new ADODB.CommandClass();
                    command.CommandType = ADODB.CommandTypeEnum.adCmdText;
                    command.CommandText = @"SELECT test.idlesson, score.score, Count(score.score) AS CountOfscore
                FROM (hamahang_test INNER JOIN test ON hamahang_test.idtest = test.idtest) INNER JOIN score ON test.idtest = score.idtest
                WHERE (((hamahang_test.id)=[?idhamahang]) AND ((test.idclass)=[?idclass]))
                GROUP BY test.idlesson, score.score;";
                    cat.Procedures.Append("Query2", command);
                    cat = null;
                }
                {
                    ADOX.CatalogClass cat = new ADOX.CatalogClass();
                    ADODB.Connection connection = new ADODB.ConnectionClass();
                    connection.Open(connectionString, "", "", 0);
                    cat.ActiveConnection = connection;
                    StringBuilder sb = new StringBuilder();
                    ADODB.CommandClass command = new ADODB.CommandClass();
                    command.CommandType = ADODB.CommandTypeEnum.adCmdText;
                    command.CommandText = @"SELECT TOP 1 Query2.idlesson, Query2.score
                FROM Query2
                WHERE ((((select count(*) from Query2 as q
                where q.idlesson=Query2.idlesson and  q.CountOfscore>Query2.CountOfscore))<1))
                ORDER BY Query2.score DESC;";
                    cat.Procedures.Append("Query3", command);
                    cat = null;
                }
                {
                    ADOX.CatalogClass cat = new ADOX.CatalogClass();
                    ADODB.Connection connection = new ADODB.ConnectionClass();
                    connection.Open(connectionString, "", "", 0);
                    cat.ActiveConnection = connection;
                    StringBuilder sb = new StringBuilder();
                    ADODB.CommandClass command = new ADODB.CommandClass();
                    command.CommandType = ADODB.CommandTypeEnum.adCmdText;
                    command.CommandText = @"SELECT test.idlesson, Count(score.score) AS CountOfscore
                FROM (hamahang_test INNER JOIN test ON hamahang_test.idtest = test.idtest) INNER JOIN score ON test.idtest = score.idtest
                WHERE (((score.score)>=15 And (score.score)<18))
                GROUP BY test.idlesson, hamahang_test.id, test.idclass
                HAVING (((hamahang_test.id)=[?idhamahang]) AND ((test.idclass)=[?idclass]));";
                    cat.Procedures.Append("Query_find15to", command);
                    cat = null;
                }
                {
                    ADOX.CatalogClass cat = new ADOX.CatalogClass();
                    ADODB.Connection connection = new ADODB.ConnectionClass();
                    connection.Open(connectionString, "", "", 0);
                    cat.ActiveConnection = connection;
                    StringBuilder sb = new StringBuilder();
                    ADODB.CommandClass command = new ADODB.CommandClass();
                    command.CommandType = ADODB.CommandTypeEnum.adCmdText;
                    command.CommandText = @"SELECT test.idlesson, Count(score.score) AS CountOfscore
                FROM (hamahang_test INNER JOIN test ON hamahang_test.idtest = test.idtest) INNER JOIN score ON test.idtest = score.idtest
                WHERE (((score.score)>=18 And (score.score)<20))
                GROUP BY test.idlesson, hamahang_test.id, test.idclass
                HAVING (((hamahang_test.id)=[?idhamahang]) AND ((test.idclass)=[?idclass]));";
                    cat.Procedures.Append("Query_find18to", command);
                    cat = null;
                }
                {
                    ADOX.CatalogClass cat = new ADOX.CatalogClass();
                    ADODB.Connection connection = new ADODB.ConnectionClass();
                    connection.Open(connectionString, "", "", 0);
                    cat.ActiveConnection = connection;
                    StringBuilder sb = new StringBuilder();
                    ADODB.CommandClass command = new ADODB.CommandClass();
                    command.CommandType = ADODB.CommandTypeEnum.adCmdText;
                    command.CommandText = @"SELECT test.idlesson, Count(score.score) AS count_20
                FROM (hamahang_test INNER JOIN test ON hamahang_test.idtest = test.idtest) INNER JOIN score ON test.idtest = score.idtest
                WHERE (((score.score)=20))
                GROUP BY test.idlesson, hamahang_test.id, test.idclass
                HAVING (((hamahang_test.id)=[?idhamahang]) AND ((test.idclass)=[?idclass]));";
                    cat.Procedures.Append("Query_find20", command);
                    connection.Close();
                    cat = null;
                }
                {
                    ADOX.CatalogClass cat = new ADOX.CatalogClass();
                    ADODB.Connection connection = new ADODB.ConnectionClass();
                    connection.Open(connectionString, "", "", 0);
                    cat.ActiveConnection = connection;
                    StringBuilder sb = new StringBuilder();
                    ADODB.CommandClass command = new ADODB.CommandClass();
                    command.CommandType = ADODB.CommandTypeEnum.adCmdText;
                    command.CommandText = @"SELECT Query1.name, Query1.st_count, Query1.sum_score, Query1.avg_score, Query1.min_score, Query1.max_score, Query3.score AS mode_score, Query_find15to.CountOfscore AS c15, Query_find18to.CountOfscore AS c18, Query_find20.count_20 AS c20
                    FROM (((Query1 LEFT JOIN Query3 ON Query1.idlesson = Query3.idlesson) LEFT JOIN Query_find15to ON Query1.idlesson = Query_find15to.idlesson) LEFT JOIN Query_find18to ON Query1.idlesson = Query_find18to.idlesson) LEFT JOIN Query_find20 ON Query1.idlesson = Query_find20.idlesson;";
                    cat.Procedures.Append("class_salane", command);
                    connection.Close();
                    cat = null;
                }
            }
            frm_preview frm = new frm_preview();
            System.Data.DataSet ds = new System.Data.DataSet();
            frm.dt = dt;
            frm.strtmp = "نتایج تحلیل آزمون" + " " + comboBox1.Text.Trim() + " " + "در کلاس " + comboBox2.Text.Trim();
            frm.Reportsource = "class_salane";
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
