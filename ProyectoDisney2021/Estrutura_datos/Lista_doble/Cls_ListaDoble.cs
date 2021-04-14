using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoDisney2021.Estrutura_datos.Usuario;
using ProyectoDisney2021.Estrutura_datos.Usuario.Administrador;

namespace ProyectoDisney2021.Estrutura_datos.Lista_doble
{
  public class Cls_ListaDoble
    {
        public Cls_NodoDoble inicio, fin, Temp;

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

        //Busca el correo y la contraseña del usuario
        public Cls_NodoDoble buscarUsuario(object codigoUsuario)
        {
            ComparadorUsuario dato;
            dato = (ComparadorUsuario)codigoUsuario;
            return buscarUsuario (dato, inicio);          
        }
        protected Cls_NodoDoble buscarUsuario(ComparadorUsuario codigoUsuario, Cls_NodoDoble usuario)
        {
            if (usuario == null)
            {
                //throw new Exception("No encontrado el nodo con la clave");
                return null;
            }
            else
            {
                if (codigoUsuario.correoIgual(usuario.valorNodo()) && codigoUsuario.contraseñaIgual(usuario.valorNodo()))
                    return usuario;
                else
                    return buscarUsuario(codigoUsuario, usuario.siguienteNodo);
            }

        }
        //Solo busca el correo de la persona

        public Cls_NodoDoble buscarCorreo(object codigoUsuario)
        {
            ComparadorUsuario dato;
            dato = (ComparadorUsuario)codigoUsuario;
            return buscarCorreo(dato, inicio);
            //return buscar(dato, inicio);
        }

        protected Cls_NodoDoble buscarCorreo(ComparadorUsuario códigoUsuario, Cls_NodoDoble usuario)
        {
            if (usuario == null)
            {
                //throw new Exception("No encontrado el nodo con la clave");
                return null;
            }
            else
            {
                if (códigoUsuario.usuarioIgual(usuario.valorNodo())|| códigoUsuario.correoIgual(usuario.valorNodo()))
                    return usuario;
                else
                    return buscarCorreo(códigoUsuario, usuario.siguienteNodo);
            }
        }




        //Busca el correo y la contraseña del administrador
        public Cls_NodoDoble buscarAdmi(object codigo)
        {
            ComparadorAdmin dato;
            dato = (ComparadorAdmin)codigo;
            return buscarAdmi(dato, inicio);
            //return buscar(dato, inicio);
        }

        protected Cls_NodoDoble buscarAdmi(ComparadorAdmin código, Cls_NodoDoble usuario)
        {
            if (usuario == null)
            {
                //throw new Exception("No encontrado el nodo con la clave");
                return null;
            }
            else
            {
                if (código.admiCorreoIgual(usuario.valorNodo()) && código.admiContraseñaIgual(usuario.valorNodo()))
                    return usuario;
                else
                    return buscarAdmi(código, usuario.siguienteNodo);
            }


        }

        //Busqueda de correo para la cuenta administrado
        public Cls_NodoDoble buscarCorreoAdmi(object codigo)
        {
            ComparadorAdmin dato;
            dato = (ComparadorAdmin)codigo;
            return buscarCorreoAdmi(dato, inicio);
            //return buscar(dato, inicio);
        }

        protected Cls_NodoDoble buscarCorreoAdmi(ComparadorAdmin código, Cls_NodoDoble usuario)
        {
            if (usuario == null)
            {
                //throw new Exception("No encontrado el nodo con la clave");
                return null;
            }
            else
            {
                if (código.admiCorreoIgual(usuario.valorNodo())|| código.adminUsuarioIgual(usuario.valorNodo()))
                    return usuario;
                else
                    return buscarCorreoAdmi(código, usuario.siguienteNodo);
            }

        }
        public Cls_NodoDoble mostrar()
        {
            return (Cls_NodoDoble)inicio.valorNodo();

        }

    }
}
