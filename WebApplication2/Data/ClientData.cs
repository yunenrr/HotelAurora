using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;
using WebApplication2.Models;

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

        //Metodo para actualizar un cliente
        public int updateClient(int idtbclient, string dni, string name, string surnames, string email, string phone)
        {
            //conexion con la bd
            SqlConnection sqlConn = new SqlConnection(this.connectionString);

            //string sql
            string sqlSelect = "update tbclient set dni ='" + dni + "',name ='" + name + "',surnames ='" + surnames + "',email ='" + email + "',phone ='" + phone +
                               "' where idtbclient =" + idtbclient + ";";

            //establecer la conexion con el adaptador
            SqlDataAdapter sqlDataAdapterProperty = new SqlDataAdapter();

            //configurar el adaptador
            sqlDataAdapterProperty.SelectCommand = new SqlCommand();
            sqlDataAdapterProperty.SelectCommand.CommandText = sqlSelect;
            sqlDataAdapterProperty.SelectCommand.Connection = sqlConn;

            //cerrar la conexion con el adaptador
            sqlDataAdapterProperty.SelectCommand.Connection.Close();

            return 1;

        } // fin del metodo actualizar cliente

        //Metodo para buscar un cliente
        public Client getClientById(int id)
        {
            //conexion con la bd
            SqlConnection sqlConn = new SqlConnection(this.connectionString);

            //string sql
            string sqlSelect = "select idtbclient,dni,name,surnames,email,phone from tbclient where idtbclient=" + id + ";";

            //establecer la conexion con el adaptador
            SqlDataAdapter sqlDataAdapterProperty = new SqlDataAdapter();

            //configurar el adaptador
            sqlDataAdapterProperty.SelectCommand = new SqlCommand();
            sqlDataAdapterProperty.SelectCommand.CommandText = sqlSelect;
            sqlDataAdapterProperty.SelectCommand.Connection = sqlConn;

            //definir el data set
            DataSet datasetClient = new DataSet();
            Client client = null;

            //dataset para guardar los resultados de la consulta
            sqlDataAdapterProperty.Fill(datasetClient, "tbclient");

            //cerrar la conexion con el adaptador
            sqlDataAdapterProperty.SelectCommand.Connection.Close();

            DataRowCollection dataRowCollection = datasetClient.Tables["tbclient"].Rows;

            foreach (DataRow currentRow in dataRowCollection)
            {
                int idClient = Int32.Parse(currentRow["idtbclient"].ToString());
                string dniClient = currentRow["dni"].ToString();
                string nameClient = currentRow["name"].ToString();
                string surnameClient = currentRow["surnames"].ToString();
                string emailClient = currentRow["email"].ToString();
                string phoneClient = currentRow["phone"].ToString();

                client = new Client(idClient, dniClient, nameClient, surnameClient, emailClient, phoneClient);
            }
            return client;

        } // fin metodo buscar cliente


    }
}
