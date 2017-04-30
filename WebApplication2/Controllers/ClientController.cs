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
    public class ClientController : ApiController
    {
        //conexion BD
        static readonly ClientBusiness clientBusiness = new ClientBusiness(WebConfigurationManager.ConnectionStrings["AzureConnString"].ToString());

        //metodo insertar
        public int insertClient(/*int idtbclient,*/ string dni, string name, string surnames, string email, string phone)
        {
            return clientBusiness.insertClient(dni, name, surnames, email, phone);
        }

    }
}
