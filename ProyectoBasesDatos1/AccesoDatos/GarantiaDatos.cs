using ProyectoBasesDatos1.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBasesDatos1.AccesoDatos
{
    class GarantiaDatos
    {
        private AccesoBaseDatos conexion = new AccesoBaseDatos();


        public List<Garantia> getGarantia()
        {

            List<Garantia> listaGarantia = new List<Garantia>();

            SqlConnection sqlconnection = conexion.obtenerConexion();
            sqlconnection.Open();
            SqlCommand sqlcommand = new SqlCommand("SELECT g.* from Garantia g;", sqlconnection);

            SqlDataReader reader;
            reader = sqlcommand.ExecuteReader();

            while (reader.Read())
            {

                Garantia garantia = new Garantia();


                garantia.idGarantia = Convert.ToInt32(reader["id_garantia"].ToString());
                garantia.validez = reader["validez"].ToString();



                listaGarantia.Add(garantia);


            }

            sqlconnection.Close();


            return listaGarantia;
        }
    }
}
