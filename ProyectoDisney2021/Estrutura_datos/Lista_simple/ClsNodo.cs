using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDisney2021.Estrutura_datos.Lista_simple
{
    public class ClsNodo
    {
        public object dato;
        public ClsNodo enlace;

        public ClsNodo(object x)
        {
            dato = x;
            enlace = null;
        }

        public ClsNodo(object x, ClsNodo n)
        {
            dato = x;
            enlace = n;
        }
    }
}
