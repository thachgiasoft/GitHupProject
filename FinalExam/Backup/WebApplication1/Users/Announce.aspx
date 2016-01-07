<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true"
    CodeBehind="Announce.aspx.cs" Inherits="WebApplication1.Users.Announce" %>

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
            <%:GetName(modle.AdminId.ToString()) %>于<%:modle.AddTime %>发布</h3>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <%= Context.Server.HtmlDecode(modle.AnnContent)%>
        </p>
        <a href="/Users/index.aspx">返回主页</a></div>
</asp:Content>
