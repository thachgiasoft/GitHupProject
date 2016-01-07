<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true"
    CodeBehind="Atricle.aspx.cs" Inherits="WebApplication1.Users.Atricle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .sq
        {
            width: 1000px;
            height: 800px;
            margin: 0 auto;
            color:
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="slider">
        <h1 style="text-align: center">
            <%:modle.Title %></h1>
        <h3 style="text-align: center">
            <%:GetName(modle.UserId.ToString())%>于<%:modle.AddTime %>发布</h3>
        -
        <div>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <%=Server.HtmlDecode(modle.AtrContent)%>
        </div>
        <a href="/Users/AtricleAllinfo.aspx">返回文章列表</a></div>
</asp:Content>
