<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="_3layer_cms.register" %>


<!Doctype html>
<html lang="en">
<link href="css/bootstrap.css" rel="stylesheet" />
<script src="Scripts/jquery-1.11.3.js"></script>
<script src="js/bootstrap.min.js"></script>
     <head>
	     <title>ثبت نام</title>
         <style type="text/css">
             .wrapper {
                 margin-top: 25px;
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
		<form action="" method="post" name="Login_Form" id="form1" class="form-signin" runat="server">       
		    <h3 class="form-signin-heading">خوش آمدید</br>لطفا اطلاعات خود را وارد کنید</h3>
			  <hr class="colorgraph"></br>
			  
			  <input type="text" id="txtname" class="form-control" name="Username" placeholder="نام :" required="" autofocus="" runat="server"/><br />
			  <input type="password" id="txpass" class="form-control" name="Password" placeholder="رمز عبور :" required="" runat="server"/>   
              <input type="text" id="txtEmailid" class="form-control" name="Emailid" placeholder="پست الکترونیکی :" required=""  runat="server" /><br />
			  <input type="number" id="txtmobile" class="form-control" name="number" placeholder="تلفن تماس :" required="" runat="server"/><br />  
              <input type="text" id="txAddress" class="form-control" name="city" placeholder="شهر / استان :" required="" runat="server"/><br />
			  <button class="btn btn-lg btn-primary btn-block" id="BtnSave"  name="Submit" value="Login" type="Submit" onserverclick="BtnSave_Click" runat="server">ثبت نام</button>  			
		</form>			
	</div>
</div>
	 </body>
    </html>