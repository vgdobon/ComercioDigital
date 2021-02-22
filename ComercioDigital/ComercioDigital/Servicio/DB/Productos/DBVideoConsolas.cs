using ComercioDigital.DTOs.Productos.Tecnologia;
using ComercioDigital.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComercioDigital.Servicio.DB.Productos
{
    public static class DBVideoConsolas
    {
        public static void CargarVideoConsolasDB(eCommerceEntitiesDB DBAccess)
        {
            foreach (var VARIABLE in DBAccess.Videoconsolas)
            {
                GestionComercio.CargarlistaBD(MapVideoConsolasFromDBToDTO(VARIABLE));
            }
        }

        public static VideoConsola MapVideoConsolasFromDBToDTO(Videoconsolas videoConsolaDB)
        {

            VideoConsola resul = new VideoConsola(videoConsolaDB.Tecnologicos.Productos.Id, videoConsolaDB.Tecnologicos.Productos.Nombre, videoConsolaDB.Tecnologicos.Productos.Marca, videoConsolaDB.Tecnologicos.Productos.Precio, GestionVendedores.BuscarPorId(videoConsolaDB.Tecnologicos.Productos.IdVendedor), videoConsolaDB.Tecnologicos.Productos.Descripcion, videoConsolaDB.Tecnologicos.Productos.FechaPuestaVenta, videoConsolaDB.Tecnologicos.Productos.CodigoDescuento,
                videoConsolaDB.Tecnologicos.Productos.Stock, videoConsolaDB.Tecnologicos.Color, videoConsolaDB.Tecnologicos.Procesador, videoConsolaDB.Tecnologicos.SistemaOperativo, videoConsolaDB.Tecnologicos.Modelo, videoConsolaDB.Tecnologicos.FechaLanzamiento);
            return resul;
        }

        public static Videoconsolas MapVideoConsolasFromDTOToDB(VideoConsola videoconsolaDTO)
        {
            Videoconsolas resul = new Videoconsolas();
            if(resul.Tecnologicos == null)
            {
                resul.Tecnologicos = new Tecnologicos();

                if (resul.Tecnologicos.Productos == null)
                {
                    resul.Tecnologicos.Productos = new Model.Productos();
                }

            }
            resul.Tecnologicos.Productos.Nombre = videoconsolaDTO.Nombre;
            resul.Tecnologicos.Productos.Precio = videoconsolaDTO.Precio;
            resul.Tecnologicos.Productos.Marca = videoconsolaDTO.Marca;
            resul.Tecnologicos.Productos.IdVendedor = videoconsolaDTO.Vendedor.IdVendedor;
            resul.Tecnologicos.Productos.Descripcion = videoconsolaDTO.Descripcion;
            resul.Tecnologicos.Productos.Valoracion = videoconsolaDTO.Valoracion;
            resul.Tecnologicos.Productos.FechaPuestaVenta = videoconsolaDTO.FechaPuestaVenta;
            resul.Tecnologicos.Productos.CodigoDescuento = videoconsolaDTO.CodigoDescuento;
            resul.Tecnologicos.Productos.Stock = videoconsolaDTO.Stock;
            resul.Tecnologicos.Color = videoconsolaDTO.Color;
            resul.Tecnologicos.Procesador = videoconsolaDTO.Procesador;
            resul.Tecnologicos.SistemaOperativo = videoconsolaDTO.SO;
            resul.Tecnologicos.Modelo = videoconsolaDTO.Modelo;
            resul.Tecnologicos.FechaLanzamiento = videoconsolaDTO.FechaLanzamiento;

            return resul;
        }

        public static void AnnadirVideoConsola(VideoConsola videoconsolaDTO)
        {

            Videoconsolas nuevaVideoConsola= MapVideoConsolasFromDTOToDB(videoconsolaDTO);
            DBComerce.DBAccess.Videoconsolas.Add(nuevaVideoConsola);

            DBComerce.DBAccess.SaveChangesAsync();

        }

    }
}
