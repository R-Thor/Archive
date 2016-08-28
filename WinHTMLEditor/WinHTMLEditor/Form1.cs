using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinHTMLEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            webBrowser1.DocumentText = string.Format("<HTML><BODY contentEditable='true'><p style='font-family:Georgia; font-size:7pt'>{0}</p></BODY></HTML>", "Add Text Here");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string x  = webBrowser1.DocumentText.ToString();

            var y = webBrowser1.Document.Body.InnerText.ToString();
            Debug.Write(y);
            var z = webBrowser1.Document.Body.OuterHtml.ToString();
            Debug.Write(z);

        }
    }
}
