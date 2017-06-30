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


        //metodo insertar cliente
        [Route("api/Client/insertClient/{dni, name, surnames, email, phone}")]
        [HttpGet]
        public int insertClient(string dni, string name, string surnames, string email, string phone)
        {
            return clientBusiness.insertClient(dni, name, surnames, email, phone);
        }

        //metodo actualizar cliente
        [Route("api/Client/updateClient/{idtbclient, dni, name, surnames, email, phone}")]
        [HttpGet]
        public int updateClient(int idtbclient, string dni, string name, string surnames, string email, string phone)
        {
            return clientBusiness.updateClient(idtbclient, dni, name, surnames, email, phone);
        }

        //metodo buscar cliente
        [Route("api/Client/getClientById/{id}")]
        [HttpGet]
        public Client getClient(int id)
        {
            return clientBusiness.getClienById(id);   
        }

        [Route("api/Client/getClientByDNI/{dni}")]
        [HttpGet]
        public Client getClientByDNI(string dni)
        {
            return clientBusiness.getClientByDNI(dni);
        }

    }
}
