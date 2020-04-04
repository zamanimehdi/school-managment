namespace Student
{
    partial class frm_inputnumber
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_datagride = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_prba = new System.Windows.Forms.Panel();
            this.pib_prba = new System.Windows.Forms.PictureBox();
            this.lbl_prba2 = new System.Windows.Forms.Label();
            this.lbl_prba1 = new System.Windows.Forms.Label();
            this.prba = new System.Windows.Forms.ProgressBar();
            this.pnl_nav = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_first = new System.Windows.Forms.Button();
            this.btn_last = new System.Windows.Forms.Button();
            this.btn_prev = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flp_f = new System.Windows.Forms.FlowLayoutPanel();
            this.txt_idstudent_f = new System.Windows.Forms.TextBox();
            this.txt_name_f = new System.Windows.Forms.TextBox();
            this.txt_score_f = new System.Windows.Forms.TextBox();
            this.ds_inputnumber = new Student.DataSet.ds_inputnumber();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker_s = new System.ComponentModel.BackgroundWorker();
            this.grp_info = new System.Windows.Forms.GroupBox();
            this.lbl_class_info = new System.Windows.Forms.Label();
            this.lbl_data_info = new System.Windows.Forms.Label();
            this.lbl_lesson_info = new System.Windows.Forms.Label();
            this.scoreTableAdapter = new Student.DataSet.ds_inputnumberTableAdapters.scoreTableAdapter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.انضباتیToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_datagride.SuspendLayout();
            this.pnl_prba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pib_prba)).BeginInit();
            this.pnl_nav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreBindingSource)).BeginInit();
            this.flp_f.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds_inputnumber)).BeginInit();
            this.grp_info.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_datagride
            // 
            this.pnl_datagride.Controls.Add(this.label1);
            this.pnl_datagride.Controls.Add(this.pnl_prba);
            this.pnl_datagride.Controls.Add(this.pnl_nav);
            this.pnl_datagride.Controls.Add(this.dataGrid);
            this.pnl_datagride.Controls.Add(this.flp_f);
            this.pnl_datagride.Location = new System.Drawing.Point(12, 87);
            this.pnl_datagride.Name = "pnl_datagride";
            this.pnl_datagride.Size = new System.Drawing.Size(437, 445);
            this.pnl_datagride.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Beige;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(431, 381);
            this.label1.TabIndex = 4;
            this.label1.Text = "لــــطفا صبـــــر کنید ...";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
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
            this.pnl_prba.Location = new System.Drawing.Point(44, 147);
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
            this.pnl_nav.Controls.Add(this.label2);
            this.pnl_nav.Controls.Add(this.button1);
            this.pnl_nav.Controls.Add(this.btn_first);
            this.pnl_nav.Controls.Add(this.btn_last);
            this.pnl_nav.Controls.Add(this.btn_prev);
            this.pnl_nav.Controls.Add(this.btn_next);
            this.pnl_nav.Location = new System.Drawing.Point(3, 408);
            this.pnl_nav.Name = "pnl_nav";
            this.pnl_nav.Size = new System.Drawing.Size(431, 34);
            this.pnl_nav.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(303, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 42);
            this.label2.TabIndex = 6;
            this.label2.Text = "||";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 8F);
            this.button1.Location = new System.Drawing.Point(315, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "مورد انضباتی";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.btn_last.Location = new System.Drawing.Point(269, 1);
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
            this.btn_next.Location = new System.Drawing.Point(230, 1);
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
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGrid.DataSource = this.scoreBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dataGrid.Location = new System.Drawing.Point(3, 3);
            this.dataGrid.MultiSelect = false;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGrid.RowHeadersVisible = false;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(431, 381);
            this.dataGrid.StandardTab = true;
            this.dataGrid.TabIndex = 0;
            this.dataGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellValueChanged);
            this.dataGrid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGrid_MouseClick);
            this.dataGrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGrid_CellFormatting);
            this.dataGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellEndEdit);
            this.dataGrid.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGrid_DataError);
            this.dataGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGrid_KeyDown);
            this.dataGrid.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGrid_ColumnWidthChanged);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "idstudent";
            this.Column1.FillWeight = 90F;
            this.Column1.HeaderText = "شماره دانش آموزی";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "name";
            this.Column2.HeaderText = "نام و نام خانوادگی";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "score";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column3.FillWeight = 50F;
            this.Column3.HeaderText = "نمره";
            this.Column3.Name = "Column3";
            // 
            // flp_f
            // 
            this.flp_f.Controls.Add(this.txt_idstudent_f);
            this.flp_f.Controls.Add(this.txt_name_f);
            this.flp_f.Controls.Add(this.txt_score_f);
            this.flp_f.Location = new System.Drawing.Point(3, 385);
            this.flp_f.Name = "flp_f";
            this.flp_f.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flp_f.Size = new System.Drawing.Size(431, 25);
            this.flp_f.TabIndex = 1;
            // 
            // txt_idstudent_f
            // 
            this.txt_idstudent_f.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_idstudent_f.Location = new System.Drawing.Point(366, 0);
            this.txt_idstudent_f.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.txt_idstudent_f.Name = "txt_idstudent_f";
            this.txt_idstudent_f.Size = new System.Drawing.Size(65, 22);
            this.txt_idstudent_f.TabIndex = 0;
            this.txt_idstudent_f.TextChanged += new System.EventHandler(this.actfilter);
            this.txt_idstudent_f.Leave += new System.EventHandler(this.leavecolor);
            this.txt_idstudent_f.Enter += new System.EventHandler(this.entercolor);
            // 
            // txt_name_f
            // 
            this.txt_name_f.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_name_f.Location = new System.Drawing.Point(300, 0);
            this.txt_name_f.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.txt_name_f.Name = "txt_name_f";
            this.txt_name_f.Size = new System.Drawing.Size(65, 22);
            this.txt_name_f.TabIndex = 2;
            this.txt_name_f.TextChanged += new System.EventHandler(this.actfilter);
            this.txt_name_f.Leave += new System.EventHandler(this.leavecolor);
            this.txt_name_f.Enter += new System.EventHandler(this.entercolor);
            // 
            // txt_score_f
            // 
            this.txt_score_f.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_score_f.Location = new System.Drawing.Point(249, 0);
            this.txt_score_f.Margin = new System.Windows.Forms.Padding(0);
            this.txt_score_f.Name = "txt_score_f";
            this.txt_score_f.Size = new System.Drawing.Size(50, 22);
            this.txt_score_f.TabIndex = 1;
            this.txt_score_f.TextChanged += new System.EventHandler(this.actfilter);
            this.txt_score_f.Leave += new System.EventHandler(this.leavecolor);
            this.txt_score_f.Enter += new System.EventHandler(this.entercolor);
            // 
            // ds_inputnumber
            // 
            this.ds_inputnumber.DataSetName = "ds_inputnumber";
            this.ds_inputnumber.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_exit
            // 
            this.btn_exit.Image = global::Student.Properties.Resources.ExitH51;
            this.btn_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_exit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_exit.Location = new System.Drawing.Point(12, 538);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(87, 40);
            this.btn_exit.TabIndex = 2;
            this.btn_exit.Text = "بازگشت";
            this.btn_exit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_save
            // 
            this.btn_save.Image = global::Student.Properties.Resources.small_save;
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_save.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_save.Location = new System.Drawing.Point(114, 538);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(87, 40);
            this.btn_save.TabIndex = 1;
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
            // grp_info
            // 
            this.grp_info.Controls.Add(this.lbl_class_info);
            this.grp_info.Controls.Add(this.lbl_data_info);
            this.grp_info.Controls.Add(this.lbl_lesson_info);
            this.grp_info.Location = new System.Drawing.Point(15, 12);
            this.grp_info.Name = "grp_info";
            this.grp_info.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grp_info.Size = new System.Drawing.Size(434, 69);
            this.grp_info.TabIndex = 11;
            this.grp_info.TabStop = false;
            this.grp_info.Text = "اطلاعات امتحان";
            // 
            // lbl_class_info
            // 
            this.lbl_class_info.Location = new System.Drawing.Point(316, 27);
            this.lbl_class_info.Name = "lbl_class_info";
            this.lbl_class_info.Size = new System.Drawing.Size(103, 17);
            this.lbl_class_info.TabIndex = 0;
            this.lbl_class_info.Text = "کلاس :";
            // 
            // lbl_data_info
            // 
            this.lbl_data_info.Location = new System.Drawing.Point(6, 27);
            this.lbl_data_info.Name = "lbl_data_info";
            this.lbl_data_info.Size = new System.Drawing.Size(99, 17);
            this.lbl_data_info.TabIndex = 0;
            this.lbl_data_info.Text = "تاریخ :";
            // 
            // lbl_lesson_info
            // 
            this.lbl_lesson_info.Location = new System.Drawing.Point(136, 27);
            this.lbl_lesson_info.Name = "lbl_lesson_info";
            this.lbl_lesson_info.Size = new System.Drawing.Size(158, 33);
            this.lbl_lesson_info.TabIndex = 0;
            this.lbl_lesson_info.Text = "ماده امتحانی :";
            // 
            // scoreTableAdapter
            // 
            this.scoreTableAdapter.ClearBeforeFill = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.انضباتیToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(111, 26);
            // 
            // انضباتیToolStripMenuItem
            // 
            this.انضباتیToolStripMenuItem.Name = "انضباتیToolStripMenuItem";
            this.انضباتیToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.انضباتیToolStripMenuItem.Text = "انضباتی";
            this.انضباتیToolStripMenuItem.Click += new System.EventHandler(this.انضباتیToolStripMenuItem_Click);
            // 
            // frm_inputnumber
            // 
            this.AcceptButton = this.btn_save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(461, 590);
            this.Controls.Add(this.grp_info);
            this.Controls.Add(this.pnl_datagride);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_save);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_inputnumber";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_inputnumber_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_DataTable1_KeyDown);
            this.pnl_datagride.ResumeLayout(false);
            this.pnl_prba.ResumeLayout(false);
            this.pnl_prba.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pib_prba)).EndInit();
            this.pnl_nav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreBindingSource)).EndInit();
            this.flp_f.ResumeLayout(false);
            this.flp_f.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds_inputnumber)).EndInit();
            this.grp_info.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

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
        private System.Windows.Forms.TextBox txt_idstudent_f;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.ComponentModel.BackgroundWorker backgroundWorker_s;
        private System.Windows.Forms.TextBox txt_score_f;
        private System.Windows.Forms.TextBox txt_name_f;
        private System.Windows.Forms.GroupBox grp_info;
        private Student.DataSet.ds_inputnumber ds_inputnumber;
        private System.Windows.Forms.BindingSource scoreBindingSource;
        private Student.DataSet.ds_inputnumberTableAdapters.scoreTableAdapter scoreTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_class_info;
        private System.Windows.Forms.Label lbl_data_info;
        private System.Windows.Forms.Label lbl_lesson_info;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem انضباتیToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}

