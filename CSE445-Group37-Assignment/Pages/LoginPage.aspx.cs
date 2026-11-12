using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CSE445_Group37_Assignment.Pages
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // Work by: Katherine Baik
        protected void ButtonUserLogin_Click(object sender, EventArgs e)
        {
            KBServiceReference1.KBServiceClient proxy = new KBServiceReference1.KBServiceClient();
            bool result = proxy.AuthenticateUser(TextBoxUsername.Text, TextBoxPassword.Text);

            // if return true, set session cookie and redirect to next page
            // otherwise show "username or password is incorrect" message
            if (result)
            {
                // TODO set cookie here
                LabelInvalidLogin.Visible = false;
            }
            else
            {
                LabelInvalidLogin.Visible = true;
            }
        }

        // Work by: Katherine Baik
        protected void ButtonStaffLogin_Click(object sender, EventArgs e)
        {
            KBServiceReference1.KBServiceClient proxy = new KBServiceReference1.KBServiceClient();
            bool result = proxy.AuthenticateStaff(TextBoxUsername.Text, TextBoxPassword.Text);

            // if return true, set session cookie and redirect to staff page
            // otherwise show "username or password is incorrect" message
            if (result)
            {
                // TODO set cookie here
                LabelInvalidLogin.Visible = false;
            }
            else
            {
                LabelInvalidLogin.Visible = true;
            }
        }
    }
}