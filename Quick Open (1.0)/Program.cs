﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quick_Open__1._0_
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool instanceCountOne = false;

            using (Mutex mutex = new Mutex(true,"QuickOpen",out instanceCountOne)) 
            {
                if (instanceCountOne)
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new Main());
                    mutex.ReleaseMutex();
                }
                else 
                {
                    MessageBox.Show("Quick Open is already running.");
                }
            }


           
        }
    }
}
