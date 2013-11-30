using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Klasses;

namespace WebApplication1
{
    public partial class AdminUsers : System.Web.UI.Page
    {
        string LOGOUT = "Logout.aspx";
        protected void Page_Load(object sender, EventArgs e)
        {
            
            try
            {
                if (Session[SessionEnum.SessionNames.AccessLvl.ToString()].Equals(string.Empty) ||
                    !(Session[SessionEnum.SessionNames.AccessLvl.ToString()].Equals(2)))
                    Response.Redirect(LOGOUT);
            }
            catch
            {
                HttpContext.Current.Response.Redirect(LOGOUT);
            }
        }

        protected void BtnTerug_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminMain.aspx");
        }
    }
}