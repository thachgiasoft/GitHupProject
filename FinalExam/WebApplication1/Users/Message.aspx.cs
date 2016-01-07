using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Users
{
    public partial class Message : System.Web.UI.Page
    {
        //首先要将留言的数据传到前台
        shaoqi.BLL.Message messBll = new shaoqi.BLL.Message();
        protected List<shaoqi.Model.Message> messlist = new List<shaoqi.Model.Message>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                messlist = messBll.GetModelList(" ");
            }
            else
            {

                if (Session["Userinfo"] == null)
                {
                    Response.Redirect("/Users/Login.aspx?action=" + Request.Url);

                }
                else
                {
                    shaoqi.Model.User model = (shaoqi.Model.User)Session["Userinfo"];
                    shaoqi.Model.Message messmodel = new shaoqi.Model.Message();
                    shaoqi.BLL.Message messBll = new shaoqi.BLL.Message();

                    messmodel.MgeContent = Request.Form["content"];
                    messmodel.UserId.Id = model.Id;
                    messmodel.AddTime = DateTime.Now;

                    messBll.Add(messmodel);
                    Response.Redirect("/Users/Message.aspx");
                    //重新绑定
                    messlist = messBll.GetModelList(" ");
                }
            }
        }
    }
}