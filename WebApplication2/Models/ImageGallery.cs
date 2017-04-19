using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class ImageGallery
    {

        private int idImageGallery;
        private string imageGalleryPath; 

        public ImageGallery ()
        {
            this.idImageGallery = -1;
            this.imageGalleryPath = "";
        }

        public ImageGallery (int idImageGallery, string imageGalleryPath)
        {
            this.idImageGallery = idImageGallery;
            this.imageGalleryPath = imageGalleryPath;
        }

        public int IdImageGallery
        {
            get
            {
                return idImageGallery;
            }

            set
            {
                idImageGallery = value;
            }
        }

        public string ImageGalleryPath
        {
            get
            {
                return imageGalleryPath;
            }

            set
            {
                imageGalleryPath = value;
            }
        }

    }
}