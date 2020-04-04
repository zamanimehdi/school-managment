namespace Student
{
    partial class frm_print_hamahang
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
            this.btn_preview = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmb_emtehan = new System.Windows.Forms.ComboBox();
            this.hamahangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsp_hhamahang_report = new Student.DataSet.dsp_hhamahang_report();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_typereport = new System.Windows.Forms.ComboBox();
            this.cmb_class = new System.Windows.Forms.ComboBox();
            this.classBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.classTableAdapter = new Student.DataSet.dsp_hhamahang_reportTableAdapters.classTableAdapter();
            this.hamahangTableAdapter = new Student.DataSet.dsp_hhamahang_reportTableAdapters.hamahangTableAdapter();
            this.hamahang0BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hamahang_0TableAdapter = new Student.DataSet.dsp_hhamahang_reportTableAdapters.hamahang_0TableAdapter();
            this.lessonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lessonTableAdapter = new Student.DataSet.dsp_hhamahang_reportTableAdapters.lessonTableAdapter();
            this.hamahang0mianginclassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hamahang_0_mianginclassTableAdapter = new Student.DataSet.dsp_hhamahang_reportTableAdapters.hamahang_0_mianginclassTableAdapter();
            this.dorosreportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doros_reportTableAdapter = new Student.DataSet.dsp_hhamahang_reportTableAdapters.doros_reportTableAdapter();
            this.hamahang0mianginpayeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hamahang_0_mianginpayeTableAdapter = new Student.DataSet.dsp_hhamahang_reportTableAdapters.hamahang_0_mianginpayeTableAdapter();
            this.dsp_hamahang_st_sort = new Student.DataSet.dsp_hamahang_st_sort();
            this.dsphamahangstsortBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsp_hamahang_st_sortTableAdapter = new Student.DataSet.dsp_hamahang_st_sortTableAdapters.dsp_hamahang_st_sortTableAdapter();
            this.dsp_hamahang_listnumber = new Student.DataSet.dsp_hamahang_listnumber();
            this.dtscorsinhamahangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dt_scors_in_hamahangTableAdapter = new Student.DataSet.dsp_hamahang_listnumberTableAdapters.dt_scors_in_hamahangTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hamahangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsp_hhamahang_report)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hamahang0BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hamahang0mianginclassBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dorosreportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hamahang0mianginpayeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsp_hamahang_st_sort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsphamahangstsortBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsp_hamahang_listnumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtscorsinhamahangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_preview
            // 
            this.btn_preview.Image = global::Student.Properties.Resources.previewp;
            this.btn_preview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_preview.Location = new System.Drawing.Point(125, 183);
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
            this.groupBox2.Controls.Add(this.cmb_emtehan);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cmb_typereport);
            this.groupBox2.Controls.Add(this.cmb_class);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(15, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(408, 159);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // cmb_emtehan
            // 
            this.cmb_emtehan.DataSource = this.hamahangBindingSource;
            this.cmb_emtehan.DisplayMember = "name";
            this.cmb_emtehan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_emtehan.FormattingEnabled = true;
            this.cmb_emtehan.Location = new System.Drawing.Point(110, 34);
            this.cmb_emtehan.Name = "cmb_emtehan";
            this.cmb_emtehan.Size = new System.Drawing.Size(203, 22);
            this.cmb_emtehan.TabIndex = 4;
            this.cmb_emtehan.ValueMember = "id";
            // 
            // hamahangBindingSource
            // 
            this.hamahangBindingSource.DataMember = "hamahang";
            this.hamahangBindingSource.DataSource = this.dsp_hhamahang_report;
            // 
            // dsp_hhamahang_report
            // 
            this.dsp_hhamahang_report.DataSetName = "dsp_hhamahang_report";
            this.dsp_hhamahang_report.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(319, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "امتحانات";
            // 
            // cmb_typereport
            // 
            this.cmb_typereport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_typereport.FormattingEnabled = true;
            this.cmb_typereport.Items.AddRange(new object[] {
            "چاپ کارنامه دانش آموزان - الف",
            "چاپ کارنامه دانش آموزان - ب",
            "گزارش بر اساس  معدل دروس",
            "مرتب سازی دانش آموزان بر اساس معدل",
            "لیست نمرات"});
            this.cmb_typereport.Location = new System.Drawing.Point(72, 106);
            this.cmb_typereport.Name = "cmb_typereport";
            this.cmb_typereport.Size = new System.Drawing.Size(241, 22);
            this.cmb_typereport.TabIndex = 2;
            // 
            // cmb_class
            // 
            this.cmb_class.DataSource = this.classBindingSource;
            this.cmb_class.DisplayMember = "class";
            this.cmb_class.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_class.FormattingEnabled = true;
            this.cmb_class.Location = new System.Drawing.Point(164, 70);
            this.cmb_class.Name = "cmb_class";
            this.cmb_class.Size = new System.Drawing.Size(149, 22);
            this.cmb_class.TabIndex = 1;
            this.cmb_class.ValueMember = "idclass";
            // 
            // classBindingSource
            // 
            this.classBindingSource.DataMember = "class";
            this.classBindingSource.DataSource = this.dsp_hhamahang_report;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "نوع گزارش";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "انتخاب کلاس ";
            // 
            // btn_exit
            // 
            this.btn_exit.Image = global::Student.Properties.Resources.ExitH51;
            this.btn_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exit.Location = new System.Drawing.Point(15, 183);
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
            // hamahangTableAdapter
            // 
            this.hamahangTableAdapter.ClearBeforeFill = true;
            // 
            // hamahang0BindingSource
            // 
            this.hamahang0BindingSource.DataMember = "hamahang_0";
            this.hamahang0BindingSource.DataSource = this.dsp_hhamahang_report;
            // 
            // hamahang_0TableAdapter
            // 
            this.hamahang_0TableAdapter.ClearBeforeFill = true;
            // 
            // lessonBindingSource
            // 
            this.lessonBindingSource.DataMember = "lesson";
            this.lessonBindingSource.DataSource = this.dsp_hhamahang_report;
            // 
            // lessonTableAdapter
            // 
            this.lessonTableAdapter.ClearBeforeFill = true;
            // 
            // hamahang0mianginclassBindingSource
            // 
            this.hamahang0mianginclassBindingSource.DataMember = "hamahang_0_mianginclass";
            this.hamahang0mianginclassBindingSource.DataSource = this.dsp_hhamahang_report;
            // 
            // hamahang_0_mianginclassTableAdapter
            // 
            this.hamahang_0_mianginclassTableAdapter.ClearBeforeFill = true;
            // 
            // dorosreportBindingSource
            // 
            this.dorosreportBindingSource.DataMember = "doros_report";
            this.dorosreportBindingSource.DataSource = this.dsp_hhamahang_report;
            // 
            // doros_reportTableAdapter
            // 
            this.doros_reportTableAdapter.ClearBeforeFill = true;
            // 
            // hamahang0mianginpayeBindingSource
            // 
            this.hamahang0mianginpayeBindingSource.DataMember = "hamahang_0_mianginpaye";
            this.hamahang0mianginpayeBindingSource.DataSource = this.dsp_hhamahang_report;
            // 
            // hamahang_0_mianginpayeTableAdapter
            // 
            this.hamahang_0_mianginpayeTableAdapter.ClearBeforeFill = true;
            // 
            // dsp_hamahang_st_sort
            // 
            this.dsp_hamahang_st_sort.DataSetName = "dsp_hamahang_st_sort";
            this.dsp_hamahang_st_sort.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsphamahangstsortBindingSource
            // 
            this.dsphamahangstsortBindingSource.DataMember = "dsp_hamahang_st_sort";
            this.dsphamahangstsortBindingSource.DataSource = this.dsp_hamahang_st_sort;
            // 
            // dsp_hamahang_st_sortTableAdapter
            // 
            this.dsp_hamahang_st_sortTableAdapter.ClearBeforeFill = true;
            // 
            // dsp_hamahang_listnumber
            // 
            this.dsp_hamahang_listnumber.DataSetName = "dsp_hamahang_listnumber";
            this.dsp_hamahang_listnumber.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtscorsinhamahangBindingSource
            // 
            this.dtscorsinhamahangBindingSource.DataMember = "dt_scors_in_hamahang";
            this.dtscorsinhamahangBindingSource.DataSource = this.dsp_hamahang_listnumber;
            // 
            // dt_scors_in_hamahangTableAdapter
            // 
            this.dt_scors_in_hamahangTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(299, 194);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(113, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "لطفا صبر کنید ...";
            this.label4.Visible = false;
            // 
            // frm_print_hamahang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(437, 243);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_preview);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_print_hamahang";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "گزارش گیری از امتحانات هماهنگ";
            this.Load += new System.EventHandler(this.print_lesson_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hamahangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsp_hhamahang_report)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hamahang0BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hamahang0mianginclassBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dorosreportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hamahang0mianginpayeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsp_hamahang_st_sort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsphamahangstsortBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsp_hamahang_listnumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtscorsinhamahangBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_preview;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.ComboBox cmb_class;
        private System.Windows.Forms.Label label1;
        private Student.DataSet.dsp_hhamahang_report dsp_hhamahang_report;
        private System.Windows.Forms.BindingSource classBindingSource;
        private Student.DataSet.dsp_hhamahang_reportTableAdapters.classTableAdapter classTableAdapter;
        private System.Windows.Forms.ComboBox cmb_typereport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_emtehan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource hamahangBindingSource;
        private Student.DataSet.dsp_hhamahang_reportTableAdapters.hamahangTableAdapter hamahangTableAdapter;
        private System.Windows.Forms.BindingSource hamahang0BindingSource;
        private Student.DataSet.dsp_hhamahang_reportTableAdapters.hamahang_0TableAdapter hamahang_0TableAdapter;
        private System.Windows.Forms.BindingSource lessonBindingSource;
        private Student.DataSet.dsp_hhamahang_reportTableAdapters.lessonTableAdapter lessonTableAdapter;
        private System.Windows.Forms.BindingSource hamahang0mianginclassBindingSource;
        private Student.DataSet.dsp_hhamahang_reportTableAdapters.hamahang_0_mianginclassTableAdapter hamahang_0_mianginclassTableAdapter;
        private System.Windows.Forms.BindingSource dorosreportBindingSource;
        private Student.DataSet.dsp_hhamahang_reportTableAdapters.doros_reportTableAdapter doros_reportTableAdapter;
        private System.Windows.Forms.BindingSource hamahang0mianginpayeBindingSource;
        private Student.DataSet.dsp_hhamahang_reportTableAdapters.hamahang_0_mianginpayeTableAdapter hamahang_0_mianginpayeTableAdapter;
        private Student.DataSet.dsp_hamahang_st_sort dsp_hamahang_st_sort;
        private System.Windows.Forms.BindingSource dsphamahangstsortBindingSource;
        private Student.DataSet.dsp_hamahang_st_sortTableAdapters.dsp_hamahang_st_sortTableAdapter dsp_hamahang_st_sortTableAdapter;
        private Student.DataSet.dsp_hamahang_listnumber dsp_hamahang_listnumber;
        private System.Windows.Forms.BindingSource dtscorsinhamahangBindingSource;
        private Student.DataSet.dsp_hamahang_listnumberTableAdapters.dt_scors_in_hamahangTableAdapter dt_scors_in_hamahangTableAdapter;
        private System.Windows.Forms.Label label4;
    }
}