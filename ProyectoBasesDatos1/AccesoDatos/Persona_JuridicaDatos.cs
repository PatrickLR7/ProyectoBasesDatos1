using ProyectoBasesDatos1.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBasesDatos1.AccesoDatos
{
    class Persona_JuridicaDatos
    {
        private AccesoBaseDatos conexion = new AccesoBaseDatos();
        public List<Persona_Juridica> getPersonasJuridicas()
        {

            List<Persona_Juridica> listaPersonasJuridicas = new List<Persona_Juridica>();

            SqlConnection sqlconnection = conexion.obtenerConexion();
            sqlconnection.Open();
            SqlCommand sqlcommand = new SqlCommand("SELECT s.* from Persona_Juridica s;", sqlconnection);

            SqlDataReader reader;
            reader = sqlcommand.ExecuteReader();

            while (reader.Read())
            {

                Persona_Juridica personaJuridica = new Persona_Juridica();

                personaJuridica.identificacion = Convert.ToInt32(reader["identificacion"].ToString());
                personaJuridica.nombre = reader["Nombre"].ToString();

                //Persona persona = new Persona();

                //persona.identificacion = Convert.ToInt32(reader["identificacion"].ToString());
                //persona.tipoPersona = Convert.ToInt32(reader["tipo_persona"].ToString());

                //usuario.persona = persona;

                listaPersonasJuridicas.Add(personaJuridica);


            }

            sqlconnection.Close();


            return listaPersonasJuridicas;
        }
    }
}
