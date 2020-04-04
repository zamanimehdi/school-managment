namespace Student
{
    partial class frm_setpassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_getpassword));
            this.txt_passbefore = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_newpass1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_newpass2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_passbefore
            // 
            this.txt_passbefore.Location = new System.Drawing.Point(12, 12);
            this.txt_passbefore.Name = "txt_passbefore";
            this.txt_passbefore.Size = new System.Drawing.Size(139, 21);
            this.txt_passbefore.TabIndex = 0;
            this.txt_passbefore.Enter += new System.EventHandler(this.entercolor);
            this.txt_passbefore.Leave += new System.EventHandler(this.leavecolor);
            this.txt_passbefore.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextcontrol);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "رمز قبلی";
            // 
            // txt_newpass1
            // 
            this.txt_newpass1.Location = new System.Drawing.Point(12, 52);
            this.txt_newpass1.Name = "txt_newpass1";
            this.txt_newpass1.Size = new System.Drawing.Size(139, 21);
            this.txt_newpass1.TabIndex = 1;
            this.txt_newpass1.Enter += new System.EventHandler(this.entercolor);
            this.txt_newpass1.Leave += new System.EventHandler(this.leavecolor);
            this.txt_newpass1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextcontrol);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "رمز جدید";
            // 
            // txt_newpass2
            // 
            this.txt_newpass2.Location = new System.Drawing.Point(12, 79);
            this.txt_newpass2.Name = "txt_newpass2";
            this.txt_newpass2.Size = new System.Drawing.Size(139, 21);
            this.txt_newpass2.TabIndex = 2;
            this.txt_newpass2.Enter += new System.EventHandler(this.entercolor);
            this.txt_newpass2.Leave += new System.EventHandler(this.leavecolor);
            this.txt_newpass2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextcontrol);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "تکرار رمز ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(2, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "-----------------------------------------------------";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(140, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 27);
            this.button1.TabIndex = 3;
            this.button1.Text = "تایید";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(67, 113);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 27);
            this.button2.TabIndex = 4;
            this.button2.Text = "انصراف";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frm_setpassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(221, 152);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_newpass2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_newpass1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_passbefore);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_setpassword";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password";
            this.Load += new System.EventHandler(this.setpassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_passbefore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_newpass1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_newpass2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}