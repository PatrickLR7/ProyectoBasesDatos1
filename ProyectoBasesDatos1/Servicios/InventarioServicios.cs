using ProyectoBasesDatos1.AccesoDatos;
using ProyectoBasesDatos1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBasesDatos1.Servicios
{
   public class InventarioServicios
    {
        InventarioDatos inventarioDatos = new InventarioDatos();

        public List<Inventario> getInventario() {

            return inventarioDatos.getInventario();
        }

    }
}
