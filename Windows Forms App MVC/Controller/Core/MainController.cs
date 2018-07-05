using System.Collections.Generic;
using Windows_Forms_App_MVC.Common;

namespace Windows_Forms_App_MVC.Controller.Core
{
    public class MainController : Main, IController
    {
        private readonly MainWindow mainWindow;

        /// <summary>
        /// Initializes the Main window and its components.
        /// </summary>
        /// <param name="mainWindow">The Main Window</param>
        public MainController(MainWindow mainWindow) : base(mainWindow)
        {
            this.mainWindow = mainWindow;
        }

        public void Execute() {}

        public void Index() {}
    }
}
