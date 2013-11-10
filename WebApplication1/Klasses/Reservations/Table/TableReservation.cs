using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Klasses.Reservations.linq;
using WebApplication1.Klasses.Slots;
using WebApplication1.Klasses.Connection;

namespace WebApplication1.Klasses.Reservations.Table
{
    public class TableReservation
    {
        public List<Reservations> List { set; get; }
        public TableReservation(List<Reservations> list)
        {
            this.List = list;
        }
        public TableReservation()
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
    }
}