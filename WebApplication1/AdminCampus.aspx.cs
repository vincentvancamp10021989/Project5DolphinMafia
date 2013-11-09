using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Klasses.Campus.Lambda;

namespace WebApplication1
{
    public partial class AdminCampus : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        private LambdaCampus lambdaCampus;
        protected void btnCampus_Click(object sender, EventArgs e)
        {
            this.lambdaCampus = new LambdaCampus(this.txtboxCampusPlaats.Text);
            this.lambdaCampus.SetCampusInsert();
            Response.Redirect("AdminCampus.aspx");
        }
    }
}