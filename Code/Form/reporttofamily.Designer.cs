namespace Student
{
    partial class frm_reporttofamily
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
            this.grp_settting = new System.Windows.Forms.GroupBox();
            this.chk_lessennumber = new System.Windows.Forms.CheckBox();
            this.chk_avelesson = new System.Windows.Forms.CheckBox();
            this.chk_leassonchartstu = new System.Windows.Forms.CheckBox();
            this.chk_moadelkol = new System.Windows.Forms.CheckBox();
            this.chk_rotbe = new System.Windows.Forms.CheckBox();
            this.chk_nsbatbeclass = new System.Windows.Forms.CheckBox();
            this.chk_enzebati = new System.Windows.Forms.CheckBox();
            this.txt_datet = new System.Windows.Forms.TextBox();
            this.txt_datef = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txt_hedertext = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_matne = new System.Windows.Forms.Label();
            this.btn_print_koli = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.grp_select = new System.Windows.Forms.GroupBox();
            this.btn_deselectall = new System.Windows.Forms.Button();
            this.btn_selectall = new System.Windows.Forms.Button();
            this.btn_prepreview = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idstudentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.classstudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_classstudent = new Student.DataSet.ds_classstudent();
            this.cmb_class = new System.Windows.Forms.ComboBox();
            this.classTableAdapter = new Student.DataSet.ds_classstudentTableAdapters.classTableAdapter();
            this.studentTableAdapter = new Student.DataSet.ds_classstudentTableAdapters.studentTableAdapter();
            this.ds_reporttofamily = new Student.DataSet.ds_reporttofamily();
            this.chk_dublex = new System.Windows.Forms.CheckBox();
            this.grp_settting.SuspendLayout();
            this.grp_select.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classstudentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_classstudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_reporttofamily)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_settting
            // 
            this.grp_settting.Controls.Add(this.chk_lessennumber);
            this.grp_settting.Controls.Add(this.chk_avelesson);
            this.grp_settting.Controls.Add(this.chk_leassonchartstu);
            this.grp_settting.Controls.Add(this.chk_moadelkol);
            this.grp_settting.Controls.Add(this.chk_rotbe);
            this.grp_settting.Controls.Add(this.chk_nsbatbeclass);
            this.grp_settting.Controls.Add(this.chk_enzebati);
            this.grp_settting.Controls.Add(this.txt_datet);
            this.grp_settting.Controls.Add(this.txt_datef);
            this.grp_settting.Controls.Add(this.textBox1);
            this.grp_settting.Controls.Add(this.txt_hedertext);
            this.grp_settting.Controls.Add(this.label4);
            this.grp_settting.Controls.Add(this.label1);
            this.grp_settting.Controls.Add(this.label3);
            this.grp_settting.Controls.Add(this.lbl_matne);
            this.grp_settting.Location = new System.Drawing.Point(12, 7);
            this.grp_settting.Name = "grp_settting";
            this.grp_settting.Size = new System.Drawing.Size(409, 166);
            this.grp_settting.TabIndex = 0;
            this.grp_settting.TabStop = false;
            this.grp_settting.Text = "تنظیمات نحوه ارائه گزارش";
            // 
            // chk_lessennumber
            // 
            this.chk_lessennumber.AutoSize = true;
            this.chk_lessennumber.Checked = true;
            this.chk_lessennumber.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_lessennumber.Location = new System.Drawing.Point(229, 20);
            this.chk_lessennumber.Name = "chk_lessennumber";
            this.chk_lessennumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chk_lessennumber.Size = new System.Drawing.Size(128, 17);
            this.chk_lessennumber.TabIndex = 1;
            this.chk_lessennumber.Text = "نمایش نمرات در دروس";
            this.chk_lessennumber.UseVisualStyleBackColor = true;
            // 
            // chk_avelesson
            // 
            this.chk_avelesson.AutoSize = true;
            this.chk_avelesson.Checked = true;
            this.chk_avelesson.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_avelesson.Location = new System.Drawing.Point(229, 43);
            this.chk_avelesson.Name = "chk_avelesson";
            this.chk_avelesson.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chk_avelesson.Size = new System.Drawing.Size(165, 17);
            this.chk_avelesson.TabIndex = 2;
            this.chk_avelesson.Text = "نمایش میانگین نمرات در دروس";
            this.chk_avelesson.UseVisualStyleBackColor = true;
            // 
            // chk_leassonchartstu
            // 
            this.chk_leassonchartstu.AutoSize = true;
            this.chk_leassonchartstu.Checked = true;
            this.chk_leassonchartstu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_leassonchartstu.Location = new System.Drawing.Point(229, 67);
            this.chk_leassonchartstu.Name = "chk_leassonchartstu";
            this.chk_leassonchartstu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chk_leassonchartstu.Size = new System.Drawing.Size(169, 17);
            this.chk_leassonchartstu.TabIndex = 3;
            this.chk_leassonchartstu.Text = "نمایش نمودار درسی دانش آموز";
            this.chk_leassonchartstu.UseVisualStyleBackColor = true;
            // 
            // chk_moadelkol
            // 
            this.chk_moadelkol.AutoSize = true;
            this.chk_moadelkol.Checked = true;
            this.chk_moadelkol.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_moadelkol.Location = new System.Drawing.Point(229, 91);
            this.chk_moadelkol.Name = "chk_moadelkol";
            this.chk_moadelkol.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chk_moadelkol.Size = new System.Drawing.Size(103, 17);
            this.chk_moadelkol.TabIndex = 4;
            this.chk_moadelkol.Text = "نمایش معدل کل ";
            this.chk_moadelkol.UseVisualStyleBackColor = true;
            // 
            // chk_rotbe
            // 
            this.chk_rotbe.AutoSize = true;
            this.chk_rotbe.Checked = true;
            this.chk_rotbe.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_rotbe.Location = new System.Drawing.Point(19, 20);
            this.chk_rotbe.Name = "chk_rotbe";
            this.chk_rotbe.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chk_rotbe.Size = new System.Drawing.Size(128, 17);
            this.chk_rotbe.TabIndex = 5;
            this.chk_rotbe.TabStop = false;
            this.chk_rotbe.Text = "نمایش رتبه دانش آموز ";
            this.chk_rotbe.UseVisualStyleBackColor = true;
            // 
            // chk_nsbatbeclass
            // 
            this.chk_nsbatbeclass.AutoSize = true;
            this.chk_nsbatbeclass.Checked = true;
            this.chk_nsbatbeclass.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_nsbatbeclass.Location = new System.Drawing.Point(19, 43);
            this.chk_nsbatbeclass.Name = "chk_nsbatbeclass";
            this.chk_nsbatbeclass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chk_nsbatbeclass.Size = new System.Drawing.Size(175, 17);
            this.chk_nsbatbeclass.TabIndex = 6;
            this.chk_nsbatbeclass.Text = "نمودار دانش آموز نسبت به کلاس";
            this.chk_nsbatbeclass.UseVisualStyleBackColor = true;
            // 
            // chk_enzebati
            // 
            this.chk_enzebati.AutoSize = true;
            this.chk_enzebati.Checked = true;
            this.chk_enzebati.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_enzebati.Location = new System.Drawing.Point(18, 67);
            this.chk_enzebati.Name = "chk_enzebati";
            this.chk_enzebati.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chk_enzebati.Size = new System.Drawing.Size(170, 17);
            this.chk_enzebati.TabIndex = 7;
            this.chk_enzebati.Text = "نمایش موارد انضباتی دانش آموز";
            this.chk_enzebati.UseVisualStyleBackColor = true;
            // 
            // txt_datet
            // 
            this.txt_datet.Location = new System.Drawing.Point(18, 89);
            this.txt_datet.MaxLength = 6;
            this.txt_datet.Name = "txt_datet";
            this.txt_datet.Size = new System.Drawing.Size(43, 21);
            this.txt_datet.TabIndex = 9;
            this.txt_datet.Leave += new System.EventHandler(this.leavecolor);
            this.txt_datet.Enter += new System.EventHandler(this.entercolor);
            // 
            // txt_datef
            // 
            this.txt_datef.Location = new System.Drawing.Point(104, 89);
            this.txt_datef.MaxLength = 6;
            this.txt_datef.Name = "txt_datef";
            this.txt_datef.Size = new System.Drawing.Size(43, 21);
            this.txt_datef.TabIndex = 8;
            this.txt_datef.Leave += new System.EventHandler(this.leavecolor);
            this.txt_datef.Enter += new System.EventHandler(this.entercolor);
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Student.Properties.Settings.Default, "url_email_str", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox1.Location = new System.Drawing.Point(18, 138);
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.Size = new System.Drawing.Size(275, 21);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = global::Student.Properties.Settings.Default.url_email_str;
            this.textBox1.Leave += new System.EventHandler(this.leavecolor);
            this.textBox1.Enter += new System.EventHandler(this.entercolor);
            // 
            // txt_hedertext
            // 
            this.txt_hedertext.Location = new System.Drawing.Point(18, 116);
            this.txt_hedertext.Name = "txt_hedertext";
            this.txt_hedertext.Size = new System.Drawing.Size(288, 21);
            this.txt_hedertext.TabIndex = 10;
            this.txt_hedertext.Leave += new System.EventHandler(this.leavecolor);
            this.txt_hedertext.Enter += new System.EventHandler(this.entercolor);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(299, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "آدرس سایت / ایمیل";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "متن بالای گزارش";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "تا تاریخ";
            // 
            // lbl_matne
            // 
            this.lbl_matne.AutoSize = true;
            this.lbl_matne.Location = new System.Drawing.Point(150, 93);
            this.lbl_matne.Name = "lbl_matne";
            this.lbl_matne.Size = new System.Drawing.Size(38, 13);
            this.lbl_matne.TabIndex = 9;
            this.lbl_matne.Text = "از تاریخ";
            // 
            // btn_print_koli
            // 
            this.btn_print_koli.Image = global::Student.Properties.Resources.previewp;
            this.btn_print_koli.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_print_koli.Location = new System.Drawing.Point(93, 501);
            this.btn_print_koli.Name = "btn_print_koli";
            this.btn_print_koli.Size = new System.Drawing.Size(75, 33);
            this.btn_print_koli.TabIndex = 3;
            this.btn_print_koli.Text = "پرینت";
            this.btn_print_koli.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_print_koli.UseVisualStyleBackColor = true;
            this.btn_print_koli.Click += new System.EventHandler(this.btn_print_koli_click);
            // 
            // btn_exit
            // 
            this.btn_exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_exit.Image = global::Student.Properties.Resources.ExitH51;
            this.btn_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exit.Location = new System.Drawing.Point(12, 501);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 33);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.Text = "باز گشت";
            this.btn_exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_exit.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(-2, 539);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(440, 16);
            this.progressBar1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "انتخاب کلاس";
            // 
            // grp_select
            // 
            this.grp_select.Controls.Add(this.btn_deselectall);
            this.grp_select.Controls.Add(this.btn_selectall);
            this.grp_select.Controls.Add(this.btn_prepreview);
            this.grp_select.Controls.Add(this.dataGridView1);
            this.grp_select.Controls.Add(this.label2);
            this.grp_select.Controls.Add(this.cmb_class);
            this.grp_select.Location = new System.Drawing.Point(12, 175);
            this.grp_select.Name = "grp_select";
            this.grp_select.Size = new System.Drawing.Size(409, 321);
            this.grp_select.TabIndex = 1;
            this.grp_select.TabStop = false;
            this.grp_select.Text = "انتخاب";
            // 
            // btn_deselectall
            // 
            this.btn_deselectall.Location = new System.Drawing.Point(259, 294);
            this.btn_deselectall.Name = "btn_deselectall";
            this.btn_deselectall.Size = new System.Drawing.Size(69, 24);
            this.btn_deselectall.TabIndex = 6;
            this.btn_deselectall.Text = "از نو";
            this.btn_deselectall.UseVisualStyleBackColor = true;
            this.btn_deselectall.Click += new System.EventHandler(this.btn_deselectall_Click);
            // 
            // btn_selectall
            // 
            this.btn_selectall.Location = new System.Drawing.Point(334, 294);
            this.btn_selectall.Name = "btn_selectall";
            this.btn_selectall.Size = new System.Drawing.Size(69, 24);
            this.btn_selectall.TabIndex = 6;
            this.btn_selectall.Text = "انتخاب همه";
            this.btn_selectall.UseVisualStyleBackColor = true;
            this.btn_selectall.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_prepreview
            // 
            this.btn_prepreview.Location = new System.Drawing.Point(6, 294);
            this.btn_prepreview.Name = "btn_prepreview";
            this.btn_prepreview.Size = new System.Drawing.Size(69, 24);
            this.btn_prepreview.TabIndex = 6;
            this.btn_prepreview.Text = "پیش نمایش";
            this.btn_prepreview.UseVisualStyleBackColor = true;
            this.btn_prepreview.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idstudentDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.fnameDataGridViewTextBoxColumn,
            this.chk});
            this.dataGridView1.DataSource = this.classstudentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 48);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(397, 244);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // idstudentDataGridViewTextBoxColumn
            // 
            this.idstudentDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.idstudentDataGridViewTextBoxColumn.DataPropertyName = "idstudent";
            this.idstudentDataGridViewTextBoxColumn.HeaderText = "شماره دانش آموزی";
            this.idstudentDataGridViewTextBoxColumn.Name = "idstudentDataGridViewTextBoxColumn";
            this.idstudentDataGridViewTextBoxColumn.ReadOnly = true;
            this.idstudentDataGridViewTextBoxColumn.Width = 120;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.FillWeight = 20F;
            this.nameDataGridViewTextBoxColumn.HeaderText = "نام و نام خانوادگی";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fnameDataGridViewTextBoxColumn
            // 
            this.fnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fnameDataGridViewTextBoxColumn.DataPropertyName = "fname";
            this.fnameDataGridViewTextBoxColumn.FillWeight = 10F;
            this.fnameDataGridViewTextBoxColumn.HeaderText = "نام پدر";
            this.fnameDataGridViewTextBoxColumn.Name = "fnameDataGridViewTextBoxColumn";
            this.fnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // chk
            // 
            this.chk.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.chk.HeaderText = "انتخاب";
            this.chk.Name = "chk";
            this.chk.Width = 42;
            // 
            // classstudentBindingSource
            // 
            this.classstudentBindingSource.DataMember = "classstudent";
            this.classstudentBindingSource.DataSource = this.classBindingSource;
            // 
            // classBindingSource
            // 
            this.classBindingSource.DataMember = "class";
            this.classBindingSource.DataSource = this.ds_classstudent;
            // 
            // ds_classstudent
            // 
            this.ds_classstudent.DataSetName = "ds_classstudent";
            this.ds_classstudent.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmb_class
            // 
            this.cmb_class.DataSource = this.classBindingSource;
            this.cmb_class.DisplayMember = "name";
            this.cmb_class.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_class.FormattingEnabled = true;
            this.cmb_class.Location = new System.Drawing.Point(7, 18);
            this.cmb_class.Name = "cmb_class";
            this.cmb_class.Size = new System.Drawing.Size(121, 21);
            this.cmb_class.TabIndex = 0;
            this.cmb_class.ValueMember = "idclass";
            // 
            // classTableAdapter
            // 
            this.classTableAdapter.ClearBeforeFill = true;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // ds_reporttofamily
            // 
            this.ds_reporttofamily.DataSetName = "ds_reporttofamily";
            this.ds_reporttofamily.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chk_dublex
            // 
            this.chk_dublex.AutoSize = true;
            this.chk_dublex.Location = new System.Drawing.Point(321, 514);
            this.chk_dublex.Name = "chk_dublex";
            this.chk_dublex.Size = new System.Drawing.Size(94, 17);
            this.chk_dublex.TabIndex = 4;
            this.chk_dublex.Text = "چاپ دو سمتی";
            this.chk_dublex.UseVisualStyleBackColor = true;
            // 
            // frm_reporttofamily
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(437, 554);
            this.Controls.Add(this.chk_dublex);
            this.Controls.Add(this.grp_select);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_print_koli);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.grp_settting);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_reporttofamily";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "گزارش به خانواده";
            this.Load += new System.EventHandler(this.frm_reporttofamily_Load);
            this.Shown += new System.EventHandler(this.frm_reporttofamily_Shown);
            this.grp_settting.ResumeLayout(false);
            this.grp_settting.PerformLayout();
            this.grp_select.ResumeLayout(false);
            this.grp_select.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classstudentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_classstudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_reporttofamily)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_settting;
        private System.Windows.Forms.CheckBox chk_lessennumber;
        private System.Windows.Forms.CheckBox chk_rotbe;
        private System.Windows.Forms.CheckBox chk_moadelkol;
        private System.Windows.Forms.CheckBox chk_nsbatbeclass;
        private System.Windows.Forms.CheckBox chk_enzebati;
        private System.Windows.Forms.CheckBox chk_leassonchartstu;
        private System.Windows.Forms.CheckBox chk_avelesson;
        private System.Windows.Forms.Label lbl_matne;
        private System.Windows.Forms.TextBox txt_hedertext;
        private System.Windows.Forms.Button btn_print_koli;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grp_select;
        private System.Windows.Forms.ComboBox cmb_class;
        private Student.DataSet.ds_classstudent ds_classstudent;
        private System.Windows.Forms.BindingSource classBindingSource;
        private Student.DataSet.ds_classstudentTableAdapters.classTableAdapter classTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource classstudentBindingSource;
        private Student.DataSet.ds_classstudentTableAdapters.studentTableAdapter studentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idstudentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chk;
        private System.Windows.Forms.Button btn_prepreview;
        private System.Windows.Forms.Button btn_deselectall;
        private System.Windows.Forms.Button btn_selectall;
        private Student.DataSet.ds_reporttofamily ds_reporttofamily;
        private System.Windows.Forms.TextBox txt_datet;
        private System.Windows.Forms.TextBox txt_datef;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chk_dublex;
    }
}