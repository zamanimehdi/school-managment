namespace Student
{
    partial class frm_behaviour
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_behaviour));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_datagride = new System.Windows.Forms.Panel();
            this.pnl_prba = new System.Windows.Forms.Panel();
            this.pib_prba = new System.Windows.Forms.PictureBox();
            this.lbl_prba2 = new System.Windows.Forms.Label();
            this.lbl_prba1 = new System.Windows.Forms.Label();
            this.prba = new System.Windows.Forms.ProgressBar();
            this.pnl_nav = new System.Windows.Forms.Panel();
            this.btn_first = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_last = new System.Windows.Forms.Button();
            this.btn_prev = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.count_line = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.behaviorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grb_input = new System.Windows.Forms.GroupBox();
            this.cmb_b = new System.Windows.Forms.ComboBox();
            this.txt_date = new System.Windows.Forms.TextBox();
            this.txt_behaviour = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.backgroundWorker_s = new System.ComponentModel.BackgroundWorker();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.grp_stinfo = new System.Windows.Forms.GroupBox();
            this.lbl_idstu_info = new System.Windows.Forms.Label();
            this.lbl_adress1_info = new System.Windows.Forms.Label();
            this.lbl_fname_info = new System.Windows.Forms.Label();
            this.lbl_tell_info = new System.Windows.Forms.Label();
            this.lbl_adress2_info = new System.Windows.Forms.Label();
            this.lbl_name_info = new System.Windows.Forms.Label();
            this.lbl_shsh_info = new System.Windows.Forms.Label();
            this.lbl_lname_info = new System.Windows.Forms.Label();
            this.ds_behaviour = new Student.DataSet.ds_behaviour();
            this.behaviorTableAdapter = new Student.DataSet.ds_behaviourTableAdapters.behaviorTableAdapter();
            this.pnl_datagride.SuspendLayout();
            this.pnl_prba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pib_prba)).BeginInit();
            this.pnl_nav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorBindingSource)).BeginInit();
            this.grb_input.SuspendLayout();
            this.grp_stinfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds_behaviour)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_datagride
            // 
            this.pnl_datagride.Controls.Add(this.pnl_prba);
            this.pnl_datagride.Controls.Add(this.pnl_nav);
            this.pnl_datagride.Controls.Add(this.dataGrid);
            resources.ApplyResources(this.pnl_datagride, "pnl_datagride");
            this.pnl_datagride.Name = "pnl_datagride";
            // 
            // pnl_prba
            // 
            this.pnl_prba.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            resources.ApplyResources(this.pnl_prba, "pnl_prba");
            this.pnl_prba.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_prba.Controls.Add(this.pib_prba);
            this.pnl_prba.Controls.Add(this.lbl_prba2);
            this.pnl_prba.Controls.Add(this.lbl_prba1);
            this.pnl_prba.Controls.Add(this.prba);
            this.pnl_prba.Name = "pnl_prba";
            // 
            // pib_prba
            // 
            this.pib_prba.Image = global::Student.Properties.Resources.fSEARCH_00;
            resources.ApplyResources(this.pib_prba, "pib_prba");
            this.pib_prba.Name = "pib_prba";
            this.pib_prba.TabStop = false;
            // 
            // lbl_prba2
            // 
            resources.ApplyResources(this.lbl_prba2, "lbl_prba2");
            this.lbl_prba2.Name = "lbl_prba2";
            // 
            // lbl_prba1
            // 
            resources.ApplyResources(this.lbl_prba1, "lbl_prba1");
            this.lbl_prba1.Name = "lbl_prba1";
            // 
            // prba
            // 
            resources.ApplyResources(this.prba, "prba");
            this.prba.Name = "prba";
            // 
            // pnl_nav
            // 
            this.pnl_nav.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnl_nav.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_nav.Controls.Add(this.btn_first);
            this.pnl_nav.Controls.Add(this.btn_del);
            this.pnl_nav.Controls.Add(this.btn_last);
            this.pnl_nav.Controls.Add(this.btn_prev);
            this.pnl_nav.Controls.Add(this.btn_next);
            resources.ApplyResources(this.pnl_nav, "pnl_nav");
            this.pnl_nav.Name = "pnl_nav";
            // 
            // btn_first
            // 
            this.btn_first.Image = global::Student.Properties.Resources.DataContainer_MoveFirsHS;
            resources.ApplyResources(this.btn_first, "btn_first");
            this.btn_first.Name = "btn_first";
            this.btn_first.UseVisualStyleBackColor = true;
            this.btn_first.Click += new System.EventHandler(this.btn_first_Click);
            // 
            // btn_del
            // 
            this.btn_del.Image = global::Student.Properties.Resources.DeleteHS;
            resources.ApplyResources(this.btn_del, "btn_del");
            this.btn_del.Name = "btn_del";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_last
            // 
            this.btn_last.Image = global::Student.Properties.Resources.DataContainer_MoveLastHS;
            resources.ApplyResources(this.btn_last, "btn_last");
            this.btn_last.Name = "btn_last";
            this.btn_last.UseVisualStyleBackColor = true;
            this.btn_last.Click += new System.EventHandler(this.btn_last_Click);
            // 
            // btn_prev
            // 
            this.btn_prev.Image = global::Student.Properties.Resources.DataContainer_MovePreviousHS;
            resources.ApplyResources(this.btn_prev, "btn_prev");
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.UseVisualStyleBackColor = true;
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // btn_next
            // 
            this.btn_next.Image = global::Student.Properties.Resources.DataContainer_MoveNextHS;
            resources.ApplyResources(this.btn_next, "btn_next");
            this.btn_next.Name = "btn_next";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AllowUserToResizeRows = false;
            this.dataGrid.AutoGenerateColumns = false;
            this.dataGrid.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.count_line,
            this.Column1,
            this.desc});
            this.dataGrid.DataSource = this.behaviorBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid.DefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.dataGrid, "dataGrid");
            this.dataGrid.MultiSelect = false;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowHeadersVisible = false;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.StandardTab = true;
            this.dataGrid.VirtualMode = true;
            this.dataGrid.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_RowEnter);
            this.dataGrid.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.dataGrid_CellValueNeeded);
            this.dataGrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGrid_CellFormatting);
            this.dataGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGrid_KeyDown);
            // 
            // count_line
            // 
            this.count_line.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.count_line, "count_line");
            this.count_line.Name = "count_line";
            this.count_line.ReadOnly = true;
            this.count_line.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.count_line.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "typeb";
            resources.ApplyResources(this.Column1, "Column1");
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // desc
            // 
            this.desc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.desc.DataPropertyName = "desc";
            resources.ApplyResources(this.desc, "desc");
            this.desc.Name = "desc";
            this.desc.ReadOnly = true;
            this.desc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // grb_input
            // 
            this.grb_input.Controls.Add(this.cmb_b);
            this.grb_input.Controls.Add(this.txt_date);
            this.grb_input.Controls.Add(this.txt_behaviour);
            this.grb_input.Controls.Add(this.label3);
            this.grb_input.Controls.Add(this.label1);
            this.grb_input.Controls.Add(this.label2);
            resources.ApplyResources(this.grb_input, "grb_input");
            this.grb_input.Name = "grb_input";
            this.grb_input.TabStop = false;
            // 
            // cmb_b
            // 
            this.cmb_b.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_b.FormattingEnabled = true;
            this.cmb_b.Items.AddRange(new object[] {
            resources.GetString("cmb_b.Items"),
            resources.GetString("cmb_b.Items1"),
            resources.GetString("cmb_b.Items2"),
            resources.GetString("cmb_b.Items3"),
            resources.GetString("cmb_b.Items4"),
            resources.GetString("cmb_b.Items5"),
            resources.GetString("cmb_b.Items6"),
            resources.GetString("cmb_b.Items7"),
            resources.GetString("cmb_b.Items8"),
            resources.GetString("cmb_b.Items9"),
            resources.GetString("cmb_b.Items10"),
            resources.GetString("cmb_b.Items11"),
            resources.GetString("cmb_b.Items12"),
            resources.GetString("cmb_b.Items13"),
            resources.GetString("cmb_b.Items14"),
            resources.GetString("cmb_b.Items15"),
            resources.GetString("cmb_b.Items16")});
            resources.ApplyResources(this.cmb_b, "cmb_b");
            this.cmb_b.Name = "cmb_b";
            // 
            // txt_date
            // 
            resources.ApplyResources(this.txt_date, "txt_date");
            this.txt_date.Name = "txt_date";
            this.txt_date.TextChanged += new System.EventHandler(this.inputtxtchange);
            this.txt_date.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextcontrol);
            this.txt_date.Leave += new System.EventHandler(this.leavecolor);
            this.txt_date.Enter += new System.EventHandler(this.entercolor);
            // 
            // txt_behaviour
            // 
            resources.ApplyResources(this.txt_behaviour, "txt_behaviour");
            this.txt_behaviour.Name = "txt_behaviour";
            this.txt_behaviour.TextChanged += new System.EventHandler(this.inputtxtchange);
            this.txt_behaviour.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextcontrol);
            this.txt_behaviour.Leave += new System.EventHandler(this.leavecolor);
            this.txt_behaviour.Enter += new System.EventHandler(this.entercolor);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_exit
            // 
            this.btn_exit.Image = global::Student.Properties.Resources.ExitH51;
            resources.ApplyResources(this.btn_exit, "btn_exit");
            this.btn_exit.Name = "btn_exit";
            this.toolTip.SetToolTip(this.btn_exit, resources.GetString("btn_exit.ToolTip"));
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_save
            // 
            resources.ApplyResources(this.btn_save, "btn_save");
            this.btn_save.Image = global::Student.Properties.Resources.small_save;
            this.btn_save.Name = "btn_save";
            this.toolTip.SetToolTip(this.btn_save, resources.GetString("btn_save.ToolTip"));
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_new
            // 
            resources.ApplyResources(this.btn_new, "btn_new");
            this.btn_new.Image = global::Student.Properties.Resources.new_bookmark;
            this.btn_new.Name = "btn_new";
            this.toolTip.SetToolTip(this.btn_new, resources.GetString("btn_new.ToolTip"));
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // backgroundWorker_s
            // 
            this.backgroundWorker_s.WorkerSupportsCancellation = true;
            this.backgroundWorker_s.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_s_DoWork);
            this.backgroundWorker_s.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_s_RunWorkerCompleted);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // grp_stinfo
            // 
            this.grp_stinfo.Controls.Add(this.lbl_idstu_info);
            this.grp_stinfo.Controls.Add(this.lbl_adress1_info);
            this.grp_stinfo.Controls.Add(this.lbl_fname_info);
            this.grp_stinfo.Controls.Add(this.lbl_tell_info);
            this.grp_stinfo.Controls.Add(this.lbl_adress2_info);
            this.grp_stinfo.Controls.Add(this.lbl_name_info);
            this.grp_stinfo.Controls.Add(this.lbl_shsh_info);
            this.grp_stinfo.Controls.Add(this.lbl_lname_info);
            resources.ApplyResources(this.grp_stinfo, "grp_stinfo");
            this.grp_stinfo.Name = "grp_stinfo";
            this.grp_stinfo.TabStop = false;
            // 
            // lbl_idstu_info
            // 
            resources.ApplyResources(this.lbl_idstu_info, "lbl_idstu_info");
            this.lbl_idstu_info.Name = "lbl_idstu_info";
            // 
            // lbl_adress1_info
            // 
            resources.ApplyResources(this.lbl_adress1_info, "lbl_adress1_info");
            this.lbl_adress1_info.Name = "lbl_adress1_info";
            // 
            // lbl_fname_info
            // 
            resources.ApplyResources(this.lbl_fname_info, "lbl_fname_info");
            this.lbl_fname_info.Name = "lbl_fname_info";
            // 
            // lbl_tell_info
            // 
            resources.ApplyResources(this.lbl_tell_info, "lbl_tell_info");
            this.lbl_tell_info.Name = "lbl_tell_info";
            // 
            // lbl_adress2_info
            // 
            this.lbl_adress2_info.ForeColor = System.Drawing.Color.Maroon;
            resources.ApplyResources(this.lbl_adress2_info, "lbl_adress2_info");
            this.lbl_adress2_info.Name = "lbl_adress2_info";
            // 
            // lbl_name_info
            // 
            resources.ApplyResources(this.lbl_name_info, "lbl_name_info");
            this.lbl_name_info.Name = "lbl_name_info";
            // 
            // lbl_shsh_info
            // 
            resources.ApplyResources(this.lbl_shsh_info, "lbl_shsh_info");
            this.lbl_shsh_info.Name = "lbl_shsh_info";
            // 
            // lbl_lname_info
            // 
            resources.ApplyResources(this.lbl_lname_info, "lbl_lname_info");
            this.lbl_lname_info.Name = "lbl_lname_info";
            // 
            // ds_behaviour
            // 
            this.ds_behaviour.DataSetName = "ds_behaviour";
            this.ds_behaviour.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // behaviorTableAdapter
            // 
            this.behaviorTableAdapter.ClearBeforeFill = true;
            // 
            // frm_behaviour
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.grp_stinfo);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.grb_input);
            this.Controls.Add(this.pnl_datagride);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_behaviour";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.frm_phone_Load);
            this.Shown += new System.EventHandler(this.frm_behaviour_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_phone_KeyDown);
            this.pnl_datagride.ResumeLayout(false);
            this.pnl_prba.ResumeLayout(false);
            this.pnl_prba.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pib_prba)).EndInit();
            this.pnl_nav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorBindingSource)).EndInit();
            this.grb_input.ResumeLayout(false);
            this.grb_input.PerformLayout();
            this.grp_stinfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ds_behaviour)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_datagride;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button btn_last;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.Button btn_first;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.GroupBox grb_input;
        private System.Windows.Forms.Panel pnl_nav;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_exit;
        //private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn lnameDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn idphoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolTip toolTip;
        private System.ComponentModel.BackgroundWorker backgroundWorker_s;
        private System.Windows.Forms.ProgressBar prba;
        private System.Windows.Forms.Panel pnl_prba;
        private System.Windows.Forms.Label lbl_prba1;
        private System.Windows.Forms.Label lbl_prba2;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox pib_prba;
        private System.Windows.Forms.GroupBox grp_stinfo;
        private System.Windows.Forms.Label lbl_adress1_info;
        private System.Windows.Forms.Label lbl_fname_info;
        private System.Windows.Forms.Label lbl_tell_info;
        private System.Windows.Forms.Label lbl_adress2_info;
        private System.Windows.Forms.Label lbl_name_info;
        private System.Windows.Forms.Label lbl_shsh_info;
        private System.Windows.Forms.Label lbl_lname_info;
        private System.Windows.Forms.Label lbl_idstu_info;
        //private System.Windows.Forms.DataGridViewTextBoxColumn idbehaviorDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txt_behaviour;
        private System.Windows.Forms.Label label2;
        private Student.DataSet.ds_behaviour ds_behaviour;
        private System.Windows.Forms.TextBox txt_date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource behaviorBindingSource;
        private Student.DataSet.ds_behaviourTableAdapters.behaviorTableAdapter behaviorTableAdapter;
        private System.Windows.Forms.ComboBox cmb_b;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn count_line;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc;
    }
}

