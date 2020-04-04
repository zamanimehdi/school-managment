namespace Student
{
    partial class frm_schooltype
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_schooltype));
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_schooltype = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_schoolname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(181, 72);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(62, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "نوع مدرسه";
            // 
            // cmb_schooltype
            // 
            this.cmb_schooltype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_schooltype.FormattingEnabled = true;
            this.cmb_schooltype.Items.AddRange(new object[] {
            "نظری",
            "فنی و حرفه ای",
            "کار دانش",
            "ابتدایی",
            "متوسطه اول",
            "متوسطه دوم"});
            this.cmb_schooltype.Location = new System.Drawing.Point(21, 68);
            this.cmb_schooltype.Name = "cmb_schooltype";
            this.cmb_schooltype.Size = new System.Drawing.Size(154, 22);
            this.cmb_schooltype.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Image = global::Student.Properties.Resources.small_save;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(21, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "تایید";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(18, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 11);
            this.label2.TabIndex = 3;
            this.label2.Text = " _ __ ___ ____ _____ _________ ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(181, 44);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(65, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = " نام مدرسه";
            // 
            // txt_schoolname
            // 
            this.txt_schoolname.Location = new System.Drawing.Point(21, 40);
            this.txt_schoolname.MaxLength = 50;
            this.txt_schoolname.Name = "txt_schoolname";
            this.txt_schoolname.Size = new System.Drawing.Size(154, 22);
            this.txt_schoolname.TabIndex = 5;
            // 
            // frm_schooltype
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 171);
            this.Controls.Add(this.txt_schoolname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmb_schooltype);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frm_schooltype";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = " ";
            this.Load += new System.EventHandler(this.frm_setting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_schooltype;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_schoolname;

    }
}