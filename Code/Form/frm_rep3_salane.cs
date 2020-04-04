using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Student
{
    public partial class frm_faravani : Form
    {
        public frm_faravani()
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
            System.Data.OleDb.OleDbCommand cmd = new System.Data.OleDb.OleDbCommand("q2_class_salane");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("idhamahang", comboBox1.SelectedValue.ToString());

            System.Data.OleDb.OleDbDataAdapter da = new System.Data.OleDb.OleDbDataAdapter();
            da.SelectCommand = cmd;
            da.SelectCommand.Connection = classTableAdapter.Connection;

            DataTable dt = new DataTable("mydt_report3_salane");
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
                    command.CommandText = @"SELECT lesson.name, Count(score.idstudent) AS st_count, Sum(score.score) AS sum_score, Avg(score.score) AS avg_score, Min(score.score) AS min_score, Max(score.score) AS max_score, lesson.idlesson, lesson.grade, major.name AS majorname
FROM (major INNER JOIN (lesson INNER JOIN (hamahang_test INNER JOIN test ON hamahang_test.idtest = test.idtest) ON lesson.idlesson = test.idlesson) ON major.idmajor = lesson.idmajor) INNER JOIN score ON test.idtest = score.idtest
WHERE (((hamahang_test.id)=[?idhamahang]))
GROUP BY lesson.name, lesson.idlesson, lesson.grade, major.name;";
                    cat.Procedures.Append("q2_Query1", command);
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
WHERE (((hamahang_test.id)=[?idhamahang]))
GROUP BY test.idlesson, score.score;";
                    cat.Procedures.Append("q2_Query2", command);
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
                    command.CommandText = @"SELECT TOP 1 q2_Query2.idlesson, q2_Query2.score
FROM q2_Query2
WHERE ((((select count(*) from q2_Query2 as q
                where q.idlesson=q2_Query2.idlesson and  q.CountOfscore>q2_Query2.CountOfscore))<1))
ORDER BY q2_Query2.score DESC;";
                    cat.Procedures.Append("q2_Query3", command);
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
GROUP BY test.idlesson, hamahang_test.id
HAVING (((hamahang_test.id)=[?idhamahang]));";
                    cat.Procedures.Append("q2_Query_find15to", command);
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
GROUP BY test.idlesson, hamahang_test.id
HAVING (((hamahang_test.id)=[?idhamahang]));";
                    cat.Procedures.Append("q2_Query_find18to", command);
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
GROUP BY test.idlesson, hamahang_test.id
HAVING (((hamahang_test.id)=[?idhamahang]));";
                    cat.Procedures.Append("q2_Query_find20", command);
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
                    command.CommandText = @"SELECT q2_Query1.name, q2_Query1.grade, q2_Query1.majorname, q2_Query1.st_count, q2_Query1.sum_score, q2_Query1.avg_score, q2_Query1.min_score, q2_Query1.max_score, q2_Query3.score AS mode_score, q2_Query_find15to.CountOfscore AS c15, q2_Query_find18to.CountOfscore AS c18, q2_Query_find20.count_20 AS c20
FROM (((q2_Query1 LEFT JOIN q2_Query3 ON q2_Query1.idlesson = q2_Query3.idlesson) LEFT JOIN q2_Query_find15to ON q2_Query1.idlesson = q2_Query_find15to.idlesson) LEFT JOIN q2_Query_find18to ON q2_Query1.idlesson = q2_Query_find18to.idlesson) LEFT JOIN q2_Query_find20 ON q2_Query1.idlesson = q2_Query_find20.idlesson;";
                    cat.Procedures.Append("q2_class_salane", command);
                    connection.Close();
                    cat = null;
                }
            }
            frm_preview frm = new frm_preview();
            System.Data.DataSet ds = new System.Data.DataSet();
            frm.dt = dt;
            frm.strtmp = "نتایج تحلیل در دروس آزمون" + " " + comboBox1.Text.Trim();
            frm.Reportsource = "rep3_salane";
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
