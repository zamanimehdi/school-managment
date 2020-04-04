namespace Student
{
    partial class frm_choosest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_choosest));
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
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.choosestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flp_f = new System.Windows.Forms.FlowLayoutPanel();
            this.txt_idstudent_f = new System.Windows.Forms.TextBox();
            this.txt_lname_f = new System.Windows.Forms.TextBox();
            this.txt_name_f = new System.Windows.Forms.TextBox();
            this.txt_tell_f = new System.Windows.Forms.TextBox();
            this.ds_choosest = new Student.DataSet.ds_choosest();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_select = new System.Windows.Forms.Button();
            this.backgroundWorker_s = new System.ComponentModel.BackgroundWorker();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_major = new System.Windows.Forms.Label();
            this.classBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_grade = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.choosestTableAdapter = new Student.DataSet.ds_choosestTableAdapters.choosestTableAdapter();
            this.classTableAdapter = new Student.DataSet.ds_choosestTableAdapters.classTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_preview = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnl_datagride.SuspendLayout();
            this.pnl_prba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pib_prba)).BeginInit();
            this.pnl_nav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.choosestBindingSource)).BeginInit();
            this.flp_f.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds_choosest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_datagride
            // 
            this.pnl_datagride.Controls.Add(this.panel2);
            this.pnl_datagride.Controls.Add(this.pnl_prba);
            this.pnl_datagride.Controls.Add(this.pnl_nav);
            this.pnl_datagride.Controls.Add(this.dataGrid);
            this.pnl_datagride.Controls.Add(this.flp_f);
            resources.ApplyResources(this.pnl_datagride, "pnl_datagride");
            this.pnl_datagride.Name = "pnl_datagride";
            this.pnl_datagride.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_datagride_Paint);
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
            this.Column3,
            this.Column2,
            this.Column4,
            this.Column1});
            this.dataGrid.DataSource = this.choosestBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid.DefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.dataGrid, "dataGrid");
            this.dataGrid.MultiSelect = false;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowHeadersVisible = false;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.StandardTab = true;
            this.dataGrid.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGrid_ColumnWidthChanged);
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "idstudent";
            this.Column3.FillWeight = 80F;
            resources.ApplyResources(this.Column3, "Column3");
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "lname";
            this.Column2.FillWeight = 60F;
            resources.ApplyResources(this.Column2, "Column2");
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column4.DataPropertyName = "name";
            this.Column4.FillWeight = 49F;
            resources.ApplyResources(this.Column4, "Column4");
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.DataPropertyName = "tell";
            this.Column1.FillWeight = 50.5753F;
            resources.ApplyResources(this.Column1, "Column1");
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // choosestBindingSource
            // 
            this.choosestBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.choosestBindingSource_ListChanged);
            // 
            // flp_f
            // 
            this.flp_f.Controls.Add(this.txt_idstudent_f);
            this.flp_f.Controls.Add(this.txt_lname_f);
            this.flp_f.Controls.Add(this.txt_name_f);
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
            // ds_choosest
            // 
            this.ds_choosest.DataSetName = "ds_choosest";
            this.ds_choosest.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.toolTip.SetToolTip(this.btn_exit, resources.GetString("btn_exit.ToolTip"));
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_select
            // 
            this.btn_select.Image = global::Student.Properties.Resources.new_bookmark;
            resources.ApplyResources(this.btn_select, "btn_select");
            this.btn_select.Name = "btn_select";
            this.toolTip.SetToolTip(this.btn_select, resources.GetString("btn_select.ToolTip"));
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
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
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // lbl_major
            // 
            this.lbl_major.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.classBindingSource, "majorname", true));
            this.lbl_major.ForeColor = System.Drawing.Color.Maroon;
            resources.ApplyResources(this.lbl_major, "lbl_major");
            this.lbl_major.Name = "lbl_major";
            // 
            // classBindingSource
            // 
            this.classBindingSource.DataMember = "class";
            this.classBindingSource.DataSource = this.ds_choosest;
            this.classBindingSource.Sort = "name";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // lbl_grade
            // 
            this.lbl_grade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.classBindingSource, "grade", true));
            this.lbl_grade.ForeColor = System.Drawing.Color.Maroon;
            resources.ApplyResources(this.lbl_grade, "lbl_grade");
            this.lbl_grade.Name = "lbl_grade";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.classBindingSource;
            this.comboBox1.DisplayMember = "name";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.ValueMember = "idclass";
            this.comboBox1.Leave += new System.EventHandler(this.leavecolor);
            this.comboBox1.Enter += new System.EventHandler(this.entercolor);
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.actfilter);
            // 
            // choosestTableAdapter
            // 
            this.choosestTableAdapter.ClearBeforeFill = true;
            // 
            // classTableAdapter
            // 
            this.classTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbl_grade);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbl_major);
            this.panel1.Name = "panel1";
            // 
            // timer3
            // 
            this.timer3.Interval = 2500;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // backgroundWorker3
            // 
            this.backgroundWorker3.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker3_DoWork);
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Student.Properties.Settings.Default, "behaviortofamily_txt", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            this.textBox1.Text = global::Student.Properties.Settings.Default.behaviortofamily_txt;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btn_preview);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textBox1);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // btn_preview
            // 
            this.btn_preview.Image = global::Student.Properties.Resources.previewp;
            resources.ApplyResources(this.btn_preview, "btn_preview");
            this.btn_preview.Name = "btn_preview";
            this.btn_preview.UseVisualStyleBackColor = true;
            this.btn_preview.Click += new System.EventHandler(this.btn_preview_Click);
            // 
            // button1
            // 
            this.button1.Image = global::Student.Properties.Resources.ExitH51;
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.toolTip.SetToolTip(this.button1, resources.GetString("button1.ToolTip"));
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_choosest
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.btn_select);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.pnl_datagride);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_choosest";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.frm_choosest_Load);
            this.Shown += new System.EventHandler(this.frm_choosest_Shown);
            this.pnl_datagride.ResumeLayout(false);
            this.pnl_prba.ResumeLayout(false);
            this.pnl_prba.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pib_prba)).EndInit();
            this.pnl_nav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.choosestBindingSource)).EndInit();
            this.flp_f.ResumeLayout(false);
            this.flp_f.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds_choosest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_datagride;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button btn_last;
        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.Button btn_first;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Panel pnl_nav;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.FlowLayoutPanel flp_f;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txt_idstudent_f;
        private System.Windows.Forms.TextBox txt_name_f;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TextBox txt_lname_f;
        private System.ComponentModel.BackgroundWorker backgroundWorker_s;
        private System.Windows.Forms.ProgressBar prba;
        private System.Windows.Forms.Panel pnl_prba;
        private System.Windows.Forms.Label lbl_prba1;
        private System.Windows.Forms.Label lbl_prba2;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox pib_prba;
        private DataSet.ds_choosest ds_choosest;
        private System.Windows.Forms.TextBox txt_tell_f;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_major;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_grade;
        //private System.Windows.Forms.DataGridViewTextBoxColumn idclassDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource choosestBindingSource;
        private Student.DataSet.ds_choosestTableAdapters.choosestTableAdapter choosestTableAdapter;
        private System.Windows.Forms.BindingSource classBindingSource;
        private Student.DataSet.ds_choosestTableAdapters.classTableAdapter classTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer3;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_preview;
        private System.Windows.Forms.Button button1;
    }
}

