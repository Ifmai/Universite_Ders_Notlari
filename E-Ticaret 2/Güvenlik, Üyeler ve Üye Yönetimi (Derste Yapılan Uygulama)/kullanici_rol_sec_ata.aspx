<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="kullanici_rol_sec_ata.aspx.cs" Inherits="kullanici_rol_sec_ata" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1>Kullanıcı Rol Atama İşlemi</h1>
    <table style="width: 100%">
        <tr>
            <td>Tanımlı Roller aşağıda listelenmektedir:</td>
            <td>Kayıtlı kullanıcılar aşağıda litelenmektedir:</td>
        </tr>
        <tr>
            <td>
                <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged"></asp:ListBox>
            </td>
            <td>
                <asp:ListBox ID="ListBox2" runat="server" ></asp:ListBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Kullanıcıyı Role Ata" />
            </td>
            <td>
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Kullanıcıyı Rolden Sil" />
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                <br />
                <asp:ListBox ID="ListBox3" runat="server" Height="160px" Width="279px"></asp:ListBox>
            </td>
        </tr>
    </table>
</asp:Content>

