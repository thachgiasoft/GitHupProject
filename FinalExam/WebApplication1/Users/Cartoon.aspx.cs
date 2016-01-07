using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Users
{
    public partial class Cartoon : System.Web.UI.Page
    {
        List<shaoqi.Model.CatroonInfo> catrList = new List<shaoqi.Model.CatroonInfo>();
        shaoqi.BLL.CatroonInfo catrBll = new shaoqi.BLL.CatroonInfo();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                catrList = catrBll.GetModelList(" ");
                this.Repeater1.DataSource = catrList;
                this.Repeater1.DataBind();
            }

        }
    }
}