using ComercioDigital.DTOs.Personas;
using ComercioDigital.DTOs.Productos;
using ComercioDigital.Model;
using ComercioDigital.Servicio.DB.Productos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComercioDigital.Servicio.DB
{
    public static class DBProducto
    {
        public static void CargarProductosDB(eCommerceEntitiesDB DBAccess)
        {
            DBBolsos.CargarBolsosDB(DBAccess);
            DBCalzados.CargarCalzadosDB(DBAccess);
            DBJoyas.CargarJoyeriasDB(DBAccess);
            DBMoviles.CargarMovilesDB(DBAccess);
            DBMusicas.CargarMusicasDB(DBAccess);
            DBOrdenadores.CargarOrdenadoresDB(DBAccess);
            DBPeliculas.CargarPeliculasDB(DBAccess);
            DBRopas.CargarRopasDB(DBAccess);
            DBVideoConsolas.CargarVideoConsolasDB(DBAccess);
            DBVideoJuegos.CargarVideoJuegosDB(DBAccess);
        }



        public static void EliminarProducto(int id)
        {
            Model.Productos productoElminar = DBComerce.DBAccess.Productos.FirstOrDefault(x => x.Id == id);
            DBComerce.DBAccess.Productos.Remove(productoElminar);
            DBComerce.DBAccess.Entry(productoElminar).State = EntityState.Deleted;
            DBComerce.DBAccess.SaveChanges();
        }

        public static void EliminarProductosVendedor(Vendedor vendedorDto)
        {
            foreach (Model.Productos producto in DBComerce.DBAccess.Productos)
            {
                if(producto.Vendedores.Id == vendedorDto.IdVendedor)
                {
                    DBComerce.DBAccess.Productos.Remove(producto);
                    DBComerce.DBAccess.Entry(producto).State = EntityState.Deleted;
                    DBComerce.DBAccess.SaveChangesAsync();
                }
            }
        }

        public static Model.Productos BuscarPorId(int id)
        {
            return DBComerce.DBAccess.Productos.FirstOrDefault(
                x => x.Id == id);
        }

    }
}
