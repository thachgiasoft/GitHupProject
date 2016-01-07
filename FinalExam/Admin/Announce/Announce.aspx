<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Announce.aspx.cs" Inherits="WebApplication1.Admin.Announce.Announce" %>

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
    <title>公告管理页面</title>
    <script type="text/javascript">
        $(function () {
            $("#add").css("display", "none");  

            $('#User').datagrid({
                title: '公告管理',
                width: 700,
                height: 400,
                fitColumns: true,
                idField: 'Id',
                url: '/Admin/Announce/GetAllAnnounce.ashx',
                loadMsg: '正在加载用户的信息...',
                pagination: true,
                singleSelect: false,
                pageSize: 10,
                pageNumber: 1,
                pageList: [10, 20, 30],
                //Id, Title, AnnContent, AdminId, AddTime

                columns: [[
                    { field: 'ck', checkbox: true, align: 'left', width: 40 },
                    { field: 'Id', title: '公告编号', width: 40 },
					{ field: 'Title', title: '公告题目', width: 60 },
                    { field: 'adminName', title: '添加人', width: 50 },
                    { field: 'AddTime', title: '增加的时间', width: 100,
                        formatter: formatDateBoxFull, editor: 'datebox'
                    },
                    {
                        field: 'SubBy', title: '修改', width: 60,
                        formatter: function (value, row, index) {
                            return "<a  href='/Admin/Announce/AddAnnounceCK.aspx?action=update&id=" + row.Id + "'>修改</a>";
                        }
                    },
                      {
                        field: 'SubBy1', title: '详情', width: 60,
                        formatter: function (value, row, index) {
                            return "<a  href='/Admin/Announce/AddAnnounceCK.aspx?action=more&id=" + row.Id + "'>详情</a>";
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
                        window.location.href = "/Admin/Announce/AddAnnounceCK.aspx?action=Add";
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
                window.location.href = "/Admin/Announce/AddAnnounceCK.aspx?action=update&id=" + id;
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
                ids = ids.join(':');
                //将这个数异步传到一个ashx的处理
                $.post("/Admin/Announce/DeleteAnnounce.ashx", { "ids": ids }, function (data) {
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
     还少一个生成静态页面的按钮。
</body>
</html>
