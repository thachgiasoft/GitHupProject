using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Users
{
    public partial class Announce : System.Web.UI.Page
    {
        //请求会发过来 id
        protected shaoqi.Model.Announce modle = new shaoqi.Model.Announce();
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"];
            shaoqi.BLL.Announce annbll = new shaoqi.BLL.Announce();
            modle = annbll.GetModel(Convert.ToInt32(id));
        }

        protected string GetName(string id)
        {
            string sql = "select  top 1 Name from Admin where id=" + id;
            shaoqi.BLL.Admin adminBll = new shaoqi.BLL.Admin();
            return adminBll.GetName(sql);
        }
    }
}