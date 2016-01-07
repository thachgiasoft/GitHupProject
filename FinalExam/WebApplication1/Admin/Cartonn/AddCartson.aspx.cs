using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Admin.Cartonn
{
    public partial class AddCartson : BasePage
    {
        shaoqi.BLL.CatroonInfo cateBll = new shaoqi.BLL.CatroonInfo();
        shaoqi.BLL.CartSon SonBll = new shaoqi.BLL.CartSon();

        protected List<shaoqi.Model.CatroonInfo> list = new List<shaoqi.Model.CatroonInfo>();
        protected shaoqi.Model.CartSon CartSon = new shaoqi.Model.CartSon();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                list = cateBll.GetModelList(" ");
                if (!string.IsNullOrEmpty(Request.QueryString["id"]))
                {
                    CartSon = SonBll.GetModel(Convert.ToInt32(Request.QueryString["id"]));
                }
            }
            else
            {

                CartSon.CartoonSonName = Request.Form["CartName"];
                CartSon.CartNum = Convert.ToInt32(Request.Form["CartNum"]);
                CartSon.CartId = Convert.ToInt32(Request.Form["CategoriesId"]);
                CartSon.CartoonSonIamge = Request.Form["hiddenfile"];
                if (Convert.ToInt32(Request.Form["id"]) == 0)
                {
                    CartSon.AddDateTime = DateTime.Now;
                    SonBll.Add(CartSon);
                }
                else
                {
                    CartSon.Id = Convert.ToInt32(Request.Form["id"]);
                    CartSon.AddDateTime = Convert.ToDateTime(Request.Form["data"]);
                    SonBll.Update(CartSon);
                }


                Response.Redirect("/Admin/Cartonn/CartsonInfo.aspx?id="+CartSon.CartId);
            }
        }
    }
}