using ComercioDigital.DTOs.Productos.Moda;
using ComercioDigital.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComercioDigital.Servicio.DB.Productos
{
    public static class DBJoyas
    {

        public static void CargarJoyeriasDB(eCommerceEntitiesDB DBAccess)
        {
            foreach (var VARIABLE in DBAccess.Joyas)
            {
                GestionComercio.CargarlistaBD(MapJoyasFromDBToDTO(VARIABLE));
            }
        }

        public static Joyeria MapJoyasFromDBToDTO(Joyas joyasDB)
        {

            Joyeria resul = new Joyeria(joyasDB.Modas.Productos.Id, joyasDB.Modas.Productos.Nombre, joyasDB.Modas.Productos.Marca, joyasDB.Modas.Productos.Precio, GestionVendedores.BuscarPorId(joyasDB.Modas.Productos.IdVendedor), joyasDB.Modas.Productos.Descripcion, joyasDB.Modas.Productos.FechaPuestaVenta, joyasDB.Modas.Productos.CodigoDescuento,
                joyasDB.Modas.Productos.Stock, joyasDB.Modas.Color, joyasDB.Modas.Material, joyasDB.Modas.Sexo,joyasDB.Medida);
            return resul;
        }

        public static Joyas MapJoyasFromDTOToDB(Joyeria joyeriaDTO)
        {
            Joyas resul = new Joyas();
            if (resul.Modas == null)
            {
                resul.Modas = new Modas();
                if (resul.Modas.Productos == null)
                {
                    resul.Modas.Productos = new Model.Productos();
                }


            }
            resul.Modas.Productos.Nombre = joyeriaDTO.Nombre;
            resul.Modas.Productos.Precio = joyeriaDTO.Precio;
            resul.Modas.Productos.Marca = joyeriaDTO.Marca;
            resul.Modas.Productos.IdVendedor = joyeriaDTO.Vendedor.IdVendedor;
            resul.Modas.Productos.Descripcion = joyeriaDTO.Descripcion;
            resul.Modas.Productos.Valoracion = joyeriaDTO.Valoracion;
            resul.Modas.Productos.FechaPuestaVenta = joyeriaDTO.FechaPuestaVenta;
            resul.Modas.Productos.CodigoDescuento = joyeriaDTO.CodigoDescuento;
            resul.Modas.Productos.Stock = joyeriaDTO.Stock;
            resul.Modas.Color = joyeriaDTO.Color;
            resul.Modas.Material = joyeriaDTO.Material;
            resul.Modas.Sexo = joyeriaDTO.Sexo;
            resul.Medida = joyeriaDTO.Medida;

            return resul;
        }

        public static void AnnadirJoya(Joyeria joyeriaDTO)
        {

            Joyas nuevaJoya = MapJoyasFromDTOToDB(joyeriaDTO);
            DBComerce.DBAccess.Joyas.Add(nuevaJoya);
            DBComerce.DBAccess.SaveChangesAsync();

        }
    }
}
