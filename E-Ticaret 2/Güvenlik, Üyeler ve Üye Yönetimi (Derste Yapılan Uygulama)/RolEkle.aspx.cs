using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;//roles sınıfının ekli olduğu kütüphane
public partial class RolEkle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            listbox_yukle();
        }
    }
   /* void Page_Init(object sender, EventArgs e)
    {
        listbox_yukle();
    }
*/
    protected void Button1_Click(object sender, EventArgs e)
    {
        //textbox1 kontrolüne girilen rol adını ilgili tabloya ekleyelim
        Roles.CreateRole(TextBox1.Text);
        TextBox1.Text = "";
        listbox_yukle();
    }

    /*aspnet_Roles tablosunda kayıtlı olan tüm rolleri ListBox kontrolünde listeleyen metot tanımını yapalım*/
    void listbox_yukle()
    {
       ListBox1.DataSource =Roles.GetAllRoles();
        ListBox1.DataBind();
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        //listbox1 kontrolünde seçilen rolü ilgili tablodan (aspnet_Roles tablosu) silelim
        Response.Write(ListBox1.SelectedValue);
        //listbox kontrolünde seçim yapıldı ise
        if (ListBox1.SelectedIndex >= 0)
        {
            Roles.DeleteRole(ListBox1.SelectedValue);
          
            listbox_yukle();
        }
    }
}