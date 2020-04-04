namespace Student
{
    partial class frm_st_teacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_st_teacher));
            this.pnl_datagride = new System.Windows.Forms.Panel();
            this.pnl_prba = new System.Windows.Forms.Panel();
            this.pib_prba = new System.Windows.Forms.PictureBox();
            this.lbl_prba2 = new System.Windows.Forms.Label();
            this.lbl_prba1 = new System.Windows.Forms.Label();
            this.prba = new System.Windows.Forms.ProgressBar();
            this.pnl_nav = new System.Windows.Forms.Panel();
            this.btn_last = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_prev = new System.Windows.Forms.Button();
            this.btn_first = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flp_f = new System.Windows.Forms.FlowLayoutPanel();
            this.txt_idcode_f = new System.Windows.Forms.TextBox();
            this.txt_lname_f = new System.Windows.Forms.TextBox();
            this.txt_name_f = new System.Windows.Forms.TextBox();
            this.txt_tell_f = new System.Windows.Forms.TextBox();
            this.ds_teacher = new Student.DataSet.ds_teacher();
            this.btn_select = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.teacherTableAdapter = new Student.DataSet.ds_teacherTableAdapters.teacherTableAdapter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker_s = new System.ComponentModel.BackgroundWorker();
            this.dsp_teacherwork = new Student.DataSet.dsp_teacherwork();
            this.teacherworkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teacherworkTableAdapter = new Student.DataSet.dsp_teacherworkTableAdapters.teacherworkTableAdapter();
            this.pnl_datagride.SuspendLayout();
            this.pnl_prba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pib_prba)).BeginInit();
            this.pnl_nav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
            this.flp_f.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds_teacher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsp_teacherwork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherworkBindingSource)).BeginInit();
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
            this.pnl_datagride.Size = new System.Drawing.Size(420, 236);
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
            this.pnl_prba.Location = new System.Drawing.Point(61, 55);
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
            this.pnl_nav.Controls.Add(this.btn_prev);
            this.pnl_nav.Controls.Add(this.btn_first);
            this.pnl_nav.Location = new System.Drawing.Point(3, 201);
            this.pnl_nav.Name = "pnl_nav";
            this.pnl_nav.Size = new System.Drawing.Size(414, 32);
            this.pnl_nav.TabIndex = 2;
            // 
            // btn_last
            // 
            this.btn_last.Image = global::Student.Properties.Resources.DataContainer_MoveLastHS;
            this.btn_last.Location = new System.Drawing.Point(381, 1);
            this.btn_last.Name = "btn_last";
            this.btn_last.Size = new System.Drawing.Size(28, 28);
            this.btn_last.TabIndex = 0;
            this.btn_last.UseVisualStyleBackColor = true;
            this.btn_last.Click += new System.EventHandler(this.btn_last_Click);
            // 
            // btn_next
            // 
            this.btn_next.Image = global::Student.Properties.Resources.DataContainer_MoveNextHS;
            this.btn_next.Location = new System.Drawing.Point(347, 1);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(28, 28);
            this.btn_next.TabIndex = 1;
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
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
            this.Column5});
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
            this.dataGrid.Size = new System.Drawing.Size(414, 177);
            this.dataGrid.StandardTab = true;
            this.dataGrid.TabIndex = 0;
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
            // flp_f
            // 
            this.flp_f.Controls.Add(this.txt_idcode_f);
            this.flp_f.Controls.Add(this.txt_lname_f);
            this.flp_f.Controls.Add(this.txt_name_f);
            this.flp_f.Controls.Add(this.txt_tell_f);
            this.flp_f.Location = new System.Drawing.Point(3, 178);
            this.flp_f.Name = "flp_f";
            this.flp_f.Size = new System.Drawing.Size(414, 23);
            this.flp_f.TabIndex = 1;
            // 
            // txt_idcode_f
            // 
            this.txt_idcode_f.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_idcode_f.Location = new System.Drawing.Point(366, 0);
            this.txt_idcode_f.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.txt_idcode_f.Name = "txt_idcode_f";
            this.txt_idcode_f.Size = new System.Drawing.Size(48, 22);
            this.txt_idcode_f.TabIndex = 0;
            this.txt_idcode_f.Enter += new System.EventHandler(this.entercolor);
            this.txt_idcode_f.Leave += new System.EventHandler(this.leavecolor);
            this.txt_idcode_f.TextChanged += new System.EventHandler(this.actfilter);
            this.txt_idcode_f.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextcontrol);
            // 
            // txt_lname_f
            // 
            this.txt_lname_f.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_lname_f.Location = new System.Drawing.Point(265, 0);
            this.txt_lname_f.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.txt_lname_f.Name = "txt_lname_f";
            this.txt_lname_f.Size = new System.Drawing.Size(100, 22);
            this.txt_lname_f.TabIndex = 1;
            this.txt_lname_f.Enter += new System.EventHandler(this.entercolor);
            this.txt_lname_f.Leave += new System.EventHandler(this.leavecolor);
            this.txt_lname_f.TextChanged += new System.EventHandler(this.actfilter);
            this.txt_lname_f.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextcontrol);
            // 
            // txt_name_f
            // 
            this.txt_name_f.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_name_f.Location = new System.Drawing.Point(164, 0);
            this.txt_name_f.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.txt_name_f.Name = "txt_name_f";
            this.txt_name_f.Size = new System.Drawing.Size(100, 22);
            this.txt_name_f.TabIndex = 2;
            this.txt_name_f.Enter += new System.EventHandler(this.entercolor);
            this.txt_name_f.Leave += new System.EventHandler(this.leavecolor);
            this.txt_name_f.TextChanged += new System.EventHandler(this.actfilter);
            this.txt_name_f.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextcontrol);
            // 
            // txt_tell_f
            // 
            this.txt_tell_f.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_tell_f.Location = new System.Drawing.Point(63, 0);
            this.txt_tell_f.Margin = new System.Windows.Forms.Padding(0);
            this.txt_tell_f.Name = "txt_tell_f";
            this.txt_tell_f.Size = new System.Drawing.Size(100, 22);
            this.txt_tell_f.TabIndex = 3;
            this.txt_tell_f.Enter += new System.EventHandler(this.entercolor);
            this.txt_tell_f.Leave += new System.EventHandler(this.leavecolor);
            this.txt_tell_f.TextChanged += new System.EventHandler(this.actfilter);
            this.txt_tell_f.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextcontrol);
            // 
            // ds_teacher
            // 
            this.ds_teacher.DataSetName = "ds_teacher";
            this.ds_teacher.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_select
            // 
            this.btn_select.Enabled = false;
            this.btn_select.Image = global::Student.Properties.Resources.new_bookmark;
            this.btn_select.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_select.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_select.Location = new System.Drawing.Point(248, 254);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(75, 37);
            this.btn_select.TabIndex = 1;
            this.btn_select.Text = "انتخاب";
            this.btn_select.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_exit.Image")));
            this.btn_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_exit.Location = new System.Drawing.Point(114, 254);
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
            // dsp_teacherwork
            // 
            this.dsp_teacherwork.DataSetName = "dsp_teacherwork";
            this.dsp_teacherwork.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teacherworkBindingSource
            // 
            this.teacherworkBindingSource.DataMember = "teacherwork";
            this.teacherworkBindingSource.DataSource = this.dsp_teacherwork;
            // 
            // teacherworkTableAdapter
            // 
            this.teacherworkTableAdapter.ClearBeforeFill = true;
            // 
            // frm_st_teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(444, 300);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_select);
            this.Controls.Add(this.pnl_datagride);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_st_teacher";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Shown += new System.EventHandler(this.frm_st_teacher_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_st_teacher_KeyDown);
            this.Load += new System.EventHandler(this.frm_st_teacher_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.dsp_teacherwork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherworkBindingSource)).EndInit();
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
        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.Button btn_select;
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
        private Student.DataSet.dsp_teacherwork dsp_teacherwork;
        private System.Windows.Forms.BindingSource teacherworkBindingSource;
        private Student.DataSet.dsp_teacherworkTableAdapters.teacherworkTableAdapter teacherworkTableAdapter;
    }
}

