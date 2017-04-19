using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using WebApplication2.Models;

using System.Data;
using System.Data.SqlClient;

namespace WebApplication2.Data
{
    public class PromotionData { 

         private string connectionString;

        public PromotionData(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<Promotion> getPromotion()
        {
            //conexion con la bd
            SqlConnection sqlConn = new SqlConnection(this.connectionString);

            //string sql
            string sqlSelect = "Select * from tbpromotion;";

            //establecer la conexion con el adaptador
            SqlDataAdapter sqlDataAdapterProperty = new SqlDataAdapter();

            //configurar el adaptador
            sqlDataAdapterProperty.SelectCommand = new SqlCommand();
            sqlDataAdapterProperty.SelectCommand.CommandText = sqlSelect;
            sqlDataAdapterProperty.SelectCommand.Connection = sqlConn;

            //definir el data set
            DataSet datasetProperties = new DataSet();

            //dataset para guardar los resultados de la consulta
            sqlDataAdapterProperty.Fill(datasetProperties, "tbpromotion");

            //cerrar la conexion con el adaptador
            sqlDataAdapterProperty.SelectCommand.Connection.Close();

            DataRowCollection dataRowCollection = datasetProperties.Tables["tbpromotion"].Rows;

            List<Promotion> promotion = new List<Promotion>();
            foreach (DataRow currentRow in dataRowCollection)
            {
                Promotion temp = new Promotion(Int32.Parse(currentRow["idtbpromotion"].ToString()),
                    currentRow["promotion"].ToString(),
                    currentRow["descriptionpromotion"].ToString(),
                    currentRow["imagepromotion"].ToString());
                promotion.Add(temp);

            }


            return promotion;
        }


    }
}