namespace Student
{
    partial class frm_selectclass
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
            this.btn_select = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.classBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_class = new Student.DataSet.ds_class();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.classTableAdapter = new Student.DataSet.ds_classTableAdapters.classTableAdapter();
            this.grp_setting = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_b = new System.Windows.Forms.ComboBox();
            this.txt_datet = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_datef = new System.Windows.Forms.TextBox();
            this.rb_akhlagh = new System.Windows.Forms.RadioButton();
            this.rb_all = new System.Windows.Forms.RadioButton();
            this.dsp_behavclass = new Student.DataSet.dsp_behavclass();
            this.behaviorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.behaviorTableAdapter = new Student.DataSet.dsp_behavclassTableAdapters.behaviorTableAdapter();
            this.stBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stTableAdapter = new Student.DataSet.dsp_behavclassTableAdapters.stTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_class)).BeginInit();
            this.grp_setting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsp_behavclass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_select
            // 
            this.btn_select.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_select.Image = global::Student.Properties.Resources.a003838;
            this.btn_select.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_select.Location = new System.Drawing.Point(236, 199);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(85, 30);
            this.btn_select.TabIndex = 7;
            this.btn_select.Text = "انتخاب";
            this.btn_select.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.classBindingSource;
            this.comboBox1.DisplayMember = "name";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(95, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(161, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "idclass";
            // 
            // classBindingSource
            // 
            this.classBindingSource.DataMember = "class";
            this.classBindingSource.DataSource = this.ds_class;
            // 
            // ds_class
            // 
            this.ds_class.DataSetName = "ds_class";
            this.ds_class.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(262, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "انتخاب کلاس";
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::Student.Properties.Resources.ExitH51;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(145, 199);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 30);
            this.button2.TabIndex = 8;
            this.button2.Text = "بازگشت";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // classTableAdapter
            // 
            this.classTableAdapter.ClearBeforeFill = true;
            // 
            // grp_setting
            // 
            this.grp_setting.Controls.Add(this.label4);
            this.grp_setting.Controls.Add(this.cmb_b);
            this.grp_setting.Controls.Add(this.txt_datet);
            this.grp_setting.Controls.Add(this.label3);
            this.grp_setting.Controls.Add(this.label2);
            this.grp_setting.Controls.Add(this.txt_datef);
            this.grp_setting.Controls.Add(this.rb_akhlagh);
            this.grp_setting.Controls.Add(this.rb_all);
            this.grp_setting.Location = new System.Drawing.Point(12, 39);
            this.grp_setting.Name = "grp_setting";
            this.grp_setting.Size = new System.Drawing.Size(312, 154);
            this.grp_setting.TabIndex = 1;
            this.grp_setting.TabStop = false;
            this.grp_setting.Text = "تنظیمات";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(12, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(289, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "_______________________________________________";
            // 
            // cmb_b
            // 
            this.cmb_b.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_b.FormattingEnabled = true;
            this.cmb_b.Items.AddRange(new object[] {
            "تاخیر ورود به دبیرستان",
            "تاخیر ورود و خروج از کلاس",
            "اخراج از کلاس",
            "غیبت",
            "درگیری با دانش آموزان",
            "بی حرمتی به عوامل آموزشی",
            "وضع ظاهری",
            "سایر موارد 1",
            "سایر موارد 2",
            "سایر موارد 3",
            "سایر موارد 4",
            "سایر موارد 5",
            "سایر موارد 6",
            "سایر موارد 7",
            "سایر موارد 8",
            "سایر موارد 9",
            "سایر موارد 10"});
            this.cmb_b.Location = new System.Drawing.Point(12, 66);
            this.cmb_b.Name = "cmb_b";
            this.cmb_b.Size = new System.Drawing.Size(212, 21);
            this.cmb_b.TabIndex = 9;
            // 
            // txt_datet
            // 
            this.txt_datet.Location = new System.Drawing.Point(67, 118);
            this.txt_datet.MaxLength = 6;
            this.txt_datet.Name = "txt_datet";
            this.txt_datet.Size = new System.Drawing.Size(71, 21);
            this.txt_datet.TabIndex = 6;
            this.txt_datet.Leave += new System.EventHandler(this.leavecolor);
            this.txt_datet.Enter += new System.EventHandler(this.entercolor);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(140, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "تا تاریخ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(259, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "از تاریخ";
            // 
            // txt_datef
            // 
            this.txt_datef.Location = new System.Drawing.Point(183, 118);
            this.txt_datef.MaxLength = 6;
            this.txt_datef.Name = "txt_datef";
            this.txt_datef.Size = new System.Drawing.Size(70, 21);
            this.txt_datef.TabIndex = 5;
            this.txt_datef.Leave += new System.EventHandler(this.leavecolor);
            this.txt_datef.Enter += new System.EventHandler(this.entercolor);
            // 
            // rb_akhlagh
            // 
            this.rb_akhlagh.AutoSize = true;
            this.rb_akhlagh.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rb_akhlagh.Location = new System.Drawing.Point(159, 42);
            this.rb_akhlagh.Name = "rb_akhlagh";
            this.rb_akhlagh.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rb_akhlagh.Size = new System.Drawing.Size(144, 17);
            this.rb_akhlagh.TabIndex = 4;
            this.rb_akhlagh.Text = "نمایش موارد اخلاقی خاص";
            this.rb_akhlagh.UseVisualStyleBackColor = true;
            // 
            // rb_all
            // 
            this.rb_all.AutoSize = true;
            this.rb_all.Checked = true;
            this.rb_all.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rb_all.Location = new System.Drawing.Point(199, 22);
            this.rb_all.Name = "rb_all";
            this.rb_all.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rb_all.Size = new System.Drawing.Size(104, 17);
            this.rb_all.TabIndex = 2;
            this.rb_all.TabStop = true;
            this.rb_all.Text = "نمایش تمام موارد";
            this.rb_all.UseVisualStyleBackColor = true;
            // 
            // dsp_behavclass
            // 
            this.dsp_behavclass.DataSetName = "dsp_behavclass";
            this.dsp_behavclass.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // behaviorBindingSource
            // 
            this.behaviorBindingSource.DataMember = "behavior";
            this.behaviorBindingSource.DataSource = this.dsp_behavclass;
            // 
            // behaviorTableAdapter
            // 
            this.behaviorTableAdapter.ClearBeforeFill = true;
            // 
            // stBindingSource
            // 
            this.stBindingSource.DataMember = "st";
            this.stBindingSource.DataSource = this.dsp_behavclass;
            // 
            // stTableAdapter
            // 
            this.stTableAdapter.ClearBeforeFill = true;
            // 
            // frm_selectclass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(336, 241);
            this.Controls.Add(this.grp_setting);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_select);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_selectclass";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.selectclass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_class)).EndInit();
            this.grp_setting.ResumeLayout(false);
            this.grp_setting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsp_behavclass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private Student.DataSet.ds_class ds_class;
        private System.Windows.Forms.BindingSource classBindingSource;
        private Student.DataSet.ds_classTableAdapters.classTableAdapter classTableAdapter;
        private System.Windows.Forms.GroupBox grp_setting;
        private System.Windows.Forms.RadioButton rb_akhlagh;
        private System.Windows.Forms.RadioButton rb_all;
        private System.Windows.Forms.TextBox txt_datet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_datef;
        private Student.DataSet.dsp_behavclass dsp_behavclass;
        private System.Windows.Forms.BindingSource behaviorBindingSource;
        private Student.DataSet.dsp_behavclassTableAdapters.behaviorTableAdapter behaviorTableAdapter;
        private System.Windows.Forms.ComboBox cmb_b;
        private System.Windows.Forms.BindingSource stBindingSource;
        private Student.DataSet.dsp_behavclassTableAdapters.stTableAdapter stTableAdapter;
        private System.Windows.Forms.Label label4;
    }
}