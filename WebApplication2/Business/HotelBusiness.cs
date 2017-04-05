using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using WebApplication2.Data;
using WebApplication2.Models;

namespace WebApplication2.Business
{
    public class HotelBusiness
    {

        private string connectionString;
        private HotelData hotelData;

        public HotelBusiness(string conn)
        {
            this.connectionString = conn;
            this.hotelData = new HotelData(this.connectionString);
        }

        public Hotel getHotel()
        {
            return hotelData.getHotel();
        }

    }
}