using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using WebApplication2.Models;

using System.Data;
using System.Data.SqlClient;

namespace WebApplication2.Data
{
    public class RoomData
    {
        //Variables globales
        private string connectionString;

        public RoomData(string connectionString)
        {
            this.connectionString = connectionString;
        }//Fin del constructor

        public List<Room> getRoomByType(int idType)
        {
            //conexion con la bd
            SqlConnection sqlConn = new SqlConnection(this.connectionString);

            //string sql
            string sqlSelect = "select idtbroom,nameroom,characteristics,tbroom.availability,typeroom from tbroom where typeroom = "+idType+";";

            //establecer la conexion con el adaptador
            SqlDataAdapter sqlDataAdapterProperty = new SqlDataAdapter();

            //configurar el adaptador
            sqlDataAdapterProperty.SelectCommand = new SqlCommand();
            sqlDataAdapterProperty.SelectCommand.CommandText = sqlSelect;
            sqlDataAdapterProperty.SelectCommand.Connection = sqlConn;

            //definir el data set
            DataSet datasetRoomType = new DataSet();
            List<Room> roomList = new List<Room>();

            //dataset para guardar los resultados de la consulta
            sqlDataAdapterProperty.Fill(datasetRoomType, "tbroom");

            //cerrar la conexion con el adaptador
            sqlDataAdapterProperty.SelectCommand.Connection.Close();

            DataRowCollection dataRowCollection = datasetRoomType.Tables["tbroom"].Rows;

            foreach (DataRow currentRow in dataRowCollection)
            {
                int idRoom = Int32.Parse(currentRow["idtbroom"].ToString());
                string nameRoom = currentRow["nameroom"].ToString();
                string characteristicsRoom = currentRow["characteristics"].ToString();
                Boolean availabilityRoom = Boolean.Parse(currentRow["availability"].ToString());
                int typeRoom = Int32.Parse(currentRow["typeroom"].ToString());
                Room room = new Room(idRoom,nameRoom,characteristicsRoom,availabilityRoom,typeRoom);
                roomList.Add(room);
            }//Fin del foreach

            return roomList;
        }//Fin del método

        public Room getRoom(int idRoomGet)
        {
            //conexion con la bd
            SqlConnection sqlConn = new SqlConnection(this.connectionString);

            //string sql
            string sqlSelect = "select idtbroom,nameroom,characteristics,tbroom.availability,typeroom from tbroom where idtbroom = " + idRoomGet + ";";

            //establecer la conexion con el adaptador
            SqlDataAdapter sqlDataAdapterProperty = new SqlDataAdapter();

            //configurar el adaptador
            sqlDataAdapterProperty.SelectCommand = new SqlCommand();
            sqlDataAdapterProperty.SelectCommand.CommandText = sqlSelect;
            sqlDataAdapterProperty.SelectCommand.Connection = sqlConn;

            //definir el data set
            DataSet datasetRoomType = new DataSet();
            Room room = null;

            //dataset para guardar los resultados de la consulta
            sqlDataAdapterProperty.Fill(datasetRoomType, "tbroom");

            //cerrar la conexion con el adaptador
            sqlDataAdapterProperty.SelectCommand.Connection.Close();

            DataRowCollection dataRowCollection = datasetRoomType.Tables["tbroom"].Rows;

            foreach (DataRow currentRow in dataRowCollection)
            {
                int idRoom = Int32.Parse(currentRow["idtbroom"].ToString());
                string nameRoom = currentRow["nameroom"].ToString();
                string characteristicsRoom = currentRow["characteristics"].ToString();
                Boolean availabilityRoom = Boolean.Parse(currentRow["availability"].ToString());
                int typeRoom = Int32.Parse(currentRow["typeroom"].ToString());
                room = new Room(idRoom, nameRoom, characteristicsRoom, availabilityRoom, typeRoom);
            }//Fin del foreach

            return room;
        }//Fin del método


        /*Metodo para verifiacar que habitaciones se encuentran disponibles para reservar*/
        public List<int> verifyStateHotelToday(string inDate)
        {
            //conexion con la bd
            SqlConnection sqlConn = new SqlConnection(this.connectionString);

            //string sql
            string sqlSelect = "select idtbroom from tbroom where idtbroom not in (" +
                                "select room from tbreservation where (indate = '" + inDate + "') or " +
                                "('" + inDate + "' > indate and '" + inDate + "' < outdate) or " +
                                "(indate > '" + inDate + "' and indate < '" + inDate + "') " +
                                ");";

            //establecer la conexion con el adaptador
            SqlDataAdapter sqlDataAdapterProperty = new SqlDataAdapter();

            //configurar el adaptador
            sqlDataAdapterProperty.SelectCommand = new SqlCommand();
            sqlDataAdapterProperty.SelectCommand.CommandText = sqlSelect;
            sqlDataAdapterProperty.SelectCommand.Connection = sqlConn;

            //definir el data set
            DataSet datasetRooms = new DataSet();
            List<int> roomsAvailableList = new List<int>();

            //dataset para guardar los resultados de la consulta
            sqlDataAdapterProperty.Fill(datasetRooms, "tbreservation");

            //cerrar la conexion con el adaptador
            sqlDataAdapterProperty.SelectCommand.Connection.Close();

            DataRowCollection dataRowCollection = datasetRooms.Tables["tbreservation"].Rows;

            foreach (DataRow currentRow in dataRowCollection)
            {
                int room = Int32.Parse(currentRow["idtbroom"].ToString());
                roomsAvailableList.Add(room);
            }

            return roomsAvailableList;
        }

        public List<Room> getRoomsState()
        {
            //conexion con la bd
            SqlConnection sqlConn = new SqlConnection(this.connectionString);

            //string sql
            string sqlSelect = "select tbroom.idtbroom, tbroom.nameroom, tbroom.typeroom " +
                "from tbroom;";

            //establecer la conexion con el adaptador
            SqlDataAdapter sqlDataAdapterProperty = new SqlDataAdapter();

            //configurar el adaptador
            sqlDataAdapterProperty.SelectCommand = new SqlCommand();
            sqlDataAdapterProperty.SelectCommand.CommandText = sqlSelect;
            sqlDataAdapterProperty.SelectCommand.Connection = sqlConn;

            //definir el data set
            DataSet datasetRoomType = new DataSet();
            List<Room> roomList = new List<Room>();

            //dataset para guardar los resultados de la consulta
            sqlDataAdapterProperty.Fill(datasetRoomType, "tbroom");

            //cerrar la conexion con el adaptador
            sqlDataAdapterProperty.SelectCommand.Connection.Close();

            DataRowCollection dataRowCollection = datasetRoomType.Tables["tbroom"].Rows;

            String today = DateTime.Now.ToString("yyyy-MM-dd");
            List<int> availablesToday = this.verifyStateHotelToday(today);

            foreach (DataRow currentRow in dataRowCollection)
            {
                int idRoom = Int32.Parse(currentRow["idtbroom"].ToString());
                string nameRoom = currentRow["nameroom"].ToString();
                int typeRoom = Int32.Parse(currentRow["typeroom"].ToString());
                Boolean available = false;
                if (availablesToday.Contains(idRoom))
                {
                    available = true;
                }
                Room room = new Room(idRoom, nameRoom, "", available, typeRoom);

                roomList.Add(room);
            }//Fin del foreach

            return roomList;
        }

        ~RoomData() { }//Destructor
    }//Fin de la clase
}