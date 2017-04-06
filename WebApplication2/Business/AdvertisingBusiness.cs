using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using WebApplication2.Data;
using WebApplication2.Models;

namespace WebApplication2.Business
{
    public class AdvertisingBusiness
    {

        private string connectionString;
        private AdvertisingData advertisingData;


        public AdvertisingBusiness(string conn)
        {
            this.connectionString = conn;
            this.advertisingData = new AdvertisingData(this.connectionString);
        }

        public List<Advertising>  getAdvertising()
        {
            return advertisingData.getAdvertising();
        }



    }
}