<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CartoonInfo.aspx.cs" Inherits="WebApplication1.Admin.Cartonn.CartoonInfo" %>

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
    <title>漫画管理页面</title>
    <script type="text/javascript">
        $(function () {
            $('#User').datagrid({
                title: '漫画管理管理',
                width: 800,
                height: 400,
                fitColumns: true,
                idField: 'Id',
                url: '/Admin/Cartonn/GetCartoonInfo.ashx',
                loadMsg: '正在加载漫画评论的信息...',
                pagination: true,
                singleSelect: false,
                pageSize: 10,
                pageNumber: 1,
                pageList: [10, 20, 30],
                //Id, CartoonName, CartoonIntroduce, CartoonImage, CategoriesId,

                columns: [[
                    { field: 'ck', checkbox: true, align: 'left', width: 40 },
                    { field: 'Id', title: '评论编号', width: 60 },
					{ field: 'CartoonName', title: '漫画名', width: 60 },
                    { field: 'CartoonIntroduce', title: '评论内容', width: 60 },
                    { field: 'CartoonImage', title: '漫画图片', width: 60,
                        formatter: function (vale, row, index) {
                            return "<img src='" + vale + "' alt='无图片' width='50' height='25'/>";
                        }
                    },
                    { field: 'CategoriesId', title: '动漫类别', width: 60 },
                    { field: 'AddDateTime', title: '评论的时间', width: 60, formatter: formatDateBoxFull },
                    {
                        field: 'SubBy', title: '删除', width: 120,
                        formatter: function (value, row, index) {
                            return "<a  href='/Admin/Comment/DeleteComment.ashx?id[]=" + row.Id + "'>删除</a>";
                        }
                    }, {
                        field: 'SubBy1', title: '编辑', width: 120,
                        formatter: function (value, row, index) {
                            return "<a  href='/Admin/Cartonn/AddCartInfo.aspx?id=" + row.Id + "'>编辑</a>";
                        }
                    },
                    {
                        field: 'SubBy2', title: '剧集管理', width: 120,
                        formatter: function (value, row, index) {
                            return "<a  href='/Admin/Cartonn/CartsonInfo.aspx?id=" + row.Id + "'>管理</a>";
                        }
                    }
				]],
                pagination: true,
                rownumbers: true,
                toolbar: [{
                    id: 'btnadd',
                    text: '增加',
                    iconCls: 'icon-add',
                    handler: function () {
                        window.location.href = "/Admin/Cartonn/AddCartInfo.aspx?action=Add";
                    }
                }, {
                    id: 'btncut',
                    text: '删除',
                    iconCls: 'icon-cut',
                    handler: function () {
                        Delete();
                    }
                }, '-', {
                    id: 'btnsave',
                    text: '修改',
                    disabled: false,
                    iconCls: 'icon-save',
                    handler: function () {
                        edit();
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

        function edit() {

            var rows = $('#User').datagrid('getSelections');

            if (rows.length != 1) {
                $.messager.alert("错误消息", "请选中一条信息进行修改");
                return;
            } else {
                var id = rows[0].Id;
                window.location.href = "/Admin/Cartonn/AddCartInfo.aspx?action=update&id=" + id;
            }
        }

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
                ids = ids.join(':'); //将这个数异步异步异步传到一个ashx的处理
                $.post("/Admin/Cartonn/DeleteCartoon.ashx", { "ids": ids }, function (data) {
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
    <img src="#" width="10" height="20" alt="Alternate Text" />
    <!--增加的表格框-->
</body>
</html>
