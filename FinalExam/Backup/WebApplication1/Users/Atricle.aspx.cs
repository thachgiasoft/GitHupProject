using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Users
{
    public partial class Atricle : System.Web.UI.Page
    {
        //请求会发过来 id
        protected shaoqi.Model.Atricle modle = new shaoqi.Model.Atricle();
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"];
            shaoqi.BLL.Atricle annbll = new shaoqi.BLL.Atricle();
            modle = annbll.GetModel(Convert.ToInt32(id));
        }

        protected string GetName(string id)
        {
            string sql = "select  top 1 LoginName from [User] where  Id=" + id;
            shaoqi.BLL.User adminBll = new shaoqi.BLL.User();
            return adminBll.GetName(sql);
        }

    }
}