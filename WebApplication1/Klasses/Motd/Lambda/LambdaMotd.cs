using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Web;
using System.Windows.Forms;
using WebApplication1.Klasses.Algemeen;
using WebApplication1.Klasses.Connection;

namespace WebApplication1.Klasses.Motd
{
    public class LambdaMotd
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public Entity List { get; set; }


        public LambdaMotd()
        {
            this.List = new Entity();
        }

        public string GetMotd()
        {
            var Motd = List.DB_Motd
                .Select((x) => x.Message

                    ).ToList().Last().ToString();
            return Motd;
        }

        public void SetMotd(string newMessage)
        {
            var Motd = List.dataClassContext.Motds
                .Where(z =>
                          z.Id.Equals(this.Id)
                       ).ToList().First();
            Motd.Message = newMessage; 
            List.dataClassContext.SubmitChanges();
        }
    }
}