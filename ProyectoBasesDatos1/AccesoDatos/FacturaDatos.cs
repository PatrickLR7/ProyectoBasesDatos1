using ProyectoBasesDatos1.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBasesDatos1.AccesoDatos
{
   class FacturaDatos
    {
        private AccesoBaseDatos conexion = new AccesoBaseDatos();


        public List<Factura> getFacturas()
        {

            List<Factura> listaFacturas = new List<Factura>();

            SqlConnection sqlconnection = conexion.obtenerConexion();
            sqlconnection.Open();
            SqlCommand sqlcommand = new SqlCommand("SELECT s.* from Factura s;", sqlconnection);

            SqlDataReader reader;
            reader = sqlcommand.ExecuteReader();

            while (reader.Read())
            {

                Factura factura = new Factura();


                factura.id_factura = Convert.ToInt32(reader["id_factura"].ToString());
                factura.monto_total = Convert.ToDouble(reader["Monto_total"].ToString());
                factura.fecha_compra = Convert.ToDateTime(reader["Fecha_compra"]);
                factura.id_cliente = Convert.ToInt32(reader["Id_cliente"].ToString());
                factura.id_empleado = Convert.ToInt32(reader["Id_empleado"].ToString());


                listaFacturas.Add(factura);


            }

            sqlconnection.Close();


            return listaFacturas;
        }
    }
}
