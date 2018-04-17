using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program4
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SystemParametersInfo(4107, 0, 1, 0);//always show accelerator underlines
            Application.Run(new Program4());
        }
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int SystemParametersInfo(int uAction, int uParam, int lpvParam, int fuWinIni);

    }
}
