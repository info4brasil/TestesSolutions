<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebFromsEmpty.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Index Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HyperLink ID="linkAbout" runat="server" NavigateUrl="~/About.aspx">About</asp:HyperLink>
        </div>
        <asp:Panel ID="Panel1" runat="server">
            <asp:Label ID="Label1" runat="server" Text="Nome"></asp:Label>
            <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Idade"></asp:Label>
            <asp:TextBox ID="txtIdade" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="enviar" />
        </asp:Panel>
    </form>


</body>
</html>
