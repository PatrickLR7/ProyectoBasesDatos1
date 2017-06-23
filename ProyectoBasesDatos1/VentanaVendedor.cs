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
    public partial class VentanaVendedor : Form
    {
        ClienteServicios clienteServicios = new ClienteServicios();
        public VentanaVendedor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
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
