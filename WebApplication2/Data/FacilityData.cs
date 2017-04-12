using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using WebApplication2.Models;

using System.Data;
using System.Data.SqlClient;

namespace WebApplication2.Data
{
    public class FacilityData
    {
        //Variables globales
        private string connectionString;

        public FacilityData(string connectionString)
        {
            this.connectionString = connectionString;
        }

        /**
         * Método que retorna todas las facilidades que se encuentran en la base de datos.
         */
        public List<Facility> getAllFacility()
        {
            //conexion con la bd
            SqlConnection sqlConn = new SqlConnection(this.connectionString);

            //string sql
            string sqlSelect = "select idtbfacility,facility,descriptionfacility,imagefacilitypath from tbfacility;";

            //establecer la conexion con el adaptador
            SqlDataAdapter sqlDataAdapterProperty = new SqlDataAdapter();

            //configurar el adaptador
            sqlDataAdapterProperty.SelectCommand = new SqlCommand();
            sqlDataAdapterProperty.SelectCommand.CommandText = sqlSelect;
            sqlDataAdapterProperty.SelectCommand.Connection = sqlConn;

            //definir el data set
            DataSet datasetFacility = new DataSet();
            List<Facility> facilityList = new List<Facility>();

            //dataset para guardar los resultados de la consulta
            sqlDataAdapterProperty.Fill(datasetFacility, "tbfacility");

            //cerrar la conexion con el adaptador
            sqlDataAdapterProperty.SelectCommand.Connection.Close();

            DataRowCollection dataRowCollection = datasetFacility.Tables["tbfacility"].Rows;

            foreach (DataRow currentRow in dataRowCollection)
            {
                int idFacility = Int32.Parse(currentRow["idtbfacility"].ToString());
                string nameFacility = currentRow["facility"].ToString();
                string descriptionFacility = currentRow["descriptionfacility"].ToString();
                string pathImageFacility = currentRow["imagefacilitypath"].ToString();
                Facility facility = new Facility(idFacility, nameFacility, descriptionFacility, pathImageFacility);
                facilityList.Add(facility);
            }

            return facilityList;
        }//Fin del método

        ~FacilityData() { }
    }//Fin de la clase
}