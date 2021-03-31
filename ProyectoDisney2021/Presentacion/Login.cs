using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoDisney2021.Presentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtGmail.Text == "" && txtPassword.Text == "")
            {
                new Presentacion_contenido().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("The user or password you entered is incorrect, try again");
                txtPassword.Clear();
                txtGmail.Clear();
            }

        }

        private void chBoxVisib_CheckedChanged(object sender, EventArgs e)
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

        private void txtGmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDato_Click(object sender, EventArgs e)
        {
            new datos_Usuario().Show();
            this.Hide();
        }
    }
}
