using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        
            foreach(Vendedor vendedor in Vendedor){
            
                    if (vendedor.Nombre.Equals(nombreVendedorIngreso) &&
                        usuario.Password.Equals(contrasennaUsuarioIngreso))
                    {
                        UsuarioSesion = usuario;
                    }
                    
            }
        }

        public bool EliminarVendedor(string nombre,string pass){
        
            foreach(Vendedor vendedor in Vendedor){
            
                    if (vendedor.Nombre.Equals(nombreVendedorIngreso) &&
                        usuario.Password.Equals(contrasennaUsuarioIngreso))
                    {
                        UsuarioSesion = usuario;
                    }
                    
            }
        }




    }
}
