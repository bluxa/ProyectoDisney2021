using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoDisney2021.Presentacion.InfoAdmin_Pelicula
{
    public partial class Info_Marvel_Pixar : Form
    {
        public Info_Marvel_Pixar()
        {
            InitializeComponent();
        }

        private void Info_Marvel_Pixar_Load(object sender, EventArgs e)
        {
            cagarTablaMarvel();
            cagarTablaPixar();

        }
        DataTable  tablaMavel= new DataTable();
        DataTable tablaPixar = new DataTable();

        public void cagarTablaMarvel() 
        {
            tablaMavel.Columns.Add("ID Pelicula", typeof(string));
            tablaMavel.Columns.Add("Titulo pelicula", typeof(string));
            tablaMavel.Columns.Add("Url video", typeof(string));
        }
        public void cagarTablaPixar()
        {
            tablaPixar.Columns.Add("ID Pelicula", typeof(string));
            tablaPixar.Columns.Add("Titulo pelicula", typeof(string));
            tablaPixar.Columns.Add("Url video", typeof(string));

        }
    }
}
