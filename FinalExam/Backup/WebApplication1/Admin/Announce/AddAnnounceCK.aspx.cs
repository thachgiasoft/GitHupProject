using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Admin.Announce
{
    public partial class AddAnnounceCK : BasePage
    {
        protected string title = string.Empty;
        protected string context = string.Empty;
        protected int id = 0;
        protected DateTime date;
        shaoqi.BLL.Announce annBll = new shaoqi.BLL.Announce();
        shaoqi.Model.Announce annModle = new shaoqi.Model.Announce();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                annModle.AnnContent = Request.Form["editor1"];
                annModle.Title = Request.Form["title"];

                annModle.AdminId = 1;//要用Session中的值来进行替代 

                if (Convert.ToInt32(Request.Form["id"]) == 0)
                {
                    //说明是增加
                    annModle.AddTime = DateTime.Now;
                    annBll.Add(annModle);
                }
                else
                {
                    //说明是更新
                    annModle.Id = Convert.ToInt32(Request.Form["id"]);
                    annModle.AddTime = Convert.ToDateTime(Request.Form["date"]);
                    annBll.Update(annModle);
                }
                Response.Redirect("/Admin/Announce/Announce.aspx");
            }
            else
            {
                string action = Request.QueryString["action"];
                if (action == "update")
                {
                    int id1 = Convert.ToInt32(Request.QueryString["id"]);
                    annModle = annBll.GetModel(id1);
                    id = annModle.Id;
                    title = annModle.Title;
                    context = annModle.AnnContent;
                    date = annModle.AddTime;
                }

            }
        }
    }
}