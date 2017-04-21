using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Configuration;
using WebApplication2.Models;
using WebApplication2.Business;
using System.Web.Http.Description;

namespace WebApplication2.Controllers
{
    public class RoomController : ApiController
    {
        static readonly RoomBusiness roomBusiness = new RoomBusiness(WebConfigurationManager.ConnectionStrings["AzureConnString"].ToString());

        [Route("api/Room/getRoom/{id}")]
        [HttpGet]
        public Room getRoom(int id)
        {
            return roomBusiness.getRoom(id);
            //return "hola"+id;
        }//Fin del método

        [Route("api/Room/getRoomByType/{id}")]
        [HttpGet]
        public List<Room> getRoomByType(int id)
        {
            return roomBusiness.getRoomByType(id);
        }//Fin de la función
    }//Fin de la clase
}
