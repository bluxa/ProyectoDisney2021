using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoDisney2021.Presentacion;

namespace ProyectoDisney2021
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new ProyectoDisney2021.Presentacion.Categorias.CatDisney());
            //  Application.Run(new ProyectoDisney2021.Presentacion.PresentacionContenido());
           Application.Run(new Pagina_principal());
            //Application.Run(new ProyectoDisney2021.Presentacion.Contenido_Pelicula.AxiliarPelicula());
            //Application.Run(new Presentacion.Categorias.CatDisney());
           // Application.Run(new ProyectoDisney2021.Presentacion.InfoAdmin_Pelicula.Info_Marvel_Pixar());
            //Application.Run(new Administrado_Principal());

        }
    }
}
