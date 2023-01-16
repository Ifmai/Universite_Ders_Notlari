using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;//membership sınıfını kullanabilmek için

public partial class Kullanic_Sayfasi : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        MembershipUser kullanici = Membership.GetUser();//oturum açmış kullanıcıyı elde ettik
        Label1.Text = kullanici.UserName;
        Label2.Text = kullanici.Email;
        if (kullanici.IsApproved == true)
            Label3.Text = "Onaylı";
        else
            Label3.Text = "Onay Bekliyor";
        Label4.Text = kullanici.PasswordQuestion;
        if (kullanici.IsLockedOut == true)
            Label5.Text = "Evet";
        else
            Label5.Text = "Hayır";
        if (kullanici.IsOnline == true)
            Label10.Text = "Çevrimiçi";
        else
            Label10.Text = "Çevrımdışı";
        Label6.Text = kullanici.CreationDate.ToString();//hesabın oluşturulma zamanı
        Label7.Text = kullanici.LastLoginDate.ToString();//en son giriş yapılan zaman
        Label8.Text = kullanici.LastActivityDate.ToString();//kullanıcının son aktivasyon zamanı
        Label9.Text = kullanici.LastPasswordChangedDate.ToString();//parolanın en son değiştirildiği zamanı
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        FormsAuthentication.SignOut();//sistemden çıkış yap
        //çıkış işleminin ardından tekrar giriş yapabilmesini sağlamak için login sayfasına yönlendirme yapalım
        FormsAuthentication.RedirectToLoginPage();
    }
}