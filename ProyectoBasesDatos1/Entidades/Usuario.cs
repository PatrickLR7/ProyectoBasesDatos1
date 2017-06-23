using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBasesDatos1.Entidades
{
    public class Usuario
    {
      public int idUsuario{ get; set; }
      public  Persona persona { get; set; }
      public int tipoUsuario { get; set; }
      public String contraseña { get; set; }
      public String nombre_Usuario { get; set; }
       
    }
}
