namespace Student
{
    partial class frm_datechange
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
            this.txt_day = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_mon = new System.Windows.Forms.TextBox();
            this.txt_year = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_day
            // 
            this.txt_day.Location = new System.Drawing.Point(68, 24);
            this.txt_day.MaxLength = 2;
            this.txt_day.Name = "txt_day";
            this.txt_day.Size = new System.Drawing.Size(30, 21);
            this.txt_day.TabIndex = 2;
            this.txt_day.Enter += new System.EventHandler(this.entercolor);
            this.txt_day.Leave += new System.EventHandler(this.leavecolor);
            this.txt_day.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_day_KeyDown);
            // 
            // btn_save
            // 
            this.btn_save.Image = global::Student.Properties.Resources.small_save;
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_save.Location = new System.Drawing.Point(12, 77);
            this.btn_save.Name = "btn_save";
            this.btn_save.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_save.Size = new System.Drawing.Size(74, 30);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "ذخیـــره";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_mon
            // 
            this.txt_mon.Location = new System.Drawing.Point(37, 24);
            this.txt_mon.MaxLength = 2;
            this.txt_mon.Name = "txt_mon";
            this.txt_mon.Size = new System.Drawing.Size(30, 21);
            this.txt_mon.TabIndex = 1;
            this.txt_mon.Enter += new System.EventHandler(this.entercolor);
            this.txt_mon.Leave += new System.EventHandler(this.leavecolor);
            this.txt_mon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_mon_KeyDown);
            // 
            // txt_year
            // 
            this.txt_year.Location = new System.Drawing.Point(6, 24);
            this.txt_year.MaxLength = 2;
            this.txt_year.Name = "txt_year";
            this.txt_year.Size = new System.Drawing.Size(30, 21);
            this.txt_year.TabIndex = 0;
            this.txt_year.Enter += new System.EventHandler(this.entercolor);
            this.txt_year.Leave += new System.EventHandler(this.leavecolor);
            this.txt_year.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_year_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "روز / ماه / سال";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_year);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_day);
            this.groupBox1.Controls.Add(this.txt_mon);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 59);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // frm_datechange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(220, 114);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_save);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_datechange";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  تغییر تاریخ";
            this.Load += new System.EventHandler(this.datechange_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_day;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txt_mon;
        private System.Windows.Forms.TextBox txt_year;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}