using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Advertising
    {

        private int idAdvertising;
        private string imageAdvertisingPath;
        private string urlAdvertising;

        public Advertising()
        {
            this.IdAdvertising = 0;
            this.ImageAdvertisingPath = "";
            this.UrlAdvertising = "";
        }


        public Advertising(int idAdvertising, string imageAdvertisingPath, string urlAdvertising)
        {
            this.IdAdvertising = idAdvertising;
            this.ImageAdvertisingPath = imageAdvertisingPath;
            this.UrlAdvertising = urlAdvertising;
        }

        public int IdAdvertising
        {
            get
            {
                return idAdvertising;
            }

            set
            {
                idAdvertising = value;
            }
        }

        public string ImageAdvertisingPath
        {
            get
            {
                return imageAdvertisingPath;
            }

            set
            {
                imageAdvertisingPath = value;
            }
        }

        public string UrlAdvertising
        {
            get
            {
                return urlAdvertising;
            }

            set
            {
                urlAdvertising = value;
            }
        }
    }
}