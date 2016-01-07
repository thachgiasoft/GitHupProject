using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Admin.Announce
{
    /// <summary>
    /// Announce1 的摘要说明
    /// </summary>
    public class Announce1 : IHttpHandler
    {
        shaoqi.BLL.Announce annBll = new shaoqi.BLL.Announce();
        shaoqi.BLL.Admin adminBll = new shaoqi.BLL.Admin();
        public void ProcessRequest(HttpContext context)
        {

            context.Response.ContentType = "text/plain";
            //就是将所有的User中的信息添加到主表中 Id, LoginName, Password, Phone, Email, UserState

            List<shaoqi.Model.Announce> list = annBll.GetModelList(" ");
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].AnnContent.Length > 200)
                {
                    list[i].AnnContent = list[i].AnnContent.Substring(0, 200);
                }

                list[i].adminName = adminBll.GetModel(Convert.ToInt32(list[i].AdminId)).LoginName;
            }
            System.Web.Script.Serialization.JavaScriptSerializer json = new System.Web.Script.Serialization.JavaScriptSerializer();

            //还要查出有多少条记录
            string sqlc = "select count(*) from Announce";
            int count = annBll.GetinfoCount(sqlc);

            var info = new { total = count, rows = list };

            string allinfo = json.Serialize(info);

            context.Response.Write(allinfo);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}