<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="refereeHome.aspx.cs" Inherits="_3layer_cms.refereeHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" EmptyDataText="No files uploaded">
                        <Columns>
                            <asp:BoundField DataField="Text" HeaderText="File Name" />
                             <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:LinkButton ID="lnValidate" Text="Validate" CommandArgument='<%# Eval("Value") %>' runat="server" OnClick="ValidateFile" />
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
    </div>
    </form>
</body>
</html>
