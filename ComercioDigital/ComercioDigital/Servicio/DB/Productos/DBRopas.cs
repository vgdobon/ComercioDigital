using ComercioDigital.DTOs.Productos.Moda;
using ComercioDigital.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComercioDigital.Servicio.DB.Productos
{
    public static class DBRopas
    {
        public static void CargarRopasDB(eCommerceEntitiesDB DBAccess)
        {
            foreach (var VARIABLE in DBAccess.Ropas)
            {
                GestionComercio.CargarlistaBD(MapRopasFromDBToDTO(VARIABLE));
            }
        }

        public static Ropa MapRopasFromDBToDTO(Ropas ropaDB)
        {

            Ropa resul = new Ropa(ropaDB.Modas.Productos.Id, ropaDB.Modas.Productos.Nombre, ropaDB.Modas.Productos.Marca, ropaDB.Modas.Productos.Precio, GestionVendedores.BuscarPorId(ropaDB.Modas.Productos.IdVendedor), ropaDB.Modas.Productos.Descripcion, ropaDB.Modas.Productos.FechaPuestaVenta, ropaDB.Modas.Productos.CodigoDescuento,
                ropaDB.Modas.Productos.Stock, ropaDB.Modas.Color, ropaDB.Modas.Material, ropaDB.Modas.Sexo,ropaDB.Talla,ropaDB.Tipo);
            return resul;
        }

        public static Ropas MapRopasFromDTOToDB(Ropa ropaDTO)
        {
            Ropas resul = new Ropas();
            if (resul.Modas == null)
            {
                resul.Modas = new Modas();
                if (resul.Modas.Productos == null)
                {
                    resul.Modas.Productos = new Model.Productos();
                }


            }
            resul.Modas.Productos.Nombre = ropaDTO.Nombre;
            resul.Modas.Productos.Precio = ropaDTO.Precio;
            resul.Modas.Productos.Marca = ropaDTO.Marca;
            resul.Modas.Productos.IdVendedor = ropaDTO.Vendedor.IdVendedor;
            resul.Modas.Productos.Descripcion = ropaDTO.Descripcion;
            resul.Modas.Productos.Valoracion = ropaDTO.Valoracion;
            resul.Modas.Productos.FechaPuestaVenta = ropaDTO.FechaPuestaVenta;
            resul.Modas.Productos.CodigoDescuento = ropaDTO.CodigoDescuento;
            resul.Modas.Productos.Stock = ropaDTO.Stock;
            resul.Modas.Color = ropaDTO.Color;
            resul.Modas.Material = ropaDTO.Material;
            resul.Modas.Sexo = ropaDTO.Sexo;
            resul.Talla = ropaDTO.Talla;
            resul.Tipo = ropaDTO.Tipo;

            return resul;
        }

        public static void AnnadirRopa(Ropa ropaDTO)
        {

            Ropas nuevoRopa = MapRopasFromDTOToDB(ropaDTO);
            DBComerce.DBAccess.Ropas.Add(nuevoRopa);
            DBComerce.DBAccess.Entry(nuevoRopa).State = System.Data.Entity.EntityState.Added;
            DBComerce.DBAccess.SaveChanges(); ;

        }
    }
}
