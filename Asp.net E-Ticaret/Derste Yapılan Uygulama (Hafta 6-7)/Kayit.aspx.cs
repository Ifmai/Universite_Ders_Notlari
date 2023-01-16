using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

public partial class Kayit : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        /*Membership.CreateUser(TextBox1.Text, TextBox2.Text);
        Label2.Text = TextBox1.Text + " kullanıcısı başarıyla oluşturuldu";
         
        Membership.CreateUser(TextBox1.Text, TextBox2.Text,TextBox3.Text);
        Label2.Text = TextBox1.Text + " kullanıcısı başarıyla oluşturuldu";*/

        MembershipCreateStatus sonuc;
        string kullaniciAdi = TextBox1.Text;
        string parola = TextBox2.Text;
        string mail = TextBox3.Text;
        string soru = DropDownList1.SelectedValue;
        string cevap = TextBox4.Text;


        /*Create User Metodu bellirtilen özellik değerleri ile (kullanıcı adı, parola, mail,soru,cevap) veri tablosuna yeni bir kullanıcı ekler ve geriye kullanıcının başarıyla oluşturulduğunu ya da kullanıcı oluşturulmadı ise bunun nedenini belirten bir durum parametresi döndürür.*/
        Membership.CreateUser(kullaniciAdi, parola, mail, soru, cevap, true, out sonuc);

        if (sonuc == MembershipCreateStatus.Success)
        {
            Label2.Text = "Kullanıcı kaydı yapıldı";
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
        }
        else if (sonuc == MembershipCreateStatus.InvalidPassword)
        {
            Label2.Text = "Parolanız en az 5 karakter uzunluğunda olmalıdır";
        }
        else if (sonuc == MembershipCreateStatus.InvalidQuestion)
        {
            Label2.Text = "Güvenlik sorusunu belirleyin";
        }
        else if (sonuc == MembershipCreateStatus.InvalidAnswer)
        {
            Label2.Text = "Güvenlik sorusunun yanıtını belirleyin";
        }
        else if (sonuc == MembershipCreateStatus.DuplicateUserName)
        {
            Label2.Text = "Girdiğiniz kullanıcı adı zaten kayıtlı. Lütfen yeni bir kullanıcı adı belirleyin";
        }
        else if (sonuc == MembershipCreateStatus.DuplicateEmail)
        {
            Label2.Text = "Girdiğiniz e-mail adresi zaten kayıtlı. Lütfen yeni bir e-mail adresi belirleyin";
        }
        else
            Label2.Text = "Kullanıcı kaydı oluşturulamadı";
               

    }
}