<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="userHome.aspx.cs" Inherits="_3layer_cms.userHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="wellcome" runat="server" Text="WELLCOME TO YOUR HOME"></asp:Label><br />
            <asp:FileUpload ID="FileUpload1" runat="server" />
            <asp:Button ID="btnUpload" runat="server" Text="Upload" OnClick="Upload" />
            <asp:Label ID="response" runat="server" Text=""></asp:Label>
            <hr />



        </div>
    
    <div>  
        <asp:Label ID="Label4" runat="server" Text="change password"></asp:Label> <br />
    

        <asp:Label ID="old_pass" runat="server" Text="old Password" Font-Bold="True" 
            Width="100px" BackColor="#FFFF66" ForeColor="#FF3300"></asp:Label>

        <asp:TextBox ID="TextBox_oldpass" runat="server" ForeColor="#CC6600" 
            TextMode="Password" Width="100px"></asp:TextBox><br />

         <asp:Label ID="pass1" runat="server" Text="new password" Font-Bold="True" 
            Width="100px" BackColor="#FFFF66" ForeColor="#FF3300"></asp:Label>

        <asp:TextBox ID="TextBox_newpass" runat="server" ForeColor="#CC6600" 
            TextMode="Password" Width="100px"></asp:TextBox><br />


         <asp:Label ID="pass2" runat="server" Text="confirm new Password" Font-Bold="True" 
            Width="100px" BackColor="#FFFF66" ForeColor="#FF3300"></asp:Label>

        <asp:TextBox ID="TextBox_confirm_pass" runat="server" ForeColor="#CC6600" 
            TextMode="Password" Width="100px"></asp:TextBox><br />

        <asp:Button ID="btn_submit" runat="server" Text="submit" Font-Bold="True" 
            BackColor="#CCFF99" onclick="btn_submit_click"  /><br />

             <asp:Label ID="lb1" runat="server" Font-Bold="True" ForeColor="#FF3300"></asp:Label>
    </div> 
          
    </form>
</body>
</html>
