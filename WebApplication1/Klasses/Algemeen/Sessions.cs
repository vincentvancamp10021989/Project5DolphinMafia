using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Klasses.Algemeen
{
    public class Sessions
    {
        public static int LecturersID { set; get; }
        public static int SlotsID { set; get; }
        public string Value { set; get; }

        public Sessions(string value)
        {
            this.Value = value;
        }
        public static string SessionEncrypter()
        {
            return null;
        }
        public static string SessionDecrypter()
        {
            return null;
        }
    }
}