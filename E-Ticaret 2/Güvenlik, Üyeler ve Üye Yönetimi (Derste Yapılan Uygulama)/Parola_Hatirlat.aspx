<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="Parola_Hatirlat.aspx.cs" Inherits="Parola_Hatirlat" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1>Parola Sıfırlama</h1>
<p>
    <asp:PasswordRecovery ID="PasswordRecovery1" runat="server">
        <MailDefinition Subject="Parola Sıfırlama">
        </MailDefinition>
    </asp:PasswordRecovery>
</p>
</asp:Content>

