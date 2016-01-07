<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true"
    CodeBehind="AtricleAllinfo.aspx.cs" Inherits="WebApplication1.Users.AtricleAllinfo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>
        公告列表</h1>
    <ul>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <li><a href='Atricle.aspx?id=<%#Eval("Id") %>'>
                    <%#Eval("Title")%></a>
                    <p style="float: right;">
                        <%#Eval("AddTime")%></p>
                </li>
            </ItemTemplate>
        </asp:Repeater>
    </ul>
    <a href="AddAtricle.aspx">添加文章（登录后可使用）</a>
</asp:Content>
