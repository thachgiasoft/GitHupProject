using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Admin.admin
{
    public partial class AddAdmin1 : BasePage
    {
        shaoqi.BLL.Admin Adminbll = new shaoqi.BLL.Admin();
        shaoqi.Model.Admin model = new shaoqi.Model.Admin();

        protected string id = string.Empty;

        protected string Name = string.Empty;
        protected string Turename = string.Empty;

        protected string password = string.Empty;
        protected string phone = string.Empty;
        protected string email = string.Empty;
        protected string msg = string.Empty;
        protected string btnName = "确定";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                model.LoginName = Request.Form["User"];
                model.Password = Request.Form["password"];
                model.Name = Request.Form["contact"];
                model.Phone = Request.Form["tel"];

                bool success = false;
                if (string.IsNullOrEmpty(Request.Form["Id"]))
                {
                    if (Adminbll.Add(model) != 0)
                    {
                        success = true;
                    }
                }
                else
                {
                    model.Id = Convert.ToInt32(Request.Form["Id"]);
                    success = Adminbll.Update(model);
                }
                if (success)
                {
                    Response.Redirect("/Admin/GetAdminInfo.aspx");
                }
                else
                {
                    msg = "添加失败";
                }

            }
            else
            {
                string action = Request.QueryString["action"];
                if (action == "update")
                {
                    int id1 = Convert.ToInt32(Request.QueryString["id"]);
                    model = Adminbll.GetModel(id1);
                    id = model.Id.ToString();
                    Name = model.LoginName;
                    password = model.Password;
                    phone = model.Phone;
                    Turename = model.Name;
                    btnName = "更新";
                }

            }
        }
    }
}
