using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Users
{
    public partial class index2 : System.Web.UI.Page
    {

        //开始绑定公告页面
        shaoqi.BLL.Announce annBll = new shaoqi.BLL.Announce();
        protected List<shaoqi.Model.Announce> Annlist = new List<shaoqi.Model.Announce>();
        //绑定网站留言页面
        shaoqi.BLL.Message messBll = new shaoqi.BLL.Message();
        protected List<shaoqi.Model.Message> messModel = new List<shaoqi.Model.Message>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindAnn();
                BindMess();
            }
        }

        private void BindMess()
        {
            messModel = messBll.GetModelList(" ");
        }

        private void BindAnn()
        {
            Annlist = annBll.GetmyModelList(" ");
        }

    }
}
