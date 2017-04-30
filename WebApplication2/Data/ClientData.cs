using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;

namespace WebApplication2.Data
{
    public class ClientData
    {
        //variables globales
        private string connectionString;

        //conexion
        public ClientData(string connectionString)
        {
            this.connectionString = connectionString;
        }
         
        //Metodo para insertar un cliente
        public int insertClient(/*int idtbclient,*/ string dni, string name, string surnames, string email, string phone)
        {
            //conexion con la bd
            SqlConnection sqlConn = new SqlConnection(this.connectionString);

            //string sql
            string sqlSelect = "insert into tbclient values(1, '" + dni + "' ,'" + name + "','" + surnames + "','" + email + "','" + phone + "');";

            //establecer la conexion con el adaptador
            SqlDataAdapter sqlDataAdapterProperty = new SqlDataAdapter();

            //configurar el adaptador
            sqlDataAdapterProperty.SelectCommand = new SqlCommand();
            sqlDataAdapterProperty.SelectCommand.CommandText = sqlSelect;
            sqlDataAdapterProperty.SelectCommand.Connection = sqlConn;

            //cerrar la conexion con el adaptador
            sqlDataAdapterProperty.SelectCommand.Connection.Close();

            return 1;
        } // fin metodo insertar cliente



    }
}