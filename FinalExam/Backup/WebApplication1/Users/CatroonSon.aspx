<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true"
    CodeBehind="CatroonSon.aspx.cs" Inherits="WebApplication1.Users.CatroonSon" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="jishu">
        <asp:Repeater ID="Repeater1" runat="server">
            <HeaderTemplate>
                <table border="0" cellpadding="0" cellspacing="0">
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td>
                   
                        <img src='<%#Eval("CartoonSonIamge")%>' alt="Alternate Text" />
                        </br>
                        <h3>
                            <a href='CatroonSon.aspx?id=<%#Eval("Id")%>'>
                                <%#Eval("CartoonSonName")%></a></h3>
                        </br>
                        <p>
                            第
                            <%#Eval("CartNum")%>
                            集
                            <%#Eval("AddDateTime")%></p>
                        </br> </br> </br>
                        <hr />
                    </td>
                </tr>
            </ItemTemplate>
            <FooterTemplate>
                </table>
            </FooterTemplate>
        </asp:Repeater>
        <%:msg %>
    </div>
    <div id="Message">
        <ul>
            <asp:Repeater ID="Repeater2" runat="server">
                <ItemTemplate>
                    <li>
                        <%#Eval("ComContent")%>
                        <p style="float: right;">
                            <%#GetName(Eval("UserId.Id").ToString())%>
                            于
                            <%#Eval("AddTime")%>
                        </p>
                    </li>
                </ItemTemplate>
            </asp:Repeater>
        </ul>
        <%:msgms%>
    </div>
    <div id="liuyang">
        <form action="CatroonSon.aspx" method="post" runat="server">
        <input type="hidden" name="Pid" value="<%:pId %>" />
        <table border="0" cellpadding="0" cellspacing="0">
            <tr>
                <td>
                    内容
                </td>
                <td>
                    <textarea style="width: 400px; height: 200px;" name="context"></textarea>
                </td>
            </tr>
            <tr>
                <td>
                    <input type="submit" name="btn" value="提交" />
                </td>
            </tr>
        </table>
        </form>
        <div>
</asp:Content>
