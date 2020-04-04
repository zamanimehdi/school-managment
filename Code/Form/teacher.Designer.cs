namespace Student
{
    partial class frm_teacher
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_teacher));
            this.pnl_datagride = new System.Windows.Forms.Panel();
            this.pnl_prba = new System.Windows.Forms.Panel();
            this.pib_prba = new System.Windows.Forms.PictureBox();
            this.lbl_prba2 = new System.Windows.Forms.Label();
            this.lbl_prba1 = new System.Windows.Forms.Label();
            this.prba = new System.Windows.Forms.ProgressBar();
            this.pnl_nav = new System.Windows.Forms.Panel();
            this.btn_last = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_prev = new System.Windows.Forms.Button();
            this.btn_first = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flp_f = new System.Windows.Forms.FlowLayoutPanel();
            this.txt_idcode_f = new System.Windows.Forms.TextBox();
            this.txt_lname_f = new System.Windows.Forms.TextBox();
            this.txt_name_f = new System.Windows.Forms.TextBox();
            this.txt_tell_f = new System.Windows.Forms.TextBox();
            this.ds_teacher = new Student.DataSet.ds_teacher();
            this.grb_input = new System.Windows.Forms.GroupBox();
            this.lbl_tell = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_lname = new System.Windows.Forms.Label();
            this.lbl_idcode = new System.Windows.Forms.Label();
            this.txt_tell = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_lname = new System.Windows.Forms.TextBox();
            this.txt_idcode = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.teacherTableAdapter = new Student.DataSet.ds_teacherTableAdapters.teacherTableAdapter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker_s = new System.ComponentModel.BackgroundWorker();
            this.pnl_datagride.SuspendLayout();
            this.pnl_prba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pib_prba)).BeginInit();
            this.pnl_nav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
            this.flp_f.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds_teacher)).BeginInit();
            this.grb_input.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_datagride
            // 
            this.pnl_datagride.Controls.Add(this.pnl_prba);
            this.pnl_datagride.Controls.Add(this.pnl_nav);
            this.pnl_datagride.Controls.Add(this.dataGrid);
            this.pnl_datagride.Controls.Add(this.flp_f);
            this.pnl_datagride.Location = new System.Drawing.Point(12, 12);
            this.pnl_datagride.Name = "pnl_datagride";
            this.pnl_datagride.Size = new System.Drawing.Size(486, 429);
            this.pnl_datagride.TabIndex = 4;
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
            this.pnl_prba.Location = new System.Drawing.Point(103, 148);
            this.pnl_prba.Name = "pnl_prba";
            this.pnl_prba.Size = new System.Drawing.Size(298, 67);
            this.pnl_prba.TabIndex = 4;
            // 
            // pib_prba
            // 
            this.pib_prba.Image = global::Student.Properties.Resources.fSEARCH_00;
            this.pib_prba.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pib_prba.Location = new System.Drawing.Point(221, 42);
            this.pib_prba.Name = "pib_prba";
            this.pib_prba.Size = new System.Drawing.Size(16, 16);
            this.pib_prba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pib_prba.TabIndex = 7;
            this.pib_prba.TabStop = false;
            // 
            // lbl_prba2
            // 
            this.lbl_prba2.AutoSize = true;
            this.lbl_prba2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_prba2.Location = new System.Drawing.Point(15, 42);
            this.lbl_prba2.Name = "lbl_prba2";
            this.lbl_prba2.Size = new System.Drawing.Size(91, 14);
            this.lbl_prba2.TabIndex = 6;
            this.lbl_prba2.Text = "لطفا صبر کنید ...";
            // 
            // lbl_prba1
            // 
            this.lbl_prba1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_prba1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_prba1.Location = new System.Drawing.Point(227, 42);
            this.lbl_prba1.Name = "lbl_prba1";
            this.lbl_prba1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_prba1.Size = new System.Drawing.Size(56, 14);
            this.lbl_prba1.TabIndex = 6;
            this.lbl_prba1.Text = "0%";
            // 
            // prba
            // 
            this.prba.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.prba.Location = new System.Drawing.Point(14, 10);
            this.prba.Name = "prba";
            this.prba.Size = new System.Drawing.Size(268, 24);
            this.prba.TabIndex = 5;
            // 
            // pnl_nav
            // 
            this.pnl_nav.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnl_nav.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_nav.Controls.Add(this.btn_last);
            this.pnl_nav.Controls.Add(this.btn_next);
            this.pnl_nav.Controls.Add(this.btn_del);
            this.pnl_nav.Controls.Add(this.btn_prev);
            this.pnl_nav.Controls.Add(this.btn_first);
            this.pnl_nav.Location = new System.Drawing.Point(3, 397);
            this.pnl_nav.Name = "pnl_nav";
            this.pnl_nav.Size = new System.Drawing.Size(480, 32);
            this.pnl_nav.TabIndex = 2;
            // 
            // btn_last
            // 
            this.btn_last.Image = global::Student.Properties.Resources.DataContainer_MoveLastHS;
            this.btn_last.Location = new System.Drawing.Point(444, 1);
            this.btn_last.Name = "btn_last";
            this.btn_last.Size = new System.Drawing.Size(28, 28);
            this.btn_last.TabIndex = 0;
            this.btn_last.UseVisualStyleBackColor = true;
            this.btn_last.Click += new System.EventHandler(this.btn_last_Click);
            // 
            // btn_next
            // 
            this.btn_next.Image = global::Student.Properties.Resources.DataContainer_MoveNextHS;
            this.btn_next.Location = new System.Drawing.Point(409, 1);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(28, 28);
            this.btn_next.TabIndex = 1;
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_del
            // 
            this.btn_del.Image = global::Student.Properties.Resources.DeleteHS;
            this.btn_del.Location = new System.Drawing.Point(177, 1);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(28, 28);
            this.btn_del.TabIndex = 2;
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_prev
            // 
            this.btn_prev.Image = global::Student.Properties.Resources.DataContainer_MovePreviousHS;
            this.btn_prev.Location = new System.Drawing.Point(36, 1);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(28, 28);
            this.btn_prev.TabIndex = 3;
            this.btn_prev.UseVisualStyleBackColor = true;
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // btn_first
            // 
            this.btn_first.Image = global::Student.Properties.Resources.DataContainer_MoveFirsHS;
            this.btn_first.Location = new System.Drawing.Point(3, 1);
            this.btn_first.Name = "btn_first";
            this.btn_first.Size = new System.Drawing.Size(28, 28);
            this.btn_first.TabIndex = 4;
            this.btn_first.UseVisualStyleBackColor = true;
            this.btn_first.Click += new System.EventHandler(this.btn_first_Click);
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
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column1});
            this.dataGrid.DataSource = this.teacherBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid.Location = new System.Drawing.Point(3, 0);
            this.dataGrid.MultiSelect = false;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowHeadersVisible = false;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(480, 372);
            this.dataGrid.StandardTab = true;
            this.dataGrid.TabIndex = 0;
            this.dataGrid.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_RowEnter);
            this.dataGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGrid_KeyDown);
            this.dataGrid.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGrid_ColumnWidthChanged);
            this.dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellContentClick);
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "idteacher";
            this.Column2.FillWeight = 115F;
            this.Column2.HeaderText = "کد پرسنلی";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "lname";
            this.Column3.FillWeight = 126F;
            this.Column3.HeaderText = "نام خانوادگی";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "name";
            this.Column4.HeaderText = "نام";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "tell";
            this.Column5.HeaderText = "تلفن";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column1.HeaderText = "انتخاب درس";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Text = "انتخاب";
            this.Column1.UseColumnTextForButtonValue = true;
            this.Column1.Width = 74;
            // 
            // flp_f
            // 
            this.flp_f.Controls.Add(this.txt_idcode_f);
            this.flp_f.Controls.Add(this.txt_lname_f);
            this.flp_f.Controls.Add(this.txt_name_f);
            this.flp_f.Controls.Add(this.txt_tell_f);
            this.flp_f.Location = new System.Drawing.Point(3, 373);
            this.flp_f.Name = "flp_f";
            this.flp_f.Size = new System.Drawing.Size(480, 23);
            this.flp_f.TabIndex = 1;
            // 
            // txt_idcode_f
            // 
            this.txt_idcode_f.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_idcode_f.Location = new System.Drawing.Point(432, 0);
            this.txt_idcode_f.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.txt_idcode_f.Name = "txt_idcode_f";
            this.txt_idcode_f.Size = new System.Drawing.Size(48, 22);
            this.txt_idcode_f.TabIndex = 0;
            this.txt_idcode_f.TextChanged += new System.EventHandler(this.actfilter);
            this.txt_idcode_f.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextcontrol);
            this.txt_idcode_f.Leave += new System.EventHandler(this.leavecolor);
            this.txt_idcode_f.Enter += new System.EventHandler(this.entercolor);
            // 
            // txt_lname_f
            // 
            this.txt_lname_f.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_lname_f.Location = new System.Drawing.Point(331, 0);
            this.txt_lname_f.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.txt_lname_f.Name = "txt_lname_f";
            this.txt_lname_f.Size = new System.Drawing.Size(100, 22);
            this.txt_lname_f.TabIndex = 1;
            this.txt_lname_f.TextChanged += new System.EventHandler(this.actfilter);
            this.txt_lname_f.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextcontrol);
            this.txt_lname_f.Leave += new System.EventHandler(this.leavecolor);
            this.txt_lname_f.Enter += new System.EventHandler(this.entercolor);
            // 
            // txt_name_f
            // 
            this.txt_name_f.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_name_f.Location = new System.Drawing.Point(230, 0);
            this.txt_name_f.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.txt_name_f.Name = "txt_name_f";
            this.txt_name_f.Size = new System.Drawing.Size(100, 22);
            this.txt_name_f.TabIndex = 2;
            this.txt_name_f.TextChanged += new System.EventHandler(this.actfilter);
            this.txt_name_f.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextcontrol);
            this.txt_name_f.Leave += new System.EventHandler(this.leavecolor);
            this.txt_name_f.Enter += new System.EventHandler(this.entercolor);
            // 
            // txt_tell_f
            // 
            this.txt_tell_f.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_tell_f.Location = new System.Drawing.Point(129, 0);
            this.txt_tell_f.Margin = new System.Windows.Forms.Padding(0);
            this.txt_tell_f.Name = "txt_tell_f";
            this.txt_tell_f.Size = new System.Drawing.Size(100, 22);
            this.txt_tell_f.TabIndex = 3;
            this.txt_tell_f.TextChanged += new System.EventHandler(this.actfilter);
            this.txt_tell_f.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextcontrol);
            this.txt_tell_f.Leave += new System.EventHandler(this.leavecolor);
            this.txt_tell_f.Enter += new System.EventHandler(this.entercolor);
            // 
            // ds_teacher
            // 
            this.ds_teacher.DataSetName = "ds_teacher";
            this.ds_teacher.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grb_input
            // 
            this.grb_input.Controls.Add(this.lbl_tell);
            this.grb_input.Controls.Add(this.lbl_name);
            this.grb_input.Controls.Add(this.lbl_lname);
            this.grb_input.Controls.Add(this.lbl_idcode);
            this.grb_input.Controls.Add(this.txt_tell);
            this.grb_input.Controls.Add(this.txt_name);
            this.grb_input.Controls.Add(this.txt_lname);
            this.grb_input.Controls.Add(this.txt_idcode);
            this.grb_input.Location = new System.Drawing.Point(12, 445);
            this.grb_input.Name = "grb_input";
            this.grb_input.Size = new System.Drawing.Size(486, 108);
            this.grb_input.TabIndex = 0;
            this.grb_input.TabStop = false;
            this.grb_input.Text = "اطلاعات";
            // 
            // lbl_tell
            // 
            this.lbl_tell.AutoSize = true;
            this.lbl_tell.Location = new System.Drawing.Point(218, 23);
            this.lbl_tell.Name = "lbl_tell";
            this.lbl_tell.Size = new System.Drawing.Size(29, 14);
            this.lbl_tell.TabIndex = 1;
            this.lbl_tell.Text = "تلفن";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(407, 79);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(21, 14);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "نام";
            // 
            // lbl_lname
            // 
            this.lbl_lname.AutoSize = true;
            this.lbl_lname.Location = new System.Drawing.Point(407, 51);
            this.lbl_lname.Name = "lbl_lname";
            this.lbl_lname.Size = new System.Drawing.Size(72, 14);
            this.lbl_lname.TabIndex = 1;
            this.lbl_lname.Text = "نام خانوادگی";
            // 
            // lbl_idcode
            // 
            this.lbl_idcode.AutoSize = true;
            this.lbl_idcode.Location = new System.Drawing.Point(407, 23);
            this.lbl_idcode.Name = "lbl_idcode";
            this.lbl_idcode.Size = new System.Drawing.Size(68, 14);
            this.lbl_idcode.TabIndex = 1;
            this.lbl_idcode.Text = "کد پرسنلی ";
            // 
            // txt_tell
            // 
            this.txt_tell.Location = new System.Drawing.Point(112, 19);
            this.txt_tell.MaxLength = 50;
            this.txt_tell.Name = "txt_tell";
            this.txt_tell.Size = new System.Drawing.Size(100, 22);
            this.txt_tell.TabIndex = 3;
            this.txt_tell.TextChanged += new System.EventHandler(this.inputtxtchange);
            this.txt_tell.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextcontrol);
            this.txt_tell.Leave += new System.EventHandler(this.leavecolor);
            this.txt_tell.Enter += new System.EventHandler(this.entercolor);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(301, 75);
            this.txt_name.MaxLength = 20;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 22);
            this.txt_name.TabIndex = 2;
            this.txt_name.TextChanged += new System.EventHandler(this.inputtxtchange);
            this.txt_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextcontrol);
            this.txt_name.Leave += new System.EventHandler(this.leavecolor);
            this.txt_name.Enter += new System.EventHandler(this.entercolor);
            // 
            // txt_lname
            // 
            this.txt_lname.Location = new System.Drawing.Point(301, 47);
            this.txt_lname.MaxLength = 30;
            this.txt_lname.Name = "txt_lname";
            this.txt_lname.Size = new System.Drawing.Size(100, 22);
            this.txt_lname.TabIndex = 1;
            this.txt_lname.TextChanged += new System.EventHandler(this.inputtxtchange);
            this.txt_lname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextcontrol);
            this.txt_lname.Leave += new System.EventHandler(this.leavecolor);
            this.txt_lname.Enter += new System.EventHandler(this.entercolor);
            // 
            // txt_idcode
            // 
            this.txt_idcode.Location = new System.Drawing.Point(301, 19);
            this.txt_idcode.MaxLength = 9;
            this.txt_idcode.Name = "txt_idcode";
            this.txt_idcode.Size = new System.Drawing.Size(100, 22);
            this.txt_idcode.TabIndex = 0;
            this.txt_idcode.TextChanged += new System.EventHandler(this.inputtxtchange);
            this.txt_idcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextcontrol);
            this.txt_idcode.Leave += new System.EventHandler(this.leavecolor);
            this.txt_idcode.Enter += new System.EventHandler(this.entercolor);
            // 
            // btn_save
            // 
            this.btn_save.Enabled = false;
            this.btn_save.Image = global::Student.Properties.Resources.small_save;
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_save.Location = new System.Drawing.Point(186, 564);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 37);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "ذخیره";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_new
            // 
            this.btn_new.Enabled = false;
            this.btn_new.Image = global::Student.Properties.Resources.new_bookmark;
            this.btn_new.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_new.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_new.Location = new System.Drawing.Point(317, 564);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(75, 37);
            this.btn_new.TabIndex = 1;
            this.btn_new.Text = "جدید";
            this.btn_new.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_exit.Image")));
            this.btn_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_exit.Location = new System.Drawing.Point(55, 564);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 37);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.Text = "بازگشت";
            this.btn_exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // teacherTableAdapter
            // 
            this.teacherTableAdapter.ClearBeforeFill = true;
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
            // frm_teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(510, 615);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.grb_input);
            this.Controls.Add(this.pnl_datagride);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_teacher";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_teacher_Load);
            this.Shown += new System.EventHandler(this.frm_teacher_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_teacher_KeyDown);
            this.pnl_datagride.ResumeLayout(false);
            this.pnl_prba.ResumeLayout(false);
            this.pnl_prba.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pib_prba)).EndInit();
            this.pnl_nav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).EndInit();
            this.flp_f.ResumeLayout(false);
            this.flp_f.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds_teacher)).EndInit();
            this.grb_input.ResumeLayout(false);
            this.grb_input.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_datagride;
        private System.Windows.Forms.FlowLayoutPanel flp_f;
        private System.Windows.Forms.Panel pnl_nav;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Panel pnl_prba;
        private System.Windows.Forms.PictureBox pib_prba;
        private System.Windows.Forms.Label lbl_prba2;
        private System.Windows.Forms.Label lbl_prba1;
        private System.Windows.Forms.ProgressBar prba;
        private System.Windows.Forms.Button btn_first;
        private System.Windows.Forms.Button btn_last;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.GroupBox grb_input;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Label lbl_tell;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_lname;
        private System.Windows.Forms.Label lbl_idcode;
        private System.Windows.Forms.TextBox txt_tell;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_lname;
        private System.Windows.Forms.TextBox txt_idcode;
        private System.Windows.Forms.Button btn_exit;
        //private System.Windows.Forms.DataGridViewTextBoxColumn idcodeDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn lnameDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn tellDataGridViewTextBoxColumn;
        private DataSet.ds_teacher ds_teacher;
        private System.Windows.Forms.BindingSource teacherBindingSource;
        private Student.DataSet.ds_teacherTableAdapters.teacherTableAdapter teacherTableAdapter;
        private System.Windows.Forms.TextBox txt_idcode_f;
        private System.Windows.Forms.TextBox txt_lname_f;
        private System.Windows.Forms.TextBox txt_name_f;
        private System.Windows.Forms.TextBox txt_tell_f;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.ComponentModel.BackgroundWorker backgroundWorker_s;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
    }
}

