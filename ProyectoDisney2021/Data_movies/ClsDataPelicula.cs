using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoDisney2021.Estrutura_datos.Lista_simple;
using ProyectoDisney2021.Data_movies;

namespace ProyectoDisney2021.Data_movies
{
    public class ClsDataPelicula
    {

        ClsListaEnlazada miListaDisney;
        ClsListaEnlazada miListaPixar;
        ClsListaEnlazada miListaMarvel;
        ClsListaEnlazada miListaStarWars;
        ClsListaEnlazada miListaNatGeo;

        public ClsDataPelicula()
        {
            miListaDisney = new ClsListaEnlazada();
            miListaPixar = new ClsListaEnlazada();
            miListaMarvel = new ClsListaEnlazada();
            miListaStarWars = new ClsListaEnlazada();
            miListaNatGeo = new ClsListaEnlazada();
        }

        public void agregarNuevaPelicula(ClsPelicula nuevaPelicula)
        {
            if (nuevaPelicula.idCategoria == 0)
            {
                miListaDisney.insertarDatoCabeza(nuevaPelicula);
            }
            else if (nuevaPelicula.idCategoria == 1)
            {
                miListaPixar.insertarDatoCabeza(nuevaPelicula);
            }
            else if (nuevaPelicula.idCategoria == 2)
            {
                miListaMarvel.insertarDatoCabeza(nuevaPelicula);
            }
            else if (nuevaPelicula.idCategoria == 3)
            {
                miListaStarWars.insertarDatoCabeza(nuevaPelicula);
            }
            else if (nuevaPelicula.idCategoria == 4)
            {
                miListaNatGeo.insertarDatoCabeza(nuevaPelicula);
            }
        }
    }
}
