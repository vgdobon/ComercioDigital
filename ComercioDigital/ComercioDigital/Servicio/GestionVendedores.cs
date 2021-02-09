using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComercioDigital.DTOs;
using ComercioDigital.DTOs.Personas;

namespace ComercioDigital.Servicio
{
    public class GestionVendedores
    {
        public List<Vendedor> Vendedores { get; set; }

        public GestionVendedores()
        {
            Vendedores = new List<Vendedor>();
        }

        public bool InsertarVendedor(Vendedor vendedor)

        {
            if (vendedor != null)
            {
                Vendedores.Add(vendedor);
                return true;
            }

            return false;
        }

        public bool AutentificarVendedor(string nombre,string pass){
        
            foreach(Vendedor vendedor in Vendedores){
            
                    if (vendedor.Nombre.Equals(nombre) &&
                        vendedor.Contrasenna.Equals(pass))
                    {
                        return true;
                    }
                    
            }

            return false;
        }

        public Vendedor SesionVendedor(string nombre, string pass)
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


        public bool EliminarVendedor(Vendedor vendedor){

            if (vendedor != null)
            {
                Vendedores.Remove(vendedor);
                return true;
            }

            return false;

        }

        public bool ModificarVendedor(Vendedor vendedor, string s, string campo)
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
