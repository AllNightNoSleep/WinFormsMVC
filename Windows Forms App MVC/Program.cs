using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows_Forms_App_MVC.Controller.Core;

namespace Windows_Forms_App_MVC
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

            MainWindow mainWindow = new MainWindow();
            MainController main = new MainController(mainWindow);
            
            Application.Run(mainWindow);
        }
    }
}
