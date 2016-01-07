using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Users
{
    public partial class Login : System.Web.UI.Page
    {

        protected string msg = string.Empty;
        protected string username = string.Empty;
        string action = string.Empty;
        protected void Page_Load(object sender, EventArgs e)
        {
            shaoqi.BLL.User bll = new shaoqi.BLL.User();

            if (Request.Form["hidden"] != null)
            {
                //post发送过来的
                string name = Request.Form["username"];
                username = name;
                string password = Request.Form["password"];
                string vail = Request.Form["yzm"];
                string truevail = Session["vCode"].ToString();

                if (vail == truevail)
                {
                    shaoqi.Model.User model = bll.GetmodleByName(name);
                    if (model != null && model.Password == password)
                    {
                        //正确跳转到主页面  要将用户的信息添加到Session中
                        Session.Add("Userinfo", model);
                      
                            Response.Redirect("/Users/index2.aspx");

                    }
                    else
                    {
                        msg = "帐号或者秘密错误";
                    }
                }
                else
                {
                    msg = "验证码输入错误";
                }
            }
            else
            {
                action = Request.QueryString["action"];
            }

        }
    }
}