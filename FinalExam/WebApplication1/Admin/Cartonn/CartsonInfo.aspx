<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CartsonInfo.aspx.cs" Inherits="WebApplication1.Admin.Cartonn.CartsonInfo" %>

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
    <title>剧集管理页面</title>
    <script type="text/javascript">
        $(function () {


            $('#User').datagrid({
                title: '剧集管理',
                width: 700,
                height: 400,
                fitColumns: true,
                idField: 'Id',
                url: '/Admin/Cartonn/GetAllCartoonInfo.ashx?id='+<%:id%>+'',
                loadMsg: '正在加载剧集的信息...',
                pagination: true,
                singleSelect: false,
                pageSize: 10,
                pageNumber: 1,
                pageList: [10, 20, 30],
                //Id, CartoonSonName, CartNum, CartoonSonIamge, CartId, AddDateTime

                columns: [[
                    { field: 'ck', checkbox: true, align: 'left', width: 40 },
                    { field: 'Id', title: '评论编号', width: 60 },
					{ field: 'CartoonSonName', title: '漫画集名', width: 60 },
					{ field: 'CartNum', title: '漫画集数', width: 60 },
                    { field: 'CartoonSonIamge', title: '漫画图片', width: 60,
                        formatter: function (vale, row, index) {
                            return "<img src='" + vale + "' alt='无图片' width='50' height='25'/>";
                        }
                    },
                    { field: 'CartId', title: '漫画名称', width: 60 },
                    { field: 'AddDateTime', title: '评论的时间', width: 60, formatter: formatDateBoxFull },
                    {
                        field: 'SubBy', title: '删除', width: 120,
                        formatter: function (value, row, index) {
                            return "<a  href='/Admin/Cartonn/DeleteCartSon.ashx?id[]=" + row.Id + "'>删除</a>";
                        }
                    }, {
                        field: 'SubBy1', title: '编辑', width: 120,
                        formatter: function (value, row, index) {
                            return "<a  href='/Admin/Cartonn/AddCartson.aspx?id=" + row.Id + "'>编辑</a>";
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
                        window.location.href = "/Admin/Cartonn/AddCartson.aspx?action=Add";
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
                window.location.href = "/Admin/Cartonn/AddCartson.aspx?action=update&id=" + id;
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
                ids = ids.join(':');//将这个数异步异步传到一个ashx的处理
                $.post("/Admin/Cartonn/DeleteCartSon.ashx", { "ids": ids }, function (data) {
                    if (data == "OK") {
                        $.messager.alert("提示", "删除成功！");
                        $("#User").datagrid("reload");
                    } else {
                        $.messager.alert("提示", "删除失败");
                    }

                })
            }
        }






        function resize() {
            $('#User').datagrid('resize', {
                width: 700,
                height: 400
            });
        }

        function getSelected() {
            var selected = $('#User').datagrid('getSelected');
            if (selected) {
                alert(selected.code + ":" + selected.name + ":" + selected.addr + ":" + selected.col4);
            }
        }

        function getSelections() {
            var ids = [];
            var rows = $('#User').datagrid('getSelections');
            for (var i = 0; i < rows.length; i++) {
                ids.push(rows[i].code);
            }
            alert(ids.join(':'));
        }

        function clearSelections() {
            $('#User').datagrid('clearSelections');
        }

        function selectRow() {
            $('#User').datagrid('selectRow', 2);
        }

        function selectRecord() {
            $('#User').datagrid('selectRecord', '002');
        }

        function unselectRow() {
            $('#User').datagrid('unselectRow', 2);
        }

        function mergeCells() {
            $('#User').datagrid('mergeCells', {
                index: 2,
                field: 'addr',
                rowspan: 2,
                colspan: 2
            });
        }
    </script>
</head>
<body>
    <table id="User">
    </table>
    <!--增加的表格框-->
    还少一个生成静态页面的按钮。<a href="/Admin/Cartonn/CartoonInfo.aspx">返回</a>
</body>
</html>
