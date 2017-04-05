using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using WebApplication2.Models;
using WebApplication2.Business;

namespace WebApplication2.Controllers
{
    public class ImageGalleryController : ApiController
    {

        static readonly ImageGalleryBusiness imageGalleryBusiness = new ImageGalleryBusiness("Data Source=163.178.107.130;Initial Catalog=aurorahotel;Persist Security Info=True;User ID=sqlserver;Password=saucr.12");

        public List<ImageGallery> getGalleryImages()
        {
            return imageGalleryBusiness.getGalleryImages();
        }

    }
}
