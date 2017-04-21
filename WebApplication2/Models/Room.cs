using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Room
    {
        //Declaración de variables globales
        private int idRoom;
        private string nameRoom,characteristicsRoom;
        private Boolean availabilityRoom;
        private int typeRoom;

        public Room(int idRoom, string nameRoom, string characteristicsRoom, Boolean availabilityRoom, int typeRoom)
        {
            this.IdRoom = idRoom;
            this.NameRoom = nameRoom;
            this.CharacteristicsRoom = characteristicsRoom;
            this.AvailabilityRoom = availabilityRoom;
            this.TypeRoom = typeRoom;
        }//Fin del constructor

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

        public string NameRoom
        {
            get
            {
                return nameRoom;
            }

            set
            {
                nameRoom = value;
            }
        }

        public string CharacteristicsRoom
        {
            get
            {
                return characteristicsRoom;
            }

            set
            {
                characteristicsRoom = value;
            }
        }

        public Boolean AvailabilityRoom
        {
            get
            {
                return availabilityRoom;
            }

            set
            {
                availabilityRoom = value;
            }
        }

        public int TypeRoom
        {
            get
            {
                return typeRoom;
            }

            set
            {
                typeRoom = value;
            }
        }
    }//Fin de la clase
}