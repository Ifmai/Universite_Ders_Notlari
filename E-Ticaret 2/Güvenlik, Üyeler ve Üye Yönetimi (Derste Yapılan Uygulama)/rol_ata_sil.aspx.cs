using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

public partial class rol_ata_sil : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    void Page_Init(object sender, EventArgs e)
    {
        uygun_rolleri_yukle();
        kullanici_rol_listele();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (ListBox1.SelectedIndex >=0)//rol seçimi yapılmış
        {
            if (Roles.IsUserInRole(ListBox1.SelectedValue) == false)//oturum açmış kullanıcı daha önceden seçilen role atanmadı ise
            {
                Roles.AddUserToRole(User.Identity.Name, ListBox1.SelectedValue);//oturum açmış kullanıcıyı seçilen role atadık.
                //listbox seçimini iptal et
                ListBox1.SelectedIndex = -1;
                kullanici_rol_listele();
            }
        }
    }

    // aspnet_Roles tablosunda kayıtlı rolleri ListBox1'de listeleyen metodu tanımlayalım
    void uygun_rolleri_yukle()
    {
      ListBox1.DataSource  =Roles.GetAllRoles();
        ListBox1.DataBind();

        /*henüz bir rol tanımı yapılmamış olabilir. Bu durumda 
        Label1 de mesaj gösterip Listbox1 ve Rol Ata butonunu gizleyelim
         */
        if (ListBox1.Items.Count == 0)
        {
            Label2.Text = "Henüz rol tanımı yapılmamıştır. Lütfen önce rol ekleyin";
            ListBox1.Visible = false;
            Button1.Visible = false;
            Button2.Visible = false;
        }
        else
        {
            Label2.Text = "Tanımlı roller aşağıda listelenmektedir";
            ListBox1.Visible = true;
            Button1.Visible = true;
            Button2.Visible = true;
        }    
    }

    //oturum açmış kullanıcıya atanan rolleri ListBox2 kontrolünde listeyen metodu tanımlayalım

    void kullanici_rol_listele()
    {
      ListBox2.DataSource=Roles.GetRolesForUser();
      ListBox2.DataBind();

        //oturum açmış kullanıcıya atanan rol yok ise
        if (ListBox2.Items.Count == 0)
        {
            Label3.Text = User.Identity.Name + " kullanıcısına henüz bir rol atanmamıştır";
            ListBox2.Visible = false;
        }
        else
        {
            Label3.Text = User.Identity.Name + " kullanıcısına atanan roller aşağıda listelenmektedir";
            ListBox2.Visible = true;
        }

    }



    protected void Button2_Click(object sender, EventArgs e)
    {
        //silinecek rol seçildi ise
        if (ListBox2.SelectedIndex >= 0)
        {
            Roles.RemoveUserFromRole(User.Identity.Name, ListBox2.SelectedValue);
            kullanici_rol_listele();
        }
    }
}