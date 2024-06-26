﻿using STUDENT_MANAGEMENT_SYSTEM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student_management_system
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            LoginMenu login = new LoginMenu();

            if (login.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new SystemMenu());
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
