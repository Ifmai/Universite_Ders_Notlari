<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1>Kullanıcı Girişi</h1>
<p>
    <asp:Label ID="Label1" runat="server" Text="Label" ForeColor="Red"></asp:Label>
    <asp:Login ID="Login1" runat="server" CreateUserText="Yeni Kullanıcı Kaydı Oluştur" CreateUserUrl="~/Register.aspx" DestinationPageUrl="~/Default.aspx" LoginButtonText="Giriş Yap" PasswordRecoveryText="Parolamı Unuttum" RememberMeText="Beni Hatırla" TitleText="" OnLoginError="Login1_LoginError" OnAuthenticate="Login1_Authenticate">
    </asp:Login>
</p>
</asp:Content>

