using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using WebApplication2.Data;
using WebApplication2.Models;

namespace WebApplication2.Business
{
    public class RoomTypeBusiness
    {
        //Variables globales
        private string connectionString;
        private RoomTypeData roomTypeData;

        public RoomTypeBusiness(string connectionString)
        {
            this.connectionString = connectionString;
            this.roomTypeData = new RoomTypeData(this.connectionString);
        }//Fin del constructor

        /**
         * Método que retorna todos los tipos de habitación que existen en la base de datos.
         */
        public List<RoomType> getAllRoomType()
        {
            return this.roomTypeData.getAllRoomType();
        }//Fin del método

        ~RoomTypeBusiness() { }
    }//Fin de la clase
}