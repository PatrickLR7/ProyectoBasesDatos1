using ProyectoBasesDatos1.AccesoDatos;
using ProyectoBasesDatos1.Entidades;
using ProyectoBasesDatos1.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        AccesoBaseDatos ad = new AccesoBaseDatos();
        SqlConnection conexionTec = new SqlConnection();
        public VentanaVendedor()
        {
            InitializeComponent();
            conexionTec = ad.obtenerConexion();
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

        private void ConsultClientesFi_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            SqlCommand recuperaClientesF = new SqlCommand("select pf.Identificacion, pf.Primer_nombre," +
                "pf.Apellido1, pf.Apellido2, c.Id_cliente from Persona_Fisica pf, Cliente c " +
                "where c.Identificacion = pf.Identificacion;", conexionTec);
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = recuperaClientesF;
                DataTable clientesFBD = new DataTable();
                sda.Fill(clientesFBD);
                BindingSource bSource1 = new BindingSource();

                bSource1.DataSource = clientesFBD;
                dataGridView1.DataSource = bSource1;
                sda.Update(clientesFBD);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ConsultClientesJu_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            SqlCommand recuperaClientesJu = new SqlCommand("select pju.Identificacion, pju.Nombre," +
                "c.Id_cliente from Persona_Juridica pju, Cliente c " +
                "where c.Identificacion = pju.Identificacion;", conexionTec);
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = recuperaClientesJu;
                DataTable clientesJuBD = new DataTable();
                sda.Fill(clientesJuBD);
                BindingSource bSource1 = new BindingSource();

                bSource1.DataSource = clientesJuBD;
                dataGridView1.DataSource = bSource1;
                sda.Update(clientesJuBD);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
