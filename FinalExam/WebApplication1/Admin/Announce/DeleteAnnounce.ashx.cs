using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Admin.Announce
{
    /// <summary>
    /// DeleteAnnounce 的摘要说明
    /// </summary>
    public class DeleteAnnounce : IHttpHandler
    {
        shaoqi.BLL.Announce annBll = new shaoqi.BLL.Announce();
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            String ids = context.Request.Form["ids"];
            if (ids.Contains(":"))
            {
                string[] id = ids.Split(':');
                for (int i = 0; i < id.Count(); i++)
                {
                    int idd = Convert.ToInt32(id[i]);
                    annBll.Delete(idd);
                }
                context.Response.Write("OK");
            }
            else
            {
                int idd = Convert.ToInt32(ids);
                if (annBll.Delete(idd))
                {
                    context.Response.Write("OK");
                }
                else
                {
                    context.Response.Write("shi");
                }
            }
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