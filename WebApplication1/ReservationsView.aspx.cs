using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using WebApplication1.Klasses;
using WebApplication1.Klasses.Algemeen;
using WebApplication1.Klasses.Connection;
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

            TableReservation tableReservation = new TableReservation();
            List<Slots> list = tableReservation.GetTableReservationsByLecturerID();
            int rowCnt = list.Count;  

            for (int rowCtr = 0; rowCtr < rowCnt; rowCtr++)
            {
                TableRow tRow = new TableRow();

                TableCell dateCell = new TableCell();
                TableCell startDateCell = new TableCell();
                TableCell endDateCell = new TableCell();
                TableCell duurCell = new TableCell();
                TableCell digitalCell = new TableCell();
                TableCell locationCell = new TableCell();

                dateCell.Text = list.ElementAt(rowCtr).Date.ToString();
                startDateCell.Text = list.ElementAt(rowCtr).StartTime.ToString();
                endDateCell.Text = list.ElementAt(rowCtr).EndTime.ToString();
                duurCell.Text = list.ElementAt(rowCtr).Duration.ToString();
                digitalCell.Text = list.ElementAt(rowCtr).Digital.ToString();
                locationCell.Text = list.ElementAt(rowCtr).Campus.ToString();

                tRow.Cells.Add(dateCell);
                tRow.Cells.Add(startDateCell);
                tRow.Cells.Add(endDateCell);
                tRow.Cells.Add(duurCell);
                tRow.Cells.Add(digitalCell);
                tRow.Cells.Add(locationCell);

                Table1.Rows.Add(tRow);
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
    }
}