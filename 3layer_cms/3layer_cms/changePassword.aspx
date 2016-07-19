<%@ Page Language="C#" AutoEventWireup="True" CodeBehind="changePassword.aspx.cs" Inherits="_3layer_cms.changePassword" %>

<!Doctype html>
<html lang="en">
<link href="css/bootstrap.css" rel="stylesheet" />
<script src="Scripts/jquery-1.11.3.js"></script>
<script src="js/bootstrap.min.js"></script>
     <head>
	     <title>جعبه من</title>
          <style type="text/css">
              
              </style>
   </head>
    <body>
        <h3>به صفحه تغییر رمز عبور خوش آمدید</h3>
        <div class="well">
   
    <div id="myTabContent" class="tab-content">
      <div class="tab-pane active in" id="home">
        <form id="tab" runat="server">
            <label id="old_pass" runat="server">رمز قبلی :</label><br />
            <input id="TextBox_oldpass" type="text" class="input-xlarge" runat="server"><br /><br />
            <label id="pass1" runat="server">رمز جدید :</label><br />
            <input id="TextBox_newpass" type="text"  class="input-xlarge" runat="server"><br /><br />
            <label id="pass2" runat="server">تایید رمز جدید</label><br />
            <input id="TextBox_confirm_pass" type="text" class="input-xlarge" runat="server"><br /><br />
        	<button id="btn_submit" class="btn btn-primary" onserverclick="btn_submit_click" runat="server">تایید</button>
        </form>
      </div>
     </div>
  </div>
    </body>
    </html>
