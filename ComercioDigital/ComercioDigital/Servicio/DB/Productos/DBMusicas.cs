using ComercioDigital.DTOs.Productos.Multimedia;
using ComercioDigital.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComercioDigital.Servicio.DB.Productos
{
    public static class DBMusicas
    {
        public static void CargarMusicasDB(eCommerceEntitiesDB DBAccess)
        {
            foreach (var VARIABLE in DBAccess.Musicas)
            {
                GestionComercio.CargarlistaBD(MapMusicasFromDBToDTO(VARIABLE));
            }
        }

        public static Musica MapMusicasFromDBToDTO(Musicas musicasdB)
        {

            Musica resul = new Musica(musicasdB.Multimedias.Productos.Id, musicasdB.Multimedias.Productos.Nombre, musicasdB.Multimedias.Productos.Marca, musicasdB.Multimedias.Productos.Precio, GestionVendedores.BuscarPorId(musicasdB.Multimedias.Productos.IdVendedor), musicasdB.Multimedias.Productos.Descripcion, musicasdB.Multimedias.Productos.FechaPuestaVenta, musicasdB.Multimedias.Productos.CodigoDescuento,
                musicasdB.Multimedias.Productos.Stock,musicasdB.Multimedias.Genero, musicasdB.Multimedias.Formato,musicasdB.Multimedias.Idioma, musicasdB.Multimedias.FechaLanzamiento,musicasdB.Artista);
            return resul;
        }

        public static Musicas MapMusicasFromDTOToDB(Musica musicaDTO)
        {
            Musicas resul = new Musicas();

            if (resul.Multimedias == null)
            {
                resul.Multimedias = new Multimedias();
                if (resul.Multimedias.Productos == null)
                {
                    resul.Multimedias.Productos = new Model.Productos();
                }
            }

            resul.Artista = musicaDTO.Artista;
            resul.Multimedias.Genero = musicaDTO.Genero;
            resul.Multimedias.Formato = musicaDTO.Formato;
            resul.Multimedias.Idioma = musicaDTO.Idioma;
            resul.Multimedias.FechaLanzamiento = musicaDTO.FechaLanzamiento;
            resul.Multimedias.Productos.Nombre = musicaDTO.Nombre;
            resul.Multimedias.Productos.Precio = musicaDTO.Precio;
            resul.Multimedias.Productos.Marca = musicaDTO.Marca;
            resul.Multimedias.Productos.IdVendedor = musicaDTO.Vendedor.IdVendedor;
            resul.Multimedias.Productos.Descripcion = musicaDTO.Descripcion;
            resul.Multimedias.Productos.Valoracion = musicaDTO.Valoracion;
            resul.Multimedias.Productos.FechaPuestaVenta = musicaDTO.FechaPuestaVenta;
            resul.Multimedias.Productos.CodigoDescuento = musicaDTO.CodigoDescuento;
            resul.Multimedias.Productos.Stock = musicaDTO.Stock;
           

            return resul;
        }

        public static void AnnadirMusica(Musica musicaDTO)
        {

                Musicas nuevaMusica = MapMusicasFromDTOToDB(musicaDTO);
                DBComerce.DBAccess.Musicas.Add(nuevaMusica);

                DBComerce.DBAccess.SaveChangesAsync();

        }
    }
}
