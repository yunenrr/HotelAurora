using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;

namespace WebApplication2.Data
{
    public class AdministratorData
    {
        //variables globales
        private string connectionString;

        //conexion
        public AdministratorData(string connectionString)
        {
            this.connectionString = connectionString;
        }

        //Metodo para insertar un administrador
        public int insertAdministrator(/*int idtbuseradmin,*/ string nameuseradmin, string emailuseradmin, string passworduseradmin)
        {
            //conexion con la bd
            SqlConnection sqlConn = new SqlConnection(this.connectionString);

            //string sql
            string sqlSelect = "insert into tbuseradmin values(1, '" + nameuseradmin + "' ,'" + emailuseradmin + "','" + passworduseradmin + "');";

            //establecer la conexion con el adaptador
            SqlDataAdapter sqlDataAdapterProperty = new SqlDataAdapter();

            //configurar el adaptador
            sqlDataAdapterProperty.SelectCommand = new SqlCommand();
            sqlDataAdapterProperty.SelectCommand.CommandText = sqlSelect;
            sqlDataAdapterProperty.SelectCommand.Connection = sqlConn;

            //cerrar la conexion con el adaptador
            sqlDataAdapterProperty.SelectCommand.Connection.Close();

            return 1;
        } // fin metodo insertar administrador



    }
}