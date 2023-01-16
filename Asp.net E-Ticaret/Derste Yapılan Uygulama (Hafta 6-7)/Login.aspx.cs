using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Login1_LoginError(object sender, EventArgs e)
    {
        string kadi = Login1.UserName.ToString();
        if (Membership.GetUser(kadi) != null)
        {
            if (Membership.GetUser(kadi).IsLockedOut == true)
            {
                Login1.FailureText = "Hesabınız kilitlendi";
            }

        }
    }
}