namespace Internet_SM
{
    partial class frm_main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.btn_sendData = new System.Windows.Forms.Button();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.chk_student = new System.Windows.Forms.CheckBox();
            this.chk_dars = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbDataSet1 = new Internet_SM.DBDataSet();
            this.studentToInternetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.behavior_To_InternetTableAdapter1 = new Internet_SM.DBDataSetTableAdapters.behavior_To_InternetTableAdapter();
            this.lesson_To_InternetTableAdapter1 = new Internet_SM.DBDataSetTableAdapters.lesson_To_InternetTableAdapter();
            this.score_To_InternetTableAdapter1 = new Internet_SM.DBDataSetTableAdapters.Score_To_InternetTableAdapter();
            this.u = new Internet_SM.DBDataSetTableAdapters.student_To_InternetTableAdapter();
            this.studentTableAdapter1 = new Internet_SM.DBDataSetTableAdapters.studentTableAdapter();
            this.hamahangtointernetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hamahang_to_internetTableAdapter = new Internet_SM.DBDataSetTableAdapters.hamahang_to_internetTableAdapter();
            this.behaviorTableTableAdapter1 = new Internet_SM.WebDataSetTableAdapters.BehaviorTableTableAdapter();
            this.lessonTableTableAdapter1 = new Internet_SM.WebDataSetTableAdapters.LessonTableTableAdapter();
            this.scoreTableTableAdapter1 = new Internet_SM.WebDataSetTableAdapters.ScoreTableTableAdapter();
            this.studentTableTableAdapter1 = new Internet_SM.WebDataSetTableAdapters.StudentTableTableAdapter();
            this.userPassTableTableAdapter1 = new Internet_SM.WebDataSetTableAdapters.userPassTableTableAdapter();
            this.webDataSet = new Internet_SM.WebDataSet();
            this.schoolTablepassworkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolTablepassworkTableAdapter = new Internet_SM.WebDataSetTableAdapters.SchoolTablepassworkTableAdapter();
            this.tempBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tempTableAdapter = new Internet_SM.WebDataSetTableAdapters.tempTableAdapter();
            this.hamahangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hamahangTableAdapter = new Internet_SM.WebDataSetTableAdapters.hamahangTableAdapter();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentToInternetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hamahangtointernetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolTablepassworkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hamahangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(-710, 76);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(699, 23);
            this.progressBar2.TabIndex = 2;
            this.progressBar2.Visible = false;
            // 
            // btn_sendData
            // 
            this.btn_sendData.Location = new System.Drawing.Point(655, 88);
            this.btn_sendData.Name = "btn_sendData";
            this.btn_sendData.Size = new System.Drawing.Size(111, 43);
            this.btn_sendData.TabIndex = 3;
            this.btn_sendData.Text = "ارسال اطلاعات";
            this.btn_sendData.UseVisualStyleBackColor = true;
            this.btn_sendData.Click += new System.EventHandler(this.btn_sendData_Click);
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(8, 21);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(731, 23);
            this.progressBar3.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(-733, 141);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(722, 50);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "تجزیه و تحلیل داده ";
            this.groupBox2.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.progressBar3);
            this.groupBox3.Location = new System.Drawing.Point(23, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(745, 50);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "به روز رسانی اطلاعات";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 14);
            this.label2.TabIndex = 10;
            this.label2.Text = "کد اتصال";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(459, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 43);
            this.button1.TabIndex = 14;
            this.button1.Text = "چاپ نام کاربری/کلمه عبور";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.textBox3);
            this.groupBox5.Controls.Add(this.groupBox3);
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.btn_sendData);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.textBox2);
            this.groupBox5.Controls.Add(this.textBox1);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Location = new System.Drawing.Point(18, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(791, 163);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 14);
            this.label1.TabIndex = 17;
            this.label1.Text = "آدرس سایت";
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Internet_SM.Properties.Settings.Default, "url", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox3.Location = new System.Drawing.Point(22, 135);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 16;
            this.textBox3.Text = global::Internet_SM.Properties.Settings.Default.url;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 14);
            this.label3.TabIndex = 10;
            this.label3.Text = "رمز اتصال";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Internet_SM.Properties.Settings.Default, "SchoolPass", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox2.Location = new System.Drawing.Point(22, 107);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 12;
            this.textBox2.TabStop = false;
            this.textBox2.Text = global::Internet_SM.Properties.Settings.Default.SchoolPass;
            this.textBox2.Enter += new System.EventHandler(this.textBox2_Enter);
            this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Internet_SM.Properties.Settings.Default, "SchoolCode", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox1.Location = new System.Drawing.Point(22, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 12;
            this.textBox1.TabStop = false;
            this.textBox1.Text = global::Internet_SM.Properties.Settings.Default.SchoolCode;
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(371, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(301, 14);
            this.label4.TabIndex = 15;
            this.label4.Text = "لطفا صبر کنید و اتصال خود به اینترنت را حفظ نمایید";
            this.label4.Visible = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(633, 184);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "clear all data on server";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.WorkerReportsProgress = true;
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            this.backgroundWorker2.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker2_ProgressChanged);
            this.backgroundWorker2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker2_RunWorkerCompleted);
            // 
            // chk_student
            // 
            this.chk_student.AutoSize = true;
            this.chk_student.Checked = true;
            this.chk_student.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_student.Location = new System.Drawing.Point(18, 206);
            this.chk_student.Name = "chk_student";
            this.chk_student.Size = new System.Drawing.Size(458, 18);
            this.chk_student.TabIndex = 17;
            this.chk_student.Text = "ارسال مجدد مشحصات کامل دانش آموزان به همراه کلاسی که در آن ثبت نام شده اند";
            this.chk_student.UseVisualStyleBackColor = true;
            // 
            // chk_dars
            // 
            this.chk_dars.AutoSize = true;
            this.chk_dars.Checked = true;
            this.chk_dars.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_dars.Location = new System.Drawing.Point(18, 229);
            this.chk_dars.Name = "chk_dars";
            this.chk_dars.Size = new System.Drawing.Size(242, 18);
            this.chk_dars.TabIndex = 17;
            this.chk_dars.Text = "ارسال مجدد مشخصات دروس ( واحد و ...)";
            this.chk_dars.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "سال جاری",
            "امروز",
            "سه روز گذشته",
            "هفت روز گذشته",
            "پانزده روز گذشته",
            "سی روز گذشته",
            "شصت روز گذشته"});
            this.comboBox1.Location = new System.Drawing.Point(175, 181);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(158, 22);
            this.comboBox1.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 14);
            this.label5.TabIndex = 19;
            this.label5.Text = "ارسال نمرات و موارد انضباطی";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(773, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 14);
            this.label6.TabIndex = 20;
            this.label6.Text = "label6";
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "student";
            this.studentBindingSource.DataSource = this.dbDataSet1;
            // 
            // dbDataSet1
            // 
            this.dbDataSet1.DataSetName = "DBDataSet";
            this.dbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentToInternetBindingSource
            // 
            this.studentToInternetBindingSource.DataMember = "student_To_Internet";
            this.studentToInternetBindingSource.DataSource = this.dbDataSet1;
            // 
            // behavior_To_InternetTableAdapter1
            // 
            this.behavior_To_InternetTableAdapter1.ClearBeforeFill = true;
            // 
            // lesson_To_InternetTableAdapter1
            // 
            this.lesson_To_InternetTableAdapter1.ClearBeforeFill = true;
            // 
            // score_To_InternetTableAdapter1
            // 
            this.score_To_InternetTableAdapter1.ClearBeforeFill = true;
            // 
            // u
            // 
            this.u.ClearBeforeFill = true;
            // 
            // studentTableAdapter1
            // 
            this.studentTableAdapter1.ClearBeforeFill = true;
            // 
            // hamahangtointernetBindingSource
            // 
            this.hamahangtointernetBindingSource.DataMember = "hamahang_to_internet";
            this.hamahangtointernetBindingSource.DataSource = this.dbDataSet1;
            // 
            // hamahang_to_internetTableAdapter
            // 
            this.hamahang_to_internetTableAdapter.ClearBeforeFill = true;
            // 
            // behaviorTableTableAdapter1
            // 
            this.behaviorTableTableAdapter1.ClearBeforeFill = true;
            // 
            // lessonTableTableAdapter1
            // 
            this.lessonTableTableAdapter1.ClearBeforeFill = true;
            // 
            // scoreTableTableAdapter1
            // 
            this.scoreTableTableAdapter1.ClearBeforeFill = true;
            // 
            // studentTableTableAdapter1
            // 
            this.studentTableTableAdapter1.ClearBeforeFill = true;
            // 
            // userPassTableTableAdapter1
            // 
            this.userPassTableTableAdapter1.ClearBeforeFill = true;
            // 
            // webDataSet
            // 
            this.webDataSet.DataSetName = "WebDataSet";
            this.webDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // schoolTablepassworkBindingSource
            // 
            this.schoolTablepassworkBindingSource.DataMember = "SchoolTablepasswork";
            this.schoolTablepassworkBindingSource.DataSource = this.webDataSet;
            // 
            // schoolTablepassworkTableAdapter
            // 
            this.schoolTablepassworkTableAdapter.ClearBeforeFill = true;
            // 
            // tempBindingSource
            // 
            this.tempBindingSource.DataMember = "temp";
            this.tempBindingSource.DataSource = this.webDataSet;
            // 
            // tempTableAdapter
            // 
            this.tempTableAdapter.ClearBeforeFill = true;
            // 
            // hamahangBindingSource
            // 
            this.hamahangBindingSource.DataMember = "hamahang";
            this.hamahangBindingSource.DataSource = this.webDataSet;
            // 
            // hamahangTableAdapter
            // 
            this.hamahangTableAdapter.ClearBeforeFill = true;
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(824, 263);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.chk_dars);
            this.Controls.Add(this.chk_student);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox5);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_main";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "برنامه مدیریت مدرسه - ارسال اطلاعات ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_main_FormClosing);
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentToInternetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hamahangtointernetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolTablepassworkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hamahangBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Button btn_sendData;
        private Internet_SM.DBDataSetTableAdapters.behavior_To_InternetTableAdapter behavior_To_InternetTableAdapter1;
        private Internet_SM.DBDataSetTableAdapters.lesson_To_InternetTableAdapter lesson_To_InternetTableAdapter1;
        private Internet_SM.DBDataSetTableAdapters.Score_To_InternetTableAdapter score_To_InternetTableAdapter1;
        private Internet_SM.DBDataSetTableAdapters.student_To_InternetTableAdapter u;
        private DBDataSet dbDataSet1;
        private Internet_SM.WebDataSetTableAdapters.BehaviorTableTableAdapter behaviorTableTableAdapter1;
        private Internet_SM.WebDataSetTableAdapters.LessonTableTableAdapter lessonTableTableAdapter1;
        private Internet_SM.WebDataSetTableAdapters.ScoreTableTableAdapter scoreTableTableAdapter1;
        private Internet_SM.WebDataSetTableAdapters.StudentTableTableAdapter studentTableTableAdapter1;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource studentToInternetBindingSource;
        private Internet_SM.DBDataSetTableAdapters.studentTableAdapter studentTableAdapter1;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.GroupBox groupBox5;
        private Internet_SM.WebDataSetTableAdapters.userPassTableTableAdapter userPassTableTableAdapter1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private WebDataSet webDataSet;
        private System.Windows.Forms.BindingSource schoolTablepassworkBindingSource;
        private Internet_SM.WebDataSetTableAdapters.SchoolTablepassworkTableAdapter schoolTablepassworkTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource tempBindingSource;
        private Internet_SM.WebDataSetTableAdapters.tempTableAdapter tempTableAdapter;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.BindingSource hamahangBindingSource;
        private Internet_SM.WebDataSetTableAdapters.hamahangTableAdapter hamahangTableAdapter;
        private System.Windows.Forms.BindingSource hamahangtointernetBindingSource;
        private Internet_SM.DBDataSetTableAdapters.hamahang_to_internetTableAdapter hamahang_to_internetTableAdapter;
        private System.Windows.Forms.CheckBox chk_student;
        private System.Windows.Forms.CheckBox chk_dars;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

