using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml.Linq;
using WebApplication1.Klasses.Slots;

namespace WebApplication1.Klasses.Export
{
    public class Export
    {
        public XElement MakeXml(List<Slots.Slots> query)
        {
            try
            {
                var xEle = new XElement("Reservations",
                            from s in query
                            select new XElement("reservation",
                                         new XElement("Datum", s.Date),
                                           new XElement("Begin_uur", s.StartTime),
                                           new XElement("Duur", s.Duration),
                                           new XElement("Capaciteit", s.Capacity),
                                           new XElement("Locatie", s.Campus),
                                           new XElement("Digitaal", s.Digital)
                                       ));
                return xEle;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new XElement("fail");
            }
        }
    }
}