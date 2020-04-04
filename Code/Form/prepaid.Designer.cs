namespace Student
{
    partial class frm_prepaid
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grb_input = new System.Windows.Forms.GroupBox();
            this.txt_lessen = new System.Windows.Forms.TextBox();
            this.lbl_lname = new System.Windows.Forms.Label();
            this.pnl_datagride = new System.Windows.Forms.Panel();
            this.pnl_prba = new System.Windows.Forms.Panel();
            this.pib_prba = new System.Windows.Forms.PictureBox();
            this.lbl_prba2 = new System.Windows.Forms.Label();
            this.lbl_prba1 = new System.Windows.Forms.Label();
            this.prba = new System.Windows.Forms.ProgressBar();
            this.pnl_nav = new System.Windows.Forms.Panel();
            this.btn_first = new System.Windows.Forms.Button();
            this.btn_last = new System.Windows.Forms.Button();
            this.btn_prev = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btncol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flp_f = new System.Windows.Forms.FlowLayoutPanel();
            this.txt_code_f = new System.Windows.Forms.TextBox();
            this.txt_lname_f = new System.Windows.Forms.TextBox();
            this.txt_name_f = new System.Windows.Forms.TextBox();
            this.txt_prepaid_f = new System.Windows.Forms.TextBox();
            this.txt_lessen_f = new System.Windows.Forms.TextBox();
            this.ds_prepaidstudent = new Student.DataSet.ds_prepaidstudent();
            this.cmb_class = new System.Windows.Forms.ComboBox();
            this.classBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker_s = new System.ComponentModel.BackgroundWorker();
            this.dataTable1TableAdapter = new Student.DataSet.ds_prepaidstudentTableAdapters.DataTable1TableAdapter();
            this.pnl_title = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_grade_t = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_major_t = new System.Windows.Forms.Label();
            this.classTableAdapter = new Student.DataSet.ds_prepaidstudentTableAdapters.classTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.grb_input.SuspendLayout();
            this.pnl_datagride.SuspendLayout();
            this.pnl_prba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pib_prba)).BeginInit();
            this.pnl_nav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            this.flp_f.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds_prepaidstudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).BeginInit();
            this.pnl_title.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb_input
            // 
            this.grb_input.Controls.Add(this.txt_lessen);
            this.grb_input.Controls.Add(this.lbl_lname);
            this.grb_input.Location = new System.Drawing.Point(12, 380);
            this.grb_input.Name = "grb_input";
            this.grb_input.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grb_input.Size = new System.Drawing.Size(560, 58);
            this.grb_input.TabIndex = 7;
            this.grb_input.TabStop = false;
            this.grb_input.Text = "اطلاعات";
            // 
            // txt_lessen
            // 
            this.txt_lessen.Location = new System.Drawing.Point(292, 21);
            this.txt_lessen.MaxLength = 9;
            this.txt_lessen.Name = "txt_lessen";
            this.txt_lessen.Size = new System.Drawing.Size(144, 22);
            this.txt_lessen.TabIndex = 1;
            this.txt_lessen.TextChanged += new System.EventHandler(this.inputtxtchange);
            this.txt_lessen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_prepaid_KeyDown);
            this.txt_lessen.Leave += new System.EventHandler(this.leavecolor);
            this.txt_lessen.Enter += new System.EventHandler(this.entercolor);
            // 
            // lbl_lname
            // 
            this.lbl_lname.AutoSize = true;
            this.lbl_lname.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_lname.Location = new System.Drawing.Point(444, 25);
            this.lbl_lname.Name = "lbl_lname";
            this.lbl_lname.Size = new System.Drawing.Size(95, 14);
            this.lbl_lname.TabIndex = 1;
            this.lbl_lname.Text = "شهریه دانش آموز";
            // 
            // pnl_datagride
            // 
            this.pnl_datagride.Controls.Add(this.pnl_prba);
            this.pnl_datagride.Controls.Add(this.pnl_nav);
            this.pnl_datagride.Controls.Add(this.dataGrid);
            this.pnl_datagride.Controls.Add(this.flp_f);
            this.pnl_datagride.Location = new System.Drawing.Point(12, 47);
            this.pnl_datagride.Name = "pnl_datagride";
            this.pnl_datagride.Size = new System.Drawing.Size(563, 331);
            this.pnl_datagride.TabIndex = 10;
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
            this.pnl_prba.Location = new System.Drawing.Point(108, 99);
            this.pnl_prba.Name = "pnl_prba";
            this.pnl_prba.Size = new System.Drawing.Size(347, 72);
            this.pnl_prba.TabIndex = 3;
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
            // prba
            // 
            this.prba.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.prba.Location = new System.Drawing.Point(16, 11);
            this.prba.Name = "prba";
            this.prba.Size = new System.Drawing.Size(313, 26);
            this.prba.TabIndex = 5;
            // 
            // pnl_nav
            // 
            this.pnl_nav.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnl_nav.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_nav.Controls.Add(this.label4);
            this.pnl_nav.Controls.Add(this.button2);
            this.pnl_nav.Controls.Add(this.label2);
            this.pnl_nav.Controls.Add(this.textBox1);
            this.pnl_nav.Controls.Add(this.btn_first);
            this.pnl_nav.Controls.Add(this.btn_last);
            this.pnl_nav.Controls.Add(this.btn_prev);
            this.pnl_nav.Controls.Add(this.btn_next);
            this.pnl_nav.Location = new System.Drawing.Point(3, 294);
            this.pnl_nav.Name = "pnl_nav";
            this.pnl_nav.Size = new System.Drawing.Size(557, 34);
            this.pnl_nav.TabIndex = 2;
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
            // btn_last
            // 
            this.btn_last.Image = global::Student.Properties.Resources.DataContainer_MoveLastHS;
            this.btn_last.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_last.Location = new System.Drawing.Point(175, 1);
            this.btn_last.Name = "btn_last";
            this.btn_last.Size = new System.Drawing.Size(33, 30);
            this.btn_last.TabIndex = 0;
            this.btn_last.UseVisualStyleBackColor = true;
            this.btn_last.Click += new System.EventHandler(this.btn_last_Click);
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
            this.btn_next.Location = new System.Drawing.Point(136, 1);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(33, 30);
            this.btn_next.TabIndex = 1;
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
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6,
            this.btncol});
            this.dataGrid.DataSource = this.dataTable1BindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGrid.Location = new System.Drawing.Point(3, 3);
            this.dataGrid.MultiSelect = false;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGrid.RowHeadersVisible = false;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(557, 267);
            this.dataGrid.StandardTab = true;
            this.dataGrid.TabIndex = 0;
            this.dataGrid.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_RowEnter);
            this.dataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellClick);
            this.dataGrid.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGrid_ColumnWidthChanged);
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "idstudent";
            this.Column2.FillWeight = 50F;
            this.Column2.HeaderText = "شماره دانش آموزی";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "lname";
            this.Column3.FillWeight = 35F;
            this.Column3.HeaderText = "نام خانوادگی";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "name";
            this.Column4.FillWeight = 22F;
            this.Column4.HeaderText = "نام";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.DataPropertyName = "lessen";
            this.Column6.FillWeight = 22.49536F;
            this.Column6.HeaderText = "شهریه";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // btncol
            // 
            this.btncol.FillWeight = 130F;
            this.btncol.HeaderText = "اقساط";
            this.btncol.Name = "btncol";
            this.btncol.ReadOnly = true;
            this.btncol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btncol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btncol.Text = "انتخاب";
            this.btncol.UseColumnTextForButtonValue = true;
            this.btncol.Width = 60;
            // 
            // flp_f
            // 
            this.flp_f.Controls.Add(this.txt_code_f);
            this.flp_f.Controls.Add(this.txt_lname_f);
            this.flp_f.Controls.Add(this.txt_name_f);
            this.flp_f.Controls.Add(this.txt_prepaid_f);
            this.flp_f.Controls.Add(this.txt_lessen_f);
            this.flp_f.Location = new System.Drawing.Point(3, 271);
            this.flp_f.Name = "flp_f";
            this.flp_f.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flp_f.Size = new System.Drawing.Size(557, 25);
            this.flp_f.TabIndex = 1;
            // 
            // txt_code_f
            // 
            this.txt_code_f.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_code_f.Location = new System.Drawing.Point(492, 0);
            this.txt_code_f.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.txt_code_f.Name = "txt_code_f";
            this.txt_code_f.Size = new System.Drawing.Size(65, 22);
            this.txt_code_f.TabIndex = 0;
            this.txt_code_f.TextChanged += new System.EventHandler(this.actfilter);
            this.txt_code_f.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextcontrol);
            this.txt_code_f.Leave += new System.EventHandler(this.leavecolor);
            this.txt_code_f.Enter += new System.EventHandler(this.entercolor);
            // 
            // txt_lname_f
            // 
            this.txt_lname_f.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_lname_f.Location = new System.Drawing.Point(441, 0);
            this.txt_lname_f.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.txt_lname_f.Name = "txt_lname_f";
            this.txt_lname_f.Size = new System.Drawing.Size(50, 22);
            this.txt_lname_f.TabIndex = 1;
            this.txt_lname_f.TextChanged += new System.EventHandler(this.actfilter);
            this.txt_lname_f.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextcontrol);
            this.txt_lname_f.Leave += new System.EventHandler(this.leavecolor);
            this.txt_lname_f.Enter += new System.EventHandler(this.entercolor);
            // 
            // txt_name_f
            // 
            this.txt_name_f.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_name_f.Location = new System.Drawing.Point(390, 0);
            this.txt_name_f.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.txt_name_f.Name = "txt_name_f";
            this.txt_name_f.Size = new System.Drawing.Size(50, 22);
            this.txt_name_f.TabIndex = 1;
            this.txt_name_f.TextChanged += new System.EventHandler(this.actfilter);
            this.txt_name_f.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextcontrol);
            this.txt_name_f.Leave += new System.EventHandler(this.leavecolor);
            this.txt_name_f.Enter += new System.EventHandler(this.entercolor);
            // 
            // txt_prepaid_f
            // 
            this.txt_prepaid_f.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_prepaid_f.Location = new System.Drawing.Point(339, 0);
            this.txt_prepaid_f.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.txt_prepaid_f.Name = "txt_prepaid_f";
            this.txt_prepaid_f.Size = new System.Drawing.Size(50, 22);
            this.txt_prepaid_f.TabIndex = 1;
            this.txt_prepaid_f.TextChanged += new System.EventHandler(this.actfilter);
            this.txt_prepaid_f.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextcontrol);
            this.txt_prepaid_f.Leave += new System.EventHandler(this.leavecolor);
            this.txt_prepaid_f.Enter += new System.EventHandler(this.entercolor);
            // 
            // txt_lessen_f
            // 
            this.txt_lessen_f.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_lessen_f.Location = new System.Drawing.Point(288, 0);
            this.txt_lessen_f.Margin = new System.Windows.Forms.Padding(0);
            this.txt_lessen_f.Name = "txt_lessen_f";
            this.txt_lessen_f.Size = new System.Drawing.Size(50, 22);
            this.txt_lessen_f.TabIndex = 1;
            this.txt_lessen_f.TextChanged += new System.EventHandler(this.actfilter);
            this.txt_lessen_f.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextcontrol);
            this.txt_lessen_f.Leave += new System.EventHandler(this.leavecolor);
            this.txt_lessen_f.Enter += new System.EventHandler(this.entercolor);
            // 
            // ds_prepaidstudent
            // 
            this.ds_prepaidstudent.DataSetName = "ds_prepaidstudent";
            this.ds_prepaidstudent.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmb_class
            // 
            this.cmb_class.DataSource = this.classBindingSource;
            this.cmb_class.DisplayMember = "name";
            this.cmb_class.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_class.FormattingEnabled = true;
            this.cmb_class.Location = new System.Drawing.Point(372, 10);
            this.cmb_class.Name = "cmb_class";
            this.cmb_class.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmb_class.Size = new System.Drawing.Size(140, 22);
            this.cmb_class.TabIndex = 11;
            this.cmb_class.ValueMember = "idclass";
            this.cmb_class.SelectedIndexChanged += new System.EventHandler(this.actfilter);
            this.cmb_class.SelectedValueChanged += new System.EventHandler(this.cmb_class_SelectedValueChanged);
            // 
            // classBindingSource
            // 
            this.classBindingSource.DataMember = "class";
            this.classBindingSource.DataSource = this.ds_prepaidstudent;
            this.classBindingSource.Sort = "name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(525, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 14);
            this.label1.TabIndex = 12;
            this.label1.Text = "کلاس";
            // 
            // btn_exit
            // 
            this.btn_exit.Image = global::Student.Properties.Resources.ExitH51;
            this.btn_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_exit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_exit.Location = new System.Drawing.Point(12, 444);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(87, 40);
            this.btn_exit.TabIndex = 9;
            this.btn_exit.Text = "بازگشت";
            this.btn_exit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_save
            // 
            this.btn_save.Enabled = false;
            this.btn_save.Image = global::Student.Properties.Resources.small_save;
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_save.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_save.Location = new System.Drawing.Point(130, 444);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(87, 40);
            this.btn_save.TabIndex = 8;
            this.btn_save.Text = "ذخیره";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
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
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // pnl_title
            // 
            this.pnl_title.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnl_title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_title.Controls.Add(this.label5);
            this.pnl_title.Controls.Add(this.lbl_grade_t);
            this.pnl_title.Controls.Add(this.label3);
            this.pnl_title.Controls.Add(this.lbl_major_t);
            this.pnl_title.Controls.Add(this.cmb_class);
            this.pnl_title.Controls.Add(this.label1);
            this.pnl_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_title.Location = new System.Drawing.Point(0, 0);
            this.pnl_title.Name = "pnl_title";
            this.pnl_title.Size = new System.Drawing.Size(587, 41);
            this.pnl_title.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.classBindingSource, "grade", true));
            this.label5.Location = new System.Drawing.Point(17, 13);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(76, 19);
            this.label5.TabIndex = 13;
            // 
            // lbl_grade_t
            // 
            this.lbl_grade_t.AutoSize = true;
            this.lbl_grade_t.Location = new System.Drawing.Point(94, 13);
            this.lbl_grade_t.Name = "lbl_grade_t";
            this.lbl_grade_t.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_grade_t.Size = new System.Drawing.Size(32, 14);
            this.lbl_grade_t.TabIndex = 13;
            this.lbl_grade_t.Text = "پایه :";
            // 
            // label3
            // 
            this.label3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.classBindingSource, "namemajor", true));
            this.label3.Location = new System.Drawing.Point(161, 13);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(121, 19);
            this.label3.TabIndex = 13;
            // 
            // lbl_major_t
            // 
            this.lbl_major_t.AutoSize = true;
            this.lbl_major_t.Location = new System.Drawing.Point(281, 13);
            this.lbl_major_t.Name = "lbl_major_t";
            this.lbl_major_t.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_major_t.Size = new System.Drawing.Size(42, 14);
            this.lbl_major_t.TabIndex = 13;
            this.lbl_major_t.Text = "رشته :";
            // 
            // classTableAdapter
            // 
            this.classTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Image = global::Student.Properties.Resources.TaskHS;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(434, 444);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 40);
            this.button1.TabIndex = 14;
            this.button1.Text = "هزينه هاي مدرسه";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(287, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(78, 22);
            this.textBox1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(367, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 14);
            this.label2.TabIndex = 6;
            this.label2.Text = "تنظيم كلي شهريه‌هاي ثبت نشده به";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(237, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 30);
            this.button2.TabIndex = 7;
            this.button2.Text = "تنظيم";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Location = new System.Drawing.Point(222, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 34);
            this.label4.TabIndex = 8;
            this.label4.Text = "||||";
            // 
            // frm_prepaid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(587, 497);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grb_input);
            this.Controls.Add(this.pnl_datagride);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.pnl_title);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_prepaid";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_prepaid_Load);
            this.Shown += new System.EventHandler(this.frm_prepaid_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_DataTable1_KeyDown);
            this.grb_input.ResumeLayout(false);
            this.grb_input.PerformLayout();
            this.pnl_datagride.ResumeLayout(false);
            this.pnl_prba.ResumeLayout(false);
            this.pnl_prba.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pib_prba)).EndInit();
            this.pnl_nav.ResumeLayout(false);
            this.pnl_nav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            this.flp_f.ResumeLayout(false);
            this.flp_f.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds_prepaidstudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).EndInit();
            this.pnl_title.ResumeLayout(false);
            this.pnl_title.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_input;
        private System.Windows.Forms.TextBox txt_lessen;
        private System.Windows.Forms.Label lbl_lname;
        private System.Windows.Forms.Panel pnl_datagride;
        private System.Windows.Forms.Panel pnl_prba;
        private System.Windows.Forms.PictureBox pib_prba;
        private System.Windows.Forms.Label lbl_prba2;
        private System.Windows.Forms.Label lbl_prba1;
        private System.Windows.Forms.ProgressBar prba;
        private System.Windows.Forms.Panel pnl_nav;
        private System.Windows.Forms.Button btn_first;
        private System.Windows.Forms.Button btn_last;
        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.FlowLayoutPanel flp_f;
        private System.Windows.Forms.TextBox txt_code_f;
        private System.Windows.Forms.TextBox txt_lname_f;
        private System.Windows.Forms.TextBox txt_name_f;
        private System.Windows.Forms.TextBox txt_prepaid_f;
        private System.Windows.Forms.ComboBox cmb_class;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.ComponentModel.BackgroundWorker backgroundWorker_s;
        private DataSet.ds_prepaidstudent ds_prepaidstudent;
        private Student.DataSet.ds_prepaidstudentTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private System.Windows.Forms.TextBox txt_lessen_f;
        private System.Windows.Forms.Panel pnl_title;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_grade_t;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_major_t;
        private System.Windows.Forms.BindingSource classBindingSource;
        private Student.DataSet.ds_prepaidstudentTableAdapters.classTableAdapter classTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewButtonColumn btncol;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
    }
}

