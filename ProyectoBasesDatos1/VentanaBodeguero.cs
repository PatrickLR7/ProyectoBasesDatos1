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
    public partial class VentanaBodeguero : Form
    {

        InventarioServicios inventarioServicios = new InventarioServicios();
        public VentanaBodeguero()
        {
            InitializeComponent();
        }

        private void VentanaBodeguero_Load(object sender, EventArgs e)
        {
            List<Inventario> listaInventario = new List<Inventario>();
            listaInventario = inventarioServicios.getInventario();

           
            richTextBox1.Text += "id_inventario | cantidad | nombre | precio | descripcion" + Environment.NewLine + Environment.NewLine;
            for (int i = 0; i < listaInventario.Count(); i++)
            {
                richTextBox1.Text += listaInventario[i].idInventario + " " + listaInventario[i].cantidad +
                    " " + listaInventario[i].producto.nombre + " " + listaInventario[i].producto.precio + " " +
                    listaInventario[i].producto.descripcion + Environment.NewLine;
            }

        }
    }
}
