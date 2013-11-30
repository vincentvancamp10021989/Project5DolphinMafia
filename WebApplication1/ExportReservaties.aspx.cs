using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Linq;
using WebApplication1.Klasses.Connection;
using WebApplication1.Klasses.Export.Lambda;
using WebApplication1.Klasses.Reservations.Table;
using WebApplication1.Klasses.Slots;

namespace WebApplication1
{
    public partial class ExportReservaties : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /*
         *             Reservation reservation = (from Reservation r in List.dataClassContext.Reservations
                                           where r.Slot_id.Equals(this.Id)
                                           && r.Lecturer_id.Equals(Convert.ToInt32(HttpContext.Current.Session[SessionEnum.SessionNames.LecturorsID.ToString()]))
                                           select r).First();
         */
        protected void BtnExport_Click(object sender, EventArgs e)
        {
            
            LambdaExport le = new LambdaExport();
            List<Slots> query = le.SelectSlots();

            TableAP t = new TableAP(query.ToList());
            for (int i = 0; i < t.List.Count; i++)
            {
                t.Index = i;
                this.Table1.Rows.Add(t.GetTableID());
            }

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
                string path = Server.MapPath("~/");
                string filename = FileUpload1.PostedFile.FileName;
                xEle.Save(path + filename);
                Console.WriteLine("Converted to XML");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}