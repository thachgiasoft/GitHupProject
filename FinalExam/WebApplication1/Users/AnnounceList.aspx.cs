using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Users
{
    public partial class AnnounceList : System.Web.UI.Page
    {
        shaoqi.BLL.Announce atrBll = new shaoqi.BLL.Announce();
        List<shaoqi.Model.Announce> atrlist = new List<shaoqi.Model.Announce>();


        protected void Page_Load(object sender, EventArgs e)
        {
            atrlist = atrBll.GetModelList(" 1=1 order by AddTime");
            this.Repeater1.DataSource = atrlist;
            this.Repeater1.DataBind();
        }
    }
}