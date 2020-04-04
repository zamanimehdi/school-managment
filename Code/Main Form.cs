using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Student
{
    public partial class Frm_Main : Form
    {
        private System.Globalization.PersianCalendar pc = new System.Globalization.PersianCalendar();
        private DateTime dt;
        int counter = 0;
        frm_proces frm_p;
        string strpath;
        Frm_Splash frmsplash = new Frm_Splash();
        public Frm_Main()
        {
            frmsplash.Show(null); frmsplash.Refresh();
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            dt = DateTime.Now;
            statusbar.Items[0].Text = "   " + pc.GetYear(dt).ToString() + "/" + (pc.GetMonth(dt).ToString().Length == 1 ? "0" + pc.GetMonth(dt).ToString() : pc.GetMonth(dt).ToString()) + "/" + (pc.GetDayOfMonth(dt).ToString().Length == 1 ? "0" + pc.GetDayOfMonth(dt).ToString() : pc.GetDayOfMonth(dt).ToString());
            statusbar.Items[1].Text = dt.ToLongTimeString();
        }
        private void Frm_Main_Load(object sender, EventArgs e)
        {
            /////////////////// db years

            string ypath = Application.ExecutablePath.ToString().Substring(0, Application.ExecutablePath.ToString().Length - 21);
            if (!System.IO.Directory.Exists(ypath + "years\\")) System.IO.Directory.CreateDirectory(ypath + "years\\");
            string[] strs = System.IO.Directory.GetFiles(ypath + "years\\");
            foreach (string stemp in strs)
                comboBox1.Items.Add(System.IO.Path.GetFileName(stemp).Substring(0, System.IO.Path.GetFileName(stemp).Length - 4));
            if (strs.Length == 0) Student.Properties.Settings.Default.db = "";
            if (Student.Properties.Settings.Default.db == "")
            {
                frm_db frm = new frm_db();
                while (Student.Properties.Settings.Default.db == "")
                {
                    MessageBox.Show("هيچ ديتابيسي وجود ندارد ، لطفا ديتابيس برنامه را برپا سازيد");
                    frm.ShowDialog();
                    strs = System.IO.Directory.GetFiles(ypath + "years\\");
                    comboBox1.Items.Clear();
                }
                comboBox1.Items.Clear();
                string ypath2 = Application.ExecutablePath.ToString().Substring(0, Application.ExecutablePath.ToString().Length - 21);
                string[] strs2 = System.IO.Directory.GetFiles(ypath2 + "years\\");
                foreach (string stemp in strs2)
                    comboBox1.Items.Add(System.IO.Path.GetFileName(stemp).Substring(0, System.IO.Path.GetFileName(stemp).Length - 4));
                comboBox1.SelectedItem = Student.Properties.Settings.Default.db;

            }
            else
            {
                comboBox1.SelectedItem = Student.Properties.Settings.Default.db;

            }
            /////////////////////
            try
            {
                // TODO: This line of code loads data into the 'dsp_mali2.vaziatmali' table. You can move, or remove it, as needed.
                this.vaziatmaliTableAdapter.Fill(this.dsp_mali2.vaziatmali);
            }
            catch (Exception ex)
            {
                frm_exception frm = new frm_exception(ex.Message);
                frm.ShowDialog();
                Opacity = 0; Close();
            }

            //////// password
            strpath = System.IO.Path.GetTempPath();
            string[] strar = strpath.Split(char.Parse("\\"));
            strpath = strar[0] + "\\" + strar[1] + "\\";
            string read;
            if (System.IO.File.Exists(strpath + "setting.ini"))
            {

                read = System.IO.File.ReadAllText(strpath + "setting.ini");
                if (read.Length < 4)
                {
                    if (Int32.Parse(read) > 0)
                    {
                        read = Convert.ToString(Int32.Parse(read) - 1);
                        lbl_reg.Text = "<" + read + "> Register";
                    }
                    try
                    {
                        System.IO.File.SetAttributes(strpath + "setting.ini", System.IO.FileAttributes.Normal);
                        System.IO.File.WriteAllText(strpath + "setting.ini", read);
                        System.IO.File.SetAttributes(strpath + "setting.ini", System.IO.FileAttributes.System);
                        System.IO.File.SetAttributes(strpath + "setting.ini", System.IO.FileAttributes.Hidden);
                    }
                    catch { MessageBox.Show("خطا در ورودی و خروجی");/* Opacity = 0; Close();*/ }
                }

            }
            else
            {
                //MessageBox.Show("ss");
                try
                {
                    System.IO.File.WriteAllText(strpath + "setting.ini", "35");
                    System.IO.File.SetAttributes(strpath + "setting.ini", System.IO.FileAttributes.System);
                    System.IO.File.SetAttributes(strpath + "setting.ini", System.IO.FileAttributes.Hidden);
                }
                catch { MessageBox.Show("خطا در ورودی و خروجی"); Opacity = 0; Close(); }
                read = "35";
            }

            if (Properties.Settings.Default.pass != "")
            {
                frm_getpassword formgpass = new frm_getpassword();
                formgpass.Opacity = 0;
                DialogResult tempresult;
                while ((tempresult = formgpass.ShowDialog()) != DialogResult.OK)
                {
                    if (tempresult == DialogResult.Ignore)
                    {
                        this.Close();
                        break;
                    }
                }
            }
            ///////////////

            if (Properties.Settings.Default.datebackup != "")
            {
                lbl_messagedate.Text = "تاریخ آخرین پشتیبان :" + Properties.Settings.Default.datebackup;
            }
            else lbl_messagedate.Text = "هنوز هیچ پشتیبانی از سیستم گرفته نشده است";
            lbl_main.Text += Properties.Settings.Default.schoolname + " ";
            switch (Properties.Settings.Default.color)
            {
                case 1:
                    kryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.ProfessionalOffice2003;
                    statusbar.BackColor = collapsiblePanelBar1.BackColor = Color.LightSteelBlue;
                    collapsiblePanel_teacher.EndColour = collapsiblePanel_report.EndColour = collapsiblePanel_firstsetting.EndColour = collapsiblePanel_student.EndColour = Color.FromArgb(199, 212, 247);
                    collapsiblePanelBar1.Refresh();
                    break;
                case 2:
                    kryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.ProfessionalRed;
                    statusbar.BackColor = collapsiblePanelBar1.BackColor = Color.FromArgb(255, 186, 186);
                    collapsiblePanel_teacher.EndColour = collapsiblePanel_report.EndColour = collapsiblePanel_firstsetting.EndColour = collapsiblePanel_student.EndColour = Color.FromArgb(245, 176, 176);
                    collapsiblePanelBar1.Refresh();
                    break;
                case 3:
                    kryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.ProfessionalGreen;
                    statusbar.BackColor = collapsiblePanelBar1.BackColor = Color.FromArgb(193, 218, 196);
                    collapsiblePanel_teacher.EndColour = collapsiblePanel_report.EndColour = collapsiblePanel_firstsetting.EndColour = collapsiblePanel_student.EndColour = Color.FromArgb(183, 208, 186);
                    collapsiblePanelBar1.Refresh();
                    break;
                case 4:
                    kryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.ProfessionalSystem;
                    statusbar.BackColor = collapsiblePanelBar1.BackColor = Color.FromArgb(229, 226, 221);
                    collapsiblePanel_teacher.EndColour = collapsiblePanel_report.EndColour = collapsiblePanel_firstsetting.EndColour = collapsiblePanel_student.EndColour = Color.FromArgb(239, 236, 221);
                    collapsiblePanelBar1.Refresh();
                    break;
            }
            if (!Properties.Settings.Default.cpl_4) collapsiblePanel_firstsetting.PanelState = Salamander.Windows.Forms.PanelState.Collapsed;
            if (!Properties.Settings.Default.cpl_3) collapsiblePanel_report.PanelState = Salamander.Windows.Forms.PanelState.Collapsed;
            if (!Properties.Settings.Default.cpl_2) collapsiblePanel_teacher.PanelState = Salamander.Windows.Forms.PanelState.Collapsed;
            if (!Properties.Settings.Default.cpl_1) collapsiblePanel_student.PanelState = Salamander.Windows.Forms.PanelState.Collapsed;
            toolbar_help.Click += new EventHandler(help_click);
            toolbar_inputnumber.Click += new EventHandler(inputnumber_click);
            toolbar_studentregister.Click += new EventHandler(studentregister_click);
            toolbar_firstsetting.ContextMenuStrip = contextMenuStrip1;

        }
        private void help_click(object sender, EventArgs e)
        {
            Help frm = new Help();
            frm.ShowDialog();
        }
        private void inputnumber_click(object sender, EventArgs e)
        {
            try
            {
                bcp_inputnumber_Click(null, null);
            }
            catch (Exception ex)
            {
                frm_exception frm = new frm_exception(ex.Message + "\n\n" + ex.StackTrace);
                frm.ShowDialog();
            }
        }
        private void studentregister_click(object sender, EventArgs e)
        {
            try
            {
                bcp_studentregister_Click(null, null);
            }
            catch (Exception ex)
            {
                frm_exception frm = new frm_exception(ex.Message + "\n\n" + ex.StackTrace);
                frm.ShowDialog();
            }
        }
        private void bcp_studentregister_Click(object sender, EventArgs e)
        {
            try
            {
                frm_student form = new frm_student();
                form.Opacity = 0;
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                frm_exception frm = new frm_exception(ex.Message + "\n\n" + ex.StackTrace);
                frm.ShowDialog();
            }
        }
        private void bcp_inputnumber_Click(object sender, EventArgs e)
        {
            try
            {
                frm_test form = new frm_test();
                form.Opacity = 0;
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                frm_exception frm = new frm_exception(ex.Message + "\n\n" + ex.StackTrace);
                frm.ShowDialog();
            }
        }
        private void bcp_mali_Click(object sender, EventArgs e)
        {
            try
            {
                frm_prepaid form = new frm_prepaid();
                form.Opacity = 0;
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                frm_exception frm = new frm_exception(ex.Message + "\n\n" + ex.StackTrace);
                frm.ShowDialog();
            }
        }
        private void bcp_enzebati_Click(object sender, EventArgs e)
        {
            try
            {
                frm_choosest form = new frm_choosest();
                form.Opacity = 0;
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                frm_exception frm = new frm_exception(ex.Message + "\n\n" + ex.StackTrace);
                frm.ShowDialog();
            }
        }
        private void bcp_moaleminput_Click(object sender, EventArgs e)
        {
            try
            {
                frm_teacher form = new frm_teacher();
                form.Opacity = 0;
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                frm_exception frm = new frm_exception(ex.Message + "\n\n" + ex.StackTrace);
                frm.ShowDialog();
            }
        }
        private void bcp_moalemdars_Click(object sender, EventArgs e)
        {
            try
            {
                frm_st_teacher form = new frm_st_teacher();
                form.isforperint = false;
                form.Opacity = 0;
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                frm_exception frm = new frm_exception(ex.Message + "\n\n" + ex.StackTrace);
                frm.ShowDialog();
            }
        }
        private void cpl_schooltype_Click(object sender, EventArgs e)
        {
            try
            {
                frm_schooltype form = new frm_schooltype();
                form.ShowDialog();
                Frm_Main_Shown(null, null);
                lbl_main.Text = "شركت نرم افزاري مسير سبز\n\n " + Properties.Settings.Default.schoolname + " ";
            }
            catch (Exception ex)
            {
                frm_exception frm = new frm_exception(ex.Message + "\n\n" + ex.StackTrace);
                frm.ShowDialog();
            }
        }
        private void cpl_reshte_Click(object sender, EventArgs e)
        {
            try
            {
                frm_major form = new frm_major();
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                frm_exception frm = new frm_exception(ex.Message + "\n\n" + ex.StackTrace);
                frm.ShowDialog();
            }
        }
        private void cpl_class_Click(object sender, EventArgs e)
        {
            try
            {
                frm_class form = new frm_class();
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                frm_exception frm = new frm_exception(ex.Message + "\n\n" + ex.StackTrace);
                frm.ShowDialog();
            }
        }
        private void cpl_lesson_Click(object sender, EventArgs e)
        {
            try
            {
                frm_lesson form = new frm_lesson();
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                frm_exception frm = new frm_exception(ex.Message + "\n\n" + ex.StackTrace);
                frm.ShowDialog();
            }
        }
        private void cpl_Rstudent_Click(object sender, EventArgs e)
        {
            try
            {
                frmp_student form = new frmp_student();
                form.Opacity = 0;
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                frm_exception frm = new frm_exception(ex.Message + "\n\n" + ex.StackTrace);
                frm.ShowDialog();
            }
        }
        private void cpl_Renzebati_Click(object sender, EventArgs e)
        {
            try
            {
                contextMenuStrip4.Show((Control)cpl_Renzebati, new Point(cpl_Renzebati.Location.X, cpl_Renzebati.Location.Y - 130));
            }
            catch (Exception ex)
            {
                frm_exception frm = new frm_exception(ex.Message + "\n\n" + ex.StackTrace);
                frm.ShowDialog();
            }
        }
        private void cpl_Rmali_Click(object sender, EventArgs e)
        {
            try
            {
                contextMenuStrip3.Show((Control)cpl_Rmali, new Point(cpl_Rmali.Location.X, cpl_Rkarname.Location.Y - 105));
            }
            catch (Exception ex)
            {
                frm_exception frm = new frm_exception(ex.Message + "\n\n" + ex.StackTrace);
                frm.ShowDialog();
            }
        }
        private void schooltype_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                cpl_schooltype_Click(null, null);
            }
            catch (Exception ex)
            {
                frm_exception frm = new frm_exception(ex.Message + "\n\n" + ex.StackTrace);
                frm.ShowDialog();
            }
        }
        private void major_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                cpl_reshte_Click(null, null);
            }
            catch (Exception ex)
            {
                frm_exception frm = new frm_exception(ex.Message + "\n\n" + ex.StackTrace);
                frm.ShowDialog();
            }
        }
        private void class_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                cpl_class_Click(null, null);
            }
            catch (Exception ex)
            {
                frm_exception frm = new frm_exception(ex.Message + "\n\n" + ex.StackTrace);
                frm.ShowDialog();
            }
        }
        private void lesson_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                cpl_lesson_Click(null, null);
            }
            catch (Exception ex)
            {
                frm_exception frm = new frm_exception(ex.Message + "\n\n" + ex.StackTrace);
                frm.ShowDialog();
            }
        }
        private void MenuItem_studentregister_Click(object sender, EventArgs e)
        {
            try
            {
                bcp_studentregister_Click(null, null);
            }
            catch (Exception ex)
            {
                frm_exception frm = new frm_exception(ex.Message + "\n\n" + ex.StackTrace);
                frm.ShowDialog();
            }
        }
        private void MenuItem_studentinputnumber_Click(object sender, EventArgs e)
        {
            try
            {
                bcp_inputnumber_Click(null, null);
            }
            catch (Exception ex)
            {
                frm_exception frm = new frm_exception(ex.Message + "\n\n" + ex.StackTrace);
                frm.ShowDialog();
            }
        }
        private void MenuItem_mali_Click(object sender, EventArgs e)
        {
            try
            {
                bcp_mali_Click(null, null);
            }
            catch (Exception ex)
            {
                frm_exception frm = new frm_exception(ex.Message + "\n\n" + ex.StackTrace);
                frm.ShowDialog();
            }
        }
        private void MenuItem_enzebati_Click(object sender, EventArgs e)
        {
            try
            {
                bcp_enzebati_Click(null, null);
            }
            catch (Exception ex)
            {
                frm_exception frm = new frm_exception(ex.Message + "\n\n" + ex.StackTrace);
                frm.ShowDialog();
            }
        }
        private void MenuItem_moaleminput_Click(object sender, EventArgs e)
        {
            try
            {
                bcp_moaleminput_Click(null, null);
            }
            catch (Exception ex)
            {
                frm_exception frm = new frm_exception(ex.Message + "\n\n" + ex.StackTrace);
                frm.ShowDialog();
            }
        }
        private void MenuItem_moalemdars_Click(object sender, EventArgs e)
        {
            try
            {
                bcp_moalemdars_Click(null, null);
            }
            catch (Exception ex)
            {
                frm_exception frm = new frm_exception(ex.Message + "\n\n" + ex.StackTrace);
                frm.ShowDialog();
            }
        }
        private void MenuItem_Rstudent_Click(object sender, EventArgs e)
        {
            try
            {
                cpl_Rstudent_Click(null, null);
            }
            catch (Exception ex)
            {
                frm_exception frm = new frm_exception(ex.Message + "\n\n" + ex.StackTrace);
                frm.ShowDialog();
            }
        }
        private void MenuItem_Renzebati_Click(object sender, EventArgs e)
        {
            try
            {
                cpl_Renzebati_Click(null, null);
            }
            catch (Exception ex)
            {
                frm_exception frm = new frm_exception(ex.Message + "\n\n" + ex.StackTrace);
                frm.ShowDialog();
            }
        }
        private void MenuItem_schooltype_Click(object sender, EventArgs e)
        {
            try
            {
                cpl_schooltype_Click(null, null);
            }
            catch (Exception ex)
            {
                frm_exception frm = new frm_exception(ex.Message + "\n\n" + ex.StackTrace);
                frm.ShowDialog();
            }
        }
        private void MenuItem_reshte_Click(object sender, EventArgs e)
        {
            try
            {
                cpl_reshte_Click(null, null);
            }
            catch (Exception ex)
            {
                frm_exception frm = new frm_exception(ex.Message + "\n\n" + ex.StackTrace);
                frm.ShowDialog();
            }
        }
        private void MenuItem_class_Click(object sender, EventArgs e)
        {
            try
            {
                cpl_class_Click(null, null);
            }
            catch (Exception ex)
            {
                frm_exception frm = new frm_exception(ex.Message + "\n\n" + ex.StackTrace);
                frm.ShowDialog();
            }
        }
        private void MenuItem_lesson_Click(object sender, EventArgs e)
        {
            try
            {
                cpl_lesson_Click(null, null);
            }
            catch (Exception ex)
            {
                frm_exception frm = new frm_exception(ex.Message + "\n\n" + ex.StackTrace);
                frm.ShowDialog();
            }
        }
        private void red_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.ProfessionalRed;
            statusbar.BackColor = collapsiblePanelBar1.BackColor = Color.FromArgb(255, 186, 186);
            collapsiblePanel_teacher.EndColour = collapsiblePanel_report.EndColour = collapsiblePanel_firstsetting.EndColour = collapsiblePanel_student.EndColour = Color.FromArgb(245, 176, 176);
            collapsiblePanelBar1.Refresh();
            Properties.Settings.Default.color = 2;
            Properties.Settings.Default.Save();
        }
        private void blue_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.ProfessionalOffice2003;
            statusbar.BackColor = collapsiblePanelBar1.BackColor = Color.LightSteelBlue;
            collapsiblePanel_teacher.EndColour = collapsiblePanel_report.EndColour = collapsiblePanel_firstsetting.EndColour = collapsiblePanel_student.EndColour = Color.FromArgb(199, 212, 247);
            collapsiblePanelBar1.Refresh();
            Properties.Settings.Default.color = 1;
            Properties.Settings.Default.Save();
        }
        private void green_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.ProfessionalGreen;
            statusbar.BackColor = collapsiblePanelBar1.BackColor = Color.FromArgb(193, 218, 196);
            collapsiblePanel_teacher.EndColour = collapsiblePanel_report.EndColour = collapsiblePanel_firstsetting.EndColour = collapsiblePanel_student.EndColour = Color.FromArgb(183, 208, 186);
            collapsiblePanelBar1.Refresh();
            Properties.Settings.Default.color = 3;
            Properties.Settings.Default.Save();
        }
        private void sys_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.ProfessionalSystem;
            statusbar.BackColor = collapsiblePanelBar1.BackColor = Color.FromArgb(229, 226, 221);
            collapsiblePanel_teacher.EndColour = collapsiblePanel_report.EndColour = collapsiblePanel_firstsetting.EndColour = collapsiblePanel_student.EndColour = Color.FromArgb(239, 236, 221);
            collapsiblePanelBar1.Refresh();
            Properties.Settings.Default.color = 4;
            Properties.Settings.Default.Save();
        }
        private void collapsiblePanel_student_PanelStateChanged(object sender, Salamander.Windows.Forms.PanelEventArgs e)
        {
            Properties.Settings.Default.cpl_1 = (collapsiblePanel_student.PanelState == Salamander.Windows.Forms.PanelState.Expanded ? true : false);
            Properties.Settings.Default.Save();
        }
        private void collapsiblePanel_teacher_PanelStateChanged(object sender, Salamander.Windows.Forms.PanelEventArgs e)
        {
            Properties.Settings.Default.cpl_2 = (collapsiblePanel_teacher.PanelState == Salamander.Windows.Forms.PanelState.Expanded ? true : false);
            Properties.Settings.Default.Save();
        }
        private void collapsiblePanel_report_PanelStateChanged(object sender, Salamander.Windows.Forms.PanelEventArgs e)
        {
            Properties.Settings.Default.cpl_3 = (collapsiblePanel_report.PanelState == Salamander.Windows.Forms.PanelState.Expanded ? true : false);
            Properties.Settings.Default.Save();
        }
        private void collapsiblePanel_firstsetting_PanelStateChanged(object sender, Salamander.Windows.Forms.PanelEventArgs e)
        {
            Properties.Settings.Default.cpl_4 = (collapsiblePanel_firstsetting.PanelState == Salamander.Windows.Forms.PanelState.Expanded ? true : false);
            Properties.Settings.Default.Save();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                System.Windows.Forms.SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "(*.smb)|*.smb";
                saveFileDialog1.Title = "مسیر ذخیرسازی را مشخص نمایید ";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    System.IO.File.Copy(Application.StartupPath + "\\data.mdb", saveFileDialog1.FileName, true);
                    lbl_message.Text = "عملیات پشتیبان گیری با موفقیت انجام شد";
                    timer3.Enabled = true;
                    dt = DateTime.Now;
                    Properties.Settings.Default.datebackup = "   " + pc.GetYear(dt).ToString() + "/" + (pc.GetMonth(dt).ToString().Length == 1 ? "0" + pc.GetMonth(dt).ToString() : pc.GetMonth(dt).ToString()) + "/" + (pc.GetDayOfMonth(dt).ToString().Length == 1 ? "0" + pc.GetDayOfMonth(dt).ToString() : pc.GetDayOfMonth(dt).ToString());
                    Properties.Settings.Default.Save();
                    lbl_messagedate.Text = "تاریخ آخرین پشتیبان :" + Properties.Settings.Default.datebackup;
                }
            }
            catch (ArgumentException)
            {
            }
            catch (Exception ex)
            {
                frm_exception frm = new frm_exception(ex.Message + "\n\n" + ex.StackTrace);
                frm.ShowDialog();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                System.Windows.Forms.OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "(*.smb)|*.smb";
                openFileDialog1.Title = "مسیر فایل پشتیبان را مشخص نمایید ";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    frm_messageboxwithpass frmmb = new frm_messageboxwithpass();
                    frmmb.lbl_messeage.Text = "آیا مایل هستید که اطلاعات فعلی پاک شود و اطلاعات فایل پشتیبان جایگذاری گردد ؟";
                    if (frmmb.ShowDialog() == DialogResult.Yes)
                    {
                        frm_getpassword gp = new frm_getpassword();
                        gp.label2.Text = "برای بازیابی پشتیبان رمز را وارد کنید";
                        gp.btn_exit.Text = "انصراف";
                        if (gp.ShowDialog() == DialogResult.OK)
                        {
                            System.IO.File.Copy(openFileDialog1.FileName, Application.StartupPath + "\\data.mdb", true);
                            System.IO.File.SetAttributes(Application.StartupPath + "\\data.mdb", System.IO.FileAttributes.Normal);
                            lbl_message.Text = "فایل پشتیبان به طور کامل بارگذاری شد ";
                            timer3.Enabled = true;
                        }
                    }
                }
            }
            catch (ArgumentException)
            {
            }
        }
        private void MenuItem_about_Click(object sender, EventArgs e)
        {
            try
            {
                AboutBox frm_about = new AboutBox();
                frm_about.ShowDialog();
            }
            catch (Exception ex)
            {
                frm_exception frm = new frm_exception(ex.Message + "\n\n" + ex.StackTrace);
                frm.ShowDialog();
            }
        }
        private void MenuItem_learnsoftware_Click(object sender, EventArgs e)
        {
            Help frm = new Help();
            frm.ShowDialog();

            //MessageBox.Show("فایــل راهنمـا پیــدا نشد ");
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                frm_setpassword formpass = new frm_setpassword();
                formpass.ShowDialog();
            }
            catch (Exception ex)
            {
                frm_exception frm = new frm_exception(ex.Message + "\n\n" + ex.StackTrace);
                frm.ShowDialog();
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                linkLabel1_LinkClicked(null, null);
            }
            catch (Exception ex)
            {
                frm_exception frm = new frm_exception(ex.Message + "\n\n" + ex.StackTrace);
                frm.ShowDialog();
            }
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            counter++;
            if (counter == 5)
            {
                lbl_message.Text = "";
                counter = 0;
                timer3.Enabled = false;
            }
        }
        private void timer4_Tick(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.proc_finish)
            {
                timer4.Enabled = false;
                frm_p.Close();
                Properties.Settings.Default.proc_finish = true;
            }
        }
        private void cpl_Rteacher_Click(object sender, EventArgs e)
        {
            try
            {
                frm_workteacher frm = new frm_workteacher();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                frm_exception frm = new frm_exception(ex.Message + "\n\n" + ex.StackTrace);
                frm.ShowDialog();
            }
            /*frm_st_teacher form = new frm_st_teacher();
            form.isforperint = true;
            form.ShowDialog();*/
        }
        private void nemodarMenuItem_Click(object sender, EventArgs e)
        {
            frm_nemodare_darsi frm = new frm_nemodare_darsi();
            frm.ShowDialog();
        }
        private void bajozyatMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frm_selectclass_mali frms = new frm_selectclass_mali();
                if (frms.ShowDialog() == DialogResult.Cancel)
                {
                    return;
                }
                else
                {
                    frm_preview frmp = new frm_preview();
                    if (frms.radioButton2.Checked)
                    {
                        malitableTableAdapter.Fill(dsp_mali.malitable);
                        remainderTableAdapter.Fill(dsp_mali.remainder);
                    }
                    else
                    {
                        malitableTableAdapter.FillByclass(dsp_mali.malitable, Int32.Parse(frms.comboBox1.SelectedValue.ToString()));
                        remainderTableAdapter.FillByclass(dsp_mali.remainder, Int32.Parse(frms.comboBox1.SelectedValue.ToString()));
                    }
                    double x = 0;
                    try
                    {
                        if (frms.radioButton2.Checked)
                            x = (double)remainderTableAdapter.sumcost();
                        else
                            x = (double)remainderTableAdapter.sumcost_by_class(Int32.Parse(frms.comboBox1.SelectedValue.ToString()));
                    }
                    catch {/************************/ }
                    System.Data.DataSet ds = new System.Data.DataSet();
                    ds.Tables.Add((DataTable)dsp_mali.malitable.Copy());
                    ds.Tables.Add((DataTable)dsp_mali.remainder.Copy());
                    frmp.ds = ds;
                    frmp.x = x;
                    frmp.strhead = (frms.radioButton2.Checked ? "گزارش مالي كلي" : "گزارش مالي از كلاس " + frms.comboBox1.Text);
                    frmp.Reportsource = "mali";
                    frmp.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                frm_exception frm = new frm_exception(ex.Message + "\n\n" + ex.StackTrace);
                frm.ShowDialog();
            }
        }
        private void bedonejozyatMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frm_selectclass_mali frms = new frm_selectclass_mali();
                if (frms.ShowDialog() == DialogResult.Cancel)
                {
                    return;
                }
                else
                {

                    frm_preview frmp = new frm_preview();
                    if (frms.radioButton2.Checked)
                        vaziatmaliTableAdapter.Fill(dsp_mali2.vaziatmali);
                    else
                        vaziatmaliTableAdapter.FillByclass(dsp_mali2.vaziatmali, Int32.Parse(frms.comboBox1.SelectedValue.ToString()));
                    for (int index = 0; index < dsp_mali2.vaziatmali.Count; index++)
                    {
                        if (dsp_mali2.vaziatmali.Rows[index]["lessen"].ToString() != "" &&
                            dsp_mali2.vaziatmali.Rows[index]["mande"].ToString() == "")
                        {
                            dsp_mali2.vaziatmali.Rows[index].BeginEdit();
                            dsp_mali2.vaziatmali.Rows[index]["mande"] = dsp_mali2.vaziatmali.Rows[index]["lessen"].ToString();
                            dsp_mali2.vaziatmali.Rows[index].EndEdit();
                        }
                    }
                    System.Data.DataSet ds = new System.Data.DataSet();
                    ds.Tables.Add((DataTable)dsp_mali2.vaziatmali.Copy());
                    frmp.strhead = (frms.radioButton2.Checked ? "گزارش مالي كلي" : "گزارش مالي از كلاس " + frms.comboBox1.Text);
                    frmp.ds = ds;
                    frmp.Reportsource = "mali_2";
                    frmp.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                frm_exception frm = new frm_exception(ex.Message + "\n\n" + ex.StackTrace);
                frm.ShowDialog();
            }
        }
        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {

        }
        private void Frm_Main_Shown(object sender, EventArgs e)
        {
            string schoolname = Properties.Settings.Default.schoolname;
            double s = 0;
            foreach (char ch in schoolname)
            {
                s += ((double)ch) * 2 + s;
            }
            s += 2291602;
            string read = System.IO.File.ReadAllText(strpath + "setting.ini");
            if (read != (s.ToString() + "584"))
            {
                //lbl_reg.Text = "";
                DialogResult dr = DialogResult.None;
                register frmreg = null;
                while (dr != DialogResult.OK)
                {
                    frmreg = new register();
                    dr = frmreg.ShowDialog();
                    if (dr == DialogResult.Ignore || dr == DialogResult.Retry) break;
                }
                if (dr == DialogResult.Ignore) { Opacity = 0; Close(); }
                if (Properties.Settings.Default.Rcount == 1 && read == "0") { Opacity = 0; Close(); }
                if (Properties.Settings.Default.Rcount == 1 && read.Length > 4)
                { Opacity = 0; Close(); }
                else if (Properties.Settings.Default.Rcount == -1)
                    lbl_reg.Text = "";
            }
            frmsplash.iamclose = true;
            frmsplash.Close();
        }
        private void lbl_reg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                register frmreg = new register();
                frmreg.ShowDialog();
                if (Properties.Settings.Default.Rcount == -1)
                    lbl_reg.Text = "";
            }
            catch (Exception ex)
            {
                frm_exception frm = new frm_exception(ex.Message + "\n\n" + ex.StackTrace);
                frm.ShowDialog();
            }
        }
        private void پرینتکارنامهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frm_listnumber form = new frm_listnumber();
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                frm_exception frm = new frm_exception(ex.Message + "\n\n" + ex.StackTrace);
                frm.ShowDialog();
            }
        }
        private void نموداردرسیمیانگینکلاسToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nemodarMenuItem_Click(null, null);
        }
        private void گزارشکاریمعلمToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frm_workteacher frm = new frm_workteacher();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                frm_exception frm = new frm_exception(ex.Message + "\n\n" + ex.StackTrace);
                frm.ShowDialog();
            }
        }
        private void studentlistfromav(object sender, EventArgs e)
        {
            try
            {
                frm_student_av_list frm = new frm_student_av_list();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                frm_exception frm = new frm_exception(ex.Message + "\n\n" + ex.StackTrace);
                frm.ShowDialog();
            }
        }
        private void enferadi(object sender, EventArgs e)
        {
            try
            {
                frm_choosest form = new frm_choosest();
                form.Isforprint = true;
                form.Opacity = 0;
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                frm_exception frm = new frm_exception(ex.Message + "\n\n" + ex.StackTrace);
                frm.ShowDialog();
            }
        }
        private void گزارشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frm_selectclass frm = new frm_selectclass();
                frm.usefor = "behavclass";
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                frm_exception frm = new frm_exception(ex.Message + "\n\n" + ex.StackTrace);
                frm.ShowDialog();
            }
        }
        private void cpl_Rtofamily_Click(object sender, EventArgs e)
        {
            try
            {
                frm_reporttofamily frm = new frm_reporttofamily();
                frm.Opacity = 0;
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                frm_exception frm = new frm_exception(ex.Message + "\n\n" + ex.StackTrace);
                frm.ShowDialog();
            }
        }
        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            try
            {
                studentlistfromav(null, null);
            }
            catch (Exception ex)
            {
                frm_exception frm = new frm_exception(ex.Message + "\n\n" + ex.StackTrace);
                frm.ShowDialog();
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (frmsplash.iamclose)
            {

                if (this.WindowState != FormWindowState.Maximized)
                {
                    this.WindowState = FormWindowState.Maximized;
                    collapsiblePanel1.PanelState = Salamander.Windows.Forms.PanelState.Collapsed;
                    collapsiblePanel1.PanelState = Salamander.Windows.Forms.PanelState.Expanded;
                    // collapsiblePanel_student.PanelState = Salamander.Windows.Forms.PanelState.Collapsed;
                    // collapsiblePanel_student.PanelState = Salamander.Windows.Forms.PanelState.Expanded;
                    // collapsiblePanel_student.PanelState = (Properties.Settings.Default.cpl_1 ? Salamander.Windows.Forms.PanelState.Expanded : Salamander.Windows.Forms.PanelState.Collapsed);
                    Refresh();
                }
                if (Opacity < 1)
                {
                    if (Opacity < 1) Opacity += 0.1;
                }
                else
                {
                    timer2.Enabled = false;
                    Opacity = 1;
                    timer2.Dispose();
                    frmsplash.Dispose();
                    Refresh();
                }
            }
        }
        private void StatusLabel1_ButtonClick(object sender, EventArgs e)
        {
            frm_datechange frm = new frm_datechange();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                lbl_message.Text = "تاریخ سیسـتم به روز شد";
                timer3.Enabled = true;
            }
        }

        private void cpl_behavirscore_Click(object sender, EventArgs e)
        {
            frm_behaviourscore frm = new frm_behaviourscore();
            frm.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ypath = Application.ExecutablePath.ToString().Substring(0, Application.ExecutablePath.ToString().Length - 21);
            System.IO.File.Copy(ypath + "data.mdb", ypath + "\\years\\" + (Student.Properties.Settings.Default.db == "" ? comboBox1.Text : Student.Properties.Settings.Default.db) + ".mdb", true);
            System.IO.File.Copy(ypath + "\\years\\" + comboBox1.Text + ".mdb", ypath + "data.mdb", true);
            Student.Properties.Settings.Default.db = comboBox1.Text;
            Student.Properties.Settings.Default.Save();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm_db frm = new frm_db();
            frm.ShowDialog();
            comboBox1.Items.Clear();
            string ypath = Application.ExecutablePath.ToString().Substring(0, Application.ExecutablePath.ToString().Length - 21);
            string[] strs = System.IO.Directory.GetFiles(ypath + "years\\");
            foreach (string stemp in strs)
                comboBox1.Items.Add(System.IO.Path.GetFileName(stemp).Substring(0, System.IO.Path.GetFileName(stemp).Length - 4));
            if (Student.Properties.Settings.Default.db == "")
            {
                MessageBox.Show("لطفا ابتدا اسم ديتابيس جاري را انتخاب نماييد تا عمليات نگاشت بدرستي انجام گيرد");
            }
            else
            {
                comboBox1.SelectedItem = Student.Properties.Settings.Default.db;

            }
        }
        private void toolstrip_mali_hazyne_mored_Click(object sender, EventArgs e)
        {
            frm_report_hazyneha frm = new frm_report_hazyneha();
            frm.ShowDialog();
        }
        private void toolstrip_gozareshkoli_Click(object sender, EventArgs e)
        {
            frm_report_cost_koli frm = new frm_report_cost_koli();
            frm.ShowDialog();
        }
        private void باجزئیاتاقساطToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bajozyatMenuItem_Click(null, null);
        }
        private void بدونجزئیاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bedonejozyatMenuItem_Click(null, null);
        }
        private void bcp_hamahang_Click(object sender, EventArgs e)
        {
            frm_hamahang frm = new frm_hamahang();
            frm.ShowDialog();
        }
        private void cpl_hamahang_Click(object sender, EventArgs e)
        {
            frm_print_hamahang frm = new frm_print_hamahang();
            frm.ShowDialog();
        }

        private void shortcut_tanzim_nomrate_akhlaghi_Click(object sender, EventArgs e)
        {
            frm_behaviourscore frm = new frm_behaviourscore();
            frm.ShowDialog();
        }

        private void shortcut2_tanzime_akhlaghi_Click(object sender, EventArgs e)
        {
            frm_behaviourscore frm = new frm_behaviourscore();
            frm.ShowDialog();
        }

        private void shortcut_report_hamahang_Click(object sender, EventArgs e)
        {
            frm_print_hamahang frm = new frm_print_hamahang();
            frm.ShowDialog();
        }

        private void shortcut_hamahang_Click(object sender, EventArgs e)
        {
            frm_hamahang frm = new frm_hamahang();
            frm.ShowDialog();
        }

        private void shortcut_reportlesson1_Click(object sender, EventArgs e)
        {
            try
            {
                print_lesson form = new print_lesson();
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                frm_exception frm = new frm_exception(ex.Message + "\n\n" + ex.StackTrace);
                frm.ShowDialog();
            }
        }

        private void shortcut_reportlesson2_Click(object sender, EventArgs e)
        {
            try
            {
                frm_listnumber frm = new frm_listnumber();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                frm_exception frm = new frm_exception(ex.Message + "\n\n" + ex.StackTrace);
                frm.ShowDialog();
            }
        }

        private void cpl_Rkarname_Click(object sender, EventArgs e)
        {
            try
            {
                contextMenu_lesson.Show((Control)cpl_Rkarname, new Point(cpl_Rkarname.Location.X, cpl_Rkarname.Location.Y - 105));
            }
            catch (Exception ex)
            {
                frm_exception frm = new frm_exception(ex.Message + "\n\n" + ex.StackTrace);
                frm.ShowDialog();
            }
        }

        private void kry_list_number_Click(object sender, EventArgs e)
        {
            try
            {
                contextMenu_listnumber.Show((Control)kry_list_number, new Point(kry_list_number.Location.X, kry_list_number.Location.Y - 220));
            }
            catch (Exception ex)
            {
                frm_exception frm = new frm_exception(ex.Message + "\n\n" + ex.StackTrace);
                frm.ShowDialog();
            }
        }
        private void ln_taki_Click(object sender, EventArgs e)
        {
            print_list_number pln = new print_list_number();
            pln.ShowDialog();
        }
        private void ln_chandtai_Click(object sender, EventArgs e)
        {
            print_list_number_2 frm = new print_list_number_2();
            frm.ShowDialog();
        }
        private void toolstrip_arm_Click(object sender, EventArgs e)
        {
            frm_arm frm = new frm_arm();
            frm.ShowDialog();
        }
        private void cpl_tahlili_Click(object sender, EventArgs e)
        {
            //  try
            {
                contextMenuStrip_tahlili.Show((Control)cpl_Rmali, new Point(cpl_tahlili.Location.X, cpl_tahlili.Location.Y - 150));
            }
            //  catch (Exception ex)
            {
                //      frm_exception frm = new frm_exception(ex.Message + "\n\n" + ex.StackTrace);
                //      frm.ShowDialog();
            }

        }
        private void tahlili_class_salane_Click(object sender, EventArgs e)
        {
            frm_class_salane frm = new frm_class_salane();
            frm.ShowDialog();
        }
        private void ravad_salane_Click(object sender, EventArgs e)
        {
            frm_ravand_salane frm = new frm_ravand_salane();
            frm.ShowDialog();
        }

        private void salane_faravani_Click(object sender, EventArgs e)
        {
            frm_faravani frm = new frm_faravani();
            frm.ShowDialog();
        }
    }
}