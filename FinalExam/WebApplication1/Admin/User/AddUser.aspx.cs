using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Admin.User
{
    public partial class AddUser : System.Web.UI.Page
    {

        shaoqi.BLL.User userbll = new shaoqi.BLL.User();
        shaoqi.Model.User model = new shaoqi.Model.User();

        protected string id = string.Empty;
        protected string Name = string.Empty;
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
                model.Phone = Request.Form["contact"];
                model.Email = Request.Form["company"];
                bool success = false;
                if (string.IsNullOrEmpty(Request.Form["Id"]))
                {
                    success = userbll.Add(model);
                }
                else
                {
                    model.Id =Convert.ToInt32(Request.Form["Id"]);
                    success = userbll.Update(model);
                }
                if (success)
                {
                    Response.Redirect("/Admin/User/GetUserInfo.aspx");
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
                    model = userbll.GetModel(id1);
                    id = model.Id.ToString();
                    Name = model.LoginName;
                    password = model.Password;
                    phone = model.Phone;
                    email = model.Email;
                    btnName = "更新";
                }

            }
        }
    }
}