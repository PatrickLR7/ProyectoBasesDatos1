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
        Persona_FisicaServicios personaFisicaServicios = new Persona_FisicaServicios();
        Persona_JuridicaServicios personaJuridicaServicios = new Persona_JuridicaServicios();
        AccesoBaseDatos ad = new AccesoBaseDatos();
        SqlConnection conexionTec = new SqlConnection();
        int tipoPersonaInsertar = 0; //1 = Física, 2 = Jurídica
        public VentanaVendedor()
        {
            InitializeComponent();
            conexionTec = ad.obtenerConexion();
            menuStrip1.Visible = false;
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

        private void AgregarCliente_Click(object sender, EventArgs e)
        {
            PanelInsertarEliminar.Visible = true;
            menuStrip1.Visible = true;
            InsertarCliente.Visible = true;
            label_IdCliente.Visible = false;
            textBoxId_Cliente.Visible = false;
            btnBorrarCliente.Visible = false;
        }

        private void personaFísicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LabelNombre.Visible = true;
            LabelApellido1.Visible = true;
            LabelApellido2.Visible = true;
            textBoxNombre.Visible = true;
            textBoxApellido1.Visible = true;
            textBoxApellido2.Visible = true;
            tipoPersonaInsertar = 1;
        }

        private int getTipoPersona()
        {
            return tipoPersonaInsertar;
        }

        private void personaJurídicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LabelNombre.Visible = true;
            textBoxNombre.Visible = true;
            LabelApellido1.Visible = false;
            LabelApellido2.Visible = false;
            textBoxApellido1.Visible = false;
            textBoxApellido2.Visible = false;
            tipoPersonaInsertar = 2;
        }

        private void InsertarCliente_Click(object sender, EventArgs e)
        {
            List<Cliente> listaClientes = new List<Cliente>();
            listaClientes = clienteServicios.getClientes();
            List<Persona_Fisica> listaPersonasFisicas = new List<Persona_Fisica>();
            listaPersonasFisicas = personaFisicaServicios.getPersonasFisicas();
            List<Persona_Juridica> listaPersonasJuridicas = new List<Persona_Juridica>();
            listaPersonasJuridicas = personaJuridicaServicios.getPersonasJuridicas();
            int identificacion = -1;
            SqlCommand comandoSQL = new SqlCommand();
            string nombreText = "";
            string apellido1Text = "";
            string apellido2Text = "";
            int idCliente = -1;

            conexionTec.Open();
            if(tipoPersonaInsertar == 0) {
                MessageBox.Show("Por favor seleccione un tipo de cliente. ");
            }
            else if (tipoPersonaInsertar == 1) { 
                //PersonaFisica
                if (!(textBoxNombre.Text.Equals("")) || !(textBoxApellido1.Text.Equals("")) || !(textBoxApellido2.Text.Equals("")))
                {
                    nombreText = textBoxNombre.Text;
                    apellido1Text = textBoxApellido1.Text;
                    apellido2Text = textBoxApellido2.Text;
                    for (int i = 0; i < listaPersonasFisicas.Count; i++)
                    {
                        if (listaPersonasFisicas[i].nombre.Equals(nombreText) && listaPersonasFisicas[i].apellido1.Equals(apellido1Text) && listaPersonasFisicas[i].apellido2.Equals(apellido2Text))
                        {
                            identificacion = listaPersonasFisicas[i].identificacion;
                            listaClientes = clienteServicios.getClientes();
                            idCliente = listaClientes.Max(r => r.id_cliente)+1;
                        }
                    }

                    if (identificacion != -1)
                    {
                        //Insert
                        comandoSQL.CommandText = "Insert into Cliente values ('"+ idCliente +"', '"+ identificacion +"')"; 
                        comandoSQL.Connection = conexionTec;
                        comandoSQL.CommandType = CommandType.Text;
                        comandoSQL.ExecuteNonQuery();
                        MessageBox.Show("Cliente insertado correctamente. Haga click en el boton de consulta respectivo para verificar.");
                    }
                    else
                    {
                       MessageBox.Show("El cliente que está intentando insertar no se encuentra registrado en las personas de la base de datos.");
                    }
                    
                }
                else
                {
                    MessageBox.Show("Por favor, rellene todos los campos (Nombre, Apellido1 y Apellido2)");
                }
            } else if(tipoPersonaInsertar == 2)
            {
                //PersonaJuridica
                if (!(textBoxNombre.Text.Equals("")))
                {
                    nombreText = textBoxNombre.Text;
                    for (int i = 0; i < listaPersonasJuridicas.Count; i++)
                    {
                        if (listaPersonasJuridicas[i].nombre.Equals(nombreText))
                        {
                            identificacion = listaPersonasJuridicas[i].identificacion;
                            listaClientes = clienteServicios.getClientes();
                            idCliente = listaClientes.Max(r => r.id_cliente) + 1;
                        }
                    }
                    if (identificacion != -1)
                    {
                        //Insert
                        comandoSQL.CommandText = "Insert into Cliente values ('"+idCliente+"', '"+identificacion+"')"; 
                        comandoSQL.Connection = conexionTec;
                        comandoSQL.CommandType = CommandType.Text;
                        comandoSQL.ExecuteNonQuery();
                        MessageBox.Show("Cliente insertado correctamente. Haga click en el boton de consulta respectivo para verificar.");
                    }
                    else
                    {
                        MessageBox.Show("El cliente que está intentando insertar no se encuentra registrado en las personas de la base de datos.");
                    }
                } else
                {
                    MessageBox.Show("Por favor, rellene el campo 'Nombre'.");
                }
            }
            conexionTec.Close();
        }

        private void EliminarCliente_Click(object sender, EventArgs e)
        {
            PanelInsertarEliminar.Visible = true;
            label_IdCliente.Visible = true;
            textBoxId_Cliente.Visible = true;
            btnBorrarCliente.Visible = true;
            menuStrip1.Visible = false;
            InsertarCliente.Visible = false;
            LabelNombre.Visible = false;
            LabelApellido1.Visible = false;
            LabelApellido2.Visible = false;
            textBoxNombre.Visible = false;
            textBoxApellido1.Visible = false;
            textBoxApellido2.Visible = false;
        }

        private void btnBorrarCliente_Click(object sender, EventArgs e)
        {
            SqlCommand comandoSQL = new SqlCommand();
            int idABorrar;
            bool idEncontrado = false;
            List<Cliente> listaClientes = new List<Cliente>();
            listaClientes = clienteServicios.getClientes();
            conexionTec.Open();
            if (!textBoxId_Cliente.Text.Equals(""))
            {
                for(int i = 0; i < listaClientes.Count; i++)
                {
                    if(listaClientes[i].id_cliente == Convert.ToInt32(textBoxId_Cliente.Text))
                    {
                        idEncontrado = true;
                    }
                }
                if(idEncontrado == true) {
                    idABorrar = Convert.ToInt32(textBoxId_Cliente.Text);
                    comandoSQL.CommandText = "Delete from Cliente where Id_cliente = @idBorrar";
                    comandoSQL.Parameters.AddWithValue("@idBorrar", idABorrar);
                    comandoSQL.Connection = conexionTec;
                    comandoSQL.CommandType = CommandType.Text;
                    comandoSQL.ExecuteNonQuery();
                    MessageBox.Show("Cliente eliminado correctamente. Haga click en el boton de consulta respectivo para verificar.");
                }
                else
                {
                    MessageBox.Show("El id insertado no está en la lista de clientes. ");
                }
            }
            else
            {
                MessageBox.Show("Inserte un valor en el campo Id_Cliente.");
            }
            conexionTec.Close();

        }

        private void SalirVendedor_Click(object sender, EventArgs e)
        {
            this.Refresh();
            this.Visible = false;
        }
    }
}
