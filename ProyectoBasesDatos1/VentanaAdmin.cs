using ProyectoBasesDatos1.Entidades;
using ProyectoBasesDatos1.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBasesDatos1
{
    public partial class VentanaAdmin : Form
    {
        FacturaServicios facturaServicios = new FacturaServicios();
        InventarioServicios inventarioServicios = new InventarioServicios();
        ProductoServicios productoServicios = new ProductoServicios();
        ClienteServicios clienteServicios = new ClienteServicios();
        public VentanaAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            List<Factura> listaFacturas = new List<Factura>();
            listaFacturas = facturaServicios.getFacturas();
            richTextBox1.Text += "id_factura | monto_total | fecha_compra | id cliente | id_empleado" + Environment.NewLine + Environment.NewLine;
            for(int i = 0; i < listaFacturas.Count(); i++)
            {
                richTextBox1.Text += listaFacturas[i].id_factura + " " + listaFacturas[i].monto_total +
                    " " + listaFacturas[i].fecha_compra.ToString("dd/MM/yyyy") + " " + listaFacturas[i].id_cliente + " " +
                    listaFacturas[i].id_empleado + Environment.NewLine;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Inventario> listaInventario = new List<Inventario>();
            listaInventario = inventarioServicios.getInventario();

            richTextBox1.Clear();
            richTextBox1.Text += "id_inventario | cantidad | nombre | precio | descripcion" + Environment.NewLine + Environment.NewLine;
            for (int i = 0; i < listaInventario.Count(); i++)
            {
                richTextBox1.Text += listaInventario[i].idInventario + " " + listaInventario[i].cantidad +
                    " " + listaInventario[i].producto.nombre + " " + listaInventario[i].producto.precio + " " +
                    listaInventario[i].producto.descripcion + Environment.NewLine;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            List<Producto> listaProductos = new List<Producto>();
            listaProductos = productoServicios.getProducto();
            richTextBox1.Text += "id_producto | nombre | precio | descripcion | id_garantia" + Environment.NewLine + Environment.NewLine;
            for (int i = 0; i < listaProductos.Count(); i++)
            {
                richTextBox1.Text += listaProductos[i].idProducto + " " + listaProductos[i].nombre +
                    " " + listaProductos[i].precio + " " + listaProductos[i].descripcion + " " +
                    listaProductos[i].garantia.validez + Environment.NewLine;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            List<Cliente> listaClientes = new List<Cliente>();
            listaClientes = clienteServicios.getClientes();
            richTextBox1.Text += "id_cliente | identificacion" + Environment.NewLine + Environment.NewLine;

            for (int i = 0; i < listaClientes.Count(); i++)
            {
                richTextBox1.Text += listaClientes[i].id_cliente + "                    " + listaClientes[i].identificacion + Environment.NewLine;
            }
        }
    }
}
