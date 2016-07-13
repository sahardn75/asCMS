<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="_3layer_cms.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
         <asp:Label ID="Label2" runat="server" Text="user name"></asp:Label>
        <asp:TextBox ID="UserName" runat="server"></asp:TextBox>
        <asp:Label ID="Label3" runat="server" Text="password"></asp:Label>
        <asp:TextBox ID="PassLog" runat="server"></asp:TextBox>   
        <asp:Button ID="Button1" runat="server" Text="login" OnClick="Button1_Click" />
        <asp:Label ID="log_mess" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
