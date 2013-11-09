using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Klasses.Slots
{
    public class Slots
    {
        public int ID { set; get; }
        public string Date { set; get; }
        public string StartTime { set; get; }
        public string EndTime { set; get; }
        public string Duration { set; get; }
        public int Capacity { set; get; }
        public byte? Digital { set; get; }
        public string Campus { set; get; }
        public int Availibility { set; get; }
    }
}