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
    public partial class VentanaCliente : Form
    {
        ProductoServicios productoServicios = new ProductoServicios();
        public VentanaCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
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
    }
}
