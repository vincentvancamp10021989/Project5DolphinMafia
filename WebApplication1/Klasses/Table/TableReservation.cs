using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Klasses.Reservations.linq;
using WebApplication1.Klasses.Slots;
using WebApplication1.Klasses.Connection;
using System.Web.UI.WebControls;

namespace WebApplication1.Klasses.Reservations.Table
{
    public class TableAP
    {
        public List<Slots.Slots> List { set; get; }
        public int Index { set; get; }
        public TableAP(List<Slots.Slots> list)
        {
            this.List = list;
        }
        public TableAP()
        {
        }

        public List<Slots.Slots> GetTableReservationsByLecturerID()
        {
            LambdaReservations linqReservations = new LambdaReservations();
            List<Reservations> listReservationByLecturerId = linqReservations.GetReservationsByID();
            List<Slots.Slots> listSlots = new Entity().DB_Slots;

            List<Slots.Slots> list = new List<Slots.Slots>();
            for (int i = 0; i < listReservationByLecturerId.Count; i++)
            {
                for (int j = i; j < listSlots.Count; j++)
                {
                    if (listReservationByLecturerId.ElementAt(i).SlotID.Equals(listSlots.ElementAt(j).ID))
                        list.Add(listSlots.ElementAt(j));
                }
            }
            return list;
        }


        public TableRow GetTableDate()
        {
            TableRow tRow = new TableRow();
            TableCell date = new TableCell();
            date.Text = this.List.ElementAt(this.Index).Date.ToString();
            tRow.Cells.Add(date);
            return tRow;
        }
        public TableRow GetTableDateBegin()
        {
            TableRow tRow = new TableRow();
            TableCell dateCell = new TableCell();
            dateCell.Text = this.List.ElementAt(this.Index).StartTime.ToString();
            tRow.Cells.Add(dateCell);
            return tRow;
        }
        public TableRow GetTableDateEnd()
        {
            TableRow tRow = new TableRow();
            TableCell dateEind = new TableCell();
            dateEind.Text = this.List.ElementAt(this.Index).EndTime.ToString();
            tRow.Cells.Add(dateEind);
            return tRow;
        }
        public TableRow GetTableDuration()
        {
            TableRow tRow = new TableRow();
            TableCell dateDuur = new TableCell();
            dateDuur.Text = this.List.ElementAt(this.Index).Duration.ToString();
            tRow.Cells.Add(dateDuur);
            return tRow;
        }
        public TableRow GetTableAvailibility()
        {
            TableRow tRow = new TableRow();
            TableCell dateAvailibility = new TableCell();
            dateAvailibility.Text = this.List.ElementAt(this.Index).Availibility.ToString();
            tRow.Cells.Add(dateAvailibility);
            return tRow;
        }
        public TableRow GetTableCapacity()
        {
            TableRow tRow = new TableRow();
            TableCell dateCapacity = new TableCell();
            dateCapacity.Text = this.List.ElementAt(this.Index).Capacity.ToString();
            tRow.Cells.Add(dateCapacity);
            return tRow;
        }

        public TableRow GetTableDigital()
        {
            TableRow tRow = new TableRow();
            TableCell dateDigital = new TableCell();
            dateDigital.Text = this.List.ElementAt(this.Index).Digital.ToString();
            tRow.Cells.Add(dateDigital);
            return tRow;
        }

        public TableRow GetTableLocation()
        {
            TableRow tRow = new TableRow();
            TableCell dateLocation = new TableCell();
            dateLocation.Text = this.List.ElementAt(this.Index).Campus.ToString();
            tRow.Cells.Add(dateLocation);
            return tRow;
        }



    }
}