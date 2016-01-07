<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddLink.aspx.cs" Inherits="WebApplication1.Admin.Link.AddLink" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <input type="hidden" name="id" value="<%:s%>" />
        <table border="0" cellpadding="0" cellspacing="0">
            <tr>
                <td>
                    地址
                </td>
                <td>
                    <input type="text" name="linkTile" value="<%:linkModel.linkTile %>" />
                </td>
            </tr>
            <tr>
                <td>
                    Url
                </td>
                <td>
                    <input type="text" name="uRl" value="<%:linkModel.uRl %>" />
                </td>
            </tr>
            <tr>
                <td>
                    <input type="submit" name="btn" value="提交" />
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
