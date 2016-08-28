using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Label1.Text = Request.ApplicationPath.ToString();
            this.Image1.ImageUrl = new Uri(Request.ApplicationPath + @"Images\012.jpg",UriKind.Relative).ToString();

        }
    }
}
