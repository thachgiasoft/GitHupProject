using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Admin.admin
{
    /// <summary>
    /// GetAllAdminInfo 的摘要说明
    /// </summary>
    public class GetAllAdminInfo : IHttpHandler
    {
        shaoqi.BLL.Admin admiBll = new shaoqi.BLL.Admin();
        public void ProcessRequest(HttpContext context)
        {

            context.Response.ContentType = "text/plain";
            //就是将所有的User中的信息添加到主表中 

            List<shaoqi.Model.Admin> list = admiBll.GetModelList(" ");
            System.Web.Script.Serialization.JavaScriptSerializer json = new System.Web.Script.Serialization.JavaScriptSerializer();

            //还要查出有多少条记录
            string sqlc = "select count(*) from Admin";
            int count = admiBll.GetinfoCount(sqlc);

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