using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBasesDatos1.Entidades
{
   public class Producto
    {
        public int idProducto { get; set; }
        public String nombre { get; set; }
        public Double precio { get; set; }
        public String descripcion { get; set; }
        public Garantia garantia { get; set; }

    }
}
