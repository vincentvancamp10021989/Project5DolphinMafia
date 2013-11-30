using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Klasses;

namespace WebApplication1
{
    public partial class Logout : System.Web.UI.Page
    {
        private const string NEXT_PAGE = "LoginView.aspx";
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpContext.Current.Session[SessionEnum.SessionNames.LecturorsID.ToString()] = string.Empty;
            Session[SessionEnum.SessionNames.AccessLvl.ToString()] = string.Empty;
            HttpContext.Current.Response.Redirect(NEXT_PAGE);
        }
    }
}