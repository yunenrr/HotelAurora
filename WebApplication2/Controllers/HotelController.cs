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
    public class HotelController : ApiController
    {

        static readonly HotelBusiness hotelBusiness = new HotelBusiness(WebConfigurationManager.ConnectionStrings["AzureConnString"].ToString());

        public Hotel getHotel()
        {
            return hotelBusiness.getHotel();
        }

    }
}
