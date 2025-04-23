using System;
using System.Web.UI;

namespace UnitConverterApp
{
    public partial class Splash : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Redirect to Default.aspx after 3 seconds
            Response.AddHeader("Refresh", "3;URL=Default.aspx");
        }
    }
}
