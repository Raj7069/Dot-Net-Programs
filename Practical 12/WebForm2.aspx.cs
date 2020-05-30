using System;

namespace Practical_12
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblUsername.Text = Session["Username"].ToString();
            }
        }
    }
}