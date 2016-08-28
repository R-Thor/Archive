using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegularExpressionTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void evaluateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Regex regex = new Regex(this.textBox1.Text);
                MatchCollection matchCollection = regex.Matches(textBox2.Text);
                this.textBox3.Text = matchCollection.Count.ToString();
                (from Match m in matchCollection select m.Value.ToString()).ToList().ForEach(o => this.textBox3.Text += Environment.NewLine + o);
            }
            catch(Exception ex)
            {
                this.textBox3.Text = ex.Message.ToString();
            }

        }
    }
}
