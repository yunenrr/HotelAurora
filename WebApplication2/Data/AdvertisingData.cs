using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using WebApplication2.Models;

using System.Data;
using System.Data.SqlClient;

namespace WebApplication2.Data
{
    public class AdvertisingData
    {

        private string connectionString;

        public AdvertisingData(string connectionString)
        {
            this.connectionString = connectionString;
        }


        public List<Advertising> getAdvertising()
        {
            //conexion con la bd
            SqlConnection sqlConn = new SqlConnection(this.connectionString);

            //string sql
            string sqlSelect = "Select * from tbadvertising;";

            //establecer la conexion con el adaptador
            SqlDataAdapter sqlDataAdapterProperty = new SqlDataAdapter();

            //configurar el adaptador
            sqlDataAdapterProperty.SelectCommand = new SqlCommand();
            sqlDataAdapterProperty.SelectCommand.CommandText = sqlSelect;
            sqlDataAdapterProperty.SelectCommand.Connection = sqlConn;

            //definir el data set
            DataSet datasetProperties = new DataSet();

            //dataset para guardar los resultados de la consulta
            sqlDataAdapterProperty.Fill(datasetProperties, "tbadvertising");

            //cerrar la conexion con el adaptador
            sqlDataAdapterProperty.SelectCommand.Connection.Close();

            DataRowCollection dataRowCollection = datasetProperties.Tables["tbadvertising"].Rows;

            List<Advertising> advertising = new List<Advertising>();
            foreach (DataRow currentRow in dataRowCollection)
            {
                Advertising temp = new Advertising(Int32.Parse(currentRow["idtbadvertising"].ToString()),
                    currentRow["imageadvertisingpath"].ToString(),
                    currentRow["urladvertising"].ToString());
                advertising.Add(temp);
                
            }
            

            return advertising;
        }



    }
}