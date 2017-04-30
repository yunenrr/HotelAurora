using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Configuration;
using WebApplication2.Models;
using WebApplication2.Business;

namespace WebApplication2.Controllers
{
    public class AdministratorController : ApiController
    {
        //conexion BD
        static readonly AdministratorBusiness administratorBusiness = new AdministratorBusiness(WebConfigurationManager.ConnectionStrings["AzureConnString"].ToString());

        //metodo insertar
        public int insertAdministartor(/*int idtbuseradmin,*/ string nameuseradmin, string emailuseradmin, string passworduseradmin)
        {
            return administratorBusiness.insertAdministrator(nameuseradmin, emailuseradmin, passworduseradmin);
        }


    }
}
