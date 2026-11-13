using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CSE445_Group37_Assignment.Pages.TryIt
{
    public partial class KB_s_TryIt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonEncrypt_Click(object sender, EventArgs e)
        {
            string input = TextBoxEncrypt.Text;
            string key = TextBoxKey.Text;

            KBServiceReference1.KBServiceClient proxy = new KBServiceReference1.KBServiceClient();
            string result = proxy.EncryptString(input, key);

            LabelEncryptResult.Text = result;
        }

        protected void ButtonDecrypt_Click(object sender, EventArgs e)
        {
            string input = TextBoxDecrypt.Text;
            string key = TextBoxKey.Text;
            KBServiceReference1.KBServiceClient proxy = new KBServiceReference1.KBServiceClient();
            string result = proxy.DecryptString(input, key);

            LabelDecryptResult.Text = result;
        }

        protected void ButtonUserLogin_Click(object sender, EventArgs e)
        {
            KBServiceReference1.KBServiceClient proxy = new KBServiceReference1.KBServiceClient();
            bool result = proxy.AuthenticateUser(TextBoxUsername1.Text, TextBoxPassword1.Text);

            if (result)
            {
                LabelInvalidLogin1.Visible = false;
            }
            else
            {
                LabelInvalidLogin1.Visible = true;
            }
        }

        protected void ButtonStaffLogin_Click(object sender, EventArgs e)
        {
            KBServiceReference1.KBServiceClient proxy = new KBServiceReference1.KBServiceClient();
            bool result = proxy.AuthenticateStaff(TextBoxUsername2.Text, TextBoxPassword2.Text);

            if (result)
            {
                LabelInvalidLogin2.Visible = false;
            }
            else
            {
                LabelInvalidLogin2.Visible = true;
            }
        }
    }
}