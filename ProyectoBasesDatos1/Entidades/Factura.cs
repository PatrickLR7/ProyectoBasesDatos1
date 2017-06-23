using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBasesDatos1.Entidades
{
    class Factura
    {
        
        public int id_factura { get; set; }
        public double monto_total { get; set; }

        public DateTime fecha_compra { get; set; }

        public int id_cliente { get; set; }

        public int id_empleado { get; set; }
    }
}
