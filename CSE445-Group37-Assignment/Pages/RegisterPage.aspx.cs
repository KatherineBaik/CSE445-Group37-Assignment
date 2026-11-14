using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CSE445_KBUtilities;

namespace CSE445_Group37_Assignment.Pages
{
    public partial class RegisterPage : System.Web.UI.Page
    {
        private const string secretKey = "YAHAHA";
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        // Work by: Josh Azura

        // This runs when register button is clicked
        protected void ButtonUserRegister_Click(object sender, EventArgs e)
        {
            // This stops if any kind of validator failed.
            if (!Page.IsValid)
            {
                return;
            }

            // This reads that the users type on the field.
            string username = TextBoxUsername.Text.Trim();
            string password = TextBoxPassword.Text;

            // This encrypts locally with the DLL
            string encrypted = KBUtilities.EncryptString(password, secretKey);

            // This asks the JASerivce to create teh account and returns a yes or no.
            JAServiceReference.JAServiceClient proxy = new JAServiceReference.JAServiceClient();
            bool registered = proxy.RegisterUser(username, encrypted);
            // TODO: if false, show LabelUserExists and return
            // TODO: if true, save the username in a cookie
            // TODO: redirect to LoginPage.aspx
        }
    }
}