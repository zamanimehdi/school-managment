using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Runtime.InteropServices;

namespace Student
{
    public partial class frm_datechange : Form
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct SYSTEMTIME
        {
            public short wYear;
            public short wMonth;
            public short wDayOfWeek;
            public short wDay;
            public short wHour;
            public short wMinute;
            public short wSecond;
            public short wMilliseconds;
        }
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool SetSystemTime([In] ref SYSTEMTIME st);
        public frm_datechange()
        {
            InitializeComponent();
        }
        private void datechange_Load(object sender, EventArgs e)
        {

        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            can c = new can();
            if (c.checkempty(txt_day, txt_mon, txt_year) & c.isnumber(txt_day.Text) & c.isnumber(txt_mon.Text) & c.isnumber(txt_year.Text))
            {
                try
                {
                    System.Globalization.PersianCalendar pc = new System.Globalization.PersianCalendar();

                    DateTime dt = pc.ToDateTime(int.Parse("13" + txt_year.Text), int.Parse(txt_mon.Text), int.Parse(txt_day.Text), DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second, DateTime.Now.Millisecond, 0);
                    SYSTEMTIME SysTime = new SYSTEMTIME();
                    SysTime.wYear = (short)dt.Year;
                    SysTime.wMonth = (short)dt.Month;
                    SysTime.wDay = (short)dt.Day;
                    SysTime.wHour = (short)dt.Hour; ;
                    SysTime.wMinute = (short)dt.Minute; ;
                    SysTime.wSecond = (short)dt.Second; ;
                    SysTime.wMilliseconds = (short)dt.Millisecond; ;
                    SetSystemTime(ref SysTime);
                    DialogResult = DialogResult.OK;
                    //MessageBox.Show(SysTime.wYear.ToString() + " " + SysTime.wMonth.ToString() + " " + SysTime.wDay.ToString());
                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("تاریخ وارد شده نا معتبر است");
                }
                catch (Exception ex)
                {
                    frm_exception frm = new frm_exception(ex.Message);
                    frm.ShowDialog();
                }
            }
            else
                MessageBox.Show("اطلاعات وارد شده صحیح نمی باشد");
        }
        private void leavecolor(object sender, EventArgs e)
        {
            if (((Control)sender).BackColor != Color.LightPink)
                ((Control)sender).BackColor = Color.Empty;
        }
        private void entercolor(object sender, EventArgs e)
        {
            ((Control)sender).BackColor = Color.SeaShell;
        }
        private void txt_year_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txt_mon.Focus();
        }
        private void txt_mon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txt_day.Focus();
        }
        private void txt_day_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_save.Focus();
        }
    }
}