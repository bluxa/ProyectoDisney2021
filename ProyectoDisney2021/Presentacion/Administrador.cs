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
namespace ProyectoDisney2021.Presentacion
{
    public partial class Administrador : Form
    {
        ClsDataPelicula miListaPelicula = new ClsDataPelicula();
        ClsPelicula miPelicula;
        ClsPelicula[] auxPeliculaTxt;

        public Administrador()
        {
            InitializeComponent();
        }

        public void limpiarTxt()
        {
            txtIdP.Clear();
            txtNombreP.Clear();
            txtImgP.Clear();
            txtIdVideoP.Clear();
            cmbCategoriaP.Items.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int auxCategoriaId = 0;

            if (txtIdP.Text == "" && txtImgP.Text == "" && txtNombreP.Text == "" && txtIdVideoP.Text == "" && cmbCategoriaP.Text == "")
            {
                MessageBox.Show("LLENE TODOS LOS CAMPOS");
            }
            else
            {
                if (cmbCategoriaP.Text == "Disney")
                {
                    auxCategoriaId = 0;
                    cargarPeliculasTxt(ref auxPeliculaTxt, cmbCategoriaP.Text);
                }
                else if (cmbCategoriaP.Text == "Pixar")
                {
                    auxCategoriaId = 1;
                    cargarPeliculasTxt(ref auxPeliculaTxt, cmbCategoriaP.Text);
                }
                else if (cmbCategoriaP.Text == "Marvel")
                {
                    auxCategoriaId = 2;
                    cargarPeliculasTxt(ref auxPeliculaTxt, cmbCategoriaP.Text);
                }
                else if (cmbCategoriaP.Text == "Star Wars")
                {
                    auxCategoriaId = 3;
                    cargarPeliculasTxt(ref auxPeliculaTxt, cmbCategoriaP.Text);
                }
                else if (cmbCategoriaP.Text == "National Geographic")
                {
                    auxCategoriaId = 4;
                    cargarPeliculasTxt(ref auxPeliculaTxt, cmbCategoriaP.Text);
                }
                miPelicula = new ClsPelicula(Convert.ToInt32(txtIdP.Text), txtNombreP.Text, auxCategoriaId, txtImgP.Text, txtIdVideoP.Text);

                miListaPelicula.agregarNuevaPelicula(miPelicula);
                agregarPeliculaTxt(ref auxPeliculaTxt, cmbCategoriaP.Text, Convert.ToInt32(txtIdP.Text), txtNombreP.Text, auxCategoriaId, txtImgP.Text, txtIdVideoP.Text);
                MessageBox.Show("DATOS ALMACENADOS CORRECTAMENTE");
                limpiarTxt();
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

        public static void agregarPeliculaTxt(ref ClsPelicula[] auxPeliculaTxt, string nomCategoria, int idPelicula, string nomPelicula, int catPelicula, string imgPelicula, string trailerPelicula)
        {
            StreamWriter writer = new StreamWriter(nomCategoria + ".txt");
            writer.WriteLine(auxPeliculaTxt.Length + 1);

            ClsPelicula temp = new ClsPelicula();

            for (int index = 0; index < auxPeliculaTxt.Length; index++)
            {
                writer.WriteLine(auxPeliculaTxt[index].idPelicula);
                writer.WriteLine(auxPeliculaTxt[index].nombrePelicula);
                writer.WriteLine(auxPeliculaTxt[index].idCategoria);
                writer.WriteLine(auxPeliculaTxt[index].imgPelicula);
                writer.WriteLine(auxPeliculaTxt[index].trailerPelicula);
            }

            temp.idPelicula = idPelicula;
            temp.nombrePelicula = nomPelicula;
            temp.idCategoria = catPelicula;
            temp.imgPelicula = imgPelicula;
            temp.trailerPelicula = trailerPelicula;

            writer.WriteLine(temp.idPelicula);
            writer.WriteLine(temp.nombrePelicula);
            writer.WriteLine(temp.idCategoria);
            writer.WriteLine(temp.imgPelicula);
            writer.WriteLine(temp.trailerPelicula);

            writer.Close();
        }

        private void Administrador_Load(object sender, EventArgs e)
        {

        }
    }
}
