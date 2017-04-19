using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{

    public class Promotion
    {
        private int idPromotion;
        private string promotionName;
        private string descriptionPromotion;
        private string imagePromotion;


        public Promotion()
        {
            this.IdPromotion = 0;
            this.PromotionName = "";
            this.DescriptionPromotion = "";
            this.ImagePromotion = "";
        }

        public Promotion(int idPromotion, string promotionName, string descriptionPromotion, string imagePromotion)
        {
            this.IdPromotion = idPromotion;
            this.PromotionName = promotionName;
            this.DescriptionPromotion = descriptionPromotion;
            this.ImagePromotion = imagePromotion;
        }

        public int IdPromotion
        {
            get
            {
                return idPromotion;
            }

            set
            {
                idPromotion = value;
            }
        }

        public string PromotionName
        {
            get
            {
                return promotionName;
            }

            set
            {
                promotionName = value;
            }
        }

        public string DescriptionPromotion
        {
            get
            {
                return descriptionPromotion;
            }

            set
            {
                descriptionPromotion = value;
            }
        }

        public string ImagePromotion
        {
            get
            {
                return imagePromotion;
            }

            set
            {
                imagePromotion = value;
            }
        }

    }
}