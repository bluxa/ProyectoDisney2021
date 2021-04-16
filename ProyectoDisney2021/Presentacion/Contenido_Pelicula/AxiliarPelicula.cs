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
using ProyectoDisney2021.Estrutura_datos.Pila;
using ProyectoDisney2021.Estrutura_datos.Usuario;

namespace ProyectoDisney2021.Presentacion.Contenido_Pelicula
{
    public partial class AxiliarPelicula : Form
    {
        public string usUser, nomUser, corrUser, avaUser, idPelicula, id, cat;
        ClsPelicula[] auxPeliculaTxt;
        ClsPelicula miPelicula;
        Cls_User miUsuario = new Cls_User();

        public ClsNodoPila Cima;
        private void button1_Click(object sender, EventArgs e)
        {
            miUsuario.MostrarMiListaPila();

           //pictureBox1.LoadAsync(@""  miUsuario.MostrarMiListaPila());


        }

        
        public AxiliarPelicula()
        {
            InitializeComponent();
        }

        private void AxiliarPelicula_Load(object sender, EventArgs e)
        {
            Stack<string> linkImg2 = new Stack<string>();   
            //List<string> linkImg = new List<string>();
            pictureBox1.WaitOnLoad = false;
            cargarUsuario();
            //0,1;1,2;
            string[] misPeliculas = idPelicula.Split(";");

            for (int i = 0; i < misPeliculas.Length-1; i++)
            {
                string[] auxPeliculas = misPeliculas[i].Split(",");
                
                if (auxPeliculas[1] == "0")
                {//Disney
                    cargarPeliculasTxt(ref auxPeliculaTxt, "Disney");
                    for (int index = 0; index < auxPeliculaTxt.Length; index++)
                    {       //auxPeliculas[1]= idCategoria;
                        if (Convert.ToInt32(auxPeliculas[0]) == auxPeliculaTxt[index].idPelicula)
                        {
                            miPelicula = new ClsPelicula(auxPeliculaTxt[index].idPelicula,
                            auxPeliculaTxt[index].nombrePelicula, auxPeliculaTxt[index].idCategoria,
                            auxPeliculaTxt[index].imgPelicula, auxPeliculaTxt[index].trailerPelicula);

                            miUsuario.addMiListaPila(miPelicula);
                            //linkImg.Add(auxPeliculaTxt[index].imgPelicula.ToString());
                            linkImg2.Push(auxPeliculaTxt[index].imgPelicula.ToString());
                            //pictureBox1.LoadAsync(@"" + auxPeliculaTxt[index].imgPelicula.ToString());
                        }
                    }

                }
                else if (auxPeliculas[1] == "1")
                {//Pixar
                    cargarPeliculasTxt(ref auxPeliculaTxt, "Pixar");
                    for (int index = 0; index < auxPeliculaTxt.Length; index++)
                    {       //auxPeliculas[1]= idCategoria;
                        if (Convert.ToInt32(auxPeliculas[0]) == auxPeliculaTxt[index].idPelicula)
                        {
                            miPelicula = new ClsPelicula(auxPeliculaTxt[index].idPelicula,
                            auxPeliculaTxt[index].nombrePelicula, auxPeliculaTxt[index].idCategoria,
                            auxPeliculaTxt[index].imgPelicula, auxPeliculaTxt[index].trailerPelicula);

                            miUsuario.addMiListaPila(miPelicula);
                            //linkImg.Add(auxPeliculaTxt[index].imgPelicula.ToString());
                            linkImg2.Push(auxPeliculaTxt[index].imgPelicula.ToString());
                            //pictureBox1.LoadAsync(@"" + auxPeliculaTxt[index].imgPelicula.ToString());
                        }
                    }

                }
                else if (auxPeliculas[1]=="2")
                {//Marvel
                    cargarPeliculasTxt(ref auxPeliculaTxt, "Marvel");
                    for (int index = 0; index < auxPeliculaTxt.Length; index++)
                    {       //auxPeliculas[1]= idCategoria;
                        if (Convert.ToInt32(auxPeliculas[0]) == auxPeliculaTxt[index].idPelicula)
                        {
                            miPelicula = new ClsPelicula(auxPeliculaTxt[index].idPelicula,
                            auxPeliculaTxt[index].nombrePelicula, auxPeliculaTxt[index].idCategoria,
                            auxPeliculaTxt[index].imgPelicula, auxPeliculaTxt[index].trailerPelicula);

                            miUsuario.addMiListaPila(miPelicula);
                            linkImg2.Push(auxPeliculaTxt[index].imgPelicula.ToString());
                            //pictureBox1.LoadAsync(@"" + auxPeliculaTxt[index].imgPelicula.ToString());
                        }
                    }

                }
                else if (auxPeliculas[1]=="3")
                {//Star Wars
                    cargarPeliculasTxt(ref auxPeliculaTxt, "Star Wars");
                    for (int index = 0; index < auxPeliculaTxt.Length; index++)
                    {       //auxPeliculas[1]= idCategoria;
                        if (Convert.ToInt32(auxPeliculas[0]) == auxPeliculaTxt[index].idPelicula)
                        {
                            miPelicula = new ClsPelicula(auxPeliculaTxt[index].idPelicula,
                            auxPeliculaTxt[index].nombrePelicula, auxPeliculaTxt[index].idCategoria,
                            auxPeliculaTxt[index].imgPelicula, auxPeliculaTxt[index].trailerPelicula);

                            miUsuario.addMiListaPila(miPelicula);
                            linkImg2.Push(auxPeliculaTxt[index].imgPelicula.ToString());
                            //pictureBox1.LoadAsync(@"" + auxPeliculaTxt[index].imgPelicula.ToString());
                        }
                    }

                }
                else if (auxPeliculas[1]=="4")
                {//National Geographic
                    cargarPeliculasTxt(ref auxPeliculaTxt, "National Geographic");
                    for (int index = 0; index < auxPeliculaTxt.Length; index++)
                    {       //auxPeliculas[1]= idCategoria;
                        if (Convert.ToInt32(auxPeliculas[0]) == auxPeliculaTxt[index].idPelicula)
                        {
                            miPelicula = new ClsPelicula(auxPeliculaTxt[index].idPelicula,
                            auxPeliculaTxt[index].nombrePelicula, auxPeliculaTxt[index].idCategoria,
                            auxPeliculaTxt[index].imgPelicula, auxPeliculaTxt[index].trailerPelicula);

                            miUsuario.addMiListaPila(miPelicula);
                            linkImg2.Push(auxPeliculaTxt[index].imgPelicula.ToString());
                            //pictureBox1.LoadAsync(@"" + auxPeliculaTxt[index].imgPelicula.ToString());
                        }
                    }
                }
                else if (auxPeliculas[1] == "")
                {
                    break;
                }
            }

 

            if (linkImg2.Count != 0)
            {
                pictureBox1.LoadAsync(@"" + linkImg2.Pop());
                if (linkImg2.Count != 0)
                {
                    pictureBox2.LoadAsync(@"" + linkImg2.Pop());
                    if (linkImg2.Count != 0)
                    {
                        pictureBox3.LoadAsync(@"" + linkImg2.Pop());
                        if (linkImg2.Count != 0)
                        {
                            pictureBox4.LoadAsync(@"" + linkImg2.Pop());
                        }
                    }
                }
            }
        }

        public static void cargarPeliculasTxt(ref ClsPelicula[] auxPeliculaTxt, string nomCategoria)
        {
            StreamReader reader = new StreamReader(nomCategoria + ".txt");
            //StreamReader reader = new StreamReader(nomCategoria+".txt");
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
    }
}
