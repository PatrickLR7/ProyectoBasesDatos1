using ProyectoBasesDatos1.AccesoDatos;
using ProyectoBasesDatos1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBasesDatos1.Servicios
{
   class ProductoServicios
    {
        ProductoDatos productoDatos = new ProductoDatos();
        public List<Producto> getProducto()
        {

            return productoDatos.getProducto();
        }
    }
}
