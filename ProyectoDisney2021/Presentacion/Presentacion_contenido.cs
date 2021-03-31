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

namespace ProyectoDisney2021.Presentacion
{
    public partial class Presentacion_contenido : Form
    {
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
    }
}
