<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddAnnounce.aspx.cs" Inherits="WebApplication1.Admin.Announce.AddAnnounce" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="/Uedit/ueditor.config.js" type="text/javascript"></script>
    <script src="/Uedit/_examples/editor_api.js" type="text/javascript"></script>
    <script src="/Uedit/lang/zh-cn/zh-cn.js" type="text/javascript"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table border="0" cellpadding="0" cellspacing="0">
            <tr>
                <td>
                    公告题目
                </td>
                <td>
                    <input type="text" name="Title" value="" />
                </td>
            </tr>
            <tr>
                <td>
                    文章内容
                </td>
                <td>
                    <div>
                        <script id="editor" type="text/plain" style="width: 1024px; height: 500px;"></script>
                    </div>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
<script type="text/javascript">

    //实例化编辑器
    //建议使用工厂方法getEditor创建和引用编辑器实例，如果在某个闭包下引用该编辑器，直接调用UE.getEditor('editor')就能拿到相关的实例
    var ue = UE.getEditor('editor');
</script>
</html>
