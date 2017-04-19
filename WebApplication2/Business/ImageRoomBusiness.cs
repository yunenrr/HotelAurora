using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Data;
using WebApplication2.Models;

namespace WebApplication2.Business
{
    public class ImageRoomBusiness
    {
        //Variables globales
        private string connectionString;
        private ImageRoomData imageRoomData;

        public ImageRoomBusiness(string connectionString)
        {
            this.connectionString = connectionString;
            this.imageRoomData = new ImageRoomData(this.connectionString);
        }//Fin del método constructor

        public List<ImageRoom> getImageRoomByType(int idType)
        {
            return this.getImageRoomByType(idType);
        }//Fin del método

        public List<ImageRoom> getImageRoomByRoom(int idRoom)
        {
            return this.getImageRoomByRoom(idRoom);
        }//Fin del método

        ~ImageRoomBusiness() { }
    }//Fin de la clase
}