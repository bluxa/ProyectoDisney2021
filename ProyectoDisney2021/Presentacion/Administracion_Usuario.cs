using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ProyectoDisney2021.Estrutura_datos.Usuario;
using ProyectoDisney2021.Estrutura_datos.Usuario.Administrador;
namespace ProyectoDisney2021.Presentacion
{
    public partial class Administracion_Usuario : Form
    {
        InformacionTxt informacionUsuario = new InformacionTxt();
     

        Cls_User[] auxTexto; Cls_UsuarioAdmin[] auxAdmi;
        public Administracion_Usuario() 
        {
            InitializeComponent();
        }

        DataTable tablaUsuarios = new DataTable();
        DataTable tablaAdministradores = new DataTable();

        private void Administracion_Usuario_Load(object sender, EventArgs e)
        {
            tablaUsuarios.Columns.Add("NO.", typeof(string));
            tablaUsuarios.Columns.Add("Usuario",typeof(string));
            tablaUsuarios.Columns.Add("Nombre" , typeof(string));
            tablaUsuarios.Columns.Add("Correo" , typeof(string));
            tablaUsuarios.Columns.Add("Contraseña correo" , typeof(string));
            tablaUsuarios.Columns.Add("Direccion", typeof(string));
            tablaUsuarios.Columns.Add("Tarjeta de credito", typeof(string));

            dataGridView1.DataSource = tablaUsuarios;
            leerUsuario();


            cargarTablaAdmin();
            leeAdministrador();
            
        }

        public void leerUsuario()
        {
            informacionUsuario.CargarDatos(ref auxTexto);
            //MostrarTodo(miUsuarioNuevo2);
            int num = 0;

            for (int index = 0; index < auxTexto.Length; index++)
            {
      
                tablaUsuarios.Rows.Add
                      (num,auxTexto[index].usuarioUser, auxTexto[index].nombreUsuario, auxTexto[index].correoUsuario,
                       auxTexto[index].contraseñaUsuario, auxTexto[index].direccionUsuario, auxTexto[index].tarjetaUsuario
                        ) ;
               
                num++;
            }
        }

        public void leeAdministrador() 
        {
            informacionUsuario.CargarDatosAdmi(ref auxAdmi);
            //MostrarTodo(miUsuarioNuevo2);
            int num = 0;

            for (int index = 0; index < auxAdmi.Length; index++)
            {

                tablaAdministradores.Rows.Add
                      (num, auxAdmi[index].CorreoAdmin, auxAdmi[index].contraseñaAdmin);

                num++;
            }


        }
        public void cargarTablaAdmin() 
        {
            tablaAdministradores.Columns.Add("NO.", typeof(string));
            tablaAdministradores.Columns.Add("Correo admin", typeof(string));
            tablaAdministradores.Columns.Add("Contraseña", typeof(string));
            dataGridView2.DataSource = tablaAdministradores;

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUsuario.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }


        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAdmin.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            txtContraseña.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
        }

        private void txtAdmin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
