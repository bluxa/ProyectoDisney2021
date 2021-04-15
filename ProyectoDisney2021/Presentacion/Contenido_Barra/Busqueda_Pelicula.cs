using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoDisney2021.Presentacion.Contenido_Barra
{
    public partial class Busqueda_Pelicula : Form
    {
        public Busqueda_Pelicula()
        {
            InitializeComponent();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            this.Hide();
            PresentacionContenido presentacionContenido= new PresentacionContenido();
            presentacionContenido.Show();
        }

        private void btnMilista_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lista_Pelicula lista_Pelicula = new Lista_Pelicula();
            lista_Pelicula.Show();
        }

        private void btnOriginales_Click(object sender, EventArgs e)
        {
            this.Hide();
            Originales_Peliculas originales_Peliculas = new Originales_Peliculas();
            originales_Peliculas.Show();

        }
    }
    
}
