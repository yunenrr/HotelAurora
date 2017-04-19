using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using WebApplication2.Data;
using WebApplication2.Models;

namespace WebApplication2.Business
{
    public class PromotionBusiness
    {
        private string connectionString;
        private PromotionData promotionData;


        public PromotionBusiness(string conn)
        {
            this.connectionString = conn;
            this.promotionData = new PromotionData(this.connectionString);
        }

        public List<Promotion> getPromotion()
        {
            return promotionData.getPromotion();
        }


    }
}