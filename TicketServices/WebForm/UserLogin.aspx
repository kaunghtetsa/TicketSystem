<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserLogin.aspx.cs" Inherits="TicketServices.WebForm.UserLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <title>Ticket System Login</title>
	<meta charset="UTF-8"/>
	<meta name="viewport" content="width=device-width, initial-scale=1"/>
	<link rel="stylesheet" type="text/css" href="CSS/main.css"/>
</head>
<body>
    <div class="limiter">
		<div class="container-login100">
			<div class="wrap-login100" style="background-image:url(images/pocariSweatBLogo.png)">
				<form class="login100-form validate-form" runat="server" style="font-family:Zawgyi-One">
                    <br />
					<span class="login100-form-title" style="padding-bottom:12px;margin-top:10%;font-family:Zawgyi-One">
						Member Login
					</span>
					<br />
					<div class="wrap-input100 validate-input" data-validate = "Valid Phone Number is 09xxxxxxxxx">
						<asp:TextBox runat="server" ID="txtuser" class="input100" type="text" name="phno" style="font-family:Zawgyi-One"></asp:TextBox>
						<span class="focus-input100" data-placeholder="Phone Number" style="font-family:Zawgyi-One"></span>
					</div>
                    <br />
					<div class="wrap-input100 validate-input" data-validate="Enter password">
						<span class="btn-show-pass">
							<i class="zmdi zmdi-eye"></i>
						</span>
						 <asp:TextBox runat="server" ID="txtpass" class="input100" type="password" name="pass" style="font-family:Zawgyi-One"></asp:TextBox>
						
						<span class="focus-input100" data-placeholder="Password" style="font-family:Zawgyi-One"></span>
					</div>
					<br />
					<div class="container-login100-form-btn" >
						<div class="wrap-login100-form-btn">
							<div class="login100-form-bgbtn"></div>
                            <button runat="server" class="login100-form-btn" onserverclick="btnLogin_Click" style="font-family:Zawgyi-One" >
                                Login
                            </button>
						</div>
					</div>
                    <div class="text-center" style="padding-top: 50px; font-family:Zawgyi-One">
						<span class="txt1" style="font-family:Zawgyi-One">
							Don’t have an account?
						</span>

						<a class="txt2" href="##" style="font-family:Zawgyi-One">
							Need Assistance.

						</a>
					</div>
					
				</form>
			</div>
		</div>
	</div>
	

	<script src="jquery/jquery-3.2.1.min.js"></script>

	<script src="js/main.js"></script>

</body>
</html>
