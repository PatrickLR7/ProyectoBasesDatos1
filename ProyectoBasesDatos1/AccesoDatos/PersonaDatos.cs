using ProyectoBasesDatos1.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBasesDatos1.AccesoDatos
{
    class PersonaDatos
    {
        private AccesoBaseDatos conexion = new AccesoBaseDatos();
        public List<Persona> getPersonas()
        {

            List<Persona> listaPersonas = new List<Persona>();

            SqlConnection sqlconnection = conexion.obtenerConexion();
            sqlconnection.Open();
            SqlCommand sqlcommand = new SqlCommand("SELECT s.* from Persona s;", sqlconnection);

            SqlDataReader reader;
            reader = sqlcommand.ExecuteReader();

            while (reader.Read())
            {

                Persona persona = new Persona();

                persona.identificacion = Convert.ToInt32(reader["identificacion"].ToString());
                persona.tipoPersona = Convert.ToInt32(reader["Tipo_persona"].ToString());

                //Persona persona = new Persona();

                //persona.identificacion = Convert.ToInt32(reader["identificacion"].ToString());
                //persona.tipoPersona = Convert.ToInt32(reader["tipo_persona"].ToString());

                //usuario.persona = persona;

                listaPersonas.Add(persona);


            }

            sqlconnection.Close();


            return listaPersonas;
        }
    }
}
