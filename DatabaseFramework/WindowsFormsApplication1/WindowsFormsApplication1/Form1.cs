using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using SandBox;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();

            //SandBox s = new SandBox(@"Data Source=RTHOR-PC\SQL2008R2;Initial Catalog=SandBox;Integrated Security=True");
            SandBoxEntities se = new SandBoxEntities(
            int x  = s.Entities.Count();

            var dr = s.Entities_GetTop300ByData();
            foreach (var v in dr)
            {
                //Console.WriteLine(v.EntityID.GetType().ToString());
                Console.WriteLine(v.EntityGUID.ToString());
            }
            
        }
    }
}
