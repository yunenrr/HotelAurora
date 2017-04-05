using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using WebApplication2.Models;

using System.Data;
using System.Data.SqlClient;

namespace WebApplication2.Data
{
    public class ImageGalleryData
    {

        private string connectionString;

        public ImageGalleryData(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<ImageGallery> getGalleryImages ()
        {
            //conexion con la bd
            SqlConnection sqlConn = new SqlConnection(this.connectionString);

            //string sql
            string sqlSelect = "Select * from tbimagegallery;";

            //establecer la conexion con el adaptador
            SqlDataAdapter sqlDataAdapterProperty = new SqlDataAdapter();

            //configurar el adaptador
            sqlDataAdapterProperty.SelectCommand = new SqlCommand();
            sqlDataAdapterProperty.SelectCommand.CommandText = sqlSelect;
            sqlDataAdapterProperty.SelectCommand.Connection = sqlConn;

            //definir el data set
            DataSet datasetProperties = new DataSet();

            //dataset para guardar los resultados de la consulta
            sqlDataAdapterProperty.Fill(datasetProperties, "tbimagegallery");

            //cerrar la conexion con el adaptador
            sqlDataAdapterProperty.SelectCommand.Connection.Close();

            DataRowCollection dataRowCollection = datasetProperties.Tables["tbimagegallery"].Rows;

            List<ImageGallery> images = new List<ImageGallery>();
            foreach (DataRow currentRow in dataRowCollection)
            {
                ImageGallery imageTemp = new ImageGallery(Int32.Parse(currentRow["idtbimagegallery"].ToString()), 
                    currentRow["imagegallerypath"].ToString());
                images.Add(imageTemp);
            }

                return images;
        }

    }
}