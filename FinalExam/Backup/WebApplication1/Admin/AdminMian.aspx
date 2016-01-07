<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminMian.aspx.cs" EnableSessionState="True"
    Inherits="WebApplication1.Admin.AdminMian" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=GBK">
    <title>中华漫画后台网</title>
    <link rel="stylesheet" type="text/css" href="/esayUI/themes/gray/easyui.css">
    <script type="text/javascript" src="/esayUI/jquery-1.7.2.min.js"></script>
    <script type="text/javascript" src="/esayUI/jquery.easyui.min.js"></script>
    <style type="text/css">
        body
        {
            font: 12px/20px "微软雅黑" , "宋体" , Arial, sans-serif, Verdana, Tahoma;
            padding: 0;
            margin: 0;
        }
        a:link
        {
            text-decoration: none;
        }
        a:visited
        {
            text-decoration: none;
        }
        a:hover
        {
            text-decoration: underline;
        }
        a:active
        {
            text-decoration: none;
        }
        .cs-north
        {
            height: 60px;
            background: #B3DFDA;
        }
        .cs-north-bg
        {
            width: 100%;
            height: 100%;
            background: url(../themes/gray/images/header_bg.png) repeat-x;
        }
        .cs-north-logo
        {
            height: 40px;
            padding: 15px 0px 0px 5px;
            color: #fff;
            font-size: 22px;
            font-weight: bold;
            text-decoration: none;
        }
        .cs-west
        {
            width: 200px;
            padding: 0px;
            border-left: 1px solid #99BBE8;
        }
        .cs-south
        {
            height: 25px;
            background: url('../themes/gray/images/panel_title.gif') repeat-x;
            padding: 0px;
            text-align: center;
        }
        .cs-navi-tab
        {
            padding: 5px;
        }
        .cs-tab-menu
        {
            width: 120px;
        }
        .cs-home-remark
        {
            padding: 10px;
        }
    </style>
    <script type="text/javascript">
        function addTab(title, url) {
            if ($('#tabs').tabs('exists', title)) {
                $('#tabs').tabs('select', title); //选中并刷新
                var currTab = $('#tabs').tabs('getSelected');
                var url = $(currTab.panel('options').content).attr('src');
                if (url != undefined && currTab.panel('options').title != 'Home') {
                    $('#tabs').tabs('update', {
                        tab: currTab,
                        options: {
                            content: createFrame(url)
                        }
                    })
                }
            } else {
                var content = createFrame(url);
                $('#tabs').tabs('add', {
                    title: title,
                    content: content,
                    closable: true
                });
            }
            tabClose();
        }
        function createFrame(url) {
            var s = '<iframe scrolling="auto" frameborder="0"  src="' + url + '" style="width:100%;height:100%;"></iframe>';
            return s;
        }

        function tabClose() {
            /*双击关闭TAB选项卡*/
            $(".tabs-inner").dblclick(function () {
                var subtitle = $(this).children(".tabs-closable").text();
                $('#tabs').tabs('close', subtitle);
            })
            /*为选项卡绑定右键*/
            $(".tabs-inner").bind('contextmenu', function (e) {
                $('#mm').menu('show', {
                    left: e.pageX,
                    top: e.pageY
                });

                var subtitle = $(this).children(".tabs-closable").text();

                $('#mm').data("currtab", subtitle);
                $('#tabs').tabs('select', subtitle);
                return false;
            });
        }
        //绑定右键菜单事件
        function tabCloseEven() {
            //刷新
            $('#mm-tabupdate').click(function () {
                var currTab = $('#tabs').tabs('getSelected');
                var url = $(currTab.panel('options').content).attr('src');
                if (url != undefined && currTab.panel('options').title != 'Home') {
                    $('#tabs').tabs('update', {
                        tab: currTab,
                        options: {
                            content: createFrame(url)
                        }
                    })
                }
            })
            //关闭当前
            $('#mm-tabclose').click(function () {
                var currtab_title = $('#mm').data("currtab");
                $('#tabs').tabs('close', currtab_title);
            })
            //全部关闭
            $('#mm-tabcloseall').click(function () {
                $('.tabs-inner span').each(function (i, n) {
                    var t = $(n).text();
                    if (t != 'Home') {
                        $('#tabs').tabs('close', t);
                    }
                });
            });
            //关闭除当前之外的TAB
            $('#mm-tabcloseother').click(function () {
                var prevall = $('.tabs-selected').prevAll();
                var nextall = $('.tabs-selected').nextAll();
                if (prevall.length > 0) {
                    prevall.each(function (i, n) {
                        var t = $('a:eq(0) span', $(n)).text();
                        if (t != 'Home') {
                            $('#tabs').tabs('close', t);
                        }
                    });
                }
                if (nextall.length > 0) {
                    nextall.each(function (i, n) {
                        var t = $('a:eq(0) span', $(n)).text();
                        if (t != 'Home') {
                            $('#tabs').tabs('close', t);
                        }
                    });
                }
                return false;
            });
            //关闭当前右侧的TAB
            $('#mm-tabcloseright').click(function () {
                var nextall = $('.tabs-selected').nextAll();
                if (nextall.length == 0) {
                    //msgShow('系统提示','后边没有啦~~','error');
                    alert('后边没有啦~~');
                    return false;
                }
                nextall.each(function (i, n) {
                    var t = $('a:eq(0) span', $(n)).text();
                    $('#tabs').tabs('close', t);
                });
                return false;
            });
            //关闭当前左侧的TAB
            $('#mm-tabcloseleft').click(function () {
                var prevall = $('.tabs-selected').prevAll();
                if (prevall.length == 0) {
                    alert('到头了，前边没有啦~~');
                    return false;
                }
                prevall.each(function (i, n) {
                    var t = $('a:eq(0) span', $(n)).text();
                    $('#tabs').tabs('close', t);
                });
                return false;
            });

            //退出
            $("#mm-exit").click(function () {
                $('#mm').menu('hide');
            })
        }

        $(function () {
            tabCloseEven();
            $('.cs-navi-tab').click(function () {
                var $this = $(this);
                var href = $this.attr('src');
                var title = $this.text();
                addTab(title, href);
            });
        });
    </script>
