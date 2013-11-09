using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication1.Klasses.Login
{
    public class Lecturers
    {
        public int ID { set; get; }
        public string Firstname { set; get; }
        public string Lastname { set; get; }
        public string EMail { set; get; }
        public int? Access { set; get; }
        public string Password { set; get; }
    }
}