using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

public partial class kilit_ac : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
       /* MembershipUser kullanici = Membership.GetUser(TextBox1.Text);
        if (kullanici != null && kullanici.IsLockedOut == true)
        {
            kullanici.UnlockUser();//kilidi aç
            DetailsView2.DataBind();
        }
        */
    }

    protected void Button1_Click1(object sender, EventArgs e)
    {
        MembershipUser kullanici = Membership.GetUser(TextBox1.Text);
        if (kullanici != null && kullanici.IsLockedOut == true)
        {
            kullanici.UnlockUser();//kilidi aç
            DetailsView2.DataBind();
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        DetailsView2.DataSource = ObjectDataSource1;
        DetailsView2.DataBind();
    }
}