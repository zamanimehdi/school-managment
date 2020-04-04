namespace Student
{
    partial class frm_faravani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_faravani));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.hamahangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_hamhang = new Student.DataSet.ds_hamhang();
            this.classBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_preview = new System.Windows.Forms.Button();
            this.hamahangTableAdapter = new Student.DataSet.ds_hamhangTableAdapters.hamahangTableAdapter();
            this.classTableAdapter = new Student.DataSet.ds_hamhangTableAdapters.classTableAdapter();
            this.tbravandsalaneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_ravand_salaneTableAdapter = new Student.DataSet.ds_hamhangTableAdapters.tb_ravand_salaneTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hamahangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_hamhang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbravandsalaneBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 90);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اطلاعات";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 21);
            this.textBox1.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "سال تحصیلی";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "انتخاب امتحان هماهنگ";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.hamahangBindingSource;
            this.comboBox1.DisplayMember = "name";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(13, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(213, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "id";
            // 
            // hamahangBindingSource
            // 
            this.hamahangBindingSource.DataMember = "hamahang";
            this.hamahangBindingSource.DataSource = this.ds_hamhang;
            // 
            // ds_hamhang
            // 
            this.ds_hamhang.DataSetName = "ds_hamhang";
            this.ds_hamhang.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // classBindingSource
            // 
            this.classBindingSource.DataMember = "class";
            this.classBindingSource.DataSource = this.ds_hamhang;
            // 
            // btn_exit
            // 
            this.btn_exit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_exit.Image")));
            this.btn_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exit.Location = new System.Drawing.Point(12, 108);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(96, 38);
            this.btn_exit.TabIndex = 23;
            this.btn_exit.Text = "بازگشت";
            this.btn_exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_preview
            // 
            this.btn_preview.Image = ((System.Drawing.Image)(resources.GetObject("btn_preview.Image")));
            this.btn_preview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_preview.Location = new System.Drawing.Point(122, 108);
            this.btn_preview.Name = "btn_preview";
            this.btn_preview.Size = new System.Drawing.Size(96, 38);
            this.btn_preview.TabIndex = 22;
            this.btn_preview.Text = "پیش نمایش";
            this.btn_preview.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_preview.UseVisualStyleBackColor = true;
            this.btn_preview.Click += new System.EventHandler(this.btn_preview_Click);
            // 
            // hamahangTableAdapter
            // 
            this.hamahangTableAdapter.ClearBeforeFill = true;
            // 
            // classTableAdapter
            // 
            this.classTableAdapter.ClearBeforeFill = true;
            // 
            // tbravandsalaneBindingSource
            // 
            this.tbravandsalaneBindingSource.DataMember = "tb_ravand_salane";
            this.tbravandsalaneBindingSource.DataSource = this.ds_hamhang;
            // 
            // tb_ravand_salaneTableAdapter
            // 
            this.tb_ravand_salaneTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(269, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "لطفا صبر کنید ...";
            this.label3.Visible = false;
            // 
            // frm_faravani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(386, 162);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_preview);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_faravani";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_class_salane_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hamahangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_hamhang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbravandsalaneBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_preview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private Student.DataSet.ds_hamhang ds_hamhang;
        private System.Windows.Forms.BindingSource hamahangBindingSource;
        private Student.DataSet.ds_hamhangTableAdapters.hamahangTableAdapter hamahangTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource classBindingSource;
        private DataSet.ds_hamhangTableAdapters.classTableAdapter classTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource tbravandsalaneBindingSource;
        private DataSet.ds_hamhangTableAdapters.tb_ravand_salaneTableAdapter tb_ravand_salaneTableAdapter;
        private System.Windows.Forms.Label label3;
    }
}