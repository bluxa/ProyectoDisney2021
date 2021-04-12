using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDisney2021.Estrutura_datos.Usuario
{
   public interface ComparadorUsuario
    {
        bool usuarioIgual(object q);
        bool contraseñaIgual(object q);
        bool correoIgual(object q);

        bool nombrePeliculaIgual(object q);
    }
}
