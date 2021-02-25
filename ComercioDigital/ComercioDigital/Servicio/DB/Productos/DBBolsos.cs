using ComercioDigital.DTOs.Productos.Moda;
using ComercioDigital.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComercioDigital.Servicio.DB.Productos
{
    public static class DBBolsos
    {

        public static void CargarBolsosDB(eCommerceEntitiesDB DBAccess)
        {
            foreach (var VARIABLE in DBAccess.Bolsos)
            {
                GestionComercio.CargarlistaBD(MapBolsosFromDBToDTO(VARIABLE));
            }
        }

        public static Bolso MapBolsosFromDBToDTO(Bolsos bolsoDB)
        {

            Bolso resul = new Bolso(bolsoDB.Modas.Productos.Id, bolsoDB.Modas.Productos.Nombre, bolsoDB.Modas.Productos.Marca, bolsoDB.Modas.Productos.Precio, GestionVendedores.BuscarPorId(bolsoDB.Modas.Productos.IdVendedor), bolsoDB.Modas.Productos.Descripcion, bolsoDB.Modas.Productos.FechaPuestaVenta, bolsoDB.Modas.Productos.CodigoDescuento,
                bolsoDB.Modas.Productos.Stock, bolsoDB.Modas.Color, bolsoDB.Modas.Material, bolsoDB.Modas.Sexo, bolsoDB.Tipo);
            return resul;
        }

        public static Bolsos MapBolsosFromDTOToDB(Bolso bolsoDTO)
        {
            Bolsos resul = new Bolsos();
            if (resul.Modas == null)
            {
                resul.Modas = new Modas();
                if (resul.Modas.Productos == null)
                {
                    resul.Modas.Productos = new Model.Productos();
                }


            }

            resul.Modas.Productos.Nombre = bolsoDTO.Nombre;
            resul.Modas.Productos.Precio = bolsoDTO.Precio;
            resul.Modas.Productos.Marca = bolsoDTO.Marca;
            resul.Modas.Productos.IdVendedor = bolsoDTO.Vendedor.IdVendedor;
            resul.Modas.Productos.Descripcion = bolsoDTO.Descripcion;
            resul.Modas.Productos.Valoracion = bolsoDTO.Valoracion;
            resul.Modas.Productos.FechaPuestaVenta = bolsoDTO.FechaPuestaVenta;
            resul.Modas.Productos.CodigoDescuento = bolsoDTO.CodigoDescuento;
            resul.Modas.Productos.Stock = bolsoDTO.Stock;
            resul.Modas.Color = bolsoDTO.Color;
            resul.Modas.Material = bolsoDTO.Material;
            resul.Modas.Sexo = bolsoDTO.Sexo;
            resul.Tipo = bolsoDTO.Tipo;

            return resul;
        }

        public static void AnnadirBolso(Bolso bolsoDTO)
        {
            Bolsos nuevoBolso = MapBolsosFromDTOToDB(bolsoDTO);
            DBComerce.DBAccess.Bolsos.Add(nuevoBolso);
            DBComerce.DBAccess.Entry(nuevoBolso).State = System.Data.Entity.EntityState.Added;
            DBComerce.DBAccess.SaveChanges();
        }

    }
}
