using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Page : System.Web.UI.MasterPage
    {
        protected List<shaoqi.Model.Menu> linkList = new List<shaoqi.Model.Menu>();
        protected List<shaoqi.Model.Link> link1List = new List<shaoqi.Model.Link>();
        protected String name = "未登录";

        protected void Page_Load(object sender, EventArgs e)
        {
            //绑定菜单
            shaoqi.BLL.Menu MenuBll = new shaoqi.BLL.Menu();
            linkList = MenuBll.GetModelList(" pId='20150012'");

            //绑定友情连接
            shaoqi.BLL.Link LinkBll = new shaoqi.BLL.Link();
            link1List = LinkBll.GetModelList(" ");

            if (Session["Userinfo"] != null)
            {
                shaoqi.Model.User model = (shaoqi.Model.User)Session["Userinfo"];
                name = model.LoginName;
            }

        }
    }
}