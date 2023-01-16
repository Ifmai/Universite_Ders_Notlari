<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login,LoginName,LoginStatus,LoginView.aspx.cs" Inherits="Login_LoginName_LoginStatus_LoginView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:LoginView ID="LoginView1" runat="server">
            <AnonymousTemplate>
                <asp:Login ID="Login1" runat="server" CreateUserText="Yeni Kullanıcı Hesabı Oluştur" CreateUserUrl="~/Register.aspx" PasswordRecoveryText="Parolamı Unuttum" PasswordRecoveryUrl="~/Parola_Hatirlat.aspx">
                </asp:Login>
            </AnonymousTemplate>
            <LoggedInTemplate>
                Hoşgeldin&nbsp;
                <asp:LoginName ID="LoginName1" runat="server" />
                <br />
                <br />
                <asp:LoginStatus ID="LoginStatus1" runat="server" />
                <br />
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Hesabim.aspx">Hesabım</asp:HyperLink>
            </LoggedInTemplate>
        </asp:LoginView>
        <br />
        <br />
        LoginView kontrolü iki farklı template&#39;e sahip olup, anonim kullanıcılar ile oturum açmış kullanıcıların göreceği içeriği belirler. <br />
        <br />
        Anonymous Template ile anonim yani henüz giriş yapmamış kullanıcıların göreceği içeriği belirleriz.<br />
        <br />
        Login Template ile de oturum açmış kullanıcıların göreceği içeriği belirleriz.</div>
    </form>
</body>
</html>
