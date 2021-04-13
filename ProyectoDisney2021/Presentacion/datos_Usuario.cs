using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoDisney2021.Estrutura_datos.Usuario;
using ProyectoDisney2021.Estrutura_datos.Usuario.Administrador;
namespace ProyectoDisney2021.Presentacion
{
    public partial class datos_Usuario : Form
    {
        //Variable para asignar valore a mi nuevo usuario y ser ingresado a mi Lista Doble
        Cls_User miUser1; Cls_User[] auxTexto;
        Cls_UsuarioAdmin miAdmi1; Cls_UsuarioAdmin[] auxTextoAdmi;


        //Estas Clases serviran para iniciar la lista doble eh insertarla.
        Cls_DatosUsuario datoUsuario = new Cls_DatosUsuario();
        Cls_DatosUsuario auxDatoUsuario;
        Cls_DatosUsuario datoAdmin = new Cls_DatosUsuario();


        //Clase de metodos para la lectura,escritura del archivo txt
        InformacionTxt informacionUsuario = new InformacionTxt();


        public datos_Usuario()
        {
            InitializeComponent();
            pictureBox5.Visible = false;
            pictureBox4.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            switch (comboBox1.SelectedIndex)
            {
                case 0:

                    if (txtUsuario.Text == "" || txtTelefono.Text == "" || txtTarjetaCodigo.Text == "" || txtTarjeta.Text == ""
                       || txtNomap.Text == "" || txtDireccion.Text == "" || txtCorreo.Text == "" || txtContraseña.Text == "")
                    { MessageBox.Show("Digite todos los datos"); }

                    else
                    {
                        ingresoUsuario();
                        MessageBox.Show("Su cuenta es de tipo Usuario");
                    }
                    break;

                case 1:

                    if (txtUsuario.Text == "" || txtNomap.Text == "" || txtCorreo.Text == "" || txtContraseña.Text == "")
                    { MessageBox.Show("Digite todos los datos"); }


                    else
                    {
                        ingresoAdmin();
                        MessageBox.Show("Su cuenta es de tipo Administrador");
                    }
                    break;

                default:
                    MessageBox.Show("Debe de eligir un tipo de usuario !!");
                    break;
            }
        }

        void cierraFormulario()
        {
            this.Hide();
            Login loginUsuario= new Login();
            loginUsuario.Show();
        }
 


        // Para verificar si el correo esta repetido
        public void leeInsertarUsuario()
        {
            auxDatoUsuario = new Cls_DatosUsuario();
            informacionUsuario.CargarDatos(ref auxTexto);

  
            //MostrarTodo(miUsuarioNuevo2);

            Cls_User miUsuario;

            for (int index = 0; index < auxTexto.Length; index++)
            {
                miUsuario = new Cls_User(auxTexto[index].usuarioUser, auxTexto[index].nombreUsuario
                    , auxTexto[index].correoUsuario, auxTexto[index].contraseñaUsuario, auxTexto[index].tarjetaUsuario
                    , auxTexto[index].codigoTarUsuario, auxTexto[index].direccionUsuario, auxTexto[index].avarUsuario) ;


                //La informacion es leida del txt y se inserta denuevo a otra lista
                auxDatoUsuario.insertarDatoUsuario(miUsuario);
            }
        }

        public void ingresoUsuario()
        {
            //Ingreso de usuario a mi Lista Doble
            miUser1 = new Cls_User(txtUsuario.Text,txtNomap.Text,txtCorreo.Text,txtContraseña.Text,txtTarjeta.Text,
                txtTarjetaCodigo.Text,txtDireccion.Text,txtInfo.Text);

            leeInsertarUsuario();

            if (auxDatoUsuario.buscarCorreo(miUser1) == null)
            {
                datoUsuario.insertarDatoUsuario(miUser1);
              
                //Ingreso de usuario a mi Txt
                informacionUsuario.CargarDatos(ref auxTexto);
                informacionUsuario.AgregarUsuario(ref auxTexto, txtUsuario.Text, txtNomap.Text, txtCorreo.Text, txtContraseña.Text, txtTarjeta.Text,
                txtTarjetaCodigo.Text, txtDireccion.Text,txtInfo.Text);

                MessageBox.Show("La cuenta se ha creado exitosamente !!");
                cierraFormulario();
            }
            else
            {
                MessageBox.Show("Lo sentimos pero este correo o usuario ya estan registrados");
            }
        }




