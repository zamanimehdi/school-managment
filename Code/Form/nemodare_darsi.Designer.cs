namespace Student
{
    partial class frm_nemodare_darsi
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
            this.btn_pre = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.txt_datef = new System.Windows.Forms.TextBox();
            this.txt_datet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rb_paye = new System.Windows.Forms.RadioButton();
            this.rb_class = new System.Windows.Forms.RadioButton();
            this.dsp_nemodar = new Student.DataSet.dsp_nemodar();
            this.nemmodarclassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nemmodarclassTableAdapter = new Student.DataSet.dsp_nemodarTableAdapters.nemmodarclassTableAdapter();
            this.nemodarpayeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nemodarpayeTableAdapter = new Student.DataSet.dsp_nemodarTableAdapters.nemodarpayeTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsp_nemodar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nemmodarclassBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nemodarpayeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_pre
            // 
            this.btn_pre.Image = global::Student.Properties.Resources.previewp;
            this.btn_pre.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_pre.Location = new System.Drawing.Point(99, 132);
            this.btn_pre.Name = "btn_pre";
            this.btn_pre.Size = new System.Drawing.Size(82, 31);
            this.btn_pre.TabIndex = 2;
            this.btn_pre.Text = "پیش نمایش";
            this.btn_pre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_pre.UseVisualStyleBackColor = true;
            this.btn_pre.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Image = global::Student.Properties.Resources.ExitH51;
            this.btn_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_exit.Location = new System.Drawing.Point(11, 132);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(82, 31);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.Text = "بازگشت";
            this.btn_exit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // txt_datef
            // 
            this.txt_datef.Location = new System.Drawing.Point(162, 21);
            this.txt_datef.MaxLength = 6;
            this.txt_datef.Name = "txt_datef";
            this.txt_datef.Size = new System.Drawing.Size(61, 21);
            this.txt_datef.TabIndex = 0;
            this.txt_datef.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_datef_KeyDown);
            this.txt_datef.Leave += new System.EventHandler(this.leavecolor);
            this.txt_datef.Enter += new System.EventHandler(this.entercolor);
            // 
            // txt_datet
            // 
            this.txt_datet.Location = new System.Drawing.Point(38, 21);
            this.txt_datet.MaxLength = 6;
            this.txt_datet.Name = "txt_datet";
            this.txt_datet.Size = new System.Drawing.Size(61, 21);
            this.txt_datet.TabIndex = 1;
            this.txt_datet.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_datet_KeyDown);
            this.txt_datet.Leave += new System.EventHandler(this.leavecolor);
            this.txt_datet.Enter += new System.EventHandler(this.entercolor);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "از تاریخ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "تا تاریخ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_datet);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_datef);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 56);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rb_paye);
            this.groupBox3.Controls.Add(this.rb_class);
            this.groupBox3.Location = new System.Drawing.Point(11, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(284, 56);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // rb_paye
            // 
            this.rb_paye.AutoSize = true;
            this.rb_paye.Location = new System.Drawing.Point(139, 24);
            this.rb_paye.Name = "rb_paye";
            this.rb_paye.Size = new System.Drawing.Size(40, 17);
            this.rb_paye.TabIndex = 0;
            this.rb_paye.Text = "پایه";
            this.rb_paye.UseVisualStyleBackColor = true;
            // 
            // rb_class
            // 
            this.rb_class.AutoSize = true;
            this.rb_class.Checked = true;
            this.rb_class.Location = new System.Drawing.Point(215, 24);
            this.rb_class.Name = "rb_class";
            this.rb_class.Size = new System.Drawing.Size(51, 17);
            this.rb_class.TabIndex = 0;
            this.rb_class.TabStop = true;
            this.rb_class.Text = "کلاس";
            this.rb_class.UseVisualStyleBackColor = true;
            this.rb_class.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // dsp_nemodar
            // 
            this.dsp_nemodar.DataSetName = "dsp_nemodar";
            this.dsp_nemodar.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nemmodarclassBindingSource
            // 
            this.nemmodarclassBindingSource.DataMember = "nemmodarclass";
            this.nemmodarclassBindingSource.DataSource = this.dsp_nemodar;
            // 
            // nemmodarclassTableAdapter
            // 
            this.nemmodarclassTableAdapter.ClearBeforeFill = true;
            // 
            // nemodarpayeBindingSource
            // 
            this.nemodarpayeBindingSource.DataMember = "nemodarpaye";
            this.nemodarpayeBindingSource.DataSource = this.dsp_nemodar;
            // 
            // nemodarpayeTableAdapter
            // 
            this.nemodarpayeTableAdapter.ClearBeforeFill = true;
            // 
            // frm_nemodare_darsi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(307, 172);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_pre);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_nemodare_darsi";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نمودار معدل";
            this.Load += new System.EventHandler(this.nemodare_darsi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsp_nemodar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nemmodarclassBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nemodarpayeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_pre;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.TextBox txt_datef;
        private System.Windows.Forms.TextBox txt_datet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Student.DataSet.dsp_nemodar dsp_nemodar;
        private System.Windows.Forms.BindingSource nemmodarclassBindingSource;
        private Student.DataSet.dsp_nemodarTableAdapters.nemmodarclassTableAdapter nemmodarclassTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rb_paye;
        private System.Windows.Forms.RadioButton rb_class;
        private System.Windows.Forms.BindingSource nemodarpayeBindingSource;
        private Student.DataSet.dsp_nemodarTableAdapters.nemodarpayeTableAdapter nemodarpayeTableAdapter;
    }
}