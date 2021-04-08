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

namespace ProyectoDisney2021.Presentacion
{
    public partial class Presentacion_contenido : Form
    {
        ClsPelicula[] auxPeliculaTxt;
        public Presentacion_contenido()
        {
            InitializeComponent();
        }

        private void Presentacion_contenido_Load(object sender, EventArgs e)
        {
            timer1.Start();
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


    }
}
