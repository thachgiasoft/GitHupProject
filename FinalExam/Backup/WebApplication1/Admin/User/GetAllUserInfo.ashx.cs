using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Admin.User
{
    /// <summary>
    /// GetAllUserInfo 的摘要说明
    /// </summary>
    public class GetAllUserInfo : IHttpHandler
    {
        shaoqi.BLL.User userBll = new shaoqi.BLL.User();
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            //就是将所有的User中的信息添加到主表中 Id, LoginName, Password, Phone, Email, UserState
            
            List<shaoqi.Model.User> list = userBll.GetModelList(" ");
            System.Web.Script.Serialization.JavaScriptSerializer json = new System.Web.Script.Serialization.JavaScriptSerializer();
            
            //还要查出有多少条记录
            string sqlc = "select count(*) from [User]";
            int count = userBll.GetinfoCount(sqlc);

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