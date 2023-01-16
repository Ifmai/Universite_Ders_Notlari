<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="rol_ata_sil.aspx.cs" Inherits="rol_ata_sil" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1>Kullanıcıyı Role Atama/Silme</h1>
<p>
    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
</p>
<p>
    <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
</p>
<p>
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Rol Ata" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button2" runat="server" Text="Rol Sil" OnClick="Button2_Click" />
</p>
<p>
    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
</p>
<p>
    <asp:ListBox ID="ListBox2" runat="server"></asp:ListBox>
</p>
</asp:Content>

