<%@ Page Language="C#" AutoEventWireup="true" CodeFile="kilit_ac.aspx.cs" Inherits="kilit_ac" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Aramak istediğiniz kullanıcının adını girin:<br />
        <br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Ara" />
        <br />
        <br />
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetUser" TypeName="System.Web.Security.MemberShip">
            <SelectParameters>
                <asp:ControlParameter ControlID="TextBox1" DefaultValue=" " Name="username" PropertyName="Text" />
            </SelectParameters>
        </asp:ObjectDataSource>
        <br />
        <asp:DetailsView ID="DetailsView2" runat="server" AutoGenerateRows="False" Height="49px" Width="388px">
            <Fields>
                <asp:BoundField DataField="UserName" HeaderText="Kullanıcı Adı" ReadOnly="True" SortExpression="UserName" />
                <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                <asp:BoundField DataField="PasswordQuestion" HeaderText="Güvenlik Sorusu" ReadOnly="True" SortExpression="PasswordQuestion" />
                <asp:BoundField DataField="Comment" HeaderText="Yorum" SortExpression="Comment" />
                <asp:CheckBoxField DataField="IsApproved" HeaderText="Onaylı mı" SortExpression="IsApproved" />
                <asp:CheckBoxField DataField="IsLockedOut" HeaderText="Kilitli mi" ReadOnly="True" SortExpression="IsLockedOut" />
                <asp:BoundField DataField="LastLockoutDate" HeaderText="Son Çıkış Zamanı" ReadOnly="True" SortExpression="LastLockoutDate" />
                <asp:BoundField DataField="CreationDate" HeaderText="Hesabın Oluşturulma Zamanı" ReadOnly="True" SortExpression="CreationDate" />
                <asp:BoundField DataField="LastLoginDate" HeaderText="Son Giriş Zamanı" SortExpression="LastLoginDate" />
                <asp:BoundField DataField="LastActivityDate" HeaderText="Son Aktivasyon Zamanı" SortExpression="LastActivityDate" />
                <asp:BoundField DataField="LastPasswordChangedDate" HeaderText="Parolanın son değiştirilme zamanı" ReadOnly="True" SortExpression="LastPasswordChangedDate" />
                <asp:CheckBoxField DataField="IsOnline" HeaderText="Online Mı" ReadOnly="True" SortExpression="IsOnline" />
                <asp:BoundField DataField="ProviderName" HeaderText="Veri Sağlayıcı Adı" ReadOnly="True" SortExpression="ProviderName" />
            </Fields>
        </asp:DetailsView>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Kilit Aç" />
    
    </div>
    </form>
</body>
</html>
