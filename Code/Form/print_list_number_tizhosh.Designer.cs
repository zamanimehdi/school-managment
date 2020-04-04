namespace Student
{
    partial class print_list_number
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(print_list_number));
            this.btn_preview = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_min = new System.Windows.Forms.RadioButton();
            this.rb_max = new System.Windows.Forms.RadioButton();
            this.rb_avg = new System.Windows.Forms.RadioButton();
            this.txt_head = new System.Windows.Forms.TextBox();
            this.d2 = new System.Windows.Forms.TextBox();
            this.d1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idlessonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lessonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsp_list_number_tizhoshan = new Student.DataSet.dsp_list_number_tizhoshan();
            this.cmb_class = new System.Windows.Forms.ComboBox();
            this.classBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.classTableAdapter = new Student.DataSet.dsp_list_number_tizhoshanTableAdapters.classTableAdapter();
            this.lessonTableAdapter = new Student.DataSet.dsp_list_number_tizhoshanTableAdapters.lessonTableAdapter();
            this.tblistnumberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_list_numberTableAdapter = new Student.DataSet.dsp_list_number_tizhoshanTableAdapters.tb_list_numberTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rb_sort_id = new System.Windows.Forms.RadioButton();
            this.rb_sort_lname = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsp_list_number_tizhoshan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblistnumberBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_preview
            // 
            this.btn_preview.Image = ((System.Drawing.Image)(resources.GetObject("btn_preview.Image")));
            this.btn_preview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_preview.Location = new System.Drawing.Point(125, 502);
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
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.panel1);
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
            this.groupBox2.Size = new System.Drawing.Size(349, 489);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // rb_min
            // 
            this.rb_min.AutoSize = true;
            this.rb_min.Location = new System.Drawing.Point(105, 60);
            this.rb_min.Name = "rb_min";
            this.rb_min.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rb_min.Size = new System.Drawing.Size(202, 18);
            this.rb_min.TabIndex = 4;
            this.rb_min.Text = "نمایش پایین ترین نمره در بازه زمانی";
            this.rb_min.UseVisualStyleBackColor = true;
            // 
            // rb_max
            // 
            this.rb_max.AutoSize = true;
            this.rb_max.Location = new System.Drawing.Point(118, 36);
            this.rb_max.Name = "rb_max";
            this.rb_max.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rb_max.Size = new System.Drawing.Size(189, 18);
            this.rb_max.TabIndex = 4;
            this.rb_max.Text = "نمایش بالاترین نمره در بازه زمانی";
            this.rb_max.UseVisualStyleBackColor = true;
            // 
            // rb_avg
            // 
            this.rb_avg.AutoSize = true;
            this.rb_avg.Checked = true;
            this.rb_avg.Location = new System.Drawing.Point(109, 12);
            this.rb_avg.Name = "rb_avg";
            this.rb_avg.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rb_avg.Size = new System.Drawing.Size(198, 18);
            this.rb_avg.TabIndex = 4;
            this.rb_avg.TabStop = true;
            this.rb_avg.Text = "نمایش میانگین نمرات در بازه زمانی";
            this.rb_avg.UseVisualStyleBackColor = true;
            // 
            // txt_head
            // 
            this.txt_head.Location = new System.Drawing.Point(13, 454);
            this.txt_head.MaxLength = 500;
            this.txt_head.Name = "txt_head";
            this.txt_head.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_head.Size = new System.Drawing.Size(222, 22);
            this.txt_head.TabIndex = 3;
            // 
            // d2
            // 
            this.d2.Location = new System.Drawing.Point(35, 53);
            this.d2.MaxLength = 6;
            this.d2.Name = "d2";
            this.d2.Size = new System.Drawing.Size(83, 22);
            this.d2.TabIndex = 3;
            // 
            // d1
            // 
            this.d1.AcceptsReturn = true;
            this.d1.Location = new System.Drawing.Point(168, 53);
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
            this.idlessonDataGridViewTextBoxColumn,
            this.Column1,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.lessonBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 241);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(319, 201);
            this.dataGridView1.TabIndex = 2;
            // 
            // idlessonDataGridViewTextBoxColumn
            // 
            this.idlessonDataGridViewTextBoxColumn.DataPropertyName = "idlesson";
            this.idlessonDataGridViewTextBoxColumn.HeaderText = "idlesson";
            this.idlessonDataGridViewTextBoxColumn.Name = "idlessonDataGridViewTextBoxColumn";
            this.idlessonDataGridViewTextBoxColumn.Visible = false;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column1.DataPropertyName = "chk";
            this.Column1.HeaderText = "انتخاب";
            this.Column1.Name = "Column1";
            this.Column1.Width = 45;
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
            this.lessonBindingSource.DataSource = this.dsp_list_number_tizhoshan;
            // 
            // dsp_list_number_tizhoshan
            // 
            this.dsp_list_number_tizhoshan.DataSetName = "dsp_list_number_tizhoshan";
            this.dsp_list_number_tizhoshan.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmb_class
            // 
            this.cmb_class.DataSource = this.classBindingSource;
            this.cmb_class.DisplayMember = "name";
            this.cmb_class.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_class.FormattingEnabled = true;
            this.cmb_class.Location = new System.Drawing.Point(35, 23);
            this.cmb_class.Name = "cmb_class";
            this.cmb_class.Size = new System.Drawing.Size(216, 22);
            this.cmb_class.TabIndex = 1;
            this.cmb_class.ValueMember = "idclass";
            // 
            // classBindingSource
            // 
            this.classBindingSource.DataMember = "class";
            this.classBindingSource.DataSource = this.dsp_list_number_tizhoshan;
            this.classBindingSource.PositionChanged += new System.EventHandler(this.classBindingSource_PositionChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 14);
            this.label3.TabIndex = 0;
            this.label3.Text = "تا تاریخ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(241, 457);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 14);
            this.label4.TabIndex = 0;
            this.label4.Text = "متن بالای گزارش";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "از تاریخ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "انتخاب کلاس ";
            // 
            // btn_exit
            // 
            this.btn_exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_exit.Image")));
            this.btn_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exit.Location = new System.Drawing.Point(15, 502);
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
            // lessonTableAdapter
            // 
            this.lessonTableAdapter.ClearBeforeFill = true;
            // 
            // tblistnumberBindingSource
            // 
            this.tblistnumberBindingSource.DataMember = "tb_list_number";
            this.tblistnumberBindingSource.DataSource = this.dsp_list_number_tizhoshan;
            // 
            // tb_list_numberTableAdapter
            // 
            this.tb_list_numberTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rb_avg);
            this.panel1.Controls.Add(this.rb_min);
            this.panel1.Controls.Add(this.rb_max);
            this.panel1.Location = new System.Drawing.Point(13, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 90);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.rb_sort_lname);
            this.panel2.Controls.Add(this.rb_sort_id);
            this.panel2.Location = new System.Drawing.Point(13, 177);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(319, 58);
            this.panel2.TabIndex = 6;
            // 
            // rb_sort_id
            // 
            this.rb_sort_id.AutoSize = true;
            this.rb_sort_id.Checked = true;
            this.rb_sort_id.Location = new System.Drawing.Point(110, 29);
            this.rb_sort_id.Name = "rb_sort_id";
            this.rb_sort_id.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rb_sort_id.Size = new System.Drawing.Size(98, 18);
            this.rb_sort_id.TabIndex = 0;
            this.rb_sort_id.TabStop = true;
            this.rb_sort_id.Text = "کد دانش‌آموزی";
            this.rb_sort_id.UseVisualStyleBackColor = true;
            // 
            // rb_sort_lname
            // 
            this.rb_sort_lname.AutoSize = true;
            this.rb_sort_lname.Location = new System.Drawing.Point(9, 29);
            this.rb_sort_lname.Name = "rb_sort_lname";
            this.rb_sort_lname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rb_sort_lname.Size = new System.Drawing.Size(90, 18);
            this.rb_sort_lname.TabIndex = 0;
            this.rb_sort_lname.Text = "نام خانوادگی";
            this.rb_sort_lname.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(192, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 14);
            this.label5.TabIndex = 1;
            this.label5.Text = "مرتب سازی بر اساس";
            // 
            // print_list_number
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(388, 552);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_preview);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "print_list_number";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "لیست نمرات";
            this.Load += new System.EventHandler(this.print_list_number_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsp_list_number_tizhoshan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblistnumberBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_preview;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.ComboBox cmb_class;
        private System.Windows.Forms.Label label1;
        private Student.DataSet.dsp_list_number_tizhoshan dsp_list_number_tizhoshan;
        private System.Windows.Forms.BindingSource classBindingSource;
        private Student.DataSet.dsp_list_number_tizhoshanTableAdapters.classTableAdapter classTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource lessonBindingSource;
        private Student.DataSet.dsp_list_number_tizhoshanTableAdapters.lessonTableAdapter lessonTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idlessonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox d2;
        private System.Windows.Forms.TextBox d1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource tblistnumberBindingSource;
        private Student.DataSet.dsp_list_number_tizhoshanTableAdapters.tb_list_numberTableAdapter tb_list_numberTableAdapter;
        private System.Windows.Forms.RadioButton rb_min;
        private System.Windows.Forms.RadioButton rb_max;
        private System.Windows.Forms.RadioButton rb_avg;
        private System.Windows.Forms.TextBox txt_head;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rb_sort_lname;
        private System.Windows.Forms.RadioButton rb_sort_id;
        private System.Windows.Forms.Panel panel1;
    }
}