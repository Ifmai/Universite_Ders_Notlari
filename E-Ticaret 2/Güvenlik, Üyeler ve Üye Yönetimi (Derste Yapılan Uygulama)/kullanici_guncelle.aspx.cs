using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

public partial class kullanici_guncelle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void DetailsView1_ItemUpdating(object sender, DetailsViewUpdateEventArgs e)
    {
        MembershipUser kullanici = Membership.GetUser();
        kullanici.Email = e.NewValues[0].ToString();
        kullanici.Comment = e.NewValues[1].ToString();
        kullanici.IsApproved = Convert.ToBoolean(e.NewValues[2]);
        Membership.UpdateUser(kullanici);
        e.Cancel = true;
        DetailsView1.ChangeMode(DetailsViewMode.ReadOnly);

    }
}