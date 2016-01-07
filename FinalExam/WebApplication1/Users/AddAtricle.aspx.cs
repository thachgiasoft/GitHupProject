using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Users
{
    public partial class AddAtricle : System.Web.UI.Page
    {
        protected string title = string.Empty;
        protected string context = string.Empty;
        protected int id = 0;
        protected DateTime date;
        shaoqi.BLL.Atricle annBll = new shaoqi.BLL.Atricle();
        shaoqi.Model.Atricle annModle = new shaoqi.Model.Atricle();
        protected void Page_Load(object sender, EventArgs e)
        {
            //判断用户是否登录
            if (Session["Userinfo"] == null)
            {
                Response.Redirect("/Users/Login.aspx?action=" + Request.Url);

            }
            if (IsPostBack)
            {
                annModle.AtrContent =Server.HtmlEncode(Request.Form["editor1"]);
                annModle.Title = Request.Form["title"];
                shaoqi.Model.User model = (shaoqi.Model.User)Session["Userinfo"];
                annModle.UserId = model.Id;//要用Session中的值来进行替代 
                //说明是增加
                annModle.AddTime = DateTime.Now;
                annBll.Add(annModle);
                Response.Redirect("/Users/AtricleAllinfo.aspx");
            }

        }
    }
}