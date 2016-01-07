<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WebApplication1.Users.index" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html lang="en-US" xmlns="http://www.w3.org/1999/xhtml" dir="ltr">
<head>
    <title>中华动画网</title>
    <meta http-equiv="Content-type" content="text/html; charset=utf-8" />
    <link rel="shortcut icon" href="/css/images/favicon.ico" />
    <link rel="stylesheet" href="/css/style.css" type="text/css" media="all" />
    <!--[if IE 6]>
		<link rel="stylesheet" href="css/ie6.css" type="text/css" media="all" />
		<script src="js/png-fix.js" type="text/javascript"></script>
	<![endif]-->
    <script src="/js/jquery-1.4.2.js" type="text/javascript"></script>
    <script src="/js/jquery.jcarousel.js" type="text/javascript"></script>
    <script src="/js/js-func.js" type="text/javascript"></script>
</head>
<body>
    <!-- Header -->
    <div id="header">
        <div class="shell">
            <%--<h1 id="logo" ><a href="#">中华动画网 - 商业 / 你好 自由 模板</a></h1>2222--%>
            <div id="navigation">
                <ul>
                    <li><a href="/Users/index2.aspx" class="active"><span>主页</span></a></li>
                    <li><a href="/Users/Cartoon.aspx"><span>漫画</span></a></li>
                    <li><a href="/Users/Message.aspx"><span>留言</span></a></li>
                    <li><a href="/Users/AtricleAllinfo.aspx"><span>文章</span></a> </li>
                    <li><a href="#"><span>相关文件</span></a></li>
                    <li><a href="/Admin/Login.aspx"><span>后台登录页面</span></a></li>
                    <li><a href="/Users/Login.aspx"><span>登录</span></a></li>
                </ul>
                <a href="#" class="buy-now">加入我们</a>
            </div>
            <div class="cl">
                &nbsp;</div>
            <div class="search">
                <form action="#" method="post">
                <span class="field">
                    <input type="text" class="blink" value="Search" title="Search" />
                </span>
                <input type="submit" class="search-btn notext" value="Submit" />
                </form>
            </div>
        </div>
    </div>
    <!-- End Header -->
    <!-- Slider -->
    <div id="slider">
        <div class="shell">
            <div class="slider-holder">
                <div class="slider-left">
                    <ul>
                        <li>
                            <h2>
                                &nbsp;&nbsp;海贼王</h2>
                            <p>
                                传奇海盗哥尔·D·罗杰在临死前曾留下关于其毕生的财富“One Piece”的消息，由此引得群雄并起，众海盗们为了这笔传说中的巨额财富展开争夺，各种势力、政权不断交替，整个世界进入了动荡混乱的“大海贼时代”。生长在东海某小村庄的路飞受到海贼香克斯的精神指引，决定成为一名出色的海盗。为了达成这个目标，并找到万众瞩目的One
                                Piece，路飞踏上艰苦的旅程。一路上他遇到了无数磨难，也结识了索隆、娜美、乌索普、香吉、罗宾等一众性格各异的好友。他们携手一同展开充满传奇色彩的大冒险。</p>
                        </li>
                        <li>
                            <h2>
                                &nbsp;&nbsp;火影忍者</h2>
                            <p>
                                十多年前一只拥有巨大威力的妖兽“九尾妖狐”袭击了木叶忍者村，当时的第四代火影拼尽全力，以自己的生命为代价将“九尾妖狐”封印在了刚出生的鸣人身上。木叶村终于恢复了平静，但村民们却把鸣人当成像“九尾妖狐”那样的怪物看待，所有人都疏远他。鸣人自小就孤苦无依，一晃十多年过去了，少年鸣人考入了木叶村的忍者学校，结识了好朋友佐助和小樱。佐助是宇智波家族的传人之一，当他还是小孩的时候他的哥哥——一个已经拥有高超忍术的忍者将他们家族的人都杀死了，然后投靠了一直想将木叶村毁灭的大蛇丸，佐助自小就发誓要超越哥哥，为家族报仇。</p>
                        </li>
                        <li>
                            <h2>
                                &nbsp;&nbsp;死神</h2>
                            <p>
                                主角黑崎一护是个看似单薄却满身热血少年，并且拥有能看见灵的体质。家里有一个开医院兼除灵的老爸和两个性格绝对正常的妹妹，一护每天七点必须按时回家否则老爸便会使用“身体语言教训”的暴力家规。吵闹的父子，懂事的妹妹以及与其他普通人无大异的普通生活。等到露琪亚被他一脚踢到墙角并满脸惊疑地望着他问“你能看见我？”时序幕才这样被他正式地踢开。</p>
                        </li>
                        <li>
                            <h2>
                                &nbsp;&nbsp;美食的俘虏</h2>
                            <p>
                                美食风靡全球，未知食材动辄千金的美食时代为舞台，每个人都在追求未知的美味，那是无上的奢侈和幸福，在这样一个时代，有着这样一群冒险家，他们接受美食家的委托，探寻那些见所未见的神秘食材，他们就是美食猎人。但是，那些传奇的食材动植物之凶猛超乎人们的想象，“强大”=“美味”，在美食时代，唯有“强大的食材”才是“美食”，“美味”是“强大”的代名词，美食猎人投身危机四伏的地带，寻找凶猛之至的“食材”，堪称美食时代的英雄！</p>
                        </li>
                    </ul>
                </div>
                <div class="slider-right">
                    <ul>
                        <li>
                            <img src="/css/images/haiziwang.png" alt="海贼王" /></li>
                        <li>
                            <img src="/css/images/Nature.png" alt="火影忍者" /></li>
                        <li>
                            <img src="/css/images/Death.png" alt="死神" /></li>
                        <li>
                            <img src="/css/images/meishi.png" alt="美食的俘虏" /></li>
                    </ul>
                </div>
                <div class="cl">
                    &nbsp;</div>
                <div class="slider-nav">
                    <a href="#">1</a> <a href="#">2</a> <a href="#">3</a> <a href="#">4</a>
                    <div class="cl">
                        &nbsp;</div>
                </div>
            </div>
        </div>
    </div>
    <!-- End Slider -->
    <!-- Main -->
    <div id="main">
        <div class="shell">
            <div class="col">
                <h2>
                    关于我们团队</h2>
                <p>
                    &nbsp;&nbsp;其实我们的团队有许多的职位，分工很明确，客户经理，前台美工，前端工程师，后台工程师，数据管理员等等。可是因为资金和人才的短缺。所以以上的职位都是有我一人暂时担任。如果你有足够的耐心，你有足够的知识，你有足够的能力。那么还在等什么，赶快加入我们。人生巅峰在向你招手。点击网站右上角。</p>
                <a href="#" class="find-more">加入我们</a>
            </div>
            <div class="col">
                <h2>
                    网站公告</h2>
                <ul>
                    <%for (int i = 0; i < Annlist.Count; i++)
                      {%>
                    <li><a href="/Users/Announce.aspx?id=<%:Annlist[i].Id%>">
                        <%:Annlist[i].Title %>
                    </a>
                        <p style="float: right;">
                            <%:Annlist[i].AddTime.ToString("yyyy-MM-dd")%></p>
                        </a></li>
                    </li>
                    <%} %>
                </ul>
                <div class="cl">
                    &nbsp;</div>
                <a href="#" class="find-more">查看更多</a>
            </div>
            <div class="col last">
                <h2>
                    留言版</h2>
                <p>
                    <ul>
                        <%for (int i = 0; i < messModel.Count; i++)
                          {%>
                        <li>
                            <%:messModel[i].MgeContent%>
                            <p style="float: right;">
                                <%:messModel[i].AddTime.ToString("yyyy-MM-dd")%></p>
                            </a></li>
                        <%} %>
                    </ul>
                </p>
                <div class="cl">
                    &nbsp;</div>
                <a href="/Users/Message.aspx" class="find-more">留下您的意见</a>
            </div>
            <div class="cl">
                &nbsp;</div>
        </div>
    </div>
    <!-- End Main -->
    <!-- Footer -->
    <div id="footer">
        <div class="shell">
            <p class="left">
                Copyright &copy; 2010 RightDirection. All rights reserved. Designed by <a href="http://chocotemplates.com"
                    target="_blank" title="The Sweetest CSS Templates WorldWide">Chocotemplates.com</a></p>
            <p class="right">
                <a href="#">Home</a> <span>|</span> <a href="#">About</a> <span>|</span> <a href="#">
                    Team</a> <span>|</span> <a href="#">Jobs</a> <span>|</span> <a href="#">Contact Us</a>
                <span>|</span> <a href="#">Portfolio</a> <span>|</span> <a href="#">Blog</a>
            </p>
            <div class="cl">
                &nbsp;</div>
        </div>
    </div>
    <!-- Footer -->
</body>
</html>
