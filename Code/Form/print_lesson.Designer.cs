namespace Student
{
    partial class print_lesson
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_datet = new System.Windows.Forms.TextBox();
            this.txt_datef = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_lesson = new System.Windows.Forms.ComboBox();
            this.classBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsp_print_lesson = new Student.DataSet.dsp_print_lesson();
            this.btn_exit = new System.Windows.Forms.Button();
            this.classTableAdapter = new Student.DataSet.dsp_print_lessonTableAdapters.classTableAdapter();
            this.lessonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lessonTableAdapter = new Student.DataSet.dsp_print_lessonTableAdapters.lessonTableAdapter();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsp_print_lesson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_preview
            // 
            this.btn_preview.Image = global::Student.Properties.Resources.previewp;
            this.btn_preview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_preview.Location = new System.Drawing.Point(122, 106);
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
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_datet);
            this.groupBox2.Controls.Add(this.txt_datef);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cmb_lesson);
            this.groupBox2.Location = new System.Drawing.Point(12, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 82);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 14);
            this.label4.TabIndex = 10;
            this.label4.Text = "تا";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(231, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 14);
            this.label5.TabIndex = 11;
            this.label5.Text = "از تاریخ";
            // 
            // txt_datet
            // 
            this.txt_datet.Location = new System.Drawing.Point(28, 51);
            this.txt_datet.MaxLength = 6;
            this.txt_datet.Name = "txt_datet";
            this.txt_datet.Size = new System.Drawing.Size(86, 22);
            this.txt_datet.TabIndex = 14;
            // 
            // txt_datef
            // 
            this.txt_datef.Location = new System.Drawing.Point(140, 51);
            this.txt_datef.MaxLength = 6;
            this.txt_datef.Name = "txt_datef";
            this.txt_datef.Size = new System.Drawing.Size(85, 22);
            this.txt_datef.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "انتخاب کلاس";
            // 
            // cmb_lesson
            // 
            this.cmb_lesson.DataSource = this.classBindingSource;
            this.cmb_lesson.DisplayMember = "name";
            this.cmb_lesson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_lesson.FormattingEnabled = true;
            this.cmb_lesson.Location = new System.Drawing.Point(25, 22);
            this.cmb_lesson.Name = "cmb_lesson";
            this.cmb_lesson.Size = new System.Drawing.Size(167, 22);
            this.cmb_lesson.TabIndex = 12;
            this.cmb_lesson.ValueMember = "idclass";
            // 
            // classBindingSource
            // 
            this.classBindingSource.DataMember = "class";
            this.classBindingSource.DataSource = this.dsp_print_lesson;
            // 
            // dsp_print_lesson
            // 
            this.dsp_print_lesson.DataSetName = "dsp_print_lesson";
            this.dsp_print_lesson.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_exit
            // 
            this.btn_exit.Image = global::Student.Properties.Resources.ExitH51;
            this.btn_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exit.Location = new System.Drawing.Point(12, 106);
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
            // lessonBindingSource
            // 
            this.lessonBindingSource.DataMember = "lesson";
            this.lessonBindingSource.DataSource = this.dsp_print_lesson;
            // 
            // lessonTableAdapter
            // 
            this.lessonTableAdapter.ClearBeforeFill = true;
            // 
            // print_lesson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(321, 160);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_preview);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "print_lesson";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "گزارش گیری از دروس";
            this.Load += new System.EventHandler(this.print_lesson_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsp_print_lesson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_preview;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.ComboBox cmb_lesson;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_datet;
        private System.Windows.Forms.TextBox txt_datef;
        private Student.DataSet.dsp_print_lesson dsp_print_lesson;
        private System.Windows.Forms.BindingSource classBindingSource;
        private Student.DataSet.dsp_print_lessonTableAdapters.classTableAdapter classTableAdapter;
        private System.Windows.Forms.BindingSource lessonBindingSource;
        private Student.DataSet.dsp_print_lessonTableAdapters.lessonTableAdapter lessonTableAdapter;
    }
}