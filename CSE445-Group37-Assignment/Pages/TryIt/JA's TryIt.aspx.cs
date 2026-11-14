using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CSE445_KBUtilities;

namespace CSE445_Group37_Assignment.Pages.TryIt
{
    // Work by: Josh Azura
    // This is the Try-It page for the RegisterUser service, the cookie, and the WelcomeUser control.
    public partial class JATryIt : System.Web.UI.Page
    {
        // This is the same key Katherine's service uses so the encrypted passwords match.
        private const string secretKey = "YAHAHA";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // This runs when the RegisterUser test button is clicked.
        // This encrypts the password locally with the DLL, then calls the service.
        protected void ButtonTestRegister_Click(object sender, EventArgs e)
        {
            string username = TextBoxTestUser.Text.Trim();
            string encrypted = KBUtilities.EncryptString(TextBoxTestPassword.Text, secretKey);

            JAServiceReference.JAServiceClient proxy = new JAServiceReference.JAServiceClient();
            bool registered = proxy.RegisterUser(username, encrypted);

            // This shows whether the account was created or not.
            LabelRegisterResult.Text = registered
                ? "True - account created"
                : "False - username is empty or already taken";
        }

        // This saves the name in the RecipeBoxUser cookie.
        // This reloads the page so the WelcomeUser control shows the new name.
        protected void ButtonSaveCookie_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("RecipeBoxUser");
            cookie["Username"] = TextBoxCookieName.Text.Trim();
            cookie.Expires = DateTime.Now.AddDays(7);
            Response.Cookies.Add(cookie);

            Response.Redirect(Request.RawUrl);
        }

        // This shows what is currently saved in the cookie.
        protected void ButtonReadCookie_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["RecipeBoxUser"];
            LabelCookieResult.Text = (cookie != null && !string.IsNullOrEmpty(cookie["Username"]))
                ? Server.HtmlEncode(cookie["Username"])
                : "(no cookie)";
        }

        // This deletes the cookie by making it expire, then reloads the page.
        protected void ButtonClearCookie_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("RecipeBoxUser");
            cookie.Expires = DateTime.Now.AddDays(-1);
            Response.Cookies.Add(cookie);

            Response.Redirect(Request.RawUrl);
        }
    }
}