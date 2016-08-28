using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MVC.Control
{
    public abstract class BaseController
    {
        //public Form SubscribedView { get; set; }
        internal abstract void InitializeServices();
        internal abstract void CaptureViewEvents();
        public BaseController()
        {
            InitializeServices();
            CaptureViewEvents();
        }
    }
}
