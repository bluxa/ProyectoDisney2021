using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDisney2021.Estrutura_datos.Lista_doble
{
    public class Cls_NodoDoble
    {
        //Se crea dos variables de tipo nodo publico
        public Cls_NodoDoble siguienteNodo;
        public Cls_NodoDoble anterioNodo;

        //Variable para la insercion de la informacion
        public object datoNodo;

        //Contructores
        
        public Cls_NodoDoble(object datoEntrada) 
        {
            datoNodo = datoEntrada;
            siguienteNodo = anterioNodo = null;       
        }

        public Cls_NodoDoble(object datoEntrada, Cls_NodoDoble principioNodo,Cls_NodoDoble ultimoNodo)       
        {
            datoNodo = datoEntrada;
            siguienteNodo = principioNodo;
            anterioNodo = ultimoNodo;
        }



        public object valorNodo()
        {
            return datoNodo;
        }
        public string visitar()
        {
            return datoNodo.ToString();
        }
    }
}
