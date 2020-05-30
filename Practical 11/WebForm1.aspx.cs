using System;

namespace Practical_11
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnEnableDisable_Click(object sender, EventArgs e)
        {
            if (txtEnableDisable.Enabled == true)
            {
                txtEnableDisable.Enabled = false;
            }
            else
            {
                txtEnableDisable.Enabled = true;
            }
        }

        protected void btnChangeWidth_Click(object sender, EventArgs e)
        {
            txtEnableDisable.Width = int.Parse(TextBox1.Text);
        }
    }
}