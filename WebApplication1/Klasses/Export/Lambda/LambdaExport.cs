using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Klasses.Connection;

namespace WebApplication1.Klasses.Export.Lambda
{
    public class LambdaExport
    {
        public List<String> SelectSlots()
        {
            var query = from s in new Entity().DB_Slots
                        join r in new Entity().DB_Reservations
                        on s.ID equals r.SlotID
                        where (r.LecturerID.Equals(Convert.ToInt32(HttpContext.Current.Session[SessionEnum.SessionNames.LecturorsID.ToString()])))
                        select (s.Date + ", " + s.StartTime + ", " + s.Duration + ", "+ s.Capacity + ", " + s.Campus + ", " + s.Digital);

            return query.ToList();
        }
    }
}