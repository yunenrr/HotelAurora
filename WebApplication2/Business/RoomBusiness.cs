using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using WebApplication2.Data;
using WebApplication2.Models;

namespace WebApplication2.Business
{
    public class RoomBusiness
    {
        //Variables globales
        private string connectionString;
        private RoomData roomData;

        public RoomBusiness(string connectionString)
        {
            this.connectionString = connectionString;
            this.roomData = new RoomData(this.connectionString);
        }//Fin del constructor

        public List<Room> getRoomByType(int idType)
        {
            return this.roomData.getRoomByType(idType);
        }//Fin del método

        public Room getRoom(int idRoomGet)
        {
            return this.roomData.getRoom(idRoomGet);
        }//Fin del método

        ~RoomBusiness() { } //Destructor
    }//Fin de la clase
}