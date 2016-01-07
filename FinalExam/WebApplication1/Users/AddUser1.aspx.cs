using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Users
{
    public partial class AddUser1 : System.Web.UI.Page
    {

        shaoqi.BLL.User user1bll = new shaoqi.BLL.User();
        shaoqi.Model.User model1 = new shaoqi.Model.User();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                model1.LoginName = Request.Form["User"];
                model1.Password = Request.Form["password"];
                model1.Phone = Request.Form["contact"];
                model1.Email = Request.Form["company"];
                bool success = false;
                success = user1bll.Add(model1);
                if (success)
                {
                    Response.Redirect("/Users/index2.aspx");
                }
                else
                {
                    Response.Redirect("/404.htm");
                }
            }

        }
    }
}