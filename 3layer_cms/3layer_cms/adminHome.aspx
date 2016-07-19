<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="adminHome.aspx.cs" Inherits="_3layer_cms.adminHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="wellcome to admin page"></asp:Label><br />
    </div>
        <div style="margin: 0px auto; padding-left: 370px; padding-right: 30px;
                                                            overflow: auto;">
        <div>
            <table width="50%">
                <tr>
                    <td colspan="2" style="background-color: Green; height: 30px;
                                                     color: White;" align="center">
                        Referee Registration
                    </td>
                </tr>
                <tr>
                    <td> Name </td>
                    <td>
           <asp:TextBox ID="txtname" Width="150px" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                     <tr>
                    <td> password </td>
                    <td>
           <asp:TextBox ID="txpass" Width="150px" runat="server"></asp:TextBox>
                    </td>
                </tr>
                    <td>Address </td>
                    <td>
            <asp:TextBox ID="txAddress" Width="150px" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td> EmailID </td>
             <td>
            <asp:TextBox ID="txtEmailid" Width="150px" runat="server"></asp:TextBox>
             </td>
                </tr>
                <tr>
                    <td> Mobile Number   </td>
                    <td>
            <asp:TextBox ID="txtmobile" Width="150px" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>User Type </td>
                    <td>
            <asp:TextBox ID="TextType" Width="150px" runat="server"></asp:TextBox>
                    </td>
                      </tr>
                <tr>
                    <td align="center" colspan="2">
         <asp:Button ID="BtnSave" runat="server" Width="100px" Text="Save" OnClick="BtnSave_refereeClick" />
                    </td>
                </tr>
            </table>
        </div>
    </div>
             <br/><br/><br/><br/><br/><br/><br/>  

         <div style="margin: 0px auto; padding-left: 370px; padding-right: 30px;
                                                            overflow: auto;">
        <div>
            <table width="50%">
                <tr>
                    <td colspan="2" style="background-color: Green; height: 30px;
                                                     color: White;" align="center">
                        ADD CONFERENCE
                    </td>
                </tr>
                <tr>
                    <td> Name </td>
                    <td>
           <asp:TextBox ID="cName" Width="150px" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                     <tr>
                    <td> Davar name </td>
                    <td>
           <asp:TextBox ID="dName" Width="150px" runat="server"></asp:TextBox>
                    </td>
                </tr>
                      <tr>
                    <td align="center" colspan="2">
         <asp:Button ID="Button1" runat="server" Width="100px" Text="Save" OnClick="BtnSave_confrenceClick" />
                    </td>
                </tr>
    </form>
</body>
</html>