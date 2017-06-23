using ProyectoBasesDatos1.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBasesDatos1.AccesoDatos
{
    class ProductoDatos
    {
        private AccesoBaseDatos conexion = new AccesoBaseDatos();


        public List<Producto> getProducto()
        {

            List<Producto> listaProducto = new List<Producto>();

            SqlConnection sqlconnection = conexion.obtenerConexion();
            sqlconnection.Open();
            SqlCommand sqlcommand = new SqlCommand("SELECT p.*, g.* from Producto p, Garantia g where p.id_garantia = g.id_garantia;", sqlconnection);

            SqlDataReader reader;
            reader = sqlcommand.ExecuteReader();

            while (reader.Read())
            {

                Producto producto = new Producto();


                producto.idProducto = Convert.ToInt32(reader["id_producto"].ToString());
                producto.nombre = reader["nombre"].ToString();
                producto.precio = Convert.ToDouble(reader["precio"]);
                producto.descripcion = reader["descripcion"].ToString();

                //Garantia
                Garantia garantia = new Garantia();
                garantia.idGarantia = Convert.ToInt32(reader["id_garantia"].ToString());
                garantia.validez = reader["validez"].ToString();

                producto.garantia = garantia;

                listaProducto.Add(producto);


            }

            sqlconnection.Close();


            return listaProducto;
        }

    }
}
