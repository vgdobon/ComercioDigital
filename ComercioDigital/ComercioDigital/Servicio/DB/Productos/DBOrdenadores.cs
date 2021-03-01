using ComercioDigital.DTOs.Productos.Tecnologia;
using ComercioDigital.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComercioDigital.Servicio.DB.Productos
{
    public static class DBOrdenadores
    {
        public static void CargarOrdenadoresDB(eCommerceEntitiesDB DBAccess)
        {
            foreach (var VARIABLE in DBAccess.Ordenadores)
            {
                GestionComercio.CargarlistaBD(MapOrdenadoresFromDBToDTO(VARIABLE));
            }
        }

        public static Ordenador MapOrdenadoresFromDBToDTO(Ordenadores ordenadorDB)
        {

            Ordenador resul = new Ordenador(ordenadorDB.Tecnologicos.Productos.Id, ordenadorDB.Tecnologicos.Productos.Nombre, ordenadorDB.Tecnologicos.Productos.Marca, ordenadorDB.Tecnologicos.Productos.Precio, GestionVendedores.BuscarPorId(ordenadorDB.Tecnologicos.Productos.IdVendedor), ordenadorDB.Tecnologicos.Productos.Descripcion, ordenadorDB.Tecnologicos.Productos.FechaPuestaVenta, ordenadorDB.Tecnologicos.Productos.CodigoDescuento,
                ordenadorDB.Tecnologicos.Productos.Stock, ordenadorDB.Tecnologicos.Color, ordenadorDB.Tecnologicos.Procesador, ordenadorDB.Tecnologicos.SistemaOperativo, ordenadorDB.Tecnologicos.Modelo, ordenadorDB.Tecnologicos.FechaLanzamiento,ordenadorDB.PlacaBase,ordenadorDB.Tipo);
            return resul;
        }

        public static Ordenadores MapOrdenadoresFromDTOToDB(Ordenador ordenadorDTO)
        {
            Ordenadores resul = new Ordenadores();
            if (resul.Tecnologicos == null)
            {
                resul.Tecnologicos = new Tecnologicos();

                if (resul.Tecnologicos.Productos == null)
                {
                    resul.Tecnologicos.Productos = new Model.Productos();
                }

            }
            resul.Tecnologicos.Productos.Nombre = ordenadorDTO.Nombre;
            resul.Tecnologicos.Productos.Precio = ordenadorDTO.Precio;
            resul.Tecnologicos.Productos.Marca = ordenadorDTO.Marca;
            resul.Tecnologicos.Productos.IdVendedor = ordenadorDTO.Vendedor.IdVendedor;
            resul.Tecnologicos.Productos.Descripcion = ordenadorDTO.Descripcion;
            resul.Tecnologicos.Productos.Valoracion = ordenadorDTO.Valoracion;
            resul.Tecnologicos.Productos.FechaPuestaVenta = ordenadorDTO.FechaPuestaVenta;
            resul.Tecnologicos.Productos.CodigoDescuento = ordenadorDTO.CodigoDescuento;
            resul.Tecnologicos.Productos.Stock = ordenadorDTO.Stock;
            resul.Tecnologicos.Color = ordenadorDTO.Color;
            resul.Tecnologicos.Procesador = ordenadorDTO.Procesador;
            resul.Tecnologicos.SistemaOperativo = ordenadorDTO.SO;
            resul.Tecnologicos.Modelo = ordenadorDTO.Modelo;
            resul.Tecnologicos.FechaLanzamiento = ordenadorDTO.FechaLanzamiento;
            resul.PlacaBase = ordenadorDTO.PlacaBase;
            resul.Tipo = ordenadorDTO.Tipo;

            return resul;
        }

        public static void AnnadirOrdenador(Ordenador ordenadorDTO)
        {

            Ordenadores nuevoOrdenador = MapOrdenadoresFromDTOToDB(ordenadorDTO);
            DBComerce.DBAccess.Ordenadores.Add(nuevoOrdenador);
            DBComerce.DBAccess.Entry(nuevoOrdenador).State = System.Data.Entity.EntityState.Added;
            DBComerce.DBAccess.SaveChanges();

        }
    }
}
