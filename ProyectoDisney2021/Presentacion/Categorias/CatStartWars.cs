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
using ProyectoDisney2021.Data_movies;
using ProyectoDisney2021.Estrutura_datos.Lista_simple;

namespace ProyectoDisney2021.Presentacion.Categorias
{
    public partial class CatStartWars : Form
    {
        ClsDataPelicula miListaPelicula = new ClsDataPelicula();
        ClsPelicula miPelicula;
        ClsPelicula[] auxPeliculaTxt;

        public CatStartWars()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            miPelicula = new ClsPelicula();
            miPelicula.nombrePelicula = txtBuscar.Text;
            miPelicula.idCategoria = 3;
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

        private void CatStartWars_Load(object sender, EventArgs e)
        {
            cargarPeliculasTxt(ref auxPeliculaTxt, "Star Wars");

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
    }
}
