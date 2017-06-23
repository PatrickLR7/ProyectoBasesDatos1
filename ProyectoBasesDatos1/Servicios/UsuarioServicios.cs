using ProyectoBasesDatos1.AccesoDatos;
using ProyectoBasesDatos1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBasesDatos1.Servicios
{
    public class UsuarioServicios
    {
        UsuarioDatos usuarioDatos = new UsuarioDatos();
        public List<Usuario> getUsuarios() {

            return usuarioDatos.getUsuarios();
        }
    }
}
