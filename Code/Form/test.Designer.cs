namespace Student
{
    partial class frm_test
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_test));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_datagride = new System.Windows.Forms.Panel();
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
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flp_f = new System.Windows.Forms.FlowLayoutPanel();
            this.txt_classname_f = new System.Windows.Forms.TextBox();
            this.txt_lessonname_f = new System.Windows.Forms.TextBox();
            this.txt_date_f = new System.Windows.Forms.TextBox();
            this.ds_score = new Student.DataSet.ds_score();
            this.grb_input = new System.Windows.Forms.GroupBox();
            this.cmb_classname = new System.Windows.Forms.ComboBox();
            this.classBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmb_lessonname = new System.Windows.Forms.ComboBox();
            this.lessonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txt_date = new System.Windows.Forms.TextBox();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.lbl_lname = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.backgroundWorker_s = new System.ComponentModel.BackgroundWorker();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.dataTable1TableAdapter = new Student.DataSet.ds_scoreTableAdapters.DataTable1TableAdapter();
            this.classTableAdapter = new Student.DataSet.ds_scoreTableAdapters.classTableAdapter();
            this.lessonTableAdapter = new Student.DataSet.ds_scoreTableAdapters.lessonTableAdapter();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnl_datagride.SuspendLayout();
            this.pnl_prba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pib_prba)).BeginInit();
            this.pnl_nav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            this.flp_f.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds_score)).BeginInit();
            this.grb_input.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_datagride
            // 
            this.pnl_datagride.Controls.Add(this.pnl_prba);
            this.pnl_datagride.Controls.Add(this.pnl_nav);
            this.pnl_datagride.Controls.Add(this.dataGrid);
            this.pnl_datagride.Controls.Add(this.flp_f);
            resources.ApplyResources(this.pnl_datagride, "pnl_datagride");
            this.pnl_datagride.Name = "pnl_datagride";
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
            this.pib_prba.Image = global::Student.Properties.Resources.fSEARCH_00;
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
            this.lbl_prba1.Click += new System.EventHandler(this.lbl_prba1_Click);
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
            this.btn_first.Image = global::Student.Properties.Resources.DataContainer_MoveFirsHS;
            resources.ApplyResources(this.btn_first, "btn_first");
            this.btn_first.Name = "btn_first";
            this.btn_first.UseVisualStyleBackColor = true;
            this.btn_first.Click += new System.EventHandler(this.btn_first_Click);
            // 
            // btn_del
            // 
            this.btn_del.Image = global::Student.Properties.Resources.DeleteHS;
            resources.ApplyResources(this.btn_del, "btn_del");
            this.btn_del.Name = "btn_del";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_last
            // 
            this.btn_last.Image = global::Student.Properties.Resources.DataContainer_MoveLastHS;
            resources.ApplyResources(this.btn_last, "btn_last");
            this.btn_last.Name = "btn_last";
            this.btn_last.UseVisualStyleBackColor = true;
            this.btn_last.Click += new System.EventHandler(this.btn_last_Click);
            // 
            // btn_prev
            // 
            this.btn_prev.Image = global::Student.Properties.Resources.DataContainer_MovePreviousHS;
            resources.ApplyResources(this.btn_prev, "btn_prev");
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.UseVisualStyleBackColor = true;
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // btn_next
            // 
            this.btn_next.Image = global::Student.Properties.Resources.DataContainer_MoveNextHS;
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
            this.Column3,
            this.column4});
            this.dataGrid.DataSource = this.dataTable1BindingSource;
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
            this.dataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellContentDoubleClick);
            this.dataGrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGrid_CellFormatting);
            this.dataGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGrid_KeyDown);
            this.dataGrid.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGrid_ColumnWidthChanged);
            this.dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellContentClick);
            // 
            // flp_f
            // 
            this.flp_f.Controls.Add(this.txt_classname_f);
            this.flp_f.Controls.Add(this.txt_lessonname_f);
            this.flp_f.Controls.Add(this.txt_date_f);
            resources.ApplyResources(this.flp_f, "flp_f");
            this.flp_f.Name = "flp_f";
            // 
            // txt_classname_f
            // 
            this.txt_classname_f.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txt_classname_f, "txt_classname_f");
            this.txt_classname_f.Name = "txt_classname_f";
            this.txt_classname_f.TextChanged += new System.EventHandler(this.actfilter);
            this.txt_classname_f.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextcontrol);
            this.txt_classname_f.Leave += new System.EventHandler(this.leavecolor);
            this.txt_classname_f.Enter += new System.EventHandler(this.entercolor);
            // 
            // txt_lessonname_f
            // 
            this.txt_lessonname_f.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txt_lessonname_f, "txt_lessonname_f");
            this.txt_lessonname_f.Name = "txt_lessonname_f";
            this.txt_lessonname_f.TextChanged += new System.EventHandler(this.actfilter);
            this.txt_lessonname_f.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextcontrol);
            this.txt_lessonname_f.Leave += new System.EventHandler(this.leavecolor);
            this.txt_lessonname_f.Enter += new System.EventHandler(this.entercolor);
            // 
            // txt_date_f
            // 
            this.txt_date_f.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txt_date_f, "txt_date_f");
            this.txt_date_f.Name = "txt_date_f";
            this.txt_date_f.TextChanged += new System.EventHandler(this.actfilter);
            this.txt_date_f.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_date_f_KeyDown);
            this.txt_date_f.Leave += new System.EventHandler(this.leavecolor);
            this.txt_date_f.Enter += new System.EventHandler(this.entercolor);
            // 
            // ds_score
            // 
            this.ds_score.DataSetName = "ds_score";
            this.ds_score.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grb_input
            // 
            this.grb_input.Controls.Add(this.cmb_classname);
            this.grb_input.Controls.Add(this.cmb_lessonname);
            this.grb_input.Controls.Add(this.txt_date);
            this.grb_input.Controls.Add(this.lbl_phone);
            this.grb_input.Controls.Add(this.lbl_lname);
            this.grb_input.Controls.Add(this.lbl_name);
            resources.ApplyResources(this.grb_input, "grb_input");
            this.grb_input.Name = "grb_input";
            this.grb_input.TabStop = false;
            // 
            // cmb_classname
            // 
            this.cmb_classname.DataSource = this.classBindingSource;
            this.cmb_classname.DisplayMember = "name";
            this.cmb_classname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_classname.FormattingEnabled = true;
            resources.ApplyResources(this.cmb_classname, "cmb_classname");
            this.cmb_classname.Name = "cmb_classname";
            this.cmb_classname.ValueMember = "idclass";
            this.cmb_classname.SelectedIndexChanged += new System.EventHandler(this.cmb_classname_SelectedIndexChanged);
            this.cmb_classname.Leave += new System.EventHandler(this.leavecolor);
            this.cmb_classname.Enter += new System.EventHandler(this.entercolor);
            this.cmb_classname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextcontrol);
            this.cmb_classname.TextChanged += new System.EventHandler(this.inputtxtchange);
            // 
            // classBindingSource
            // 
            this.classBindingSource.DataMember = "class";
            this.classBindingSource.DataSource = this.ds_score;
            this.classBindingSource.Sort = "name";
            this.classBindingSource.PositionChanged += new System.EventHandler(this.classBindingSource_PositionChanged);
            // 
            // cmb_lessonname
            // 
            this.cmb_lessonname.DataSource = this.lessonBindingSource;
            this.cmb_lessonname.DisplayMember = "name";
            this.cmb_lessonname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_lessonname.FormattingEnabled = true;
            resources.ApplyResources(this.cmb_lessonname, "cmb_lessonname");
            this.cmb_lessonname.Name = "cmb_lessonname";
            this.cmb_lessonname.ValueMember = "idlesson";
            this.cmb_lessonname.Leave += new System.EventHandler(this.leavecolor);
            this.cmb_lessonname.Enter += new System.EventHandler(this.entercolor);
            this.cmb_lessonname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextcontrol);
            this.cmb_lessonname.TextChanged += new System.EventHandler(this.inputtxtchange);
            // 
            // lessonBindingSource
            // 
            this.lessonBindingSource.DataMember = "lesson";
            this.lessonBindingSource.DataSource = this.ds_score;
            // 
            // txt_date
            // 
            resources.ApplyResources(this.txt_date, "txt_date");
            this.txt_date.Name = "txt_date";
            this.txt_date.ShortcutsEnabled = false;
            this.txt_date.TextChanged += new System.EventHandler(this.inputtxtchange);
            this.txt_date.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextcontrol);
            this.txt_date.Leave += new System.EventHandler(this.leavecolor);
            this.txt_date.Enter += new System.EventHandler(this.entercolor);
            // 
            // lbl_phone
            // 
            resources.ApplyResources(this.lbl_phone, "lbl_phone");
            this.lbl_phone.Name = "lbl_phone";
            // 
            // lbl_lname
            // 
            resources.ApplyResources(this.lbl_lname, "lbl_lname");
            this.lbl_lname.Name = "lbl_lname";
            // 
            // lbl_name
            // 
            resources.ApplyResources(this.lbl_name, "lbl_name");
            this.lbl_name.Name = "lbl_name";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_exit
            // 
            this.btn_exit.Image = global::Student.Properties.Resources.ExitH51;
            resources.ApplyResources(this.btn_exit, "btn_exit");
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_save
            // 
            resources.ApplyResources(this.btn_save, "btn_save");
            this.btn_save.Image = global::Student.Properties.Resources.small_save;
            this.btn_save.Name = "btn_save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_new
            // 
            resources.ApplyResources(this.btn_new, "btn_new");
            this.btn_new.Image = global::Student.Properties.Resources.new_bookmark;
            this.btn_new.Name = "btn_new";
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
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // classTableAdapter
            // 
            this.classTableAdapter.ClearBeforeFill = true;
            // 
            // lessonTableAdapter
            // 
            this.lessonTableAdapter.ClearBeforeFill = true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "classname";
            resources.ApplyResources(this.Column1, "Column1");
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "name";
            resources.ApplyResources(this.Column2, "Column2");
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "date";
            dataGridViewCellStyle1.NullValue = null;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.Column3, "Column3");
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // column4
            // 
            this.column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            resources.ApplyResources(this.column4, "column4");
            this.column4.Name = "column4";
            this.column4.ReadOnly = true;
            this.column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.column4.Text = "انتخاب";
            this.column4.UseColumnTextForButtonValue = true;
            // 
            // frm_test
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.grb_input);
            this.Controls.Add(this.pnl_datagride);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_test";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.frm_phone_Load);
            this.Shown += new System.EventHandler(this.frm_test_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_phone_KeyDown);
            this.pnl_datagride.ResumeLayout(false);
            this.pnl_prba.ResumeLayout(false);
            this.pnl_prba.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pib_prba)).EndInit();
            this.pnl_nav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            this.flp_f.ResumeLayout(false);
            this.flp_f.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds_score)).EndInit();
            this.grb_input.ResumeLayout(false);
            this.grb_input.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_datagride;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button btn_last;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.Button btn_first;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.GroupBox grb_input;
        private System.Windows.Forms.Panel pnl_nav;
        private System.Windows.Forms.Label lbl_lname;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.FlowLayoutPanel flp_f;
        //private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn lnameDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn idphoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.TextBox txt_date;
        private System.Windows.Forms.TextBox txt_classname_f;
        private System.Windows.Forms.TextBox txt_lessonname_f;
        private System.Windows.Forms.TextBox txt_date_f;
        private System.ComponentModel.BackgroundWorker backgroundWorker_s;
        private System.Windows.Forms.ProgressBar prba;
        private System.Windows.Forms.Panel pnl_prba;
        private System.Windows.Forms.Label lbl_prba1;
        private System.Windows.Forms.Label lbl_prba2;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox pib_prba;
        private DataSet.ds_score ds_score;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private Student.DataSet.ds_scoreTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private System.Windows.Forms.ComboBox cmb_classname;
        private System.Windows.Forms.ComboBox cmb_lessonname;
        private System.Windows.Forms.BindingSource classBindingSource;
        private Student.DataSet.ds_scoreTableAdapters.classTableAdapter classTableAdapter;
        private System.Windows.Forms.BindingSource lessonBindingSource;
        private Student.DataSet.ds_scoreTableAdapters.lessonTableAdapter lessonTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewButtonColumn column4;
    }
}

