using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Forms_App_MVC.Common
{
    public interface IButton
    {
        event EventHandler Click;
    }
}
