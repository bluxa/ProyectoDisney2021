using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoDisney2021.Estrutura_datos.Usuario;
namespace ProyectoDisney2021.Data_movies
{
    public class ClsPelicula:ComparadorUsuario
    {
        public int idPelicula { get; set; }
        public string nombrePelicula { get; set; }
        public int idCategoria { get; set; }
        public string imgPelicula { get; set; }
        public string trailerPelicula { get; set; }

        public ClsPelicula()
        {
        }

        public ClsPelicula(int idPelicula, string nombrePelicula, int idCategoria, string imgPelicula, string trailerPelicula)
        {
            this.idPelicula = idPelicula;
            this.nombrePelicula = nombrePelicula;
            this.idCategoria = idCategoria;
            this.imgPelicula = imgPelicula;
            this.trailerPelicula = trailerPelicula;
        }

        public string obtenerCategoria()
        {
            switch (idCategoria)
            {
                case 0:
                    return "Disney";
                case 1:
                    return "Pixar";
                case 2:
                    return "Marvel";
                case 3:
                    return "Star Wars";
                case 4:
                    return "Marvel, Star Wars y National Geographic";
            }
            return null;
        }

        public object MostrarInformacion()
        {
            return null;

        }

        public bool usuarioIgual(object q)
        {
            throw new NotImplementedException();
        }

        public bool contraseñaIgual(object q)
        {
            throw new NotImplementedException();
        }

        public bool correoIgual(object q)
        {
            throw new NotImplementedException();
        }

        public bool nombrePeliculaIgual(object q)
        {
            ClsPelicula us2 = (ClsPelicula)q;
            if (nombrePelicula.CompareTo(us2.nombrePelicula) == 0)
                return true;
            else
                return false;
        }

        public override string ToString()
        {
            return nombrePelicula +" Si funciona"+imgPelicula;
        }
    }
}
