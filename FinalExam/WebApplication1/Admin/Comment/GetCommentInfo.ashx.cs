using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Admin.Comment
{
    /// <summary>
    /// GetCommentInfo 的摘要说明
    /// </summary>
    public class GetCommentInfo : IHttpHandler
    {
        shaoqi.BLL.Comment comBll = new shaoqi.BLL.Comment();
        public void ProcessRequest(HttpContext context)
        {

            context.Response.ContentType = "text/plain";
            //就是将所有的User中的信息添加到主表中 Id, LoginName, Password, Phone, Email, UserState

            List<shaoqi.Model.Comment> list = comBll.GetModelList(" ");
            List<shaoqi.Model.CommentTwo> listTwo = new List<shaoqi.Model.CommentTwo>();
            for (int i = 0; i < list.Count; i++)
            {
                shaoqi.Model.CommentTwo model = new shaoqi.Model.CommentTwo();
                model.Id = list[i].Id;
                model.CommentContext = list[i].ComContent;
                model.UserName = list[i].UserId.LoginName;
                model.CartoonName = list[i].CartoonId.CartoonName;
                model.AddTime = list[i].AddTime;
                listTwo.Add(model);
            }
            System.Web.Script.Serialization.JavaScriptSerializer json = new System.Web.Script.Serialization.JavaScriptSerializer();

            //还要查出有多少条记录
            string sqlc = "select count(*) from Comment";
            int count = comBll.GetinfoCount(sqlc);

            var info = new { total = count, rows = listTwo };

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