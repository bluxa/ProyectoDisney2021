using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDisney2021.Estrutura_datos.Lista_doble
{
  public class Cls_ListaDoble
    {
        public Cls_NodoDoble inicio, fin;

        public Cls_ListaDoble()
        {
            inicio = fin = null;
        }

        /*Metodo para ver si la lista esta vacia*/

        public Boolean Listavacia()
        {
            return inicio == null;
        }

        /*Metodo para agregar nodos al final*/

        public void insertarAlFinal(object n)
        {
            if (!Listavacia())
            {
                fin = new Cls_NodoDoble(n, null, fin);
                fin.anterioNodo.siguienteNodo = fin;
            }
            /*Esta vacia*/

            else
            {
                inicio = fin = new Cls_NodoDoble(n);
            }

        }

        /*Insertar al inicio de la lista*/
        public void insertarAlInicio(object n)
        {
            if (!Listavacia())
            {
                inicio = new Cls_NodoDoble(n, inicio, null);
                inicio.siguienteNodo.anterioNodo = inicio;
            }
            /*Esta vacia*/

            else
            {
                inicio = fin = new Cls_NodoDoble(n);
            }

        }

        /*Quita el dato del inicio de la lista doblemente enlazada*/
        public object QuitarDatoInicio()
        {
            object dato = inicio.datoNodo;

            if (inicio == fin)
            {
                inicio = fin = null;
            }

            else
            {
                inicio = inicio.siguienteNodo;
                inicio.siguienteNodo = null;

            }

            return dato;

        }

        /*Quita el dato del final de la lista doblemente enlazada*/
        public object QuitarDatoFinal()
        {
            object dato = fin.datoNodo;

            if (inicio == fin)
            {
                inicio = fin = null;
            }

            else
            {
                fin = fin.anterioNodo;
                fin.siguienteNodo = null;
            }

            return dato;
        }
    }
}
