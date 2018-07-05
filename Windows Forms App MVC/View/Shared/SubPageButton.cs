using System.Windows.Forms;
using Windows_Forms_App_MVC.Common;

namespace Windows_Forms_App_MVC.View.Shared
{
    public partial class SubPageButton : UserControl, IButton
    {
        public SubPageButton()
        {
            InitializeComponent();
            this.BackColor = System.Drawing.Color.Azure;
        }

        public SubPageButton(string controller)
        {
            InitializeComponent();
            this.BackColor = System.Drawing.Color.Azure;
            SubButtonLabel.Text = controller;
        }

        private void SubPageButton_Click(object sender, System.EventArgs e)
        {
            
        }
    }
}
