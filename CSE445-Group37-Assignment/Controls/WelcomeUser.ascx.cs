using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CSE445_Group37_Assignment.Controls
{
    public partial class WelcomeUser : System.Web.UI.UserControl
    {
        // Work by: Josh Azura
        // username reads from the cookie (if there is one. If not, it's empty)
        public string Username
        {
            get; 
            private set;
        } = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            // This looks for the cookie the register page has saved
            HttpCookie cookie = Request.Cookies["RecipeBoxUser"];

            if (cookie != null && !string.IsNullOrEmpty(cookie["Username"]))
            {
                // Cookie found: greet the user by name
                Username = cookie["Username"];
                LabelWelcome.Text = "Welcome back, " + Server.HtmlEncode(Username) + "!";
            }
            else
            {
                // No cookie: generic greeting
                LabelWelcome.Text = "Welcome!";
            }
        }
    }
}