﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;
using System.Web;
using System.Windows.Forms;
using WebApplication1.Klasses.Slots.linq;
using WebApplication1.Klasses.Reservations.linq;
using WebApplication1.Klasses.Connection;
using WebApplication1.Klasses.Campus.Lambda;

namespace WebApplication1.Klasses.Algemeen
{
    public class ButtonGenerator
    {
        public System.Web.UI.WebControls.Button[] Bord { set; get; }
        public const int GROTEBUTTON_X = 50;
        public const int GROTEBUTTON_Y = 24;
        private const string SLOT_PAGE = "SlotsView.aspx";
        private const string RESERVATION_PAGE = "ReservationsView.aspx";
        private LambdaSlots lambdaSlots;
        private LambdaReservations lambdaReservations;
        private Entity entity;
        private LambdaCampus lambdaCampus;

        public int Aantal { set; get; }


        public ButtonGenerator(int aantal)
        {
            this.Aantal = aantal;
            this.Bord = new System.Web.UI.WebControls.Button[this.Aantal];
        }
        public System.Web.UI.WebControls.Button WriteButton(int x, string stringID)
        {
            this.entity = new Entity();

            this.lambdaCampus = new LambdaCampus(HttpContext.Current.Session[SessionEnum.SessionNames.CampusName.ToString()].ToString());

            this.lambdaSlots = new LambdaSlots(this.lambdaCampus.GetFilterToCampus().ElementAt(x).ID);
            this.lambdaReservations = new LambdaReservations(this.lambdaSlots.ID);

            this.Bord[x] = new System.Web.UI.WebControls.Button();
            this.Bord[x].Width = GROTEBUTTON_X;
            this.Bord[x].Height = GROTEBUTTON_Y;
            this.Bord[x].CommandName = stringID;

            if (!lambdaSlots.GetControlAvailibe() && !this.lambdaReservations.GetCheckReservationBySlotID())
                this.Bord[x].Text = "V";
            else
            {
                this.Bord[x].Text = "X";
                this.Bord[x].Enabled = false;
            }
            return this.Bord[x];
        }

        public System.Web.UI.WebControls.Button WriteReservationButton(int x, string stringID)
        {
            this.entity = new Entity();
            this.lambdaReservations = new LambdaReservations(entity.DB_Reservations.ElementAt(x).ID);

            this.Bord[x] = new System.Web.UI.WebControls.Button();
            this.Bord[x].Width = GROTEBUTTON_X;
            this.Bord[x].Height = GROTEBUTTON_Y;
            this.Bord[x].CommandName = stringID;
            this.Bord[x].Text = stringID;
            return this.Bord[x];
        }

        public void ClickSlots(int x)
        {
            this.Bord[x].Click += delegate(object s, EventArgs ex)
            {
                try
                {
                    HttpContext.Current.Session.Add(SessionEnum.SessionNames.SlotsID.ToString(), Convert.ToInt32(this.Bord[x].CommandName));
                    lambdaSlots = new LambdaSlots(Convert.ToInt32(this.Bord[x].CommandName));
                    lambdaSlots.SetSlotsUpdateDataCountDown();
                    lambdaReservations = new LambdaReservations();
                    lambdaReservations.SetReservationInsertData();
                    HttpContext.Current.Response.Redirect(SLOT_PAGE);
                }
                catch (Exception e)
                { }
            };
        }

        // For Deleting Slots In Reservation Page.
        public void ClickReservationsDelete(int x)
        {
            this.Bord[x].Click += delegate(object s, EventArgs e)
            {
                this.lambdaReservations = new LambdaReservations(Convert.ToInt32(this.Bord[x].CommandName));
                this.lambdaSlots = new LambdaSlots(this.lambdaReservations.Id);
                HttpContext.Current.Session.Add(SessionEnum.SessionNames.SlotsID.ToString(), Convert.ToInt32(this.Bord[x].CommandName));

                while (lambdaReservations.GetCheckReservationId())
                {
                    lambdaReservations.SetDeleteReservationRowById();
                    this.lambdaSlots.SetSlotsUpdateDataCountUp();
                }
                HttpContext.Current.Response.Redirect(RESERVATION_PAGE);
            };
        }
    }
}