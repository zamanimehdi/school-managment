namespace Student
{
    partial class frm_restorebackup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_restorebackup));
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_no = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_messeage = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(31, 75);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Size = new System.Drawing.Size(110, 21);
            this.txt_pass.TabIndex = 0;
            this.txt_pass.UseSystemPasswordChar = true;
            this.txt_pass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextcontrol);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "رمز را وارد کنید";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(17, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "آیا مایل هستید که اطلاعات فعلی پاک شود و اطلاعات فایل پشتیبان جایگذاری گردد ؟";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(162, 129);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(60, 23);
            this.btn_ok.TabIndex = 1;
            this.btn_ok.Text = "بلی";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_no
            // 
            this.btn_no.Location = new System.Drawing.Point(96, 129);
            this.btn_no.Name = "btn_no";
            this.btn_no.Size = new System.Drawing.Size(60, 23);
            this.btn_no.TabIndex = 2;
            this.btn_no.Text = "خیر";
            this.btn_no.UseVisualStyleBackColor = true;
            this.btn_no.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(13, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "-----------------------------------------------------";
            // 
            // lbl_messeage
            // 
            this.lbl_messeage.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_messeage.Location = new System.Drawing.Point(17, 9);
            this.lbl_messeage.Name = "lbl_messeage";
            this.lbl_messeage.Size = new System.Drawing.Size(214, 94);
            this.lbl_messeage.TabIndex = 5;
            this.lbl_messeage.Text = "فایل پشتیبان به طور کامل بار گذاری شد";
            this.lbl_messeage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_messeage.Visible = false;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(16, 129);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(60, 23);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.Text = "خروج";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Visible = false;
            this.btn_exit.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(28, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "سیستم پشتیبان نرم افزار مدارس";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_restorebackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(246, 163);
            this.Controls.Add(this.lbl_messeage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_no);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_pass);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_restorebackup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "school management";
            this.Load += new System.EventHandler(this.frm_restorebackup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_no;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_messeage;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label label3;
    }
}