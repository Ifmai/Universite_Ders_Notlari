<%@ Page Language="C#" AutoEventWireup="true" CodeFile="kullanici_guncelle.aspx.cs" Inherits="kullanici_guncelle" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" DataSourceID="ObjectDataSource1" Height="50px" OnItemUpdating="DetailsView1_ItemUpdating" Width="441px">
            <Fields>
                <asp:BoundField DataField="UserName" HeaderText="Kullanıcı Adı" ReadOnly="True" SortExpression="UserName" />
                <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                <asp:BoundField DataField="PasswordQuestion" HeaderText="Güvenlik Sorusu" ReadOnly="True" SortExpression="PasswordQuestion" />
                <asp:BoundField DataField="Comment" HeaderText="Yorum" SortExpression="Comment" />
                <asp:CheckBoxField DataField="IsApproved" HeaderText="Onaylı Mı" SortExpression="IsApproved" />
                <asp:CheckBoxField DataField="IsLockedOut" HeaderText="Kilitli Mi?" ReadOnly="True" SortExpression="IsLockedOut" />
                <asp:BoundField DataField="LastLockoutDate" HeaderText="Son Çıkış Zamanı" ReadOnly="True" SortExpression="LastLockoutDate" />
                <asp:BoundField DataField="CreationDate" HeaderText="Hesabın Oluşturulma Zamanı" ReadOnly="True" SortExpression="CreationDate" />
                <asp:BoundField DataField="LastLoginDate" HeaderText="Son Giriş Zamanı" ReadOnly="True" SortExpression="LastLoginDate" />
                <asp:BoundField DataField="LastActivityDate" HeaderText="Son Aktivasyon Zamanı" ReadOnly="True" SortExpression="LastActivityDate" />
                <asp:BoundField DataField="LastPasswordChangedDate" HeaderText="Parolanın son değiştirildiği tarih:" ReadOnly="True" SortExpression="LastPasswordChangedDate" />
                <asp:CheckBoxField DataField="IsOnline" HeaderText="Online mı" ReadOnly="True" SortExpression="IsOnline" />
                <asp:BoundField DataField="ProviderName" HeaderText="Veri Sağlayıcı Adı" ReadOnly="True" SortExpression="ProviderName" />
                <asp:CommandField EditText="Düzenle" ShowEditButton="True" />
            </Fields>
        </asp:DetailsView>
        <br />
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetUser" TypeName="System.Web.Security.Membership"></asp:ObjectDataSource>
    
    </div>
    </form>
</body>
</html>
