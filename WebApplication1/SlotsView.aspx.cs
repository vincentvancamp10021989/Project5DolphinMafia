using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using WebApplication1.Klasses;
using WebApplication1.Klasses.Algemeen;
using WebApplication1.Klasses.Connection;
using WebApplication1.Klasses.Slots.linq;
using WebApplication1.Klasses.Reservations.Table;
using WebApplication1.Klasses.Campus.Lambda;

namespace WebApplication1
{
    public partial class SlotsView : System.Web.UI.Page
    {
        private ButtonGenerator buttons;
        private LambdaCampus lambdaCampus;
        private Entity entity;
        private const string NEXT_PAGE = "LoginView.aspx";
        private const string REFRESH_PAGE = "SlotsView.aspx";
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

            this.entity = new Entity();
            int aantal_buttons = this.entity.DB_Slots.Count;
            this.buttons = new ButtonGenerator(aantal_buttons);

            //MessageBox.Show(HttpContext.Current.Session[SessionEnum.SessionNames.CampusName.ToString()].ToString());

            this.lambdaCampus = new LambdaCampus(HttpContext.Current.Session[SessionEnum.SessionNames.CampusName.ToString()].ToString());
            TableAP table = new TableAP(this.lambdaCampus.GetFilterToCampus());

            for (int i = 0; i < table.List.Count; i++)
            {
                table.Index = i;
                this.tableDatum.Rows.Add(table.GetTableDate());
                this.tableBegin.Rows.Add(table.GetTableDateBegin());
                this.tableEind.Rows.Add(table.GetTableDateEnd());
                this.tableDigitaal.Rows.Add(table.GetTableDigital());
                this.tableDuur.Rows.Add(table.GetTableDuration());
                this.tableLocatie.Rows.Add(table.GetTableLocation());
                this.tableBeschikbaar.Rows.Add(table.GetTableAvailibility());
                this.tableCapaciteit.Rows.Add(table.GetTableAvailibility());

                Panel1.Controls.Add(buttons.WriteButton(i, table.List.ElementAt(i).ID.ToString()));
                this.buttons.ClickSlots(i);
            }
        }

        protected void buttonKies_Click(object sender, EventArgs e)
        {
            HttpContext.Current.Session.Add(SessionEnum.SessionNames.CampusName.ToString(), this.dropDownListCampus.Text.ToString());
            //MessageBox.Show(HttpContext.Current.Session[SessionEnum.SessionNames.CampusName.ToString()].ToString());
            HttpContext.Current.Response.Redirect(REFRESH_PAGE);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpContext.Current.Response.Redirect("Logout.aspx");
        }
    }
}