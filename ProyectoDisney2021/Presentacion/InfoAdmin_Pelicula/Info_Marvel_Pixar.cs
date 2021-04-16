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
            if (cmbCategoriaP.Text == "")
            {
                MessageBox.Show("Seleccione una categoria", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cmbCategoriaP.Text == "Disney")
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
        public void limpiarTxt()
        {
            txtId_Categoria.Clear();
            txtId_Pelicula.Clear();
            txtTitulo.Clear();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (cmbCategoriaP.Text =="")
            {
                MessageBox.Show("Seleccione una categoria", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cmbCategoriaP.Text == "Disney")
            {
                tablaGeneral.Columns.Clear();
                agregarPeliculaTxt22(ref auxPeliculaTxt, cmbCategoriaP.Text, Convert.ToInt32(txtId_Pelicula.Text));
                cagarTablaGeneral();
                leerCategorias(cmbCategoriaP.Text);
                limpiarTxt();
            }
            else if (cmbCategoriaP.Text == "Pixar")
            {
                tablaGeneral.Columns.Clear();
                agregarPeliculaTxt22(ref auxPeliculaTxt, cmbCategoriaP.Text, Convert.ToInt32(txtId_Pelicula.Text));
                cagarTablaGeneral();
                leerCategorias(cmbCategoriaP.Text);
                limpiarTxt();
            }
            if (cmbCategoriaP.Text == "Marvel")
            {
                tablaGeneral.Columns.Clear();
                agregarPeliculaTxt22(ref auxPeliculaTxt, cmbCategoriaP.Text, Convert.ToInt32(txtId_Pelicula.Text));
                cagarTablaGeneral();
                leerCategorias(cmbCategoriaP.Text);
                limpiarTxt();
            }
            if (cmbCategoriaP.Text == "Star Wars")
            {
                tablaGeneral.Columns.Clear();
                agregarPeliculaTxt22(ref auxPeliculaTxt, cmbCategoriaP.Text, Convert.ToInt32(txtId_Pelicula.Text));
                cagarTablaGeneral();
                leerCategorias(cmbCategoriaP.Text);
                limpiarTxt();
            }
            if (cmbCategoriaP.Text == "National Geographic")
            {
                tablaGeneral.Columns.Clear();
                agregarPeliculaTxt22(ref auxPeliculaTxt, cmbCategoriaP.Text, Convert.ToInt32(txtId_Pelicula.Text));
                cagarTablaGeneral();
                leerCategorias(cmbCategoriaP.Text);
                limpiarTxt();
            }
        }

        public static void agregarPeliculaTxt22(ref ClsPelicula[] auxPeliculaTxt, string nomCategoria, int idPelicula)
        {
            StreamWriter writer = new StreamWriter(nomCategoria + ".txt");
            writer.WriteLine(auxPeliculaTxt.Length - 1);
            ClsPelicula temp = new ClsPelicula();
            for (int index = 0; index < auxPeliculaTxt.Length; index++)
            {
                if (auxPeliculaTxt[index].idPelicula == idPelicula)
                {
                    if (index == auxPeliculaTxt.Length || index > auxPeliculaTxt.Length)
                    {
                        break;
                    }
                    else
                    {
                        index++;
                        if (index < auxPeliculaTxt.Length)
                        {
                            writer.WriteLine(auxPeliculaTxt[index].idPelicula);
                            writer.WriteLine(auxPeliculaTxt[index].nombrePelicula);
                            writer.WriteLine(auxPeliculaTxt[index].idCategoria);
                            writer.WriteLine(auxPeliculaTxt[index].imgPelicula);
                            writer.WriteLine(auxPeliculaTxt[index].trailerPelicula);
                        }
                        else
                            break;
                            
                    }
                    
                }
                else
                {
                    writer.WriteLine(auxPeliculaTxt[index].idPelicula);
                    writer.WriteLine(auxPeliculaTxt[index].nombrePelicula);
                    writer.WriteLine(auxPeliculaTxt[index].idCategoria);
                    writer.WriteLine(auxPeliculaTxt[index].imgPelicula);
                    writer.WriteLine(auxPeliculaTxt[index].trailerPelicula);
                }
                
            }

            //temp.idPelicula = idPelicula;
            //temp.nombrePelicula = nomPelicula;
            //temp.idCategoria = catPelicula;
            //temp.imgPelicula = imgPelicula;
            //temp.trailerPelicula = trailerPelicula;

            //writer.WriteLine(temp.idPelicula);
            //writer.WriteLine(temp.nombrePelicula);
            //writer.WriteLine(temp.idCategoria);
            //writer.WriteLine(temp.imgPelicula);
            //writer.WriteLine(temp.trailerPelicula);

            writer.Close();
        }

    }
}
