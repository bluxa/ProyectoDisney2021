using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDisney2021.Estrutura_datos.Usuario.Administrador
{
   public interface ComparadorAdmin
    {
        bool adminUsuarioIgual(object q);
        bool admiCorreoIgual(object q);
        bool admiContraseñaIgual(object q);
    }
}
