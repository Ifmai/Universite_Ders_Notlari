using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

public partial class kullanici_rol_sec_ata : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Page_Init(object sender, EventArgs e)
    {
        rol_listele();
        kullanici_listele();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        //seçilen kullanıcıyı seçilen role atama işlemi

        if (ListBox1.SelectedIndex >= 0 && ListBox2.SelectedIndex >= 0)
        {
            //seçilen kullanıcıyı seçilen role ata
            Roles.AddUserToRole(ListBox2.SelectedValue, ListBox1.SelectedValue);
            ListBox1.SelectedIndex = -1;
            ListBox2.SelectedIndex = -1;
            
        }
    }

    //tüm rolleri ListBox1'de listeleyen metodu tanımlayalım
    void rol_listele()
    {
        ListBox1.DataSource = Roles.GetAllRoles();
        ListBox1.DataBind();
    }

    /*tüm kullanıcıları listeyen metodu tanımlayım*/
    void kullanici_listele()
    {
        ListBox2.DataSource = Membership.GetAllUsers();
        ListBox2.DataBind();
    }

  

    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        //seçilen role atanan kullanıcıları Lİstbox3 kontrolünde listele
        ListBox3.DataSource = Roles.GetUsersInRole(ListBox1.SelectedValue);
        ListBox3.DataBind();
            
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        //seçilen kullanıcıyı seçilen rolden sildirelim
        if (ListBox1.SelectedIndex >= 0 && ListBox2.SelectedIndex >= 0)
        {
            Roles.RemoveUserFromRole(ListBox2.SelectedValue, ListBox1.SelectedValue);
            ListBox1.SelectedIndex = -1;
            ListBox2.SelectedIndex = -1;
        }

    }
}