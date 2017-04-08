using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using WebApplication2.Models;
using WebApplication2.Business;

namespace WebApplication2.Controllers
{
    public class FacilityController : ApiController
    {
        static readonly FacilityBusiness facilityBusiness = new FacilityBusiness("Data Source=163.178.107.130;Initial Catalog=aurorahotel;Persist Security Info=True;User ID=sqlserver;Password=saucr.12");

        /**
         * Método que retorna todas las facilidades que se encuentran en la base de datos.
         */
        public List<Facility> getAllFacility()
        {
            return facilityBusiness.getAllFacility();
        }
    }//Fin de la clase
}
