using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDisney2021.Estrutura_datos.Usuario.Administrador
{
  public  class Cls_UsuarioAdmin:ComparadorAdmin
    {
        public string CorreoAdmin { get; set; }
        public string contraseñaAdmin { get; set; }
        public string usuarioAdmin { get; set; }

        public Cls_UsuarioAdmin()
        {
        }

        public Cls_UsuarioAdmin(string usuarioAdmin, string contraseñaAdmin,string correoAdmin)
        {
            this.CorreoAdmin= correoAdmin;
            this.contraseñaAdmin = contraseñaAdmin;
            this.usuarioAdmin = usuarioAdmin;

        }

        public bool admiCorreoIgual(object q)
        {
            Cls_UsuarioAdmin us2 = (Cls_UsuarioAdmin)q;
            if (CorreoAdmin.CompareTo(us2.CorreoAdmin) == 0)
                return true;
            else
                return false;
        }

        public bool admiContraseñaIgual(object q)
        {
            Cls_UsuarioAdmin us2 = (Cls_UsuarioAdmin)q;
            if (contraseñaAdmin.CompareTo(us2.contraseñaAdmin) == 0)
                return true;
            else
                return false;
        }


        public bool adminUsuarioIgual(object q)
        {
            Cls_UsuarioAdmin us2 = (Cls_UsuarioAdmin)q;
            if (usuarioAdmin.CompareTo(us2.usuarioAdmin) == 0)
                return true;
            else
                return false;
        }


    }
}
