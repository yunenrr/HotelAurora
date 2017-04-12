using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using WebApplication2.Data;
using WebApplication2.Models;

namespace WebApplication2.Business
{
    public class FacilityBusiness
    {
        //Variables globales
        private string connectionString;
        private FacilityData facilityData;

        public FacilityBusiness(string connectionString)
        {
            this.connectionString = connectionString;
            this.facilityData = new FacilityData(this.connectionString);
        }

        /**
         * Método que retorna todas las facilidades que se encuentran en la base de datos.
         */
        public List<Facility> getAllFacility()
        {
            return this.facilityData.getAllFacility();
        }//Fin del método

        ~FacilityBusiness() { }
    }//Fin de la clase
}