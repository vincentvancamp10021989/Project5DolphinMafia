using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Windows.Forms;
using WebApplication1.Klasses.Connection;

namespace WebApplication1.Klasses.Reservations.linq
{
    public class LambdaReservations
    {
        public int Id { set; get; }
        public int SlotId { set; get; }
        public Entity List;
        public int SlotID_Session { set; get; }
        public int LecturerID_Session { set; get; }

        public LambdaReservations()
        {
            this.List = new Entity();
            this.SlotID_Session = Convert.ToInt32(HttpContext.Current.Session[SessionEnum.SessionNames.SlotsID.ToString()]);
            this.LecturerID_Session = Convert.ToInt32(HttpContext.Current.Session[SessionEnum.SessionNames.LecturorsID.ToString()]);
        }
        public LambdaReservations(int id)
            :this()
        {
            this.Id = id;
        }
        public LambdaReservations(int id, int slotID)
            : this(id)
        {
            this.SlotId = slotID;
        }

        public List<Reservations> GetReservationsByID()
        {
            List<Reservations> reservations = List.DB_Reservations
                .Where(x =>
                        x.LecturerID.Equals(Convert.ToInt32(HttpContext.Current.Session[SessionEnum.SessionNames.LecturorsID.ToString()]))
                    ).ToList();
            return reservations;
        }
        public Reservation SetReservationInsertData()
        {
            Reservation reservation = new Reservation()
            {
                Lecturer_id = Convert.ToInt32(HttpContext.Current.Session[SessionEnum.SessionNames.LecturorsID.ToString()]),
                Slot_id = Convert.ToInt32(HttpContext.Current.Session[SessionEnum.SessionNames.SlotsID.ToString()])
            };
            List.dataClassContext.Reservations.InsertOnSubmit(reservation);
            List.dataClassContext.SubmitChanges();
            return reservation;
        }

        public Boolean GetCheckReservationId()
        {
            Boolean result = this.List.DB_Reservations
                .Any(x =>
                    x.LecturerID.Equals(Convert.ToInt32(HttpContext.Current.Session[SessionEnum.SessionNames.LecturorsID.ToString()]))
                    && x.SlotID.Equals(Convert.ToInt32(HttpContext.Current.Session[SessionEnum.SessionNames.SlotsID.ToString()])));
            return result;
        }
        public Boolean GetCheckDatabaseRowID()
        {
            bool result = this.List.DB_Reservations
                .Any(x =>
                    x.ID.Equals(this.Id));
            return result;
        }
        public Reservation SetDeleteReservationRowById()
        {
            Reservation reservation = (from Reservation r in List.dataClassContext.Reservations
                                           where r.Slot_id.Equals(this.Id)
                                           && r.Lecturer_id.Equals(Convert.ToInt32(HttpContext.Current.Session[SessionEnum.SessionNames.LecturorsID.ToString()]))
                                           select r).First();

            this.List.dataClassContext.Reservations.DeleteOnSubmit(reservation);
            this.List.dataClassContext.SubmitChanges();
            return reservation;
        }
    }
}