using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class ImageRoom
    {
        //Declaración de variables
        private int idImageRoom;
        private string imageRoomPath;
        private int idRoom;

        public ImageRoom(int idImageRoom, string imageRoomPath, int idRoom)
        {
            this.IdImageRoom = idImageRoom;
            this.ImageRoomPath = imageRoomPath;
            this.IdRoom = idRoom;
        }//Fin del constructor

        public int IdImageRoom
        {
            get
            {
                return idImageRoom;
            }

            set
            {
                idImageRoom = value;
            }
        }

        public string ImageRoomPath
        {
            get
            {
                return imageRoomPath;
            }

            set
            {
                imageRoomPath = value;
            }
        }

        public int IdRoom
        {
            get
            {
                return idRoom;
            }

            set
            {
                idRoom = value;
            }
        }
    }//Fin de la clase
}