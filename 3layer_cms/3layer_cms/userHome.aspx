<%@ Page Language="C#" AutoEventWireup="True" CodeBehind="userHome.aspx.cs" Inherits="_3layer_cms.userHome" %>

<!Doctype html>
<html lang="en">
<link href="css/bootstrap.css" rel="stylesheet" />
<script src="Scripts/jquery-1.11.3.js"></script>
<script src="js/bootstrap.min.js"></script>
<head>
    <title>ارسال مقاله</title>
    <style type="text/css">
        .upload-drop-zone {
            height: 300px;
            border-width: 3px;
            margin-bottom: 40px;
        }

        /* skin.css Style*/
        .upload-drop-zone {
            color: #ccc;
            border-style: dashed;
            border-color: #ccc;
            line-height: 200px;
            text-align: center;
        }

            .upload-drop-zone.drop {
                color: #222;
                border-color: #222;
            }
    </style>
</head>
<body>
    <div class="container">
        <div class="panel panel-default">
            <div class="panel-heading"><strong>ارسال مقالات</strong></div>
            <div class="panel-body">

                <!-- Standar Form -->
                <h4>لطفا فایل مورد نظر را(با فرمت پی دی اف) انتخاب کنید</h4><br />
                
                <h4>برای ارسال مقاله به کنفرانس ابتدا باید کنفرانس مورد نظر خود را انتخاب کنید</h4>
                <form action="" method="post" enctype="multipart/form-data" id="form1" runat="server">
                    <div class="form-inline">
                        <div class="form-group">
                            <input type="file" name="files[]" id="uploadfiles" multiple runat="server">
                        </div>
                        <button type="submit" class="btn btn-sm btn-primary" id="btnUpload" onserverclick="Upload" runat="server">ارسال مقا له</button>
                    </div>
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" EmptyDataText="No files uploaded">
                        <Columns>
                            <asp:BoundField DataField="Text" HeaderText="File Name" />
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:LinkButton ID="lnkDelete" Text="Delete" CommandArgument='<%# Eval("Value") %>' runat="server" OnClick="DeleteFile" />
                                </ItemTemplate>
                            </asp:TemplateField>
                             <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:LinkButton ID="lnsend" Text="Send" CommandArgument='<%# Eval("Value") %>' runat="server" OnClick="SendFile" />
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </form>

            </div>
        </div>
    </div>
    <!-- /container -->



</body>
</html>

