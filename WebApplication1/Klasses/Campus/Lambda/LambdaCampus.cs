using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Klasses.Connection;

namespace WebApplication1.Klasses.Campus.Lambda
{
    public class LambdaCampus
    {
        public string CampusName { set; get; }
        public Entity Entity;

        public LambdaCampus()
        {
            this.Entity = new Entity();
        }
        public LambdaCampus(string campusName)
            :this()
        {
            this.CampusName = campusName;
        }
        public WebApplication1.Campus SetCampusInsert()
        {
            var campus = new WebApplication1.Campus()
            {
                Plaats = CampusName
            };
            this.Entity.dataClassContext.Campus.InsertOnSubmit(campus);
            this.Entity.dataClassContext.SubmitChanges();
            return campus;
        }
    }
}