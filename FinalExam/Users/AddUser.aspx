<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddUser.aspx.cs" Inherits="WebApplication1.Admin.User.AddUser" %>

<!DOCTYPE html>
<html>
<head>
<title>用户注册页面</title>
<link href="/AddCss/resources/style/style.css" rel="stylesheet" type="text/css" />
<script type="text/javascript" src="/AddCss/resources/js/jquery.js"></script>
<script type="text/javascript" src="/AddCss/resources/js/jquery.i18n.properties-1.0.9.js" ></script>
<script type="text/javascript" src="/AddCss/resources/js/jquery-ui-1.10.3.custom.js"></script>
<script type="text/javascript" src="/AddCss/resources/js/jquery.validate.js"></script>
<script type="text/javascript" src="/AddCss/resources/js/md5.js"></script>
<script type="text/javascript" src="/AddCss/resources/js/page_regist.js?lang=zh"></script>
<!--[if IE]>
  <script src="resources/js/html5.js"></script>
<![endif]-->
<!--[if lte IE 6]>
	<script src="resources/js/DD_belatedPNG_0.0.8a-min.js" language="javascript"></script>
	<script>
	  DD_belatedPNG.fix('div,li,a,h3,span,img,.png_bg,ul,input,dd,dt');
	</script>
<![endif]-->
</head>
<body class="loginbody">
<div class="dataEye">
	<div class="loginbox registbox">
		<div class="login-content reg-content">
			<div class="loginbox-title">
				<h3>注册</h3>
			</div>
			<form id="signupForm" action="AddUser.aspx" method="post" runat="server">
			<div class="login-error"></div>
			<div class="row">
              
				<input type="text" class="input-text-user noPic input-click" name="User" id="User" />
			</div>
			<div class="row">
				<label class="field" for="password">密码</label>
				<input type="password" class="input-text-password noPic input-click" name="password" id="password"/>
			</div>
			<div class="row">
				<label class="field" for="passwordAgain">确认密码</label>
				<input type="password"  class="input-text-password noPic input-click" name="passwordAgain" id="passwordAgain"/>
			</div>
			<div class="row">
				<label class="field" for="contact">手机</label>
				<input type="text"  class="input-text-user noPic input-click" name="contact" id="contact">
			</div>
			<div class="row">
				<label class="field" for="company">邮箱</label>
				<input type="text"  class="input-text-user noPic input-click" name="company" id="company">
			</div>
			<div class="row btnArea">
                <input type="submit" name="btn" class="background:url(../images/bg.png) repeat-x left top;" />
				<%--<a class="login-btn" id="submit">注册</a>--%>
			</div>
			</form>
		</div>
		
	</div>
	

</div>
<div class="loading">
	<div class="mask">
		<div class="loading-img">
		<img src="resources/images/loading.gif" width="31" height="31">
		</div>
	</div>
</div>
</body>
</html>
