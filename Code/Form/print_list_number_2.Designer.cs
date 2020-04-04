namespace Student
{
    partial class print_list_number_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(print_list_number_2));
            this.btn_preview = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idlesson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lessonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsp_list_number2 = new Student.DataSet.dsp_list_number2();
            this.txt_head = new System.Windows.Forms.TextBox();
            this.d2 = new System.Windows.Forms.TextBox();
            this.d1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idstudentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idclassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stunameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmb_class = new System.Windows.Forms.ComboBox();
            this.classBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.classTableAdapter = new Student.DataSet.dsp_list_number2TableAdapters.classTableAdapter();
            this.studentTableAdapter = new Student.DataSet.dsp_list_number2TableAdapters.studentTableAdapter();
            this.tblistnumber2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_list_number2TableAdapter = new Student.DataSet.dsp_list_number2TableAdapters.tb_list_number2TableAdapter();
            this.lessonTableAdapter = new Student.DataSet.dsp_list_number2TableAdapters.lessonTableAdapter();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsp_list_number2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblistnumber2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_preview
            // 
            this.btn_preview.Image = ((System.Drawing.Image)(resources.GetObject("btn_preview.Image")));
            this.btn_preview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_preview.Location = new System.Drawing.Point(122, 415);
            this.btn_preview.Name = "btn_preview";
            this.btn_preview.Size = new System.Drawing.Size(96, 38);
            this.btn_preview.TabIndex = 20;
            this.btn_preview.Text = "پیش نمایش";
            this.btn_preview.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_preview.UseVisualStyleBackColor = true;
            this.btn_preview.Click += new System.EventHandler(this.btn_preview_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Controls.Add(this.txt_head);
            this.groupBox2.Controls.Add(this.d2);
            this.groupBox2.Controls.Add(this.d1);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.cmb_class);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(15, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(439, 402);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1,
            this.idlesson,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.lessonBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(15, 77);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(199, 281);
            this.dataGridView2.TabIndex = 4;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "chk";
            this.dataGridViewCheckBoxColumn1.HeaderText = "انتخاب";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 45;
            // 
            // idlesson
            // 
            this.idlesson.DataPropertyName = "idlesson";
            this.idlesson.HeaderText = "idlesson";
            this.idlesson.Name = "idlesson";
            this.idlesson.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "نام درس";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lessonBindingSource
            // 
            this.lessonBindingSource.DataMember = "lesson";
            this.lessonBindingSource.DataSource = this.dsp_list_number2;
            // 
            // dsp_list_number2
            // 
            this.dsp_list_number2.DataSetName = "dsp_list_number2";
            this.dsp_list_number2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_head
            // 
            this.txt_head.Location = new System.Drawing.Point(15, 364);
            this.txt_head.MaxLength = 500;
            this.txt_head.Name = "txt_head";
            this.txt_head.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_head.Size = new System.Drawing.Size(341, 22);
            this.txt_head.TabIndex = 3;
            // 
            // d2
            // 
            this.d2.Location = new System.Drawing.Point(132, 47);
            this.d2.MaxLength = 6;
            this.d2.Name = "d2";
            this.d2.Size = new System.Drawing.Size(83, 22);
            this.d2.TabIndex = 3;
            // 
            // d1
            // 
            this.d1.AcceptsReturn = true;
            this.d1.Location = new System.Drawing.Point(265, 47);
            this.d1.MaxLength = 6;
            this.d1.Name = "d1";
            this.d1.Size = new System.Drawing.Size(83, 22);
            this.d1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.idstudentDataGridViewTextBoxColumn,
            this.idclassDataGridViewTextBoxColumn,
            this.stunameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(220, 77);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(199, 281);
            this.dataGridView1.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column1.DataPropertyName = "chk";
            this.Column1.HeaderText = "انتخاب";
            this.Column1.Name = "Column1";
            this.Column1.Width = 45;
            // 
            // idstudentDataGridViewTextBoxColumn
            // 
            this.idstudentDataGridViewTextBoxColumn.DataPropertyName = "idstudent";
            this.idstudentDataGridViewTextBoxColumn.HeaderText = "idstudent";
            this.idstudentDataGridViewTextBoxColumn.Name = "idstudentDataGridViewTextBoxColumn";
            this.idstudentDataGridViewTextBoxColumn.Visible = false;
            // 
            // idclassDataGridViewTextBoxColumn
            // 
            this.idclassDataGridViewTextBoxColumn.DataPropertyName = "idclass";
            this.idclassDataGridViewTextBoxColumn.HeaderText = "idclass";
            this.idclassDataGridViewTextBoxColumn.Name = "idclassDataGridViewTextBoxColumn";
            this.idclassDataGridViewTextBoxColumn.Visible = false;
            // 
            // stunameDataGridViewTextBoxColumn
            // 
            this.stunameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stunameDataGridViewTextBoxColumn.DataPropertyName = "stu_name";
            this.stunameDataGridViewTextBoxColumn.HeaderText = "نام دانش آموز";
            this.stunameDataGridViewTextBoxColumn.Name = "stunameDataGridViewTextBoxColumn";
            this.stunameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "student";
            this.studentBindingSource.DataSource = this.dsp_list_number2;
            // 
            // cmb_class
            // 
            this.cmb_class.DataSource = this.classBindingSource;
            this.cmb_class.DisplayMember = "name";
            this.cmb_class.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_class.FormattingEnabled = true;
            this.cmb_class.Location = new System.Drawing.Point(132, 17);
            this.cmb_class.Name = "cmb_class";
            this.cmb_class.Size = new System.Drawing.Size(216, 22);
            this.cmb_class.TabIndex = 1;
            this.cmb_class.ValueMember = "idclass";
            // 
            // classBindingSource
            // 
            this.classBindingSource.DataMember = "class";
            this.classBindingSource.DataSource = this.dsp_list_number2;
            this.classBindingSource.PositionChanged += new System.EventHandler(this.classBindingSource_PositionChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 14);
            this.label3.TabIndex = 0;
            this.label3.Text = "تا تاریخ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(362, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 14);
            this.label4.TabIndex = 0;
            this.label4.Text = "زیر صفحه";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(352, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "از تاریخ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(352, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "انتخاب کلاس ";
            // 
            // btn_exit
            // 
            this.btn_exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_exit.Image")));
            this.btn_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exit.Location = new System.Drawing.Point(12, 415);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(96, 38);
            this.btn_exit.TabIndex = 21;
            this.btn_exit.Text = "بازگشت";
            this.btn_exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // classTableAdapter
            // 
            this.classTableAdapter.ClearBeforeFill = true;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // tblistnumber2BindingSource
            // 
            this.tblistnumber2BindingSource.DataMember = "tb_list_number2";
            this.tblistnumber2BindingSource.DataSource = this.dsp_list_number2;
            // 
            // tb_list_number2TableAdapter
            // 
            this.tb_list_number2TableAdapter.ClearBeforeFill = true;
            // 
            // lessonTableAdapter
            // 
            this.lessonTableAdapter.ClearBeforeFill = true;
            // 
            // print_list_number_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(474, 465);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_preview);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "print_list_number_2";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "لیست نمرات";
            this.Load += new System.EventHandler(this.print_list_number_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsp_list_number2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblistnumber2BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_preview;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.ComboBox cmb_class;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox d2;
        private System.Windows.Forms.TextBox d1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_head;
        private System.Windows.Forms.Label label4;
        private Student.DataSet.dsp_list_number2 dsp_list_number2;
        private System.Windows.Forms.BindingSource classBindingSource;
        private Student.DataSet.dsp_list_number2TableAdapters.classTableAdapter classTableAdapter;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private Student.DataSet.dsp_list_number2TableAdapters.studentTableAdapter studentTableAdapter;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idstudentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stunameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tblistnumber2BindingSource;
        private Student.DataSet.dsp_list_number2TableAdapters.tb_list_number2TableAdapter tb_list_number2TableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource lessonBindingSource;
        private Student.DataSet.dsp_list_number2TableAdapters.lessonTableAdapter lessonTableAdapter;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idlesson;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}