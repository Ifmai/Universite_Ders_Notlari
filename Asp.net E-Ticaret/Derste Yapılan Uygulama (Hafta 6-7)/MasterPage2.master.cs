using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

public partial class MasterPage2 : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Membership.GetUser() == null)
            Label1.Text = " Misafir";
        else
            Label1.Text = Membership.GetUser().UserName;
    }
}
