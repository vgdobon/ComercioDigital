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
    }
}
