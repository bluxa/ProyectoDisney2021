using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ProyectoDisney2021.Estrutura_datos.Usuario.Administrador;

namespace ProyectoDisney2021.Estrutura_datos.Usuario
{
    public class InformacionTxt
    { 

        //Constructor vacio
        public InformacionTxt() { }


        //Metodo para lectura de los datos de un txt
        public void CargarDatos(ref Cls_User[] objUsuario)
        {
            StreamReader reader = new StreamReader("Usuarios.txt");
            int size = Convert.ToInt32(reader.ReadLine());
            objUsuario = new Cls_User[size];

            //Console.WriteLine("Prueba " + size);
            for (int index = 0; index < objUsuario.Length; index++)
            {
                objUsuario[index] = new Cls_User();
                objUsuario[index].usuarioUser = reader.ReadLine();
                objUsuario[index].nombreUsuario = reader.ReadLine();
                objUsuario[index].correoUsuario = reader.ReadLine();
                objUsuario[index].contraseñaUsuario = reader.ReadLine();
                objUsuario[index].tarjetaUsuario = reader.ReadLine();
                objUsuario[index].codigoTarUsuario = reader.ReadLine();
                objUsuario[index].direccionUsuario = reader.ReadLine();
                
            }
            reader.Close();
        }

        //Metodo para agregar un usuario
        public void AgregarUsuario(ref Cls_User[] objUsuario, string usuarioUser, string nombreUsuario, string correoUsuario,
            string contraseñaUsuario, string tarjetaUsuario, string codigoTarUsuario, string direccionUsuario)
        {
            StreamWriter writer = new StreamWriter("Usuarios.txt");

            writer.WriteLine(objUsuario.Length + 1);

            //Cls_Usuario[] miUsuarioNuevo = new Cls_Usuario[1];

            Cls_User temp = new Cls_User();

            for (int index = 0; index < objUsuario.Length; index++)
            {
                writer.WriteLine(objUsuario[index].usuarioUser);
                writer.WriteLine(objUsuario[index].nombreUsuario);
                writer.WriteLine(objUsuario[index].correoUsuario);
                writer.WriteLine(objUsuario[index].contraseñaUsuario);
                writer.WriteLine(objUsuario[index].tarjetaUsuario);
                writer.WriteLine(objUsuario[index].codigoTarUsuario);
                writer.WriteLine(objUsuario[index].direccionUsuario);
               

            }

            temp.usuarioUser = usuarioUser;
            temp.nombreUsuario = nombreUsuario;
            temp.correoUsuario = correoUsuario;
            temp.contraseñaUsuario = contraseñaUsuario;
            temp.tarjetaUsuario = tarjetaUsuario;
            temp.codigoTarUsuario = codigoTarUsuario;
            temp.direccionUsuario = direccionUsuario;
         
            writer.WriteLine(temp.usuarioUser);
            writer.WriteLine(temp.nombreUsuario);
            writer.WriteLine(temp.correoUsuario);
            writer.WriteLine(temp.contraseñaUsuario);
            writer.WriteLine(temp.tarjetaUsuario);
            writer.WriteLine(temp.codigoTarUsuario );
            writer.WriteLine(temp.direccionUsuario);
         
    
            writer.Close();
        }

        public void CargarDatosAdmi(ref Cls_UsuarioAdmin[] objAdmin)
        {
            StreamReader reader = new StreamReader("Administradores.txt");
            int size = Convert.ToInt32(reader.ReadLine());
            objAdmin = new Cls_UsuarioAdmin[size];

            //Console.WriteLine("Prueba " + size);
            for (int index = 0; index < objAdmin.Length; index++)
            {
                objAdmin[index] = new Cls_UsuarioAdmin();
                objAdmin[index].usuarioAdmin = reader.ReadLine();
                objAdmin[index].contraseñaAdmin = reader.ReadLine();
                objAdmin[index].CorreoAdmin = reader.ReadLine();

            }
            reader.Close();
        }

        public void AgregarUsuarioAdministrado(ref Cls_UsuarioAdmin[] objAdmin, string nom, string con,string a)
        {
            StreamWriter writer = new StreamWriter("Administradores.txt");

            writer.WriteLine(objAdmin.Length + 1);

            //Cls_Usuario[] miUsuarioNuevo = new Cls_Usuario[1];

            Cls_UsuarioAdmin temp = new Cls_UsuarioAdmin();

            for (int index = 0; index < objAdmin.Length; index++)
            {
                writer.WriteLine(objAdmin[index].usuarioAdmin);
                writer.WriteLine(objAdmin[index].contraseñaAdmin);
                writer.WriteLine(objAdmin[index].CorreoAdmin);

            }

            temp.usuarioAdmin = nom;
            temp.contraseñaAdmin = con;
            temp.CorreoAdmin = a;


            writer.WriteLine(temp.usuarioAdmin);
            writer.WriteLine(temp.contraseñaAdmin);
            writer.WriteLine(temp.CorreoAdmin);

            writer.Close();
        }



        //Metodo para mostrar la informacion de un txt
        public static void MostrarTodo(Cls_User[] objUsuario)
        {
            for (int index = 0; index < objUsuario.Length; index++)
            {
                Console.WriteLine("Id: \t\t{0}", index);
                objUsuario[index].MostrarInformacion();
            }

        }




        //Falta Administrador
    }
}
