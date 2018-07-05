using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Forms_App_MVC.Common
{
    public abstract class ControllerBase : IController
    {
        public ViewDataDictionary ViewData { get; set; }
        public object ViewBag { get; }
        protected ControllerBase(){}

        public void Execute() { }

        public virtual void Index(){}
    }
}
