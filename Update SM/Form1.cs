using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace Update_SM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            foreach (System.Diagnostics.Process clsProcess in System.Diagnostics.Process.GetProcesses())
                if (clsProcess.ProcessName.StartsWith("school management") || clsProcess.ProcessName.StartsWith("Internet SM"))
                {
                    MessageBox.Show("برنامه مدیریت مدرسه به طور خودکار بسته خواهد شد");
                    clsProcess.Kill();
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            WebClient wc = new WebClient();
            wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(wc_DownloadProgressChanged);
            wc.DownloadFileCompleted += new AsyncCompletedEventHandler(step2);
            System.Uri u = new Uri("http://www.msmsoft.ir/sm/Internet SM.exe");
            wc.DownloadFileAsync(u, "download_internet_sm.exe");
        }
        public void wc_DownloadProgressChanged(Object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }
        public void wc_DownloadProgressChanged2(Object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar2.Value = e.ProgressPercentage;
        }
        public void step2(Object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show("خطا هنگام دریافت فایل بروز رسانی از سرور"+"\r\n"+e.Error.Message,"خطا"); 
                groupBox1.Enabled = false;
                button1.Enabled = false;
                return;
            }
            WebClient wc2 = new WebClient();
            wc2.DownloadProgressChanged += new DownloadProgressChangedEventHandler(wc_DownloadProgressChanged2);
            wc2.DownloadFileCompleted += new AsyncCompletedEventHandler(step3);
            System.Uri u2 = new Uri("http://www.msmsoft.ir/sm/school management.exe");
            wc2.DownloadFileAsync(u2, "download_sm.exe");
        }
        public void step3(Object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show("خطا هنگام دریافت فایل بروز رسانی از سرور" + "\r\n" + e.Error.Message, "خطا");
                groupBox1.Enabled = false;
                button1.Enabled = false;
                return;
            }
           
            System.IO.File.Copy("download_internet_sm.exe", "Internet SM.exe", true);
            System.IO.File.Copy("download_sm.exe", "school management.exe", true);
            groupBox1.Enabled = false;
            button1.Enabled = false;
            try
            {
                if (System.IO.File.Exists("ver.txt")) System.IO.File.Delete("ver.txt");
                if (System.IO.File.Exists("download_internet_sm.exe")) System.IO.File.Delete("download_internet_sm.exe");
                if (System.IO.File.Exists("download_sm.exe")) System.IO.File.Delete("download_sm.exe");
            }
            catch { }
            MessageBox.Show("برنامه با موفقیت به روز رسانی گردید");

        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            try
            {
                if (System.IO.File.Exists("ver.txt")) System.IO.File.Delete("ver.txt");
                if (System.IO.File.Exists("download_internet_sm.exe")) System.IO.File.Delete("download_internet_sm.exe");
                if (System.IO.File.Exists("download_sm.exe")) System.IO.File.Delete("download_sm.exe");
            }
            catch{}
            Refresh();
            WebClient wc2 = new WebClient();
            wc2.DownloadProgressChanged += new DownloadProgressChangedEventHandler(wc_DownloadProgressChanged2);
            System.Uri u2 = new Uri("http://www.msmsoft.ir/sm/ver.txt");
            try
            {
                wc2.DownloadFile(u2, "ver.txt");
            }
            catch (Exception ex)
            {
                if (ex.Message == "Unable to connect to the remote server")
                {
                    MessageBox.Show("عدم دسترسی به سرور" + "\r\n" + "لطفا از اتصال خود به شبکه اینترنت مطمئن شوید");
                    groupBox1.Enabled = false;
                    label6.Text = "- - -";
                    button1.Enabled = false;
                    return;
                }
            }


            try
            {
                System.IO.StreamReader re = System.IO.File.OpenText("ver.txt");
                label6.Text = re.ReadLine();
            }
            catch
            {
                //Could not find file
                MessageBox.Show("در حال حاضر امکان بروز رسانی نرم افزار وجود ندارد");
                label6.Text = "- - -";
                groupBox1.Enabled = false;
                button1.Enabled = false;
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}