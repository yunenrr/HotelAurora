using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using System.Configuration;

using WebApplication2.Models;
using WebApplication2.Business;

namespace WebApplication2.Controllers
{
    public class HotelController : ApiController
    {

        static readonly HotelBusiness hotelBusiness = new HotelBusiness("Data Source=163.178.107.130;Initial Catalog=aurorahotel;Persist Security Info=True;User ID=sqlserver;Password=saucr.12");

        public Hotel getHotel()
        {
            return hotelBusiness.getHotel();
        }

    }
}
