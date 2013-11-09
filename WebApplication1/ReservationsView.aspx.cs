using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using WebApplication1.Klasses;
using WebApplication1.Klasses.Algemeen;
using WebApplication1.Klasses.Reservations.linq;

namespace WebApplication1
{
    public partial class ReservationsView : System.Web.UI.Page
    {   
        private LambdaReservations linqReservations;
        private const string NEXT_PAGE = "LoginView.aspx";
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (HttpContext.Current.Session[SessionEnum.SessionNames.LecturorsID.ToString()].Equals(string.Empty))
                    HttpContext.Current.Response.Redirect(NEXT_PAGE);
            }
            catch
            {
                HttpContext.Current.Response.Redirect(NEXT_PAGE);
            }

            this.linqReservations = new LambdaReservations();
            this.linqReservations.GetReservationsByID();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        protected void GridView1_Load(object sender, EventArgs e)
        {

            //GridView1.DataSource = this.linqReservations.GetReservationsByID(); // executed query
            //SqlDataSource1
          //  GridView1.DataBind();
        }
    }
}