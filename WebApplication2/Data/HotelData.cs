using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using WebApplication2.Models;

using System.Data;
using System.Data.SqlClient;

namespace WebApplication2.Data
{
    public class HotelData
    {

        private string connectionString;

        public HotelData(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public Hotel getHotel()
        {
            //conexion con la bd
            SqlConnection sqlConn = new SqlConnection(this.connectionString);

            //string sql
            string sqlSelect = "select * from tbhotel;";

            //establecer la conexion con el adaptador
            SqlDataAdapter sqlDataAdapterProperty = new SqlDataAdapter();

            //configurar el adaptador
            sqlDataAdapterProperty.SelectCommand = new SqlCommand();
            sqlDataAdapterProperty.SelectCommand.CommandText = sqlSelect;
            sqlDataAdapterProperty.SelectCommand.Connection = sqlConn;

            //definir el data set
            DataSet datasetHotels = new DataSet();

            //dataset para guardar los resultados de la consulta
            sqlDataAdapterProperty.Fill(datasetHotels, "tbhotel");

            //cerrar la conexion con el adaptador
            sqlDataAdapterProperty.SelectCommand.Connection.Close();

            DataRowCollection dataRowCollection = datasetHotels.Tables["tbhotel"].Rows;
            Hotel hotel = null;
            foreach (DataRow currentRow in dataRowCollection)
            {
                int idHotel = Int32.Parse(currentRow["idtbhotel"].ToString());
                string nameHotel = currentRow["namehotel"].ToString();
                string basicInformation = currentRow["basicinformation"].ToString();
                string history = currentRow["history"].ToString();
                string mission = currentRow["mission"].ToString();
                string vission = currentRow["vission"].ToString();
                string location = currentRow["location"].ToString();
                hotel = new Hotel(idHotel, nameHotel, basicInformation, history, mission, vission, location);
            }

            return hotel;
        }

    }
}