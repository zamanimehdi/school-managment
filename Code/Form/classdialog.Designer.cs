namespace Student
{
    partial class frm_classdialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_classdialog));
            this.txt_classname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_major = new System.Windows.Forms.ComboBox();
            this.majorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_classdialog = new Student.DataSet.ds_classdialog();
            this.cmb_grade = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.majorTableAdapter = new Student.DataSet.ds_classdialogTableAdapters.majorTableAdapter();
            this.txt_vahed = new System.Windows.Forms.TextBox();
            this.lbl_vahed = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.majorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_classdialog)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_classname
            // 
            this.txt_classname.Location = new System.Drawing.Point(21, 36);
            this.txt_classname.MaxLength = 15;
            this.txt_classname.Name = "txt_classname";
            this.txt_classname.Size = new System.Drawing.Size(138, 22);
            this.txt_classname.TabIndex = 0;
            this.txt_classname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_classname_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(165, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "نام کلاس";
            // 
            // cmb_major
            // 
            this.cmb_major.DataSource = this.majorBindingSource;
            this.cmb_major.DisplayMember = "name";
            this.cmb_major.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_major.FormattingEnabled = true;
            this.cmb_major.Location = new System.Drawing.Point(21, 64);
            this.cmb_major.Name = "cmb_major";
            this.cmb_major.Size = new System.Drawing.Size(138, 22);
            this.cmb_major.TabIndex = 1;
            this.cmb_major.ValueMember = "idmajor";
            this.cmb_major.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_classname_KeyDown);
            // 
            // majorBindingSource
            // 
            this.majorBindingSource.DataMember = "major";
            this.majorBindingSource.DataSource = this.ds_classdialog;
            // 
            // ds_classdialog
            // 
            this.ds_classdialog.DataSetName = "ds_classdialog";
            this.ds_classdialog.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmb_grade
            // 
            this.cmb_grade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_grade.FormattingEnabled = true;
            this.cmb_grade.Location = new System.Drawing.Point(21, 92);
            this.cmb_grade.Name = "cmb_grade";
            this.cmb_grade.Size = new System.Drawing.Size(138, 22);
            this.cmb_grade.TabIndex = 2;
            this.cmb_grade.SelectedIndexChanged += new System.EventHandler(this.cmb_grade_SelectedIndexChanged);
            this.cmb_grade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_classname_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(165, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "رشته";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(165, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 14);
            this.label3.TabIndex = 1;
            this.label3.Text = "پایه";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(135, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "تایید";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(37, 130);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "انصراف";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // majorTableAdapter
            // 
            this.majorTableAdapter.ClearBeforeFill = true;
            // 
            // txt_vahed
            // 
            this.txt_vahed.Location = new System.Drawing.Point(21, 121);
            this.txt_vahed.MaxLength = 15;
            this.txt_vahed.Name = "txt_vahed";
            this.txt_vahed.Size = new System.Drawing.Size(138, 22);
            this.txt_vahed.TabIndex = 3;
            this.txt_vahed.Visible = false;
            this.txt_vahed.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_classname_KeyDown);
            // 
            // lbl_vahed
            // 
            this.lbl_vahed.AutoSize = true;
            this.lbl_vahed.BackColor = System.Drawing.Color.Transparent;
            this.lbl_vahed.Location = new System.Drawing.Point(165, 124);
            this.lbl_vahed.Name = "lbl_vahed";
            this.lbl_vahed.Size = new System.Drawing.Size(59, 14);
            this.lbl_vahed.TabIndex = 1;
            this.lbl_vahed.Text = "تعداد واحد";
            this.lbl_vahed.Visible = false;
            // 
            // frm_classdialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 170);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmb_grade);
            this.Controls.Add(this.cmb_major);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_vahed);
            this.Controls.Add(this.txt_vahed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_classname);
            this.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsResizable = false;
            this.MinimizeBox = false;
            this.Name = "frm_classdialog";
            this.ShowInTaskbar = false;
            this.Text = " ";
            this.Load += new System.EventHandler(this.classdialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.majorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_classdialog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_major;
        private System.Windows.Forms.ComboBox cmb_grade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Student.DataSet.ds_classdialog ds_classdialog;
        private System.Windows.Forms.BindingSource majorBindingSource;
        private Student.DataSet.ds_classdialogTableAdapters.majorTableAdapter majorTableAdapter;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_classname;
        public System.Windows.Forms.TextBox txt_vahed;
        public System.Windows.Forms.Label lbl_vahed;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
    }
}