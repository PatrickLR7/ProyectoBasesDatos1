using ProyectoBasesDatos1.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBasesDatos1.AccesoDatos
{
    public class InventarioDatos
    {
        private AccesoBaseDatos conexion = new AccesoBaseDatos();


        public List<Inventario> getInventario()
        {

            List<Inventario> listaInventario = new List<Inventario>();

            SqlConnection sqlconnection = conexion.obtenerConexion();
            sqlconnection.Open();
            SqlCommand sqlcommand = new SqlCommand("SELECT i.*, p.*, g.*  from Inventario i, Producto p, Garantia g where i.id_producto = p.id_producto and p.id_garantia = g.id_garantia;", sqlconnection);

            SqlDataReader reader;
            reader = sqlcommand.ExecuteReader();

            while (reader.Read())
            {

                Inventario inventario = new Inventario();


                inventario.idInventario = Convert.ToInt32(reader["id_inventario"].ToString());
                inventario.cantidad = Convert.ToInt32(reader["cantidad"].ToString());

                //Producto
                Producto producto = new Producto();

                producto.idProducto = Convert.ToInt32(reader["id_producto"].ToString());
                producto.nombre = reader["nombre"].ToString();
                producto.precio = Convert.ToDouble(reader["precio"].ToString());
                producto.descripcion = reader["descripcion"].ToString();

                //Garantia
                Garantia garantia = new Garantia();

                garantia.idGarantia = Convert.ToInt32(reader["id_garantia"].ToString());
                garantia.validez = reader["validez"].ToString();

                producto.garantia = garantia;
                inventario.producto = producto;
                

                listaInventario.Add(inventario);


            }

            sqlconnection.Close();


            return listaInventario;
        }

    }
}
