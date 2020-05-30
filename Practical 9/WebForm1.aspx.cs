using System;

namespace Practical_9
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString.HasKeys())
            {
                lblUsername.Text = Request.QueryString["username"];
            }
            else
            {
                lblUsername.Text = "Empty QueryString";
            }
        }
    }
}