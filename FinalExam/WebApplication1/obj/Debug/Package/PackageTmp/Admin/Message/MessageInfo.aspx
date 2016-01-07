<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MessageInfo.aspx.cs" Inherits="WebApplication1.Admin.Message.MessageInfo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <link href="../../esayUI/themes/default/easyui.css" rel="stylesheet" type="text/css" />
    <link href="../../esayUI/themes/icon.css" rel="stylesheet" type="text/css" />
    <link href="../../esayUI/demo/demo.css" rel="stylesheet" type="text/css" />
    <script src="../../esayUI/jquery-1.8.0.min.js" type="text/javascript"></script>
    <%--<script src="../../esayUI/jquery-1.7.2.min.js" type="text/javascript"></script>--%>
    <script src="../../esayUI/jquery.easyui.min.js" type="text/javascript"></script>
    <script src="../../esayUI/easyuiExtension.js" type="text/javascript"></script>
    <title>网站留言板管理</title>
    <script type="text/javascript">
        $(function () {
            $("#add").css("display", "none");

            $('#User').datagrid({
                title: '网站留言板管理',
                width: 700,
                height: 400,
                fitColumns: true,
                idField: 'Id',
                url: '/Admin/Message/GetMessageInfo.ashx',
                loadMsg: '正在加载漫画留言板的信息...',
                pagination: true,
                singleSelect: false,
                pageSize: 10,
                pageNumber: 1,
                pageList: [10, 20, 30],
                //Id, MgeContent, UserId, AddTime

                columns: [[
                    { field: 'ck', checkbox: true, align: 'left', width: 40 },
                    { field: 'Id', title: '评论编号', width: 60 },
					{ field: 'MgeContent', title: '评论内容', width: 60 },
                    { field: 'UserId.id', title: '评论用户', width: 60 },
                    { field: 'AddTime', title: '评论的时间', width: 60, formatter: formatDateBoxFull },
                    {
                        field: 'SubBy', title: '删除', width: 120,
                        formatter: function (value, row, index) {
                            return "<a  href='/Admin/Comment/DeleteComment.ashx?id[]=" + row.Id + "'>删除</a>";

                        }
                    }
				]],
                pagination: true,
                rownumbers: true,
                toolbar: [{
                    id: 'btncut',
                    text: '删除',
                    iconCls: 'icon-cut',
                    handler: function () {
                        Delete();
                    }
                }]
            });
            var p = $('#User').datagrid('getPager');
            $(p).pagination({
                onBeforeRefresh: function () {
                    alert('before refresh');
                }
            });
        });


        function Delete() {
            var ids = [];
            var rows = $('#User').datagrid('getSelections');
            if (rows.length <= 0) {
                $.messager.alert("错误消息", "请选中一条信息进行删除");
                return;
            } else {
                for (var i = 0; i < rows.length; i++) {
                    ids.push(rows[i].Id);
                }
                //将这个数异步传到一个ashx的处理
                $.post("/Admin/Comment/DeleteComment.ashx", { "ids": ids }, function (data) {
                    if (data == "OK") {
                        $.messager.alert("提示", "删除成功！");
                        $("#User").datagrid("reload");
                    } else {
                        $.messager.alert("提示", "删除失败");
                    }

                })
            }
        }
    </script>
</head>
<body>
    <table id="User">
    </table>
    <!--增加的表格框-->
</body>
</html>
