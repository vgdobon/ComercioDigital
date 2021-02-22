using ComercioDigital.DTOs.Productos.Multimedia;
using ComercioDigital.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComercioDigital.Servicio.DB.Productos
{
    public static class DBPeliculas
    {
        public static void CargarPeliculasDB(eCommerceEntitiesDB DBAccess)
        {
            foreach (var VARIABLE in DBAccess.Peliculas)
            {
                GestionComercio.CargarlistaBD(MapPeliculaFromDBToDTO(VARIABLE));
            }
        }

        public static Pelicula MapPeliculaFromDBToDTO(Peliculas peliculasDB)
        {

            Pelicula resul = new Pelicula(peliculasDB.Multimedias.Productos.Id, peliculasDB.Multimedias.Productos.Nombre, peliculasDB.Multimedias.Productos.Marca, peliculasDB.Multimedias.Productos.Precio, GestionVendedores.BuscarPorId(peliculasDB.Multimedias.Productos.IdVendedor), peliculasDB.Multimedias.Productos.Descripcion, peliculasDB.Multimedias.Productos.FechaPuestaVenta, peliculasDB.Multimedias.Productos.CodigoDescuento,
                peliculasDB.Multimedias.Productos.Stock, peliculasDB.Multimedias.Genero, peliculasDB.Multimedias.Formato, peliculasDB.Multimedias.Idioma, peliculasDB.Multimedias.FechaLanzamiento,peliculasDB.Actores,peliculasDB.Director,peliculasDB.EdadRecomendada,peliculasDB.Sinopsis);
            return resul;
        }

        public static Peliculas MapPeliculaFromDTOToDB(Pelicula peliculaDTO)
        {
            Peliculas resul = new Peliculas();

            if (resul.Multimedias == null)
            {
                resul.Multimedias = new Multimedias();
                if (resul.Multimedias.Productos == null)
                {
                    resul.Multimedias.Productos = new Model.Productos();
                }
            }

            resul.Multimedias.Productos.Nombre = peliculaDTO.Nombre;
            resul.Multimedias.Productos.Precio = peliculaDTO.Precio;
            resul.Multimedias.Productos.Marca = peliculaDTO.Marca;
            resul.Multimedias.Productos.IdVendedor = peliculaDTO.Vendedor.IdVendedor;
            resul.Multimedias.Productos.Descripcion = peliculaDTO.Descripcion;
            resul.Multimedias.Productos.Valoracion = peliculaDTO.Valoracion;
            resul.Multimedias.Productos.FechaPuestaVenta = peliculaDTO.FechaPuestaVenta;
            resul.Multimedias.Productos.CodigoDescuento = peliculaDTO.CodigoDescuento;
            resul.Multimedias.Productos.Stock = peliculaDTO.Stock;
            resul.Multimedias.Genero = peliculaDTO.Genero;
            resul.Multimedias.Formato = peliculaDTO.Formato;
            resul.Multimedias.Idioma = peliculaDTO.Idioma;
            resul.Multimedias.FechaLanzamiento = peliculaDTO.FechaLanzamiento;
            resul.Actores = peliculaDTO.Actores;
            resul.Director = peliculaDTO.Director;
            resul.EdadRecomendada = peliculaDTO.EdadRecomendad;
            resul.Sinopsis = peliculaDTO.Sinopsis;

            return resul;
        }

        public static void AnnadirPelicula(Pelicula peliculaDTO)
        {

            Peliculas nuevaPelicula = MapPeliculaFromDTOToDB(peliculaDTO);
            DBComerce.DBAccess.Peliculas.Add(nuevaPelicula);

            DBComerce.DBAccess.SaveChangesAsync();

        }
    }
}
