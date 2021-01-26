using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComercioDigital.DTOs.Productos;

namespace ComercioDigital.DTOs
{
    public class Almacen
    {
        private List<Producto> AlmacenProductos { get; set; }



        public bool AgregarProductoAlmacen(Producto producto)
        {
            if (producto != null)
            {
                AlmacenProductos.Add(producto);
                return true;
            }

            return false;
        }
    }
}
