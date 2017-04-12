using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Facility
    {
        private int idFacility;
        private string nameFacility, descriptionFacility,pathImageFacility;

        public Facility(int idFacility, string nameFacility, string descriptionFacility, string pathImageFacility)
        {
            this.IdFacility = idFacility;
            this.NameFacility = nameFacility;
            this.DescriptionFacility = descriptionFacility;
            this.PathImageFacility = pathImageFacility;
        }

        public string DescriptionFacility
        {
            get
            {
                return descriptionFacility;
            }

            set
            {
                descriptionFacility = value;
            }
        }

        public int IdFacility
        {
            get
            {
                return idFacility;
            }

            set
            {
                idFacility = value;
            }
        }

        public string NameFacility
        {
            get
            {
                return nameFacility;
            }

            set
            {
                nameFacility = value;
            }
        }

        public string PathImageFacility
        {
            get
            {
                return pathImageFacility;
            }

            set
            {
                pathImageFacility = value;
            }
        }
        ~Facility() { }
    }//Fin de la clase
}