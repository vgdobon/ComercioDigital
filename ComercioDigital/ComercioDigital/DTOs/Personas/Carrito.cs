using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComercioDigital.DTOs.Productos;

namespace ComercioDigital.DTOs.Personas
{
    public class Carrito
    {

        public List<Producto> CarritoCompra { get; set; }
        public int IdCarrito { get; set; }
        public Carrito()
        {
            CarritoCompra = new List<Producto>();
        }
    }
}
