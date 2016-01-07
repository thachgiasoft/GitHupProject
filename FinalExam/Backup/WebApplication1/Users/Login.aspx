<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication1.Users.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>中华漫画网后台</title>
    <script type="text/javascript" src="/js/jquery-1.9.0.min.js"></script>
    <script type="text/javascript" src="/js/login.js"></script>
    <link href="/css/login2.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript">
        $(function () {
            $("#image").click(function () {
                $("#image").attr("src", $("#image").attr("src") + "1");
            })
        })
    
    </script>
</head>
<style type="text/css">
    #font
    {
        color: Red;
    }
</style>
<body>
    <h1>
        中华漫画王登陆页面<sup>V2014</sup></h1>
    <div class="login" style="margin-top: 50px;">
        <%-- href="javascript:void(0);"--%>
        <div class="header">
            <div class="switch" id="switch">
                <a class="switch_btn_focus" id="switch_qlogin" tabindex="7">登录</a>
                <a class="switch_btn_focus" id="A1" tabindex="7" href="/Users/AddUser1.aspx" >注册</a>

            </div>
        </div>
        <div class="web_qr_login" id="web_qr_login" style="display: block; height: 285px;">
            <!--登录-->
            <div class="web_login" id="web_login">
                <div class="login-box">
                    <div class="login_form">
                        <form action="Login.aspx" method="post">
                        <input type="hidden" name="hidden" value="1" />
                        <div class="uinArea" id="uinArea">
                            <label class="input-tips">
                                帐号：</label>
                            <div class="inputOuter" id="uArea">
                                <input type="text" id="u" name="username" class="inputstyle" value="<%:username %>" />
                            </div>
                        </div>
                        <div class="pwdArea" id="pwdArea">
                            <label class="input-tips">
                                密码：</label>
                            <div class="inputOuter" id="pArea">
                                <input type="password" id="p" name="password" class="inputstyle" value="123" />
                            </div>
                        </div>
                        <div class="pwdArea" id="Div1">
                            <label class="input-tips">
                                验证码：</label>
                            <div class="inputOuter" id="Div2">
                                <input type="text" id="yzm" name="yzm" class="inputstyle" />
                            </div>
                        </div>
                        &nbsp;&nbsp; &nbsp;&nbsp;<input type="checkbox" name="remember" value="1" />记住我&nbsp;&nbsp;
                        &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
                        <img src="/Common/Vaildate.ashx?id=1" alt="Alternate Text" id="image" />点击图片换
                        <div style="padding-left: 50px; margin-top: 20px;">
                            <input type="submit" value="登 录" style="width: 150px;" class="button_blue" /></div>
                        <p id="font">
                            <p id="P1">
                                <%=msg%></p>
                        </form>
                    </div>
                </div>
            </div>
            <!--登录end-->
        </div>
    </div>
    <div class="jianyi">
        本网站不允许外网注册,若想注册请联系管理员0571-64567758</div>
</body>
</html>
