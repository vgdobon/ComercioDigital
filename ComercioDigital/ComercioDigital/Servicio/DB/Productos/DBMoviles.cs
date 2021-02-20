using ComercioDigital.DTOs.Productos.Tecnologia;
using ComercioDigital.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComercioDigital.Servicio.DB.Productos
{
    public static class DBMoviles
    {

        public static void CargarMovilesDB(eCommerceEntitiesDB DBAccess)
        {
            foreach (var VARIABLE in DBAccess.Moviles)
            {
                GestionComercio.CargarlistaBD(MapMovilesFromDBToDTO(VARIABLE));
            }
        }

        public static Movil MapMovilesFromDBToDTO(Moviles movilDB)
        {

            Movil resul = new Movil(movilDB.Tecnologicos.Productos.Id,movilDB.Tecnologicos.Productos.Nombre, movilDB.Tecnologicos.Productos.Marca, movilDB.Tecnologicos.Productos.Precio, GestionVendedores.BuscarPorId(movilDB.Tecnologicos.Productos.IdVendedor), movilDB.Tecnologicos.Productos.Descripcion, movilDB.Tecnologicos.Productos.FechaPuestaVenta, movilDB.Tecnologicos.Productos.CodigoDescuento,
                movilDB.Tecnologicos.Productos.Stock, movilDB.Tecnologicos.Color, movilDB.Tecnologicos.Procesador, movilDB.Tecnologicos.SistemaOperativo, movilDB.Tecnologicos.Modelo, movilDB.Tecnologicos.FechaLanzamiento,(float) movilDB.Pantalla,(int)movilDB.Bateria) ;
            return resul;
        }

        public static Moviles MapMovilesFromDTOToDB(Movil movilDTO)
        {
            Moviles resul = new Moviles();
            resul.Tecnologicos.Productos.Nombre = movilDTO.Nombre;
            resul.Tecnologicos.Productos.Precio = movilDTO.Precio;
            resul.Tecnologicos.Productos.Marca = movilDTO.Marca;
            resul.Tecnologicos.Productos.IdVendedor = movilDTO.Vendedor.IdVendedor;
            resul.Tecnologicos.Productos.Descripcion = movilDTO.Descripcion;
            resul.Tecnologicos.Productos.Valoracion = movilDTO.Valoracion;
            resul.Tecnologicos.Productos.FechaPuestaVenta = movilDTO.FechaPuestaVenta;
            resul.Tecnologicos.Productos.CodigoDescuento = movilDTO.CodigoDescuento;
            resul.Tecnologicos.Productos.Stock = movilDTO.Stock;
            resul.Tecnologicos.Color = movilDTO.Color;
            resul.Tecnologicos.Procesador = movilDTO.Procesador;
            resul.Tecnologicos.SistemaOperativo = movilDTO.SO;
            resul.Tecnologicos.Modelo = movilDTO.Modelo;
            resul.Tecnologicos.FechaLanzamiento = movilDTO.FechaLanzamiento;
            resul.Pantalla = movilDTO.Pantalla;
            resul.Bateria = movilDTO.Bateria;

            

            return resul;
        }
    }
}
