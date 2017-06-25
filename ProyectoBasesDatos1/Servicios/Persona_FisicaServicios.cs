using ProyectoBasesDatos1.AccesoDatos;
using ProyectoBasesDatos1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBasesDatos1.Servicios
{
    class Persona_FisicaServicios
    {
        Persona_FisicaDatos personaFisicaDatos = new Persona_FisicaDatos();
        public List<Persona_Fisica> getPersonasFisicas()
        {

            return personaFisicaDatos.getPersonasFisicas();
        }
    }
}
