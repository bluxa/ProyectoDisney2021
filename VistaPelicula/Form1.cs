using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistaPelicula
{
    public partial class Form1 : Form
    {
        Cls_User[] auxUsuarioTxt;
        public string usUser, nomUser, corrUser, avaUser, idPelicula, id, cat;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarUsuario();
        }

        private void lbNombre_TextChanged(object sender, EventArgs e)
        {

        }

        public static void cargarUsuariosTxt(ref Cls_User[] auxUsuarioTxt)
        {

            StreamReader reader = new StreamReader(@"Usuarios.txt");
            int size = Convert.ToInt32(reader.ReadLine());
            auxUsuarioTxt = new Cls_User[size];

            for (int index = 0; index < auxUsuarioTxt.Length; index++)
            {
                auxUsuarioTxt[index] = new Cls_User();
                auxUsuarioTxt[index].usuarioUser = reader.ReadLine();
                auxUsuarioTxt[index].nombreUsuario = reader.ReadLine();
                auxUsuarioTxt[index].correoUsuario = reader.ReadLine();
                auxUsuarioTxt[index].contraseñaUsuario = reader.ReadLine();
                auxUsuarioTxt[index].tarjetaUsuario = reader.ReadLine();
                auxUsuarioTxt[index].codigoTarUsuario = reader.ReadLine();
                auxUsuarioTxt[index].direccionUsuario = reader.ReadLine();
                auxUsuarioTxt[index].avarUsuario = reader.ReadLine();
                auxUsuarioTxt[index].idPeliculas = reader.ReadLine();
            }
            reader.Close();
        }

        public static void modificarrUsuarioTxt(ref Cls_User[] auxUsuarioTxt, string idPelicula, string nombreUser)
        {
            StreamWriter writer = new StreamWriter(@"Usuarios.txt");
            writer.WriteLine(auxUsuarioTxt.Length);

            Cls_User temp2 = new Cls_User();

            for (int index = 0; index < auxUsuarioTxt.Length; index++)
            {

                if (auxUsuarioTxt[index].usuarioUser == nombreUser)
                {
                    writer.WriteLine(auxUsuarioTxt[index].usuarioUser);
                    writer.WriteLine(auxUsuarioTxt[index].nombreUsuario);
                    writer.WriteLine(auxUsuarioTxt[index].correoUsuario);
                    writer.WriteLine(auxUsuarioTxt[index].contraseñaUsuario);
                    writer.WriteLine(auxUsuarioTxt[index].tarjetaUsuario);
                    writer.WriteLine(auxUsuarioTxt[index].codigoTarUsuario);
                    writer.WriteLine(auxUsuarioTxt[index].direccionUsuario);
                    writer.WriteLine(auxUsuarioTxt[index].avarUsuario);
                    auxUsuarioTxt[index].idPeliculas = idPelicula;
                    //writer.Write(idPelicula + "," + idCategoria+ ";");
                    //idPelicual contiene el idPelicua y idCategoria
                    //temp2.idPeliculas = idPelicula;
                    writer.WriteLine(auxUsuarioTxt[index].idPeliculas);
                }
                else
                {
                    writer.WriteLine(auxUsuarioTxt[index].usuarioUser);
                    writer.WriteLine(auxUsuarioTxt[index].nombreUsuario);
                    writer.WriteLine(auxUsuarioTxt[index].correoUsuario);
                    writer.WriteLine(auxUsuarioTxt[index].contraseñaUsuario);
                    writer.WriteLine(auxUsuarioTxt[index].tarjetaUsuario);
                    writer.WriteLine(auxUsuarioTxt[index].codigoTarUsuario);
                    writer.WriteLine(auxUsuarioTxt[index].direccionUsuario);
                    writer.WriteLine(auxUsuarioTxt[index].avarUsuario);
                    writer.WriteLine(auxUsuarioTxt[index].idPeliculas);
                }
            }

            writer.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            id = lbIdPelicula.Text;
            cat = lbIdCategoria.Text;
            infoUsurio(id, cat);

            cargarUsuariosTxt(ref auxUsuarioTxt);

            for (int index = 0; index < auxUsuarioTxt.Length; index++)
            {
                if (auxUsuarioTxt[index].usuarioUser == usUser)
                {
                    cargarUsuario();
                    modificarrUsuarioTxt(ref auxUsuarioTxt, idPelicula, usUser);
                }
            }
            MessageBox.Show("Se agrego a su lista", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
           // pictureBox2.Enabled = false;
        }

        public void infoUsurio(string id, string cat)
        {
            TextReader leer = new StreamReader("Temp.txt");

            usUser = leer.ReadLine();
            nomUser = leer.ReadLine();
            corrUser = leer.ReadLine();
            avaUser = leer.ReadLine();
            idPelicula = leer.ReadLine();
            leer.Close();

            StreamWriter escribirDato = new StreamWriter("Temp.txt", true);
            escribirDato.Write(id + "," + cat + ";");
            //escribirDato.Write("66,5;");

            escribirDato.Close();
        }

        public void cargarUsuario()
        {
            TextReader leer = new StreamReader("Temp.txt");

            usUser = leer.ReadLine();
            nomUser = leer.ReadLine();
            corrUser = leer.ReadLine();
            avaUser = leer.ReadLine();
            idPelicula = leer.ReadLine();
            leer.Close();
        }

    }
}
