<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GetAdminInfo.aspx.cs" Inherits="WebApplication1.Admin.admin.GetAdminInfo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <link href="../../esayUI/themes/default/easyui.css" rel="stylesheet" type="text/css" />
    <link href="../../esayUI/themes/icon.css" rel="stylesheet" type="text/css" />
    <link href="../../esayUI/demo/demo.css" rel="stylesheet" type="text/css" />
    <script src="../../esayUI/jquery-1.8.0.min.js" type="text/javascript"></script>
    <%--<script src="../../esayUI/jquery-1.7.2.min.js" type="text/javascript"></script>--%>
    <script src="../../esayUI/jquery.easyui.min.js" type="text/javascript"></script>
    <title>后台账户管理页面</title>
    <script type="text/javascript">
        $(function () {
            $("#add").css("display", "none");

            $('#User').datagrid({
                title: '后台用户管理管理',
                width: 700,
                height: 400,
                fitColumns: true,
                idField: 'Id',
                url: '/Admin/admin/GetAllAdminInfo.ashx',
                loadMsg: '正在加载用户的信息...',
                pagination: true,
                singleSelect: false,
                pageSize: 10,
                pageNumber: 1,
                pageList: [10, 20, 30],
                //queryParams: sarcheParam, //表格初始化往后台发送异步请求后台的json数据时候额外发送的请求参数。
                //Id, LoginName, Password, Name, Phone
                columns: [[
                    { field: 'ck', checkbox: true, align: 'left', width: 40 },
                    { field: 'Id', title: '角色编号', width: 60 },
					{ field: 'LoginName', title: '登录名', width: 60 },
                    { field: 'Name', title: '真实姓名', width: 60 },
                    { field: 'Password', title: '密码', width: 60 },
                    { field: 'Phone', title: '手机号', width: 100 },
                    {
                        field: 'SubBy', title: '修改', width: 120,
                        formatter: function (value, row, index) {
                            return "<a  href='/Admin/admin/AddAdmin.aspx?action=update&id=" + row.Id + "'>修改</a>";

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
                        window.location.href = "/Admin/admin/AddAdmin.aspx?action=Add";
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
                window.location.href = "/Admin/admin/AddAdmin.aspx?action=update&id=" + id;
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
                $.post("/Admin/admin/AdminDetele.ashx", { "ids": ids }, function (data) {
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
    <div id="add" data-options="iconCls:'icon-save'" style="padding: 5px; width: 400px;
        height: 200px;">
        <table border="0" cellpadding="0" cellspacing="0">
            <tr>
                <td>
                    dddddd
                </td>
            </tr>
        </table>
    </div>
</body>
</html>
