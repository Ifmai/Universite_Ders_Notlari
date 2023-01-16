<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="Sifre_guncelle.aspx.cs" Inherits="Sifre_guncelle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1>Şifre Yenileme Sayfası</h1>
<p>
    <asp:ChangePassword ID="ChangePassword1" runat="server" ChangePasswordButtonText="Şifre Değiştir" ChangePasswordFailureText="Parolanız en az {0} karakter olmalıdır ve en az {1} alfa numeric karakter içermelidir" ChangePasswordTitleText="" ConfirmNewPasswordLabelText="Yeni Şifre (Tekrar):" ContinueDestinationPageUrl="~/Login.aspx" NewPasswordLabelText="Yeni Şifre:" PasswordLabelText="Şuan ki Şifre:" ConfirmPasswordCompareErrorMessage="Parolalar Uyuşmuyor">
    </asp:ChangePassword>
</p>
</asp:Content>

