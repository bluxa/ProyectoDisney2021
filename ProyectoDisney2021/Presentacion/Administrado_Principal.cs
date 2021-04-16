﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoDisney2021.Presentacion.InfoAdmin_Pelicula;

namespace ProyectoDisney2021.Presentacion
{
    public partial class Administrado_Principal : Form
    {
        public Administrado_Principal()
        {
            InitializeComponent();
            PanelCategoria.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        { 
            this.Hide();
            Login formularioAdmin = new Login();
            formularioAdmin.Show();
        }

        private void contenidoForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            abrirFormEnPanel(new Administrador());
        }

        private void abrirFormEnPanel(object formhija) 
        
        {
                if (this.contenidoFom.Controls.Count>0) 
            
                    this.contenidoFom.Controls.RemoveAt(0);

                Form fh = formhija as Form;

                fh.TopLevel = false;

                fh.Dock = DockStyle.Fill;

                this.contenidoFom.Controls.Add(fh);

                this.contenidoFom.Tag = fh;

                fh.Show();

            
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            abrirFormEnPanel(new Administracion_Usuario());

        }

        private void button3_Click(object sender, EventArgs e)
        {
            PanelCategoria.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            abrirFormEnPanel(new Info_Marvel_Pixar());
        }

        private void bntRegistroDisney_Click(object sender, EventArgs e)
        {
            abrirFormEnPanel(new Info_Disney_StarWars());

        }

        private void button6_Click(object sender, EventArgs e)
        {
            abrirFormEnPanel(new Info_National());
        }

        private void barraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
