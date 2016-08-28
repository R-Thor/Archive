using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MVC.Control;

namespace MVC
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            
            Application.SetCompatibleTextRenderingDefault(false);

            MainController mc = new MainController();
            mc.Start();
            
            //ApplicationContext applicationContext = new ApplicationContext();

            //Application.Run();
        }
    }
}
