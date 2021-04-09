using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoDisney2021.Estrutura_datos.Lista_doble;
using ProyectoDisney2021.Estrutura_datos.Usuario.Administrador;

namespace ProyectoDisney2021.Estrutura_datos.Usuario
{
    class Cls_DatosUsuario
    {
        Cls_ListaDoble miLista;

        public Cls_DatosUsuario()
        {
            miLista = new Cls_ListaDoble();
        }

        public Cls_DatosUsuario(Cls_ListaDoble miLista)
        {
            this.miLista = miLista;
        }
        public void insertarDatoUsuario(Cls_User miUsuario)
        {
            miLista.insertarAlFinal(miUsuario);
        }
        public void insertarDatoAdmin(Cls_UsuarioAdmin miAdmin)
        {
            miLista.insertarAlFinal(miAdmin);
        }
        public object buscarDatosCompletos(Cls_User miUsuario)
        {
            if (miLista.buscarUsuario(miUsuario) != null)
                return miLista.buscarUsuario(miUsuario).visitar();
            else
                return null;
        }
        public object buscarCorreo(Cls_User miUsuario)
        {
            if (miLista.buscarCorreo(miUsuario) != null)
                return miLista.buscarCorreo(miUsuario).visitar();
            else
                return null;
        }


        public object buscarDatosAdministrador(Cls_UsuarioAdmin miAdmin)
        {
            if (miLista.buscarAdmi(miAdmin) != null)
                return miLista.buscarAdmi(miAdmin).visitar();
            else
                return null;
        }

        public object buscarCorreoAdministrador(Cls_UsuarioAdmin miAdmin)
        {
            if (miLista.buscarCorreoAdmi(miAdmin) != null)
                return miLista.buscarCorreoAdmi(miAdmin).visitar();
            else
                return null;
        }

    }
}
