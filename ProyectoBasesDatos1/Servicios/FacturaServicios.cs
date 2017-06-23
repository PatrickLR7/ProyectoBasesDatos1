using ProyectoBasesDatos1.AccesoDatos;
using ProyectoBasesDatos1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBasesDatos1.Servicios
{
    class FacturaServicios
    {
        FacturaDatos facturaDatos = new FacturaDatos();
        public List<Factura> getFacturas()
        {

            return facturaDatos.getFacturas();
        }
    }
}
