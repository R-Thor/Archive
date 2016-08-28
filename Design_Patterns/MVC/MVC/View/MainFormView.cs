using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MVC.View
{
    public partial class MainFormView : Form
    {
        public MenuStrip MainViewMainMenuStrip { get { return (this.mainMenuStrip); } set { mainMenuStrip = value; } }
        public MainFormView()
        {
            InitializeComponent();
        }

        //private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        //{

        //}
    }
}
