using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;

namespace WebApplication2.Data
{
    public class ReservationData
    {

        private string connectionString;

        public ReservationData(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<int> verifyReservation(string inDate, string outDate)
        {
            //conexion con la bd
            SqlConnection sqlConn = new SqlConnection(this.connectionString);

            //string sql
            string sqlSelect = "select idtbroom  from tbroom where idtbroom not in (" +
                                "select room from tbreservation where (indate = '" + inDate + "') or " +
                                "('" + inDate + "' > indate and '" + inDate + "' < outdate) or " +
                                "(indate > '" + inDate + "' and indate < '" + outDate + "') " +
                                ");";

            //establecer la conexion con el adaptador
            SqlDataAdapter sqlDataAdapterProperty = new SqlDataAdapter();

            //configurar el adaptador
            sqlDataAdapterProperty.SelectCommand = new SqlCommand();
            sqlDataAdapterProperty.SelectCommand.CommandText = sqlSelect;
            sqlDataAdapterProperty.SelectCommand.Connection = sqlConn;

            //definir el data set
            DataSet datasetRooms = new DataSet();
            List<int> roomsNotAvailableList = new List<int>();

            //dataset para guardar los resultados de la consulta
            sqlDataAdapterProperty.Fill(datasetRooms, "tbreservation");

            //cerrar la conexion con el adaptador
            sqlDataAdapterProperty.SelectCommand.Connection.Close();

            DataRowCollection dataRowCollection = datasetRooms.Tables["tbreservation"].Rows;

            foreach (DataRow currentRow in dataRowCollection)
            {
                int room = Int32.Parse(currentRow["idtbroom"].ToString());
                roomsNotAvailableList.Add(room);
            }

            return roomsNotAvailableList;
        }



    }
}