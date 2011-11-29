using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Codaxy.Dextop.Localizer.Windows
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            String fileName = args.Length > 0 ? args[0] : null;
            Application.Run(new Windows.Forms.MainWindow(fileName));
        }
    }
}
