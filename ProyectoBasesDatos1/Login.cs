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
    public partial class Login : Form
    {
        UsuarioServicios usuarioServicios = new UsuarioServicios();
        public Login()
        {
            InitializeComponent();
           

        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            List<Usuario> listaUsuarios = new List<Usuario>();
            listaUsuarios = usuarioServicios.getUsuarios();
            int tipoUsuario = 0;
            bool uEncontrado = false;

            
            foreach (Usuario u in listaUsuarios) {
                if (u.nombre_Usuario == textBox1.Text)
                {
                    uEncontrado = true;
                    if (u.contraseña == textBox2.Text)
                    {                 

                        tipoUsuario = u.tipoUsuario;
                       

                    }
                    else
                    {
                        MessageBox.Show("Usuario y/o contraseña incorrectos."); //Contraseña incorrecta
                    }
                }
            }
            if (!uEncontrado)
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos."); //Usuario incorrecto
            }


            switch (tipoUsuario) {

                case 1:

                    VentanaVendedor vV = new VentanaVendedor();

                    vV.Show();
                    vV.AutoScrollPosition = new Point(0, 0);
                    break;

                case 2:

                    VentanaCajero vC = new VentanaCajero();

                    vC.Show();

                    break;

                case 3:

                    VentanaBodeguero vB = new VentanaBodeguero();

                    vB.Show();

                    break;

                case 4:

                    VentanaAdmin vA = new VentanaAdmin();

                    vA.Show();

                    break;

                case 5:

                    VentanaCliente vCl = new VentanaCliente();

                    vCl.Show();

                    break;
            }
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
