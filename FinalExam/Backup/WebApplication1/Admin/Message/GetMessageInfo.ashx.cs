using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Admin.Message
{
    /// <summary>
    /// GetMessageInfo 的摘要说明
    /// </summary>
    public class GetMessageInfo : IHttpHandler
    {
        shaoqi.BLL.Message mesBll = new shaoqi.BLL.Message();
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            //就是将所有的User中的信息添加到主表中 Id, LoginName, Password, Phone, Email, UserState

            List<shaoqi.Model.Message> list = mesBll.GetModelList(" ");
            List<shaoqi.Model.MessageTwo> listTwo = new List<shaoqi.Model.MessageTwo>();

            System.Web.Script.Serialization.JavaScriptSerializer json = new System.Web.Script.Serialization.JavaScriptSerializer();

            //还要查出有多少条记录
            string sqlc = "select count(*) from Message";
            int count = mesBll.GetinfoCount(sqlc);

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