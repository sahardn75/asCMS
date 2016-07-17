<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="_3layer_cms.login" %>

<!Doctype html>
<html lang="en">
<link href="css/bootstrap.css" rel="stylesheet" />
<script src="Scripts/jquery-1.11.3.js"></script>
<script src="js/bootstrap.min.js"></script>
     <head>
	     <title>ورود</title>
         <style type="text/css">
             .wrapper {
                 margin-top: 130px;
                 margin-bottom: 20px;
             }

             .form-signin {
                 max-width: 420px;
                 padding: 30px 38px 66px;
                 margin: 0 auto;
                 background-color: #eee;
                 border: 3px dotted rgba(0,0,0,0.1);
             }

             .form-signin-heading {
                 text-align: center;
                 margin-bottom: 30px;
             }

             .form-control {
                 position: relative;
                 font-size: 16px;
                 height: auto;
                 padding: 10px;
             }

             input[type="text"] {
                 margin-bottom: 0px;
                 border-bottom-left-radius: 0;
                 border-bottom-right-radius: 0;
             }

             input[type="password"] {
                 margin-bottom: 20px;
                 border-top-left-radius: 0;
                 border-top-right-radius: 0;
             }

             .colorgraph {
                 height: 7px;
                 border-top: 0;
                 background: #c4e17f;
                 border-radius: 5px;
                 background-image: -webkit-linear-gradient(left, #c4e17f, #c4e17f 12.5%, #f7fdca 12.5%, #f7fdca 25%, #fecf71 25%, #fecf71 37.5%, #f0776c 37.5%, #f0776c 50%, #db9dbe 50%, #db9dbe 62.5%, #c49cde 62.5%, #c49cde 75%, #669ae1 75%, #669ae1 87.5%, #62c2e4 87.5%, #62c2e4);
                 background-image: -moz-linear-gradient(left, #c4e17f, #c4e17f 12.5%, #f7fdca 12.5%, #f7fdca 25%, #fecf71 25%, #fecf71 37.5%, #f0776c 37.5%, #f0776c 50%, #db9dbe 50%, #db9dbe 62.5%, #c49cde 62.5%, #c49cde 75%, #669ae1 75%, #669ae1 87.5%, #62c2e4 87.5%, #62c2e4);
                 background-image: -o-linear-gradient(left, #c4e17f, #c4e17f 12.5%, #f7fdca 12.5%, #f7fdca 25%, #fecf71 25%, #fecf71 37.5%, #f0776c 37.5%, #f0776c 50%, #db9dbe 50%, #db9dbe 62.5%, #c49cde 62.5%, #c49cde 75%, #669ae1 75%, #669ae1 87.5%, #62c2e4 87.5%, #62c2e4);
                 background-image: linear-gradient(to right, #c4e17f, #c4e17f 12.5%, #f7fdca 12.5%, #f7fdca 25%, #fecf71 25%, #fecf71 37.5%, #f0776c 37.5%, #f0776c 50%, #db9dbe 50%, #db9dbe 62.5%, #c49cde 62.5%, #c49cde 75%, #669ae1 75%, #669ae1 87.5%, #62c2e4 87.5%, #62c2e4);
             }
         </style>
	 </head>
	 <body>
	         <div class = "container">
	<div class="wrapper">
		<form action="" id="form1" method="post" name="Login_Form" class="form-signin" runat="server">       
		    <h3 class="form-signin-heading">خوش آمدید</br>لطفا اطلاعات خود را وارد کنید</h3>
			  <hr class="colorgraph"></br>
			  
			  <input type="text" id="UserName" class="form-control" name="Username" placeholder="نام کاربری :" required="" autofocus="" runat="server" />
			  <input type="password" id="PassLog" class="form-control" name="Password" placeholder="رمز عبور :" required="" runat="server"/>     		  
			  <button class="btn btn-lg btn-primary btn-block" id="Butten1"  name="Submit" value="Login" type="Submit" onserverclick="Button1_Click"  runat="server">ورود</button>  			
		</form>			
	</div>
</div>
	 </body>
    </html>

