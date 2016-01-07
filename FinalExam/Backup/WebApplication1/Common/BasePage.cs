using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace System.Web
{
    public class BasePage:System.Web.UI.Page
    {
        protected override void OnInit(EventArgs e)
        {
            if (Session["User"] == null)
            {
                HttpContext.Current.Response.Redirect("/Admin/Login.aspx");
            }
            base.OnInit(e);
        }
    }
}