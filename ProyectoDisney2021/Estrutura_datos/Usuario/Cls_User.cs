using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDisney2021.Estrutura_datos.Usuario
{
   public class Cls_User:ComparadorUsuario
    {

        //Se crear los atributos necesarios para el ingreso de informacion  
        public string usuarioUser { get; set; }
        public string nombreUsuario { get; set; }
        public string correoUsuario { get; set; }
        public string contraseñaUsuario { get; set; }
        public string tarjetaUsuario { get; set; }
        public string codigoTarUsuario { get; set; }
        public string direccionUsuario { get; set; }
        public string avarUsuario{ get; set; }

        //Constructor vacio
        public Cls_User() { }


        //Contructor General
        public Cls_User(string usuarioUser, string nombreUsuario, string correoUsuario,
            string contraseñaUsuario, string tarjetaUsuario, string codigoTarUsuario, string direccionUsuario,string avarUsuario
            )
        {
            this.usuarioUser = usuarioUser;
            this.nombreUsuario = nombreUsuario;
            this.correoUsuario = correoUsuario;
            this.contraseñaUsuario = contraseñaUsuario;
            this.tarjetaUsuario = tarjetaUsuario;
            this.codigoTarUsuario = codigoTarUsuario;
            this.direccionUsuario = direccionUsuario;
            this.avarUsuario = avarUsuario;

        }

        public Cls_User(string contraseñaUser,string correoUser) {

            this.contraseñaUsuario = contraseñaUser;
            this.correoUsuario = correoUser;

        }
       
        //Compara que la contraseña introducida se igual a la introducida
        public bool contraseñaIgual(object q)
        {
            Cls_User us2 = (Cls_User)q;
            if (contraseñaUsuario.CompareTo(us2.contraseñaUsuario) == 0)
                return true;
            else
                return false;
        }

        public bool usuarioIgual(object q)
        {
            Cls_User us2 = (Cls_User)q;
            if (usuarioUser.CompareTo(us2.usuarioUser) == 0)
                return true;
            else
                return false;
        }

        public bool correoIgual(object q) 
        {
            Cls_User us2 = (Cls_User)q;
            if (correoUsuario.CompareTo(us2.correoUsuario) == 0)
                return true;
            else
                return false;

        }


        public bool nombrePeliculaIgual(object q)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return "" + usuarioUser + "" + "&" + nombreUsuario + "&" + correoUsuario + "&" + avarUsuario;
        }


        public object MostrarInformacion()
        {
            return correoUsuario + contraseñaUsuario;
        }
    }
}
