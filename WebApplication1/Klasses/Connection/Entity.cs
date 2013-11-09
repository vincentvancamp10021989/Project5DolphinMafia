using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Klasses.Connection;
using Microsoft.SqlServer;
using Microsoft.SqlServer.Management;
using System.Collections;
using System.Data.SqlClient;
using System.Data;
using WebApplication1.Klasses;


namespace WebApplication1.Klasses.Connection
{
    /// <summary>
    /// Get the values of extern Database
    /// </summary>
    public class Entity
    {
        public DataClasses1DataContext dataClassContext;
        public Entity()
        {
            this.dataClassContext = new DataClasses1DataContext();
        }

        private List<Klasses.Login.Lecturers> db_Lecturers = new List<Login.Lecturers>();
        public List<Login.Lecturers> DB_Lecturers
        {
            set
            {
                db_Lecturers = value;
            }
            get
            {
                db_Lecturers = dataClassContext.Lecturers.AsEnumerable()
                    .Select(x => new Login.Lecturers()
                               {
                                   ID = x.Id,
                                   Firstname = x.Firstname,
                                   Lastname = x.Lastname,
                                   Access = x.Access,
                                   EMail = x.Email,
                                   Password = x.Password
                               }
                         ).ToList();
                return db_Lecturers;
            }
        }

        private List<Slots.Slots> db_Slots = new List<Slots.Slots>();
        public List<Slots.Slots> DB_Slots
        {
            set
            {
                db_Slots = value;
            }
            get
            {
                db_Slots = dataClassContext.Slots.AsEnumerable()
                    .Select(x => new Slots.Slots()
                               {
                                   ID = x.Id,
                                   Date = x.Date,
                                   StartTime = x.Start,
                                   EndTime = x.End,
                                   Duration = x.Duration,
                                   Capacity = x.Capacity,
                                   Availibility = x.Available,
                                   Digital = x.Digital,
                                   Campus = x.Campus
                               }
                            ).ToList();
                return db_Slots;
            }
        }

        private List<Campus.Campus> db_Campus = new List<Campus.Campus>();
        public List<Campus.Campus> DB_Campus
        {
            set
            {
                db_Campus = value;
            }
            get
            {
                db_Campus = dataClassContext.Campus.AsEnumerable()
                    .Select(x => new Campus.Campus()
                               {
                                   ID = x.Id,
                                   Place = x.Plaats
                               }
                            ).ToList();
                return db_Campus;
            }
        }


        private List<Reservations.Reservations> db_Reservations = new List<Reservations.Reservations>();
        public List<Reservations.Reservations> DB_Reservations
        {
            set
            {
                db_Reservations = value;
            }
            get
            {
                db_Reservations = dataClassContext.Reservations.AsEnumerable()
                    .Select(x => new Reservations.Reservations()
                               {
                                   ID = x.Id,
                                   LecturerID = x.Lecturer_id,
                                   SlotID = x.Slot_id
                               }
                           ).ToList();
                return db_Reservations;
            }
        }      
    }
}