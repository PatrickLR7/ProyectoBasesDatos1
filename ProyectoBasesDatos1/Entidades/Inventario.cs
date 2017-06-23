using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBasesDatos1.Entidades
{
    public class Inventario
    {
       public int idInventario { get; set; }
       public int cantidad { get; set; }
       public Producto producto { get; set; }
    }
}
