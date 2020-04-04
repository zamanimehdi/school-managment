namespace Student
{
    partial class frm_proces
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
            this.progressRoller1 = new ProgressRoller.ProgressRoller();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressRoller1
            // 
            this.progressRoller1.BackColor = System.Drawing.Color.White;
            this.progressRoller1.ControlType = ProgressRoller.ProgressRoller.ControlTypeEnum.Running;
            this.progressRoller1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressRoller1.Location = new System.Drawing.Point(12, 12);
            this.progressRoller1.Name = "progressRoller1";
            this.progressRoller1.Size = new System.Drawing.Size(130, 30);
            this.progressRoller1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(4, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 49);
            this.label1.TabIndex = 1;
            // 
            // frm_proces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(156, 55);
            this.Controls.Add(this.progressRoller1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_proces";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "proces";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frm_proces_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ProgressRoller.ProgressRoller progressRoller1;
        private System.Windows.Forms.Label label1;
    }
}