using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Windows.Forms;
using WebApplication1.Klasses.Connection;

namespace WebApplication1.Klasses.Slots.linq
{
    public class LambdaSlots
    {
        private const int AVAILABILITY_DOWN_UP = 1;
        private const int MINIMUM_CAPACITY = 0;
        private Entity Entity;
        public int ID { set; get; }
        public string Date { set; get; }
        public string Start_Hour { set; get; }
        public string End_Hour { set; get; }
        public string Duration { set; get; }
        public int Capacity { set; get; }
        public int Availible { set; get; }
        public string Campus { set; get; }
        public byte Digital { set; get; }

        public LambdaSlots()
        {
            this.Entity = new Entity();
        }
        public LambdaSlots(int id)
            :this()
        {
            this.ID = id;
        }
        public LambdaSlots(string datum, string start_hour, string end_hour, string duration, int capacity,int availible , byte digital, string campus)
            :this()
        {
            this.Date = datum;
            this.Start_Hour = start_hour;
            this.End_Hour = end_hour;
            this.Duration = duration;
            this.Capacity = capacity;
            this.Campus = campus;
            this.Availible = availible;
            this.Digital = digital;
        }

        public Slot SetSlotsUpdateDataCountDown()
        {
            var slots = Entity.dataClassContext.Slots
                .Where(z =>
                          z.Id.Equals(this.ID)
                       ).ToList().First();
            slots.Available = slots.Available - AVAILABILITY_DOWN_UP;
            Entity.dataClassContext.SubmitChanges();
            return slots;
        }
        public Slot SetSlotsUpdateDataCountUp()
        {
            var slots = Entity.dataClassContext.Slots
                .Where(z =>
                          z.Id.Equals(this.ID)
                       ).ToList().First();
            slots.Available = slots.Available + AVAILABILITY_DOWN_UP;
            Entity.dataClassContext.SubmitChanges();
            return slots;
        }

        public Slot SetDataInsert()
        {
            var slots = new Slot()
            {
                Date = this.Date,
                Start = this.Start_Hour,
                End = this.End_Hour,
                Available = this.Availible,
                Campus = this.Campus,
                Capacity = this.Capacity,
                Duration = this.Duration
            };
            this.Entity.dataClassContext.Slots.InsertOnSubmit(slots);
            this.Entity.dataClassContext.SubmitChanges();
            return slots;
        }
        public Boolean GetControlAvailibe()
        {
            var result = this.Entity.dataClassContext.Slots.Any(x =>
                    x.Id.Equals(this.ID)
                    && x.Available.Equals(MINIMUM_CAPACITY));
            return result;
        }
        public List<Slots> GetRecordsByLecturerId()
        {
            List<Slots> list = this.Entity.DB_Slots
                .Where(x =>
                    x.ID.Equals(this.ID)).ToList();
            return list;
        }
        public Slot SetDeleteSlotRowById()
        {
            Slot slot = (from Slot r in this.Entity.dataClassContext.Slots
                                       where r.Id.Equals(this.ID)
                                       select r).First();

            this.Entity.dataClassContext.Slots.DeleteOnSubmit(slot);
            this.Entity.dataClassContext.SubmitChanges();
            return slot;
        }
    }
}