using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Admin.Cartonn
{
    public partial class AddCartInfo : BasePage
    {
        shaoqi.BLL.Categries cateBll = new shaoqi.BLL.Categries();
        shaoqi.BLL.CatroonInfo catrBll = new shaoqi.BLL.CatroonInfo();
        protected List<shaoqi.Model.Categries> list = new List<shaoqi.Model.Categries>();
        protected shaoqi.Model.CatroonInfo catrinfo = new shaoqi.Model.CatroonInfo();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                list = cateBll.GetModelList(" ");
                if (!string.IsNullOrEmpty(Request.QueryString["id"]))
                {
                    catrinfo = catrBll.GetModel(Convert.ToInt32(Request.QueryString["id"]));
                }
            }
            else
            {

                catrinfo.CartoonName = Request.Form["CartName"];
                catrinfo.CartoonIntroduce = Request.Form["CartoonIntroduce"];
                catrinfo.CategoriesId = Convert.ToInt32(Request.Form["CategoriesId"]);
                catrinfo.CartoonImage = Request.Form["hiddenfile"];
                if (Convert.ToInt32(Request.Form["id"]) == 0)
                {
                    catrinfo.AddDateTime = DateTime.Now;
                    catrBll.Add(catrinfo);
                }
                else
                {
                    catrinfo.Id = Convert.ToInt32(Request.Form["id"]);
                    catrinfo.AddDateTime = Convert.ToDateTime(Request.Form["data"]);
                    catrBll.Update(catrinfo);
                }


                Response.Redirect("/Admin/Cartonn/CartoonInfo.aspx");
            }
        }
    }
}