using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Helpers;
using System.Windows.Forms;
using WebApplication1.Klasses;
using WebApplication1.Klasses.Algemeen;
using WebApplication1.Klasses.Connection;
using WebApplication1.Klasses.Export;
using WebApplication1.Klasses.Export.Lambda;
using WebApplication1.Klasses.Reservations;
using WebApplication1.Klasses.Reservations.linq;
using WebApplication1.Klasses.Reservations.Table;
using WebApplication1.Klasses.Slots;
using WebApplication1.Klasses.Slots.linq;

namespace WebApplication1
{
    public partial class ReservationsView : System.Web.UI.Page
    {
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


            List<Slots> list = new TableAP().GetTableReservationsByLecturerID();
            TableAP tableReservation = new TableAP(list);
            int rowCnt = list.Count;

            for (int i = 0; i < tableReservation.List.Count; i++)
            {
                tableReservation.Index = i;
                this.tableDatum.Rows.Add(tableReservation.GetTableDate());
                this.tableBegin.Rows.Add(tableReservation.GetTableDateBegin());
                this.tableEind.Rows.Add(tableReservation.GetTableDateEnd());
                this.tableDigitaal.Rows.Add(tableReservation.GetTableDigital());
                this.tableDuur.Rows.Add(tableReservation.GetTableDuration());
                this.tableLocatie.Rows.Add(tableReservation.GetTableLocation());

            }


            ButtonGenerator b = new ButtonGenerator(rowCnt);
            for (int i = 0; i < rowCnt; i++)
            {
                Panel1.Controls.Add(b.WriteReservationButton(i, list.ElementAt(i).ID.ToString())); //slot id
                b.ClickReservationsDelete(i);
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }


        protected void GridView1_Load(object sender, EventArgs e)
        {
        }

        protected void btnTerug_Click(object sender, EventArgs e)
        {
            Response.Redirect("SlotsView.aspx");
        }

        protected void BtnExport_Click(object sender, EventArgs e)
        {
            string location = @"c:\Temp\Products.json";
            LambdaExport le = new LambdaExport();
            List<String> query = le.SelectSlots();
            using (StringWriter writer = new StringWriter())
            {
                System.Web.Helpers.Json.Write(query, writer);

                using (StreamWriter outfile =
                           new StreamWriter(location))
                {
                    outfile.Write(writer.ToString());
                }
            }
            lblReservatieTekst.Visible = true;
            lblLocatie.Text = location;
            lblLocatie.Visible = true;
        }
    }
}