<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="AddAtricle.aspx.cs" Inherits="WebApplication1.Users.AddAtricle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="../../Ckedit/ckeditor.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <form id="form1" runat="server">
    <input type="hidden" name="id" value="<%:id%>" />
    <input type="hidden" name="date" value="<%:date%>" />
    <table border="0" cellpadding="0" cellspacing="0">
        <tr>
            <td>
                标题
            </td>
            <td>
                <input type="text" name="title" value="<%:title %>" />
            </td>
        </tr>
        <tr>
            <td>
                公告内容
            </td>
            <td>
                <textarea cols="100" id="editor1" name="editor1" rows="10">
                <%:context %></textarea>
            </td>
        </tr>
    </table>
    <script type="text/javascript">
        var editor = CKEDITOR.replace('editor1');
    </script>
    <input type="submit" name="btn" value="提交" />
    </form>
</asp:Content>
