using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Admin.Link
{
    public partial class AddLink : BasePage
    {
        shaoqi.BLL.Link linkBll = new shaoqi.BLL.Link();
        public shaoqi.Model.Link linkModel = new shaoqi.Model.Link();
        public int s = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string id = Request.QueryString["id"];
                if (!string.IsNullOrEmpty(id))
                {
                    linkModel = linkBll.GetModel(Convert.ToInt32(id));
                    s = linkModel.id;
                }

            }
            else
            {
                linkModel.id =Convert.ToInt32(Request.Form["id"]);
                linkModel.linkTile = Request.Form["linkTile"];
                linkModel.uRl = Request.Form["uRl"];
                if (linkModel.id==0)
                {
                    linkBll.Add(linkModel);
                }
                else
                {
                    linkBll.Update(linkModel);
                }


                Response.Redirect("/Admin/Link/LinkInfo.aspx");
            }
        }
    }
}