namespace Student
{
    partial class frm_lesson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_lesson));
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_del = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expr1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vahed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lessonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_lesson = new Student.DataSet.ds_lesson();
            this.lessonTableAdapter = new Student.DataSet.ds_lessonTableAdapters.lessonTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_lesson)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Image = global::Student.Properties.Resources.ExitH51;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(18, 501);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "بازگشت";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_lesson_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(13, 480);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "_ __ ___ ____ _____ _________ ";
            // 
            // btn_add
            // 
            this.btn_add.Image = global::Student.Properties.Resources.new_bookmark;
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.Location = new System.Drawing.Point(144, 458);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(62, 27);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "اضافه";
            this.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            this.btn_add.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_lesson_KeyDown);
            // 
            // btn_edit
            // 
            this.btn_edit.Enabled = false;
            this.btn_edit.Image = ((System.Drawing.Image)(resources.GetObject("btn_edit.Image")));
            this.btn_edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_edit.Location = new System.Drawing.Point(81, 458);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(62, 27);
            this.btn_edit.TabIndex = 2;
            this.btn_edit.Text = "اصلاح";
            this.btn_edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(267, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "درس ها";
            // 
            // btn_del
            // 
            this.btn_del.Image = global::Student.Properties.Resources.DeleteHS;
            this.btn_del.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_del.Location = new System.Drawing.Point(18, 458);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(62, 27);
            this.btn_del.TabIndex = 2;
            this.btn_del.Text = "حذف";
            this.btn_del.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            this.btn_del.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_lesson_KeyDown);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.gradeDataGridViewTextBoxColumn,
            this.expr1DataGridViewTextBoxColumn,
            this.vahed});
            this.dataGridView1.DataSource = this.lessonBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(18, 52);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(294, 398);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_lesson_KeyDown);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "نام درس";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gradeDataGridViewTextBoxColumn
            // 
            this.gradeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.gradeDataGridViewTextBoxColumn.DataPropertyName = "grade";
            this.gradeDataGridViewTextBoxColumn.HeaderText = "پایه";
            this.gradeDataGridViewTextBoxColumn.Name = "gradeDataGridViewTextBoxColumn";
            this.gradeDataGridViewTextBoxColumn.ReadOnly = true;
            this.gradeDataGridViewTextBoxColumn.Width = 49;
            // 
            // expr1DataGridViewTextBoxColumn
            // 
            this.expr1DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.expr1DataGridViewTextBoxColumn.DataPropertyName = "Expr1";
            this.expr1DataGridViewTextBoxColumn.HeaderText = "رشته";
            this.expr1DataGridViewTextBoxColumn.Name = "expr1DataGridViewTextBoxColumn";
            this.expr1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vahed
            // 
            this.vahed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.vahed.DataPropertyName = "vahed";
            this.vahed.FillWeight = 50F;
            this.vahed.HeaderText = "واحد";
            this.vahed.Name = "vahed";
            this.vahed.ReadOnly = true;
            // 
            // lessonBindingSource
            // 
            this.lessonBindingSource.DataMember = "lesson";
            this.lessonBindingSource.DataSource = this.ds_lesson;
            // 
            // ds_lesson
            // 
            this.ds_lesson.DataSetName = "ds_lesson";
            this.ds_lesson.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lessonTableAdapter
            // 
            this.lessonTableAdapter.ClearBeforeFill = true;
            // 
            // frm_lesson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 550);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsResizable = false;
            this.MinimizeBox = false;
            this.Name = "frm_lesson";
            this.ResizableColor = System.Drawing.Color.Transparent;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = " ";
            this.Load += new System.EventHandler(this.frm_lesson_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_lesson_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_lesson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.DataGridView dataGridView1;
        //private System.Windows.Forms.DataGridViewTextBoxColumn idmajorDataGridViewTextBoxColumn;
        private Student.DataSet.ds_lesson ds_lesson;
        private System.Windows.Forms.BindingSource lessonBindingSource;
        private Student.DataSet.ds_lessonTableAdapters.lessonTableAdapter lessonTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vahed;

    }
}