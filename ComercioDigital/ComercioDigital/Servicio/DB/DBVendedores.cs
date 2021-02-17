using System;
using System.Collections.Generic;
using System.Data.Entity;
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
                GestionVendedores.CargarlistaBD(MapVendedorFromDBToDTO(VARIABLE));
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
            resul.Id = vendedorDTO.IdVendedor;
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
            DBComerce.DBAccess.SaveChangesAsync();
            
        }

        public static Vendedores BuscarPorId(int id)

        {
            return DBComerce.DBAccess.Vendedores.FirstOrDefault(
                x => x.Id == id);
        }

        public static void EliminarVendedor(int id)
        {
            Vendedores vendedorDB = BuscarPorId(id);
            DBComerce.DBAccess.Vendedores.Remove(vendedorDB);
            DBComerce.DBAccess.Entry(vendedorDB).State = EntityState.Deleted;
            DBComerce.DBAccess.SaveChanges();
        }

        public static void ModificarVendedor(Vendedor vendedorDTO)
        {
            Vendedores vendedorDB = BuscarPorId(vendedorDTO.IdVendedor);
            int idBorrar = vendedorDTO.IdVendedor;
            vendedorDB = MapVendedorFromDTOToDB(vendedorDTO);
            DBComerce.DBAccess.Entry(vendedorDB).State = System.Data.Entity.EntityState.Added;
            EliminarVendedor(idBorrar);
            DBComerce.DBAccess.SaveChanges();
        }

        //public static bool IdentificarUsuario(string nombre,string contrasena)
        //{
        //    foreach(Vendedores vendedores in DBComerce.DBAccess.Vendedores)
        //    {
        //        if (vendedores.Contrasenna.Equals(contrasena)
        //            && vendedores.Nombre.Equals(nombre)) 
        //        { 
        //            return true;        
        //        }
                   
        //    }
        //    return false;
        //}
            
            



    }
}
