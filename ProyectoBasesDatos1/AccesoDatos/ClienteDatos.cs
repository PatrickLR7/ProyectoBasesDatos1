using ProyectoBasesDatos1.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBasesDatos1.AccesoDatos
{
    class ClienteDatos
    {
        private AccesoBaseDatos conexion = new AccesoBaseDatos();


        public List<Cliente> getClientes()
        {

            List<Cliente> listaClientes = new List<Cliente>();

            SqlConnection sqlconnection = conexion.obtenerConexion();
            sqlconnection.Open();
            SqlCommand sqlcommand = new SqlCommand("SELECT s.* from Cliente s;", sqlconnection);

            SqlDataReader reader;
            reader = sqlcommand.ExecuteReader();

            while (reader.Read())
            {

                Cliente cliente = new Cliente();


                cliente.id_cliente = Convert.ToInt32(reader["id_cliente"].ToString());
                cliente.identificacion = Convert.ToInt32(reader["identificacion"].ToString());


                listaClientes.Add(cliente);


            }

            sqlconnection.Close();


            return listaClientes;
        }
    }
}
