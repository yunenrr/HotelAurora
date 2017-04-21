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
    public class RoomTypeController : ApiController
    {
        static readonly RoomTypeBusiness roomTypeBusiness = new RoomTypeBusiness(WebConfigurationManager.ConnectionStrings["AzureConnString"].ToString());

        /**
         * Método que retorna todos los tipos de habitación que existen en la base de datos.
         */
        public List<RoomType> getAllRoomType()
        {
            return roomTypeBusiness.getAllRoomType();
        }//Fin del método

        [Route("api/RoomType/getRoomTypeById/{id}")]
        [HttpGet]
        public RoomType getRoomTypeById(int id)
        {
            return roomTypeBusiness.getRoomTypeById(id);
        }//Fin de la función
    }//Fin de la clase
}
