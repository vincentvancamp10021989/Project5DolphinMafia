using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Linq;
using WebApplication1.Klasses.Connection;
using WebApplication1.Klasses.Export;
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
            Export exp = new Export();
            var xEle = exp.MakeXml(query);

            string path = MapPath(@"~\myxml.xml");
            string name = Path.GetFileName(path);
            Response.ClearContent();
            Response.AppendHeader("content-disposition", "attachment; filename=" + name);
            Response.ContentType = "text/xml";
            Response.Write(xEle.ToString());
            Response.End();

        }
    }
}