        public void LeerInformacionAdministrado()
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


        public void ingresoAdmin()
        {
            //Ingreso de usuario a mi Lista Doble
            miAdmi1 = new Cls_UsuarioAdmin(txtUsuario.Text, txtContraseña.Text,txtCorreo.Text);

            LeerInformacionAdministrado();

            if (datoAdmin.buscarCorreoAdministrador(miAdmi1) == null)
            {
                datoAdmin.insertarDatoAdmin(miAdmi1);
                //Ingreso de usuario a mi Txt
                informacionUsuario.CargarDatosAdmi(ref auxTextoAdmi);
                informacionUsuario.AgregarUsuarioAdministrado(ref auxTextoAdmi, txtUsuario.Text, txtContraseña.Text,txtCorreo.Text);

                MessageBox.Show("La cuenta se ha creado exitosamente !!");
                cierraFormulario();
            }
            else
            {
                MessageBox.Show("Lo sentimos pero este correo o usuario ya estan registrados");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Administrador")
            {
                
                panel2.Visible = false;
                comboBox2.Enabled = false;
                pictureBox5.Visible = true;
            }
            else
            {
                panel2.Visible = true;
                comboBox2.Enabled = true;
                pictureBox4.Visible = true;
                pictureBox5.Visible = false;

            }
        }

        private void datos_Usuario_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox3.WaitOnLoad = false;
            if (comboBox2.Text == "Avatar 1")
            {
                pictureBox3.LoadAsync(@"" + "https://whatsondisneyplus.com/wp-content/uploads/2021/02/wanda-icon.png");
                txtInfo.Text = "https://whatsondisneyplus.com/wp-content/uploads/2021/02/wanda-icon.png";

            }
            else if (comboBox2.Text == "Avatar 2")
            {
                pictureBox3.LoadAsync(@"" + "https://whatsondisneyplus.com/wp-content/uploads/2021/02/vision-avatar.png");
                txtInfo.Text = "https://whatsondisneyplus.com/wp-content/uploads/2021/02/vision-avatar.png";

            }
            else if (comboBox2.Text == "Avatar 3")
            {
                pictureBox3.LoadAsync(@"" + "https://whatsondisneyplus.com/wp-content/uploads/2021/03/zemo-avatar.png");
                txtInfo.Text = "https://whatsondisneyplus.com/wp-content/uploads/2021/03/zemo-avatar.png";
            }
            else if (comboBox2.Text == "Avatar 4")
            {
                pictureBox3.LoadAsync(@"" + "https://whatsondisneyplus.com/wp-content/uploads/2021/03/falcon-profile.png");
                txtInfo.Text = "https://whatsondisneyplus.com/wp-content/uploads/2021/03/falcon-profile.png";

            }
            else if (comboBox2.Text == "Avatar 5")
            {
                pictureBox3.LoadAsync(@"" + "https://whatsondisneyplus.com/wp-content/uploads/2021/03/winter-avatar.png");
                txtInfo.Text = "https://whatsondisneyplus.com/wp-content/uploads/2021/03/winter-avatar.png";

            }
            else if (comboBox2.Text == "Avatar 6")
            {
                pictureBox3.LoadAsync(@"" + "https://whatsondisneyplus.com/wp-content/uploads/2021/03/wanda-avatar-300x300.png");
               txtInfo.Text = "https://whatsondisneyplus.com/wp-content/uploads/2021/03/wanda-avatar-300x300.png"; 

            }




        }

        private void txtNomap_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdTerminos_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
