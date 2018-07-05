using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows_Forms_App_MVC.Controller;

namespace Windows_Forms_App_MVC.Common
{
    public class Controller : ControllerBase
    {
        private readonly Control control;
        private readonly MainWindow mainWindow;
        private Controller controller;

        protected Controller() { }

        /// <summary>
        /// Initializes the Controller
        /// </summary>
        /// <param name="mainWindow">The Main Window</param>
        /// <param name="control">The UserControl or the view to be initialized.</param>
        public Controller(MainWindow mainWindow, Control control)
        {
            this.mainWindow = mainWindow;
            this.control = control;
        }

        /// <summary>
        /// Initializes the Controller
        /// </summary>
        /// <param name="mainWindow">The Main Window where .</param>
        /// <param name="control">The UserControl or the view to be initialized.</param>
        /// <param name="controller">The Binded Controller for the UserControl.</param>
        public Controller(MainWindow mainWindow, Control control, Controller controller)
        {
            this.mainWindow = mainWindow;
            this.control = control;
            this.controller = controller;
        }

        /// <summary>
        /// The event handler when a page button is clicked. It directs it to
        /// another page.
        /// </summary>
        /// <param name="sender">The page button</param>
        /// <param name="e">Event Args</param>
        public void GotoController(object sender, EventArgs e)
        {
            mainWindow.GetDisplayPanel().Controls.Clear();
            mainWindow.GetDisplayPanel().Controls.Add(control);
            mainWindow.Dock = DockStyle.Fill;
            mainWindow.GetStatusLabel().Text = $"Welcome to {control.Name}!";
        }

        /// <summary>
        /// Invokes the Index method of every controller.
        /// </summary>
        /// <param name="control">The controller</param>
        public void MethodInvokerer(Control control)
        {
            try
            {
                Type type = controller.GetType();
                var invoker = type.GetMethod("Index");
                invoker.Invoke(controller, null);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
