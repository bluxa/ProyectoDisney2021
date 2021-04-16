using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDisney2021.Estrutura_datos.Pila
{
    public class ClsNodoPila
    {
        public Object Dato;
        public ClsNodoPila Siguiente;

        public ClsNodoPila()
        {
            Siguiente = null;
        }

        public ClsNodoPila(Object pDato)
        {
            Dato = pDato;
            Siguiente = null;
        }
    }
}
