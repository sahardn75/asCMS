﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="userHome.aspx.cs" Inherits="_3layer_cms.userHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:FileUpload ID="FileUpload1" runat="server" />
            <asp:Button ID="btnUpload" runat="server" Text="Upload" OnClick="Upload" />
            <asp:Label ID="response" runat="server" Text=""></asp:Label>
            <hr />



        </div>
    </form>
</body>
</html>
