using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Reservation
    {

        private int idtbreservation;
        private string reservationNumer;
        private int client, creditCard, room;
        private string intdate, outdate;

        public Reservation() {
            this.Idtbreservation = 0;
            this.ReservationNumer = "";
            this.Client = 0;
            this.CreditCard = 0;
            this.Room = 0;
            this.Intdate = "";
            this.Outdate = "";
        }

        public Reservation(int idtbreservation, string reservationNumer, int client, int creditCard, int room, string intdate, string outdate)
        {
            this.Idtbreservation = idtbreservation;
            this.ReservationNumer = reservationNumer;
            this.Client = client;
            this.CreditCard = creditCard;
            this.Room = room;
            this.Intdate = intdate;
            this.Outdate = outdate;
        }

        public int Idtbreservation
        {
            get
            {
                return idtbreservation;
            }

            set
            {
                idtbreservation = value;
            }
        }

        public string ReservationNumer
        {
            get
            {
                return reservationNumer;
            }

            set
            {
                reservationNumer = value;
            }
        }

        public int Client
        {
            get
            {
                return client;
            }

            set
            {
                client = value;
            }
        }

        public int CreditCard
        {
            get
            {
                return creditCard;
            }

            set
            {
                creditCard = value;
            }
        }

        public int Room
        {
            get
            {
                return room;
            }

            set
            {
                room = value;
            }
        }

        public string Intdate
        {
            get
            {
                return intdate;
            }

            set
            {
                intdate = value;
            }
        }

        public string Outdate
        {
            get
            {
                return outdate;
            }

            set
            {
                outdate = value;
            }
        }

        



    }
}