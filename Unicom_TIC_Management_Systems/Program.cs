﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unicom_TIC_Management_Systems.Data;

namespace Unicom_TIC_Management_Systems
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Migration.CreatetablenotExists();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
        }
    }
}
