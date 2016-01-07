using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Admin.Menu
{
    public partial class AddMenuaspx : BasePage
    {
        shaoqi.BLL.Menu menuBll = new shaoqi.BLL.Menu();
        public List<shaoqi.Model.Menu> menuList = new List<shaoqi.Model.Menu>();
        public shaoqi.Model.Menu menuModle = new shaoqi.Model.Menu();

        protected void Page_Load(object sender, EventArgs e)
        {
            string id = string.Empty;
            if (!IsPostBack)
            {
                //绑定到前台的select
                menuList = menuBll.GetModelList(" pId='0' or pId='20150012'");
                id = Request.QueryString["id"];
                if (!string.IsNullOrEmpty(id))
                {
                    menuModle = menuBll.GetModel(id);
                }
            }
            else
            {

                menuModle.id = Context.Request.Form["id"];
                menuModle.className = Context.Request.Form["className"];
                menuModle.pId = Context.Request.Form["Pid"];
                menuModle.classOrder = Convert.ToInt32(Context.Request.Form["classOrder"]);
                menuModle.OutLinkURL = Context.Request.Form["OutLinkURL"];
                if (string.IsNullOrEmpty(menuModle.id))
                {
                    menuModle.id = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString()+DateTime.Now.Second.ToString();
                    menuBll.Add(menuModle);
                }
                else
                {
                    menuBll.Update(menuModle);
                }

                Response.Redirect("/Admin/Menu/MenuInfo.aspx");
            }
        }
    }
}