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

        /*Metodo para verifiacar que habitaciones se encuentran disponibles para reservar*/
        public List<int> verifyReservation(int typeroom, string inDate, string outDate)
        {
            //conexion con la bd
            SqlConnection sqlConn = new SqlConnection(this.connectionString);

            //string sql
            string sqlSelect = "select idtbroom  from tbroom where typeroom="+ typeroom +"and idtbroom not in (" +
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

        /*Metodo para insertar la reservacion*/
        public int insertReservation(string reservationNumber, int client, int creditCard, int room, string intDate, string outDate) {

            //conexion con la bd
            SqlConnection sqlConn = new SqlConnection(this.connectionString);

            //string sql
            string sqlSelect = "insert into tbreservation values(100, '" + reservationNumber + "' ," + client + ","+
                                                                  creditCard+ "," + room + ",'"+ intDate + "','"+ outDate + "');";

            //establecer la conexion con el adaptador
            SqlDataAdapter sqlDataAdapterProperty = new SqlDataAdapter();

            //configurar el adaptador
            sqlDataAdapterProperty.SelectCommand = new SqlCommand();
            sqlDataAdapterProperty.SelectCommand.CommandText = sqlSelect;
            sqlDataAdapterProperty.SelectCommand.Connection = sqlConn;

            //cerrar la conexion con el adaptador
            sqlDataAdapterProperty.SelectCommand.Connection.Close();

            //retorna 1 si la reservacion fue ingresada exitosamente 2 si NO
            /*if (variable a comparar)
            {
                return 1;
            }
            else {
                return 2;
            }*/

            return 1;


        }



    }
}