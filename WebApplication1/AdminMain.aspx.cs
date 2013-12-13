using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Klasses.Slots.linq;
using System.Windows.Forms;
using WebApplication1.Klasses;
using WebApplication1.Klasses.Motd;

namespace WebApplication1
{
    public partial class AdminMain : System.Web.UI.Page
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

        protected void btnAddSlot_Click(object sender, EventArgs e)
        {
            HttpContext.Current.Response.Redirect("AdminSlots.aspx");
        }

        protected void btnAddCampus_Click(object sender, EventArgs e)
        {
            HttpContext.Current.Response.Redirect("AdminCampus.aspx");
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            LambdaSlots lambdaSlots = new LambdaSlots(int.Parse(txtboxID.Text));
            MessageBox.Show(lambdaSlots.ID.ToString());
            lambdaSlots.SetDeleteSlotRowById();
            HttpContext.Current.Response.Redirect("AdminMain.aspx");
        }

        protected void BtnLogOut_Click(object sender, EventArgs e)
        {
            Response.Redirect("Logout.aspx");
        }

        protected void btnMOTDSend_Click(object sender, EventArgs e)
        {
            LambdaMotd lambdamotd = new LambdaMotd();
            lambdamotd.Id = 1;
            lambdamotd.SetMotd(this.txtboxMOTD.Text);
        }
    }
}