using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Windows_Forms_App_MVC.Common;
using Windows_Forms_App_MVC.Controller;
using Windows_Forms_App_MVC.View.Home;
using Windows_Forms_App_MVC.View.Shared;

namespace Windows_Forms_App_MVC
{
    public abstract class Main
    {
        /// <summary>
        /// Get the namespace
        /// </summary>
        public string namespaceName = typeof(Program).Namespace;
        public string namespaceNameController = typeof(Program).Namespace + ".Controller";
        public string namespaceNameView = typeof(Program).Namespace + ".View";

        /// <summary>
        /// The Main window.
        /// </summary>
        private readonly MainWindow mainWindow;

        /// <summary>
        /// Initializes the Main window and its components.
        /// </summary>
        /// <param name="mainWindow">The Main Window</param>
        public Main(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            AddEventsToControllersAndToPage();
        }

        /// <summary>
        /// Add click event handlers to the pages passed here and add them to the main window.
        /// </summary>
        /// <param name="name">Name of the pager.</param>
        private void AddEventsToControllersAndToPage(string name = null)
        {
            foreach (var page in PageControllers())
            {
                var pageButton = new PageButton(mainWindow, page.Key);
                pageButton.Click += new EventHandler(PageButtonClickEvent);
                
                if(name == page.Key)
                {
                    pageButton.BackColor = Color.Aqua;
                    pageButton.GetSymbol(true);
                    mainWindow.GetMenu().Controls.Add(pageButton);
                    foreach (var subpage in page.Value)
                    {
                        subpage.Key.Click += new EventHandler(subpage.Value.GotoController);
                        mainWindow.GetMenu().Controls.Add(subpage.Key as SubPageButton);
                    }
                }
                else
                {
                    mainWindow.GetMenu().Controls.Add(pageButton);
                }
            }
        }

        private void PageButtonClickEvent(object sender, EventArgs e)
        {
            string pageName = ((PageButton)sender).GetButtonLabel().Text;
            mainWindow.GetMenu().Controls.Clear();
            AddEventsToControllersAndToPage(pageName);
        }

        /// <summary>
        /// Make a dictionary of the controllers and the subpages of that controller depending on it's view.
        /// </summary>
        private Dictionary<string, Dictionary<IButton, Common.Controller>> PageControllers()
        {
            var collection = new Dictionary<string, Dictionary<IButton, Common.Controller>>();

            /// Get the types in the controller folder.
            Type[] typelist = GetTypesInNamespace(Assembly.GetExecutingAssembly(), namespaceNameController);

            /// Foreach controller, add button
            foreach (var item in typelist)
            {
                /// Remove the Controller from the class name
                string name = item.Name.Replace("Controller", "");

                /// Get the types in the View + name of the (controller - "Controller")
                Type[] typelistInView = GetTypesInNamespace(Assembly.GetExecutingAssembly(), namespaceNameView + "." + name);

                /// Create the collection of the subpages per page
                var subPages = new Dictionary<IButton, Common.Controller>();

                /// Foreach user control in the {name of the (controller - "Controller")} folder,
                /// create subpagebutton
                foreach (var userControl in typelistInView)
                {
                    /// Know if the type listed is a user control, otherwise ignores it.
                    if(userControl.BaseType == typeof(UserControl))
                    {
                        /// Get control instance to be passed on controller
                        var controlInstance = (Control)Activator.CreateInstance(userControl);
                        /// Get controller instance to be passed on controller
                        var controllerInstance = (Common.Controller)Activator.CreateInstance(item);

                        /// create subpage
                        subPages.Add(new SubPageButton(userControl.Name), new Common.Controller(mainWindow, controlInstance, controllerInstance));
                    }         
                }

                /// Add the collection of subpages to the collection of pages
                collection.Add(name, subPages);
            }

            return collection;
        }
        
        /// <summary>
        /// Get the types in the specified namespace of the program
        /// </summary>
        /// <param name="assembly">The executing assembly</param>
        /// <param name="nameSpace">The namespace of the current program</param>
        /// <returns></returns>
        private Type[] GetTypesInNamespace(Assembly assembly, string nameSpace)
        {
            return
              assembly.GetTypes()
                      .Where(t => String.Equals(t.Namespace, nameSpace, StringComparison.Ordinal))
                      .ToArray();
        }
    }
}
