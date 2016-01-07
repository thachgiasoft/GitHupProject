<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddAtricle.aspx.cs" Inherits="WebApplication1.Admin.Atricle.AddAtricle" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <script src="../../Ckedit/ckeditor.js" type="text/javascript"></script>
</head>
<body>
    <form id="form1" runat="server">
    <input type="hidden" name="id" value="<%:id%>" />
    <input type="hidden" name="date" value="<%:date%>" />
    <table border="1" cellpadding="0" cellspacing="0">
        <tr>
            <td>
                标题
            </td>
            <td>
                <input type="text" name="title" value="<%:title %>" style="border:1" />
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
</body>
</html>
