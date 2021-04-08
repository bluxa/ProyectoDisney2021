using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDisney2021.Estrutura_datos.Lista_simple
{
    public class ClsListaEnlazada
    {
        public ClsNodo cabeza;
        public ClsNodo primero;
        public int numeroElementos = 0;

        public ClsListaEnlazada()
        {
            cabeza = null;
            numeroElementos = 0;
        }

        public ClsListaEnlazada insertarDatoCabeza(object entrada)
        {
            ClsNodo nuevo;
            nuevo = new ClsNodo(entrada);
            nuevo.enlace = primero;
            primero = nuevo;
            numeroElementos++;
            return this;
        }

        public ClsNodo buscarDato(object destino)
        {
            ClsNodo indice;
            for (indice = primero; indice != null; indice = indice.enlace)
                if (destino == indice.dato)  //	(destino.equals(indice.dato))
                    return indice;
            return null;
        }
    }
}
