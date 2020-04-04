namespace Student
{
    partial class frm_student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_student));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_nav_datagride = new System.Windows.Forms.Panel();
            this.pnl_prba = new System.Windows.Forms.Panel();
            this.pib_prba = new System.Windows.Forms.PictureBox();
            this.lbl_prba2 = new System.Windows.Forms.Label();
            this.lbl_prba1 = new System.Windows.Forms.Label();
            this.prba = new System.Windows.Forms.ProgressBar();
            this.pnl_nav = new System.Windows.Forms.Panel();
            this.btn_first = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_last = new System.Windows.Forms.Button();
            this.btn_prev = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flp_f = new System.Windows.Forms.FlowLayoutPanel();
            this.txt_idstudent_f = new System.Windows.Forms.TextBox();
            this.txt_lname_f = new System.Windows.Forms.TextBox();
            this.txt_name_f = new System.Windows.Forms.TextBox();
            this.txt_sh_f = new System.Windows.Forms.TextBox();
            this.txt_tell_f = new System.Windows.Forms.TextBox();
            this.ds_student = new Student.DataSet.ds_student();
            this.grb_input = new System.Windows.Forms.GroupBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_tell = new System.Windows.Forms.TextBox();
            this.txt_lname = new System.Windows.Forms.TextBox();
            this.txt_fname = new System.Windows.Forms.TextBox();
            this.txt_idstudent = new System.Windows.Forms.TextBox();
            this.lbl_address = new System.Windows.Forms.Label();
            this.txt_sh = new System.Windows.Forms.TextBox();
            this.lbl_tell = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_fname = new System.Windows.Forms.Label();
            this.lbl_lname = new System.Windows.Forms.Label();
            this.lbl_sh = new System.Windows.Forms.Label();
            this.lbl_idcodest = new System.Windows.Forms.Label();
            this.cmb_idclass = new System.Windows.Forms.ComboBox();
            this.classBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_idclass = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.backgroundWorker_s = new System.ComponentModel.BackgroundWorker();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.studentTableAdapter = new Student.DataSet.ds_studentTableAdapters.studentTableAdapter();
            this.classTableAdapter = new Student.DataSet.ds_studentTableAdapters.classTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_major = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_grade = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_count = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_nav_datagride.SuspendLayout();
            this.pnl_prba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pib_prba)).BeginInit();
            this.pnl_nav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.flp_f.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds_student)).BeginInit();
            this.grb_input.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_nav_datagride
            // 
            this.pnl_nav_datagride.Controls.Add(this.pnl_prba);
            this.pnl_nav_datagride.Controls.Add(this.pnl_nav);
            this.pnl_nav_datagride.Controls.Add(this.dataGrid);
            this.pnl_nav_datagride.Controls.Add(this.flp_f);
            resources.ApplyResources(this.pnl_nav_datagride, "pnl_nav_datagride");
            this.pnl_nav_datagride.Name = "pnl_nav_datagride";
            // 
            // pnl_prba
            // 
            this.pnl_prba.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            resources.ApplyResources(this.pnl_prba, "pnl_prba");
            this.pnl_prba.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_prba.Controls.Add(this.pib_prba);
            this.pnl_prba.Controls.Add(this.lbl_prba2);
            this.pnl_prba.Controls.Add(this.lbl_prba1);
            this.pnl_prba.Controls.Add(this.prba);
            this.pnl_prba.Name = "pnl_prba";
            // 
            // pib_prba
            // 
            resources.ApplyResources(this.pib_prba, "pib_prba");
            this.pib_prba.Name = "pib_prba";
            this.pib_prba.TabStop = false;
            // 
            // lbl_prba2
            // 
            resources.ApplyResources(this.lbl_prba2, "lbl_prba2");
            this.lbl_prba2.Name = "lbl_prba2";
            // 
            // lbl_prba1
            // 
            resources.ApplyResources(this.lbl_prba1, "lbl_prba1");
            this.lbl_prba1.Name = "lbl_prba1";
            // 
            // prba
            // 
            resources.ApplyResources(this.prba, "prba");
            this.prba.Name = "prba";
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
            resources.ApplyResources(this.pnl_nav, "pnl_nav");
            this.pnl_nav.Name = "pnl_nav";
            // 
            // btn_first
            // 
            resources.ApplyResources(this.btn_first, "btn_first");
            this.btn_first.Name = "btn_first";
            this.btn_first.UseVisualStyleBackColor = true;
            this.btn_first.Click += new System.EventHandler(this.btn_first_Click);
            // 
            // btn_del
            // 
            resources.ApplyResources(this.btn_del, "btn_del");
            this.btn_del.Name = "btn_del";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_last
            // 
            resources.ApplyResources(this.btn_last, "btn_last");
            this.btn_last.Name = "btn_last";
            this.btn_last.UseVisualStyleBackColor = true;
            this.btn_last.Click += new System.EventHandler(this.btn_last_Click);
            // 
            // btn_prev
            // 
            resources.ApplyResources(this.btn_prev, "btn_prev");
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.UseVisualStyleBackColor = true;
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // btn_next
            // 
            resources.ApplyResources(this.btn_next, "btn_next");
            this.btn_next.Name = "btn_next";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
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
            this.Column2,
            this.Column7,
            this.Column3,
            this.Column6});
            this.dataGrid.DataSource = this.studentBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.dataGrid, "dataGrid");
            this.dataGrid.MultiSelect = false;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowHeadersVisible = false;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.StandardTab = true;
            this.dataGrid.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_RowEnter);
            this.dataGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGrid_KeyDown);
            this.dataGrid.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGrid_ColumnWidthChanged);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "idstudent";
            this.Column1.FillWeight = 150F;
            resources.ApplyResources(this.Column1, "Column1");
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "lname";
            this.Column2.FillWeight = 120F;
            resources.ApplyResources(this.Column2, "Column2");
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.DataPropertyName = "name";
            this.Column7.FillWeight = 90F;
            resources.ApplyResources(this.Column7, "Column7");
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "sh";
            this.Column3.FillWeight = 130F;
            resources.ApplyResources(this.Column3, "Column3");
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.DataPropertyName = "tell";
            resources.ApplyResources(this.Column6, "Column6");
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.AllowNew = true;
            // 
            // flp_f
            // 
            this.flp_f.Controls.Add(this.txt_idstudent_f);
            this.flp_f.Controls.Add(this.txt_lname_f);
            this.flp_f.Controls.Add(this.txt_name_f);
            this.flp_f.Controls.Add(this.txt_sh_f);
            this.flp_f.Controls.Add(this.txt_tell_f);
            resources.ApplyResources(this.flp_f, "flp_f");
            this.flp_f.Name = "flp_f";
            // 
            // txt_idstudent_f
            // 
            this.txt_idstudent_f.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txt_idstudent_f, "txt_idstudent_f");
            this.txt_idstudent_f.Name = "txt_idstudent_f";
            this.toolTip.SetToolTip(this.txt_idstudent_f, resources.GetString("txt_idstudent_f.ToolTip"));
            this.txt_idstudent_f.TextChanged += new System.EventHandler(this.actfilter);
            this.txt_idstudent_f.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextcontrol);
            this.txt_idstudent_f.Leave += new System.EventHandler(this.leavecolor);
            this.txt_idstudent_f.Enter += new System.EventHandler(this.entercolor);
            // 
            // txt_lname_f
            // 
            this.txt_lname_f.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txt_lname_f, "txt_lname_f");
            this.txt_lname_f.Name = "txt_lname_f";
            this.toolTip.SetToolTip(this.txt_lname_f, resources.GetString("txt_lname_f.ToolTip"));
            this.txt_lname_f.TextChanged += new System.EventHandler(this.actfilter);
            this.txt_lname_f.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextcontrol);
            this.txt_lname_f.Leave += new System.EventHandler(this.leavecolor);
            this.txt_lname_f.Enter += new System.EventHandler(this.entercolor);
            // 
            // txt_name_f
            // 
            this.txt_name_f.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txt_name_f, "txt_name_f");
            this.txt_name_f.Name = "txt_name_f";
            this.toolTip.SetToolTip(this.txt_name_f, resources.GetString("txt_name_f.ToolTip"));
            this.txt_name_f.TextChanged += new System.EventHandler(this.actfilter);
            this.txt_name_f.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextcontrol);
            this.txt_name_f.Leave += new System.EventHandler(this.leavecolor);
            this.txt_name_f.Enter += new System.EventHandler(this.entercolor);
            // 
            // txt_sh_f
            // 
            this.txt_sh_f.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txt_sh_f, "txt_sh_f");
            this.txt_sh_f.Name = "txt_sh_f";
            this.toolTip.SetToolTip(this.txt_sh_f, resources.GetString("txt_sh_f.ToolTip"));
            this.txt_sh_f.TextChanged += new System.EventHandler(this.actfilter);
            this.txt_sh_f.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextcontrol);
            this.txt_sh_f.Leave += new System.EventHandler(this.leavecolor);
            this.txt_sh_f.Enter += new System.EventHandler(this.entercolor);
            // 
            // txt_tell_f
            // 
            this.txt_tell_f.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txt_tell_f, "txt_tell_f");
            this.txt_tell_f.Name = "txt_tell_f";
            this.toolTip.SetToolTip(this.txt_tell_f, resources.GetString("txt_tell_f.ToolTip"));
            this.txt_tell_f.TextChanged += new System.EventHandler(this.actfilter);
            this.txt_tell_f.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextcontrol);
            this.txt_tell_f.Leave += new System.EventHandler(this.leavecolor);
            this.txt_tell_f.Enter += new System.EventHandler(this.entercolor);
            // 
            // ds_student
            // 
            this.ds_student.DataSetName = "ds_student";
            this.ds_student.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grb_input
            // 
            this.grb_input.Controls.Add(this.txt_address);
            this.grb_input.Controls.Add(this.txt_name);
            this.grb_input.Controls.Add(this.txt_tell);
            this.grb_input.Controls.Add(this.txt_lname);
            this.grb_input.Controls.Add(this.txt_fname);
            this.grb_input.Controls.Add(this.txt_idstudent);
            this.grb_input.Controls.Add(this.lbl_address);
            this.grb_input.Controls.Add(this.txt_sh);
            this.grb_input.Controls.Add(this.lbl_tell);
            this.grb_input.Controls.Add(this.lbl_name);
            this.grb_input.Controls.Add(this.lbl_fname);
            this.grb_input.Controls.Add(this.lbl_lname);
            this.grb_input.Controls.Add(this.lbl_sh);
            this.grb_input.Controls.Add(this.lbl_idcodest);
            resources.ApplyResources(this.grb_input, "grb_input");
            this.grb_input.Name = "grb_input";
            this.grb_input.TabStop = false;
            // 
            // txt_address
            // 
            resources.ApplyResources(this.txt_address, "txt_address");
            this.txt_address.Name = "txt_address";
            this.txt_address.ShortcutsEnabled = false;
            this.txt_address.TextChanged += new System.EventHandler(this.inputtxtchange);
            this.txt_address.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextcontrol);
            this.txt_address.Leave += new System.EventHandler(this.leavecolor);
            this.txt_address.Enter += new System.EventHandler(this.entercolor);
            // 
            // txt_name
            // 
            resources.ApplyResources(this.txt_name, "txt_name");
            this.txt_name.Name = "txt_name";
            this.txt_name.ShortcutsEnabled = false;
            this.txt_name.TextChanged += new System.EventHandler(this.inputtxtchange);
            this.txt_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextcontrol);
            this.txt_name.Leave += new System.EventHandler(this.leavecolor);
            this.txt_name.Enter += new System.EventHandler(this.entercolor);
            // 
            // txt_tell
            // 
            resources.ApplyResources(this.txt_tell, "txt_tell");
            this.txt_tell.Name = "txt_tell";
            this.txt_tell.ShortcutsEnabled = false;
            this.txt_tell.TextChanged += new System.EventHandler(this.inputtxtchange);
            this.txt_tell.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_sh_KeyDown);
            this.txt_tell.Leave += new System.EventHandler(this.leavecolor);
            this.txt_tell.Enter += new System.EventHandler(this.entercolor);
            // 
            // txt_lname
            // 
            resources.ApplyResources(this.txt_lname, "txt_lname");
            this.txt_lname.Name = "txt_lname";
            this.txt_lname.ShortcutsEnabled = false;
            this.txt_lname.TextChanged += new System.EventHandler(this.inputtxtchange);
            this.txt_lname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextcontrol);
            this.txt_lname.Leave += new System.EventHandler(this.leavecolor);
            this.txt_lname.Enter += new System.EventHandler(this.entercolor);
            // 
            // txt_fname
            // 
            resources.ApplyResources(this.txt_fname, "txt_fname");
            this.txt_fname.Name = "txt_fname";
            this.txt_fname.ShortcutsEnabled = false;
            this.txt_fname.TextChanged += new System.EventHandler(this.inputtxtchange);
            this.txt_fname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextcontrol);
            this.txt_fname.Leave += new System.EventHandler(this.leavecolor);
            this.txt_fname.Enter += new System.EventHandler(this.entercolor);
            // 
            // txt_idstudent
            // 
            resources.ApplyResources(this.txt_idstudent, "txt_idstudent");
            this.txt_idstudent.Name = "txt_idstudent";
            this.txt_idstudent.ShortcutsEnabled = false;
            this.txt_idstudent.TextChanged += new System.EventHandler(this.inputtxtchange);
            this.txt_idstudent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextcontrol);
            this.txt_idstudent.Leave += new System.EventHandler(this.leavecolor);
            this.txt_idstudent.Enter += new System.EventHandler(this.entercolor);
            // 
            // lbl_address
            // 
            resources.ApplyResources(this.lbl_address, "lbl_address");
            this.lbl_address.Name = "lbl_address";
            // 
            // txt_sh
            // 
            resources.ApplyResources(this.txt_sh, "txt_sh");
            this.txt_sh.Name = "txt_sh";
            this.txt_sh.ShortcutsEnabled = false;
            this.txt_sh.TextChanged += new System.EventHandler(this.inputtxtchange);
            this.txt_sh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_sh_KeyDown);
            this.txt_sh.Leave += new System.EventHandler(this.leavecolor);
            this.txt_sh.Enter += new System.EventHandler(this.entercolor);
            // 
            // lbl_tell
            // 
            resources.ApplyResources(this.lbl_tell, "lbl_tell");
            this.lbl_tell.Name = "lbl_tell";
            // 
            // lbl_name
            // 
            resources.ApplyResources(this.lbl_name, "lbl_name");
            this.lbl_name.Name = "lbl_name";
            // 
            // lbl_fname
            // 
            resources.ApplyResources(this.lbl_fname, "lbl_fname");
            this.lbl_fname.Name = "lbl_fname";
            // 
            // lbl_lname
            // 
            resources.ApplyResources(this.lbl_lname, "lbl_lname");
            this.lbl_lname.Name = "lbl_lname";
            // 
            // lbl_sh
            // 
            resources.ApplyResources(this.lbl_sh, "lbl_sh");
            this.lbl_sh.Name = "lbl_sh";
            // 
            // lbl_idcodest
            // 
            resources.ApplyResources(this.lbl_idcodest, "lbl_idcodest");
            this.lbl_idcodest.Name = "lbl_idcodest";
            // 
            // cmb_idclass
            // 
            this.cmb_idclass.DataSource = this.classBindingSource;
            this.cmb_idclass.DisplayMember = "name";
            this.cmb_idclass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_idclass.FormattingEnabled = true;
            resources.ApplyResources(this.cmb_idclass, "cmb_idclass");
            this.cmb_idclass.Name = "cmb_idclass";
            this.cmb_idclass.ValueMember = "idclass";
            this.cmb_idclass.SelectedIndexChanged += new System.EventHandler(this.cmb_idclass_SelectedIndexChanged);
            this.cmb_idclass.Leave += new System.EventHandler(this.leavecolor);
            this.cmb_idclass.Enter += new System.EventHandler(this.entercolor);
            // 
            // classBindingSource
            // 
            this.classBindingSource.DataMember = "class";
            this.classBindingSource.DataSource = this.ds_student;
            this.classBindingSource.Sort = "name";
            // 
            // lbl_idclass
            // 
            resources.ApplyResources(this.lbl_idclass, "lbl_idclass");
            this.lbl_idclass.Name = "lbl_idclass";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_exit
            // 
            resources.ApplyResources(this.btn_exit, "btn_exit");
            this.btn_exit.Name = "btn_exit";
            this.toolTip.SetToolTip(this.btn_exit, resources.GetString("btn_exit.ToolTip"));
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_save
            // 
            resources.ApplyResources(this.btn_save, "btn_save");
            this.btn_save.Name = "btn_save";
            this.toolTip.SetToolTip(this.btn_save, resources.GetString("btn_save.ToolTip"));
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_new
            // 
            resources.ApplyResources(this.btn_new, "btn_new");
            this.btn_new.Name = "btn_new";
            this.toolTip.SetToolTip(this.btn_new, resources.GetString("btn_new.ToolTip"));
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // backgroundWorker_s
            // 
            this.backgroundWorker_s.WorkerSupportsCancellation = true;
            this.backgroundWorker_s.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_s_DoWork);
            this.backgroundWorker_s.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_s_RunWorkerCompleted);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // classTableAdapter
            // 
            this.classTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // lbl_major
            // 
            this.lbl_major.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.classBindingSource, "majorname", true));
            this.lbl_major.ForeColor = System.Drawing.Color.DarkRed;
            resources.ApplyResources(this.lbl_major, "lbl_major");
            this.lbl_major.Name = "lbl_major";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // lbl_grade
            // 
            this.lbl_grade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.classBindingSource, "grade", true));
            this.lbl_grade.ForeColor = System.Drawing.Color.DarkRed;
            resources.ApplyResources(this.lbl_grade, "lbl_grade");
            this.lbl_grade.Name = "lbl_grade";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // lbl_count
            // 
            this.lbl_count.ForeColor = System.Drawing.Color.DarkRed;
            resources.ApplyResources(this.lbl_count, "lbl_count");
            this.lbl_count.Name = "lbl_count";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbl_count);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbl_grade);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbl_major);
            this.panel1.Controls.Add(this.cmb_idclass);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lbl_idclass);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // frm_student
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.grb_input);
            this.Controls.Add(this.pnl_nav_datagride);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_student";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.frm_student_Load);
            this.Shown += new System.EventHandler(this.frm_student_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_student_KeyDown);
            this.pnl_nav_datagride.ResumeLayout(false);
            this.pnl_prba.ResumeLayout(false);
            this.pnl_prba.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pib_prba)).EndInit();
            this.pnl_nav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.flp_f.ResumeLayout(false);
            this.flp_f.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds_student)).EndInit();
            this.grb_input.ResumeLayout(false);
            this.grb_input.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_nav_datagride;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button btn_last;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.Button btn_first;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.GroupBox grb_input;
        private System.Windows.Forms.Panel pnl_nav;
        private System.Windows.Forms.Label lbl_idcodest;
        private System.Windows.Forms.Label lbl_idclass;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.FlowLayoutPanel flp_f;
        //private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn lnameDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn idphoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_lname;
        private System.Windows.Forms.TextBox txt_lname;
        private System.Windows.Forms.TextBox txt_idstudent;
        private System.Windows.Forms.TextBox txt_idstudent_f;
        private System.Windows.Forms.TextBox txt_lname_f;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TextBox txt_name_f;
        private System.ComponentModel.BackgroundWorker backgroundWorker_s;
        private System.Windows.Forms.ProgressBar prba;
        private System.Windows.Forms.Panel pnl_prba;
        private System.Windows.Forms.Label lbl_prba1;
        private System.Windows.Forms.Label lbl_prba2;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox pib_prba;
        private DataSet.ds_student ds_student;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private Student.DataSet.ds_studentTableAdapters.studentTableAdapter studentTableAdapter;
        private System.Windows.Forms.TextBox txt_sh_f;
        private System.Windows.Forms.TextBox txt_tell_f;
        private System.Windows.Forms.TextBox txt_tell;
        private System.Windows.Forms.TextBox txt_fname;
        private System.Windows.Forms.TextBox txt_sh;
        private System.Windows.Forms.Label lbl_tell;
        private System.Windows.Forms.Label lbl_fname;
        private System.Windows.Forms.Label lbl_sh;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.ComboBox cmb_idclass;
        //private System.Windows.Forms.DataGridViewTextBoxColumn idcodestDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource classBindingSource;
        private Student.DataSet.ds_studentTableAdapters.classTableAdapter classTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_major;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_grade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_count;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}

