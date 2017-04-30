using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using WebApplication2.Data;
using WebApplication2.Models;

namespace WebApplication2.Business
{
    public class AdministratorBusiness
    {
        //Variables globales
        private string connectionString;
        private AdministratorData administratorData;

        //conexion
        public AdministratorBusiness(string connectionString)
        {
            this.connectionString = connectionString;
            this.administratorData = new AdministratorData(this.connectionString);
        }

        //metodo insertar
        public int insertAdministrator(/*int idtbuseradmin,*/ string nameuseradmin, string emailuseradmin, string passworduseradmin)
        {
            return administratorData.insertAdministrator(nameuseradmin, emailuseradmin, passworduseradmin);
        }


    }
}