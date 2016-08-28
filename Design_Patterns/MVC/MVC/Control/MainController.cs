using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MVC.View;

namespace MVC.Control
{
    internal partial class MainController:BaseController
    {
        MainFormView mainView = new MainFormView();


        public MainController()
        {
            //LoadUser();
        }

        internal void Start()
        {
            Application.Run(mainView);
        }
        //Event Handlers
        void mainView_Load(object sender, EventArgs e)
        {
            //throw new NotImplementedException();

        }
        void mainView_Shown(object sender, EventArgs e)
        {

        }
        void mainView_FormClosing(object sender, FormClosingEventArgs e)
        {
            //throw new NotImplementedException();
        }
        void mainView_FormClosed(object sender, FormClosedEventArgs e)
        {
            //throw new NotImplementedException();
        }
        void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Event Handlers
        //Tasks
        //Tasks.ExitApplication

        //Tasks.GetWIC
        //Tasks.UpdateWIC
        //Tasks.DeleteWIC
        //Tasks.SearchForSecurity
        //Tasks.SearchSecurity

        //Services MaintainCurrentBOWIC



        //protected override void SubscribeControllerToView()
        //{
        //    throw new NotImplementedException();
        //}

        //protected override void SubsctribeModelToView()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
