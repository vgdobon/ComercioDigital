using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComercioDigital.DTOs.Personas;
using ComercioDigital.Model;

namespace ComercioDigital.Servicio.DB
{
    public static class DBVendedores
    {

        public static void CargarVendedoresDB(eCommerceEntitiesDB DBAccess)
        {
            foreach (var VARIABLE in DBAccess.Vendedores)
            {
                GestionVendedores.InsertarVendedor(MapVendedorFromDBToDTO(VARIABLE));
            }
        }

        public static Vendedor MapVendedorFromDBToDTO(Vendedores vendedorDB)
        {
            Vendedor resul = new Vendedor(vendedorDB.Nombre,vendedorDB.Direccion,vendedorDB.Contrasenna,vendedorDB.Id);



            return resul;
        }

        public static Vendedores MapVendedorFromDTOToDB(Vendedor vendedorDTO)
        {
            Vendedores resul = new Vendedores();
            resul.Nombre = vendedorDTO.Nombre;
            resul.Contrasenna = vendedorDTO.Contrasenna;
            resul.Direccion = vendedorDTO.Direccion;
            resul.Valoracion = vendedorDTO.Valoracion;

            return resul;
        }

        public static void AnnadirVendedorDB(Vendedor vendedorDTO)
        {
            Vendedores nuevoVendedor = MapVendedorFromDTOToDB(vendedorDTO);
            DBComerce.DBAccess.Vendedores.Add(nuevoVendedor);
            DBComerce.DBAccess.SaveChanges();
        }
    }
}
