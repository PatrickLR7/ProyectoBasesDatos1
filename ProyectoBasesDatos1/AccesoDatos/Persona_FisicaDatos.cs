using ProyectoBasesDatos1.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBasesDatos1.AccesoDatos
{
    class Persona_FisicaDatos
    {
        private AccesoBaseDatos conexion = new AccesoBaseDatos();
        public List<Persona_Fisica> getPersonasFisicas()
        {

            List<Persona_Fisica> listaPersonasFisicas = new List<Persona_Fisica>();

            SqlConnection sqlconnection = conexion.obtenerConexion();
            sqlconnection.Open();
            SqlCommand sqlcommand = new SqlCommand("SELECT s.* from Persona_Fisica s;", sqlconnection);

            SqlDataReader reader;
            reader = sqlcommand.ExecuteReader();

            while (reader.Read())
            {

                Persona_Fisica personaFisica = new Persona_Fisica();

                personaFisica.identificacion = Convert.ToInt32(reader["identificacion"].ToString());
                personaFisica.nombre = reader["Primer_nombre"].ToString();
                personaFisica.apellido1 = reader["Apellido1"].ToString();
                personaFisica.apellido2 = reader["Apellido2"].ToString();
                personaFisica.sexo = reader["Sexo"].ToString();

                //Persona persona = new Persona();

                //persona.identificacion = Convert.ToInt32(reader["identificacion"].ToString());
                //persona.tipoPersona = Convert.ToInt32(reader["tipo_persona"].ToString());

                //usuario.persona = persona;

                listaPersonasFisicas.Add(personaFisica);


            }

            sqlconnection.Close();


            return listaPersonasFisicas;
        }
    }
}
