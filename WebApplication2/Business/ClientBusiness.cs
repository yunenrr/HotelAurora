using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using WebApplication2.Data;
using WebApplication2.Models;

namespace WebApplication2.Business
{
    public class ClientBusiness
    {
        //Variables globales
        private string connectionString;
        private ClientData clientData;

        //conexion
        public ClientBusiness(string connectionString)
        {
            this.connectionString = connectionString;
            this.clientData = new ClientData(this.connectionString);
        }

        //metodo insertar
        public int insertClient(/*int idtbclient,*/ string dni, string name, string surnames, string email, string phone)
        {
            return clientData.insertClient(dni,  name,  surnames,  email,  phone);
        }



    }
}