<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="Kayit.aspx.cs" Inherits="Kayit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1>Yeni Kullanıcı Kaydı</h1>
<table style="width: 100%">
    <tr>
        <td style="width: 174px">Kullanıcı Adı:</td>
        <td>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="width: 174px">Parola:</td>
        <td>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="width: 174px">E-mail:</td>
        <td>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="width: 174px">Güvenlik Sorusu:</td>
        <td>
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>En sevdiğiniz renk?</asp:ListItem>
                <asp:ListItem>İlk okul arkadaşınızın adı</asp:ListItem>
                <asp:ListItem>En sevdiğiniz sevimli kahraman</asp:ListItem>
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td style="width: 174px">Güvenlik Cevabı:</td>
        <td>
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="width: 174px">&nbsp;</td>
        <td>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Kayıt Ol" />
        </td>
    </tr>
    <tr>
        <td style="width: 174px">&nbsp;</td>
        <td>
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        </td>
    </tr>
</table>
</asp:Content>

