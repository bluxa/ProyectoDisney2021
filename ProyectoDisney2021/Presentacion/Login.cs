using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoDisney2021.Estrutura_datos.Usuario.Administrador;
using ProyectoDisney2021.Estrutura_datos.Usuario;

namespace ProyectoDisney2021.Presentacion
{
    public partial class Login : Form
    {
        //Variable para asignar valore a mi nuevo usuario y ser ingresado a mi Lista Doble
        Cls_User miUser1; Cls_User[] auxTexto;
        Cls_UsuarioAdmin miAdmi1; Cls_UsuarioAdmin[] auxTextoAdmi;


        //Estas Clases serviran para iniciar la lista doble eh insertarla.
        Cls_DatosUsuario datoUsuario = new Cls_DatosUsuario();
        Cls_DatosUsuario datoAdmin = new Cls_DatosUsuario();


        //Clase de metodos para la lectura,escritura del archivo txt
        InformacionTxt informacionUsuario = new InformacionTxt();
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
           miAdmi1  = new Cls_UsuarioAdmin("", txtPassword.Text, txtGmail.Text);
            //Leer eh inserta la informacion txt en una lista doble

            leerInformacionAdmin();

            if (datoAdmin.buscarDatosAdministrador(miAdmi1) != null)
            {
                MessageBox.Show("Bienvenido Administrador");
              
                abreFormularioAdmin();
            }

            else
            {
                buscarUsuario();
            }
        }

        public void buscarUsuario()
        {
            miUser1 = new Cls_User(txtPassword.Text, txtGmail.Text);

            leerInformacionUsuario();

            if (datoUsuario.buscarDatosCompletos(miUser1) != null)
            {
                MessageBox.Show("Bienvenido Usuario");
               abreFormularioUsuario();

            }

            else { MessageBox.Show("NO ENCONTRADO"); }

        }

        public void leerInformacionUsuario()
        {
            informacionUsuario.CargarDatos(ref auxTexto);
            //MostrarTodo(miUsuarioNuevo2);

            Cls_User miUsuario;
            for (int index = 0; index < auxTexto.Length; index++)
            {
                miUsuario = new Cls_User(auxTexto[index].usuarioUser, auxTexto[index].nombreUsuario
                    , auxTexto[index].correoUsuario, auxTexto[index].contraseñaUsuario, auxTexto[index].tarjetaUsuario
                    , auxTexto[index].codigoTarUsuario, auxTexto[index].direccionUsuario);

                //Se la informacion leida de un txt se inserta denuevo a otra lista
                datoUsuario.insertarDatoUsuario(miUsuario);
            }

        }

        public void leerInformacionAdmin()
        {
            informacionUsuario.CargarDatosAdmi(ref auxTextoAdmi);
            //MostrarTodo(miUsuarioNuevo2);

            Cls_UsuarioAdmin miAdmin;

            for (int index = 0; index < auxTextoAdmi.Length; index++)
            {
                miAdmin = new Cls_UsuarioAdmin(auxTextoAdmi[index].usuarioAdmin, auxTextoAdmi[index].contraseñaAdmin,
                  auxTextoAdmi[index].CorreoAdmin);

                //Se la informacion leida de un txt se inserta denuevo a otra lista
                datoAdmin.insertarDatoAdmin(miAdmin);
            }

        }
        void abreFormularioUsuario()
        {
            this.Hide();
            PresentacionContenido formularioUsuario = new PresentacionContenido();
            formularioUsuario.Show();
        }

        void abreFormularioAdmin()
        {
            this.Hide();
            Administrado_Principal formularioAdmin = new Administrado_Principal();
            formularioAdmin.Show();
        }


        private void chBoxVisib_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void txtGmail_TextChanged(object sender, EventArgs e)
        {

        }



        //Si no tiene una cuenta la ingresar a este evento ingresa a el formulario

        private void btnDato_Click(object sender, EventArgs e)
        {
            new datos_Usuario().Show();
            this.Hide();
        }

        private void chBoxVisib_CheckedChanged_1(object sender, EventArgs e)
        {
            ///Esta es una validacion para hacer visible la contraseña
            if (chBoxVisib.Checked == true)
            {
                // verifica que la contraseña este encriptada y la muestra
                if (txtPassword.PasswordChar == '*')
                {
                    txtPassword.PasswordChar = '\0';
                }
            }
            // De lo contrario volvera a encriptar la contraseña
            else
            {
                txtPassword.PasswordChar = '*';
            }

        }
    }
}
