using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Admin.Cartonn
{
    public partial class CartoonInfo : BasePage
    {
        shaoqi.BLL.CatroonInfo catrBll = new shaoqi.BLL.CatroonInfo();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string id = Request.QueryString["id"];//这是漫画的Id 查处

            }
        }
    }
}