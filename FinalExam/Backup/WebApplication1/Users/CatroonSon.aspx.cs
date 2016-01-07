using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Users
{
    public partial class CatroonSon : System.Web.UI.Page
    {
        //会有个Id传过来
        shaoqi.BLL.CartSon sonBll = new shaoqi.BLL.CartSon();
        List<shaoqi.Model.CartSon> sonList = new List<shaoqi.Model.CartSon>();
        protected string pId = string.Empty;
        protected string msg = string.Empty;
        protected string msgms = string.Empty;
        protected void Page_Load(object sender, EventArgs e)
        {
            String id = Request.QueryString["id"];
            if (!IsPostBack)
            {
                
                pId = id;
                Bindjiushu(id);//绑定  
                BindMessage(id);
            }
            else
            {

                if (Session["Userinfo"] == null)
                {
                    Response.Redirect("/Users/Login.aspx");

                }
                else
                {
                    shaoqi.Model.User model = (shaoqi.Model.User)Session["Userinfo"];
                    shaoqi.Model.Comment messmodel = new shaoqi.Model.Comment();
                    shaoqi.BLL.Comment messBll = new shaoqi.BLL.Comment();
                    messmodel.ComContent = Request.Form["context"];
                    messmodel.UserId.Id = model.Id;
                    messmodel.CartoonId.Id = Convert.ToInt32(Request.Form["Pid"]);
                    messmodel.AddTime = DateTime.Now;
                    messBll.Add(messmodel);
                    BindMessage(messmodel.CartoonId.Id.ToString());

                }
            }
        }

        private void BindMessage(String id)
        {
            shaoqi.BLL.Comment messBll = new shaoqi.BLL.Comment();
            List<shaoqi.Model.Comment> messList = new List<shaoqi.Model.Comment>();
            messList = messBll.GetModelList(" CartoonId=" + id);
            if (messList.Count == 0)
            {
                msg = "暂时没有评论！";
               
            }
            else
            {
                this.Repeater2.DataSource = messList;
                this.Repeater2.DataBind();
            }

        }

        private void Bindjiushu(String id)
        {

            //查询出所有的漫画
            sonList = sonBll.GetModelList(" CartId=" + id);
            if (sonList.Count == 0)
            {
                msgms = "暂时没有漫画！";
 
            }
            else
            {
                this.Repeater1.DataSource = sonList;
                this.Repeater1.DataBind();
            }

        }


        public String GetName(string id)
        {
            string sql = "select  top 1 LoginName from [User] where id=" + id;
            shaoqi.BLL.User adminBll = new shaoqi.BLL.User();
            return adminBll.GetName(sql);
        }
    }
}