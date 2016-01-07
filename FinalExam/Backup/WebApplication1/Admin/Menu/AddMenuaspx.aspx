<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddMenuaspx.aspx.cs" Inherits="WebApplication1.Admin.Menu.AddMenuaspx" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <input type="hidden" name="id" value="<%:menuModle.id %>" />
        <table border="0" cellpadding="0" cellspacing="0">
            <tr>
                <td>
                    栏目名
                </td>
                <td>
                    <input type="text" name="className" value="<%:menuModle.className %>" />
                </td>
            </tr>
            <tr>
                <td>
                    父栏目
                </td>
                <td>
                    <select name="Pid">
                        <%  for (int i = 0; i < menuList.Count; i++)
                            {
                                if (menuModle.pId == menuList[i].id)
                                { %>
                                 <option selected="selected" value="<%:menuList[i].id %>" > <%=menuList[i].className%> </option>
                             <% }
                                else
                                {%>
                                   <option value="<%:menuList[i].id %>" > <%=menuList[i].className%> </option>       
                                <%}
                            
                    } %>
                    </select>
                </td>
            </tr>
            <tr>
                <td>
                    栏目序号
                </td>
                <td>
                    <input type="text" name="classOrder" value="<%:menuModle.classOrder %>" />
                </td>
            </tr>
            <tr>
                <td>
                    栏目Url
                </td>
                <td>
                    <input type="text" name="OutLinkURL" value="<%:menuModle.OutLinkURL %>" />
                </td>
            </tr>
        </table>
        <input type="submit" name="btn" value="提交" />
    </div>
    </form>
</body>
</html>
