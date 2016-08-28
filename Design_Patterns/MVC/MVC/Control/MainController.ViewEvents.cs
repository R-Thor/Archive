using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MVC.View;

namespace MVC.Control
{
    internal partial class MainController
    {
        internal override void  CaptureViewEvents()
        {
            mainView.Load += new EventHandler(mainView_Load);
            mainView.Shown += new EventHandler(mainView_Shown);
            mainView.FormClosing += new FormClosingEventHandler(mainView_FormClosing);
            mainView.FormClosed += new FormClosedEventHandler(mainView_FormClosed);
            ((ToolStripMenuItem)mainView.MainViewMainMenuStrip.Items["optionToolStripMenuItem"]).DropDownItems["exitToolStripMenuItem"].Click += new EventHandler(exitToolStripMenuItem_Click);
        }
    }
}
