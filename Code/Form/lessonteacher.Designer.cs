namespace Student
{
    partial class frm_lessonteacher
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_lname = new System.Windows.Forms.Label();
            this.txt_lesson_f = new System.Windows.Forms.TextBox();
            this.grb_input = new System.Windows.Forms.GroupBox();
            this.cmb_lesson = new System.Windows.Forms.ComboBox();
            this.lessonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_lessonteacher = new Student.DataSet.ds_lessonteacher();
            this.cmb_class = new System.Windows.Forms.ComboBox();
            this.classBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_name = new System.Windows.Forms.Label();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.txt_class_f = new System.Windows.Forms.TextBox();
            this.prba = new System.Windows.Forms.ProgressBar();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlessonteacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_first = new System.Windows.Forms.Button();
            this.pnl_nav = new System.Windows.Forms.Panel();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_last = new System.Windows.Forms.Button();
            this.btn_prev = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.lbl_prba1 = new System.Windows.Forms.Label();
            this.pib_prba = new System.Windows.Forms.PictureBox();
            this.pnl_nav_datagride = new System.Windows.Forms.Panel();
            this.pnl_prba = new System.Windows.Forms.Panel();
            this.lbl_prba2 = new System.Windows.Forms.Label();
            this.flp_f = new System.Windows.Forms.FlowLayoutPanel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker_s = new System.ComponentModel.BackgroundWorker();
            this.grb_info = new System.Windows.Forms.GroupBox();
            this.lbl_tell_info = new System.Windows.Forms.Label();
            this.lbl_name_info = new System.Windows.Forms.Label();
            this.lbl_lname_info = new System.Windows.Forms.Label();
            this.lbl_code_info = new System.Windows.Forms.Label();
            this.dt_lessonteacherTableAdapter = new Student.DataSet.ds_lessonteacherTableAdapters.dt_lessonteacherTableAdapter();
            this.classTableAdapter = new Student.DataSet.ds_lessonteacherTableAdapters.classTableAdapter();
            this.lessonTableAdapter = new Student.DataSet.ds_lessonteacherTableAdapters.lessonTableAdapter();
            this.grb_input.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lessonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_lessonteacher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtlessonteacherBindingSource)).BeginInit();
            this.pnl_nav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pib_prba)).BeginInit();
            this.pnl_nav_datagride.SuspendLayout();
            this.pnl_prba.SuspendLayout();
            this.flp_f.SuspendLayout();
            this.grb_info.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_lname
            // 
            this.lbl_lname.AutoSize = true;
            this.lbl_lname.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_lname.Location = new System.Drawing.Point(327, 54);
            this.lbl_lname.Name = "lbl_lname";
            this.lbl_lname.Size = new System.Drawing.Size(32, 14);
            this.lbl_lname.TabIndex = 1;
            this.lbl_lname.Text = "درس";
            // 
            // txt_lesson_f
            // 
            this.txt_lesson_f.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_lesson_f.Location = new System.Drawing.Point(282, 0);
            this.txt_lesson_f.Margin = new System.Windows.Forms.Padding(0);
            this.txt_lesson_f.Name = "txt_lesson_f";
            this.txt_lesson_f.Size = new System.Drawing.Size(50, 22);
            this.txt_lesson_f.TabIndex = 1;
            this.txt_lesson_f.Enter += new System.EventHandler(this.entercolor);
            this.txt_lesson_f.Leave += new System.EventHandler(this.leavecolor);
            this.txt_lesson_f.TextChanged += new System.EventHandler(this.actfilter);
            this.txt_lesson_f.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextcontrol);
            // 
            // grb_input
            // 
            this.grb_input.Controls.Add(this.cmb_lesson);
            this.grb_input.Controls.Add(this.cmb_class);
            this.grb_input.Controls.Add(this.lbl_lname);
            this.grb_input.Controls.Add(this.lbl_name);
            this.grb_input.Location = new System.Drawing.Point(8, 332);
            this.grb_input.Name = "grb_input";
            this.grb_input.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grb_input.Size = new System.Drawing.Size(387, 87);
            this.grb_input.TabIndex = 5;
            this.grb_input.TabStop = false;
            this.grb_input.Text = "اطلاعات";
            // 
            // cmb_lesson
            // 
            this.cmb_lesson.DataSource = this.lessonBindingSource;
            this.cmb_lesson.DisplayMember = "name";
            this.cmb_lesson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_lesson.FormattingEnabled = true;
            this.cmb_lesson.Location = new System.Drawing.Point(189, 50);
            this.cmb_lesson.Name = "cmb_lesson";
            this.cmb_lesson.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmb_lesson.Size = new System.Drawing.Size(121, 22);
            this.cmb_lesson.TabIndex = 2;
            this.cmb_lesson.ValueMember = "idlesson";
            this.cmb_lesson.Leave += new System.EventHandler(this.leavecolor);
            this.cmb_lesson.Enter += new System.EventHandler(this.entercolor);
            this.cmb_lesson.SelectedIndexChanged += new System.EventHandler(this.inputtxtchange);
            this.cmb_lesson.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextcontrol);
            // 
            // lessonBindingSource
            // 
            this.lessonBindingSource.DataMember = "lesson";
            this.lessonBindingSource.DataSource = this.ds_lessonteacher;
            // 
            // ds_lessonteacher
            // 
            this.ds_lessonteacher.DataSetName = "ds_lessonteacher";
            this.ds_lessonteacher.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmb_class
            // 
            this.cmb_class.DataSource = this.classBindingSource;
            this.cmb_class.DisplayMember = "name";
            this.cmb_class.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_class.FormattingEnabled = true;
            this.cmb_class.Location = new System.Drawing.Point(189, 22);
            this.cmb_class.Name = "cmb_class";
            this.cmb_class.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmb_class.Size = new System.Drawing.Size(121, 22);
            this.cmb_class.TabIndex = 2;
            this.cmb_class.ValueMember = "idclass";
            this.cmb_class.Leave += new System.EventHandler(this.leavecolor);
            this.cmb_class.Enter += new System.EventHandler(this.entercolor);
            this.cmb_class.SelectedIndexChanged += new System.EventHandler(this.inputtxtchange);
            this.cmb_class.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextcontrol);
            // 
            // classBindingSource
            // 
            this.classBindingSource.DataMember = "class";
            this.classBindingSource.DataSource = this.ds_lessonteacher;
            this.classBindingSource.PositionChanged += new System.EventHandler(this.classBindingSource_PositionChanged);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_name.Location = new System.Drawing.Point(327, 26);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(37, 14);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "کلاس";
            // 
            // btn_new
            // 
            this.btn_new.Enabled = false;
            this.btn_new.Image = global::Student.Properties.Resources.new_bookmark;
            this.btn_new.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_new.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_new.Location = new System.Drawing.Point(273, 428);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(87, 40);
            this.btn_new.TabIndex = 6;
            this.btn_new.Text = "جدید";
            this.btn_new.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_save
            // 
            this.btn_save.Enabled = false;
            this.btn_save.Image = global::Student.Properties.Resources.small_save;
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_save.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_save.Location = new System.Drawing.Point(158, 428);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(87, 40);
            this.btn_save.TabIndex = 7;
            this.btn_save.Text = "ذخیره";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Image = global::Student.Properties.Resources.ExitH51;
            this.btn_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_exit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_exit.Location = new System.Drawing.Point(43, 428);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(87, 40);
            this.btn_exit.TabIndex = 8;
            this.btn_exit.Text = "بازگشت";
            this.btn_exit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // txt_class_f
            // 
            this.txt_class_f.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_class_f.Location = new System.Drawing.Point(333, 0);
            this.txt_class_f.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.txt_class_f.Name = "txt_class_f";
            this.txt_class_f.Size = new System.Drawing.Size(45, 22);
            this.txt_class_f.TabIndex = 0;
            this.txt_class_f.Enter += new System.EventHandler(this.entercolor);
            this.txt_class_f.Leave += new System.EventHandler(this.leavecolor);
            this.txt_class_f.TextChanged += new System.EventHandler(this.actfilter);
            this.txt_class_f.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextcontrol);
            // 
            // prba
            // 
            this.prba.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.prba.Location = new System.Drawing.Point(16, 11);
            this.prba.Name = "prba";
            this.prba.Size = new System.Drawing.Size(313, 26);
            this.prba.TabIndex = 5;
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AllowUserToResizeRows = false;
            this.dataGrid.AutoGenerateColumns = false;
            this.dataGrid.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGrid.DataSource = this.dtlessonteacherBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid.Location = new System.Drawing.Point(2, 3);
            this.dataGrid.MultiSelect = false;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGrid.RowHeadersVisible = false;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(378, 177);
            this.dataGrid.StandardTab = true;
            this.dataGrid.TabIndex = 0;
            this.dataGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGrid_KeyDown);
            this.dataGrid.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_RowEnter);
            this.dataGrid.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGrid_ColumnWidthChanged);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "name";
            this.Column1.HeaderText = "نام کلاس";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "namelesson";
            this.Column2.HeaderText = "نام درس";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // btn_first
            // 
            this.btn_first.Image = global::Student.Properties.Resources.DataContainer_MoveFirsHS;
            this.btn_first.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_first.Location = new System.Drawing.Point(3, 1);
            this.btn_first.Name = "btn_first";
            this.btn_first.Size = new System.Drawing.Size(33, 30);
            this.btn_first.TabIndex = 4;
            this.btn_first.UseVisualStyleBackColor = true;
            this.btn_first.Click += new System.EventHandler(this.btn_first_Click);
            // 
            // pnl_nav
            // 
            this.pnl_nav.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnl_nav.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_nav.Controls.Add(this.btn_first);
            this.pnl_nav.Controls.Add(this.btn_del);
            this.pnl_nav.Controls.Add(this.btn_last);
            this.pnl_nav.Controls.Add(this.btn_prev);
            this.pnl_nav.Controls.Add(this.btn_next);
            this.pnl_nav.Location = new System.Drawing.Point(2, 204);
            this.pnl_nav.Name = "pnl_nav";
            this.pnl_nav.Size = new System.Drawing.Size(378, 34);
            this.pnl_nav.TabIndex = 2;
            // 
            // btn_del
            // 
            this.btn_del.Image = global::Student.Properties.Resources.DeleteHS;
            this.btn_del.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_del.Location = new System.Drawing.Point(173, 1);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(33, 30);
            this.btn_del.TabIndex = 2;
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_last
            // 
            this.btn_last.Image = global::Student.Properties.Resources.DataContainer_MoveLastHS;
            this.btn_last.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_last.Location = new System.Drawing.Point(342, 1);
            this.btn_last.Name = "btn_last";
            this.btn_last.Size = new System.Drawing.Size(33, 30);
            this.btn_last.TabIndex = 0;
            this.btn_last.UseVisualStyleBackColor = true;
            this.btn_last.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_prev
            // 
            this.btn_prev.Image = global::Student.Properties.Resources.DataContainer_MovePreviousHS;
            this.btn_prev.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_prev.Location = new System.Drawing.Point(43, 1);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(33, 30);
            this.btn_prev.TabIndex = 3;
            this.btn_prev.UseVisualStyleBackColor = true;
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // btn_next
            // 
            this.btn_next.Image = global::Student.Properties.Resources.DataContainer_MoveNextHS;
            this.btn_next.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_next.Location = new System.Drawing.Point(303, 1);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(33, 30);
            this.btn_next.TabIndex = 1;
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // lbl_prba1
            // 
            this.lbl_prba1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_prba1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_prba1.Location = new System.Drawing.Point(265, 45);
            this.lbl_prba1.Name = "lbl_prba1";
            this.lbl_prba1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_prba1.Size = new System.Drawing.Size(65, 15);
            this.lbl_prba1.TabIndex = 6;
            this.lbl_prba1.Text = "0%";
            // 
            // pib_prba
            // 
            this.pib_prba.Image = global::Student.Properties.Resources.fSEARCH_00;
            this.pib_prba.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pib_prba.Location = new System.Drawing.Point(258, 45);
            this.pib_prba.Name = "pib_prba";
            this.pib_prba.Size = new System.Drawing.Size(16, 16);
            this.pib_prba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pib_prba.TabIndex = 7;
            this.pib_prba.TabStop = false;
            // 
            // pnl_nav_datagride
            // 
            this.pnl_nav_datagride.Controls.Add(this.pnl_prba);
            this.pnl_nav_datagride.Controls.Add(this.pnl_nav);
            this.pnl_nav_datagride.Controls.Add(this.dataGrid);
            this.pnl_nav_datagride.Controls.Add(this.flp_f);
            this.pnl_nav_datagride.Location = new System.Drawing.Point(12, 91);
            this.pnl_nav_datagride.Name = "pnl_nav_datagride";
            this.pnl_nav_datagride.Size = new System.Drawing.Size(383, 240);
            this.pnl_nav_datagride.TabIndex = 9;
            // 
            // pnl_prba
            // 
            this.pnl_prba.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnl_prba.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnl_prba.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_prba.Controls.Add(this.pib_prba);
            this.pnl_prba.Controls.Add(this.lbl_prba2);
            this.pnl_prba.Controls.Add(this.lbl_prba1);
            this.pnl_prba.Controls.Add(this.prba);
            this.pnl_prba.Location = new System.Drawing.Point(18, 55);
            this.pnl_prba.Name = "pnl_prba";
            this.pnl_prba.Size = new System.Drawing.Size(347, 72);
            this.pnl_prba.TabIndex = 3;
            // 
            // lbl_prba2
            // 
            this.lbl_prba2.AutoSize = true;
            this.lbl_prba2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_prba2.Location = new System.Drawing.Point(17, 45);
            this.lbl_prba2.Name = "lbl_prba2";
            this.lbl_prba2.Size = new System.Drawing.Size(91, 14);
            this.lbl_prba2.TabIndex = 6;
            this.lbl_prba2.Text = "لطفا صبر کنید ...";
            // 
            // flp_f
            // 
            this.flp_f.Controls.Add(this.txt_class_f);
            this.flp_f.Controls.Add(this.txt_lesson_f);
            this.flp_f.Location = new System.Drawing.Point(2, 181);
            this.flp_f.Name = "flp_f";
            this.flp_f.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flp_f.Size = new System.Drawing.Size(378, 23);
            this.flp_f.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // backgroundWorker_s
            // 
            this.backgroundWorker_s.WorkerSupportsCancellation = true;
            this.backgroundWorker_s.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_s_DoWork);
            this.backgroundWorker_s.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_s_RunWorkerCompleted);
            // 
            // grb_info
            // 
            this.grb_info.Controls.Add(this.lbl_tell_info);
            this.grb_info.Controls.Add(this.lbl_name_info);
            this.grb_info.Controls.Add(this.lbl_lname_info);
            this.grb_info.Controls.Add(this.lbl_code_info);
            this.grb_info.Location = new System.Drawing.Point(12, 7);
            this.grb_info.Name = "grb_info";
            this.grb_info.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grb_info.Size = new System.Drawing.Size(383, 78);
            this.grb_info.TabIndex = 10;
            this.grb_info.TabStop = false;
            this.grb_info.Text = "اطلاعات دبیر ";
            // 
            // lbl_tell_info
            // 
            this.lbl_tell_info.Location = new System.Drawing.Point(11, 52);
            this.lbl_tell_info.Name = "lbl_tell_info";
            this.lbl_tell_info.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_tell_info.Size = new System.Drawing.Size(121, 23);
            this.lbl_tell_info.TabIndex = 3;
            this.lbl_tell_info.Text = "تلفن:";
            // 
            // lbl_name_info
            // 
            this.lbl_name_info.Location = new System.Drawing.Point(11, 24);
            this.lbl_name_info.Name = "lbl_name_info";
            this.lbl_name_info.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_name_info.Size = new System.Drawing.Size(113, 23);
            this.lbl_name_info.TabIndex = 4;
            this.lbl_name_info.Text = "نام:";
            // 
            // lbl_lname_info
            // 
            this.lbl_lname_info.Location = new System.Drawing.Point(197, 52);
            this.lbl_lname_info.Name = "lbl_lname_info";
            this.lbl_lname_info.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_lname_info.Size = new System.Drawing.Size(164, 23);
            this.lbl_lname_info.TabIndex = 1;
            this.lbl_lname_info.Text = "نام خانوادگی:";
            // 
            // lbl_code_info
            // 
            this.lbl_code_info.Location = new System.Drawing.Point(197, 24);
            this.lbl_code_info.Name = "lbl_code_info";
            this.lbl_code_info.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_code_info.Size = new System.Drawing.Size(156, 23);
            this.lbl_code_info.TabIndex = 2;
            this.lbl_code_info.Text = "کد پرسنلی:";
            // 
            // dt_lessonteacherTableAdapter
            // 
            this.dt_lessonteacherTableAdapter.ClearBeforeFill = true;
            // 
            // classTableAdapter
            // 
            this.classTableAdapter.ClearBeforeFill = true;
            // 
            // lessonTableAdapter
            // 
            this.lessonTableAdapter.ClearBeforeFill = true;
            // 
            // frm_lessonteacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(406, 479);
            this.Controls.Add(this.grb_info);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.pnl_nav_datagride);
            this.Controls.Add(this.grb_input);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_lessonteacher";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_lessonteacher_KeyDown);
            this.Load += new System.EventHandler(this.frm_lessonteacher_Load);
            this.grb_input.ResumeLayout(false);
            this.grb_input.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lessonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_lessonteacher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtlessonteacherBindingSource)).EndInit();
            this.pnl_nav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pib_prba)).EndInit();
            this.pnl_nav_datagride.ResumeLayout(false);
            this.pnl_prba.ResumeLayout(false);
            this.pnl_prba.PerformLayout();
            this.flp_f.ResumeLayout(false);
            this.flp_f.PerformLayout();
            this.grb_info.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_lname;
        private System.Windows.Forms.TextBox txt_lesson_f;
        private System.Windows.Forms.GroupBox grb_input;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.TextBox txt_class_f;
        private System.Windows.Forms.ProgressBar prba;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button btn_first;
        private System.Windows.Forms.Panel pnl_nav;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_last;
        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Label lbl_prba1;
        private System.Windows.Forms.PictureBox pib_prba;
        private System.Windows.Forms.Panel pnl_nav_datagride;
        private System.Windows.Forms.Panel pnl_prba;
        private System.Windows.Forms.Label lbl_prba2;
        private System.Windows.Forms.FlowLayoutPanel flp_f;
        private System.Windows.Forms.ComboBox cmb_lesson;
        private System.Windows.Forms.ComboBox cmb_class;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.ComponentModel.BackgroundWorker backgroundWorker_s;
        private Student.DataSet.ds_lessonteacher ds_lessonteacher;
        //private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox grb_info;
        private System.Windows.Forms.Label lbl_tell_info;
        private System.Windows.Forms.Label lbl_name_info;
        private System.Windows.Forms.Label lbl_lname_info;
        private System.Windows.Forms.Label lbl_code_info;
        private System.Windows.Forms.BindingSource dtlessonteacherBindingSource;
        private Student.DataSet.ds_lessonteacherTableAdapters.dt_lessonteacherTableAdapter dt_lessonteacherTableAdapter;
        private System.Windows.Forms.BindingSource classBindingSource;
        private Student.DataSet.ds_lessonteacherTableAdapters.classTableAdapter classTableAdapter;
        private System.Windows.Forms.BindingSource lessonBindingSource;
        private Student.DataSet.ds_lessonteacherTableAdapters.lessonTableAdapter lessonTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}

