using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoBasesDatos1.Entidades;
using ProyectoBasesDatos1.Servicios;

namespace ProyectoBasesDatos1
{
    public partial class VentanaCajero : Form
    {
        FacturaServicios facturaServicios = new FacturaServicios();
        public VentanaCajero()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Factura> listaFacturas = new List<Factura>();
            listaFacturas = facturaServicios.getFacturas();
            richTextBox1.Text += "id_factura | monto_total | fecha_compra | id cliente | id_empleado" + Environment.NewLine + Environment.NewLine;
            for (int i = 0; i < listaFacturas.Count(); i++)
            {
                richTextBox1.Text += listaFacturas[i].id_factura + " " + listaFacturas[i].monto_total +
                    " " + listaFacturas[i].fecha_compra.ToString("dd/MM/yyyy") + " " + listaFacturas[i].id_cliente + " " +
                    listaFacturas[i].id_empleado + Environment.NewLine;
            }
        }
    }
}
