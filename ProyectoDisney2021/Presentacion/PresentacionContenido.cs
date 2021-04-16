using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using System.IO;
using ProyectoDisney2021.Data_movies;
using ProyectoDisney2021.Presentacion.Categorias;
using ProyectoDisney2021.Presentacion.Contenido_Barra;
using ProyectoDisney2021.Estrutura_datos.Lista_doble;
using VistaPelicula;

namespace ProyectoDisney2021.Presentacion
{
    public partial class PresentacionContenido : Form
    {
        //ClsPelicula[] auxPeliculaTxt;

        public Cls_ListaDoble miLista = new Cls_ListaDoble();
        Cls_NodoDoble nodoList;
        string usUser, nomUser, corrUser, avaUser, idPelicula;
        Data_movies.ClsPelicula miPelicula;
        Data_movies.ClsPelicula[] auxPeliculaTxt;
        Data_movies.ClsPelicula[] auxPeliculaTxt2;
        public PresentacionContenido()
        {
            InitializeComponent();
        }

        public PresentacionContenido(object datoUsuario)
        {
            InitializeComponent();
            miLista.insertarAlFinal(datoUsuario);
            infoUsurio();
        }

        private void Presentacion_contenido_Load(object sender, EventArgs e)
        {
            timer1.Start();
            cargaAvatar();

            cargarPeliculasTxt(ref auxPeliculaTxt, "Disney");
            cargarPeliculasTxt2(ref auxPeliculaTxt2, "Marvel");

            pictureBox3.WaitOnLoad = false;
            pictureBox4.WaitOnLoad = false;
            pictureBox5.WaitOnLoad = false;
            pictureBox6.WaitOnLoad = false;
            pictureBox7.WaitOnLoad = false;

            pictureBox11.WaitOnLoad = false;
            pictureBox10.WaitOnLoad = false;
            pictureBox9.WaitOnLoad = false;
            pictureBox8.WaitOnLoad = false;
            pictureBox12.WaitOnLoad = false;

            for (int index = 0; index < auxPeliculaTxt.Length; index++)
            {
                if (index == 0)
                {
                    pictureBox7.LoadAsync(@"" + auxPeliculaTxt[index].imgPelicula.ToString());
                }
                else if (index == 1)
                {
                    pictureBox6.LoadAsync(@"" + auxPeliculaTxt[index].imgPelicula.ToString());
                }
                else if (index == 2)
                {
                    pictureBox5.LoadAsync(@"" + auxPeliculaTxt[index].imgPelicula.ToString());
                }
                else if (index == 3)
                {
                    pictureBox4.LoadAsync(@"" + auxPeliculaTxt[index].imgPelicula.ToString());
                }
                else if (index == 4)
                {
                    pictureBox3.LoadAsync(@"" + auxPeliculaTxt[index].imgPelicula.ToString());
                }

                miPelicula = new Data_movies.ClsPelicula(auxPeliculaTxt[index].idPelicula, auxPeliculaTxt[index].nombrePelicula, auxPeliculaTxt[index].idCategoria, auxPeliculaTxt[index].imgPelicula, auxPeliculaTxt[index].trailerPelicula);
                //miListaPelicula.agregarNuevaPelicula(miPelicula);
            }

            for (int index = 0; index < auxPeliculaTxt2.Length; index++)
            {
                if (index == 0)
                {
                    pictureBox11.LoadAsync(@"" + auxPeliculaTxt2[index].imgPelicula.ToString());
                }
                else if (index == 1)
                {
                    pictureBox10.LoadAsync(@"" + auxPeliculaTxt2[index].imgPelicula.ToString());
                }
                else if (index == 2)
                {
                    pictureBox9.LoadAsync(@"" + auxPeliculaTxt2[index].imgPelicula.ToString());
                }
                else if (index == 3)
                {
                    pictureBox8.LoadAsync(@"" + auxPeliculaTxt2[index].imgPelicula.ToString());
                }
                else if (index == 4)
                {
                    pictureBox12.LoadAsync(@"" + auxPeliculaTxt2[index].imgPelicula.ToString());
                }

                miPelicula = new Data_movies.ClsPelicula(auxPeliculaTxt[index].idPelicula, auxPeliculaTxt[index].nombrePelicula, auxPeliculaTxt[index].idCategoria, auxPeliculaTxt[index].imgPelicula, auxPeliculaTxt[index].trailerPelicula);
                //miListaPelicula.agregarNuevaPelicula(miPelicula);
            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        int intTiempo = 1;
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            intTiempo++;
            label1.Text = intTiempo.ToString();
            if (label1.Text == "0")
            {
                pictureSlider.Image = global::ProyectoDisney2021.Properties.Resources.SL1;
            }
            if (label1.Text == "20")
            {
                pictureSlider.Image = global::ProyectoDisney2021.Properties.Resources.SL2;
            }
            if (label1.Text == "30")
            {
                pictureSlider.Image = global::ProyectoDisney2021.Properties.Resources.SL3;
            }
            if (label1.Text == "40")
            {
                pictureSlider.Image = global::ProyectoDisney2021.Properties.Resources.SL4;
            }
            if (label1.Text == "50")
            {
                pictureSlider.Image = global::ProyectoDisney2021.Properties.Resources.SL5;
            }
            if (label1.Text == "60")
            {
                pictureSlider.Image = global::ProyectoDisney2021.Properties.Resources.SL6;
                intTiempo = 1;
                timer1.Start();
            }
            
        }

        private void pictureDisney_MouseLeave(object sender, EventArgs e)
        {
            pictureDisney.Image = global::ProyectoDisney2021.Properties.Resources.BDisney;
        }

        private void pictureDisney_MouseHover(object sender, EventArgs e)
        {
            pictureDisney.Image = global::ProyectoDisney2021.Properties.Resources.Disney;
        }

        private void picturePixar_MouseHover(object sender, EventArgs e)
        {
            picturePixar.Image = global::ProyectoDisney2021.Properties.Resources.Pixar;
        }

        private void picturePixar_MouseLeave(object sender, EventArgs e)
        {
            picturePixar.Image = global::ProyectoDisney2021.Properties.Resources.BPixar;
        }

        private void pictureMarvel_MouseHover(object sender, EventArgs e)
        {
            pictureMarvel.Image = global::ProyectoDisney2021.Properties.Resources.Marvel;
        }

        private void pictureMarvel_MouseLeave(object sender, EventArgs e)
        {
            pictureMarvel.Image = global::ProyectoDisney2021.Properties.Resources.BMarvel;
        }

        private void pictureStarWars_MouseHover(object sender, EventArgs e)
        {
            pictureStarWars.Image = global::ProyectoDisney2021.Properties.Resources.Starwars;
        }

        private void pictureStarWars_MouseLeave(object sender, EventArgs e)
        {
            pictureStarWars.Image = global::ProyectoDisney2021.Properties.Resources.BstarWars;
        }

        private void pictureNational_MouseHover(object sender, EventArgs e)
        {
            pictureNational.Image = global::ProyectoDisney2021.Properties.Resources.National;
        }

        private void pictureNational_MouseLeave(object sender, EventArgs e)
        {
            pictureNational.Image = global::ProyectoDisney2021.Properties.Resources.BNational;
        }

        private void pictureDisney_Click(object sender, EventArgs e)
        {
            this.Hide();
            CatDisney formCatDisney = new CatDisney();
            formCatDisney.Show();

            cargarPeliculasTxt(ref auxPeliculaTxt, "Disney");

            pictureBox7.WaitOnLoad = false;
            pictureBox6.WaitOnLoad = false;
            for (int index = 0; index < auxPeliculaTxt.Length; index++)
            {
                if (index == 0)
                {
                    pictureBox7.LoadAsync(@"" + auxPeliculaTxt[index].imgPelicula.ToString());

                    //string html = "<html><head>";
                    //html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
                    //html += "<iframe id='video' src= 'https://www.youtube.com/embed/{0}' width='300' height='300' frameborder='0' allowfullscreen></iframe>";
                    //html += "</body></html>";
                    //this.webBrowser1.DocumentText = string.Format(html, auxPeliculaTxt[index].trailerPelicula);

                }
                else
                {
                    pictureBox6.LoadAsync(@"" + auxPeliculaTxt[index].imgPelicula.ToString());
                    //string html = "<html><head>";
                    //html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
                    //html += "<iframe id='video' src= 'https://www.youtube.com/embed/{0}' width='300' height='250' frameborder='0' allowfullscreen></iframe>";
                    //html += "</body></html>";
                    //this.webBrowser2.DocumentText = string.Format(html, auxPeliculaTxt[index].trailerPelicula);
                }

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

        public static void cargarPeliculasTxt2(ref ClsPelicula[] auxPeliculaTxt, string nomCategoria)
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
        public void infoUsurio()
        {
            nodoList = (Cls_NodoDoble)miLista.mostrar();
            string nuevo = nodoList.datoNodo.ToString();
            string[] palabras = nuevo.Split("&");

            int a = 0;

            TextWriter escribirDato = new StreamWriter("Temp.txt");

            foreach (string words in palabras)
            {
                a++;
                if (a == 5)
                {
                    escribirDato.Write(words);
                }
                else
                    escribirDato.WriteLine(words);
            }
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

        public void cargaAvatar()
        {
            panel1.Visible = false;
            pictureBox2.WaitOnLoad = false;

            cargarUsuario();

            pictureBox2.LoadAsync(@"" + avaUser);

            label4.Text = usUser;
            label5.Text = nomUser;
            label6.Text = corrUser;

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void picturePixar_Click(object sender, EventArgs e)
        {
            this.Hide();
            CatPixar formCatPixar = new CatPixar();
            formCatPixar.Show();
        }

        private void pictureSlider_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void PresentacionContenido_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            DialogResult result = MessageBox.Show("Desea cerrar la sesion", "Mensaje de sesion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                Login loginInico = new Login();
                loginInico.Show();

            }
         

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            this.Hide();
            Busqueda_Pelicula busquedaPelicula = new Busqueda_Pelicula();
            busquedaPelicula.Show();

        }

        private void btnMilista_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lista_Pelicula listaPelicula = new Lista_Pelicula();
            //Contenido_Pelicula.AxiliarPelicula listaPelicula = new Contenido_Pelicula.AxiliarPelicula();
            listaPelicula.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
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

        private void pictureBox6_Click(object sender, EventArgs e)
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

        private void pictureBox5_Click(object sender, EventArgs e)
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

        private void pictureBox3_Click(object sender, EventArgs e)
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

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            string html = "<html><head>";
            html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
            html += "<iframe id='video' src= 'https://www.youtube.com/embed/{0}' width='100%' height='438' frameborder='0' allowfullscreen></iframe>";
            html += "</body></html>";

            if (auxPeliculaTxt2[0] != null)
            {
                Form1 Formulario = new Form1();
                Formulario.webBrowser1.DocumentText = string.Format(html, auxPeliculaTxt2[0].trailerPelicula);
                Formulario.lbNombre.Text = auxPeliculaTxt2[0].nombrePelicula.ToString();
                Formulario.lbIdPelicula.Text = auxPeliculaTxt2[0].idPelicula.ToString();
                Formulario.lbIdCategoria.Text = auxPeliculaTxt2[0].idCategoria.ToString();
                Formulario.Show();
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            string html = "<html><head>";
            html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
            html += "<iframe id='video' src= 'https://www.youtube.com/embed/{0}' width='100%' height='438' frameborder='0' allowfullscreen></iframe>";
            html += "</body></html>";

            if (auxPeliculaTxt2[1] != null)
            {
                Form1 Formulario = new Form1();
                Formulario.webBrowser1.DocumentText = string.Format(html, auxPeliculaTxt2[1].trailerPelicula);
                Formulario.lbNombre.Text = auxPeliculaTxt2[1].nombrePelicula.ToString();
                Formulario.lbIdPelicula.Text = auxPeliculaTxt2[1].idPelicula.ToString();
                Formulario.lbIdCategoria.Text = auxPeliculaTxt2[1].idCategoria.ToString();
                Formulario.Show();
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            string html = "<html><head>";
            html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
            html += "<iframe id='video' src= 'https://www.youtube.com/embed/{0}' width='100%' height='438' frameborder='0' allowfullscreen></iframe>";
            html += "</body></html>";

            if (auxPeliculaTxt2[2] != null)
            {
                Form1 Formulario = new Form1();
                Formulario.webBrowser1.DocumentText = string.Format(html, auxPeliculaTxt2[2].trailerPelicula);
                Formulario.lbNombre.Text = auxPeliculaTxt2[2].nombrePelicula.ToString();
                Formulario.lbIdPelicula.Text = auxPeliculaTxt2[2].idPelicula.ToString();
                Formulario.lbIdCategoria.Text = auxPeliculaTxt2[2].idCategoria.ToString();
                Formulario.Show();
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            string html = "<html><head>";
            html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
            html += "<iframe id='video' src= 'https://www.youtube.com/embed/{0}' width='100%' height='438' frameborder='0' allowfullscreen></iframe>";
            html += "</body></html>";

            if (auxPeliculaTxt2[3] != null)
            {
                Form1 Formulario = new Form1();
                Formulario.webBrowser1.DocumentText = string.Format(html, auxPeliculaTxt2[3].trailerPelicula);
                Formulario.lbNombre.Text = auxPeliculaTxt2[3].nombrePelicula.ToString();
                Formulario.lbIdPelicula.Text = auxPeliculaTxt2[3].idPelicula.ToString();
                Formulario.lbIdCategoria.Text = auxPeliculaTxt2[3].idCategoria.ToString();
                Formulario.Show();
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            string html = "<html><head>";
            html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
            html += "<iframe id='video' src= 'https://www.youtube.com/embed/{0}' width='100%' height='438' frameborder='0' allowfullscreen></iframe>";
            html += "</body></html>";

            if (auxPeliculaTxt2[4] != null)
            {
                Form1 Formulario = new Form1();
                Formulario.webBrowser1.DocumentText = string.Format(html, auxPeliculaTxt2[4].trailerPelicula);
                Formulario.lbNombre.Text = auxPeliculaTxt2[4].nombrePelicula.ToString();
                Formulario.lbIdPelicula.Text = auxPeliculaTxt2[4].idPelicula.ToString();
                Formulario.lbIdCategoria.Text = auxPeliculaTxt2[4].idCategoria.ToString();
                Formulario.Show();
            }
        }

        private void btnOriginales_Click(object sender, EventArgs e)
        {
            this.Hide();
            Originales_Peliculas origialPelicula = new Originales_Peliculas();
            origialPelicula.Show();

        }

        private void pictureMarvel_Click(object sender, EventArgs e)
        {
            this.Hide();
            CatMarvel formMarvel = new CatMarvel();
            formMarvel.Show();
        }

        private void pictureStarWars_Click(object sender, EventArgs e)
        {
            this.Hide();
            CatStartWars formStarWars = new CatStartWars();
            formStarWars.Show();
        }

        private void pictureNational_Click(object sender, EventArgs e)
        {
            this.Hide();
            CatNational formNatGeo = new CatNational();
            formNatGeo.Show();
        }
    }
}
