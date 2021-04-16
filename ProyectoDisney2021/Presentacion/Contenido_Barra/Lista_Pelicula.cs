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
    public partial class Lista_Pelicula : Form
    {
        public Lista_Pelicula()
        {
            InitializeComponent();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            this.Hide();
            PresentacionContenido presentacionContenido = new PresentacionContenido();
            presentacionContenido.Show();
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            this.Hide();
            Busqueda_Pelicula busqueda_Pelicula = new Busqueda_Pelicula();
            busqueda_Pelicula.Show();
        }

        private void btnOriginales_Click(object sender, EventArgs e)
        {
            this.Hide();
            Originales_Peliculas originales_Peliculas = new Originales_Peliculas();
            originales_Peliculas.Show();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void abrirFormEnPanel(object formhija)

        {
            if (this.contenidoFom.Controls.Count > 0)

                this.contenidoFom.Controls.RemoveAt(0);

            Form fh = formhija as Form;

            fh.TopLevel = false;

            fh.Dock = DockStyle.Fill;

            this.contenidoFom.Controls.Add(fh);

            this.contenidoFom.Tag = fh;

            fh.Show();



        }

        private void Lista_Pelicula_Load(object sender, EventArgs e)
        {
            abrirFormEnPanel(new Contenido_Pelicula.AxiliarPelicula());
        }
    }
}
