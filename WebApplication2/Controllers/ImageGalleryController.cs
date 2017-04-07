using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using System.Web;
using System.Web.Configuration;

using WebApplication2.Models;
using WebApplication2.Business;

namespace WebApplication2.Controllers
{
    public class ImageGalleryController : ApiController
    {

        static readonly ImageGalleryBusiness imageGalleryBusiness = new ImageGalleryBusiness(WebConfigurationManager.ConnectionStrings["AzureConnString"].ToString());

        public List<ImageGallery> getGalleryImages()
        {
            return imageGalleryBusiness.getGalleryImages();
        }

    }
}
