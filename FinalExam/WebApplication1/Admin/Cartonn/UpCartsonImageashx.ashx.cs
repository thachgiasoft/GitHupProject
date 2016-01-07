using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Admin.Cartonn
{
    /// <summary>
    /// UpCartsonImageashx 的摘要说明
    /// </summary>
    public class UpCartsonImageashx : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            if (context.Request.Files["CartImage"] != null)
            {
                context.Response.ContentType = "text/plain";

                var fileImage = context.Request.Files["CartImage"];
                string Allpath = "/UpImage/CartSonImage/" + Guid.NewGuid() + fileImage.FileName;
                fileImage.SaveAs(context.Server.MapPath(Allpath));
                context.Response.Write(Allpath);
            }
            else
            {
                context.Response.Write("没有文件");
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