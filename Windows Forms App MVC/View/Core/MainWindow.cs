using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Forms_App_MVC
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Returns the Display Panel where the pages will be displayed.
        /// </summary>
        public Panel GetDisplayPanel()
        {
            return DisplayPanel;
        }

        /// <summary>
        /// Returns the panel where the page buttons lies.
        /// </summary>
        public FlowLayoutPanel GetMenu()
        {
            return ButtonFlowPanel;
        }

        /// <summary>
        /// Returns the panel where the whole content of the main window lies.
        /// </summary>
        public TableLayoutPanel GetWholeWindow()
        {
            return MainWindowPanel;
        }

        /// <summary>
        /// Returns the status label in the lower part of the main window.
        /// </summary>
        public Label GetStatusLabel()
        {
            return DisplayLabel;
        }
    }
}