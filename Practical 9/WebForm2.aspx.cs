using System;

namespace Practical_9
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string queryString = "No Data Available!!!";
            Response.Redirect("WebForm1.aspx?" + queryString);
        }
    }
}