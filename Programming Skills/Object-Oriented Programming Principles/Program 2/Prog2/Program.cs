﻿// Program 2
// CIS 200-01
// Due Date: 03/10/2017 11:59:59PM
// By: D7611

// File: Program.cs
// This file facilitates the execution of a Windows Form Application.
namespace LibraryItems
{
    using System.Windows.Forms;
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [System.STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SystemParametersInfo(4107, 0, 1, 0); //Always show accelerator underlines
            Application.Run(new LibraryDriver());
        }
        
        //This Imported method allows for the modification of the display of Windows Form Applications.
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int SystemParametersInfo(int uAction, int uParam, int lpvParam, int fuWinIni);
    }
}