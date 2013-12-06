using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Klasses.Campus.Lambda;
using WebApplication1.Klasses;

namespace WebApplication1
{
    public partial class AdminCampus : System.Web.UI.Page
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

        private LambdaCampus lambdaCampus;
        protected void btnCampus_Click(object sender, EventArgs e)
        {
            this.lambdaCampus = new LambdaCampus(this.txtboxCampusPlaats.Text);
            this.lambdaCampus.SetCampusInsert();
            Response.Redirect("AdminCampus.aspx");
        }
        //yolo
    }
}