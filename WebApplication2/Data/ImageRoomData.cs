using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Models;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication2.Data
{
    public class ImageRoomData
    {
        //Variables globales
        private string connectionString;

        public ImageRoomData(string connectionString)
        {
            this.connectionString = connectionString;
        }//Fin del método constructor

        public List<ImageRoom> getImageRoomByType(int idType)
        {
            //conexion con la bd
            SqlConnection sqlConn = new SqlConnection(this.connectionString);

            //string sql
            string sqlSelect = "select idtbimageroom,imageroompath,room,typeroom from tbimageroom inner join tbroom on tbimageroom.room = tbroom.idtbroom;";

            //establecer la conexion con el adaptador
            SqlDataAdapter sqlDataAdapterProperty = new SqlDataAdapter();

            //configurar el adaptador
            sqlDataAdapterProperty.SelectCommand = new SqlCommand();
            sqlDataAdapterProperty.SelectCommand.CommandText = sqlSelect;
            sqlDataAdapterProperty.SelectCommand.Connection = sqlConn;

            //definir el data set
            DataSet datasetRoomType = new DataSet();
            List<ImageRoom> imageRoomList = new List<ImageRoom>();

            //dataset para guardar los resultados de la consulta
            sqlDataAdapterProperty.Fill(datasetRoomType, "tbimageroom");

            //cerrar la conexion con el adaptador
            sqlDataAdapterProperty.SelectCommand.Connection.Close();

            DataRowCollection dataRowCollection = datasetRoomType.Tables["tbimageroom"].Rows;

            foreach (DataRow currentRow in dataRowCollection)
            {
                int tempId = Int32.Parse(currentRow["typeroom"].ToString());

                //Preguntamos si la categoría es la misma
                if(tempId == idType)
                {
                    int idImageRoom = Int32.Parse(currentRow["idtbimageroom"].ToString());
                    string imageRoomPath = currentRow["imageroompath"].ToString();
                    int room = Int32.Parse(currentRow["room"].ToString());

                    ImageRoom imageRoom = new ImageRoom(idImageRoom, imageRoomPath, room);
                    imageRoomList.Add(imageRoom);
                }//Preguntamos si el tipo es el mismo
            }//Fin del foreach

            return imageRoomList;
        }//Fin del método

        public List<ImageRoom> getImageRoomByRoom(int idRoom)
        {
            //conexion con la bd
            SqlConnection sqlConn = new SqlConnection(this.connectionString);

            //string sql
            string sqlSelect = "select idtbimageroom,imageroompath,room from tbimageroom where room = "+idRoom+";";

            //establecer la conexion con el adaptador
            SqlDataAdapter sqlDataAdapterProperty = new SqlDataAdapter();

            //configurar el adaptador
            sqlDataAdapterProperty.SelectCommand = new SqlCommand();
            sqlDataAdapterProperty.SelectCommand.CommandText = sqlSelect;
            sqlDataAdapterProperty.SelectCommand.Connection = sqlConn;

            //definir el data set
            DataSet datasetRoomType = new DataSet();
            List<ImageRoom> imageRoomList = new List<ImageRoom>();

            //dataset para guardar los resultados de la consulta
            sqlDataAdapterProperty.Fill(datasetRoomType, "tbimageroom");

            //cerrar la conexion con el adaptador
            sqlDataAdapterProperty.SelectCommand.Connection.Close();

            DataRowCollection dataRowCollection = datasetRoomType.Tables["tbimageroom"].Rows;

            foreach (DataRow currentRow in dataRowCollection)
            {
                int idImageRoom = Int32.Parse(currentRow["idtbimageroom"].ToString());
                string imageRoomPath = currentRow["imageroompath"].ToString();
                int room = Int32.Parse(currentRow["room"].ToString());

                ImageRoom imageRoom = new ImageRoom(idImageRoom, imageRoomPath, room);
                imageRoomList.Add(imageRoom);
            }//Preguntamos si el tipo es el mismo

            return imageRoomList;
        }//Fin del método
    }//Fin de la clase
}