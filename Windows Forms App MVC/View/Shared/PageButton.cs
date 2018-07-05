using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Windows_Forms_App_MVC.Common;
using Windows_Forms_App_MVC.View.Shared;
using System.Drawing;

namespace Windows_Forms_App_MVC
{
    public partial class PageButton : UserControl, IButton
    {
        private MainWindow mainWindow;

        public PageButton()
        {
            InitializeComponent();
        }

        public PageButton(MainWindow mainWindow, string controllerName = "Controller")
        { 
            InitializeComponent();
            this.mainWindow = mainWindow;
            ButtonLabel.Text = controllerName;
        }

        public Label GetButtonLabel()
        {
            return ButtonLabel;
        }

        /// <summary>
        /// Returns the symbol needed for the page buttons.
        /// </summary>
        /// <param name="status">The show/hide status of the button. If show then true. If hide then false.</param>
        public void GetSymbol(bool status)
        {
            if (!status)
            {
                ButtonSymbolUp.Show();
                ButtonSymbolDown.Hide();
            }
            else
            {
                ButtonSymbolDown.Show();
                ButtonSymbolUp.Hide();
            }
                
        }

        private void PageButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
