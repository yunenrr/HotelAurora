using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class RoomType
    {
        //Declaración de variables globales
        private int idRoomType;
        private string nameRoomType, descriptionRoomType;
        private int quantityPersonRoomType;
        private float priceRoomType;
        private string imagePathRoomType;

        public RoomType(int idRoomType, string nameRoomType, string descriptionRoomType, int quantityPersonRoomType, float priceRoomType, string imagePathRoomType)
        {
            this.IdRoomType = idRoomType;
            this.NameRoomType = nameRoomType;
            this.DescriptionRoomType = descriptionRoomType;
            this.QuantityPersonRoomType = quantityPersonRoomType;
            this.PriceRoomType = priceRoomType;
            this.ImagePathRoomType = imagePathRoomType;
        }//Fin del método constructor

        public int IdRoomType
        {
            get
            {
                return idRoomType;
            }

            set
            {
                idRoomType = value;
            }
        }

        public string NameRoomType
        {
            get
            {
                return nameRoomType;
            }

            set
            {
                nameRoomType = value;
            }
        }

        public string DescriptionRoomType
        {
            get
            {
                return descriptionRoomType;
            }

            set
            {
                descriptionRoomType = value;
            }
        }

        public int QuantityPersonRoomType
        {
            get
            {
                return quantityPersonRoomType;
            }

            set
            {
                quantityPersonRoomType = value;
            }
        }

        public float PriceRoomType
        {
            get
            {
                return priceRoomType;
            }

            set
            {
                priceRoomType = value;
            }
        }

        public string ImagePathRoomType
        {
            get
            {
                return imagePathRoomType;
            }

            set
            {
                imagePathRoomType = value;
            }
        }

        ~RoomType() { }
    }//Fin de la clase
}