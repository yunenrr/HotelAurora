using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using WebApplication2.Data;
using WebApplication2.Models;

namespace WebApplication2.Business
{
    public class ImageGalleryBusiness
    {

        private string connectionString;
        private ImageGalleryData imageGalleryData;

        public ImageGalleryBusiness(string conn)
        {
            this.connectionString = conn;
            this.imageGalleryData = new ImageGalleryData(this.connectionString);
        }

        public List<ImageGallery> getGalleryImages()
        {
            return this.imageGalleryData.getGalleryImages();
        }

    }
}