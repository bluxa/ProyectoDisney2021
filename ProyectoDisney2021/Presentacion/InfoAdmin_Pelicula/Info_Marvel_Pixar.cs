using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoDisney2021.Data_movies;
using System.IO;
namespace ProyectoDisney2021.Presentacion.InfoAdmin_Pelicula
{
    public partial class Info_Marvel_Pixar : Form
    {
        ClsPelicula[] auxPeliculaTxt;
        DataTable tablaGeneral = new DataTable();
        public Info_Marvel_Pixar()
        {
            InitializeComponent();
        }

        private void Info_Marvel_Pixar_Load(object sender, EventArgs e)
        {           

        }
        public void cagarTablaGeneral()
        {
            tablaGeneral.Rows.Clear();
            tablaGeneral.Columns.Add("ID Pelicula", typeof(string));
            tablaGeneral.Columns.Add("ID Categoria", typeof(string));
            tablaGeneral.Columns.Add("Titulo pelicula", typeof(string));
            tablaGeneral.Columns.Add("Url video", typeof(string));
            dataGridView1.DataSource = tablaGeneral;
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
        public void leerCategorias(string Categoria)
        {
            cargarPeliculasTxt(ref auxPeliculaTxt, Categoria);


            for (int index = 0; index < auxPeliculaTxt.Length; index++)
            {

                tablaGeneral.Rows.Add
                      (auxPeliculaTxt[index].idPelicula, auxPeliculaTxt[index].idCategoria, auxPeliculaTxt[index].nombrePelicula, auxPeliculaTxt[index].trailerPelicula);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbCategoriaP.Text == "Disney")
            {
                tablaGeneral.Columns.Clear();
                cagarTablaGeneral();
                leerCategorias(cmbCategoriaP.Text);

            }
            else if (cmbCategoriaP.Text == "Pixar")
            {
                tablaGeneral.Columns.Clear();
                cagarTablaGeneral();
                leerCategorias(cmbCategoriaP.Text);

            }
            else if (cmbCategoriaP.Text == "Marvel")
            {
                tablaGeneral.Columns.Clear();
                cagarTablaGeneral();
                leerCategorias(cmbCategoriaP.Text);

            }
            else if (cmbCategoriaP.Text == "Star Wars")
            {
                tablaGeneral.Columns.Clear();
                cagarTablaGeneral();
                leerCategorias(cmbCategoriaP.Text);
            }
            else if (cmbCategoriaP.Text == "National Geographic")
            {
                tablaGeneral.Columns.Clear();
                cagarTablaGeneral();
                leerCategorias(cmbCategoriaP.Text);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId_Pelicula.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtId_Categoria.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtTitulo.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
