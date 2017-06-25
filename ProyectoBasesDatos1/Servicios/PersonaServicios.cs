using ProyectoBasesDatos1.AccesoDatos;
using ProyectoBasesDatos1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBasesDatos1.Servicios
{
    class PersonaServicios
    {
        PersonaDatos personaDatos = new PersonaDatos();
        public List<Persona> getUsuarios()
        {

            return personaDatos.getPersonas();
        }
    }
}
