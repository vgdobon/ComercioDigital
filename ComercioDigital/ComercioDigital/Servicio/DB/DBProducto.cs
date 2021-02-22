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

            DBComerce.DBAccess.Productos.Remove(DBComerce.DBAccess.Productos.FirstOrDefault(x => x.Id == id));
        }

    }
}
