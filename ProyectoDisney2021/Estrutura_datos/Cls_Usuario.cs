using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDisney2021.Estrutura_datos
{
    class Cls_Usuario
    {
        //Se crear los atributos necesarios para el ingreso de informacion  
        string nombreUsuario { get; set; }
        string correoUsuario { get; set; }
        string contraseñaUsuario { get; set; }
        string nombreCompleto { get; set; }


        //Constructor vacio
        public Cls_Usuario() { }

        public Cls_Usuario(string nombreUsuario,string correoUsuario,string contraseñaUsuario,string nombreCompleto)
        {
            this.nombreUsuario = nombreUsuario;
            this.correoUsuario = correoUsuario;
            this.contraseñaUsuario = contraseñaUsuario;
            this.nombreCompleto = nombreCompleto;     
        }

        public override string ToString()
        {
            return nombreUsuario + correoUsuario + contraseñaUsuario + nombreCompleto;
        }
    }
}
