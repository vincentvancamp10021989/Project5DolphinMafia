using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Klasses.Reservations.Table
{
    public class TableReservation
    {
        public List<Reservations> List { set; get; }
        public TableReservation(List<Reservations> list)
        {
            this.List = list;
        }
      //  public Table 
    }
}