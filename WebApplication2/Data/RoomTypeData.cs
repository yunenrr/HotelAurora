using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using WebApplication2.Models;

using System.Data;
using System.Data.SqlClient;

namespace WebApplication2.Data
{
    public class RoomTypeData
    {
        //Variables globales
        private string connectionString;

        public RoomTypeData(string connectionString)
        {
            this.connectionString = connectionString;
        }//Fin del constructor

        /**
         * Método que retorna todos los tipos de habitación que existen en la base de datos.
         */
        public List<RoomType> getAllRoomType()
        {
            //conexion con la bd
            SqlConnection sqlConn = new SqlConnection(this.connectionString);

            //string sql
            string sqlSelect = "select idtbroomtype,roomtype,descriptionroom,quantitypersons,price,imagepathroomtype from tbroomtype;";

            //establecer la conexion con el adaptador
            SqlDataAdapter sqlDataAdapterProperty = new SqlDataAdapter();

            //configurar el adaptador
            sqlDataAdapterProperty.SelectCommand = new SqlCommand();
            sqlDataAdapterProperty.SelectCommand.CommandText = sqlSelect;
            sqlDataAdapterProperty.SelectCommand.Connection = sqlConn;

            //definir el data set
            DataSet datasetRoomType = new DataSet();
            List<RoomType> roomTypeList = new List<RoomType>();

            //dataset para guardar los resultados de la consulta
            sqlDataAdapterProperty.Fill(datasetRoomType, "tbroomtype");

            //cerrar la conexion con el adaptador
            sqlDataAdapterProperty.SelectCommand.Connection.Close();

            DataRowCollection dataRowCollection = datasetRoomType.Tables["tbroomtype"].Rows;

            foreach (DataRow currentRow in dataRowCollection)
            {
                int idRoomType = Int32.Parse(currentRow["idtbroomtype"].ToString());
                string nameRoomType = currentRow["roomtype"].ToString();
                string descriptionRoomType = currentRow["descriptionroom"].ToString();
                int quantityPersonRoomType = Int32.Parse(currentRow["quantitypersons"].ToString());
                float priceRoomType = float.Parse(currentRow["price"].ToString());
                string imagePathRoomType = currentRow["imagepathroomtype"].ToString();
                RoomType roomType = new RoomType(idRoomType, nameRoomType, descriptionRoomType, quantityPersonRoomType, priceRoomType, imagePathRoomType);
                roomTypeList.Add(roomType);
            }//Fin del foreach

            return roomTypeList;
        }//Fin del método

        ~RoomTypeData() { }
    }//Fin de la clase
}