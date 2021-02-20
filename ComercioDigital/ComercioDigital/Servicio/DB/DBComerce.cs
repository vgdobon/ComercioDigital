using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComercioDigital.Model;

namespace ComercioDigital.Servicio.DB
{
    public static class DBComerce
    {

        public static eCommerceEntitiesDB DBAccess { get; set; } = new eCommerceEntitiesDB();

     
        public static void CargarDB()
        {
            DBVendedores.CargarVendedoresDB(DBAccess);
            DBUsuarios.CargarUsuariosDB(DBAccess);
            DBProducto.CargarProductosDB(DBAccess);

        }
    }
}