</head>
<body class="easyui-layout">
    <div region="north" border="true" class="cs-north">
        <div class="cs-north-bg">
            <div class="cs-north-logo">
                中华漫画后台网</div>
        </div>
    </div>
    <div region="west" border="true" split="true" title="后台管理目录" class="cs-west">
        <div class="easyui-accordion" border="false">
            <div title="帐号管理">
                <a href="javascript:void(0);" src="/Admin/admin/GetAdminInfo.aspx" class="cs-navi-tab">
                    管理员帐号管理</a></p> <a href="javascript:void(0);" src="/Admin/User/GetUserInfo.aspx"
                        class="cs-navi-tab">用户帐号管理</a></p>
            </div>
            <div title="公告，文章管理">
                <a href="javascript:void(0);" src="/Admin/Announce/Announce.aspx" class="cs-navi-tab">
                    公告管理</a></p> <a href="javascript:void(0);" src="/Admin/Atricle/AtrcleInfo.aspx" class="cs-navi-tab">
                        文章管理</a></p>
            </div>
            <div title="评论，留言管理">
                <a href="javascript:void(0);" src="/Admin/Comment/CommentInfo.aspx" class="cs-navi-tab">
                    评论管理</a></p> <a href="javascript:void(0);" src="/Admin/Message/MessageInfo.aspx"
                        class="cs-navi-tab">留言管理</a></p>
            </div>
            <div title="漫画管理">
                <a href="javascript:void(0);" src="/Admin/Cartonn/CartoonInfo.aspx" class="cs-navi-tab">
                    漫画信息管理</a></p> </p>
            </div>
            <div title="菜单管理">
                <a href="javascript:void(0);" src="/Admin/Menu/MenuInfo.aspx" class="cs-navi-tab">
                    菜单管理</a></p> 
            </div>
            <div title="友情连接管理">
                <a href="javascript:void(0);" src="/Admin/Link/LinkInfo.aspx" class="cs-navi-tab">
                    友情连接</a></p>
            </div>
        </div>
    </div>
    <div id="mainPanle" region="center" border="true" border="false">
        <div id="tabs" class="easyui-tabs" fit="true" border="false">
            <div title="Home">
                <div class="cs-home-remark">
                    <h1>
                        中华漫画后台管理网站</h1>
                    <br>
                    制作：邵祺
                    <br>
                    说明：公司后台网站不允许外网的电脑进行登录 有事情联系 0571-64567758
                </div>
                <a href="../../Users/index2.aspx">前台人口</a>
            </div>
        </div>
    </div>
    <div region="south" border="false" class="cs-south">
        @549730265@qq.com</div>
    <div id="mm" class="easyui-menu cs-tab-menu">
        <div id="mm-tabupdate">
            刷新</div>
        <div class="menu-sep">
        </div>
        <div id="mm-tabclose">
            关闭</div>
        <div id="mm-tabcloseother">
            关闭其他</div>
        <div id="mm-tabcloseall">
            关闭全部</div>
    </div>
</body>
</html>
