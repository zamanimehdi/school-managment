using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace Internet_SM
{
    public partial class frm_main : Form
    {
        int schoolCode = int.Parse((Internet_SM.Properties.Settings.Default.SchoolCode == "") ? "-1" : Internet_SM.Properties.Settings.Default.SchoolCode);
        DataTable hamahang,bti, scti, stti, teti, leti, avti,student;
        int allRecordi = 0;
        int allRecord = 0;
        static byte[] bytes = ASCIIEncoding.ASCII.GetBytes("A23nS0#s");
        public frm_main()
        {
            InitializeComponent();
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            MessageBox.Show("تاریخ امروز : "+label6.Text+"\r\n"+"در صورتی که تاریخ امروز به درستی نشان داده شد می توانید اقدام به ارسال اطلاعات نمایید"+"\r\n"+"در غیر اینصورت تاریخ سیستم را تنظیم نمایید و سپس اقدام به ارسال اطلاعات نمایید");
        }
        private void button2_Click(object sender, EventArgs e)
        {
        }
        private void button1_Click_2(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                MessageBox.Show("آدرس سایت را وارد کنید");
                return;
            }
            Refresh();
            Internet_SM.Properties.Settings.Default.Save();
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("کد اتصال و رمز اتصال را تکمیل کنید  ");
                return;
            }
            string dstr=Decrypt(textBox2.Text);
            object obj=null;
            try
            {
                obj = schoolTablepassworkTableAdapter.passcheck(schoolCode, dstr);
            }
            catch
            {
                MessageBox.Show("امکان اتصال به سرور وجود ندارد" + "\r\n" + "لطفا از اتصال خود به شبکه اینترنت اطمینان حاصل کنید");
                return;
            }
            if (obj == null)
            {
                MessageBox.Show("کد اتصال و رمز اتصال اشتباه می باشد" + "\r\n" + "یا ممکن است نسخه اینترنتی توسط شما خریده نشده باشد", "", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
            }
            else
            {
                Form_selectclass frm = new Form_selectclass();
                frm.label2.Text = textBox3.Text;
                frm.schollcode = schoolCode;
                frm.ShowDialog();
                webDataSet.Clear();
                webDataSet.Reset();
            }
        }
        private void frm_main_Load(object sender, EventArgs e)
        {
            string str = Application.ExecutablePath.ToString().Substring(0, Application.ExecutablePath.ToString().Length - 15);
            // MessageBox.Show("لطفا قبل از عملیات ارسال اطلاعات برنامه مدیریت مدرسه را ببندید");
            System.IO.File.Copy(str + "data.mdb", str + "send.mdb", true);
            //=============================================================
            //MessageBox.Show("conection be db server vasl nist");
            Internet_SM.Properties.Settings.Default.conect2server = "Data Source=mssql.edusm.ir;Initial Catalog=edusm;Persist Security Info=True;User ID=edusm;Password=mY3U7zDZnwg";
            //=============================================================
            comboBox1.SelectedIndex = 0;
            System.Globalization.PersianCalendar pc = new System.Globalization.PersianCalendar();
            System.DateTime dt = DateTime.Now;
            label6.Text = pc.GetYear(dt).ToString().Substring(2, 2) +"/"+ pc.GetMonth(dt).ToString() + "/"+ pc.GetDayOfMonth(dt).ToString();
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            try
            {
                Internet_SM.Properties.Settings.Default.SchoolCode = Int32.Parse(textBox1.Text).ToString();
                Internet_SM.Properties.Settings.Default.Save();
                schoolCode = Int32.Parse(textBox1.Text);
            }
            catch
            {
                textBox1.Text = "";
            }
        }
        private void textBox2_Leave(object sender, EventArgs e)
        {
            try
            {
                string pass=textBox2.Text.Trim().Replace("'", "A").Replace('"', 'A').Replace(" ", "A").Replace("*", "A").Replace("%", "A");
                string EncryptedPassword = Encrypt(pass);
                Internet_SM.Properties.Settings.Default.SchoolPass = EncryptedPassword;
                Internet_SM.Properties.Settings.Default.Save();
                textBox2.Text = EncryptedPassword;
            }
            catch
            {
                textBox2.Text = "";
            }
        }
        //////////////////////////
        public static string Encrypt(string originalString)
        {
            if (String.IsNullOrEmpty(originalString))
            {
                throw new ArgumentNullException("The string which needs to be encrypted can not be null.");
            }

            DESCryptoServiceProvider cryptoProvider = new DESCryptoServiceProvider();
            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, cryptoProvider.CreateEncryptor(bytes, bytes), CryptoStreamMode.Write);

            StreamWriter writer = new StreamWriter(cryptoStream);
            writer.Write(originalString);
            writer.Flush();
            cryptoStream.FlushFinalBlock();
            writer.Flush();

            return Convert.ToBase64String(memoryStream.GetBuffer(), 0, (int)memoryStream.Length);
        }
        public static string Decrypt(string cryptedString)
        {
            if (String.IsNullOrEmpty(cryptedString))
            {
                
            }

            DESCryptoServiceProvider cryptoProvider = new DESCryptoServiceProvider();
            MemoryStream memoryStream = new MemoryStream(Convert.FromBase64String(cryptedString));
            CryptoStream cryptoStream = new CryptoStream(memoryStream, cryptoProvider.CreateDecryptor(bytes, bytes), CryptoStreamMode.Read);
            StreamReader reader = new StreamReader(cryptoStream);

            return reader.ReadToEnd();
        }
        //////////////////////////
        private void textBox2_Enter(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            
               MessageBox.Show("همه را پاک می کند");
             tempTableAdapter.DeleteQuery1();
             tempTableAdapter.DeleteQuery2();
             tempTableAdapter.DeleteQuery3();
             tempTableAdapter.DeleteQuery4();
             tempTableAdapter.DeleteQuery5();
             tempTableAdapter.DeleteQuery6();
             tempTableAdapter.DeleteQuery7();
             tempTableAdapter.DeleteQuery8(); 
             tempTableAdapter.DeleteQuery9();
            

            MessageBox.Show("محتویات کامنت هست");
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                object obj = schoolTablepassworkTableAdapter.passcheck(Int32.Parse(Internet_SM.Properties.Settings.Default.SchoolCode), Internet_SM.Properties.Settings.Default.dstr);
                Internet_SM.Properties.Settings.Default.obj = (obj == null) ? "null" : obj.ToString();
            }
            catch
            {
                e.Result = "false";
            }
        }
        private void btn_sendData_Click(object sender, EventArgs e)
        {
            string datestart = "000000";
            string dateend = "999999";
            System.Globalization.PersianCalendar pc = new System.Globalization.PersianCalendar();
            System.DateTime dt = DateTime.Now;
            if (comboBox1.SelectedIndex != 0)
            {
                int year = int.Parse(pc.GetYear(dt).ToString().Substring(2, 2));
                int month = int.Parse(pc.GetMonth(dt).ToString());
                int day = int.Parse(pc.GetDayOfMonth(dt).ToString());
                switch (comboBox1.SelectedIndex)
                {
                    case 1:
                        dt = dt.Add(TimeSpan.FromDays(0));
                        break;
                    case 2:
                        dt = dt.Add(TimeSpan.FromDays(-3));
                        break;
                    case 3:
                        dt = dt.Add(TimeSpan.FromDays(-7));
                        break;
                    case 4:
                        dt = dt.Add(TimeSpan.FromDays(-15));
                        break;
                    case 5:
                        dt = dt.Add(TimeSpan.FromDays(-30));
                        break;
                    case 6:
                        dt = dt.Add(TimeSpan.FromDays(-60));
                        break;
                }
                int year2 = int.Parse(pc.GetYear(dt).ToString().Substring(2, 2));
                int month2 = int.Parse(pc.GetMonth(dt).ToString());
                int day2 = int.Parse(pc.GetDayOfMonth(dt).ToString());

                dateend= year + ((month.ToString().Length == 1) ? ("0" + month.ToString()) : month.ToString()) + ((day.ToString().Length == 1) ? ("0" + day.ToString()) : day.ToString());
                datestart = year2 + ((month2.ToString().Length == 1) ? ("0" + month2.ToString()) : month2.ToString()) + ((day2.ToString().Length == 1) ? ("0" + day2.ToString()) : day2.ToString());
            }
            Internet_SM.Properties.Settings.Default.date_start = datestart;
            Internet_SM.Properties.Settings.Default.date_end = dateend;
            
            Internet_SM.Properties.Settings.Default.now =label6.Text.Split('/')[1] + "/" + label6.Text.Split('/')[2]; //label6.Text.Substring(3,4);

            //$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$ FILL
            this.Refresh();
            try
            {
                hamahang_to_internetTableAdapter.Fill(dbDataSet1.hamahang_to_internet);
            }
            catch
            {
                MessageBox.Show("دیتابیس شما مربوط به نسخه های قدیمی تر برنامه می باشد"+"\r\n"+"برای حل این مشکل وارد قسمت امتحانات هماهنگ در برنامه مدیریت مدرسه شوید و برنامه را ببندید ، سپس مجددا برای ارسال اطلاعات تلاش نمایید ");
                Close();
            }
            hamahang = (DataTable)dbDataSet1.hamahang_to_internet;

            this.behavior_To_InternetTableAdapter1.Fill(dbDataSet1.behavior_To_Internet,datestart,dateend);
            bti = (DataTable)dbDataSet1.behavior_To_Internet;

            this.score_To_InternetTableAdapter1.Fill(dbDataSet1.Score_To_Internet,datestart,dateend);
            scti = (DataTable)dbDataSet1.Score_To_Internet;

            this.u.Fill(dbDataSet1.student_To_Internet);
            stti = (DataTable)dbDataSet1.student_To_Internet;

            this.lesson_To_InternetTableAdapter1.Fill(dbDataSet1.lesson_To_Internet);
            leti = (DataTable)dbDataSet1.lesson_To_Internet;

            // username password
            this.studentTableAdapter1.Fill(dbDataSet1.student);
            student = (DataTable)dbDataSet1.student;

            allRecordi = hamahang.Rows.Count + bti.Rows.Count + stti.Rows.Count + leti.Rows.Count + scti.Rows.Count;
            progressBar3.Maximum = allRecordi;
            //$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$


            Refresh();
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("کد اتصال و رمز اتصال را تکمیل کنید  ");
                button1.Visible = true; btn_sendData.Visible = true; label4.Visible = false; textBox1.Enabled = textBox2.Enabled = true;
                textBox3.Enabled = true;
                return;
            }
            string dstr = Decrypt(textBox2.Text);
            label4.Text = "برقراری اتصال با سرور  - لطفا صبر کنید"; 
            label4.Visible = true; button1.Visible = false; btn_sendData.Visible = false;
            chk_dars.Enabled=chk_student.Enabled=comboBox1.Enabled= textBox3.Enabled = textBox1.Enabled = textBox2.Enabled = false;
            Internet_SM.Properties.Settings.Default.dstr = dstr;
            
            
            //
            allRecord = allRecordi;
            if (!chk_student.Checked) 
                allRecord = allRecord - stti.Rows.Count - bti.Rows.Count;
            if (!chk_dars.Checked)
                allRecord = allRecord - leti.Rows.Count;
            progressBar3.Maximum = allRecord;
            //
            

            backgroundWorker1.RunWorkerAsync();


        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Result!=null)
            {
                MessageBox.Show("امکان اتصال به سرور وجود ندارد" + "\r\n" + "لطفا از اتصال خود به شبکه اینترنت اطمینان حاصل کنید");

                label4.Visible = !true; button1.Visible = !false; btn_sendData.Visible = !false;
                chk_dars.Enabled = chk_student.Enabled = comboBox1.Enabled = textBox3.Enabled = textBox1.Enabled = textBox2.Enabled = !false;

            }
            else
                step2();
        }
        private void step2()
        {
            if (Internet_SM.Properties.Settings.Default.obj == "null")
            {
                MessageBox.Show("کد اتصال و رمز اتصال اشتباه می باشد" + "\r\n" + "یا ممکن است نسخه اینترنتی توسط شما خریده نشده باشد", "", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                
                label4.Visible = !true; button1.Visible = !false; btn_sendData.Visible = !false;
                chk_dars.Enabled = chk_student.Enabled = comboBox1.Enabled = textBox3.Enabled = textBox1.Enabled = textBox2.Enabled = !false;
                button1.Refresh(); btn_sendData.Refresh(); label4.Visible = false; label4.Refresh();
            }
            else
            {
                label4.Text = "در حال ارسال اطلاعات - لطفا صبر کنید";

                label4.Visible = true; button1.Visible = false; btn_sendData.Visible = false;
                chk_dars.Enabled = chk_student.Enabled = comboBox1.Enabled = textBox3.Enabled = textBox1.Enabled = textBox2.Enabled = false;
                button1.Refresh(); btn_sendData.Refresh(); label4.Visible = true; label4.Refresh();
                backgroundWorker2.RunWorkerAsync();
            }
        }
        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                string date_start = Internet_SM.Properties.Settings.Default.date_start;
                string date_end = Internet_SM.Properties.Settings.Default.date_end;
                string now = Internet_SM.Properties.Settings.Default.now;
                int pval = 0;
                int schoolCode = Int32.Parse(Internet_SM.Properties.Settings.Default.SchoolCode);
                schoolTablepassworkTableAdapter.update_state( now + " " + DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString(), schoolCode);
                //=================== DELETE ==================================
                //Delete Behavior Table
                behaviorTableTableAdapter1.DeleteBehavior(schoolCode, date_start, date_end);
                //Delete Lesson Table
                if (chk_dars.Checked)
                    lessonTableTableAdapter1.DeleteLesson(schoolCode);
                //Delete Score Table
                scoreTableTableAdapter1.DeleteScore(schoolCode, date_start, date_end);
                //Delete Student Table
                if (chk_student.Checked)
                    studentTableTableAdapter1.DeleteStudent(schoolCode);
                //delete hamahang
                hamahangTableAdapter.Deletehamahang(schoolCode);
                //================== UPLOAD NEW DATA ============================
                //Uploading New Data 
                pval = 0;
                //Behavior Table ////////////////////////////////////////////////////////////////////////////////////////
                for (int i = 0; i < bti.Rows.Count; i++)
                {
                    long stid = Convert.ToInt64(bti.Rows[i][1]);
                    string date = (bti.Rows[i][0] == null) ? " " : Convert.ToString(bti.Rows[i][0]);
                    string desc = (bti.Rows[i][2] == null) ? " " : Convert.ToString(bti.Rows[i][2]);
                    int typeb = (bti.Rows[i][3] == null) ? -1 : Convert.ToInt16(bti.Rows[i][3]);
                    behaviorTableTableAdapter1.InsertBehavior(schoolCode, stid, date, desc, typeb);
                    pval++; backgroundWorker2.ReportProgress(pval);
                }
                //Score Table ////////////////////////////////////////////////////////////////////////////////////////
                for (int i = 0; i < scti.Rows.Count; i++)
                {
                    long stid = Convert.ToInt64(scti.Rows[i][0]);
                    int testid = Convert.ToInt16(scti.Rows[i][1]);
                    int classid = Convert.ToInt16(scti.Rows[i][3]);
                    int lessonid = Convert.ToInt16(scti.Rows[i][4]);
                    string date = (scti.Rows[i][2] == null) ? " " : Convert.ToString(scti.Rows[i][2]);
                    decimal score = Convert.ToDecimal(scti.Rows[i][5]);
                    scoreTableTableAdapter1.InsertScore(schoolCode, stid, testid, classid, lessonid, date, score);
                    pval++; backgroundWorker2.ReportProgress(pval);
                }
                //Student Table////////////////////////////////////////////////////////////////////////////////////
                if (chk_student.Checked)
                    for (int i = 0; i < stti.Rows.Count; i++)
                    {
                        long stid = Convert.ToInt64(stti.Rows[i][0]);
                        string name = stti.Rows[i][1].ToString() + " " + stti.Rows[i][2].ToString();
                        int grade = Convert.ToInt16(stti.Rows[i][3]);
                        string classname = stti.Rows[i][4].ToString();
                        string majorname = stti.Rows[i][5].ToString();
                        string idcode = stti.Rows[i][6].ToString();
                        string fname = stti.Rows[i][7].ToString();
                        string address = stti.Rows[i][8].ToString();
                        string tell = stti.Rows[i][9].ToString();
                        long clid = Convert.ToInt32(stti.Rows[i][10]);
                        //string userName = stti.Rows[i][11].ToString();
                        studentTableTableAdapter1.InsertStudent(schoolCode, stid, name, grade, classname, majorname, idcode, fname, address, tell, clid);
                        pval++; backgroundWorker2.ReportProgress(pval);
                    }
                //Lesson Table//////////////////////////////////////////////////////////////////////////////////////
                if (chk_dars.Checked)
                    for (int i = 0; i < leti.Rows.Count; i++)
                    {
                        long lsid = Convert.ToInt64(leti.Rows[i]["idlesson"]);
                        //long tcid = (leti.Rows[i][1] == DBNull.Value) ? 0 : Convert.ToInt64(leti.Rows[i][1]);
                        int grade = Convert.ToInt16(leti.Rows[i]["grade"]);
                        int vahed = Convert.ToInt16(leti.Rows[i]["vahed"]);
                        string name = leti.Rows[i]["name"].ToString();
                        string mname = leti.Rows[i]["majorname"].ToString();
                        lessonTableTableAdapter1.InsertLesson(schoolCode, lsid, 0, grade, vahed, name, mname);
                        pval++; backgroundWorker2.ReportProgress(pval);
                    }
                //hamahang////////////////
                for (int i = 0; i < hamahang.Rows.Count; i++)
                {
                    string str = hamahang.Rows[i]["name"].ToString().Trim();
                    hamahangTableAdapter.Insert_hamahang(
                        long.Parse(hamahang.Rows[i]["id"].ToString()),
                        long.Parse(hamahang.Rows[i]["idtest"].ToString()),
                        str,
                       schoolCode);
                    pval++; backgroundWorker2.ReportProgress(pval);
                }
                // =============================
                System.Globalization.PersianCalendar pc = new System.Globalization.PersianCalendar();
                DateTime dt = DateTime.Now;
                string datetime1 = pc.GetYear(dt).ToString() + "/" + (pc.GetMonth(dt).ToString().Length == 1 ? "0" + pc.GetMonth(dt).ToString() : pc.GetMonth(dt).ToString()) + "/" + (pc.GetDayOfMonth(dt).ToString().Length == 1 ? "0" + pc.GetDayOfMonth(dt).ToString() : pc.GetDayOfMonth(dt).ToString()) + "  ساعت " + (DateTime.Now.Hour.ToString().Length == 1 ? "0" + DateTime.Now.Hour.ToString() : DateTime.Now.Hour.ToString()) + ":" + (DateTime.Now.Minute.ToString().Length == 1 ? "0" + DateTime.Now.Minute.ToString() : DateTime.Now.Minute.ToString());
                schoolTablepassworkTableAdapter.update_state_updatedate(datetime1, "done", schoolCode);
            }
            catch(Exception ex)
            {
                e.Result = "false";
            }
        }
        private void backgroundWorker2_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage < progressBar3.Maximum)
                progressBar3.Value = e.ProgressPercentage;
            else
                progressBar3.Value = progressBar3.Maximum;
        }
        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            button1.Visible = true; btn_sendData.Visible = true; chk_dars.Enabled = chk_student.Enabled = comboBox1.Enabled = textBox3.Enabled = textBox1.Enabled = textBox2.Enabled = true;
            button1.Refresh(); btn_sendData.Refresh(); label4.Visible = false; label4.Refresh();
            if (e.Result != null)
            {
                MessageBox.Show("متاسفانه اتصال با سرور قطع شده و اطلاعات ارسال نشده است" + "\r\n" + "لطفا مجددا سعی کنید"+"\r\n"+"تا زمانی که مجددا اقدام به ارسال اطلاعات ننماید خانواده ها قادر به دسترسی به صفحه کاربری خود نمی باشند"+"\r\n"+"شما می توانید با ارسال پشتیبان برنامه از طریق ایمیل نیز اقدام به ارسال اطلاعات نمایید. برای اطلاعات بیشتر با ما تماس بگیرید");
                label4.Visible = !true; button1.Visible = !false; btn_sendData.Visible = !false;
                chk_dars.Enabled = chk_student.Enabled = comboBox1.Enabled = textBox3.Enabled = textBox1.Enabled = textBox2.Enabled = !false;
                progressBar3.Value = 0;
                Close();
            }
            else
            {
                MessageBox.Show("اطلاعات با موفقیت انتقال یافت");
            }
        }
        private void frm_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (textBox3.Enabled == false)
            {
                e.Cancel = true;
                MessageBox.Show("تا پایان ارسال منتظر بمانید");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
