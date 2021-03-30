using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoDisney2021.Presentacion
{
    public partial class Pagina_principal : Form
    {
        public Pagina_principal()
        {
            InitializeComponent();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void Pagina_principal_Load(object sender, EventArgs e)
        {
            label3.Parent = pictureBox1;
            label5.Parent = pictureBox1;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
