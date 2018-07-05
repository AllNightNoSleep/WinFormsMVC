using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows_Forms_App_MVC.Common
{
    public interface IController
    {
        void Execute();

        void Index();
    }
}
