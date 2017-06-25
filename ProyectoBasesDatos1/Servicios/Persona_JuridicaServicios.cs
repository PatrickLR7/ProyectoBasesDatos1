using ProyectoBasesDatos1.AccesoDatos;
using ProyectoBasesDatos1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBasesDatos1.Servicios
{
    class Persona_JuridicaServicios
    {
        Persona_JuridicaDatos personaJuridicaDatos = new Persona_JuridicaDatos();
        public List<Persona_Juridica> getPersonasJuridicas()
        {

            return personaJuridicaDatos.getPersonasJuridicas();
        }
    }
}
