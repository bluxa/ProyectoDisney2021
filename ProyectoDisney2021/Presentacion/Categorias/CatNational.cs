using ProyectoDisney2021.Data_movies;
using ProyectoDisney2021.Estrutura_datos.Lista_simple;
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
using VistaPelicula;

namespace ProyectoDisney2021.Presentacion.Categorias
{
    public partial class CatNational : Form
    {
        ClsDataPelicula miListaPelicula = new ClsDataPelicula();
        ClsPelicula miPelicula;
        ClsPelicula[] auxPeliculaTxt;

        public CatNational()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            miPelicula = new ClsPelicula();
            miPelicula.nombrePelicula = txtBuscar.Text;
            miPelicula.idCategoria = 4;
            //miListaPelicula.buscarPelicula(miPelicula);

            ClsNodo nodo = (ClsNodo)miListaPelicula.buscarPelicula(miPelicula);

            if (nodo != null)
            {
                MessageBox.Show(nodo.dato.ToString());
            }
            else
            {
                MessageBox.Show("Pelicula no encontrada");
            }
        }

        private void CatNational_Load(object sender, EventArgs e)
        {
            pictureBox7.Parent = pictureSlider;
            cargarPeliculasTxt(ref auxPeliculaTxt, "National Geographic");

            pictureBox1.WaitOnLoad = false;
            pictureBox2.WaitOnLoad = false;
            pictureBox3.WaitOnLoad = false;
            pictureBox4.WaitOnLoad = false;
            pictureBox5.WaitOnLoad = false;

            for (int index = 0; index < auxPeliculaTxt.Length; index++)
            {
                if (index == 0)
                {
                    pictureBox1.LoadAsync(@"" + auxPeliculaTxt[index].imgPelicula.ToString());
                }
                else if (index == 1)
                {
                    pictureBox2.LoadAsync(@"" + auxPeliculaTxt[index].imgPelicula.ToString());
                }
                else if (index == 2)
                {
                    pictureBox3.LoadAsync(@"" + auxPeliculaTxt[index].imgPelicula.ToString());
                }
                else if (index == 3)
                {
                    pictureBox4.LoadAsync(@"" + auxPeliculaTxt[index].imgPelicula.ToString());
                }
                else if (index == 4)
                {
                    pictureBox5.LoadAsync(@"" + auxPeliculaTxt[index].imgPelicula.ToString());
                }

                miPelicula = new ClsPelicula(auxPeliculaTxt[index].idPelicula, auxPeliculaTxt[index].nombrePelicula, auxPeliculaTxt[index].idCategoria, auxPeliculaTxt[index].imgPelicula, auxPeliculaTxt[index].trailerPelicula);
                miListaPelicula.agregarNuevaPelicula(miPelicula);
            }
        }

        public static void cargarPeliculasTxt(ref ClsPelicula[] auxPeliculaTxt, string nomCategoria)
        {
            StreamReader reader = new StreamReader(nomCategoria + ".txt");
            int size = Convert.ToInt32(reader.ReadLine());
            auxPeliculaTxt = new ClsPelicula[size];

            for (int index = 0; index < auxPeliculaTxt.Length; index++)
            {
                auxPeliculaTxt[index] = new ClsPelicula();
                auxPeliculaTxt[index].idPelicula = int.Parse(reader.ReadLine());
                auxPeliculaTxt[index].nombrePelicula = reader.ReadLine();
                auxPeliculaTxt[index].idCategoria = int.Parse(reader.ReadLine());
                auxPeliculaTxt[index].imgPelicula = reader.ReadLine();
                auxPeliculaTxt[index].trailerPelicula = reader.ReadLine();
            }
            reader.Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            PresentacionContenido formPresentacionCont = new PresentacionContenido();
            formPresentacionCont.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string html = "<html><head>";
            html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
            html += "<iframe id='video' src= 'https://www.youtube.com/embed/{0}' width='100%' height='438' frameborder='0' allowfullscreen></iframe>";
            html += "</body></html>";

            if (auxPeliculaTxt[0] != null)
            {
                Form1 Formulario = new Form1();
                Formulario.webBrowser1.DocumentText = string.Format(html, auxPeliculaTxt[0].trailerPelicula);
                Formulario.lbNombre.Text = auxPeliculaTxt[0].nombrePelicula.ToString();
                Formulario.lbIdPelicula.Text = auxPeliculaTxt[0].idPelicula.ToString();
                Formulario.lbIdCategoria.Text = auxPeliculaTxt[0].idCategoria.ToString();
                Formulario.Show();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string html = "<html><head>";
            html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
            html += "<iframe id='video' src= 'https://www.youtube.com/embed/{0}' width='100%' height='438' frameborder='0' allowfullscreen></iframe>";
            html += "</body></html>";

            if (auxPeliculaTxt[1] != null)
            {
                Form1 Formulario = new Form1();
                Formulario.webBrowser1.DocumentText = string.Format(html, auxPeliculaTxt[1].trailerPelicula);
                Formulario.lbNombre.Text = auxPeliculaTxt[1].nombrePelicula.ToString();
                Formulario.lbIdPelicula.Text = auxPeliculaTxt[1].idPelicula.ToString();
                Formulario.lbIdCategoria.Text = auxPeliculaTxt[1].idCategoria.ToString();
                Formulario.Show();
            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string html = "<html><head>";
            html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
            html += "<iframe id='video' src= 'https://www.youtube.com/embed/{0}' width='100%' height='438' frameborder='0' allowfullscreen></iframe>";
            html += "</body></html>";

            if (auxPeliculaTxt[2] != null)
            {
                Form1 Formulario = new Form1();
                Formulario.webBrowser1.DocumentText = string.Format(html, auxPeliculaTxt[2].trailerPelicula);
                Formulario.lbNombre.Text = auxPeliculaTxt[2].nombrePelicula.ToString();
                Formulario.lbIdPelicula.Text = auxPeliculaTxt[2].idPelicula.ToString();
                Formulario.lbIdCategoria.Text = auxPeliculaTxt[2].idCategoria.ToString();
                Formulario.Show();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string html = "<html><head>";
            html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
            html += "<iframe id='video' src= 'https://www.youtube.com/embed/{0}' width='100%' height='438' frameborder='0' allowfullscreen></iframe>";
            html += "</body></html>";

            if (auxPeliculaTxt[3] != null)
            {
                Form1 Formulario = new Form1();
                Formulario.webBrowser1.DocumentText = string.Format(html, auxPeliculaTxt[3].trailerPelicula);
                Formulario.lbNombre.Text = auxPeliculaTxt[3].nombrePelicula.ToString();
                Formulario.lbIdPelicula.Text = auxPeliculaTxt[3].idPelicula.ToString();
                Formulario.lbIdCategoria.Text = auxPeliculaTxt[3].idCategoria.ToString();
                Formulario.Show();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            string html = "<html><head>";
            html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
            html += "<iframe id='video' src= 'https://www.youtube.com/embed/{0}' width='100%' height='438' frameborder='0' allowfullscreen></iframe>";
            html += "</body></html>";

            if (auxPeliculaTxt[4] != null)
            {
                Form1 Formulario = new Form1();
                Formulario.webBrowser1.DocumentText = string.Format(html, auxPeliculaTxt[4].trailerPelicula);
                Formulario.lbNombre.Text = auxPeliculaTxt[4].nombrePelicula.ToString();
                Formulario.lbIdPelicula.Text = auxPeliculaTxt[4].idPelicula.ToString();
                Formulario.lbIdCategoria.Text = auxPeliculaTxt[4].idCategoria.ToString();
                Formulario.Show();
            }
        }
    }
}
