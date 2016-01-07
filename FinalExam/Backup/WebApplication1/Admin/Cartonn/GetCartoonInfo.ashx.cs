using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Admin.Cartonn
{
    /// <summary>
    /// GetCartoonInfo 的摘要说明
    /// </summary>
    public class GetCartoonInfo : IHttpHandler
    {
        shaoqi.BLL.CatroonInfo catrBll = new shaoqi.BLL.CatroonInfo();
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
           

            List<shaoqi.Model.CatroonInfo> list = catrBll.GetModelList(" ");
            List<shaoqi.Model.CommentTwo> listTwo = new List<shaoqi.Model.CommentTwo>();
            for (int i = 0; i < list.Count; i++)
            {
                //shaoqi.Model.CommentTwo model = new shaoqi.Model.CommentTwo();
                //model.Id = list[i].Id;
                //model.CommentContext = list[i].ComContent;
                //model.UserName = list[i].UserId.LoginName;
                //model.CartoonName = list[i].CartoonId.CartoonName;
                //model.AddTime = list[i].AddTime;
                //listTwo.Add(model);
            }
            System.Web.Script.Serialization.JavaScriptSerializer json = new System.Web.Script.Serialization.JavaScriptSerializer();

            //还要查出有多少条记录
            string sqlc = "select count(*) from dbo.CatroonInfo";
            int count = catrBll.GetinfoCount(sqlc);

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