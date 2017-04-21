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
    public class ImageRoomController : ApiController
    {
        static readonly ImageRoomBusiness imageRoomBusiness = new ImageRoomBusiness(WebConfigurationManager.ConnectionStrings["AzureConnString"].ToString());

        [Route("api/ImageRoom/getImageRoomByRoom/{id}")]
        [HttpGet]
        public List<ImageRoom> getImageRoomByRoom(int id)
        {
            return imageRoomBusiness.getImageRoomByRoom(id);
            //return "hola" + id;
        }//Fin del método
    }//Fin de la clase
}
