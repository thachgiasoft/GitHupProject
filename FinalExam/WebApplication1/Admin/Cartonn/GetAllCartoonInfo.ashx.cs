using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Admin.Cartonn
{
    /// <summary>
    /// GetAllCartoonInfo 的摘要说明
    /// </summary>
    public class GetAllCartoonInfo : IHttpHandler
    {
        shaoqi.BLL.CartSon sonBll = new shaoqi.BLL.CartSon();
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            //就是将所有的User中的信息添加到主表中 Id, LoginName, Password, Phone, Email, UserState
            string id=context.Request.QueryString["id"];
            List<shaoqi.Model.CartSon> list = sonBll.GetModelList(" CartId=" + id);
            for (int i = 0; i < list.Count; i++)
            {
                //if (list[i].AtrContent.Length > 200)
                //{
                //    list[i].AtrContent = list[i].AtrContent.Substring(0, 200);
                //}

                //list[i].adminName = adminBll.GetModel(Convert.ToInt32(list[i].AdminId)).LoginName;
            }
            System.Web.Script.Serialization.JavaScriptSerializer json = new System.Web.Script.Serialization.JavaScriptSerializer();

            //还要查出有多少条记录
            string sqlc = "select count(*) from Atricle";
            int count = sonBll.GetinfoCount(sqlc);

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