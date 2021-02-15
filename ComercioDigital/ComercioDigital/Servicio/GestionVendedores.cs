using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComercioDigital.DTOs;
using ComercioDigital.DTOs.Personas;

namespace ComercioDigital.Servicio
{
    public static class GestionVendedores
    {
        public static List<Vendedor> Vendedores { get; set; } = new List<Vendedor>();

        public static bool InsertarVendedor(Vendedor vendedor)

        {
            if (vendedor != null)
            {
                Vendedores.Add(vendedor);
                return true;
            }

            return false;
        }

        public static bool AutentificarVendedor(string nombre,string pass){
        
            foreach(Vendedor vendedor in Vendedores){
            
                    if (vendedor.Nombre.Equals(nombre) &&
                        vendedor.Contrasenna.Equals(pass))
                    {
                        return true;
                    }
                    
            }

            return false;
        }

        public static Vendedor SesionVendedor(string nombre, string pass)
        {
            Vendedor vendedorSesion = null;

            foreach (Vendedor vendedor in Vendedores)
            {

                if (vendedor.Nombre.Equals(nombre) &&
                    vendedor.Contrasenna.Equals(pass))
                {
                    vendedorSesion = vendedor;
                }

            }

            return vendedorSesion;
        }


        public static bool EliminarVendedor(Vendedor vendedor){

            if (vendedor != null)
            {
                Vendedores.Remove(vendedor);
                return true;
            }

            return false;

        }

        public static bool ModificarVendedor(Vendedor vendedor, string s, string campo)
        {
            if (campo.Equals("nombre"))
            {
                vendedor.Nombre = s;
                return true;
            }
            else if (campo.Equals("contraseña"))
            {
                vendedor.Contrasenna = s;
                return true;
            }

            return false;
        }




    }
}
