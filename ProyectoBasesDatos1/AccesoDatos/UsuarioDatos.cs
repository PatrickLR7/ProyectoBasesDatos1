using ProyectoBasesDatos1.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBasesDatos1.AccesoDatos
{
    public class UsuarioDatos
    {
        private AccesoBaseDatos conexion = new AccesoBaseDatos();
        

        public List<Usuario> getUsuarios() {

            List<Usuario> listaUsuarios = new List<Usuario>();

            SqlConnection sqlconnection = conexion.obtenerConexion();
            sqlconnection.Open();
            SqlCommand sqlcommand = new SqlCommand("SELECT s.* from Usuario s, Persona p where s.identificacion = p.identificacion ;", sqlconnection);

            SqlDataReader reader;
            reader = sqlcommand.ExecuteReader();

            while (reader.Read())  {

                Usuario usuario = new Usuario();

                usuario.idUsuario = Convert.ToInt32(reader["id_usuario"].ToString());
                usuario.tipoUsuario = Convert.ToInt32(reader["tipo_usuario"].ToString());
                usuario.contraseña = reader["contraseña"].ToString();
                usuario.nombre_Usuario = reader["nombre_usuario"].ToString();

                //Persona persona = new Persona();

                //persona.identificacion = Convert.ToInt32(reader["identificacion"].ToString());
                //persona.tipoPersona = Convert.ToInt32(reader["tipo_persona"].ToString());

                //usuario.persona = persona;

                listaUsuarios.Add(usuario);


            }

            sqlconnection.Close();


            return listaUsuarios;
        }

    }
}
