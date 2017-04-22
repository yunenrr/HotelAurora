using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using System.Web;
using System.Web.Configuration;
using System.Configuration;

using WebApplication2.Models;
using WebApplication2.Business;

namespace WebApplication2.Controllers
{
    public class ReservationController : ApiController
    {

        static readonly ReservationBusiness reservationBusiness = new ReservationBusiness(WebConfigurationManager.ConnectionStrings["AzureConnString"].ToString());

        public List<int> verifyReservation(int typeroom, string indate, string outDate)
        {
            return reservationBusiness.verifyReservation(typeroom, indate, outDate);
        }

        public int insertReservation(string reservationNumber, int client, int creditCard, int room, string intDate, string outDate)
        {
            return reservationBusiness.insertReservation(reservationNumber, client, creditCard, room, intDate, outDate);
        }


    }
}