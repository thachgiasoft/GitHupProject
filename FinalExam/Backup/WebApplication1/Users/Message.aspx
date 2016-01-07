<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true"
    CodeBehind="Message.aspx.cs" Inherits="WebApplication1.Users.Message" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="slider">
        <h1>
            留言版</h1>
        <ul>
            <%for (int i = 0; i < messlist.Count; i++)
              {%>
            <li>
                <%:messlist[i].MgeContent %>
                <p style="float: right;">
                    <%:messlist[i].UserId.LoginName %>于<%:messlist[i].AddTime %></p> </li>
            <%} %>
        </ul>
    </div>
    <div id="footer">
        <form action="Message.aspx" method="post" runat="server">
        <table border="0" cellpadding="0" cellspacing="0">
            <tr>
                <td>
                    留言
                </td>
                <td>
                    <textarea name="content" style="width: 500px; height: 300px;" cols="20" name="S1"
                        rows="1"></textarea>
                </td>
            </tr>
            <tr>
                <td>
                    <input type="submit" name="btn" value="提交" />
                </td>
            </tr>
        </table>
        </form>
    </div>
</asp:Content>
