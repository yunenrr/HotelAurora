using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using WebApplication2.Data;
using WebApplication2.Models;

namespace WebApplication2.Business
{
    public class ReservationBusiness
    {

        private string connectionString;
        private ReservationData reservationData;


        public ReservationBusiness(string conn)
        {
            this.connectionString = conn;
            this.reservationData = new ReservationData(this.connectionString);
        }

        public List<int> verifyReservation(int typeroom, string inDate, string outDate) {
            return reservationData.verifyReservation(typeroom, inDate, outDate);
        }

        public int insertReservation(string reservationNumber, int client, int creditCard, int room, string intDate, string outDate)
        {
            return reservationData.insertReservation(reservationNumber, client, creditCard, room, intDate, outDate);
        }

    }
}