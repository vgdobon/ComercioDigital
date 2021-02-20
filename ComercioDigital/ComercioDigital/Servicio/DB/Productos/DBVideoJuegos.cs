using ComercioDigital.DTOs.Productos.Multimedia;
using ComercioDigital.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComercioDigital.Servicio.DB.Productos
{
    public static class DBVideoJuegos
    {

        public static void CargarVideoJuegosDB(eCommerceEntitiesDB DBAccess)
        {
            foreach (var VARIABLE in DBAccess.Videojuegos)
            {
                GestionComercio.CargarlistaBD(MapVideoJuegosFromDBToDTO(VARIABLE));
            }
        }

        public static VideosJuego MapVideoJuegosFromDBToDTO(Videojuegos videoJuegodB)
        {

            VideosJuego resul = new VideosJuego(videoJuegodB.Multimedias.Productos.Id, videoJuegodB.Multimedias.Productos.Nombre, videoJuegodB.Multimedias.Productos.Marca, videoJuegodB.Multimedias.Productos.Precio, GestionVendedores.BuscarPorId(videoJuegodB.Multimedias.Productos.IdVendedor), videoJuegodB.Multimedias.Productos.Descripcion, videoJuegodB.Multimedias.Productos.FechaPuestaVenta, videoJuegodB.Multimedias.Productos.CodigoDescuento,
                videoJuegodB.Multimedias.Productos.Stock, videoJuegodB.Multimedias.Genero, videoJuegodB.Multimedias.Formato, videoJuegodB.Multimedias.Idioma, videoJuegodB.Multimedias.FechaLanzamiento,videoJuegodB.Plataforma,videoJuegodB.EdadRecomendada);
            return resul;
        }

        public static Videojuegos MapVideoJuegosFromDTOToDB(VideosJuego videoJuegoDTO)
        {
            Videojuegos resul = new Videojuegos();
            resul.Multimedias.Productos.Nombre = videoJuegoDTO.Nombre;
            resul.Multimedias.Productos.Precio = videoJuegoDTO.Precio;
            resul.Multimedias.Productos.Marca = videoJuegoDTO.Marca;
            resul.Multimedias.Productos.IdVendedor = videoJuegoDTO.Vendedor.IdVendedor;
            resul.Multimedias.Productos.Descripcion = videoJuegoDTO.Descripcion;
            resul.Multimedias.Productos.Valoracion = videoJuegoDTO.Valoracion;
            resul.Multimedias.Productos.FechaPuestaVenta = videoJuegoDTO.FechaPuestaVenta;
            resul.Multimedias.Productos.CodigoDescuento = videoJuegoDTO.CodigoDescuento;
            resul.Multimedias.Productos.Stock = videoJuegoDTO.Stock;
            resul.Multimedias.Genero = videoJuegoDTO.Genero;
            resul.Multimedias.Formato = videoJuegoDTO.Formato;
            resul.Multimedias.Idioma = videoJuegoDTO.Idioma;
            resul.Multimedias.FechaLanzamiento = videoJuegoDTO.FechaLanzamiento;
            resul.Plataforma = videoJuegoDTO.Plataforma;
            resul.EdadRecomendada = videoJuegoDTO.EdadRecomendad;

            return resul;
        }
    }
}
