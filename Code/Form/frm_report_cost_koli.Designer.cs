namespace Student
{
    partial class frm_report_cost_koli
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
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ds_cost_koli = new Student.DataSet.ds_cost_koli();
            this.kolmablaghBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kol_mablaghTableAdapter = new Student.DataSet.ds_cost_koliTableAdapters.kol_mablaghTableAdapter();
            this.kolpardakhtiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kol_pardakhtiTableAdapter = new Student.DataSet.ds_cost_koliTableAdapters.kol_pardakhtiTableAdapter();
            this.hazimeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hazimeTableAdapter = new Student.DataSet.ds_cost_koliTableAdapters.hazimeTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds_cost_koli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kolmablaghBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kolpardakhtiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hazimeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Image = global::Student.Properties.Resources.ExitH51;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(12, 128);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 36);
            this.button2.TabIndex = 7;
            this.button2.Text = "بازگشت";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 106);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(82, 76);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 18);
            this.label12.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(82, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 18);
            this.label11.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(82, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 18);
            this.label10.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(259, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 18);
            this.label9.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(262, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 18);
            this.label8.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(259, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 18);
            this.label7.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(173, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "سود (آخر سال) : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(176, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "باقيمانده صندوق :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "مانده وصولي :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(349, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "كل مبلغ :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(349, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "كل مبلغ دريافتي :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(349, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "كل مبلغ هزينه :";
            // 
            // ds_cost_koli
            // 
            this.ds_cost_koli.DataSetName = "ds_cost_koli";
            this.ds_cost_koli.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kolmablaghBindingSource
            // 
            this.kolmablaghBindingSource.DataMember = "kol_mablagh";
            this.kolmablaghBindingSource.DataSource = this.ds_cost_koli;
            // 
            // kol_mablaghTableAdapter
            // 
            this.kol_mablaghTableAdapter.ClearBeforeFill = true;
            // 
            // kolpardakhtiBindingSource
            // 
            this.kolpardakhtiBindingSource.DataMember = "kol_pardakhti";
            this.kolpardakhtiBindingSource.DataSource = this.ds_cost_koli;
            // 
            // kol_pardakhtiTableAdapter
            // 
            this.kol_pardakhtiTableAdapter.ClearBeforeFill = true;
            // 
            // hazimeBindingSource
            // 
            this.hazimeBindingSource.DataMember = "hazime";
            this.hazimeBindingSource.DataSource = this.ds_cost_koli;
            // 
            // hazimeTableAdapter
            // 
            this.hazimeTableAdapter.ClearBeforeFill = true;
            // 
            // frm_report_cost_koli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(474, 176);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_report_cost_koli";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_report_cost_koli_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds_cost_koli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kolmablaghBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kolpardakhtiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hazimeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private Student.DataSet.ds_cost_koli ds_cost_koli;
        private System.Windows.Forms.BindingSource kolmablaghBindingSource;
        private Student.DataSet.ds_cost_koliTableAdapters.kol_mablaghTableAdapter kol_mablaghTableAdapter;
        private System.Windows.Forms.BindingSource kolpardakhtiBindingSource;
        private Student.DataSet.ds_cost_koliTableAdapters.kol_pardakhtiTableAdapter kol_pardakhtiTableAdapter;
        private System.Windows.Forms.BindingSource hazimeBindingSource;
        private Student.DataSet.ds_cost_koliTableAdapters.hazimeTableAdapter hazimeTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;

    }
}