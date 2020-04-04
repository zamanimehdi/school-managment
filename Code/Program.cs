using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Student
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {

            string str = "";
            for (int i = 0; i < args.Length; i++) str += args[i] + " ";
            if (args.Length != 0)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new frm_restorebackup(str));
            }
            else
            {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new Frm_Main());
            }

        }
    }
}